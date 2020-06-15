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

namespace KinoCentar.WinUI.Forms.FilmskeLicnosti
{
    public partial class frmFilmskeLicnosti : Form
    {
        private WebAPIHelper filmskeLicnostiService = new WebAPIHelper(Global.ApiAddress, Global.FilmskeLicnostiRoute);

        public frmFilmskeLicnosti()
        {
            InitializeComponent();
            dgvFilmskeLicnosti.AutoGenerateColumns = false;
        }

        private void frmFilmskeLicnosti_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid(string firstName = null, string lastName = null)
        {
            HttpResponseMessage response = filmskeLicnostiService.GetActionSearchResponse("SearchByName", firstName, lastName).Handle();           
            if (response.IsSuccessStatusCode)
            {
                dgvFilmskeLicnosti.DataSource = response.GetResponseResult<List<FilmskaLicnostModel>>();
                dgvFilmskeLicnosti.ClearSelection();
            }
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            BindGrid(txtImePretraga.Text.Trim(), txtPrezimePretraga.Text.Trim());
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            var frm = new frmFilmskeLicnostiAdd();
            frm.ShowDialog();
            BindGrid();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frmFilmskeLicnostiEdit(Convert.ToInt32(dgvFilmskeLicnosti.SelectedRows[0].Cells[0].Value));
                frm.ShowDialog();
                BindGrid();
            }
            catch
            {}
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(dgvFilmskeLicnosti.SelectedRows[0].Cells[0].Value);

                DialogResult result = MessageBox.Show(Messages.del_filmskaLicnost_prompt, Messages.msg_conf, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var response = filmskeLicnostiService.DeleteResponse(id).Handle();
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(Messages.del_filmskaLicnost_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindGrid();
                    }
                }
            }
            catch
            {}            
        }
    }
}
