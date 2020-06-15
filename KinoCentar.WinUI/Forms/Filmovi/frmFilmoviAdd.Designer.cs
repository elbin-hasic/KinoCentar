namespace KinoCentar.WinUI.Forms.Filmovi
{
    partial class frmFilmoviAdd
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
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbReditelj = new System.Windows.Forms.ComboBox();
            this.txtVideoLink = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTrajanje = new System.Windows.Forms.MaskedTextBox();
            this.txtGodinaSnimanja = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSadrzaj = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtImdbLink = new System.Windows.Forms.TextBox();
            this.pbPlakat = new System.Windows.Forms.PictureBox();
            this.btnIzaberiPlakat = new System.Windows.Forms.Button();
            this.txtPlakat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlakat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naslov:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(140, 35);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(282, 22);
            this.txtNaslov.TabIndex = 1;
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(672, 427);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(100, 30);
            this.btnSnimi.TabIndex = 20;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(566, 427);
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
            this.label2.Location = new System.Drawing.Point(35, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trajanje (min):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Godina snimanja:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Reditelj:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbReditelj
            // 
            this.cmbReditelj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReditelj.FormattingEnabled = true;
            this.cmbReditelj.Location = new System.Drawing.Point(141, 135);
            this.cmbReditelj.Name = "cmbReditelj";
            this.cmbReditelj.Size = new System.Drawing.Size(282, 24);
            this.cmbReditelj.TabIndex = 7;
            // 
            // txtVideoLink
            // 
            this.txtVideoLink.Location = new System.Drawing.Point(141, 170);
            this.txtVideoLink.Name = "txtVideoLink";
            this.txtVideoLink.Size = new System.Drawing.Size(282, 22);
            this.txtVideoLink.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Video link:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTrajanje
            // 
            this.txtTrajanje.Location = new System.Drawing.Point(141, 68);
            this.txtTrajanje.Mask = "00000";
            this.txtTrajanje.Name = "txtTrajanje";
            this.txtTrajanje.Size = new System.Drawing.Size(282, 22);
            this.txtTrajanje.TabIndex = 3;
            this.txtTrajanje.ValidatingType = typeof(int);
            // 
            // txtGodinaSnimanja
            // 
            this.txtGodinaSnimanja.Location = new System.Drawing.Point(141, 102);
            this.txtGodinaSnimanja.Mask = "0000";
            this.txtGodinaSnimanja.Name = "txtGodinaSnimanja";
            this.txtGodinaSnimanja.Size = new System.Drawing.Size(282, 22);
            this.txtGodinaSnimanja.TabIndex = 5;
            this.txtGodinaSnimanja.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Imdb link:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSadrzaj
            // 
            this.txtSadrzaj.Location = new System.Drawing.Point(140, 292);
            this.txtSadrzaj.Multiline = true;
            this.txtSadrzaj.Name = "txtSadrzaj";
            this.txtSadrzaj.Size = new System.Drawing.Size(632, 101);
            this.txtSadrzaj.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Sadržaj:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtImdbLink
            // 
            this.txtImdbLink.Location = new System.Drawing.Point(141, 203);
            this.txtImdbLink.Name = "txtImdbLink";
            this.txtImdbLink.Size = new System.Drawing.Size(282, 22);
            this.txtImdbLink.TabIndex = 11;
            // 
            // pbPlakat
            // 
            this.pbPlakat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPlakat.Location = new System.Drawing.Point(462, 63);
            this.pbPlakat.Name = "pbPlakat";
            this.pbPlakat.Size = new System.Drawing.Size(310, 195);
            this.pbPlakat.TabIndex = 22;
            this.pbPlakat.TabStop = false;
            // 
            // btnIzaberiPlakat
            // 
            this.btnIzaberiPlakat.Location = new System.Drawing.Point(382, 232);
            this.btnIzaberiPlakat.Name = "btnIzaberiPlakat";
            this.btnIzaberiPlakat.Size = new System.Drawing.Size(40, 30);
            this.btnIzaberiPlakat.TabIndex = 14;
            this.btnIzaberiPlakat.Text = "...";
            this.btnIzaberiPlakat.UseVisualStyleBackColor = true;
            this.btnIzaberiPlakat.Click += new System.EventHandler(this.btnIzaberiPlakat_Click);
            // 
            // txtPlakat
            // 
            this.txtPlakat.Location = new System.Drawing.Point(140, 236);
            this.txtPlakat.Name = "txtPlakat";
            this.txtPlakat.Size = new System.Drawing.Size(236, 22);
            this.txtPlakat.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(84, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Plakat:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(459, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Prikaz plakata:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmFilmoviAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 487);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnIzaberiPlakat);
            this.Controls.Add(this.txtPlakat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pbPlakat);
            this.Controls.Add(this.txtSadrzaj);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtImdbLink);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGodinaSnimanja);
            this.Controls.Add(this.txtTrajanje);
            this.Controls.Add(this.txtVideoLink);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbReditelj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFilmoviAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi film";
            this.Load += new System.EventHandler(this.frmFilmoviAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlakat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbReditelj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVideoLink;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtTrajanje;
        private System.Windows.Forms.MaskedTextBox txtGodinaSnimanja;
        private System.Windows.Forms.TextBox txtSadrzaj;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtImdbLink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbPlakat;
        private System.Windows.Forms.Button btnIzaberiPlakat;
        private System.Windows.Forms.TextBox txtPlakat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}