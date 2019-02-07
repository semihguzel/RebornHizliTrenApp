namespace HızlıTrenApp.UI.YoneticiPanelFormlari
{
    partial class FrmYoneticiCalisanIslemleri
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
            this.btnListele = new MetroFramework.Controls.MetroButton();
            this.dgvCalisanlar = new System.Windows.Forms.DataGridView();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtSoyad = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtAdres = new MetroFramework.Controls.MetroTextBox();
            this.txtTcNo = new MetroFramework.Controls.MetroTextBox();
            this.txtAd = new MetroFramework.Controls.MetroTextBox();
            this.btnSil = new MetroFramework.Controls.MetroButton();
            this.btnGuncelle = new MetroFramework.Controls.MetroButton();
            this.btnEkle = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbUnvan = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.chkErkek = new MetroFramework.Controls.MetroCheckBox();
            this.chkKadin = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.pnlKayit = new MetroFramework.Controls.MetroPanel();
            this.btnUnvanEkle = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlar)).BeginInit();
            this.pnlKayit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(292, 30);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(439, 33);
            this.btnListele.TabIndex = 31;
            this.btnListele.Text = "Listele";
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // dgvCalisanlar
            // 
            this.dgvCalisanlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCalisanlar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCalisanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalisanlar.Location = new System.Drawing.Point(292, 69);
            this.dgvCalisanlar.Name = "dgvCalisanlar";
            this.dgvCalisanlar.Size = new System.Drawing.Size(439, 268);
            this.dgvCalisanlar.TabIndex = 27;
            this.dgvCalisanlar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCalisanlar_CellDoubleClick);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(54, 96);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(46, 19);
            this.metroLabel4.TabIndex = 26;
            this.metroLabel4.Text = "Adres:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(52, 36);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 19);
            this.metroLabel3.TabIndex = 25;
            this.metroLabel3.Text = "Soyad:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(71, 6);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(29, 19);
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "Ad:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(108, 31);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(169, 23);
            this.txtSoyad.TabIndex = 23;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(55, 66);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 22;
            this.metroLabel1.Text = "Tc No:";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(108, 89);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(169, 23);
            this.txtAdres.TabIndex = 21;
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(108, 60);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(169, 23);
            this.txtTcNo.TabIndex = 20;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(108, 2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(169, 23);
            this.txtAd.TabIndex = 19;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(198, 213);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(79, 23);
            this.btnSil.TabIndex = 18;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(108, 242);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(169, 28);
            this.btnGuncelle.TabIndex = 17;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(108, 213);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(79, 23);
            this.btnEkle.TabIndex = 16;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(10, 126);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(90, 19);
            this.metroLabel6.TabIndex = 32;
            this.metroLabel6.Text = "Doğum Tarihi:";
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(108, 119);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(169, 20);
            this.dtpDogumTarihi.TabIndex = 33;
            // 
            // cmbUnvan
            // 
            this.cmbUnvan.FormattingEnabled = true;
            this.cmbUnvan.ItemHeight = 23;
            this.cmbUnvan.Location = new System.Drawing.Point(108, 146);
            this.cmbUnvan.Name = "cmbUnvan";
            this.cmbUnvan.Size = new System.Drawing.Size(169, 29);
            this.cmbUnvan.TabIndex = 34;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(52, 156);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(48, 19);
            this.metroLabel7.TabIndex = 35;
            this.metroLabel7.Text = "Ünvan:";
            // 
            // chkErkek
            // 
            this.chkErkek.AutoSize = true;
            this.chkErkek.Location = new System.Drawing.Point(125, 186);
            this.chkErkek.Name = "chkErkek";
            this.chkErkek.Size = new System.Drawing.Size(51, 15);
            this.chkErkek.TabIndex = 36;
            this.chkErkek.Text = "Erkek";
            this.chkErkek.UseVisualStyleBackColor = true;
            this.chkErkek.CheckedChanged += new System.EventHandler(this.chkErkek_CheckedChanged);
            // 
            // chkKadin
            // 
            this.chkKadin.AutoSize = true;
            this.chkKadin.Location = new System.Drawing.Point(207, 186);
            this.chkKadin.Name = "chkKadin";
            this.chkKadin.Size = new System.Drawing.Size(53, 15);
            this.chkKadin.TabIndex = 37;
            this.chkKadin.Text = "Kadın";
            this.chkKadin.UseVisualStyleBackColor = true;
            this.chkKadin.CheckedChanged += new System.EventHandler(this.chkKadin_CheckedChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(44, 182);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(56, 19);
            this.metroLabel8.TabIndex = 38;
            this.metroLabel8.Text = "Cinsiyet:";
            // 
            // pnlKayit
            // 
            this.pnlKayit.Controls.Add(this.metroLabel8);
            this.pnlKayit.Controls.Add(this.chkKadin);
            this.pnlKayit.Controls.Add(this.txtAd);
            this.pnlKayit.Controls.Add(this.chkErkek);
            this.pnlKayit.Controls.Add(this.btnEkle);
            this.pnlKayit.Controls.Add(this.metroLabel7);
            this.pnlKayit.Controls.Add(this.btnGuncelle);
            this.pnlKayit.Controls.Add(this.cmbUnvan);
            this.pnlKayit.Controls.Add(this.btnSil);
            this.pnlKayit.Controls.Add(this.dtpDogumTarihi);
            this.pnlKayit.Controls.Add(this.txtTcNo);
            this.pnlKayit.Controls.Add(this.metroLabel6);
            this.pnlKayit.Controls.Add(this.txtAdres);
            this.pnlKayit.Controls.Add(this.metroLabel1);
            this.pnlKayit.Controls.Add(this.txtSoyad);
            this.pnlKayit.Controls.Add(this.metroLabel2);
            this.pnlKayit.Controls.Add(this.metroLabel3);
            this.pnlKayit.Controls.Add(this.metroLabel4);
            this.pnlKayit.HorizontalScrollbarBarColor = true;
            this.pnlKayit.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlKayit.HorizontalScrollbarSize = 10;
            this.pnlKayit.Location = new System.Drawing.Point(2, 69);
            this.pnlKayit.Name = "pnlKayit";
            this.pnlKayit.Size = new System.Drawing.Size(284, 271);
            this.pnlKayit.TabIndex = 39;
            this.pnlKayit.VerticalScrollbarBarColor = true;
            this.pnlKayit.VerticalScrollbarHighlightOnWheel = false;
            this.pnlKayit.VerticalScrollbarSize = 10;
            // 
            // btnUnvanEkle
            // 
            this.btnUnvanEkle.Location = new System.Drawing.Point(292, 346);
            this.btnUnvanEkle.Name = "btnUnvanEkle";
            this.btnUnvanEkle.Size = new System.Drawing.Size(439, 28);
            this.btnUnvanEkle.TabIndex = 40;
            this.btnUnvanEkle.Text = "Yeni Ünvan Ekle";
            this.btnUnvanEkle.Click += new System.EventHandler(this.btnUnvanEkle_Click);
            // 
            // FrmYoneticiCalisanIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(745, 397);
            this.Controls.Add(this.btnUnvanEkle);
            this.Controls.Add(this.pnlKayit);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dgvCalisanlar);
            this.Name = "FrmYoneticiCalisanIslemleri";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Çalışan İşlemleri";
            this.Load += new System.EventHandler(this.FrmYoneticiCalisanIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlar)).EndInit();
            this.pnlKayit.ResumeLayout(false);
            this.pnlKayit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnListele;
        private System.Windows.Forms.DataGridView dgvCalisanlar;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtSoyad;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtAdres;
        private MetroFramework.Controls.MetroTextBox txtTcNo;
        private MetroFramework.Controls.MetroTextBox txtAd;
        private MetroFramework.Controls.MetroButton btnSil;
        private MetroFramework.Controls.MetroButton btnGuncelle;
        private MetroFramework.Controls.MetroButton btnEkle;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private MetroFramework.Controls.MetroComboBox cmbUnvan;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroCheckBox chkErkek;
        private MetroFramework.Controls.MetroCheckBox chkKadin;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroPanel pnlKayit;
        private MetroFramework.Controls.MetroButton btnUnvanEkle;
    }
}