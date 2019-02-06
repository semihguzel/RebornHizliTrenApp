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
		public frmOdeme(frmKoltukSecimi form)
		{
			InitializeComponent();
            koltukForm = form;
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
		}

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
