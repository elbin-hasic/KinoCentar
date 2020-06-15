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

namespace KinoCentar.WinUI.Forms.Filmovi
{
    public partial class frmFilmoviEdit : Form
    {
        private WebAPIHelper filmoviService = new WebAPIHelper(Global.ApiAddress, Global.FilmoviRoute);
        private WebAPIHelper filmskeLicnostiService = new WebAPIHelper(Global.ApiAddress, Global.FilmskeLicnostiRoute);

        private int _id { get; set; }
        private FilmModel _film { get; set; }

        public frmFilmoviEdit(int id)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

            _id = id;
            _film = null;
        }

        private void frmFilmoviEdit_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = filmoviService.GetResponse(_id.ToString()).Handle();
            if (response.IsSuccessStatusCode)
            {
                _film = response.GetResponseResult<FilmModel>();
                FillForm();
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                _film = null;
            }
        }

        private void FillForm()
        {
            var filmskeLicnostiResponse = filmskeLicnostiService.GetActionResponse("GetByType", "false", "true").Handle();
            if (filmskeLicnostiResponse.IsSuccessStatusCode)
            {
                var filmskeLicnosti = filmskeLicnostiResponse.GetResponseResult<List<FilmskaLicnostModel>>();
                cmbReditelj.DataSource = filmskeLicnosti;
                cmbReditelj.DisplayMember = "ImePrezime";
                cmbReditelj.ValueMember = "Id";
                foreach (var filmskaLicnost in filmskeLicnosti)
                {
                    if (filmskaLicnost.Id == _film.RediteljId)
                    {
                        cmbReditelj.SelectedItem = filmskaLicnost;
                        break;
                    }
                }
            }

            txtNaslov.Text = _film.Naslov;
            txtTrajanje.Text = _film.Trajanje != null ? _film.Trajanje.ToString() : string.Empty;
            txtGodinaSnimanja.Text = _film.GodinaSnimanja != null ? _film.GodinaSnimanja.ToString() : string.Empty;
            txtSadrzaj.Text = _film.Sadrzaj;
            txtVideoLink.Text = _film.VideoLink;
            txtImdbLink.Text = _film.ImdbLink;

            if (_film.PlakatThumb != null)
            {
                pbPlakat.Image = (Bitmap)((new ImageConverter()).ConvertFrom(_film.PlakatThumb));
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
                    _film.Plakat = slikaData.OriginalImageBytes;
                    _film.PlakatThumb = slikaData.CroppedImageBytes;
                    pbPlakat.Image = slikaData.CroppedImage;
                }
            }
            catch
            {
                txtPlakat.Text = null;
            }
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (_film != null && this.ValidateChildren())
            {
                _film.Naslov = txtNaslov.Text;
                _film.Trajanje = !string.IsNullOrEmpty(txtTrajanje.Text) ? int.Parse(txtTrajanje.Text) : (int?)null;
                _film.GodinaSnimanja = !string.IsNullOrEmpty(txtGodinaSnimanja.Text) ? int.Parse(txtGodinaSnimanja.Text) : (int?)null;
                _film.Sadrzaj = txtSadrzaj.Text;
                _film.VideoLink = txtVideoLink.Text;
                _film.ImdbLink = txtImdbLink.Text;
                
                _film.RediteljId = ((FilmskaLicnostModel)cmbReditelj.SelectedItem).Id;

                HttpResponseMessage response = filmoviService.PutResponse(_id, _film).Handle();
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.edit_film_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
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



        #endregion
    }
}
