using KinoCentar.Shared.Models;
using KinoCentar.Shared.Util;
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
using KinoCentar.Shared.Extensions;

namespace KinoCentar.WinUI.Forms.Ankete
{
    public partial class frmAnketeEdit : Form
    {
        private WebAPIHelper anketeService = new WebAPIHelper(Global.ApiAddress, Global.AnketeRoute, Global.PrijavljeniKorisnik);

        private int _id { get; set; }
        private AnketaModel _a { get; set; }

        public frmAnketeEdit(int id)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

            _id = id;
            _a = null;
        }

        private void frmObavijestiEdit_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = anketeService.GetResponse(_id.ToString()).Handle();
            if (response.IsSuccessStatusCode)
            {
                _a = response.GetResponseResult<AnketaModel>();
                FillForm();
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                _a = null;
            }
        }

        private void FillForm()
        {
            txtNaslov.Text = _a.Naslov;

            foreach (var odgovor in _a.Odgovori)
            {
                if (odgovor.RedniBroj == 1)
                {
                    cbOdgovor1.Checked = true;
                    cbOdgovor1.Enabled = false;
                    txtOdgovor1.Text = odgovor.Odgovor;
                }
                if (odgovor.RedniBroj == 2)
                {
                    cbOdgovor2.Checked = true;
                    cbOdgovor2.Enabled = false;
                    txtOdgovor2.Text = odgovor.Odgovor;
                }
                if (odgovor.RedniBroj == 3)
                {
                    cbOdgovor3.Checked = true;
                    cbOdgovor3.Enabled = false;
                    txtOdgovor3.Text = odgovor.Odgovor;
                }
                if (odgovor.RedniBroj == 4)
                {
                    cbOdgovor4.Checked = true;
                    cbOdgovor4.Enabled = false;
                    txtOdgovor4.Text = odgovor.Odgovor;
                }
                if (odgovor.RedniBroj == 5)
                {
                    cbOdgovor5.Checked = true;
                    cbOdgovor5.Enabled = false;
                    txtOdgovor5.Text = odgovor.Odgovor;
                }
            }
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (_a != null && this.ValidateChildren())
            {
                _a.Naslov = txtNaslov.Text;

                if (cbOdgovor1.Checked)
                {
                    var odgovor1 = _a.Odgovori.FirstOrDefault(x => x.RedniBroj == 1);
                    if (odgovor1 != null)
                    {
                        odgovor1.Odgovor = txtOdgovor1.Text;
                    }
                    else
                    {
                        _a.Odgovori.Add(new AnketaOdgovorModel { AnketaId = _a.Id, Odgovor = txtOdgovor1.Text, RedniBroj = 1 });
                    }
                }
                if (cbOdgovor2.Checked)
                {
                    var odgovor2 = _a.Odgovori.FirstOrDefault(x => x.RedniBroj == 2);
                    if (odgovor2 != null)
                    {
                        odgovor2.Odgovor = txtOdgovor2.Text;
                    }
                    else
                    {
                        _a.Odgovori.Add(new AnketaOdgovorModel { AnketaId = _a.Id, Odgovor = txtOdgovor2.Text, RedniBroj = 2 });
                    }
                }
                if (cbOdgovor3.Checked)
                {
                    var odgovor3 = _a.Odgovori.FirstOrDefault(x => x.RedniBroj == 3);
                    if (odgovor3 != null)
                    {
                        odgovor3.Odgovor = txtOdgovor3.Text;
                    }
                    else
                    {
                        _a.Odgovori.Add(new AnketaOdgovorModel { AnketaId = _a.Id, Odgovor = txtOdgovor3.Text, RedniBroj = 3 });
                    }
                }
                if (cbOdgovor4.Checked)
                {
                    var odgovor4 = _a.Odgovori.FirstOrDefault(x => x.RedniBroj == 4);
                    if (odgovor4 != null)
                    {
                        odgovor4.Odgovor = txtOdgovor4.Text;
                    }
                    else
                    {
                        _a.Odgovori.Add(new AnketaOdgovorModel { AnketaId = _a.Id, Odgovor = txtOdgovor4.Text, RedniBroj = 4 });
                    }
                }
                if (cbOdgovor5.Checked)
                {
                    var odgovor5 = _a.Odgovori.FirstOrDefault(x => x.RedniBroj == 5);
                    if (odgovor5 != null)
                    {
                        odgovor5.Odgovor = txtOdgovor5.Text;
                    }
                    else
                    {
                        _a.Odgovori.Add(new AnketaOdgovorModel { AnketaId = _a.Id, Odgovor = txtOdgovor4.Text, RedniBroj = 5 });
                    }
                }

                HttpResponseMessage response = anketeService.PutResponse(_id, _a).Handle();
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.edit_anketa_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                errorProvider.SetError(txtNaslov, Messages.obavijest_name_req);
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
