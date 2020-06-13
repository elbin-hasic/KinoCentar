using KinoCentar.PCL.Models;
using KinoCentar.PCL.Util;
using KinoCentar.Shared.Models;
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

namespace KinoCentar.WinUI.TipoviKorisnika
{
    public partial class frmTipoviKorisnika : Form
    {
        private WebAPIHelper tipoviKorisnikaService = new WebAPIHelper(Global.API_ADDRESS, Global.TipoviKorisnikaRoute);

        public frmTipoviKorisnika()
        {
            InitializeComponent();
            dgvTipoviKorisnika.AutoGenerateColumns = false;
        }

        private void frmTipoviKorisnika_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid(string name = null)
        {
            var response = tipoviKorisnikaService.GetActionResponse("SearchByName", name).Handle();            
            if (response.IsSuccessStatusCode)
            {
                dgvTipoviKorisnika.DataSource = response.GetResponseResult<List<TipKorisnika>>();
                dgvTipoviKorisnika.ClearSelection();
            }
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            BindGrid(txtNazivPretraga.Text.Trim());
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            var frm = new frmTipoviKorisnikaAdd();
            frm.ShowDialog();
            BindGrid();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            var frm = new frmTipoviKorisnikaEdit(Convert.ToInt32(dgvTipoviKorisnika.SelectedRows[0].Cells[0].Value));
            frm.ShowDialog();
            BindGrid();
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgvTipoviKorisnika.SelectedRows[0].Cells[0].Value);

            DialogResult result = MessageBox.Show(Messages.del_tipKorisnika_prompt, Messages.msg_conf, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var response = tipoviKorisnikaService.DeleteResponse(id).Handle();
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.del_tipKorisnika_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindGrid();
                }
            }
        }
    }
}
