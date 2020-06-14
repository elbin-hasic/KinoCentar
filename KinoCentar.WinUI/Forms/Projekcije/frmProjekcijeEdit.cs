using KinoCentar.Shared.Models;
using KinoCentar.Shared.Util;
using KinoCentar.WinUI.Util;
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

namespace KinoCentar.WinUI.Forms.Projekcije
{
    public partial class frmProjekcijeEdit : Form
    {
        private WebAPIHelper projekcijeService = new WebAPIHelper(Global.API_ADDRESS, Global.ProjekcijeRoute);
        private WebAPIHelper filmoviService = new WebAPIHelper(Global.API_ADDRESS, Global.FilmoviRoute);
        private WebAPIHelper saleService = new WebAPIHelper(Global.API_ADDRESS, Global.SaleRoute);

        private int _id { get; set; }
        private ProjekcijaModel _p { get; set; }

        public frmProjekcijeEdit(int id)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

            _id = id;
            _p = null;
        }

        private void frmProjekcijeEdit_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = projekcijeService.GetResponse(_id.ToString()).Handle();
            if (response.IsSuccessStatusCode)
            {
                _p = response.GetResponseResult<ProjekcijaModel>();
                FillForm();
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                _p = null;
            }
        }

        private void FillForm()
        {
            var filmoviResponse = filmoviService.GetResponse().Handle();
            if (filmoviResponse.IsSuccessStatusCode)
            {
                var filmovi = filmoviResponse.GetResponseResult<List<FilmModel>>();
                cmbFilm.DataSource = filmovi;
                cmbFilm.DisplayMember = "Naslov";
                cmbFilm.ValueMember = "Id";
                foreach (var film in filmovi)
                {
                    if (film.Id == _p.FilmId)
                    {
                        cmbFilm.SelectedItem = film;
                        break;
                    }
                }
            }

            var saleResponse = saleService.GetResponse().Handle();
            if (saleResponse.IsSuccessStatusCode)
            {
                var sale = saleResponse.GetResponseResult<List<SalaModel>>();
                cmbSala.DataSource = sale;
                cmbSala.DisplayMember = "Naziv";
                cmbSala.ValueMember = "Id";
                foreach (var sala in sale)
                {
                    if (sala.Id == _p.SalaId)
                    {
                        cmbSala.SelectedItem = sala;
                        break;
                    }
                }
            }

            txtCijena.Text = _p.Cijena.ToString("0000.00");
            dtpVrijediOd.Value = _p.VrijediOd;
            dtpVrijediDo.Value = _p.VrijediDo;
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (_p != null && this.ValidateChildren())
            {
                _p.FilmId = ((FilmModel)cmbFilm.SelectedItem).Id;
                _p.SalaId = ((SalaModel)cmbSala.SelectedItem).Id;
                
                _p.Cijena = Convert.ToDecimal(txtCijena.Text);
                _p.VrijediOd = dtpVrijediOd.Value;
                _p.VrijediDo = dtpVrijediDo.Value;

                HttpResponseMessage response = projekcijeService.PutResponse(_id, _p).Handle();
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.edit_projekcija_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
