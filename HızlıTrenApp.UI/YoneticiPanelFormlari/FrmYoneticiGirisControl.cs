using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HızlıTrenApp.UI
{
    public partial class frmYoneticiGirisControl : MetroFramework.Forms.MetroForm
    {
        public frmYoneticiGirisControl(frmAnaSayfa frmAnaSayfa)
        {
            InitializeComponent();
            _frmAnaSayfa = frmAnaSayfa;
        }
        frmAnaSayfa _frmAnaSayfa;
        private void frmYoneticiGirisControl_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullanici = "ali";
            string sifre = "veli";
            YoneticiPanelFormlari.FrmYoneticiPaneliAnaForm frmYoneticiPaneliAnaForm = new YoneticiPanelFormlari.FrmYoneticiPaneliAnaForm(_frmAnaSayfa);
            frmYoneticiPaneliAnaForm.Show();
            Hide();
        }

        private void frmYoneticiGirisControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            _frmAnaSayfa.Show();
        }
    }
}
