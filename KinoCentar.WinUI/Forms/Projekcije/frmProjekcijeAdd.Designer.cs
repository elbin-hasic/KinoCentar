namespace KinoCentar.WinUI.Forms.Projekcije
{
    partial class frmProjekcijeAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFilm = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSala = new System.Windows.Forms.ComboBox();
            this.txtCijena = new System.Windows.Forms.MaskedTextBox();
            this.dtpVrijediOd = new System.Windows.Forms.DateTimePicker();
            this.dtpVrijediDo = new System.Windows.Forms.DateTimePicker();
            this.btnFilmInfo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpTermin1 = new System.Windows.Forms.DateTimePicker();
            this.dtpTermin4 = new System.Windows.Forms.DateTimePicker();
            this.dtpTermin6 = new System.Windows.Forms.DateTimePicker();
            this.dtpTermin5 = new System.Windows.Forms.DateTimePicker();
            this.dtpTermin3 = new System.Windows.Forms.DateTimePicker();
            this.dtpTermin2 = new System.Windows.Forms.DateTimePicker();
            this.cbTermin6 = new System.Windows.Forms.CheckBox();
            this.cbTermin5 = new System.Windows.Forms.CheckBox();
            this.cbTermin4 = new System.Windows.Forms.CheckBox();
            this.cbTermin3 = new System.Windows.Forms.CheckBox();
            this.cbTermin2 = new System.Windows.Forms.CheckBox();
            this.cbTermin1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(308, 352);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(100, 30);
            this.btnSnimi.TabIndex = 20;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(202, 352);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(100, 30);
            this.btnOdustani.TabIndex = 21;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sala:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cijena (KM):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vrijedi od:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbFilm
            // 
            this.cmbFilm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilm.FormattingEnabled = true;
            this.cmbFilm.Location = new System.Drawing.Point(126, 35);
            this.cmbFilm.Name = "cmbFilm";
            this.cmbFilm.Size = new System.Drawing.Size(246, 24);
            this.cmbFilm.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Vrijedi do:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbSala
            // 
            this.cmbSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSala.FormattingEnabled = true;
            this.cmbSala.Location = new System.Drawing.Point(126, 68);
            this.cmbSala.Name = "cmbSala";
            this.cmbSala.Size = new System.Drawing.Size(282, 24);
            this.cmbSala.TabIndex = 3;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(126, 103);
            this.txtCijena.Mask = "0000.00";
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(282, 22);
            this.txtCijena.TabIndex = 5;
            this.txtCijena.Validating += new System.ComponentModel.CancelEventHandler(this.txtCijena_Validating);
            // 
            // dtpVrijediOd
            // 
            this.dtpVrijediOd.Location = new System.Drawing.Point(126, 136);
            this.dtpVrijediOd.Name = "dtpVrijediOd";
            this.dtpVrijediOd.Size = new System.Drawing.Size(282, 22);
            this.dtpVrijediOd.TabIndex = 7;
            this.dtpVrijediOd.Validating += new System.ComponentModel.CancelEventHandler(this.dtpVrijediOd_Validating);
            // 
            // dtpVrijediDo
            // 
            this.dtpVrijediDo.Location = new System.Drawing.Point(126, 169);
            this.dtpVrijediDo.Name = "dtpVrijediDo";
            this.dtpVrijediDo.Size = new System.Drawing.Size(282, 22);
            this.dtpVrijediDo.TabIndex = 9;
            // 
            // btnFilmInfo
            // 
            this.btnFilmInfo.Location = new System.Drawing.Point(378, 34);
            this.btnFilmInfo.Name = "btnFilmInfo";
            this.btnFilmInfo.Size = new System.Drawing.Size(30, 26);
            this.btnFilmInfo.TabIndex = 53;
            this.btnFilmInfo.Text = "i";
            this.btnFilmInfo.UseVisualStyleBackColor = true;
            this.btnFilmInfo.Click += new System.EventHandler(this.btnFilmInfo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpTermin1);
            this.groupBox1.Controls.Add(this.dtpTermin4);
            this.groupBox1.Controls.Add(this.dtpTermin6);
            this.groupBox1.Controls.Add(this.dtpTermin5);
            this.groupBox1.Controls.Add(this.dtpTermin3);
            this.groupBox1.Controls.Add(this.dtpTermin2);
            this.groupBox1.Controls.Add(this.cbTermin6);
            this.groupBox1.Controls.Add(this.cbTermin5);
            this.groupBox1.Controls.Add(this.cbTermin4);
            this.groupBox1.Controls.Add(this.cbTermin3);
            this.groupBox1.Controls.Add(this.cbTermin2);
            this.groupBox1.Controls.Add(this.cbTermin1);
            this.groupBox1.Location = new System.Drawing.Point(38, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 140);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Termini";
            // 
            // dtpTermin1
            // 
            this.dtpTermin1.CustomFormat = "HH:mm";
            this.dtpTermin1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTermin1.Location = new System.Drawing.Point(112, 23);
            this.dtpTermin1.Name = "dtpTermin1";
            this.dtpTermin1.ShowUpDown = true;
            this.dtpTermin1.Size = new System.Drawing.Size(100, 22);
            this.dtpTermin1.TabIndex = 2;
            this.dtpTermin1.Value = new System.DateTime(2020, 9, 11, 0, 0, 0, 0);
            // 
            // dtpTermin4
            // 
            this.dtpTermin4.CustomFormat = "HH:mm";
            this.dtpTermin4.Enabled = false;
            this.dtpTermin4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTermin4.Location = new System.Drawing.Point(258, 61);
            this.dtpTermin4.Name = "dtpTermin4";
            this.dtpTermin4.ShowUpDown = true;
            this.dtpTermin4.Size = new System.Drawing.Size(100, 22);
            this.dtpTermin4.TabIndex = 8;
            this.dtpTermin4.Value = new System.DateTime(2020, 9, 11, 0, 0, 0, 0);
            // 
            // dtpTermin6
            // 
            this.dtpTermin6.CustomFormat = "HH:mm";
            this.dtpTermin6.Enabled = false;
            this.dtpTermin6.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTermin6.Location = new System.Drawing.Point(258, 98);
            this.dtpTermin6.Name = "dtpTermin6";
            this.dtpTermin6.ShowUpDown = true;
            this.dtpTermin6.Size = new System.Drawing.Size(100, 22);
            this.dtpTermin6.TabIndex = 12;
            this.dtpTermin6.Value = new System.DateTime(2020, 9, 11, 0, 0, 0, 0);
            // 
            // dtpTermin5
            // 
            this.dtpTermin5.CustomFormat = "HH:mm";
            this.dtpTermin5.Enabled = false;
            this.dtpTermin5.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTermin5.Location = new System.Drawing.Point(112, 98);
            this.dtpTermin5.Name = "dtpTermin5";
            this.dtpTermin5.ShowUpDown = true;
            this.dtpTermin5.Size = new System.Drawing.Size(100, 22);
            this.dtpTermin5.TabIndex = 10;
            this.dtpTermin5.Value = new System.DateTime(2020, 9, 11, 0, 0, 0, 0);
            // 
            // dtpTermin3
            // 
            this.dtpTermin3.CustomFormat = "HH:mm";
            this.dtpTermin3.Enabled = false;
            this.dtpTermin3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTermin3.Location = new System.Drawing.Point(112, 61);
            this.dtpTermin3.Name = "dtpTermin3";
            this.dtpTermin3.ShowUpDown = true;
            this.dtpTermin3.Size = new System.Drawing.Size(100, 22);
            this.dtpTermin3.TabIndex = 6;
            this.dtpTermin3.Value = new System.DateTime(2020, 9, 11, 0, 0, 0, 0);
            // 
            // dtpTermin2
            // 
            this.dtpTermin2.CustomFormat = "HH:mm";
            this.dtpTermin2.Enabled = false;
            this.dtpTermin2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTermin2.Location = new System.Drawing.Point(258, 23);
            this.dtpTermin2.Name = "dtpTermin2";
            this.dtpTermin2.ShowUpDown = true;
            this.dtpTermin2.Size = new System.Drawing.Size(100, 22);
            this.dtpTermin2.TabIndex = 4;
            this.dtpTermin2.Value = new System.DateTime(2020, 9, 11, 0, 0, 0, 0);
            // 
            // cbTermin6
            // 
            this.cbTermin6.AutoSize = true;
            this.cbTermin6.Location = new System.Drawing.Point(233, 100);
            this.cbTermin6.Name = "cbTermin6";
            this.cbTermin6.Size = new System.Drawing.Size(18, 17);
            this.cbTermin6.TabIndex = 11;
            this.cbTermin6.UseVisualStyleBackColor = true;
            this.cbTermin6.CheckedChanged += new System.EventHandler(this.cbTermin6_CheckedChanged);
            // 
            // cbTermin5
            // 
            this.cbTermin5.AutoSize = true;
            this.cbTermin5.Location = new System.Drawing.Point(88, 100);
            this.cbTermin5.Name = "cbTermin5";
            this.cbTermin5.Size = new System.Drawing.Size(18, 17);
            this.cbTermin5.TabIndex = 9;
            this.cbTermin5.UseVisualStyleBackColor = true;
            this.cbTermin5.CheckedChanged += new System.EventHandler(this.cbTermin5_CheckedChanged);
            // 
            // cbTermin4
            // 
            this.cbTermin4.AutoSize = true;
            this.cbTermin4.Location = new System.Drawing.Point(233, 63);
            this.cbTermin4.Name = "cbTermin4";
            this.cbTermin4.Size = new System.Drawing.Size(18, 17);
            this.cbTermin4.TabIndex = 7;
            this.cbTermin4.UseVisualStyleBackColor = true;
            this.cbTermin4.CheckedChanged += new System.EventHandler(this.cbTermin4_CheckedChanged);
            // 
            // cbTermin3
            // 
            this.cbTermin3.AutoSize = true;
            this.cbTermin3.Location = new System.Drawing.Point(88, 63);
            this.cbTermin3.Name = "cbTermin3";
            this.cbTermin3.Size = new System.Drawing.Size(18, 17);
            this.cbTermin3.TabIndex = 5;
            this.cbTermin3.UseVisualStyleBackColor = true;
            this.cbTermin3.CheckedChanged += new System.EventHandler(this.cbTermin3_CheckedChanged);
            // 
            // cbTermin2
            // 
            this.cbTermin2.AutoSize = true;
            this.cbTermin2.Location = new System.Drawing.Point(234, 25);
            this.cbTermin2.Name = "cbTermin2";
            this.cbTermin2.Size = new System.Drawing.Size(18, 17);
            this.cbTermin2.TabIndex = 3;
            this.cbTermin2.UseVisualStyleBackColor = true;
            this.cbTermin2.CheckedChanged += new System.EventHandler(this.cbTermin2_CheckedChanged);
            // 
            // cbTermin1
            // 
            this.cbTermin1.AutoSize = true;
            this.cbTermin1.Checked = true;
            this.cbTermin1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTermin1.Enabled = false;
            this.cbTermin1.Location = new System.Drawing.Point(88, 25);
            this.cbTermin1.Name = "cbTermin1";
            this.cbTermin1.Size = new System.Drawing.Size(18, 17);
            this.cbTermin1.TabIndex = 1;
            this.cbTermin1.UseVisualStyleBackColor = true;
            // 
            // frmProjekcijeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 408);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFilmInfo);
            this.Controls.Add(this.dtpVrijediDo);
            this.Controls.Add(this.dtpVrijediOd);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.cmbSala);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbFilm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmProjekcijeAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova projekcija";
            this.Load += new System.EventHandler(this.frmProjekcijeAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFilm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSala;
        private System.Windows.Forms.DateTimePicker dtpVrijediDo;
        private System.Windows.Forms.DateTimePicker dtpVrijediOd;
        private System.Windows.Forms.MaskedTextBox txtCijena;
        private System.Windows.Forms.Button btnFilmInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbTermin6;
        private System.Windows.Forms.CheckBox cbTermin5;
        private System.Windows.Forms.CheckBox cbTermin4;
        private System.Windows.Forms.CheckBox cbTermin3;
        private System.Windows.Forms.CheckBox cbTermin2;
        private System.Windows.Forms.CheckBox cbTermin1;
        private System.Windows.Forms.DateTimePicker dtpTermin4;
        private System.Windows.Forms.DateTimePicker dtpTermin6;
        private System.Windows.Forms.DateTimePicker dtpTermin5;
        private System.Windows.Forms.DateTimePicker dtpTermin3;
        private System.Windows.Forms.DateTimePicker dtpTermin2;
        private System.Windows.Forms.DateTimePicker dtpTermin1;
    }
}