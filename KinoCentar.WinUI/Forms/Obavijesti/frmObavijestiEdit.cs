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

namespace KinoCentar.WinUI.Forms.Obavijesti
{
    public partial class frmObavijestiEdit : Form
    {
        private WebAPIHelper obavijestiService = new WebAPIHelper(Global.ApiAddress, Global.ObavijestiRoute);

        private int _id { get; set; }
        private ObavijestModel _o { get; set; }

        public frmObavijestiEdit(int id)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

            _id = id;
            _o = null;
        }

        private void frmObavijestiEdit_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = obavijestiService.GetResponse(_id.ToString()).Handle();
            if (response.IsSuccessStatusCode)
            {
                _o = response.GetResponseResult<ObavijestModel>();
                FillForm();
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                _o = null;
            }
        }

        private void FillForm()
        {
            txtNaslov.Text = _o.Naslov;
            txtTekst.Text = _o.Tekst;
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (_o != null && this.ValidateChildren())
            {
                _o.Naslov = txtNaslov.Text;
                _o.Tekst = txtTekst.Text;

                HttpResponseMessage response = obavijestiService.PutResponse(_id, _o).Handle();
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.edit_genre_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        

        #endregion
    }
}
