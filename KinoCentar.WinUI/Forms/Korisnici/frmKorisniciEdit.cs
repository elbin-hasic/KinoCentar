using KinoCentar.Shared.Models;
using KinoCentar.Shared.Util;
using KinoCentar.WinUI.Util;
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
using System.Net.Mail;
using KinoCentar.Shared.Extensions;
using KinoCentar.Shared.Models.Enums;

namespace KinoCentar.WinUI.Forms.Korisnici
{
    public partial class frmKorisniciEdit : Form
    {
        private WebAPIHelper korisniciService = new WebAPIHelper(Global.ApiAddress, Global.KorisniciRoute, Global.PrijavljeniKorisnik);
        private WebAPIHelper tipoviKorisnikaService = new WebAPIHelper(Global.ApiAddress, Global.TipoviKorisnikaRoute, Global.PrijavljeniKorisnik);

        private TipKorisnikaType? tipKorisnika = Global.PrijavljeniKorisnik.TipKorisnika?.Type;

        private int _id { get; set; }
        private KorisnikModel _k { get; set; }

        public frmKorisniciEdit(int id)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

            if (tipKorisnika != null && tipKorisnika.Value == TipKorisnikaType.Radnik)
            {
                cmbTipKorisnika.Enabled = false;
            }

            _id = id;
            _k = null;
        }
        
        private void frmKorisniciEdit_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = korisniciService.GetResponse(_id.ToString()).Handle();
            if (response.IsSuccessStatusCode)
            {
                _k = response.GetResponseResult<KorisnikModel>();
                FillForm();
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                _k = null;
            }
        }

        private void FillForm()
        {
            cmbSpol.Items.AddRange(new object[] { "M", "Ž" });
            cmbSpol.SelectedIndex = cmbSpol.FindStringExact(_k.Spol);

            var tipoviKorisnikaResponse = tipoviKorisnikaService.GetResponse().Handle();
            if (tipoviKorisnikaResponse.IsSuccessStatusCode)
            {
                var tipoviKorisnika = tipoviKorisnikaResponse.GetResponseResult<List<TipKorisnikaModel>>();
                cmbTipKorisnika.DataSource = tipoviKorisnika;
                cmbTipKorisnika.DisplayMember = "Naziv";
                cmbTipKorisnika.ValueMember = "Id";
                foreach (var tipKorisnika in tipoviKorisnika)
                {
                    if (tipKorisnika.Id == _k.TipKorisnikaId)
                    {
                        cmbTipKorisnika.SelectedItem = tipKorisnika;
                        break;
                    }
                }
            }

            txtIme.Text = _k.Ime;
            txtPrezime.Text = _k.Prezime;
            txtEmail.Text = _k.Email;            
            txtKorisnickoIme.Text = _k.KorisnickoIme;

            if (_k.SlikaThumb != null)
            {
                pbSlikaThumb.Image = (Bitmap)((new ImageConverter()).ConvertFrom(_k.SlikaThumb));
            }
        }

        private void btnIzaberiSliku_Click(object sender, EventArgs e)
        {
            try
            {
                using (var openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.ShowDialog();
                    txtSlika.Text = openFileDialog.FileName;
                }

                var slikaData = Util.UIHelper.PrepareSaveImage(txtSlika.Text);
                if (slikaData != null)
                {
                    _k.Slika = slikaData.OriginalImageBytes;
                    _k.SlikaThumb = slikaData.CroppedImageBytes;
                    pbSlikaThumb.Image = slikaData.CroppedImage;
                }
            }
            catch
            {
                txtSlika.Text = null;
            }
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (_k != null && this.ValidateChildren())
            {
                _k.Ime = txtIme.Text;
                _k.Prezime = txtPrezime.Text;
                _k.Email = txtEmail.Text;
                _k.Spol = cmbSpol.SelectedItem.ToString();
                _k.DatumRodjenja = dtpDatumRodjenja.Value;
                
                _k.KorisnickoIme = txtKorisnickoIme.Text;
                _k.TipKorisnikaId = ((TipKorisnikaModel)cmbTipKorisnika.SelectedItem).Id;

                if (!string.IsNullOrEmpty(txtLozinka.Text))
                {
                    _k.LozinkaSalt = Util.UIHelper.GenerateSalt();
                    _k.LozinkaHash = Util.UIHelper.GenerateHash(_k.LozinkaSalt, txtLozinka.Text);
                }

                HttpResponseMessage response = korisniciService.PutResponse(_id, _k).Handle();
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.edit_user_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                errorProvider.SetError(txtIme, Messages.user_fname_req);
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
                errorProvider.SetError(txtPrezime, Messages.user_fname_req);
            }
            else
            {
                errorProvider.SetError(txtPrezime, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtEmail, Messages.user_email_req);
            }
            else
            {
                try
                {
                    MailAddress mail = new MailAddress(txtEmail.Text);
                    errorProvider.SetError(txtEmail, null);

                }
                catch (FormatException)
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtEmail, Messages.user_email_err);
                }
            }
        }

        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtKorisnickoIme.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtKorisnickoIme, Messages.user_name_req);
            }
            else if (txtKorisnickoIme.TextLength < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(txtKorisnickoIme, Messages.user_name_err);
            }
            else
            {
                errorProvider.SetError(txtKorisnickoIme, null);
            }
        }

        private void txtLozinka_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLozinka.Text.Trim()) &&
                (txtLozinka.TextLength < 6 || !txtLozinka.Text.Any(char.IsDigit) || !txtLozinka.Text.Any(char.IsLetter)))
            {
                e.Cancel = true;
                errorProvider.SetError(txtLozinka, Messages.user_pass_err);
            }
            else
            {
                errorProvider.SetError(txtLozinka, null);
            }
        }

        #endregion
    }
}
