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

namespace KinoCentar.WinUI.Forms.Filmovi
{
    public partial class frmFilmoviAdd : Form
    {
        private WebAPIHelper filmoviService = new WebAPIHelper(Global.ApiAddress, Global.FilmoviRoute, Global.PrijavljeniKorisnik);
        private WebAPIHelper filmskeLicnostiService = new WebAPIHelper(Global.ApiAddress, Global.FilmskeLicnostiRoute, Global.PrijavljeniKorisnik);

        FilmModel film = new FilmModel();

        public frmFilmoviAdd()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void frmFilmoviAdd_Load(object sender, EventArgs e)
        {
            var filmskeLicnostiResponse = filmskeLicnostiService.GetActionResponse("GetByType", "false", "true").Handle();
            if (filmskeLicnostiResponse.IsSuccessStatusCode)
            {
                var filmskeLicnosti = filmskeLicnostiResponse.GetResponseResult<List<FilmskaLicnostModel>>();
                cmbReditelj.DataSource = filmskeLicnosti;
                cmbReditelj.DisplayMember = "ImePrezime";
                cmbReditelj.ValueMember = "Id";
            }
        }

        private void btnIzaberiPlakat_Click(object sender, EventArgs e)
        {
            try
            {
                using (var openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.ShowDialog();
                    txtPlakat.Text = openFileDialog.FileName;
                }

                var slikaData = Util.UIHelper.PrepareSaveImage(txtPlakat.Text);
                if (slikaData != null)
                {
                    film.Plakat = slikaData.OriginalImageBytes;
                    film.PlakatThumb = slikaData.CroppedImageBytes;
                    pbPlakat.Image = slikaData.OriginalImage;
                }
            }
            catch
            {
                txtPlakat.Text = null;
            }
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                film.Naslov = txtNaslov.Text;
                film.Trajanje = !string.IsNullOrEmpty(txtTrajanje.Text) ? int.Parse(txtTrajanje.Text) : (int?)null;
                film.GodinaSnimanja = !string.IsNullOrEmpty(txtGodinaSnimanja.Text) ? int.Parse(txtGodinaSnimanja.Text) : (int?)null;
                film.Sadrzaj = txtSadrzaj.Text;
                film.VideoLink = txtVideoLink.Text;
                film.ImdbLink = txtImdbLink.Text;
                
                film.RediteljId = ((FilmskaLicnostModel)cmbReditelj.SelectedItem).Id;

                HttpResponseMessage response = filmoviService.PostResponse(film).Handle();
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.add_film_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtNaslov_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNaslov.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNaslov, Messages.film_name_req);
            }
            else
            {
                errorProvider.SetError(txtNaslov, null);
            }
        }

        #endregion
    }
}
