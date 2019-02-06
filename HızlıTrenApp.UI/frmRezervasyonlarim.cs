using HızlıTrenApp.DAL.Repository.Concrete;
using HızlıTrenApp.DATA;
using MetroFramework;
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
	public partial class frmRezervasyonlarim : MetroFramework.Forms.MetroForm
	{
		public frmRezervasyonlarim()
		{
			InitializeComponent();
		}
		private RezerveConcrete _rezerveConcrete;
		object gelenRezerveBilet;
		private void frmRezervasyonlarim_Load_1(object sender, EventArgs e)
		{
			this.ControlBox = false;
			this.Text = "Rezervasyonlarım";
		}
		private void btnSorgula_Click(object sender, EventArgs e)
		{
			RezerveBiletListele();
		}

		private void RezerveBiletListele()
		{
			_rezerveConcrete = new RezerveConcrete();

			if (_rezerveConcrete.GelenRezerveBilet(txtPnrNo.Text, txtSoyad.Text) != null)
			{
				gelenRezerveBilet = _rezerveConcrete.GelenRezerveBilet(txtPnrNo.Text, txtSoyad.Text);
				List<object> liste = new List<object>();
				liste.Add(gelenRezerveBilet);
				dgvSeyehatBilgileri.DataSource = liste;
			}
			else
				MessageBox.Show("Lütfen PNR No ve Soyad alanlarını doğru girdiğinizden emin olunuz!", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void frmRezervasyonlarim_Load(object sender, EventArgs e)
		{
			dgvSeyehatBilgileri.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		}

		private void btnSatisaCevir_Click(object sender, EventArgs e)
		{
			string[] dizi = gelenRezerveBilet.ToString().Split(' ', ',');
			int biletId = Convert.ToInt32(dizi[3]);
			if (dgvSeyehatBilgileri.SelectedRows.Count > 0)
			{
				RezerveConcrete rezerveBilet = new RezerveConcrete();
				SatilanConcrete satilanBilet = new SatilanConcrete();
				RezerveBilet rezerve = rezerveBilet.GetBiletById(biletId);
				SatilanBilet satilan = new SatilanBilet();
				satilan.BiletID = rezerve.BiletID;
				satilan.MusteriID = rezerve.MusteriID;
				satilan.SatisTarihi = DateTime.Now;

				satilanBilet._satilanBiletRepository.Insert(satilan);

				rezerve.IsBought = true;
				satilanBilet._dbContext.SaveChanges();
				rezerveBilet._dbContext.SaveChanges();
				MessageBox.Show("Rezerve biletiniz Satışa Çevrilmiştir.");
				RezerveBiletListele();

			}
		}

		
	}
}