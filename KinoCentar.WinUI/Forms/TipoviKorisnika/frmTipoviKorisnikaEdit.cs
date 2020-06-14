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

namespace KinoCentar.WinUI.Forms.TipoviKorisnika
{
    public partial class frmTipoviKorisnikaEdit : Form
    {
        private WebAPIHelper tipoviKorisnikaService = new WebAPIHelper(Global.API_ADDRESS, Global.TipoviKorisnikaRoute);

        private int _id { get; set; }
        private TipKorisnikaModel _tipKorisnika { get; set; }

        public frmTipoviKorisnikaEdit(int id)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

            _id = id;
            _tipKorisnika = null;
        }

        private void frmTipoviKorisnikaEdit_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = tipoviKorisnikaService.GetResponse(_id.ToString()).Handle();
            if (response.IsSuccessStatusCode)
            {
                _tipKorisnika = response.GetResponseResult<TipKorisnikaModel>();
                FillForm();
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                _tipKorisnika = null;
            }
        }

        private void FillForm()
        {
            txtNaziv.Text = _tipKorisnika.Naziv;
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (_tipKorisnika != null && this.ValidateChildren())
            {
                _tipKorisnika.Naziv = txtNaziv.Text;

                HttpResponseMessage response = tipoviKorisnikaService.PutResponse(_id, _tipKorisnika).Handle();
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.edit_tipKorisnika_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (String.IsNullOrEmpty(txtNaziv.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNaziv, Messages.tipKorisnika_name_req);
            }
            else if (txtNaziv.TextLength < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(txtNaziv, Messages.tipKorisnika_name_err);
            }
            else
            {
                errorProvider.SetError(txtNaziv, null);
            }
        }

        #endregion
    }
}
