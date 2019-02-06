using HızlıTrenApp.DAL.Repository.Concrete;
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
	public partial class frmBiletlerim : MetroFramework.Forms.MetroForm
	{
		public frmBiletlerim()
		{
			InitializeComponent();
		}

		private void frmBiletlerim_Load(object sender, EventArgs e)
		{
			dgvSeyehatBilgileri.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		}
		private BiletConcrete _biletConcrete;
		object gelenBilet;
		private void btnSorgula_Click(object sender, EventArgs e)
		{
			BiletleriListele();
		}

		private void BiletleriListele()
		{
			_biletConcrete = new BiletConcrete();

			if (_biletConcrete.GelenBilet(txtPnrNo.Text, txtSoyad.Text) != null)
			{
				gelenBilet = _biletConcrete.GelenBilet(txtPnrNo.Text, txtSoyad.Text);
				List<object> liste = new List<object>();
				liste.Add(gelenBilet);
				dgvSeyehatBilgileri.DataSource = liste;
			}
			else
				MessageBox.Show("Lütfen PNR No ve Soyad alanlarını doğru girdiğinizden emin olunuz!", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void frmBiletlerim_Load_1(object sender, EventArgs e)
		{
			this.ControlBox = false;
			this.Text = "Biletlerim";
		}
	}
}