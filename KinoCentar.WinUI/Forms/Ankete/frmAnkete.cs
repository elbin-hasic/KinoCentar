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
    public partial class frmAnkete : Form
    {
        private WebAPIHelper anketeService = new WebAPIHelper(Global.ApiAddress, Global.AnketeRoute, Global.PrijavljeniKorisnik);

        public frmAnkete()
        {
            InitializeComponent();
            dgvAnkete.AutoGenerateColumns = false;
        }

        private void frmAnkete_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid(string name = null)
        {
            HttpResponseMessage response = anketeService.GetActionResponse("SearchByName", name).Handle();
            if (response.IsSuccessStatusCode)
            {
                dgvAnkete.DataSource = response.GetResponseResult<List<AnketaModel>>();
                dgvAnkete.ClearSelection();
            }
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            BindGrid(txtNaslovPretraga.Text.Trim());
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            var frm = new frmAnketeAdd();
            frm.ShowDialog();
            BindGrid();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frmAnketeEdit(Convert.ToInt32(dgvAnkete.SelectedRows[0].Cells[0].Value));
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
                var id = Convert.ToInt32(dgvAnkete.SelectedRows[0].Cells[0].Value);

                DialogResult result = MessageBox.Show(Messages.del_anketa_prompt, Messages.msg_conf, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    HttpResponseMessage response = anketeService.DeleteResponse(id).Handle();
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(Messages.del_anketa_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindGrid();
                    }
                }
            }
            catch
            { }
        }

        private void btnZakljucaj_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(dgvAnkete.SelectedRows[0].Cells[0].Value);

                DialogResult result = MessageBox.Show(Messages.close_anketa_prompt, Messages.msg_conf, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    HttpResponseMessage response = anketeService.PutActionResponse("Close", id).Handle();
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(Messages.close_anketa_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindGrid();
                    }
                }
            }
            catch (Exception ex)
            { }
        }
    }
}
