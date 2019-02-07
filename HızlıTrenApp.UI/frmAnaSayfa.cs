using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
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
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }
        GroupBox kutu;
        public bool kutuVarMi = false;
        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            frmGiris giris = new frmGiris();
            //Tools.FormGetir(this, giris, grpAnaKutu, kutu, kutuVarMi, mlBilet);
            FormGetir(giris);
            mlBilet.UseStyleColors = true;
            mlIstasyonTren.UseStyleColors = true;
            mlBilet.Style = MetroColorStyle.Blue;
            mlIstasyonTren.Style = MetroColorStyle.Black;

        }

        public void FormGetir(MetroForm gelenForm)
        {
            if (!kutuVarMi)
            {

                foreach (Control item in this.Controls)
                {
                    if (item is GroupBox)
                    {
                        foreach (Control group in item.Controls)
                        {
                            if (group is GroupBox)
                            {
                                if (group.Name == "kutu")
                                    kutuVarMi = true;
                            }
                        }
                        if (!kutuVarMi)
                        {
                            kutu = new GroupBox();
                            kutuVarMi = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                foreach (MetroForm item in kutu.Controls)
                {
                    kutu.Controls.Remove(item);
                }
            }

            kutu.Location = new Point((this.Width - gelenForm.Width) / 2, (this.Height - gelenForm.Height) / 2);
            kutu.Text = "";
            kutu.Width = gelenForm.Size.Width;
            kutu.Height = gelenForm.Size.Height;
            if (grpAnaKutu.Height < kutu.Height)
            {
                grpAnaKutu.Height = kutu.Size.Height + 100;
                if (this.Height < grpAnaKutu.Height)
                    this.Height = grpAnaKutu.Size.Height + 160;
            }
            grpAnaKutu.Controls.Add(kutu);
            kutu.Location = new Point(0, (mlBilet.Height + (mlBilet.Top * 2)));
            kutu.Left = (grpAnaKutu.Right - kutu.Right) / 2;
            gelenForm.MdiParent = this;
            kutu.Controls.Add(gelenForm);
            gelenForm.Show();
            gelenForm.Location = Point.Empty;
            //this.Location = new Point(Location.X, Location.Y - 50);
        }

        private void mlBilet_Click(object sender, EventArgs e)
        {
            bool biletMi = false;
            foreach (Control item in grpAnaKutu.Controls)
            {
                if (item.Name == "frmGiris")
                    biletMi = true;
            }
            if (!biletMi)
            {
                frmGiris frmGiris = new frmGiris();
                Tools.FormGetir(this, frmGiris, grpAnaKutu, kutu, kutuVarMi, mlBilet);
                mlBilet.Style = MetroColorStyle.Blue;
                mlIstasyonTren.Style = MetroColorStyle.Black;
            }
        }

        bool istasyonMu = false;
        public void FormKontrolluGetir(MetroForm gelenform)
        {
            Form kutuIciForm = null;
            foreach (Control item in grpAnaKutu.Controls)
            {
                foreach (MetroForm form in item.Controls)
                {
                    if (form.Name == gelenform.Name)
                        istasyonMu = true;
                    else
                    {
                        kutuIciForm = form;
                        break;
                    }
                }
            }
            if (!istasyonMu)
            {
                //Tools.FormGetir(this, gelenform, grpAnaKutu, kutu, kutuVarMi, mlBilet);
                FormGetir(gelenform);
                mlBilet.Style = MetroColorStyle.Black;
                mlIstasyonTren.Style = MetroColorStyle.Blue;
            }
        }

        private void mlIstasyonTren_Click(object sender, EventArgs e)
        {
            frmIstasyonTrenBilgileri frmIstasyon = new frmIstasyonTrenBilgileri();
            FormKontrolluGetir(frmIstasyon);
            //Tools.FormKontrolluGetir(this, frmKoltuk, grpAnaKutu, kutu, istasyonMu, mlBilet, mlIstasyonTren);
        }

        private void mlBiletlerim_Click(object sender, EventArgs e)
        {
            frmBiletlerim biletlerim = new frmBiletlerim();
            AnaFormGetir(biletlerim);
        }

        private void AnaFormGetir(MetroForm gelenForm)
        {
            grpAnaKutu.Controls.Clear();
            //mlBilet.Hide();
            //mlIstasyonTren.Hide();
            gelenForm.Width = grpAnaKutu.Width;
            gelenForm.Height = grpAnaKutu.Height;
            gelenForm.MdiParent = this;
            grpAnaKutu.Controls.Add(gelenForm);
            gelenForm.Show();
            gelenForm.Location = Point.Empty;
        }

        private void mlRezervasyonlarim_Click(object sender, EventArgs e)
        {
            frmRezervasyonlarim rezervasyonlarim = new frmRezervasyonlarim();
            AnaFormGetir(rezervasyonlarim);
        }

        private void AnaSayfaYenile()
        {
            frmGiris giris = new frmGiris();
            foreach (Control item in grpAnaKutu.Controls)
            {
                if (item is MetroForm)
                    grpAnaKutu.Controls.Remove(item);
            }
            grpAnaKutu.Controls.Add(mlBilet);
            grpAnaKutu.Controls.Add(mlIstasyonTren);
            FormGetir(giris);
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            AnaSayfaYenile();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            frmYoneticiGirisControl frmYoneticiGirisControl = new frmYoneticiGirisControl(this);
            frmYoneticiGirisControl.Show();
            Hide();
        }
    }
}
