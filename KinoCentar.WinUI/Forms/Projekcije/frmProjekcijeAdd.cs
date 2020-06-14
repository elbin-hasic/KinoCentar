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

namespace KinoCentar.WinUI.Forms.Projekcije
{
    public partial class frmProjekcijeAdd : Form
    {
        private WebAPIHelper projekcijeService = new WebAPIHelper(Global.API_ADDRESS, Global.ProjekcijeRoute);
        private WebAPIHelper filmoviService = new WebAPIHelper(Global.API_ADDRESS, Global.FilmoviRoute);
        private WebAPIHelper saleService = new WebAPIHelper(Global.API_ADDRESS, Global.SaleRoute);

        public frmProjekcijeAdd()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void frmProjekcijeAdd_Load(object sender, EventArgs e)
        {
            var filmoviResponse = filmoviService.GetResponse().Handle();
            if (filmoviResponse.IsSuccessStatusCode)
            {
                var filmovi = filmoviResponse.GetResponseResult<List<FilmModel>>();
                cmbFilm.DataSource = filmovi;
                cmbFilm.DisplayMember = "Naslov";
                cmbFilm.ValueMember = "Id";
            }

            var saleResponse = saleService.GetResponse().Handle();
            if (saleResponse.IsSuccessStatusCode)
            {
                var sale = saleResponse.GetResponseResult<List<SalaModel>>();
                cmbSala.DataSource = sale;
                cmbSala.DisplayMember = "Naziv";
                cmbSala.ValueMember = "Id";
            }
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                ProjekcijaModel p = new ProjekcijaModel();
                p.FilmId = ((FilmModel)cmbFilm.SelectedItem).Id;
                p.SalaId = ((SalaModel)cmbSala.SelectedItem).Id;

                p.Cijena = decimal.Parse(txtCijena.Text);
                p.VrijediOd = dtpVrijediOd.Value;
                p.VrijediDo = dtpVrijediDo.Value;
                p.Datum = DateTime.Now;

                HttpResponseMessage response = projekcijeService.PostResponse(p).Handle();
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.add_projekcija_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
