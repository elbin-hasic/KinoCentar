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

namespace KinoCentar.WinUI.Forms.FilmskeLicnosti
{
    public partial class frmFilmskeLicnostiEdit : Form
    {
        private WebAPIHelper filmskeLicnostiService = new WebAPIHelper(Global.ApiAddress, Global.FilmskeLicnostiRoute, Global.PrijavljeniKorisnik);

        private int _id { get; set; }
        private FilmskaLicnostModel _filmskaLicnost { get; set; }

        public frmFilmskeLicnostiEdit(int id)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

            _id = id;
            _filmskaLicnost = null;
        }

        private void frmFilmskeLicnostiEdit_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = filmskeLicnostiService.GetResponse(_id.ToString()).Handle();
            if (response.IsSuccessStatusCode)
            {
                _filmskaLicnost = response.GetResponseResult<FilmskaLicnostModel>();
                FillForm();
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                _filmskaLicnost = null;
            }
        }

        private void FillForm()
        {
            txtIme.Text = _filmskaLicnost.Ime;
            txtPrezime.Text = _filmskaLicnost.Prezime;
            ckbIsGlumac.Checked = _filmskaLicnost.IsGlumac;
            ckbIsReziser.Checked = _filmskaLicnost.IsReziser;
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (_filmskaLicnost != null && this.ValidateChildren())
            {
                _filmskaLicnost.Ime = txtIme.Text;
                _filmskaLicnost.Prezime = txtPrezime.Text;
                _filmskaLicnost.IsGlumac = ckbIsGlumac.Checked;
                _filmskaLicnost.IsReziser = ckbIsReziser.Checked;

                HttpResponseMessage response = filmskeLicnostiService.PutResponse(_id, _filmskaLicnost).Handle();
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.edit_filmskaLicnost_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtIme.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtIme, Messages.filmskeLicnosti_name_req);
            }
            else
            {
                errorProvider.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrezime.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPrezime, Messages.filmskeLicnosti_lastname_req);
            }
            else
            {
                errorProvider.SetError(txtPrezime, null);
            }
        }

        #endregion
    }
}
