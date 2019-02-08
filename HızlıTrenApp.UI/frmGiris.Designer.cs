namespace HızlıTrenApp.UI
{
	partial class frmGiris
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiris));
			this.btnSeferleriListele = new MetroFramework.Controls.MetroButton();
			this.nmrYolcuSayisi = new System.Windows.Forms.NumericUpDown();
			this.dtpDonusTarihi = new System.Windows.Forms.DateTimePicker();
			this.dtpGidisTarihi = new System.Windows.Forms.DateTimePicker();
			this.rdbGidisDonus = new MetroFramework.Controls.MetroRadioButton();
			this.rdbTekyon = new MetroFramework.Controls.MetroRadioButton();
			this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.cmbNereye = new MetroFramework.Controls.MetroComboBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.cmbTip = new MetroFramework.Controls.MetroComboBox();
			this.cmbNereden = new MetroFramework.Controls.MetroComboBox();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.grpBilet = new System.Windows.Forms.GroupBox();
			this.grpYonSecimi = new System.Windows.Forms.GroupBox();
			this.grpSatisRezerve = new System.Windows.Forms.GroupBox();
			this.rdpSatis = new MetroFramework.Controls.MetroRadioButton();
			this.rdpRezerve = new MetroFramework.Controls.MetroRadioButton();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
			((System.ComponentModel.ISupportInitialize)(this.nmrYolcuSayisi)).BeginInit();
			this.grpBilet.SuspendLayout();
			this.grpYonSecimi.SuspendLayout();
			this.grpSatisRezerve.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSeferleriListele
			// 
			resources.ApplyResources(this.btnSeferleriListele, "btnSeferleriListele");
			this.btnSeferleriListele.Name = "btnSeferleriListele";
			this.btnSeferleriListele.Style = MetroFramework.MetroColorStyle.Red;
			this.btnSeferleriListele.Click += new System.EventHandler(this.btnSeferleriListele_Click);
			// 
			// nmrYolcuSayisi
			// 
			resources.ApplyResources(this.nmrYolcuSayisi, "nmrYolcuSayisi");
			this.nmrYolcuSayisi.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
			this.nmrYolcuSayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nmrYolcuSayisi.Name = "nmrYolcuSayisi";
			this.nmrYolcuSayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nmrYolcuSayisi.ValueChanged += new System.EventHandler(this.nmrYolcuSayisi_ValueChanged);
			// 
			// dtpDonusTarihi
			// 
			resources.ApplyResources(this.dtpDonusTarihi, "dtpDonusTarihi");
			this.dtpDonusTarihi.Name = "dtpDonusTarihi";
			this.dtpDonusTarihi.ValueChanged += new System.EventHandler(this.dtpDonusTarihi_ValueChanged);
			// 
			// dtpGidisTarihi
			// 
			resources.ApplyResources(this.dtpGidisTarihi, "dtpGidisTarihi");
			this.dtpGidisTarihi.Name = "dtpGidisTarihi";
			this.dtpGidisTarihi.ValueChanged += new System.EventHandler(this.dtpGidisTarihi_ValueChanged);
			// 
			// rdbGidisDonus
			// 
			resources.ApplyResources(this.rdbGidisDonus, "rdbGidisDonus");
			this.rdbGidisDonus.Name = "rdbGidisDonus";
			this.rdbGidisDonus.TabStop = true;
			this.rdbGidisDonus.UseVisualStyleBackColor = true;
			this.rdbGidisDonus.CheckedChanged += new System.EventHandler(this.rdbGidisDonus_CheckedChanged);
			// 
			// rdbTekyon
			// 
			resources.ApplyResources(this.rdbTekyon, "rdbTekyon");
			this.rdbTekyon.Name = "rdbTekyon";
			this.rdbTekyon.TabStop = true;
			this.rdbTekyon.UseVisualStyleBackColor = true;
			this.rdbTekyon.CheckedChanged += new System.EventHandler(this.rdbTekyon_CheckedChanged);
			// 
			// metroLabel6
			// 
			resources.ApplyResources(this.metroLabel6, "metroLabel6");
			this.metroLabel6.Name = "metroLabel6";
			// 
			// metroLabel5
			// 
			resources.ApplyResources(this.metroLabel5, "metroLabel5");
			this.metroLabel5.Name = "metroLabel5";
			// 
			// metroLabel4
			// 
			resources.ApplyResources(this.metroLabel4, "metroLabel4");
			this.metroLabel4.Name = "metroLabel4";
			// 
			// cmbNereye
			// 
			this.cmbNereye.FormattingEnabled = true;
			resources.ApplyResources(this.cmbNereye, "cmbNereye");
			this.cmbNereye.Name = "cmbNereye";
			// 
			// metroLabel3
			// 
			resources.ApplyResources(this.metroLabel3, "metroLabel3");
			this.metroLabel3.Name = "metroLabel3";
			// 
			// cmbTip
			// 
			this.cmbTip.FormattingEnabled = true;
			resources.ApplyResources(this.cmbTip, "cmbTip");
			this.cmbTip.Name = "cmbTip";
			// 
			// cmbNereden
			// 
			this.cmbNereden.FormattingEnabled = true;
			resources.ApplyResources(this.cmbNereden, "cmbNereden");
			this.cmbNereden.Name = "cmbNereden";
			// 
			// metroLabel2
			// 
			resources.ApplyResources(this.metroLabel2, "metroLabel2");
			this.metroLabel2.Name = "metroLabel2";
			// 
			// grpBilet
			// 
			this.grpBilet.Controls.Add(this.metroLabel7);
			this.grpBilet.Controls.Add(this.grpYonSecimi);
			this.grpBilet.Controls.Add(this.grpSatisRezerve);
			this.grpBilet.Controls.Add(this.btnSeferleriListele);
			this.grpBilet.Controls.Add(this.nmrYolcuSayisi);
			this.grpBilet.Controls.Add(this.dtpDonusTarihi);
			this.grpBilet.Controls.Add(this.dtpGidisTarihi);
			this.grpBilet.Controls.Add(this.metroLabel6);
			this.grpBilet.Controls.Add(this.metroLabel5);
			this.grpBilet.Controls.Add(this.metroLabel4);
			this.grpBilet.Controls.Add(this.cmbNereye);
			this.grpBilet.Controls.Add(this.metroLabel3);
			this.grpBilet.Controls.Add(this.cmbTip);
			this.grpBilet.Controls.Add(this.cmbNereden);
			this.grpBilet.Controls.Add(this.metroLabel2);
			resources.ApplyResources(this.grpBilet, "grpBilet");
			this.grpBilet.Name = "grpBilet";
			this.grpBilet.TabStop = false;
			// 
			// grpYonSecimi
			// 
			this.grpYonSecimi.Controls.Add(this.rdbTekyon);
			this.grpYonSecimi.Controls.Add(this.rdbGidisDonus);
			resources.ApplyResources(this.grpYonSecimi, "grpYonSecimi");
			this.grpYonSecimi.Name = "grpYonSecimi";
			this.grpYonSecimi.TabStop = false;
			// 
			// grpSatisRezerve
			// 
			this.grpSatisRezerve.Controls.Add(this.rdpSatis);
			this.grpSatisRezerve.Controls.Add(this.rdpRezerve);
			resources.ApplyResources(this.grpSatisRezerve, "grpSatisRezerve");
			this.grpSatisRezerve.Name = "grpSatisRezerve";
			this.grpSatisRezerve.TabStop = false;
			// 
			// rdpSatis
			// 
			resources.ApplyResources(this.rdpSatis, "rdpSatis");
			this.rdpSatis.Name = "rdpSatis";
			this.rdpSatis.TabStop = true;
			this.rdpSatis.UseVisualStyleBackColor = true;
			// 
			// rdpRezerve
			// 
			resources.ApplyResources(this.rdpRezerve, "rdpRezerve");
			this.rdpRezerve.Name = "rdpRezerve";
			this.rdpRezerve.TabStop = true;
			this.rdpRezerve.UseVisualStyleBackColor = true;
			// 
			// metroLabel1
			// 
			resources.ApplyResources(this.metroLabel1, "metroLabel1");
			this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel1.Name = "metroLabel1";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::HızlıTrenApp.UI.Properties.Resources.SGKhizlitren1;
			resources.ApplyResources(this.pictureBox1, "pictureBox1");
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.TabStop = false;
			// 
			// metroLabel7
			// 
			resources.ApplyResources(this.metroLabel7, "metroLabel7");
			this.metroLabel7.Name = "metroLabel7";
			// 
			// frmGiris
			// 
			this.AcceptButton = this.btnSeferleriListele;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.grpBilet);
			this.Controls.Add(this.metroLabel1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmGiris";
			this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
			this.Style = MetroFramework.MetroColorStyle.Red;
			this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Right;
			this.Load += new System.EventHandler(this.frmGiris_Load);
			((System.ComponentModel.ISupportInitialize)(this.nmrYolcuSayisi)).EndInit();
			this.grpBilet.ResumeLayout(false);
			this.grpBilet.PerformLayout();
			this.grpYonSecimi.ResumeLayout(false);
			this.grpYonSecimi.PerformLayout();
			this.grpSatisRezerve.ResumeLayout(false);
			this.grpSatisRezerve.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private MetroFramework.Controls.MetroButton btnSeferleriListele;
		private System.Windows.Forms.NumericUpDown nmrYolcuSayisi;
		private System.Windows.Forms.DateTimePicker dtpDonusTarihi;
		private System.Windows.Forms.DateTimePicker dtpGidisTarihi;
		private MetroFramework.Controls.MetroRadioButton rdbGidisDonus;
		private MetroFramework.Controls.MetroRadioButton rdbTekyon;
		private MetroFramework.Controls.MetroLabel metroLabel6;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroComboBox cmbNereye;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroComboBox cmbTip;
		private MetroFramework.Controls.MetroComboBox cmbNereden;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private System.Windows.Forms.GroupBox grpBilet;
		private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox grpYonSecimi;
        private System.Windows.Forms.GroupBox grpSatisRezerve;
        private MetroFramework.Controls.MetroRadioButton rdpSatis;
        private MetroFramework.Controls.MetroRadioButton rdpRezerve;
		private MetroFramework.Controls.MetroLabel metroLabel7;
	}
}