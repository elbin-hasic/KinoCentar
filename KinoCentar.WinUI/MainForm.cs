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
using KinoCentar.WinUI.Extensions;
using KinoCentar.WinUI.Forms.Artikli;
using KinoCentar.WinUI.Forms.Dojmovi;
using KinoCentar.WinUI.Forms.Filmovi;
using KinoCentar.WinUI.Forms.FilmskeLicnosti;
using KinoCentar.WinUI.Forms.JediniceMjere;
using KinoCentar.WinUI.Forms.Korisnici;
using KinoCentar.WinUI.Forms.Obavijesti;
using KinoCentar.WinUI.Forms.Projekcije;
using KinoCentar.WinUI.Forms.Rezervacije;
using KinoCentar.WinUI.Forms.Sale;
using KinoCentar.WinUI.Forms.TipoviKorisnika;
using KinoCentar.WinUI.Forms.Zanrovi;

namespace KinoCentar.WinUI
{
    public partial class MainForm : Form
    {
        private WebAPIHelper korisniciService = new WebAPIHelper(Global.ApiAddress, Global.KorisniciRoute);

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = korisniciService.GetActionResponse("GetByUserName", "admin").Handle();
            if (response.IsSuccessStatusCode)
            {
                var k = response.GetResponseResult<KorisnikModel>();
                Global.PrijavljeniKorisnik = k;
            }
        }

        #region Administracija

        private void korisniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmKorisnici();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;

            frm.Show();
        }

        private void tipoviKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmTipoviKorisnika();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;

            frm.Show();
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmSale();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;

            frm.Show();
        }

        private void zanroviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmZanrovi();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;

            frm.Show();
        }

        private void jediniceMjereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmJediniceMjere();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;

            frm.Show();
        }

        private void filmskeLicnostiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmFilmskeLicnosti();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;

            frm.Show();
        }

        #endregion

        #region Filmovi

        private void filmoviNoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmFilmoviAdd();
            frm.MdiParent = this;

            frm.Show();
        }

        private void filmoviListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmFilmovi();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;

            frm.Show();
        }

        #endregion

        #region Projekcije

        private void projekcijeNovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmProjekcijeAdd();
            frm.MdiParent = this;

            frm.Show();
        }

        private void projekcijeListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmProjekcije();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;

            frm.Show();
        }

        #endregion

        #region Artikli

        private void artilkiNoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmArtikliAdd();
            frm.MdiParent = this;

            frm.Show();
        }

        private void artikliListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmArtikli();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;

            frm.Show();
        }

        #endregion

        #region Obavijesti

        private void obavijestiNovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmObavijestiAdd();
            frm.MdiParent = this;

            frm.Show();
        }

        private void obavijestiListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmObavijesti();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;

            frm.Show();
        }

        #endregion

        #region Dojmovi

        private void dojmoviListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmDojmovi();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;

            frm.Show();
        }

        #endregion

        #region Rezervacije

        private void rezervacijeNovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmRezervacijeAdd();
            frm.MdiParent = this;

            frm.Show();
        }

        private void rezervacijeListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmRezervacije();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;

            frm.Show();
        }

        #endregion
    }
}
