using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HızlıTrenApp.UI
{
	public partial class frmIslemOzeti : MetroFramework.Forms.MetroForm
	{
		
		private PrintDocument printDocument1 = new PrintDocument();
		public frmIslemOzeti()
		{			
			printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);		
			InitializeComponent();
		}

		private void frmIslemOzeti_Load(object sender, EventArgs e)
		{
			this.ControlBox = false;
			this.Text = "İşlem Özeti";
		}
		Bitmap memoryImage;

		private void CaptureScreen()
		{
			Graphics myGraphics = this.CreateGraphics();
			Size s = this.Size;
			memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
			Graphics memoryGraphics = Graphics.FromImage(memoryImage);
			memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
		}

		private void printDocument1_PrintPage(System.Object sender,
			   System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.Graphics.DrawImage(memoryImage, 0, 0);
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnYazdir_Click(object sender, EventArgs e)
		{
			CaptureScreen();
			printDocument1.Print();
		}

		private void btnIndir_Click(object sender, EventArgs e)
		{
			PrintDocument doc = new PrintDocument();
			doc.PrintPage += this.Doc_PrintPage;
			PrintDialog dlgSettings = new PrintDialog();
			dlgSettings.Document = doc;
			if (dlgSettings.ShowDialog() == DialogResult.OK)
			{
				doc.Print();
			}
		}
		private void Doc_PrintPage(object sender, PrintPageEventArgs e)
		{
			float x = e.MarginBounds.Left;
			float y = e.MarginBounds.Top;
			Bitmap bmp = new Bitmap(this.grpYolcuBilgileri.Width, this.grpYolcuBilgileri.Height);
			this.grpYolcuBilgileri.DrawToBitmap(bmp, new Rectangle(0, 0, this.grpYolcuBilgileri.Width, this.grpYolcuBilgileri.Height));
			e.Graphics.DrawImage((Image)bmp, x, y);
		}
	}
}

