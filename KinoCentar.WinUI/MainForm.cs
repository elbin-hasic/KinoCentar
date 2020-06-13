using KinoCentar.WinUI.JediniceMjere;
using KinoCentar.WinUI.Sale;
using KinoCentar.WinUI.Zanrovi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinoCentar.WinUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void zanroviToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmZanrovi frm = new frmZanrovi();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;

            frm.Show();
        }

        private void saleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSale frm = new frmSale();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;

            frm.Show();
        }

        private void jediniceMjereToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmJediniceMjere frm = new frmJediniceMjere();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;

            frm.Show();
        }
    }
}
