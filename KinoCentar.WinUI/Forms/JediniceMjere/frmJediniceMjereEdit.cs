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

namespace KinoCentar.WinUI.Forms.JediniceMjere
{
    public partial class frmJediniceMjereEdit : Form
    {
        private WebAPIHelper jediniceMjereService = new WebAPIHelper(Global.API_ADDRESS, Global.JediniceMjereRoute);

        private int _id { get; set; }
        private JedinicaMjereModel _jedMjere { get; set; }

        public frmJediniceMjereEdit(int id)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

            _id = id;
            _jedMjere = null;
        }

        private void frmJediniceMjereEdit_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = jediniceMjereService.GetResponse(_id.ToString()).Handle();
            if (response.IsSuccessStatusCode)
            {
                _jedMjere = response.GetResponseResult<JedinicaMjereModel>();
                FillForm();
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                _jedMjere = null;
            }
        }

        private void FillForm()
        {
            txtNaziv.Text = _jedMjere.Naziv;
            txtKratkiNaziv.Text = _jedMjere.KratkiNaziv;
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (_jedMjere != null && this.ValidateChildren())
            {
                _jedMjere.Naziv = txtNaziv.Text;
                _jedMjere.KratkiNaziv = txtKratkiNaziv.Text;

                HttpResponseMessage response = jediniceMjereService.PutResponse(_id, _jedMjere).Handle();
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.edit_jedMjere_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtKratkiNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtKratkiNaziv.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtKratkiNaziv, Messages.jedMjere_shortName_err);
            }
            else
            {
                errorProvider.SetError(txtKratkiNaziv, null);
            }
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtNaziv.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNaziv, Messages.jedMjere_name_req);
            }
            else if (txtNaziv.TextLength < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(txtNaziv, Messages.jedMjere_name_err);
            }
            else
            {
                errorProvider.SetError(txtNaziv, null);
            }
        }

        #endregion
    }
}
