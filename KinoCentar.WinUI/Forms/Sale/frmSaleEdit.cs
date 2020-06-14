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

namespace KinoCentar.WinUI.Forms.Sale
{
    public partial class frmSaleEdit : Form
    {
        private WebAPIHelper saleService = new WebAPIHelper(Global.API_ADDRESS, Global.SaleRoute);

        private int _id { get; set; }
        private SalaModel _sala { get; set; }

        public frmSaleEdit(int id)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

            _id = id;
            _sala = null;
        }

        private void frmSaleEdit_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = saleService.GetResponse(_id.ToString()).Handle();
            if (response.IsSuccessStatusCode)
            {
                _sala = response.GetResponseResult<SalaModel>();
                FillForm();
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                _sala = null;
            }
        }

        private void FillForm()
        {
            txtNaziv.Text = _sala.Naziv;
            txtBrojSjedista.Text = _sala.BrojSjedista != null ? _sala.BrojSjedista.ToString() : "0";
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (_sala != null && this.ValidateChildren())
            {
                _sala.Naziv = txtNaziv.Text;
                _sala.BrojSjedista = int.Parse(txtBrojSjedista.Text);

                HttpResponseMessage response = saleService.PutResponse(_id, _sala).Handle();
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.edit_sale_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                errorProvider.SetError(txtNaziv, Messages.sale_name_req);
            }
            else if (txtNaziv.TextLength < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(txtNaziv, Messages.sale_name_err);
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
