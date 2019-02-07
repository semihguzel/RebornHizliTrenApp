namespace HızlıTrenApp.UI.YoneticiPanelFormlari
{
    partial class FrmYoneticiPaneliAnaForm
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
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.btnSeferIslemleri = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(647, 29);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(125, 28);
            this.metroButton4.TabIndex = 7;
            this.metroButton4.Text = "Müşteri işlemleri";
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(516, 29);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(125, 28);
            this.metroButton3.TabIndex = 6;
            this.metroButton3.Text = "Bilet İşlemleri";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(385, 29);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(125, 28);
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "Çalışan İşlemleri";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // btnSeferIslemleri
            // 
            this.btnSeferIslemleri.Location = new System.Drawing.Point(254, 29);
            this.btnSeferIslemleri.Name = "btnSeferIslemleri";
            this.btnSeferIslemleri.Size = new System.Drawing.Size(125, 28);
            this.btnSeferIslemleri.TabIndex = 4;
            this.btnSeferIslemleri.Text = "Sefer İşlemleri";
            this.btnSeferIslemleri.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = " Yönetici Paneli";
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(749, 396);
            this.metroPanel1.TabIndex = 13;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // FrmYoneticiPaneliAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 479);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.btnSeferIslemleri);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.IsMdiContainer = true;
            this.Name = "FrmYoneticiPaneliAnaForm";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "MDIParent1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmYoneticiPaneliAnaForm_FormClosed);
            this.Load += new System.EventHandler(this.FrmYoneticiPaneliAnaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton btnSeferIslemleri;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}



