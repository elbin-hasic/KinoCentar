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
using KinoCentar.Shared.Models.Enums;
using KinoCentar.Shared.Util;
using KinoCentar.WinUI.Extensions;
using KinoCentar.WinUI.Forms.Artikli;
using KinoCentar.WinUI.Forms.Dojmovi;
using KinoCentar.WinUI.Forms.Filmovi;
using KinoCentar.WinUI.Forms.FilmskeLicnosti;
using KinoCentar.WinUI.Forms.JediniceMjere;
using KinoCentar.WinUI.Forms.Korisnici;
using KinoCentar.WinUI.Forms.Obavijesti;
using KinoCentar.WinUI.Forms.Prodaja;
using KinoCentar.WinUI.Forms.Projekcije;
using KinoCentar.WinUI.Forms.Rezervacije;
using KinoCentar.WinUI.Forms.Sale;
using KinoCentar.WinUI.Forms.TipoviKorisnika;
using KinoCentar.WinUI.Forms.Zanrovi;

namespace KinoCentar.WinUI
{
    public partial class MainForm : Form
    {
        private TipKorisnikaType? tipKorisnika = null;

        public MainForm()
        {
            InitializeComponent();

            if (Global.PrijavljeniKorisnik != null)
            {
                tipKorisnika = Global.PrijavljeniKorisnik.TipKorisnika?.Type;
                lblUserToolStripStatus.Text = $"Korisnik: {Global.PrijavljeniKorisnik.ImePrezime}";
            }
            else
            {
                MessageBox.Show("Prijava na sistem nije uspjela, pojavila se greška!", Messages.msg_err, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (tipKorisnika != null)
            {
                switch (tipKorisnika.Value)
                {
                    case TipKorisnikaType.Administrator:
                        administracijaToolStripMenuItem.Enabled = true;
                        filmoviToolStripMenuItem.Enabled = true;
                        projekcijeToolStripMenuItem.Enabled = true;
                        artikliToolStripMenuItem.Enabled = true;
                        izvjestajiToolStripMenuItem.Enabled = true;
                        obavijestiToolStripMenuItem.Enabled = true;
                        dojmoviToolStripMenuItem.Enabled = true;
                        //
                        rezervacijeToolStripMenuItem.Enabled = true;
                        prodajaToolStripMenuItem.Enabled = true;
                        break;
                    case TipKorisnikaType.Moderator:
                        filmoviToolStripMenuItem.Enabled = true;
                        projekcijeToolStripMenuItem.Enabled = true;
                        artikliToolStripMenuItem.Enabled = true;
                        izvjestajiToolStripMenuItem.Enabled = true;
                        obavijestiToolStripMenuItem.Enabled = true;
                        dojmoviToolStripMenuItem.Enabled = true;
                        break;
                    case TipKorisnikaType.Radnik:
                        rezervacijeToolStripMenuItem.Enabled = true;
                        prodajaToolStripMenuItem.Enabled = true;
                        break;
                }
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

        #region Prodaja

        private void prodajaNovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmProdajaAdd();
            frm.MdiParent = this;

            frm.Show();
        }

        private void prodajaListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmProdaja();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;

            frm.Show();
        }

        #endregion
    }
}
