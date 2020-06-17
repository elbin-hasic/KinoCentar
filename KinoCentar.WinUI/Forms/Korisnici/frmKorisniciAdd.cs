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
using KinoCentar.Shared.Models;
using KinoCentar.Shared.Util;
using KinoCentar.WinUI.Util;
using KinoCentar.WinUI.Extensions;
using System.IO;
using System.Net.Mail;

namespace KinoCentar.WinUI.Forms.Korisnici
{
    public partial class frmKorisniciAdd : Form
    {
        private WebAPIHelper korisniciService = new WebAPIHelper(Global.ApiAddress, Global.KorisniciRoute);
        private WebAPIHelper tipoviKorisnikaService = new WebAPIHelper(Global.ApiAddress, Global.TipoviKorisnikaRoute);

        KorisnikModel k = new KorisnikModel();

        public frmKorisniciAdd()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void frmKorisniciAdd_Load(object sender, EventArgs e)
        {
            cmbSpol.Items.AddRange(new object[] {"M", "Ž"});
            var tipoviKorisnikaResponse = tipoviKorisnikaService.GetResponse().Handle();
            if (tipoviKorisnikaResponse.IsSuccessStatusCode)
            {
                var tipoviKorisnika = tipoviKorisnikaResponse.GetResponseResult<List<TipKorisnikaModel>>();
                this.cmbTipKorisnika.DataSource = tipoviKorisnika;
                this.cmbTipKorisnika.DisplayMember = "Naziv";
                this.cmbTipKorisnika.ValueMember = "Id";
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
                    k.Slika = slikaData.OriginalImageBytes;
                    k.SlikaThumb = slikaData.CroppedImageBytes;
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
            if (this.ValidateChildren())
            {
                k.Ime = txtIme.Text;
                k.Prezime = txtPrezime.Text;
                k.Email = txtEmail.Text;
                k.Spol = cmbSpol.SelectedItem.ToString();
                k.DatumRodjenja = dtpDatumRodjenja.Value;

                k.KorisnickoIme = txtKorisnickoIme.Text;
                k.LozinkaSalt = Util.UIHelper.GenerateSalt();
                k.LozinkaHash = Util.UIHelper.GenerateHash(k.LozinkaSalt, txtLozinka.Text);
                k.TipKorisnikaId = ((TipKorisnikaModel)cmbTipKorisnika.SelectedItem).Id;

                HttpResponseMessage response = korisniciService.PostResponse(k).Handle();
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.add_user_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (string.IsNullOrEmpty(txtLozinka.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtLozinka, Messages.user_pass_req);
            }
            else if (txtLozinka.TextLength < 6 || !txtLozinka.Text.Any(char.IsDigit) || !txtLozinka.Text.Any(char.IsLetter))
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
