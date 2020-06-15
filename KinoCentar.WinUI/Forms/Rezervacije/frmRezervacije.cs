using KinoCentar.Shared.Models;
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

namespace KinoCentar.WinUI.Forms.Rezervacije
{
    public partial class frmRezervacije : Form
    {
        private WebAPIHelper rezervacijeService = new WebAPIHelper(Global.ApiAddress, Global.RezervacijeRoute);

        public frmRezervacije()
        {
            InitializeComponent();
            dgvRezervacije.AutoGenerateColumns = false;
        }

        private void frmRezervacije_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid(string name = null)
        {
            var response = rezervacijeService.GetActionResponse("SearchByName", name).Handle();
            if (response.IsSuccessStatusCode)
            {
                dgvRezervacije.DataSource = response.GetResponseResult<List<RezervacijaModel>>();
                dgvRezervacije.ClearSelection();
            }
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            BindGrid(txtNaslovPretraga.Text.Trim());
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            var frm = new frmRezervacijeAdd();
            frm.ShowDialog();
            BindGrid();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frmRezervacijeEdit(Convert.ToInt32(dgvRezervacije.SelectedRows[0].Cells[0].Value));
                frm.ShowDialog();
                BindGrid();
            }
            catch
            {}
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(dgvRezervacije.SelectedRows[0].Cells[0].Value);

                DialogResult result = MessageBox.Show(Messages.disable_rezervacija_prompt, Messages.msg_conf, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    HttpResponseMessage response = rezervacijeService.PutActionResponse("disable", id).Handle();
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(Messages.disable_rezervacija_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindGrid();
                    }
                }
            }
            catch
            { }
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(dgvRezervacije.SelectedRows[0].Cells[0].Value);

                DialogResult result = MessageBox.Show(Messages.del_rezervacija_prompt, Messages.msg_conf, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    HttpResponseMessage response = rezervacijeService.DeleteResponse(id).Handle();
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(Messages.del_rezervacija_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindGrid();
                    }
                }
            }
            catch
            {}
        }
    }
}
