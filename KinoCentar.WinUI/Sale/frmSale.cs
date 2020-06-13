using KinoCentar.PCL.Models;
using KinoCentar.PCL.Util;
using KinoCentar.Shared.Models;
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

namespace KinoCentar.WinUI.Sale
{
    public partial class frmSale : Form
    {
        private WebAPIHelper saleService = new WebAPIHelper(Global.API_ADDRESS, Global.SaleRoute);

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
            HttpResponseMessage response = saleService.GetActionResponse("SearchByName", name);

            if (response.IsSuccessStatusCode)
            {
                var jsonObject = response.Content.ReadAsStringAsync();
                List<Sala> sale = JsonConvert.DeserializeObject<List<Sala>>(jsonObject.Result);
                dgvSale.DataSource = sale;
                dgvSale.ClearSelection();
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
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
            frmSaleEdit frm = new frmSaleEdit(Convert.ToInt32(dgvSale.SelectedRows[0].Cells[0].Value));
            frm.ShowDialog();
            BindGrid();
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgvSale.SelectedRows[0].Cells[0].Value);

            DialogResult result = MessageBox.Show(Messages.del_sale_prompt, Messages.msg_conf, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                HttpResponseMessage response = saleService.DeleteResponse(id);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.del_sale_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindGrid();
                }
                else
                {
                    MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
                }
            }
        }
    }
}
