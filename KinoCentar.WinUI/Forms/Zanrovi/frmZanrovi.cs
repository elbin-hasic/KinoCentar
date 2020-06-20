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

namespace KinoCentar.WinUI.Forms.Zanrovi
{
    public partial class frmZanrovi : Form
    {
        private WebAPIHelper zanroviService = new WebAPIHelper(Global.ApiAddress, Global.ZanroviRoute, Global.PrijavljeniKorisnik);

        public frmZanrovi()
        {
            InitializeComponent();
            dgvZanrovi.AutoGenerateColumns = false;
        }

        private void frmZanrovi_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid(string name = null)
        {
            HttpResponseMessage response = zanroviService.GetActionResponse("SearchByName", name).Handle();
            if (response.IsSuccessStatusCode)
            {
                dgvZanrovi.DataSource = response.GetResponseResult<List<ZanrModel>>();
                dgvZanrovi.ClearSelection();
            }
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            BindGrid(txtNazivPretraga.Text.Trim());
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            frmZanroviAdd frm = new frmZanroviAdd();
            frm.ShowDialog();
            BindGrid();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            try
            {
                frmZanroviEdit frm = new frmZanroviEdit(Convert.ToInt32(dgvZanrovi.SelectedRows[0].Cells[0].Value));
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
                var id = Convert.ToInt32(dgvZanrovi.SelectedRows[0].Cells[0].Value);

                DialogResult result = MessageBox.Show(Messages.del_genre_prompt, Messages.msg_conf, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    HttpResponseMessage response = zanroviService.DeleteResponse(id).Handle();
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(Messages.del_genre_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindGrid();
                    }
                }
            }
            catch
            { }
        }
    }
}
