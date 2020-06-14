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

namespace KinoCentar.WinUI.Forms.Filmovi
{
    public partial class frmFilmovi : Form
    {
        private WebAPIHelper filmoviService = new WebAPIHelper(Global.API_ADDRESS, Global.FilmoviRoute);

        public frmFilmovi()
        {
            InitializeComponent();
            dgvFilmovi.AutoGenerateColumns = false;
        }

        private void frmFilmovi_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid(string name = null)
        {
            var response = filmoviService.GetActionResponse("SearchByName", name).Handle();
            if (response.IsSuccessStatusCode)
            {
                dgvFilmovi.DataSource = response.GetResponseResult<List<FilmModel>>();
                dgvFilmovi.ClearSelection();
            }
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            BindGrid(txtNaslovPretraga.Text.Trim());
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            var frm = new frmFilmoviAdd();
            frm.ShowDialog();
            BindGrid();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frmFilmoviEdit(Convert.ToInt32(dgvFilmovi.SelectedRows[0].Cells[0].Value));
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
                var id = Convert.ToInt32(dgvFilmovi.SelectedRows[0].Cells[0].Value);

                DialogResult result = MessageBox.Show(Messages.del_film_prompt, Messages.msg_conf, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    HttpResponseMessage response = filmoviService.DeleteResponse(id).Handle();
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(Messages.del_film_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindGrid();
                    }
                }
            }
            catch
            {}
        }
    }
}
