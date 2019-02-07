using HızlıTrenApp.DAL.Repository.Concrete;
using HızlıTrenApp.DATA.Classes;
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
            _yoneticiDal = new YoneticiDal();
        }
        frmAnaSayfa _frmAnaSayfa;
        YoneticiDal _yoneticiDal;

        private void frmYoneticiGirisControl_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text.Trim()!=string.Empty&&txtSifre.Text.Trim()!=string.Empty)
            {
                Yonetici yonetici = new Yonetici();
                if (_yoneticiDal.GetByUserNamePasword(txtKullaniciAdi.Text,txtSifre.Text)!=null)
                {
                    YoneticiPanelFormlari.FrmYoneticiPaneliAnaForm frmYoneticiPaneliAnaForm = new YoneticiPanelFormlari.FrmYoneticiPaneliAnaForm(_frmAnaSayfa);
                    frmYoneticiPaneliAnaForm.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı adı veya şifre girdiniz lütfen kontrol ediniz.");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ve şifre alanı boş bırakılamaz.");
            }
           
        }

        private void frmYoneticiGirisControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            _frmAnaSayfa.Show();
        }
    }
}
