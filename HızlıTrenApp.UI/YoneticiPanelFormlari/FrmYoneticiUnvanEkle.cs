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
    public partial class FrmYoneticiUnvanEkle : MetroForm
    {
        public FrmYoneticiUnvanEkle()
        {
            InitializeComponent();
            _unvanDal = new UnvanDal();
        }
        private UnvanDal _unvanDal;

        private void FrmYoneticiUnvanEkle_Load(object sender, EventArgs e)
        {
            UnvanDoldur();
            btnGuncelle.Enabled = false;

        }

        private void UnvanDoldur()
        {
            cmbUnvanlar.DataSource = _unvanDal.GetAll();
            cmbUnvanlar.DisplayMember = "UnvanAdi";
            cmbUnvanlar.ValueMember = "UnvanID";
        }

        private void cmbUnvanlar_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                Unvan unvan = new Unvan();
                unvan = _unvanDal.GetByUnvanID(Convert.ToInt32(cmbUnvanlar.SelectedValue));
                txtMaas.Text = unvan.Maas.ToString();
                btnGuncelle.Enabled = true;
                btnEkle.Enabled = false;
            }
            catch
            {

            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtMaas.Text.Trim() != string.Empty && txtUnvan.Text != string.Empty)
            {
                try
                {
                    Unvan unvan = new Unvan
                    {
                        Maas = Convert.ToDecimal(txtMaas.Text),
                        UnvanAdi = txtUnvan.Text
                    };
                    _unvanDal.Add(unvan);
                    txtMaas.Text = txtUnvan.Text = string.Empty;
                    MessageBox.Show("Yeni ünvan eklendi.");
                    UnvanDoldur();
                }
                catch
                {
                    MessageBox.Show("Ünvan uzunluk sınırını geçtiniz!");
                }
            }
            else
            {

            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtMaas.Text.Trim() != string.Empty)
            {
                Unvan unvan = new Unvan();
                unvan = _unvanDal.GetByUnvanID(Convert.ToInt32(cmbUnvanlar.SelectedValue));
                unvan.Maas = Convert.ToDecimal(txtMaas.Text);
                _unvanDal.Update(unvan);
                MessageBox.Show("Güncelleme yapıldı.");
                txtMaas.Text = txtUnvan.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Ünvan ve Maaş alanları dolu olmak zorundadır.");
            }
        }
    }
}
