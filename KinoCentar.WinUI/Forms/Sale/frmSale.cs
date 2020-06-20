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

namespace KinoCentar.WinUI.Forms.Sale
{
    public partial class frmSale : Form
    {
        private WebAPIHelper saleService = new WebAPIHelper(Global.ApiAddress, Global.SaleRoute, Global.PrijavljeniKorisnik);

        public frmSale()
        {
            InitializeComponent();
            dgvSale.AutoGenerateColumns = false;
        }

        private void frmSale_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid(string name = null)
        {
            var response = saleService.GetActionResponse("SearchByName", name).Handle();            
            if (response.IsSuccessStatusCode)
            {
                dgvSale.DataSource = response.GetResponseResult<List<SalaModel>>();
                dgvSale.ClearSelection();
            }
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            BindGrid(txtNazivPretraga.Text.Trim());
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            frmSaleAdd frm = new frmSaleAdd();
            frm.ShowDialog();
            BindGrid();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            try
            {
                frmSaleEdit frm = new frmSaleEdit(Convert.ToInt32(dgvSale.SelectedRows[0].Cells[0].Value));
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
                var id = Convert.ToInt32(dgvSale.SelectedRows[0].Cells[0].Value);

                DialogResult result = MessageBox.Show(Messages.del_sale_prompt, Messages.msg_conf, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var response = saleService.DeleteResponse(id).Handle();
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(Messages.del_sale_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindGrid();
                    }
                }
            }
            catch
            { }
        }
    }
}
