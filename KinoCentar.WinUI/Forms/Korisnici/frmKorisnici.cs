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

namespace KinoCentar.WinUI.Forms.Korisnici
{
    public partial class frmKorisnici : Form
    {
        private WebAPIHelper korisniciService = new WebAPIHelper(Global.ApiAddress, Global.KorisniciRoute);

        public frmKorisnici()
        {
            InitializeComponent();
            dgvKorisnici.AutoGenerateColumns = false;
        }

        private void frmKorisnici_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid(string firstName = null, string lastName = null)
        {
            HttpResponseMessage response = korisniciService.GetActionSearchResponse("SearchByName", firstName, lastName).Handle();
            if (response.IsSuccessStatusCode)
            {
                dgvKorisnici.DataSource = response.GetResponseResult<List<KorisnikModel>>();
                dgvKorisnici.ClearSelection();
            }
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            BindGrid(txtImePretraga.Text.Trim(), txtPrezimePretraga.Text.Trim());
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            frmKorisniciAdd frm = new frmKorisniciAdd();
            frm.ShowDialog();
            BindGrid();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            try
            {
                frmKorisniciEdit frm = new frmKorisniciEdit(Convert.ToInt32(dgvKorisnici.SelectedRows[0].Cells[0].Value));
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
                var id = Convert.ToInt32(dgvKorisnici.SelectedRows[0].Cells[0].Value);

                DialogResult result = MessageBox.Show(Messages.del_user_prompt, Messages.msg_conf, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    HttpResponseMessage response = korisniciService.DeleteResponse(id).Handle();
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(Messages.del_user_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindGrid();
                    }
                }
            }
            catch
            {}
        }
    }
}
