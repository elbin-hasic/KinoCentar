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

namespace KinoCentar.WinUI.Forms.Prodaja
{
    public partial class frmProdajaAdd : Form
    {
        private WebAPIHelper prodajaService = new WebAPIHelper(Global.ApiAddress, Global.ProdajaRoute);
        private WebAPIHelper rezervacijeService = new WebAPIHelper(Global.ApiAddress, Global.RezervacijeRoute);
        private WebAPIHelper projekcijeService = new WebAPIHelper(Global.ApiAddress, Global.ProjekcijeRoute);
        private WebAPIHelper artikliService = new WebAPIHelper(Global.ApiAddress, Global.ArtikliRoute);
        private WebAPIHelper korisniciService = new WebAPIHelper(Global.ApiAddress, Global.KorisniciRoute);

        private decimal rezervacijaCijena = 0;
        private decimal artikliUkupnaCijena = 0;
        private decimal ukupnaCijena = 0;

        private ProdajaRezervacijaType rezervacijaType = ProdajaRezervacijaType.PostojecaRezervacija;

        public frmProdajaAdd()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            dgvArtikli.AutoGenerateColumns = false;
        }

        private void frmProdajaAdd_Load(object sender, EventArgs e)
        {
            var response = artikliService.GetResponse().Handle();
            if (response.IsSuccessStatusCode)
            {
                dgvArtikli.DataSource = response.GetResponseResult<List<ArtikalModel>>();
                dgvArtikli.Columns["Naziv"].ReadOnly = true;
                dgvArtikli.Columns["Sifra"].ReadOnly = true;
                dgvArtikli.Columns["Cijena"].ReadOnly = true;
                dgvArtikli.Columns["Kolicina"].ReadOnly = true;
                dgvArtikli.Columns["Kolicina"].ValueType = typeof(int);
                dgvArtikli.ClearSelection();
            }

            var rezervacijeResponse = rezervacijeService.GetActionResponse("GetByType", "false", "false").Handle();
            if (rezervacijeResponse.IsSuccessStatusCode)
            {
                var rezervacije = rezervacijeResponse.GetResponseResult<List<RezervacijaModel>>();
                cmbRezervacija.DataSource = rezervacije;
                cmbRezervacija.DisplayMember = "Naslov";
                cmbRezervacija.ValueMember = "Id";
            }

            var projekcijeResponse = projekcijeService.GetResponse().Handle();
            if (projekcijeResponse.IsSuccessStatusCode)
            {
                var projekcije = projekcijeResponse.GetResponseResult<List<ProjekcijaModel>>();
                cmbProjekcija.DataSource = projekcije;
                cmbProjekcija.DisplayMember = "FilmNaslov";
                cmbProjekcija.ValueMember = "Id";
            }

            var korisnikResponse = korisniciService.GetResponse().Handle();
            if (korisnikResponse.IsSuccessStatusCode)
            {
                var korisnici = korisnikResponse.GetResponseResult<List<KorisnikModel>>();
                korisnici.Insert(0, new KorisnikModel());
                cmbKorisnik.DataSource = korisnici;
                cmbKorisnik.DisplayMember = "ImePrezime";
                cmbKorisnik.ValueMember = "Id";
            }
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                RezervacijaModel rezervacija = null;
                bool rezervacijaValid = true;

                switch (rezervacijaType)
                {
                    case ProdajaRezervacijaType.NovaRezervacija:
                        var rezervacijaResponse = KreirajNovuRezervaciju();
                        rezervacijaValid = rezervacijaResponse.IsSuccessStatusCode;
                        if (rezervacijaValid)
                        {
                            rezervacija = rezervacijaResponse.GetResponseResult<RezervacijaModel>();
                        }
                        break;
                    case ProdajaRezervacijaType.PostojecaRezervacija:
                        rezervacija = (RezervacijaModel)cmbRezervacija.SelectedItem;
                        break;
                }

                var p = new ProdajaModel();
                
                p.BrojRacuna = txtBrojRacuna.Text;
                p.Datum = DateTime.Now;
                p.ArtikliStavke = GetArtikliStavke();

                if (rezervacijaValid && rezervacija != null)
                {
                    p.KorisnikId = rezervacija.KorisnikId;
                    p.RezervacijeStavke = new List<ProdajaRezervacijaDodjelaModel>();
                    p.RezervacijeStavke.Add(new ProdajaRezervacijaDodjelaModel
                    {
                        RezervacijaId = rezervacija.Id,
                        Cijena = rezervacija.Cijena
                    });
                }

                HttpResponseMessage response = prodajaService.PostResponse(p).Handle();
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.add_prodaja_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    if (rezervacijaType == ProdajaRezervacijaType.NovaRezervacija && rezervacijaValid && rezervacija != null)
                    {
                        rezervacijeService.DeleteResponse(rezervacija.Id).Handle();
                    }
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

        private void dgvArtikli_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvArtikli.Columns[e.ColumnIndex].Name == "Izaberi")
            {
                UpdateArtikliKolicinaStatus();
            }
            if (dgvArtikli.Columns[e.ColumnIndex].Name == "Kolicina")
            {
                UpdateArtikliUkupnaCijena();
            }            
        }

        private void btnRezervacijaInfo_Click(object sender, EventArgs e)
        {
            try
            {
                var rezervacijaId = ((RezervacijaModel)cmbRezervacija.SelectedItem).Id;
                var frm = new frmRezervacijeEdit(rezervacijaId);
                frm.ShowDialog();
            }
            catch
            { }
        }

        private void btnProjekcijaInfo_Click(object sender, EventArgs e)
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

        private void rbIzaberiRezervaciju_CheckedChanged(object sender, EventArgs e)
        {
            RezervacijaFormStatus(ProdajaRezervacijaType.PostojecaRezervacija);
        }

        private void rbKreirajRezervaciju_CheckedChanged(object sender, EventArgs e)
        {
            RezervacijaFormStatus(ProdajaRezervacijaType.NovaRezervacija);
        }

        private void rbBezRezervacije_CheckedChanged(object sender, EventArgs e)
        {
            RezervacijaFormStatus(ProdajaRezervacijaType.BezRezervacije);
        }

        private void cmbRezervacija_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var rezervacija = (RezervacijaModel)cmbRezervacija.SelectedItem;
                UpdateRezervacijaCijenu(rezervacija.Cijena);
            }
            catch
            { }
        }

        private void cmbProjekcija_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var projekcija = (ProjekcijaModel)cmbProjekcija.SelectedItem;

                dtpDatumProjekcije.MinDate = projekcija.VrijediOd;
                dtpDatumProjekcije.MaxDate = projekcija.VrijediDo;

                var retSjedistaResponse = rezervacijeService.GetActionResponse("FreeSeats", projekcija.Id.ToString()).Handle();
                if (retSjedistaResponse.IsSuccessStatusCode)
                {
                    var retSjedista = retSjedistaResponse.GetResponseResult<List<int>>();
                    cmbBrojSjedista.DataSource = retSjedista;
                }

                UpdateRezervacijaCijenu(projekcija.Cijena);
            }
            catch
            { }
        }        

        #region Validation

        private void txtBrojRacuna_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBrojRacuna.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtBrojRacuna, Messages.prodaja_sifra_req);
            }
            else
            {
                errorProvider.SetError(txtBrojRacuna, null);
            }
        }

        #endregion

        #region PrivateMethods

        private HttpResponseMessage KreirajNovuRezervaciju()
        {
            var projekcija = (ProjekcijaModel)cmbProjekcija.SelectedItem;

            var model = new RezervacijaModel();

            model.ProjekcijaId = projekcija.Id;
            if (cmbKorisnik.SelectedIndex != 0)
            {
                model.KorisnikId = ((KorisnikModel)cmbKorisnik.SelectedItem).Id;
            }
            if (cmbBrojSjedista.SelectedIndex != 0)
            {
                model.BrojSjedista = Convert.ToInt32(cmbBrojSjedista.SelectedItem);
            }

            model.DatumProjekcije = dtpDatumProjekcije.Value;
            model.Cijena = projekcija.Cijena;
            model.Datum = DateTime.Now;

            return rezervacijeService.PostResponse(model).Handle();
        }

        private void UpdateArtikliKolicinaStatus()
        {
            for (int i = 0; i < (dgvArtikli.Rows.Count); i++)
            {
                bool isChecked = false;

                if (dgvArtikli.Rows[i].Cells["Izaberi"].Value != null)
                {
                    isChecked = bool.Parse(dgvArtikli.Rows[i].Cells["Izaberi"].Value.ToString());
                }

                if (isChecked)
                {
                    dgvArtikli.Rows[i].Cells["Kolicina"].ReadOnly = false;
                    if (dgvArtikli.Rows[i].Cells["Kolicina"].Value == null)
                    {
                        dgvArtikli.Rows[i].Cells["Kolicina"].Value = 1;
                    }
                }
                else
                {
                    dgvArtikli.Rows[i].Cells["Kolicina"].Value = null;
                    dgvArtikli.Rows[i].Cells["Kolicina"].ReadOnly = true;
                }
            }
        }

        private List<ProdajaArtikalDodjelaModel> GetArtikliStavke()
        {
            var artikliStavke = new List<ProdajaArtikalDodjelaModel>();

            for (int i = 0; i < (dgvArtikli.Rows.Count); i++)
            {
                bool isChecked = false;

                if (dgvArtikli.Rows[i].Cells["Izaberi"].Value != null)
                {
                    isChecked = bool.Parse(dgvArtikli.Rows[i].Cells["Izaberi"].Value.ToString());
                }

                if (isChecked)
                {
                    int id = -1;
                    decimal cijena = -1;
                    int kolicina = -1;

                    if (dgvArtikli.Rows[i].Cells["Id"].Value != null)
                    {
                        id = int.Parse(dgvArtikli.Rows[i].Cells["Id"].Value.ToString());
                    }
                    if (dgvArtikli.Rows[i].Cells["Cijena"].Value != null)
                    {
                        cijena = decimal.Parse(dgvArtikli.Rows[i].Cells["Cijena"].Value.ToString());
                    }
                    if (dgvArtikli.Rows[i].Cells["Kolicina"].Value != null)
                    {
                        kolicina = int.Parse(dgvArtikli.Rows[i].Cells["Kolicina"].Value.ToString());
                    }

                    if (id > -1 && cijena > -1 && kolicina > -1)
                    {
                        artikliStavke.Add(new ProdajaArtikalDodjelaModel
                        {
                            ArtikalId = id,
                            Cijena = cijena,
                            Kolicina = kolicina
                        });
                    }
                }
            }

            return artikliStavke;
        }

        private void UpdateArtikliUkupnaCijena()
        {
            artikliUkupnaCijena = 0;

            for (int i = 0; i < (dgvArtikli.Rows.Count); i++)
            {
                decimal cijena = 0;
                int kolicina = 0;

                if (dgvArtikli.Rows[i].Cells["Cijena"].Value != null)
                {
                    cijena = decimal.Parse(dgvArtikli.Rows[i].Cells["Cijena"].Value.ToString());
                }
                if (dgvArtikli.Rows[i].Cells["Kolicina"].Value != null)
                {
                    kolicina = int.Parse(dgvArtikli.Rows[i].Cells["Kolicina"].Value.ToString());
                }

                artikliUkupnaCijena += (cijena * kolicina);
            }

            ukupnaCijena = rezervacijaCijena + artikliUkupnaCijena;

            txtArtikliCijenaUkupno.Text = artikliUkupnaCijena.ToString("0.##");
            txtCijenaUkupno.Text = ukupnaCijena.ToString("0.##");
        }

        private void UpdateRezervacijaCijenu(decimal rezervacijaCijena)
        {
            ukupnaCijena = rezervacijaCijena + artikliUkupnaCijena;
            txtCijenaRezervacije.Text = rezervacijaCijena.ToString("0.##");
            txtCijenaUkupno.Text = ukupnaCijena.ToString("0.##");
        }

        private void RezervacijaFormStatus(ProdajaRezervacijaType type)
        {
            rezervacijaType = type;

            if (type == ProdajaRezervacijaType.BezRezervacije)
            {
                cmbRezervacija.Enabled = false;
                btnRezervacijaInfo.Enabled = false;
                //
                cmbProjekcija.Enabled = false;
                btnProjekcijaInfo.Enabled = false;
                cmbKorisnik.Enabled = false;
                cmbBrojSjedista.Enabled = false;
                //
                UpdateRezervacijaCijenu(0);
            }
            else if (type == ProdajaRezervacijaType.PostojecaRezervacija)
            {
                cmbRezervacija.Enabled = true;
                btnRezervacijaInfo.Enabled = true;
                //
                cmbProjekcija.Enabled = false;
                btnProjekcijaInfo.Enabled = false;
                cmbKorisnik.Enabled = false;
                cmbBrojSjedista.Enabled = false;
                //
                var rezervacija = (RezervacijaModel)cmbRezervacija.SelectedItem;
                UpdateRezervacijaCijenu(rezervacija.Cijena);
            }
            else
            {
                cmbRezervacija.Enabled = false;
                btnRezervacijaInfo.Enabled = false;
                //
                cmbProjekcija.Enabled = true;
                btnProjekcijaInfo.Enabled = true;
                cmbKorisnik.Enabled = true;
                cmbBrojSjedista.Enabled = true;
                //
                var projekcija = (ProjekcijaModel)cmbProjekcija.SelectedItem;
                UpdateRezervacijaCijenu(projekcija.Cijena);
            }
        }

        #endregion
    }
}
