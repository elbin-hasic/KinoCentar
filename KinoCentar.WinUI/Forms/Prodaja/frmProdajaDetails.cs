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
using KinoCentar.WinUI.Forms.Filmovi;
using KinoCentar.WinUI.Forms.Projekcije;

namespace KinoCentar.WinUI.Forms.Prodaja
{
    public partial class frmProdajaDetails : Form
    {
        private WebAPIHelper prodajaService = new WebAPIHelper(Global.ApiAddress, Global.ProdajaRoute);
        private WebAPIHelper projekcijeService = new WebAPIHelper(Global.ApiAddress, Global.ProjekcijeRoute);
        private WebAPIHelper artikliService = new WebAPIHelper(Global.ApiAddress, Global.ArtikliRoute);

        private int _id { get; set; }
        private ProdajaModel _r { get; set; }

        public frmProdajaDetails(int id)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

            _id = id;
            _r = null;
        }

        private void frmProdajaDetails_Load(object sender, EventArgs e)
        {

        }

        private void FillForm()
        {
            
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (_r != null && this.ValidateChildren())
            {
                /*_r.ProjekcijaId = ((ProjekcijaModel)cmbProjekcija.SelectedItem).Id;
                if (cmbKorisnik.SelectedIndex != 0)
                {
                    _r.KorisnikId = ((KorisnikModel)cmbKorisnik.SelectedItem).Id;
                }
                if (cmbBrojSjedista.SelectedIndex != 0)
                {
                    _r.BrojSjedista = Convert.ToInt32(cmbBrojSjedista.SelectedItem);
                }

                _r.DatumProjekcije = dtpDatumProjekcije.Value;

                HttpResponseMessage response = rezervacijeService.PutResponse(_id, _r).Handle();
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.edit_rezervacija_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }*/
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
