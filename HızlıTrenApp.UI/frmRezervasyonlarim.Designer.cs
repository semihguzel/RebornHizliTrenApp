namespace HızlıTrenApp.UI
{
	partial class frmRezervasyonlarim
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
			this.grpRezervasyonBilgileri = new System.Windows.Forms.GroupBox();
			this.dgvSeyehatBilgileri = new System.Windows.Forms.DataGridView();
			this.txtSoyad = new System.Windows.Forms.TextBox();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.txtPnrNo = new System.Windows.Forms.TextBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.btnSatisaCevir = new MetroFramework.Controls.MetroButton();
			this.btnSorgula = new MetroFramework.Controls.MetroButton();
			this.grpRezervasyonBilgileri.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSeyehatBilgileri)).BeginInit();
			this.SuspendLayout();
			// 
			// grpRezervasyonBilgileri
			// 
			this.grpRezervasyonBilgileri.Controls.Add(this.dgvSeyehatBilgileri);
			this.grpRezervasyonBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.grpRezervasyonBilgileri.Location = new System.Drawing.Point(27, 133);
			this.grpRezervasyonBilgileri.Name = "grpRezervasyonBilgileri";
			this.grpRezervasyonBilgileri.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.grpRezervasyonBilgileri.Size = new System.Drawing.Size(741, 236);
			this.grpRezervasyonBilgileri.TabIndex = 12;
			this.grpRezervasyonBilgileri.TabStop = false;
			this.grpRezervasyonBilgileri.Text = "Rezervasyon Bilgileri Listesi";
			// 
			// dgvSeyehatBilgileri
			// 
			this.dgvSeyehatBilgileri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvSeyehatBilgileri.BackgroundColor = System.Drawing.Color.GhostWhite;
			this.dgvSeyehatBilgileri.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvSeyehatBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSeyehatBilgileri.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvSeyehatBilgileri.Location = new System.Drawing.Point(3, 19);
			this.dgvSeyehatBilgileri.Name = "dgvSeyehatBilgileri";
			this.dgvSeyehatBilgileri.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dgvSeyehatBilgileri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
			this.dgvSeyehatBilgileri.Size = new System.Drawing.Size(735, 214);
			this.dgvSeyehatBilgileri.TabIndex = 0;
			// 
			// txtSoyad
			// 
			this.txtSoyad.Location = new System.Drawing.Point(87, 67);
			this.txtSoyad.Name = "txtSoyad";
			this.txtSoyad.Size = new System.Drawing.Size(124, 20);
			this.txtSoyad.TabIndex = 1;
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(36, 67);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(45, 19);
			this.metroLabel2.TabIndex = 4;
			this.metroLabel2.Text = "Soyad";
			// 
			// txtPnrNo
			// 
			this.txtPnrNo.Location = new System.Drawing.Point(87, 39);
			this.txtPnrNo.Name = "txtPnrNo";
			this.txtPnrNo.Size = new System.Drawing.Size(124, 20);
			this.txtPnrNo.TabIndex = 0;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(24, 40);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(57, 19);
			this.metroLabel1.TabIndex = 5;
			this.metroLabel1.Text = "PNR No";
			// 
			// btnSatisaCevir
			// 
			this.btnSatisaCevir.Location = new System.Drawing.Point(324, 390);
			this.btnSatisaCevir.Name = "btnSatisaCevir";
			this.btnSatisaCevir.Size = new System.Drawing.Size(133, 37);
			this.btnSatisaCevir.TabIndex = 3;
			this.btnSatisaCevir.Text = "Satışa Çevir";
			this.btnSatisaCevir.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// btnSorgula
			// 
			this.btnSorgula.Location = new System.Drawing.Point(98, 93);
			this.btnSorgula.Name = "btnSorgula";
			this.btnSorgula.Size = new System.Drawing.Size(113, 39);
			this.btnSorgula.TabIndex = 14;
			this.btnSorgula.Text = "Sorgula";
			this.btnSorgula.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
			// 
			// frmRezervasyonlarim
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnSorgula);
			this.Controls.Add(this.grpRezervasyonBilgileri);
			this.Controls.Add(this.txtSoyad);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.txtPnrNo);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.btnSatisaCevir);
			this.Name = "frmRezervasyonlarim";
			this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
			this.Style = MetroFramework.MetroColorStyle.Red;
			this.Text = "Rezervasyonlarım";
			this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Right;
			this.Load += new System.EventHandler(this.frmRezervasyonlarim_Load_1);
			this.grpRezervasyonBilgileri.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvSeyehatBilgileri)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox grpRezervasyonBilgileri;
		private System.Windows.Forms.DataGridView dgvSeyehatBilgileri;
		private System.Windows.Forms.TextBox txtSoyad;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private System.Windows.Forms.TextBox txtPnrNo;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroButton btnSatisaCevir;
		private MetroFramework.Controls.MetroButton btnSorgula;
	}
}