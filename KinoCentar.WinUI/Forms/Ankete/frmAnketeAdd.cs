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

namespace KinoCentar.WinUI.Forms.Ankete
{
    public partial class frmAnketeAdd : Form
    {
        private WebAPIHelper anketeService = new WebAPIHelper(Global.ApiAddress, Global.AnketeRoute, Global.PrijavljeniKorisnik);

        public frmAnketeAdd()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var a = new AnketaModel();
                a.Naslov = txtNaslov.Text;
                a.Datum = DateTime.Now;
                a.KorisnikId = Global.PrijavljeniKorisnik.Id;

                var odgovori = new List<AnketaOdgovorModel>();
                if (cbOdgovor1.Checked)
                {
                    odgovori.Add(new AnketaOdgovorModel { Odgovor = txtOdgovor1.Text, RedniBroj = 1 });
                }
                if (cbOdgovor2.Checked)
                {
                    odgovori.Add(new AnketaOdgovorModel { Odgovor = txtOdgovor2.Text, RedniBroj = 2 });
                }
                if (cbOdgovor3.Checked)
                {
                    odgovori.Add(new AnketaOdgovorModel { Odgovor = txtOdgovor3.Text, RedniBroj = 3 });
                }
                if (cbOdgovor4.Checked)
                {
                    odgovori.Add(new AnketaOdgovorModel { Odgovor = txtOdgovor4.Text, RedniBroj = 4 });
                }
                if (cbOdgovor5.Checked)
                {
                    odgovori.Add(new AnketaOdgovorModel { Odgovor = txtOdgovor5.Text, RedniBroj = 5 });
                }

                a.Odgovori = odgovori;

                HttpResponseMessage response = anketeService.PostResponse(a).Handle();
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.add_anketa_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtNaslov_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNaslov.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNaslov, Messages.anketa_name_req);
            }
            else
            {
                errorProvider.SetError(txtNaslov, null);
            }
        }

        #endregion

        private void cbOdgovor1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOdgovor1.Checked)
            {
                txtOdgovor1.ReadOnly = false;
            }
            else
            {
                txtOdgovor1.Text = string.Empty;
                txtOdgovor1.ReadOnly = true;
            }
        }

        private void cbOdgovor2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOdgovor2.Checked)
            {
                txtOdgovor2.ReadOnly = false;
            }
            else
            {
                txtOdgovor2.Text = string.Empty;
                txtOdgovor2.ReadOnly = true;
            }
        }

        private void cbOdgovor3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOdgovor3.Checked)
            {
                txtOdgovor3.ReadOnly = false;
            }
            else
            {
                txtOdgovor3.Text = string.Empty;
                txtOdgovor3.ReadOnly = true;
            }
        }

        private void cbOdgovor4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOdgovor4.Checked)
            {
                txtOdgovor4.ReadOnly = false;
            }
            else
            {
                txtOdgovor4.Text = string.Empty;
                txtOdgovor4.ReadOnly = true;
            }
        }

        private void cbOdgovor5_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOdgovor5.Checked)
            {
                txtOdgovor5.ReadOnly = false;
            }
            else
            {
                txtOdgovor5.Text = string.Empty;
                txtOdgovor5.ReadOnly = true;
            }
        }
    }
}
