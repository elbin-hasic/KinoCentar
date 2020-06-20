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
using KinoCentar.Shared.Extensions;

namespace KinoCentar.WinUI.Forms.Artikli
{
    public partial class frmArtikliAdd : Form
    {
        private WebAPIHelper artikliService = new WebAPIHelper(Global.ApiAddress, Global.ArtikliRoute, Global.PrijavljeniKorisnik);
        private WebAPIHelper jedMjereService = new WebAPIHelper(Global.ApiAddress, Global.JediniceMjereRoute, Global.PrijavljeniKorisnik);

        ArtikalModel a = new ArtikalModel();

        public frmArtikliAdd()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void frmArtikalAdd_Load(object sender, EventArgs e)
        {
            var jedMjereResponse = jedMjereService.GetResponse().Handle();
            if (jedMjereResponse.IsSuccessStatusCode)
            {
                var jedMjere = jedMjereResponse.GetResponseResult<List<JedinicaMjereModel>>();
                cmbJedinicaMjere.DataSource = jedMjere;
                cmbJedinicaMjere.DisplayMember = "PuniNaziv";
                cmbJedinicaMjere.ValueMember = "Id";
            }
        }

        private void btnIzaberiPlakat_Click(object sender, EventArgs e)
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
                    a.Slika = slikaData.OriginalImageBytes;
                    a.SlikaThumb = slikaData.CroppedImageBytes;
                    pbSlika.Image = slikaData.CroppedImage;
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
                a.JedinicaMjereId = ((JedinicaMjereModel)cmbJedinicaMjere.SelectedItem).Id;

                a.Naziv = txtNaziv.Text;
                a.Sifra = txtSifra.Text;
                a.Cijena = decimal.Parse(txtCijena.Text);                

                HttpResponseMessage response = artikliService.PostResponse(a).Handle();
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.add_artikal_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                errorProvider.SetError(txtNaziv, Messages.artikal_name_req);
            }
            else
            {
                errorProvider.SetError(txtNaziv, null);
            }
        }

        private void txtSifra_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSifra.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtSifra, Messages.artikal_sifra_req);
            }
            else
            {
                errorProvider.SetError(txtSifra, null);
            }
        }

        private void txtCijena_Validating(object sender, CancelEventArgs e)
        {
            var cijenaText = txtCijena.Text.Trim().Replace(",", "");
            if (string.IsNullOrEmpty(cijenaText))
            {
                e.Cancel = true;
                errorProvider.SetError(txtCijena, Messages.cijena_req);
            }
            else
            {
                try
                {
                    var cijena = decimal.Parse(txtCijena.Text);
                    errorProvider.SetError(txtCijena, null);
                }
                catch
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtCijena, Messages.cijena_err);
                }
            }
        }

        #endregion
    }
}
