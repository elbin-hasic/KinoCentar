using KinoCentar.PCL.Models;
using KinoCentar.PCL.Util;
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

namespace KinoCentar.WinUI.Zanrovi
{
    public partial class frmZanroviAdd : Form
    {
        private WebAPIHelper zanroviService = new WebAPIHelper(Global.API_ADDRESS, Global.ZanroviRoute);

        public frmZanroviAdd()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                Zanr zanr = new Zanr();
                zanr.Naziv = txtNaziv.Text;
                zanr.Opis = txtOpis.Text;

                HttpResponseMessage response = zanroviService.PostResponse(zanr);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.add_genre_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    string msg = response.ReasonPhrase;

                    if (!String.IsNullOrEmpty(Messages.ResourceManager.GetString(response.ReasonPhrase)))
                        msg = Messages.ResourceManager.GetString(response.ReasonPhrase);

                    MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + msg);
                }
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Da li ste sigurni da želite odustati", Messages.msg_conf, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        #region Validation

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtNaziv.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNaziv, Messages.genre_name_req);
            }
            else if (txtNaziv.TextLength < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(txtNaziv, Messages.genre_name_err);
            }
            else
            {
                errorProvider.SetError(txtNaziv, null);
            }
        }

        #endregion
    }
}
