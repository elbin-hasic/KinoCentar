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
                cmbProjekcija.DisplayMember = "FilmNaslov";
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

            var korisnikResponse = korisniciService.GetActionResponse("Klijenti", "").Handle();
            if (korisnikResponse.IsSuccessStatusCode)
            {
                var korisnici = korisnikResponse.GetResponseResult<List<KorisnikModel>>();
                korisnici.Insert(0, new KorisnikModel());
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

            dtpDatumProjekcije.Value = _r.DatumProjekcije;
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (_r != null && this.ValidateChildren())
            {
                _r.ProjekcijaId = ((ProjekcijaModel)cmbProjekcija.SelectedItem).Id;
                if (cmbKorisnik.SelectedIndex != 0)
                {
                    _r.KorisnikId = ((KorisnikModel)cmbKorisnik.SelectedItem).Id;
                }
                if (cmbBrojSjedista.SelectedIndex != 0)
                {
                    _r.BrojSjedista = Convert.ToInt32(cmbBrojSjedista.SelectedItem);
                }

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

        #region Validation



        #endregion
    }
}
