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
	public partial class frmOdeme : MetroFramework.Forms.MetroForm
	{
        frmKoltukSecimi koltukForm;
        frmRezervasyonlarim rezerveForm;
		ListViewItem lvi;
		List<ListViewItem> listeler;
		public frmOdeme(frmKoltukSecimi form,ListViewItem list,List<ListViewItem> liste)
		{
			InitializeComponent();
            koltukForm = form;
			lvi = list;
			listeler = liste;
		}
        public frmOdeme(frmRezervasyonlarim form)
        {
            InitializeComponent();
            rezerveForm = form;
        }

        private void frmOdeme_Load(object sender, EventArgs e)
        {
			this.ControlBox = false;
			this.Text = "Ödeme";
			if (listeler != null)
			{
				foreach (ListViewItem item in listeler)
				{
					lstOdeme.Items.Add(item);
				}
			}
			else
			{
				lstOdeme.Items.Add(lvi);
			}
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
