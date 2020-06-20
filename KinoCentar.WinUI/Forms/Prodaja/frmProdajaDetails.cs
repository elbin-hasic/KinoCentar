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
using KinoCentar.WinUI.Forms.Projekcije;
using KinoCentar.WinUI.Forms.Rezervacije;
using KinoCentar.WinUI.Models.Enums;
using KinoCentar.Shared.Extensions;

namespace KinoCentar.WinUI.Forms.Prodaja
{
    public partial class frmProdajaDetails : Form
    {
        private WebAPIHelper prodajaService = new WebAPIHelper(Global.ApiAddress, Global.ProdajaRoute);

        private int _id { get; set; }
        private ProdajaModel _p { get; set; }

        public frmProdajaDetails(int id)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            dgvArtikli.AutoGenerateColumns = false;

            _id = id;
            _p = null;
        }

        private void frmProdajaDetails_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = prodajaService.GetResponse(_id.ToString()).Handle();
            if (response.IsSuccessStatusCode)
            {
                _p = response.GetResponseResult<ProdajaModel>();
                FillForm();
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                _p = null;
            }
        }

        private void FillForm()
        {
            decimal rezervacijaCijena = 0;
            decimal artikliUkupnaCijena = 0;

            var artikli = _p.ArtikliStavke.ToList();

            foreach (var artikal in artikli)
            {
                artikliUkupnaCijena += (artikal.Kolicina * artikal.Cijena);
            }

            RezervacijaModel rezervacija = null;
            if (_p.RezervacijeStavke.Any())
            {
                if (_p.RezervacijeStavke.First() != null)
                {
                    rezervacija = _p.RezervacijeStavke.First().Rezervacija;
                }                    
            }

            if (rezervacija != null)
            {
                txtNaslov.Text = _p.FilmNaslov;
                txtSala.Text = _p.SalaNaziv;
                txtBrojSjedista.Text = rezervacija.BrojSjedista.ToString();
                txtCijena.Text = rezervacija.Cijena.ToString();
                dtpDatumProjekcije.Value = rezervacija.DatumProjekcije;
                txtKorisnik.Text = _p.Korisnik?.ImePrezime;
                //
                rezervacijaCijena = rezervacija.Cijena;
                txtCijenaRezervacije.Text = rezervacijaCijena.ToString("0.##");
            }
            else
            {
                gbProjekcija.Enabled = false;
                txtCijenaRezervacije.Text = string.Empty;
            }

            dgvArtikli.DataSource = artikli;
            dgvArtikli.ClearSelection();

            decimal ukupnaCijena = rezervacijaCijena + artikliUkupnaCijena;

            txtBrojRacuna.Text = _p.BrojRacuna;
            txtArtikliCijenaUkupno.Text = artikliUkupnaCijena.ToString("0.##");
            txtCijenaUkupno.Text = ukupnaCijena.ToString("0.##");            
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(Messages.msg_cancel_que, Messages.msg_conf, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
