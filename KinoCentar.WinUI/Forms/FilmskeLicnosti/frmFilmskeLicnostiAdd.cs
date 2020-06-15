using KinoCentar.Shared.Models;
using KinoCentar.Shared.Util;
using KinoCentar.WinUI.Extensions;
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

namespace KinoCentar.WinUI.Forms.FilmskeLicnosti
{
    public partial class frmFilmskeLicnostiAdd : Form
    {
        private WebAPIHelper filmskeLicnostiService = new WebAPIHelper(Global.ApiAddress, Global.FilmskeLicnostiRoute);

        public frmFilmskeLicnostiAdd()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var filmskaLicnost = new FilmskaLicnostModel();
                filmskaLicnost.Ime = txtIme.Text;
                filmskaLicnost.Prezime = txtPrezime.Text;
                filmskaLicnost.IsGlumac = ckbIsGlumac.Checked;
                filmskaLicnost.IsReziser = ckbIsReziser.Checked;

                HttpResponseMessage response = filmskeLicnostiService.PostResponse(filmskaLicnost).Handle();
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.add_filmskaLicnost_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
