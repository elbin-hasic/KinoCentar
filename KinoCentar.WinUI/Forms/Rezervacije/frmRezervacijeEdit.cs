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
using KinoCentar.WinUI.Forms.Projekcije;
using KinoCentar.Shared.Extensions;
using KinoCentar.WinUI.Forms.Korisnici;

namespace KinoCentar.WinUI.Forms.Rezervacije
{
    public partial class frmRezervacijeEdit : Form
    {
        private WebAPIHelper rezervacijeService = new WebAPIHelper(Global.ApiAddress, Global.RezervacijeRoute, Global.PrijavljeniKorisnik);
        private WebAPIHelper projekcijeService = new WebAPIHelper(Global.ApiAddress, Global.ProjekcijeRoute, Global.PrijavljeniKorisnik);
        private WebAPIHelper korisniciService = new WebAPIHelper(Global.ApiAddress, Global.KorisniciRoute, Global.PrijavljeniKorisnik);

        private int _id { get; set; }
        private RezervacijaModel _r { get; set; }

        public frmRezervacijeEdit(int id)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

            _id = id;
            _r = null;
        }

        private void frmRezervacijeEdit_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = rezervacijeService.GetResponse(_id.ToString()).Handle();
            if (response.IsSuccessStatusCode)
            {
                _r = response.GetResponseResult<RezervacijaModel>();
                FillForm();
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                _r = null;
            }
        }

        private void FillForm()
        {
            var projekcijeResponse = projekcijeService.GetResponse().Handle();
            if (projekcijeResponse.IsSuccessStatusCode)
            {
                var projekcije = projekcijeResponse.GetResponseResult<List<ProjekcijaModel>>();
                cmbProjekcija.DataSource = projekcije;
                cmbProjekcija.DisplayMember = "FilmDatumNaslov";
                cmbProjekcija.ValueMember = "Id";
                foreach (var projekcijaItem in projekcije)
                {
                    if (projekcijaItem.Id == _r.ProjekcijaId)
                    {
                        cmbProjekcija.SelectedItem = projekcijaItem;
                        break;
                    }
                }
            }

            var projekcija = (ProjekcijaModel)cmbProjekcija.SelectedItem;

            if (projekcija.VrijediOd.Date < projekcija.VrijediDo.Date)
            {
                dtpDatumProjekcije.MinDate = projekcija.VrijediOd;
                dtpDatumProjekcije.MaxDate = projekcija.VrijediDo;
            }
            else
            {
                dtpDatumProjekcije.MinDate = projekcija.VrijediOd.Date;
                dtpDatumProjekcije.MaxDate = projekcija.VrijediOd.Date.AddDays(1);
            }

            var retSjedistaResponse = rezervacijeService.GetActionResponse("FreeSeats", projekcija.Id.ToString(), _r.Id.ToString()).Handle();
            if (retSjedistaResponse.IsSuccessStatusCode)
            {
                var retSjedista = retSjedistaResponse.GetResponseResult<List<int>>();
                cmbBrojSjedista.DataSource = retSjedista;
                cmbBrojSjedista.SelectedIndex = cmbBrojSjedista.FindStringExact(_r.BrojSjedista.ToString());
            }

            var retTerminiResponse = projekcijeService.GetActionResponse("Terms", projekcija.Id.ToString()).Handle();
            if (retTerminiResponse.IsSuccessStatusCode)
            {
                var termini = retTerminiResponse.GetResponseResult<List<ProjekcijaTerminModel>>();
                cmbTermin.DataSource = termini;
                cmbTermin.DisplayMember = "TerminShort";
                cmbTermin.ValueMember = "Id";
                foreach (var terminItem in termini)
                {
                    if (terminItem.Id == _r.ProjekcijaTerminId)
                    {
                        cmbTermin.SelectedItem = terminItem;
                        break;
                    }
                }
            }

            LoadKorisnici();

            dtpDatumProjekcije.Value = _r.DatumProjekcije;
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (_r != null && this.ValidateChildren())
            {
                var projekcija = ((ProjekcijaModel)cmbProjekcija.SelectedItem);
                var projekcijaTermin = ((ProjekcijaTerminModel)cmbTermin.SelectedItem);

                _r.ProjekcijaId = projekcija.Id;
                _r.ProjekcijaTerminId = projekcijaTermin.Id;
                _r.KorisnikId = ((KorisnikModel)cmbKorisnik.SelectedItem).Id;
                _r.BrojSjedista = Convert.ToInt32(cmbBrojSjedista.SelectedItem);
                _r.DatumProjekcije = dtpDatumProjekcije.Value;

                HttpResponseMessage response = rezervacijeService.PutResponse(_id, _r).Handle();
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.edit_rezervacija_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var projekcijaId = ((ProjekcijaModel)cmbProjekcija.SelectedItem).Id;
                var frm = new frmProjekcijeEdit(projekcijaId);
                frm.ShowDialog();
            }
            catch
            { }
        }

        private void brnNoviKorisnik_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frmKorisniciAdd();
                frm.ShowDialog();

                LoadKorisnici();
            }
            catch
            { }
        }

        private void LoadKorisnici()
        {
            var korisnikResponse = korisniciService.GetActionResponse("Klijenti", "").Handle();
            if (korisnikResponse.IsSuccessStatusCode)
            {
                var korisnici = korisnikResponse.GetResponseResult<List<KorisnikModel>>();
                cmbKorisnik.DataSource = korisnici;
                cmbKorisnik.DisplayMember = "ImePrezime";
                cmbKorisnik.ValueMember = "Id";
                foreach (var korisnik in korisnici)
                {
                    if (korisnik.Id == _r.KorisnikId)
                    {
                        cmbKorisnik.SelectedItem = korisnik;
                        break;
                    }
                }
            }
        }
    }
}
