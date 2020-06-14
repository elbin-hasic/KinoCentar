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

namespace KinoCentar.WinUI.Forms.Artikli
{
    public partial class frmArtikli : Form
    {
        private WebAPIHelper artikliService = new WebAPIHelper(Global.API_ADDRESS, Global.ArtikliRoute);

        public frmArtikli()
        {
            InitializeComponent();
            dgvAtikli.AutoGenerateColumns = false;
        }

        private void frmArtikli_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid(string name = null)
        {
            var response = artikliService.GetActionResponse("SearchByName", name).Handle();
            if (response.IsSuccessStatusCode)
            {
                dgvAtikli.DataSource = response.GetResponseResult<List<ArtikalModel>>();
                dgvAtikli.ClearSelection();
            }
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            BindGrid(txtNazivPretraga.Text.Trim());
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            var frm = new frmArtikliAdd();
            frm.ShowDialog();
            BindGrid();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frmArtikliEdit(Convert.ToInt32(dgvAtikli.SelectedRows[0].Cells[0].Value));
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
                var id = Convert.ToInt32(dgvAtikli.SelectedRows[0].Cells[0].Value);

                DialogResult result = MessageBox.Show(Messages.del_artikal_prompt, Messages.msg_conf, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    HttpResponseMessage response = artikliService.DeleteResponse(id).Handle();
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(Messages.del_artikal_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindGrid();
                    }
                }
            }
            catch
            {}
        }
    }
}
