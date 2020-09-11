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
using KinoCentar.WinUI.Forms.Filmovi;
using KinoCentar.Shared.Extensions;

namespace KinoCentar.WinUI.Forms.Projekcije
{
    public partial class frmProjekcijeEdit : Form
    {
        private WebAPIHelper projekcijeService = new WebAPIHelper(Global.ApiAddress, Global.ProjekcijeRoute, Global.PrijavljeniKorisnik);
        private WebAPIHelper filmoviService = new WebAPIHelper(Global.ApiAddress, Global.FilmoviRoute, Global.PrijavljeniKorisnik);
        private WebAPIHelper saleService = new WebAPIHelper(Global.ApiAddress, Global.SaleRoute, Global.PrijavljeniKorisnik);

        private int _id { get; set; }
        private ProjekcijaModel _p { get; set; }

        public frmProjekcijeEdit(int id)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

            _id = id;
            _p = null;
        }

        private void frmProjekcijeEdit_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = projekcijeService.GetResponse(_id.ToString()).Handle();
            if (response.IsSuccessStatusCode)
            {
                _p = response.GetResponseResult<ProjekcijaModel>();
                FillForm();
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                _p = null;
            }
        }

        private void FillForm()
        {
            var filmoviResponse = filmoviService.GetResponse().Handle();
            if (filmoviResponse.IsSuccessStatusCode)
            {
                var filmovi = filmoviResponse.GetResponseResult<List<FilmModel>>();
                cmbFilm.DataSource = filmovi;
                cmbFilm.DisplayMember = "Naslov";
                cmbFilm.ValueMember = "Id";
                foreach (var film in filmovi)
                {
                    if (film.Id == _p.FilmId)
                    {
                        cmbFilm.SelectedItem = film;
                        break;
                    }
                }
            }

            var saleResponse = saleService.GetResponse().Handle();
            if (saleResponse.IsSuccessStatusCode)
            {
                var sale = saleResponse.GetResponseResult<List<SalaModel>>();
                cmbSala.DataSource = sale;
                cmbSala.DisplayMember = "Naziv";
                cmbSala.ValueMember = "Id";
                foreach (var sala in sale)
                {
                    if (sala.Id == _p.SalaId)
                    {
                        cmbSala.SelectedItem = sala;
                        break;
                    }
                }
            }

            FillTermini();

            txtCijena.Text = _p.Cijena.ToString("0000.00");
            dtpVrijediOd.Value = _p.VrijediOd;
            dtpVrijediDo.Value = _p.VrijediDo;
        }

        private void FillTermini()
        {
            int i = 0;
            foreach (var t in _p.Termini)
            {
                i++;

                switch (i)
                {
                    case 1:
                        cbLblId1.Text = t.Id.ToString();
                        dtpTermin1.Value = DateTime.Now.Date + t.Termin;
                        break;
                    case 2:
                        cbLblId2.Text = t.Id.ToString();
                        cbTermin2.Checked = true;
                        dtpTermin2.Enabled = true;
                        dtpTermin2.Value = DateTime.Now.Date + t.Termin;
                        break;
                    case 3:
                        cbLblId3.Text = t.Id.ToString();
                        cbTermin3.Checked = true;
                        dtpTermin3.Enabled = true;
                        dtpTermin3.Value = DateTime.Now.Date + t.Termin;
                        break;
                    case 4:
                        cbLblId4.Text = t.Id.ToString();
                        cbTermin4.Checked = true;
                        dtpTermin4.Enabled = true;
                        dtpTermin4.Value = DateTime.Now.Date + t.Termin;
                        break;
                    case 5:
                        cbLblId5.Text = t.Id.ToString();
                        cbTermin5.Checked = true;
                        dtpTermin5.Enabled = true;
                        dtpTermin5.Value = DateTime.Now.Date + t.Termin;
                        break;
                    case 6:
                        cbLblId6.Text = t.Id.ToString();
                        cbTermin6.Checked = true;
                        dtpTermin6.Enabled = true;
                        dtpTermin6.Value = DateTime.Now.Date + t.Termin;
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (_p != null && this.ValidateChildren())
            {
                _p.FilmId = ((FilmModel)cmbFilm.SelectedItem).Id;
                _p.SalaId = ((SalaModel)cmbSala.SelectedItem).Id;
                
                _p.Cijena = Convert.ToDecimal(txtCijena.Text);
                _p.VrijediOd = dtpVrijediOd.Value;
                _p.VrijediDo = dtpVrijediDo.Value;

                _p.Termini = GetTermini();

                HttpResponseMessage response = projekcijeService.PutResponse(_id, _p).Handle();
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.edit_projekcija_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private List<ProjekcijaTerminModel> GetTermini()
        {
            var termini = new List<ProjekcijaTerminModel>();

            termini.Add(new ProjekcijaTerminModel { 
                Id = !string.IsNullOrEmpty(cbLblId1.Text) ? int.Parse(cbLblId1.Text) : 0, 
                ProjekcijaId = _p.Id, Termin = dtpTermin1.Value.TimeOfDay });
            if (cbTermin2.Checked)
            {
                termini.Add(new ProjekcijaTerminModel { 
                    Id = !string.IsNullOrEmpty(cbLblId2.Text) ? int.Parse(cbLblId1.Text) : 0,
                    ProjekcijaId = _p.Id, Termin = dtpTermin2.Value.TimeOfDay });
            }
            if (cbTermin3.Checked)
            {
                termini.Add(new ProjekcijaTerminModel { 
                    Id = !string.IsNullOrEmpty(cbLblId3.Text) ? int.Parse(cbLblId1.Text) : 0,
                    ProjekcijaId = _p.Id, Termin = dtpTermin3.Value.TimeOfDay });
            }
            if (cbTermin4.Checked)
            {
                termini.Add(new ProjekcijaTerminModel {
                    Id = !string.IsNullOrEmpty(cbLblId4.Text) ? int.Parse(cbLblId1.Text) : 0,
                    ProjekcijaId = _p.Id, Termin = dtpTermin4.Value.TimeOfDay });
            }
            if (cbTermin5.Checked)
            {
                termini.Add(new ProjekcijaTerminModel {
                    Id = !string.IsNullOrEmpty(cbLblId5.Text) ? int.Parse(cbLblId1.Text) : 0,
                    ProjekcijaId = _p.Id, Termin = dtpTermin5.Value.TimeOfDay });
            }
            if (cbTermin6.Checked)
            {
                termini.Add(new ProjekcijaTerminModel {
                    Id = !string.IsNullOrEmpty(cbLblId6.Text) ? int.Parse(cbLblId1.Text) : 0,
                    ProjekcijaId = _p.Id, Termin = dtpTermin6.Value.TimeOfDay });
            }

            return termini;
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

        #endregion

        private void cbTermin2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTermin2.Checked)
            {
                dtpTermin2.Enabled = true;
            }
            else
            {
                dtpTermin2.Enabled = false;
            }
        }

        private void cbTermin3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTermin3.Checked)
            {
                dtpTermin3.Enabled = true;
            }
            else
            {
                dtpTermin3.Enabled = false;
            }
        }

        private void cbTermin4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTermin4.Checked)
            {
                dtpTermin4.Enabled = true;
            }
            else
            {
                dtpTermin4.Enabled = false;
            }
        }

        private void cbTermin5_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTermin5.Checked)
            {
                dtpTermin5.Enabled = true;
            }
            else
            {
                dtpTermin5.Enabled = false;
            }
        }

        private void cbTermin6_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTermin6.Checked)
            {
                dtpTermin6.Enabled = true;
            }
            else
            {
                dtpTermin6.Enabled = false;
            }
        }
    }
}
