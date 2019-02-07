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
using HızlıTrenApp.DATA;
using MetroFramework.Forms;

namespace HızlıTrenApp.UI.YoneticiPanelFormlari
{
    public partial class FrmYoneticiCalisanIslemleri : MetroForm
    {
        public FrmYoneticiCalisanIslemleri()
        {
            InitializeComponent();
            _calisanConcreteDal = new CalisanConcrete();
            _unvanDal = new UnvanDal();
        }
        private CalisanConcrete _calisanConcreteDal;
        private UnvanDal _unvanDal;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (Metodlar.Sorgula(pnlKayit))
            {
                Calisan calisan = new Calisan
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Adres = txtAdres.Text,
                    UnvanID = Convert.ToInt32(cmbUnvan.ValueMember),
                    Cinsiyet = chkErkek.Checked,
                    DogumTarihi = dtpDogumTarihi.Value,
                    IseAlimTarihi = DateTime.Now,
                    TcNo = txtTcNo.Text
                };
                _calisanConcreteDal.Add(calisan);
                chkErkek.Checked = true;
                Metodlar.Temizle(pnlKayit);
            }
            else
                MessageBox.Show("Lütfen girdiğiniz verileri kontrol ediniz...");
        }

        private void FrmYoneticiCalisanIslemleri_Load(object sender, EventArgs e)
        {
            btnSil.Enabled = btnGuncelle.Enabled = false;
            dgvCalisanlar.DataSource = _calisanConcreteDal.CalisanList();
            cmbUnvan.DataSource = _unvanDal.GetAll();
            cmbUnvan.DisplayMember = "UnvanAdi";
            cmbUnvan.ValueMember = "UnvanID";
            chkErkek.Checked = true;
        }

        private void chkErkek_CheckedChanged(object sender, EventArgs e)
        {
            chkKadin.Checked = !chkErkek.Checked;
        }

        private void chkKadin_CheckedChanged(object sender, EventArgs e)
        {
            chkErkek.Checked = !chkKadin.Checked;
        }

        private void dgvCalisanlar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnGuncelle.Enabled = btnSil.Enabled = true;
            btnEkle.Enabled = false;
            try
            {
                txtTcNo.Text = dgvCalisanlar.CurrentRow.Cells[1].Value.ToString();
                txtAd.Text = dgvCalisanlar.CurrentRow.Cells[2].Value.ToString();
                txtSoyad.Text = dgvCalisanlar.CurrentRow.Cells[3].Value.ToString();
                string cinsiyet = dgvCalisanlar.CurrentRow.Cells[5].Value.ToString();
                chkErkek.Checked = Convert.ToBoolean(cinsiyet);
                dtpDogumTarihi.Value = Convert.ToDateTime(dgvCalisanlar.CurrentRow.Cells[6].Value.ToString());
                string unvanID = dgvCalisanlar.CurrentRow.Cells[9].Value.ToString();
                cmbUnvan.SelectedValue = Convert.ToInt32(unvanID);
                txtAdres.Text = dgvCalisanlar.CurrentRow.Cells[4].Value.ToString();
            }
            catch
            {
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dgvCalisanlar.DataSource = _calisanConcreteDal.CalisanList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                Calisan calisan = new Calisan
                {
                    CalisanID = Convert.ToInt32(dgvCalisanlar.CurrentRow.Cells[0].Value.ToString())
                };
                _calisanConcreteDal.Remove(calisan);
                dgvCalisanlar.DataSource = _calisanConcreteDal.CalisanList();

                btnGuncelle.Enabled = btnSil.Enabled = false;
                btnEkle.Enabled = true;
            }
            catch 
            {
                MessageBox.Show("Lütfen bir çalışan seçtiğinizden emin olunuz.");
            }

                


        }
    }

}
