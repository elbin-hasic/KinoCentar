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
using KinoCentar.Shared.Extensions;

namespace KinoCentar.WinUI.Forms.JediniceMjere
{
    public partial class frmJediniceMjere : Form
    {
        private WebAPIHelper jediniceMjereService = new WebAPIHelper(Global.ApiAddress, Global.JediniceMjereRoute, Global.PrijavljeniKorisnik);

        public frmJediniceMjere()
        {
            InitializeComponent();
            dgvJediniceMjere.AutoGenerateColumns = false;
        }

        private void frmJediniceMjere_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid(string name = null)
        {
            var response = jediniceMjereService.GetActionResponse("SearchByName", name).Handle();            
            if (response.IsSuccessStatusCode)
            {
                dgvJediniceMjere.DataSource = response.GetResponseResult<List<JedinicaMjereModel>>();
                dgvJediniceMjere.ClearSelection();
            }
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            BindGrid(txtNazivPretraga.Text.Trim());
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            var frm = new frmJediniceMjereAdd();
            frm.ShowDialog();
            BindGrid();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frmJediniceMjereEdit(Convert.ToInt32(dgvJediniceMjere.SelectedRows[0].Cells[0].Value));
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
                var id = Convert.ToInt32(dgvJediniceMjere.SelectedRows[0].Cells[0].Value);

                DialogResult result = MessageBox.Show(Messages.del_jedMjere_prompt, Messages.msg_conf, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var response = jediniceMjereService.DeleteResponse(id).Handle();
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(Messages.del_jedMjere_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindGrid();
                    }
                }
            }
            catch
            {}            
        }
    }
}
