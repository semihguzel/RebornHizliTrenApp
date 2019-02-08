namespace HızlıTrenApp.UI
{
	partial class frmIslemOzeti
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
            this.grpYolcuBilgileri = new System.Windows.Forms.GroupBox();
            this.lstIslemOzeti = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnIndir = new MetroFramework.Controls.MetroButton();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpYolcuBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpYolcuBilgileri
            // 
            this.grpYolcuBilgileri.Controls.Add(this.lstIslemOzeti);
            this.grpYolcuBilgileri.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpYolcuBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpYolcuBilgileri.Location = new System.Drawing.Point(20, 149);
            this.grpYolcuBilgileri.Name = "grpYolcuBilgileri";
            this.grpYolcuBilgileri.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpYolcuBilgileri.Size = new System.Drawing.Size(885, 213);
            this.grpYolcuBilgileri.TabIndex = 1;
            this.grpYolcuBilgileri.TabStop = false;
            this.grpYolcuBilgileri.Text = "Yolcu Bilgileri";
            // 
            // lstIslemOzeti
            // 
            this.lstIslemOzeti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8,
            this.columnHeader7});
            this.lstIslemOzeti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstIslemOzeti.GridLines = true;
            this.lstIslemOzeti.Location = new System.Drawing.Point(3, 19);
            this.lstIslemOzeti.Name = "lstIslemOzeti";
            this.lstIslemOzeti.Size = new System.Drawing.Size(879, 191);
            this.lstIslemOzeti.TabIndex = 1;
            this.lstIslemOzeti.UseCompatibleStateImageBehavior = false;
            this.lstIslemOzeti.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Adı";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyadı";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Seyehat Tipi";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tren";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Hareket Saati";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Koltuk No";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 90;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Toplam Ücret";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 100;
            // 
            // btnIndir
            // 
            this.btnIndir.Location = new System.Drawing.Point(670, 87);
            this.btnIndir.Name = "btnIndir";
            this.btnIndir.Size = new System.Drawing.Size(127, 37);
            this.btnIndir.TabIndex = 4;
            this.btnIndir.Text = "Yazdır / İndir";
            this.btnIndir.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnIndir.Click += new System.EventHandler(this.btnIndir_Click);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "PNRNO";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 100;
            // 
            // frmIslemOzeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 382);
            this.Controls.Add(this.btnIndir);
            this.Controls.Add(this.grpYolcuBilgileri);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIslemOzeti";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "İşlem Özeti";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Right;
            this.Load += new System.EventHandler(this.frmIslemOzeti_Load);
            this.grpYolcuBilgileri.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpYolcuBilgileri;
		private MetroFramework.Controls.MetroButton btnIndir;
        private System.Windows.Forms.ListView lstIslemOzeti;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}