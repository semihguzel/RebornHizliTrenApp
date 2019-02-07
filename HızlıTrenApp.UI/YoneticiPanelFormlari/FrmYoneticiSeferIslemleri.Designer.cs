namespace HızlıTrenApp.UI.YoneticiPanelFormlari
{
    partial class FrmYoneticiSeferIslemleri
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
            this.btnEkle = new MetroFramework.Controls.MetroButton();
            this.btnGuncelle = new MetroFramework.Controls.MetroButton();
            this.btnSil = new MetroFramework.Controls.MetroButton();
            this.txtKalkıs = new MetroFramework.Controls.MetroTextBox();
            this.txtYolcuKapasitesi = new MetroFramework.Controls.MetroTextBox();
            this.txtVarısSuresi = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtVarıs = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dgvSeferler = new System.Windows.Forms.DataGridView();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtSeferAra = new MetroFramework.Controls.MetroTextBox();
            this.btnSeferAra = new MetroFramework.Controls.MetroButton();
            this.btnListele = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeferler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(147, 197);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(53, 23);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(148, 226);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(116, 28);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(211, 197);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(53, 23);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtKalkıs
            // 
            this.txtKalkıs.Location = new System.Drawing.Point(148, 81);
            this.txtKalkıs.Name = "txtKalkıs";
            this.txtKalkıs.Size = new System.Drawing.Size(116, 23);
            this.txtKalkıs.TabIndex = 3;
            // 
            // txtYolcuKapasitesi
            // 
            this.txtYolcuKapasitesi.Location = new System.Drawing.Point(147, 139);
            this.txtYolcuKapasitesi.Name = "txtYolcuKapasitesi";
            this.txtYolcuKapasitesi.Size = new System.Drawing.Size(116, 23);
            this.txtYolcuKapasitesi.TabIndex = 4;
            // 
            // txtVarısSuresi
            // 
            this.txtVarısSuresi.Location = new System.Drawing.Point(148, 168);
            this.txtVarısSuresi.Name = "txtVarısSuresi";
            this.txtVarısSuresi.Size = new System.Drawing.Size(116, 23);
            this.txtVarısSuresi.TabIndex = 5;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(99, 81);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(43, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Kalkış:";
            // 
            // txtVarıs
            // 
            this.txtVarıs.Location = new System.Drawing.Point(147, 110);
            this.txtVarıs.Name = "txtVarıs";
            this.txtVarıs.Size = new System.Drawing.Size(116, 23);
            this.txtVarıs.TabIndex = 7;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(103, 111);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Varış:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(38, 141);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(103, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Yolcu Kapasitesi:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(18, 171);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(124, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Tahmini Varış Süresi:";
            // 
            // dgvSeferler
            // 
            this.dgvSeferler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSeferler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSeferler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeferler.Location = new System.Drawing.Point(282, 72);
            this.dgvSeferler.Name = "dgvSeferler";
            this.dgvSeferler.Size = new System.Drawing.Size(392, 182);
            this.dgvSeferler.TabIndex = 11;
            this.dgvSeferler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSeferler_CellDoubleClick);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(277, 42);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(43, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Sefer:";
            // 
            // txtSeferAra
            // 
            this.txtSeferAra.Location = new System.Drawing.Point(326, 41);
            this.txtSeferAra.Name = "txtSeferAra";
            this.txtSeferAra.Size = new System.Drawing.Size(116, 23);
            this.txtSeferAra.TabIndex = 13;
            // 
            // btnSeferAra
            // 
            this.btnSeferAra.Location = new System.Drawing.Point(448, 41);
            this.btnSeferAra.Name = "btnSeferAra";
            this.btnSeferAra.Size = new System.Drawing.Size(99, 23);
            this.btnSeferAra.TabIndex = 14;
            this.btnSeferAra.Text = "Ara";
            this.btnSeferAra.Click += new System.EventHandler(this.btnSeferAra_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(553, 41);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(121, 23);
            this.btnListele.TabIndex = 15;
            this.btnListele.Text = "Listele";
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // FrmYoneticiSeferIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(690, 278);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnSeferAra);
            this.Controls.Add(this.txtSeferAra);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.dgvSeferler);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtVarıs);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtVarısSuresi);
            this.Controls.Add(this.txtYolcuKapasitesi);
            this.Controls.Add(this.txtKalkıs);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Name = "FrmYoneticiSeferIslemleri";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Sefer İşlemleri";
            this.Load += new System.EventHandler(this.frmYoneticiSeferIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeferler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnEkle;
        private MetroFramework.Controls.MetroButton btnGuncelle;
        private MetroFramework.Controls.MetroButton btnSil;
        private MetroFramework.Controls.MetroTextBox txtKalkıs;
        private MetroFramework.Controls.MetroTextBox txtYolcuKapasitesi;
        private MetroFramework.Controls.MetroTextBox txtVarısSuresi;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtVarıs;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DataGridView dgvSeferler;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtSeferAra;
        private MetroFramework.Controls.MetroButton btnSeferAra;
        private MetroFramework.Controls.MetroButton btnListele;
    }
}