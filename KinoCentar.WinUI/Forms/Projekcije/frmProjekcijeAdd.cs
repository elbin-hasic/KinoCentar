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
using KinoCentar.WinUI.Forms.Filmovi;
using KinoCentar.Shared.Extensions;

namespace KinoCentar.WinUI.Forms.Projekcije
{
    public partial class frmProjekcijeAdd : Form
    {
        private WebAPIHelper projekcijeService = new WebAPIHelper(Global.ApiAddress, Global.ProjekcijeRoute, Global.PrijavljeniKorisnik);
        private WebAPIHelper filmoviService = new WebAPIHelper(Global.ApiAddress, Global.FilmoviRoute, Global.PrijavljeniKorisnik);
        private WebAPIHelper saleService = new WebAPIHelper(Global.ApiAddress, Global.SaleRoute, Global.PrijavljeniKorisnik);

        public frmProjekcijeAdd()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

            var dtn = DateTime.Now;

            dtpVrijediOd.MinDate = dtn.Date;
            dtpVrijediDo.MinDate = dtn.Date;
        }

        private void frmProjekcijeAdd_Load(object sender, EventArgs e)
        {
            var filmoviResponse = filmoviService.GetResponse().Handle();
            if (filmoviResponse.IsSuccessStatusCode)
            {
                var filmovi = filmoviResponse.GetResponseResult<List<FilmModel>>();
                cmbFilm.DataSource = filmovi;
                cmbFilm.DisplayMember = "Naslov";
                cmbFilm.ValueMember = "Id";
            }

            var saleResponse = saleService.GetResponse().Handle();
            if (saleResponse.IsSuccessStatusCode)
            {
                var sale = saleResponse.GetResponseResult<List<SalaModel>>();
                cmbSala.DataSource = sale;
                cmbSala.DisplayMember = "Naziv";
                cmbSala.ValueMember = "Id";
            }
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                ProjekcijaModel p = new ProjekcijaModel();
                p.FilmId = ((FilmModel)cmbFilm.SelectedItem).Id;
                p.SalaId = ((SalaModel)cmbSala.SelectedItem).Id;

                p.Cijena = decimal.Parse(txtCijena.Text);
                p.VrijediOd = dtpVrijediOd.Value;
                p.VrijediDo = dtpVrijediDo.Value;
                p.Datum = DateTime.Now;

                HttpResponseMessage response = projekcijeService.PostResponse(p).Handle();
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.add_projekcija_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnFilmInfo_Click(object sender, EventArgs e)
        {
            try
            {
                var filmId = ((FilmModel)cmbFilm.SelectedItem).Id;
                var frm = new frmFilmoviEdit(filmId);
                frm.ShowDialog();
            }
            catch
            { }
        }

        #region Validation

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

        private void dtpVrijediOd_Validating(object sender, CancelEventArgs e)
        {
            if (dtpVrijediOd.Value.Date > dtpVrijediDo.Value.Date)
            {
                e.Cancel = true;
                errorProvider.SetError(dtpVrijediOd, Messages.projekcija_datum_err);
            }
            else
            {
                errorProvider.SetError(dtpVrijediOd, null);
            }
        }

        #endregion
    }
}
