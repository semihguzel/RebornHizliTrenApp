namespace HızlıTrenApp.UI
{
	partial class frmBiletlerim
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
			this.txtPnrNo = new System.Windows.Forms.TextBox();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.txtSoyad = new System.Windows.Forms.TextBox();
			this.btnSorgula = new MetroFramework.Controls.MetroButton();
			this.grpSeyehatBilgileri = new System.Windows.Forms.GroupBox();
			this.dgvSeyehatBilgileri = new System.Windows.Forms.DataGridView();
			this.grpSeyehatBilgileri.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSeyehatBilgileri)).BeginInit();
			this.SuspendLayout();
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(24, 86);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(57, 19);
			this.metroLabel1.TabIndex = 0;
			this.metroLabel1.Text = "PNR No";
			// 
			// txtPnrNo
			// 
			this.txtPnrNo.Location = new System.Drawing.Point(87, 85);
			this.txtPnrNo.Name = "txtPnrNo";
			this.txtPnrNo.Size = new System.Drawing.Size(124, 20);
			this.txtPnrNo.TabIndex = 0;
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(36, 113);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(45, 19);
			this.metroLabel2.TabIndex = 0;
			this.metroLabel2.Text = "Soyad";
			// 
			// txtSoyad
			// 
			this.txtSoyad.Location = new System.Drawing.Point(87, 113);
			this.txtSoyad.Name = "txtSoyad";
			this.txtSoyad.Size = new System.Drawing.Size(124, 20);
			this.txtSoyad.TabIndex = 1;
			// 
			// btnSorgula
			// 
			this.btnSorgula.Location = new System.Drawing.Point(98, 139);
			this.btnSorgula.Name = "btnSorgula";
			this.btnSorgula.Size = new System.Drawing.Size(113, 39);
			this.btnSorgula.TabIndex = 2;
			this.btnSorgula.Text = "Sorgula";
			this.btnSorgula.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
			// 
			// grpSeyehatBilgileri
			// 
			this.grpSeyehatBilgileri.Controls.Add(this.dgvSeyehatBilgileri);
			this.grpSeyehatBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.grpSeyehatBilgileri.Location = new System.Drawing.Point(21, 179);
			this.grpSeyehatBilgileri.Name = "grpSeyehatBilgileri";
			this.grpSeyehatBilgileri.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.grpSeyehatBilgileri.Size = new System.Drawing.Size(741, 236);
			this.grpSeyehatBilgileri.TabIndex = 3;
			this.grpSeyehatBilgileri.TabStop = false;
			this.grpSeyehatBilgileri.Text = "Seyehat Bilgileri Listesi";
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
			this.dgvSeyehatBilgileri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSeyehatBilgileri.Size = new System.Drawing.Size(735, 214);
			this.dgvSeyehatBilgileri.TabIndex = 0;
			// 
			// frmBiletlerim
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(795, 452);
			this.Controls.Add(this.grpSeyehatBilgileri);
			this.Controls.Add(this.btnSorgula);
			this.Controls.Add(this.txtSoyad);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.txtPnrNo);
			this.Controls.Add(this.metroLabel1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmBiletlerim";
			this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
			this.Style = MetroFramework.MetroColorStyle.Red;
			this.Text = "Biletlerim";
			this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Right;
			this.Load += new System.EventHandler(this.frmBiletlerim_Load_1);
			this.grpSeyehatBilgileri.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvSeyehatBilgileri)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroLabel metroLabel1;
		private System.Windows.Forms.TextBox txtPnrNo;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private System.Windows.Forms.TextBox txtSoyad;
		private MetroFramework.Controls.MetroButton btnSorgula;
		private System.Windows.Forms.GroupBox grpSeyehatBilgileri;
		private System.Windows.Forms.DataGridView dgvSeyehatBilgileri;
	}
}