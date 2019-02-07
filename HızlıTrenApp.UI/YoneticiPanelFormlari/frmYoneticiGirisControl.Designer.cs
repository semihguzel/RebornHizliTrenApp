namespace HızlıTrenApp.UI
{
    partial class frmYoneticiGirisControl
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtKullaniciAdi = new MetroFramework.Controls.MetroTextBox();
            this.txtSifre = new MetroFramework.Controls.MetroTextBox();
            this.btnGiris = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 70);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Kullanıcı Adı:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(67, 107);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Şifre:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(111, 66);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(148, 23);
            this.txtKullaniciAdi.TabIndex = 2;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(111, 103);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(148, 23);
            this.txtSifre.TabIndex = 3;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(111, 132);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(148, 29);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // frmYoneticiGirisControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 202);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frmYoneticiGirisControl";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Yönetici Giriş Formu";
            this.Load += new System.EventHandler(this.frmYoneticiGirisControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtKullaniciAdi;
        private MetroFramework.Controls.MetroTextBox txtSifre;
        private MetroFramework.Controls.MetroButton btnGiris;
    }
}