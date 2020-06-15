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

namespace KinoCentar.WinUI.Forms.Artikli
{
    public partial class frmArtikliEdit : Form
    {
        private WebAPIHelper artikliService = new WebAPIHelper(Global.ApiAddress, Global.ArtikliRoute);
        private WebAPIHelper jedMjereService = new WebAPIHelper(Global.ApiAddress, Global.JediniceMjereRoute);

        private int _id { get; set; }
        private ArtikalModel _a { get; set; }

        public frmArtikliEdit(int id)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

            _id = id;
            _a = null;
        }

        private void frmArtikliEdit_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = artikliService.GetResponse(_id.ToString()).Handle();
            if (response.IsSuccessStatusCode)
            {
                _a = response.GetResponseResult<ArtikalModel>();
                FillForm();
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                _a = null;
            }
        }

        private void FillForm()
        {
            var jedMjereResponse = jedMjereService.GetResponse().Handle();
            if (jedMjereResponse.IsSuccessStatusCode)
            {
                var jedMjere = jedMjereResponse.GetResponseResult<List<JedinicaMjereModel>>();
                cmbJedinicaMjere.DataSource = jedMjere;
                cmbJedinicaMjere.DisplayMember = "PuniNaziv";
                cmbJedinicaMjere.ValueMember = "Id";
                foreach (var jedMjera in jedMjere)
                {
                    if (jedMjera.Id == _a.JedinicaMjereId)
                    {
                        cmbJedinicaMjere.SelectedItem = jedMjera;
                        break;
                    }
                }
            }

            txtCijena.Text = _a.Cijena.ToString("0000.00");
            txtNaziv.Text = _a.Naziv;
            txtSifra.Text = _a.Sifra;

            if (_a.Slika != null)
            {
                pbSlika.Image = (Bitmap)((new ImageConverter()).ConvertFrom(_a.Slika));
            }
        }

        private void btnIzaberiPlakat_Click(object sender, EventArgs e)
        {
            try
            {
                using (var openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.ShowDialog();
                    txtSlika.Text = openFileDialog.FileName;
                }

                var slikaData = Util.UIHelper.PrepareSaveImage(txtSlika.Text);
                if (slikaData != null)
                {
                    _a.Slika = slikaData.OriginalImageBytes;
                    _a.SlikaThumb = slikaData.CroppedImageBytes;
                    pbSlika.Image = slikaData.OriginalImage;
                }
            }
            catch
            {
                txtSlika.Text = null;
            }
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (_a != null && this.ValidateChildren())
            {
                _a.JedinicaMjereId = ((JedinicaMjereModel)cmbJedinicaMjere.SelectedItem).Id;
                
                _a.Naziv = txtNaziv.Text;
                _a.Sifra = txtSifra.Text;
                _a.Cijena = decimal.Parse(txtCijena.Text);

                HttpResponseMessage response = artikliService.PutResponse(_id, _a).Handle();
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.edit_artikal_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
