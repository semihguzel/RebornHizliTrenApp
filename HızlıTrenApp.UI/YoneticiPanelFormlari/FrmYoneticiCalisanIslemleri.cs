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
                try
                {
                    Calisan calisan = new Calisan
                    {
                        Ad = txtAd.Text,
                        Soyad = txtSoyad.Text,
                        Adres = txtAdres.Text,
                        Cinsiyet = chkErkek.Checked,
                        UnvanID = Convert.ToInt32(cmbUnvan.SelectedValue),
                        DogumTarihi = dtpDogumTarihi.Value,
                        IseAlimTarihi = DateTime.Now,
                        TcNo = txtTcNo.Text
                    };

                    _calisanConcreteDal.Add(calisan);
                    chkErkek.Checked = true;
                    Metodlar.Temizle(pnlKayit);
                    txtAd.Text = txtAdres.Text = txtSoyad.Text = txtTcNo.Text = string.Empty;
                    dgvCalisanlar.DataSource = _calisanConcreteDal.CalisanList();
                    MessageBox.Show("Ekleme işlemi gerçekleşti.");
                }
                catch
                {
                    MessageBox.Show("Hatalı veri girişi tespit edildi.");
                }
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
                btnGuncelle.Enabled = btnSil.Enabled = true;
                btnEkle.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Lütfen bir calisan seçiniz.");
            }

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dgvCalisanlar.DataSource = _calisanConcreteDal.CalisanList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"{txtAd.Text} adlı çalışan silmek istediğinize emin misiniz?", "Silme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Calisan calisan = new Calisan
                    {
                        CalisanID = Convert.ToInt32(dgvCalisanlar.CurrentRow.Cells[0].Value.ToString())
                    };
                    _calisanConcreteDal.Remove(calisan);
                    dgvCalisanlar.DataSource = _calisanConcreteDal.CalisanList();
                    btnSil.Enabled = btnGuncelle.Enabled = false;
                    btnEkle.Enabled = true;
                    Metodlar.Temizle(pnlKayit);
                    txtAd.Text = txtAdres.Text = txtSoyad.Text = txtTcNo.Text = string.Empty;
                    MessageBox.Show("Silme işlemi gerçekleştirildi.");

                }
                catch
                {
                    MessageBox.Show("Lütfen bir çalışan seçtiğinizden emin olunuz.");
                }
            }
            else
            {
                MessageBox.Show("Silme işlemi iptal edildi.");
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (Metodlar.Sorgula(pnlKayit))
            {
                try
                {
                    Calisan calisan = new Calisan();
                    calisan = _calisanConcreteDal.GetCalisanByID(Convert.ToInt32(dgvCalisanlar.CurrentRow.Cells[0].Value.ToString()));
                    calisan.Ad = txtAd.Text;
                    calisan.Soyad = txtSoyad.Text;
                    calisan.TcNo = txtTcNo.Text;
                    calisan.Adres = txtAdres.Text;
                    calisan.DogumTarihi = dtpDogumTarihi.Value;
                    calisan.UnvanID = Convert.ToInt32(cmbUnvan.SelectedValue);
                    calisan.Cinsiyet = chkErkek.Checked;

                    _calisanConcreteDal.Update(calisan);

                    chkErkek.Checked = true;
                    dgvCalisanlar.DataSource = _calisanConcreteDal.CalisanList();
                    btnSil.Enabled = btnGuncelle.Enabled = false;
                    btnEkle.Enabled = true;
                    Metodlar.Temizle(pnlKayit);
                    txtAd.Text = txtAdres.Text = txtSoyad.Text = txtTcNo.Text = string.Empty;
                    MessageBox.Show("Güncelleme işlemi gerçekleştirildi.");
                }
                catch
                {
                    MessageBox.Show("Girdiğiniz veriler mantık sınırları dışında:D");
                }
            }
            else
                MessageBox.Show("Lütfen girdiğiniz verileri kontrol ediniz...");
        }
        

        private void btnUnvanEkle_Click(object sender, EventArgs e)
        {
            FrmYoneticiUnvanEkle frmYoneticiUnvanEkle = new FrmYoneticiUnvanEkle();
            frmYoneticiUnvanEkle.Show();
        }
    }
}


