using KinoCentar.PCL.Models;
using KinoCentar.PCL.Util;
using KinoCentar.Shared.Models;
using KinoCentar.WinUI.Extensions;
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
    public partial class frmSaleAdd : Form
    {
        private WebAPIHelper saleService = new WebAPIHelper(Global.API_ADDRESS, Global.SaleRoute);

        public frmSaleAdd()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                Sala sala = new Sala();
                sala.Naziv = txtNaziv.Text;
                sala.BrojSjedista = int.Parse(txtBrojSjedista.Text);

                HttpResponseMessage response = saleService.PostResponse(sala).Handle();
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.add_sale_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(Messages.msg_cancel_que, Messages.msg_conf, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        #region Validation

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNaziv.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNaziv, Messages.sale_name_err);
            }
            else if (txtNaziv.TextLength < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(txtNaziv, Messages.sale_name_req);
            }
            else
            {
                errorProvider.SetError(txtNaziv, null);
            }
        }

        private void txtBrojSjedista_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBrojSjedista.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtBrojSjedista, Messages.sale_brojSjedista_req);
            }
            else
            {
                errorProvider.SetError(txtBrojSjedista, null);
            }
        }

        #endregion
    }
}
