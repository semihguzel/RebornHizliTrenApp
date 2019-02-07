using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HızlıTrenApp.UI.YoneticiPanelFormlari
{
    public partial class FrmYoneticiPaneliAnaForm : MetroFramework.Forms.MetroForm
    {
        

        public FrmYoneticiPaneliAnaForm()
        {
            InitializeComponent();
        }
        
        private void metroButton1_Click(object sender, EventArgs e)
        {
            FrmYoneticiSeferIslemleri frmSeferIslemleri = new FrmYoneticiSeferIslemleri();
            // From nesneni olarak parametre alan metodumuza açmak istediğimiz formu gönderiyoruz.
            frmSeferIslemleri.TopLevel = false;

            //frmSeferIslemleri.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.None;
          
            frmSeferIslemleri.Parent = this;
            frmSeferIslemleri.Visible = true;
            frmSeferIslemleri.Location = new Point((this.Width - frmSeferIslemleri.Width) / 2, (this.Height - frmSeferIslemleri.Height) / 2);
            //this.AutoScroll = true;
            //frmSeferIslemleri.Parent = groupBox1;
            //frmSeferIslemleri.MdiParent = this.ParentForm;
            
            frmSeferIslemleri.Show();
            metroPanel1.Controls.Add(frmSeferIslemleri);
            //Controls.Add(frmSeferIslemleri);
            //frmSeferIslemleri.Dock = DockStyle.Fill;
            //frmSeferIslemleri.MdiParent = this;
            //frmSeferIslemleri.Show();
            //AcilacakForm(frmSeferIslemleri);
        }

    
        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmYoneticiPaneliAnaForm_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            FrmYoneticiCalisanIslemleri frmYoneticiCalisanIslemleri = new FrmYoneticiCalisanIslemleri();
            frmYoneticiCalisanIslemleri.Show();
        }
    }
}
