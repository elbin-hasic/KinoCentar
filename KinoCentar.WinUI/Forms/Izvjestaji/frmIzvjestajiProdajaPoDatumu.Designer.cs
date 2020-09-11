namespace KinoCentar.WinUI.Forms.Izvjestaji
{
    partial class frmIzvjestajiProdajaPoDatumu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rwShowIzvjestaj = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumDo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ProdajaIzvjestajModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProdajaIzvjestajModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rwShowIzvjestaj
            // 
            this.rwShowIzvjestaj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rwShowIzvjestaj.Location = new System.Drawing.Point(0, 75);
            this.rwShowIzvjestaj.Name = "rwShowIzvjestaj";
            this.rwShowIzvjestaj.ServerReport.BearerToken = null;
            this.rwShowIzvjestaj.Size = new System.Drawing.Size(1182, 677);
            this.rwShowIzvjestaj.TabIndex = 0;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(841, 26);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(100, 26);
            this.btnPrikazi.TabIndex = 12;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Od datum:";
            // 
            // dtpDatumOd
            // 
            this.dtpDatumOd.Location = new System.Drawing.Point(92, 27);
            this.dtpDatumOd.Name = "dtpDatumOd";
            this.dtpDatumOd.Size = new System.Drawing.Size(320, 22);
            this.dtpDatumOd.TabIndex = 13;
            // 
            // dtpDatumDo
            // 
            this.dtpDatumDo.Location = new System.Drawing.Point(510, 27);
            this.dtpDatumDo.Name = "dtpDatumDo";
            this.dtpDatumDo.Size = new System.Drawing.Size(320, 22);
            this.dtpDatumDo.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Do datuma:";
            // 
            // ProdajaIzvjestajModelBindingSource
            // 
            this.ProdajaIzvjestajModelBindingSource.DataSource = typeof(KinoCentar.Shared.Models.Izvjestaji.ProdajaIzvjestajModel);
            // 
            // frmIzvjestajiProdajaPoDatumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.dtpDatumDo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDatumOd);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rwShowIzvjestaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmIzvjestajiProdajaPoDatumu";
            this.Text = "Izvještaj: Prodaja po datumu";
            this.Load += new System.EventHandler(this.frmIzvjestajiProdajaPoMjesecu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProdajaIzvjestajModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rwShowIzvjestaj;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDatumOd;
        private System.Windows.Forms.DateTimePicker dtpDatumDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource ProdajaIzvjestajModelBindingSource;
    }
}