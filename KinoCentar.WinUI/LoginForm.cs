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
using KinoCentar.Shared.Extensions;

namespace KinoCentar.WinUI
{
    public partial class LoginForm : Form
    {
        private WebAPIHelper korisniciService = new WebAPIHelper(Global.ApiAddress, Global.KorisniciRoute);

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Prijava()
        {
            HttpResponseMessage response = korisniciService.GetActionResponse("GetByUserName", txtKorisnickoIme.Text).Handle();

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                MessageBox.Show(Messages.login_user_err, Messages.msg_err, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (response.IsSuccessStatusCode)
            {
                var korisnik = response.GetResponseResult<KorisnikModel>();
                if (Util.UIHelper.GenerateHash(korisnik.LozinkaSalt, txtLozinka.Text) == korisnik.LozinkaHash)
                {
                    this.DialogResult = DialogResult.OK;
                    korisnik.Lozinka = txtLozinka.Text;
                    Global.PrijavljeniKorisnik = korisnik;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(Messages.login_pass_err, Messages.msg_err, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLozinka.Text = String.Empty;
                }
            }
        }

        private void btnPotvrda_Click(object sender, EventArgs e)
        {
            Prijava();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLozinka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Prijava();
            }                
        }
    }
}
