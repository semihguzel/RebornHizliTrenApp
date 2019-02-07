namespace HızlıTrenApp.UI
{
    partial class frmAnaSayfa
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
            this.mlBiletlerim = new MetroFramework.Controls.MetroLink();
            this.mlRezervasyonlarim = new MetroFramework.Controls.MetroLink();
            this.grpAnaKutu = new System.Windows.Forms.GroupBox();
            this.mlIstasyonTren = new MetroFramework.Controls.MetroLink();
            this.mlBilet = new MetroFramework.Controls.MetroLink();
            this.label1 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnYoneticiGrs = new MetroFramework.Controls.MetroButton();
            this.grpAnaKutu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // mlBiletlerim
            // 
            this.mlBiletlerim.Location = new System.Drawing.Point(779, 8);
            this.mlBiletlerim.Margin = new System.Windows.Forms.Padding(2);
            this.mlBiletlerim.Name = "mlBiletlerim";
            this.mlBiletlerim.Size = new System.Drawing.Size(126, 37);
            this.mlBiletlerim.TabIndex = 2;
            this.mlBiletlerim.Text = "Biletlerim";
            this.mlBiletlerim.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mlBiletlerim.Click += new System.EventHandler(this.mlBiletlerim_Click);
            // 
            // mlRezervasyonlarim
            // 
            this.mlRezervasyonlarim.Location = new System.Drawing.Point(909, 8);
            this.mlRezervasyonlarim.Margin = new System.Windows.Forms.Padding(2);
            this.mlRezervasyonlarim.Name = "mlRezervasyonlarim";
            this.mlRezervasyonlarim.Size = new System.Drawing.Size(126, 37);
            this.mlRezervasyonlarim.TabIndex = 2;
            this.mlRezervasyonlarim.Text = "Rezervasyonlarım";
            this.mlRezervasyonlarim.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mlRezervasyonlarim.Click += new System.EventHandler(this.mlRezervasyonlarim_Click);
            // 
            // grpAnaKutu
            // 
            this.grpAnaKutu.Controls.Add(this.mlIstasyonTren);
            this.grpAnaKutu.Controls.Add(this.mlBilet);
            this.grpAnaKutu.Location = new System.Drawing.Point(22, 58);
            this.grpAnaKutu.Margin = new System.Windows.Forms.Padding(2);
            this.grpAnaKutu.Name = "grpAnaKutu";
            this.grpAnaKutu.Padding = new System.Windows.Forms.Padding(2);
            this.grpAnaKutu.Size = new System.Drawing.Size(1013, 542);
            this.grpAnaKutu.TabIndex = 5;
            this.grpAnaKutu.TabStop = false;
            // 
            // mlIstasyonTren
            // 
            this.mlIstasyonTren.Location = new System.Drawing.Point(866, 16);
            this.mlIstasyonTren.Margin = new System.Windows.Forms.Padding(2);
            this.mlIstasyonTren.Name = "mlIstasyonTren";
            this.mlIstasyonTren.Size = new System.Drawing.Size(132, 29);
            this.mlIstasyonTren.TabIndex = 0;
            this.mlIstasyonTren.Text = "İstasyon-Tren Bilgileri";
            this.mlIstasyonTren.Click += new System.EventHandler(this.mlIstasyonTren_Click);
            // 
            // mlBilet
            // 
            this.mlBilet.Location = new System.Drawing.Point(775, 16);
            this.mlBilet.Margin = new System.Windows.Forms.Padding(2);
            this.mlBilet.Name = "mlBilet";
            this.mlBilet.Size = new System.Drawing.Size(87, 29);
            this.mlBilet.TabIndex = 0;
            this.mlBilet.Text = "Bilet";
            this.mlBilet.Click += new System.EventHandler(this.mlBilet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "SGT            Second Group Transportation";
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = global::HızlıTrenApp.UI.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(22, 8);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(85, 46);
            this.pbLogo.TabIndex = 7;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // btnYoneticiGrs
            // 
            this.btnYoneticiGrs.Location = new System.Drawing.Point(667, 8);
            this.btnYoneticiGrs.Name = "btnYoneticiGrs";
            this.btnYoneticiGrs.Size = new System.Drawing.Size(107, 37);
            this.btnYoneticiGrs.TabIndex = 9;
            this.btnYoneticiGrs.Text = "Yönetici Girişi";
            this.btnYoneticiGrs.Click += new System.EventHandler(this.btnYoneticiGrs_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 619);
            this.Controls.Add(this.btnYoneticiGrs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.grpAnaKutu);
            this.Controls.Add(this.mlRezervasyonlarim);
            this.Controls.Add(this.mlBiletlerim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hızlı Tren Bilet Satış Otomasyonu";
            this.Load += new System.EventHandler(this.frmAnaSayfa_Load);
            this.grpAnaKutu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLink mlBiletlerim;
        private MetroFramework.Controls.MetroLink mlRezervasyonlarim;
        private System.Windows.Forms.GroupBox grpAnaKutu;
        private MetroFramework.Controls.MetroLink mlIstasyonTren;
        private MetroFramework.Controls.MetroLink mlBilet;
        private System.Windows.Forms.PictureBox pbLogo;
		private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnYoneticiGrs;
    }
}