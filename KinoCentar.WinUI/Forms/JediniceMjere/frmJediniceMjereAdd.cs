﻿using KinoCentar.Shared.Models;
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

namespace KinoCentar.WinUI.Forms.JediniceMjere
{
    public partial class frmJediniceMjereAdd : Form
    {
        private WebAPIHelper jediniceMjereService = new WebAPIHelper(Global.ApiAddress, Global.JediniceMjereRoute, Global.PrijavljeniKorisnik);

        public frmJediniceMjereAdd()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                JedinicaMjereModel jedMjere = new JedinicaMjereModel();
                jedMjere.KratkiNaziv = txtKratkiNaziv.Text;
                jedMjere.Naziv = txtNaziv.Text;

                HttpResponseMessage response = jediniceMjereService.PostResponse(jedMjere).Handle();
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.add_jedMjere_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtKratkiNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtKratkiNaziv.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtKratkiNaziv, Messages.jedMjere_shortName_err);
            }
            else
            {
                errorProvider.SetError(txtKratkiNaziv, null);
            }
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtNaziv.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNaziv, Messages.jedMjere_name_req);
            }
            else if (txtNaziv.TextLength < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(txtNaziv, Messages.jedMjere_name_err);
            }
            else
            {
                errorProvider.SetError(txtNaziv, null);
            }
        }

        #endregion
    }
}
