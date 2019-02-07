using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HızlıTrenApp.DAL.Repository.Concrete;
using MetroFramework.Forms;

namespace HızlıTrenApp.UI.YoneticiPanelFormlari
{
    public partial class FrmYoneticiCalisanIslemleri : MetroForm
    {
        public FrmYoneticiCalisanIslemleri()
        {
            InitializeComponent();
            _calisanConcreteDal = new CalisanConcrete();
        }
        private CalisanConcrete _calisanConcreteDal;

        private void btnEkle_Click(object sender, EventArgs e)
        {

        }

        private void FrmYoneticiCalisanIslemleri_Load(object sender, EventArgs e)
        {
            btnSil.Enabled = btnGuncelle.Enabled = false;
            dgvCalisanlar.DataSource = _calisanConcreteDal.CalisanList();
        }
    }
}
