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
	public partial class frmIstasyonTrenBilgileri : MetroFramework.Forms.MetroForm	 
	{
		public frmIstasyonTrenBilgileri()
		{
			InitializeComponent();
		}
        public string istasyon;
        public DateTime tarih;
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (cmbIstasyon.SelectedIndex!=-1)
            {
                if (dtpTarih.Value.Date>=DateTime.Now.Date)
                {
                    istasyon = cmbIstasyon.SelectedItem.ToString();
                    tarih = dtpTarih.Value;
                    frmIstasyonAyrinti frmIstasyonAyrinti = new frmIstasyonAyrinti(this);
                    Hide();

                    GroupBox kutu = (GroupBox)this.Parent;
                    Form anaForm = (Form)kutu.Parent.Parent;
                    kutu.Width = frmIstasyonAyrinti.Width;
                    kutu.Height = frmIstasyonAyrinti.Height;
                    frmIstasyonAyrinti.MdiParent = anaForm;
                    kutu.Controls.Remove(this);
                    kutu.Controls.Add(frmIstasyonAyrinti);
                    frmIstasyonAyrinti.Show();
                    frmIstasyonAyrinti.Location = Point.Empty;
                }
                else
                {
                    MessageBox.Show("Önceki tarihlerin istasyon bilgileri bulunmamaktadır.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir istasyon seçiniz.");
            }
        }
    }
}
