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

namespace KinoCentar.WinUI.Forms.Filmovi
{
    public partial class frmFilmoviAdd : Form
    {
        private WebAPIHelper filmoviService = new WebAPIHelper(Global.API_ADDRESS, Global.FilmoviRoute);
        private WebAPIHelper filmskeLicnostiService = new WebAPIHelper(Global.API_ADDRESS, Global.FilmskeLicnostiRoute);

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

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                FilmModel film = new FilmModel();
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

        

        #endregion
    }
}
