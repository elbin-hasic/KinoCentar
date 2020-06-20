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

namespace KinoCentar.WinUI.Forms.Obavijesti
{
    public partial class frmObavijesti : Form
    {
        private WebAPIHelper obavijestiService = new WebAPIHelper(Global.ApiAddress, Global.ObavijestiRoute, Global.PrijavljeniKorisnik);

        public frmObavijesti()
        {
            InitializeComponent();
            dgvObavijesti.AutoGenerateColumns = false;
        }

        private void frmObavijesti_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid(string name = null)
        {
            HttpResponseMessage response = obavijestiService.GetActionResponse("SearchByName", name).Handle();
            if (response.IsSuccessStatusCode)
            {
                dgvObavijesti.DataSource = response.GetResponseResult<List<ObavijestModel>>();
                dgvObavijesti.ClearSelection();
            }
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            BindGrid(txtNaslovPretraga.Text.Trim());
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            var frm = new frmObavijestiAdd();
            frm.ShowDialog();
            BindGrid();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frmObavijestiEdit(Convert.ToInt32(dgvObavijesti.SelectedRows[0].Cells[0].Value));
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
                var id = Convert.ToInt32(dgvObavijesti.SelectedRows[0].Cells[0].Value);

                DialogResult result = MessageBox.Show(Messages.del_obavijest_prompt, Messages.msg_conf, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    HttpResponseMessage response = obavijestiService.DeleteResponse(id).Handle();
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(Messages.del_obavijest_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindGrid();
                    }
                }
            }
            catch
            { }
        }
    }
}
