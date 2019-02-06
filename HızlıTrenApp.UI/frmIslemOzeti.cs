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
	public partial class frmIslemOzeti : MetroFramework.Forms.MetroForm
	{
		public frmIslemOzeti()
		{
			InitializeComponent();
		}

		private void frmIslemOzeti_Load(object sender, EventArgs e)
		{
			this.ControlBox = false;
			this.Text = "İşlem Özeti";
		}
	}
}
