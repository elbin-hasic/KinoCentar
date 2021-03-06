﻿using KinoCentar.Shared.Models;
using KinoCentar.Shared.Util;
using KinoCentar.WinUI.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KinoCentar.Shared.Extensions;

namespace KinoCentar.WinUI.Forms.Projekcije
{
    public partial class frmProjekcije : Form
    {
        private WebAPIHelper projekcijeService = new WebAPIHelper(Global.ApiAddress, Global.ProjekcijeRoute, Global.PrijavljeniKorisnik);

        public frmProjekcije()
        {
            InitializeComponent();
            dgvProjekcije.AutoGenerateColumns = false;
        }

        private void frmProjekcije_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid(string name = null)
        {
            var response = projekcijeService.GetActionResponse("SearchByName", name).Handle();
            if (response.IsSuccessStatusCode)
            {
                dgvProjekcije.DataSource = response.GetResponseResult<List<ProjekcijaModel>>();
                dgvProjekcije.ClearSelection();
            }
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            BindGrid(txtNaslovPretraga.Text.Trim());
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            var frm = new frmProjekcijeAdd();
            frm.ShowDialog();
            BindGrid();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frmProjekcijeEdit(Convert.ToInt32(dgvProjekcije.SelectedRows[0].Cells[0].Value));
                frm.ShowDialog();
                BindGrid();
            }
            catch
            {}
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(dgvProjekcije.SelectedRows[0].Cells[0].Value);

                DialogResult result = MessageBox.Show(Messages.del_projekcija_prompt, Messages.msg_conf, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    HttpResponseMessage response = projekcijeService.DeleteResponse(id).Handle();
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(Messages.del_projekcija_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindGrid();
                    }
                }
            }
            catch
            {}
        }
    }
}
