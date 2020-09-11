namespace KinoCentar.WinUI.Forms.Rezervacije
{
    partial class frmRezervacijeEdit
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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbBrojSjedista = new System.Windows.Forms.ComboBox();
            this.btnProjekcijaInfo = new System.Windows.Forms.Button();
            this.dtpDatumProjekcije = new System.Windows.Forms.DateTimePicker();
            this.cmbKorisnik = new System.Windows.Forms.ComboBox();
            this.cmbProjekcija = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.brnNoviKorisnik = new System.Windows.Forms.Button();
            this.cmbTermin = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(229, 215);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(100, 30);
            this.btnOdustani.TabIndex = 41;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(335, 215);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(100, 30);
            this.btnSnimi.TabIndex = 40;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cmbBrojSjedista
            // 
            this.cmbBrojSjedista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrojSjedista.FormattingEnabled = true;
            this.cmbBrojSjedista.Location = new System.Drawing.Point(153, 103);
            this.cmbBrojSjedista.Name = "cmbBrojSjedista";
            this.cmbBrojSjedista.Size = new System.Drawing.Size(282, 24);
            this.cmbBrojSjedista.TabIndex = 63;
            // 
            // btnProjekcijaInfo
            // 
            this.btnProjekcijaInfo.Location = new System.Drawing.Point(405, 34);
            this.btnProjekcijaInfo.Name = "btnProjekcijaInfo";
            this.btnProjekcijaInfo.Size = new System.Drawing.Size(30, 26);
            this.btnProjekcijaInfo.TabIndex = 62;
            this.btnProjekcijaInfo.Text = "i";
            this.btnProjekcijaInfo.UseVisualStyleBackColor = true;
            // 
            // dtpDatumProjekcije
            // 
            this.dtpDatumProjekcije.Location = new System.Drawing.Point(153, 138);
            this.dtpDatumProjekcije.Name = "dtpDatumProjekcije";
            this.dtpDatumProjekcije.Size = new System.Drawing.Size(282, 22);
            this.dtpDatumProjekcije.TabIndex = 61;
            // 
            // cmbKorisnik
            // 
            this.cmbKorisnik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKorisnik.FormattingEnabled = true;
            this.cmbKorisnik.Location = new System.Drawing.Point(153, 68);
            this.cmbKorisnik.Name = "cmbKorisnik";
            this.cmbKorisnik.Size = new System.Drawing.Size(246, 24);
            this.cmbKorisnik.TabIndex = 58;
            // 
            // cmbProjekcija
            // 
            this.cmbProjekcija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjekcija.Enabled = false;
            this.cmbProjekcija.FormattingEnabled = true;
            this.cmbProjekcija.Location = new System.Drawing.Point(153, 35);
            this.cmbProjekcija.Name = "cmbProjekcija";
            this.cmbProjekcija.Size = new System.Drawing.Size(246, 24);
            this.cmbProjekcija.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 60;
            this.label4.Text = "Datum gledanja:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 59;
            this.label3.Text = "Broj sjedišta:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "Korisnik:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "Projekcija:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // brnNoviKorisnik
            // 
            this.brnNoviKorisnik.Location = new System.Drawing.Point(405, 66);
            this.brnNoviKorisnik.Name = "brnNoviKorisnik";
            this.brnNoviKorisnik.Size = new System.Drawing.Size(30, 26);
            this.brnNoviKorisnik.TabIndex = 64;
            this.brnNoviKorisnik.Text = "+";
            this.brnNoviKorisnik.UseVisualStyleBackColor = true;
            this.brnNoviKorisnik.Click += new System.EventHandler(this.brnNoviKorisnik_Click);
            // 
            // cmbTermin
            // 
            this.cmbTermin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTermin.FormattingEnabled = true;
            this.cmbTermin.Location = new System.Drawing.Point(153, 171);
            this.cmbTermin.Name = "cmbTermin";
            this.cmbTermin.Size = new System.Drawing.Size(282, 24);
            this.cmbTermin.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 65;
            this.label5.Text = "Termin:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmRezervacijeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 281);
            this.Controls.Add(this.cmbTermin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.brnNoviKorisnik);
            this.Controls.Add(this.cmbBrojSjedista);
            this.Controls.Add(this.btnProjekcijaInfo);
            this.Controls.Add(this.dtpDatumProjekcije);
            this.Controls.Add(this.cmbKorisnik);
            this.Controls.Add(this.cmbProjekcija);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSnimi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRezervacijeEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uredi rezervaciju";
            this.Load += new System.EventHandler(this.frmRezervacijeEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox cmbBrojSjedista;
        private System.Windows.Forms.Button btnProjekcijaInfo;
        private System.Windows.Forms.DateTimePicker dtpDatumProjekcije;
        private System.Windows.Forms.ComboBox cmbKorisnik;
        private System.Windows.Forms.ComboBox cmbProjekcija;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button brnNoviKorisnik;
        private System.Windows.Forms.ComboBox cmbTermin;
        private System.Windows.Forms.Label label5;
    }
}