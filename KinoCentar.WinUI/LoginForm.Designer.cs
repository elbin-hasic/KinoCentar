namespace KinoCentar.WinUI
{
    partial class LoginForm
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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnPotvrda = new System.Windows.Forms.Button();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOdustani.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOdustani.Location = new System.Drawing.Point(224, 114);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(108, 37);
            this.btnOdustani.TabIndex = 23;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnPotvrda
            // 
            this.btnPotvrda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPotvrda.Location = new System.Drawing.Point(340, 114);
            this.btnPotvrda.Margin = new System.Windows.Forms.Padding(4);
            this.btnPotvrda.Name = "btnPotvrda";
            this.btnPotvrda.Size = new System.Drawing.Size(108, 37);
            this.btnPotvrda.TabIndex = 22;
            this.btnPotvrda.Text = "Potvrdi";
            this.btnPotvrda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPotvrda.UseVisualStyleBackColor = true;
            this.btnPotvrda.Click += new System.EventHandler(this.btnPotvrda_Click);
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(172, 68);
            this.txtLozinka.Margin = new System.Windows.Forms.Padding(4);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(275, 22);
            this.txtLozinka.TabIndex = 21;
            this.txtLozinka.UseWaitCursor = true;
            this.txtLozinka.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLozinka_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Lozinka:";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(172, 36);
            this.txtKorisnickoIme.Margin = new System.Windows.Forms.Padding(4);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(275, 22);
            this.txtKorisnickoIme.TabIndex = 19;
            this.txtKorisnickoIme.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Korisničko ime:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 177);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPotvrda);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava na sistem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnPotvrda;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label label1;
    }
}