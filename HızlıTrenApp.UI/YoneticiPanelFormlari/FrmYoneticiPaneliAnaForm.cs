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
        

        public FrmYoneticiPaneliAnaForm(frmAnaSayfa frmAnaSayfa)
        {
            InitializeComponent();
            _frmAnaSayfa = frmAnaSayfa;
        }
        frmAnaSayfa _frmAnaSayfa;
        private void metroButton1_Click(object sender, EventArgs e)
        {
            FrmYoneticiSeferIslemleri frmSeferIslemleri = new FrmYoneticiSeferIslemleri();
            frmSeferIslemleri.TopLevel = false;

            frmSeferIslemleri.Parent = this;
            frmSeferIslemleri.Visible = true;
            frmSeferIslemleri.ShadowType = MetroFormShadowType.None;
            metroPanel1.Controls.Add(frmSeferIslemleri);
            frmSeferIslemleri.Show();
            frmSeferIslemleri.Location = Point.Empty;
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

        private void FrmYoneticiPaneliAnaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _frmAnaSayfa.Show();
        }
    }
}
