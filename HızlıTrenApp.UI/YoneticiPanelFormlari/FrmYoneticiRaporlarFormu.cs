using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HızlıTrenApp.DATA;
using MetroFramework.Forms;

namespace HızlıTrenApp.UI.YoneticiPanelFormlari
{
    public partial class FrmYoneticiRaporlarFormu : MetroForm
    {
        public FrmYoneticiRaporlarFormu()
        {
            InitializeComponent();
        }

        private void FrmYoneticiRaporlarFormu_Load(object sender, EventArgs e)
        {
            cmbRaporlar.Items.Add("Economy/Business Bilet Alım Oranı");
            cmbRaporlar.Items.Add("Müşterilerin Kadın/Erkek Oranı");
            cmbRaporlar.Items.Add("Çalışanların Kadın/Erkek Oranı");
        }

        private void cmbRaporlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbRaporlar.SelectedIndex)
            {
                case 0:
                    grpRapor.Controls.Clear();
                    Reporter.ReportFormCreate<BiletBilgi>(grpRapor, "BiletBilgiID", "AlimTarihi", "BiletTipi",
                        "KoltukNo", "BiletFiyati", "SeferTarihi", "SeferSaati", "MusteriID", "SeferSeferSaatID");
                    break;
                case 1:
                    grpRapor.Controls.Clear();
                    Reporter.ReportFormCreate<Musteri>(grpRapor, "MusteriID", "Ad", "Soyad","Cinsiyet","DogumTarihi");
                    break;
                case 2:
                    grpRapor.Controls.Clear();
                    Reporter.ReportFormCreate<Calisan>(grpRapor, "CalisanID", "TcNo", "Ad", "Soyad", "Adres", "Cinsiyet", "DogumTarihi", "IseAlimTarihi", "UnvanID");
                    break;
                default:
                    break;
            }
        }
    }
}
