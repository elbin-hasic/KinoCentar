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
using KinoCentar.Shared.Models;
using KinoCentar.Shared.Util;
using KinoCentar.WinUI.Util;
using KinoCentar.WinUI.Extensions;
using KinoCentar.Shared.Extensions;
using System.Windows.Forms.DataVisualization.Charting;

namespace KinoCentar.WinUI.Forms.Ankete
{
    public partial class frmAnketeDetails : Form
    {
        private WebAPIHelper anketeService = new WebAPIHelper(Global.ApiAddress, Global.AnketeRoute, Global.PrijavljeniKorisnik);

        Chart pieChart;

        private int _id { get; set; }
        private AnketaModel _a { get; set; }

        public frmAnketeDetails(int id)
        {
            InitializeComponent();

            _id = id;
            _a = null;

            InitializeChart();
        }

        private void frmAnketeDetails_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = anketeService.GetResponse(_id.ToString()).Handle();
            if (response.IsSuccessStatusCode)
            {
                _a = response.GetResponseResult<AnketaModel>();
                LoadPieChart();
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                _a = null;
            }            
        }

        private void InitializeChart()
        {
            this.components = new System.ComponentModel.Container();
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend()
            { 
                BackColor = Color.LightBlue, 
                ForeColor = Color.Black, 
                Title = "Ponuđeni odgovori:" };

            pieChart = new Chart();

            ((ISupportInitialize)(pieChart)).BeginInit();

            SuspendLayout();

            //===Pie chart
            chartArea1.Name = "PieChartArea";
            pieChart.ChartAreas.Add(chartArea1);
            pieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            pieChart.Legends.Add(legend1);
            pieChart.Location = new System.Drawing.Point(0, 50);

            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            ((ISupportInitialize)(this.pieChart)).EndInit();

            this.ResumeLayout(false);
        }

        void LoadPieChart()
        {
            pieChart.Series.Clear();
            pieChart.Palette = ChartColorPalette.Fire;
            pieChart.BackColor = Color.White;
            pieChart.Titles.Add(_a.Naslov);
            pieChart.ChartAreas[0].BackColor = Color.Transparent;

            Series series1 = new Series
            {
                Name = "series1",
                IsVisibleInLegend = true,
                Color = System.Drawing.Color.Green,
                ChartType = SeriesChartType.Pie
            };

            pieChart.Series.Add(series1);

            for (int i = 0; i < _a.Odgovori.Count(); i++)
            {
                var odgovor = _a.Odgovori[i];

                series1.Points.Add(odgovor.UkupnoIzabrano);
                var p = series1.Points[i];
                p.AxisLabel = odgovor.UkupnoIzabrano.ToString();
                p.LegendText = odgovor.Odgovor;
            }

            pieChart.Invalidate();
            pnlPie.Controls.Add(pieChart);
        }
    }
}
