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

namespace KinoCentar.WinUI.Forms.Zanrovi
{
    public partial class frmZanroviEdit : Form
    {
        private WebAPIHelper zanroviService = new WebAPIHelper(Global.API_ADDRESS, Global.ZanroviRoute);

        private int _id { get; set; }
        private ZanrModel _zanr { get; set; }

        public frmZanroviEdit(int id)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

            _id = id;
            _zanr = null;
        }

        private void frmZanroviEdit_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = zanroviService.GetResponse(_id.ToString()).Handle();
            if (response.IsSuccessStatusCode)
            {
                _zanr = response.GetResponseResult<ZanrModel>();
                FillForm();
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                _zanr = null;
            }
        }

        private void FillForm()
        {
            txtNaziv.Text = _zanr.Naziv;
            txtOpis.Text = _zanr.Opis;
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (_zanr != null && this.ValidateChildren())
            {
                _zanr.Naziv = txtNaziv.Text;
                _zanr.Opis = txtOpis.Text;

                HttpResponseMessage response = zanroviService.PutResponse(_id, _zanr).Handle();
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.edit_genre_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                errorProvider.SetError(txtNaziv, Messages.genre_name_req);
            }
            else if (txtNaziv.TextLength < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(txtNaziv, Messages.genre_name_err);
            }
            else
            {
                errorProvider.SetError(txtNaziv, null);
            }
        }

        #endregion
    }
}
