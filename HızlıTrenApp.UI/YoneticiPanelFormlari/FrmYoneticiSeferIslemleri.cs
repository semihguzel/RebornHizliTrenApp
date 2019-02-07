using HızlıTrenApp.DAL.Repository.Concrete;
using HızlıTrenApp.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;


namespace HızlıTrenApp.UI.YoneticiPanelFormlari
{
    public partial class FrmYoneticiSeferIslemleri : MetroForm
    {
        public FrmYoneticiSeferIslemleri()
        {
            InitializeComponent();
            _seferlerDal = new SeferlerDal();
            _seferSaatleriDal = new SeferSaatleriDal();
            _SeferlerSeferSaatleriDal = new SeferlerSeferSaatleriDal();
        }

        private SeferlerDal _seferlerDal;
        private SeferSaatleriDal _seferSaatleriDal;
        private SeferlerSeferSaatleriDal _SeferlerSeferSaatleriDal;

        private void frmYoneticiSeferIslemleri_Load(object sender, EventArgs e)
        {
            dgvSeferler.DataSource = _seferlerDal.GetAllSeferler();
            btnSil.Enabled = false;
            btnGuncelle.Enabled = false;
        }

        private void btnSeferAra_Click(object sender, EventArgs e)
        {
            if (txtSeferAra.Text != string.Empty)
            {
                dgvSeferler.DataSource = _seferlerDal.GetSeferByContains(txtSeferAra.Text);
            }
            else
                MessageBox.Show("Sefer aramak için bir şeyler yazınız.");

            txtSeferAra.Text = string.Empty;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dgvSeferler.DataSource = _seferlerDal.GetAllSeferler();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (_seferlerDal.GetSeferByContains(txtKalkıs.Text + "-" + txtVarıs) != null)
            {
                if (txtKalkıs.Text.Trim() != string.Empty && txtVarıs.Text.Trim() != string.Empty && txtYolcuKapasitesi.Text.Trim() != string.Empty && txtVarısSuresi.Text.Trim() != string.Empty)
                {
                    SeferEkle(1);
                    SeferEkle(2);
                    dgvSeferler.DataSource = _seferlerDal.GetAllSeferler();
                    Temizle();
                    MessageBox.Show("Sefer ekleme işlemi gerçekletirilmiştir.");
                }
                else
                    MessageBox.Show("Lütfen, bütün alanlara veri girilmiş olduğundan emin olunuz...");
            }
            else
                MessageBox.Show("Böyle bir sefer vardır.");
        }

        private void SeferEkle(int sayi)
        {
            Sefer sefer = new Sefer();
            if (sayi == 1)
            {
                sefer.SeferYonu = txtKalkıs.Text + "-" + txtVarıs.Text;
            }
            else
            {
                sefer.SeferYonu = txtVarıs.Text + "-" + txtKalkıs.Text;
            }
            sefer.TahminiVarisSuresi = txtVarısSuresi.Text;
            sefer.YolcuKapasitesi = Convert.ToByte(txtYolcuKapasitesi.Text);
            _seferlerDal.Add(sefer);

            if (sayi==1)
            {
                sefer = _seferlerDal.GetSeferIDByFilter(txtKalkıs.Text, txtVarıs.Text);
            }
            else
            {
                sefer = _seferlerDal.GetSeferIDByFilter(txtVarıs.Text, txtKalkıs.Text);
            }
            
            List<SeferSaat> seferSaatleri = new List<SeferSaat>();
            seferSaatleri = _seferSaatleriDal.GetAll();
            List<SeferSeferSaat> seferSeferSaats = new List<SeferSeferSaat>();
            for (int i = 0; i < seferSaatleri.Count; i++)
            {
                SeferSeferSaat seferSeferSaat = new SeferSeferSaat
                {
                    SeferSaatID = seferSaatleri[i].SeferSaatID,
                    SeferID = sefer.SeferID
                };
                seferSeferSaats.Add(seferSeferSaat);
            }
            _SeferlerSeferSaatleriDal.Add(seferSeferSaats);
        }

        public void Temizle()
        {
            txtKalkıs.Text = txtVarıs.Text = txtVarısSuresi.Text = txtYolcuKapasitesi.Text = string.Empty;
        }
        string kalkis, varis;
        private void dgvSeferler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEkle.Enabled = false;
            btnGuncelle.Enabled = btnSil.Enabled = true;
            string[] sehirler = dgvSeferler.CurrentRow.Cells[1].Value.ToString().Split('-');
            txtKalkıs.Text = sehirler[0];
            txtVarıs.Text = sehirler[1];
            txtVarısSuresi.Text = dgvSeferler.CurrentRow.Cells[2].Value.ToString();
            txtYolcuKapasitesi.Text = dgvSeferler.CurrentRow.Cells[3].Value.ToString();
            kalkis = sehirler[0];
            varis = sehirler[1];
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtKalkıs.Text.Trim() != string.Empty && txtVarıs.Text.Trim() != string.Empty)
            {
                var result = MessageBox.Show("Bu seferi sildiğiniz de, aynı seferin dönüş seferi de silinecektir. Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    SeferSil();
                    MessageBox.Show("Sefer Silme İşlemi Gerçekleştirilmiştir.");
                }
                else
                {
                    MessageBox.Show("Silme işlemi iptal edilmiştir.");
                }
                Temizle();
                btnGuncelle.Enabled = btnSil.Enabled = false;
                btnEkle.Enabled = true;
                dgvSeferler.DataSource = _seferlerDal.GetAllSeferler();
            }
            else
                MessageBox.Show("Lütfen verilerin dolu oldğundan emin olunuz.");

        }

        private void SeferSil()
        {
            Sefer sefer1 = _seferlerDal.GetSeferIDByFilter(txtKalkıs.Text, txtVarıs.Text);
            Sefer sefer2 = _seferlerDal.GetSeferIDByFilter(txtVarıs.Text, txtKalkıs.Text);

            _seferlerDal.Delete(sefer1);
            _seferlerDal.Delete(sefer2);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtKalkıs.Text.Trim() != string.Empty && txtVarıs.Text.Trim() != string.Empty)
            {
                var result = MessageBox.Show("Seferlerde yaptığınız değişiklikler aynı seferin dönüşünü de etkilemektedir. Güncellemeye devam edilsin mi?", "Güncelleme uyarısı.", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    SeferGuncelle();
                    MessageBox.Show("Güncelleme işlemi başarıyla gerçekleştirilmiştir.");
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi iptal edilmiştir.");
                }
                Temizle();
                btnGuncelle.Enabled = btnSil.Enabled = false;
                btnEkle.Enabled = true;
                dgvSeferler.DataSource = _seferlerDal.GetAllSeferler();
            }
            else
                MessageBox.Show("Lütfen verilerin dolu oldğundan emin olunuz.");

        }

        private void SeferGuncelle()
        {
            Sefer sefer1 = new Sefer();
            sefer1 = _seferlerDal.GetSeferIDByFilter(kalkis, varis);

            Sefer sefer2 = new Sefer();
            sefer2 = _seferlerDal.GetSeferIDByFilter(varis, kalkis);

            sefer1.SeferYonu = txtKalkıs.Text + "-" + txtVarıs.Text;
            sefer2.SeferYonu = txtVarıs.Text + "-" + txtKalkıs.Text;
            sefer1.TahminiVarisSuresi = txtVarısSuresi.Text;
            sefer2.TahminiVarisSuresi = txtVarısSuresi.Text;
            sefer1.YolcuKapasitesi = Convert.ToByte(txtYolcuKapasitesi.Text);
            sefer2.YolcuKapasitesi = Convert.ToByte(txtYolcuKapasitesi.Text);

            _seferlerDal.Update(sefer1);
            _seferlerDal.Update(sefer2);
        }
    }
}
