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

namespace KinoCentar.WinUI.Forms.Dojmovi
{
    public partial class frmDojmovi : Form
    {
        private WebAPIHelper dojmoviService = new WebAPIHelper(Global.ApiAddress, Global.DojmoviRoute);

        public frmDojmovi()
        {
            InitializeComponent();
            dgvDojmovi.AutoGenerateColumns = false;
        }

        private void frmDojmovi_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid(string name = null)
        {
            var response = dojmoviService.GetActionResponse("SearchByName", name).Handle();            
            if (response.IsSuccessStatusCode)
            {
                dgvDojmovi.DataSource = response.GetResponseResult<List<DojamModel>>();
                dgvDojmovi.ClearSelection();
            }
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            BindGrid(txtNazivPretraga.Text.Trim());
        }
    }
}
