namespace KinoCentar.WinUI.Forms.Izvjestaji
{
    partial class frmIzvjestajiRezervacijePoDatumu
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
            this.dtpDatumDo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rwShowIzvjestaj = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbIskoristeneShow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // dtpDatumDo
            // 
            this.dtpDatumDo.Location = new System.Drawing.Point(510, 27);
            this.dtpDatumDo.Name = "dtpDatumDo";
            this.dtpDatumDo.Size = new System.Drawing.Size(320, 22);
            this.dtpDatumDo.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Do datuma:";
            // 
            // dtpDatumOd
            // 
            this.dtpDatumOd.Location = new System.Drawing.Point(92, 27);
            this.dtpDatumOd.Name = "dtpDatumOd";
            this.dtpDatumOd.Size = new System.Drawing.Size(320, 22);
            this.dtpDatumOd.TabIndex = 19;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(985, 26);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(100, 26);
            this.btnPrikazi.TabIndex = 18;
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
            this.label2.TabIndex = 17;
            this.label2.Text = "Od datum:";
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
            this.rwShowIzvjestaj.TabIndex = 16;
            // 
            // cbIskoristeneShow
            // 
            this.cbIskoristeneShow.AutoSize = true;
            this.cbIskoristeneShow.Location = new System.Drawing.Point(841, 28);
            this.cbIskoristeneShow.Name = "cbIskoristeneShow";
            this.cbIskoristeneShow.Size = new System.Drawing.Size(138, 21);
            this.cbIskoristeneShow.TabIndex = 22;
            this.cbIskoristeneShow.Text = "Samo iskorištene";
            this.cbIskoristeneShow.UseVisualStyleBackColor = true;
            // 
            // frmIzvjestajiRezervacijePoDatumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.cbIskoristeneShow);
            this.Controls.Add(this.dtpDatumDo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDatumOd);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rwShowIzvjestaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmIzvjestajiRezervacijePoDatumu";
            this.Text = "Izvještaj: Rezervacije po datumu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDatumDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDatumOd;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer rwShowIzvjestaj;
        private System.Windows.Forms.CheckBox cbIskoristeneShow;
    }
}