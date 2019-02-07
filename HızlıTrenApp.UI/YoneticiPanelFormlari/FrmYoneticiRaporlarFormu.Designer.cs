namespace HızlıTrenApp.UI.YoneticiPanelFormlari
{
    partial class FrmYoneticiRaporlarFormu
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
            this.cmbRaporlar = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.grpRapor = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // cmbRaporlar
            // 
            this.cmbRaporlar.FormattingEnabled = true;
            this.cmbRaporlar.ItemHeight = 23;
            this.cmbRaporlar.Location = new System.Drawing.Point(178, 59);
            this.cmbRaporlar.Name = "cmbRaporlar";
            this.cmbRaporlar.Size = new System.Drawing.Size(370, 29);
            this.cmbRaporlar.TabIndex = 0;
            this.cmbRaporlar.SelectedIndexChanged += new System.EventHandler(this.cmbRaporlar_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(24, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(148, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Bir Rapor Seçiniz :";
            // 
            // grpRapor
            // 
            this.grpRapor.Location = new System.Drawing.Point(24, 92);
            this.grpRapor.Name = "grpRapor";
            this.grpRapor.Size = new System.Drawing.Size(698, 275);
            this.grpRapor.TabIndex = 2;
            this.grpRapor.TabStop = false;
            // 
            // FrmYoneticiRaporlarFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 390);
            this.Controls.Add(this.grpRapor);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmbRaporlar);
            this.Name = "FrmYoneticiRaporlarFormu";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Load += new System.EventHandler(this.FrmYoneticiRaporlarFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbRaporlar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox grpRapor;
    }
}