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

namespace KinoCentar.WinUI.Forms.Prodaja
{
    public partial class frmProdaja : Form
    {
        private WebAPIHelper prodajaService = new WebAPIHelper(Global.ApiAddress, Global.ProdajaRoute, Global.PrijavljeniKorisnik);

        public frmProdaja()
        {
            InitializeComponent();
            dgvProdaja.AutoGenerateColumns = false;
        }

        private void frmProdaja_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid(string number = null)
        {
            var response = prodajaService.GetActionResponse("SearchByNumber", number).Handle();
            if (response.IsSuccessStatusCode)
            {
                dgvProdaja.DataSource = response.GetResponseResult<List<ProdajaModel>>();
                dgvProdaja.ClearSelection();
            }
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            BindGrid(txtBrojRacunaPretraga.Text.Trim());
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            var frm = new frmProdajaAdd();
            frm.ShowDialog();
            BindGrid();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frmProdajaDetails(Convert.ToInt32(dgvProdaja.SelectedRows[0].Cells[0].Value));
                frm.ShowDialog();
                BindGrid();
            }
            catch
            { }
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(dgvProdaja.SelectedRows[0].Cells[0].Value);

                DialogResult result = MessageBox.Show(Messages.del_prodaja_prompt, Messages.msg_conf, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    HttpResponseMessage response = prodajaService.DeleteResponse(id).Handle();
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(Messages.del_prodaja_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindGrid();
                    }
                }
            }
            catch
            {}
        }
    }
}
