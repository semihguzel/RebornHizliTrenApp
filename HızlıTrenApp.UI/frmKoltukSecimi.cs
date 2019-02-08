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

namespace HızlıTrenApp.UI
{
    public partial class frmKoltukSecimi : MetroFramework.Forms.MetroForm
    {
        Form gelenForm;
        int seferId = 0;
        string saat = "";
        bool gidisVarMi = false;
        bool donusVarMi = false;
        DateTime gidisTarihi;
        DateTime donusTarihi;
        int yolcuSayisi = 0;
        string biletTipi = "";
        bool rezerveMi = false;
        int donusSssd = 0;
        int donusId = 0;
        int donusSaatId = 0;
        public frmKoltukSecimi(Form form, int id, string tiklananSaat, bool gidis, bool donus, DateTime gidisT, DateTime donusT, int yolcular, string tip, bool rezerve, int donusSeferSaatId, int tiklananDonusId, int tiklananDonusSaatId)
        {
            InitializeComponent();
            gelenForm = form;
            seferId = id;
            saat = tiklananSaat;
            gidisVarMi = gidis;
            donusVarMi = donus;
            gidisTarihi = gidisT;
            donusTarihi = donusT;
            yolcuSayisi = yolcular;
            biletTipi = tip;
            rezerveMi = rezerve;
            donusSssd = donusSeferSaatId;
            donusSaatId = tiklananDonusSaatId;
            donusId = tiklananDonusId;
        }
        List<BiletBilgi> businessKadinBiletler;
        List<BiletBilgi> businessErkekBiletler;
        List<BiletBilgi> economyErkekBiletler;
        List<BiletBilgi> economyKadinBiletler;

        string economyErkekKoltuk = @"..\..\Images\Resized_Seats\seat_man_resized_economy.png";
        string economyKadinKoltuk = @"..\..\Images\Resized_Seats\seat_woman_resized_economy.png";
        string businessBosKoltuk = @"..\..\Images\Resized_Seats\seat_available_resized_business.png";
        string economyBosKoltuk = @"..\..\Images\Resized_Seats\seat_available_resized_economy.png";
        string economyLuggage = @"..\..\Images\luggage_economy.png";
        string secilenKoltuk = @"..\..\Images\Resized_Seats\seat_reserved_resized_economy.png";
        int kayitSayaci = 0;
        int saatID = 0;
        BiletBilgiDal biletBilgiConcrete = new BiletBilgiDal();
        private void frmKoltukSecimi_Load(object sender, EventArgs e)
        {
            if (!gidisVarMi)
            {
                KoltuklariOlustur();
            }

            if (rezerveMi)
                btnOdemeyeGec.Text = "Rezerve Et";

            this.ControlBox = false;
            this.Text = "Koltuk Seçimi";
            if (yolcuSayisi > 1)
            {
                cmbBiletTipi.Enabled = true;
                cmbBiletTipi.SelectedIndex = 0;
                lblYolcuSayisiBilgilendirme.Text = "Seçtiğiniz " + yolcuSayisi + " adet biletten " + kayitSayaci + " kadar eklenmiştir.";
                
            }
            else
            {
                lblYolcuSayisiBilgilendirme.Visible = false;
                cmbBiletTipi.Text = biletTipi;
                lblYolcuSayisiBilgilendirme.Visible = false;
            }

            SeferSaatleriDal ssd = new SeferSaatleriDal();
            saatID = ssd.GetIdByDate(saat);
            if (gidisVarMi)
            {
                KoltuklariOlustur();
                KoltuklariDoldur();
            }
        }

        private void CokluSecim(object sender, EventArgs e)
        {
            tiklanan = sender as PictureBox;
            GroupBox grp = (GroupBox)tiklanan.Parent;
            if (!rdbErkek.Checked == !rdbKadin.Checked)
            {
                MessageBox.Show("Lütfen 'Yolcu Bilgileri' kutucuğundan bir cinsiyet seçiniz");
                return;
            }
            if (tiklanan.Name.StartsWith("E") && tiklanan.ImageLocation != null && tiklanan.ImageLocation == economyErkekKoltuk | tiklanan.ImageLocation == economyKadinKoltuk)
            {
                MessageBox.Show("Lütfen boş bir koltuk seçiniz");
            }
            else
            {
                foreach (Control yanindaki in grp.Controls)
                {
                    if (yanindaki is PictureBox)
                    {
                        if ((yanindaki.Location.X == tiklanan.Location.X && yanindaki.Name.StartsWith("E") && yanindaki.Name != tiklanan.Name && tiklanan.ImageLocation.Contains("available")) && sonTiklananKoltukAdi != tiklanan.Name && ((((PictureBox)yanindaki).ImageLocation.Contains("woman") && !rdbKadin.Checked) || (((PictureBox)yanindaki).ImageLocation.Contains("_man") && !rdbErkek.Checked)))
                        {
                            MessageBox.Show("Seçilen koltuk karşı cinsin yanında olamaz. Lütfen doğru şekilde koltuk seçiniz.");
                            return;
                        }
                        else if (yanindaki.Location.X == tiklanan.Location.X && yanindaki.Name != "" && tiklanan.ImageLocation.Contains("available") && yanindaki.Name != tiklanan.Name)
                        {
                            if (eskiTiklanan != null)
                            {
                                eskiTiklanan.ImageLocation = economyBosKoltuk;
                            }
                            tiklanan.ImageLocation = secilenKoltuk;
                            eskiTiklanan = tiklanan;
                            return;
                        }
                    }
                }
            }
        }

        private void KoltuklariDoldur()
        {
            businessKadinBiletler = biletBilgiConcrete.BusinessWomanTickets(seferId, saatID, gidisTarihi);
            businessErkekBiletler = biletBilgiConcrete.BusinessManTickets(seferId, saatID, gidisTarihi);

            economyKadinBiletler = biletBilgiConcrete.EconomyWomanTickets(seferId, saatID, gidisTarihi);
            economyErkekBiletler = biletBilgiConcrete.EconomyManTickets(seferId, saatID, gidisTarihi);

            BusinessKadinlar(grpBusiness1, grpBusiness2);
            BusinessErkekler(grpBusiness1, grpBusiness2);

            EconomyKadinlar(grpEconomy1, grpEconomy2);
            EconomyErkekler(grpEconomy1, grpEconomy2);
        }

        private void EconomyErkekler(GroupBox grpEconomy1, GroupBox grpEconomy2)
        {
            foreach (BiletBilgi bilet in economyErkekBiletler)
            {
                foreach (Control item in grpEconomy1.Controls)
                {
                    if (item is PictureBox && bilet.KoltukNo == item.Name)
                    {
                        ((PictureBox)item).ImageLocation = economyErkekKoltuk;
                    }
                }
                foreach (Control item in grpEconomy2.Controls)
                {
                    if (item is PictureBox && bilet.KoltukNo == item.Name)
                    {
                        ((PictureBox)item).ImageLocation = economyErkekKoltuk;
                    }
                }
            }
        }

        private void EconomyKadinlar(GroupBox grpEconomy1, GroupBox grpEconomy2)
        {
            foreach (BiletBilgi bilet in economyKadinBiletler)
            {
                foreach (Control item in grpEconomy1.Controls)
                {
                    if (item is PictureBox && bilet.KoltukNo == item.Name)
                    {
                        ((PictureBox)item).ImageLocation = economyKadinKoltuk;
                    }
                }
                foreach (Control item in grpEconomy2.Controls)
                {
                    if (item is PictureBox && bilet.KoltukNo == item.Name)
                    {
                        ((PictureBox)item).ImageLocation = economyKadinKoltuk;
                    }
                }
            }
        }

        private void BusinessErkekler(GroupBox grpBusiness1, GroupBox grpBusiness2)
        {
            if (businessErkekBiletler.Count == 0)
            {
                foreach (BiletBilgi bilet in businessErkekBiletler)
                {
                    foreach (Control item in grpBusiness1.Controls)
                    {
                        if (item is PictureBox)
                        {
                            ((PictureBox)item).ImageLocation = economyBosKoltuk;
                        }
                    }
                }
            }
            else
            {
                foreach (BiletBilgi bilet in businessErkekBiletler)
                {
                    foreach (Control item in grpBusiness1.Controls)
                    {
                        if (item is PictureBox && bilet.KoltukNo == item.Name)
                        {
                            ((PictureBox)item).ImageLocation = economyErkekKoltuk;
                        }
                    }
                    foreach (Control item in grpBusiness2.Controls)
                    {
                        if (item is PictureBox && bilet.KoltukNo == item.Name)
                        {
                            ((PictureBox)item).ImageLocation = economyErkekKoltuk;
                        }
                    }
                }
            }
        }

        private void BusinessKadinlar(GroupBox grpBusiness1, GroupBox grpBusiness2)
        {
            if (businessKadinBiletler.Count == 0)
            {
                foreach (BiletBilgi bilet in businessErkekBiletler)
                {
                    foreach (Control item in grpBusiness1.Controls)
                    {
                        if (item is PictureBox)
                        {
                            ((PictureBox)item).ImageLocation = economyBosKoltuk;
                        }
                    }
                }
            }

            foreach (BiletBilgi bilet in businessKadinBiletler)
            {
                foreach (Control item in grpBusiness1.Controls)
                {
                    if (item is PictureBox && bilet.KoltukNo == item.Name)
                    {
                        ((PictureBox)item).ImageLocation = economyKadinKoltuk;
                    }
                }
                foreach (Control item in grpBusiness2.Controls)
                {
                    if (item is PictureBox && bilet.KoltukNo == item.Name)
                    {
                        ((PictureBox)item).ImageLocation = economyKadinKoltuk;
                    }
                }
            }
        }

        private void KoltuklariOlustur()
        {
            //Business pb ve lbl
            PictureBox pbB1;
            PictureBox pbB2;
            Label lblB1;
            Label lblB2;
            Label lblB1Masa;
            Label lblB2Masa;

            //Business Degiskenleri

            int businessSoldanBosluk = 60;
            int businessKoltukArasi = 20;
            int businessUsttenBosluk = 10;
            int businessKoltukSayisi = 8;

            lblB1Masa = new Label();
            lblB1Masa.AutoSize = false;
            lblB1Masa.TextAlign = ContentAlignment.MiddleCenter;
            lblB1Masa.Width = 269;
            lblB1Masa.Height = 20;
            lblB1Masa.Text = "MASA";
            lblB1Masa.BackColor = Color.LightGoldenrodYellow;
            grpBusiness1.Controls.Add(lblB1Masa);

            lblB2Masa = new Label();
            lblB2Masa.AutoSize = false;
            lblB2Masa.TextAlign = ContentAlignment.MiddleCenter;
            lblB2Masa.Width = 269;
            lblB2Masa.Height = 20;
            lblB2Masa.Text = "MASA";
            lblB2Masa.BackColor = Color.LightGoldenrodYellow;
            grpBusiness2.Controls.Add(lblB2Masa);

            for (int i = 0; i < 8; i++)
            {
                //grpBusiness1
                pbB1 = new PictureBox();
                lblB1 = new Label();
                pbB1.Name = "B" + i;
                lblB1.Text = pbB1.Name;
                KoltukAyarlari(pbB1, lblB1, null);


                grpBusiness1.Controls.Add(pbB1);
                grpBusiness1.Controls.Add(lblB1);

                //grpBusiness2
                pbB2 = new PictureBox();
                lblB2 = new Label();
                pbB2.Name = "B" + businessKoltukSayisi;
                lblB2.Text = pbB2.Name;
                businessKoltukSayisi++;
                KoltukAyarlari(pbB2, lblB2, null);


                grpBusiness2.Controls.Add(pbB2);
                grpBusiness2.Controls.Add(lblB2);

                if (i < 4)
                {
                    //grpBusiness1'de ust 4 koltuk
                    pbB1.Location = new Point((i * businessSoldanBosluk) + businessKoltukArasi, businessUsttenBosluk);
                    lblB1.Location = new Point(pbB1.Location.X, pbB1.Height + businessUsttenBosluk);


                    //grpBusiness2'de ust 4 koltuk
                    pbB2.Location = new Point((i * businessSoldanBosluk) + businessKoltukArasi, businessUsttenBosluk);
                    lblB2.Location = new Point(pbB2.Location.X, pbB2.Height + businessUsttenBosluk);
                }
                else
                {
                    //grpBusiness1'de alt 4 koltuk
                    pbB1.Location = new Point(((i - 4) * businessSoldanBosluk) + businessKoltukArasi, lblB1.Height + pbB1.Height + (businessUsttenBosluk * 4));
                    lblB1.Location = new Point(pbB1.Location.X, pbB1.Location.Y + (businessUsttenBosluk * 3));

                    //grpBusiness2'de alt 4 koltuk
                    pbB2.Location = new Point(((i - 4) * businessSoldanBosluk) + businessKoltukArasi, lblB2.Height + pbB2.Height + (businessUsttenBosluk * 4));
                    lblB2.Location = new Point(pbB2.Location.X, pbB2.Location.Y + (businessUsttenBosluk * 3));
                }
                lblB1Masa.Location = new Point(0, 60);
                lblB2Masa.Location = new Point(0, 60);
            }
            //Economy pb ve lbl
            PictureBox pbE1;
            PictureBox pbE2;
            Label lblE1;
            Label lblE2;
            PictureBox luggage;
            PictureBox luggage2;

            //Economy Degiskenleri

            int economySoldanBosluk = 60;
            int economyKoltukArasi = 20;
            int economyUsttenBosluk = 10;
            int economyLabelBosluk = 15;
            int economyKoltukSayisi = 12;

            for (int i = 0; i < 12; i++)
            {
                //grpEconomy1
                pbE1 = new PictureBox();
                lblE1 = new Label();
                luggage = new PictureBox();
                pbE1.Name = "E" + i;
                lblE1.Text = pbE1.Name;
                KoltukAyarlari(pbE1, lblE1, luggage);
                grpEconomy1.Controls.Add(pbE1);
                grpEconomy1.Controls.Add(lblE1);

                //grpEconomy2
                pbE2 = new PictureBox();
                lblE2 = new Label();
                luggage2 = new PictureBox();

                pbE2.Name = "E" + economyKoltukSayisi;
                lblE2.Text = pbE2.Name;
                economyKoltukSayisi++;
                KoltukAyarlari(pbE2, lblE2, luggage2);
                grpEconomy2.Controls.Add(pbE2);
                grpEconomy2.Controls.Add(lblE2);

                if (i < 3)
                {
                    //grpEconomy1'de ust 4 koltuk
                    grpEconomy1.Controls.Add(luggage);

                    pbE1.Location = new Point((2 * i * economySoldanBosluk - 5) + economyKoltukArasi, economyUsttenBosluk);
                    lblE1.Location = new Point(pbE1.Location.X, pbE1.Height + economyUsttenBosluk - 3);
                    luggage.Location = new Point(pbE1.Location.X + economySoldanBosluk - 2, economyUsttenBosluk + 5);

                    //grpEconomy2'de ust 4 koltuk
                    grpEconomy2.Controls.Add(luggage2);
                    pbE2.Location = new Point((2 * i * economySoldanBosluk - 5) + economyKoltukArasi, economyUsttenBosluk);
                    lblE2.Location = new Point(pbE2.Location.X, pbE2.Height + economyUsttenBosluk - 3);
                    luggage2.Location = new Point(pbE2.Location.X + economySoldanBosluk - 2, economyUsttenBosluk + 5);

                }
                else if (i >= 3 && i < 9)
                {
                    //grpEconomy1'de orta 4 koltuk
                    pbE1.Location = new Point(((i - 3) * economySoldanBosluk - 5) + businessKoltukArasi, lblE1.Height + pbE1.Height + economyUsttenBosluk - 5);
                    lblE1.Location = new Point(pbE1.Location.X, pbE1.Location.Y + economyUsttenBosluk + economyLabelBosluk + 3);

                    //grpEconomy2'de orta 4 koltuk
                    pbE2.Location = new Point(((i - 3) * economySoldanBosluk - 5) + businessKoltukArasi, lblE2.Height + pbE2.Height + economyUsttenBosluk - 5);
                    lblE2.Location = new Point(pbE2.Location.X, pbE2.Location.Y + economyUsttenBosluk + economyLabelBosluk + 3);
                }
                else
                {
                    //grpEconomy1'de alt 4 koltuk
                    grpEconomy1.Controls.Remove(pbE1);
                    grpEconomy1.Controls.Remove(lblE1);
                    grpEconomy1.Controls.Add(luggage);
                    grpEconomy1.Controls.Add(pbE1);
                    grpEconomy1.Controls.Add(lblE1);

                    luggage.Location = new Point((2 * (i - 9) * economySoldanBosluk - 5) + businessKoltukArasi, lblE1.Height + pbE1.Height + economyUsttenBosluk + (economyUsttenBosluk * 3) + economyUsttenBosluk + 5);
                    pbE1.Location = new Point(luggage.Location.X + economySoldanBosluk, lblE1.Height + pbE1.Height + economyUsttenBosluk + (economyUsttenBosluk * 3) + economyUsttenBosluk - 2);
                    lblE1.Location = new Point(pbE1.Location.X, pbE1.Location.Y + economyUsttenBosluk + 20);


                    //grpEconomy2'de alt 4 koltuk
                    grpEconomy2.Controls.Remove(pbE2);
                    grpEconomy2.Controls.Remove(lblE2);
                    grpEconomy2.Controls.Add(luggage2);
                    grpEconomy2.Controls.Add(pbE2);
                    grpEconomy2.Controls.Add(lblE2);
                    luggage2.Location = new Point((2 * (i - 9) * economySoldanBosluk - 5) + businessKoltukArasi, lblE2.Height + pbE2.Height + economyUsttenBosluk + (economyUsttenBosluk * 3) + economyUsttenBosluk + 5);
                    pbE2.Location = new Point(luggage2.Location.X + economySoldanBosluk, lblE2.Height + pbE2.Height + economyUsttenBosluk + (economyUsttenBosluk * 3) + economyUsttenBosluk + 5);
                    lblE2.Location = new Point(pbE2.Location.X, pbE2.Location.Y + economyUsttenBosluk + 20);

                }
            }
        }

        private void KoltukAyarlari(PictureBox pb, Label lbl, PictureBox luggage)
        {
            pb.Width = 40;
            pb.Height = 30;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Width = pb.Width;
            lbl.Height = 15;
            pb.ImageLocation = economyBosKoltuk;
            pb.Click += EconomyClick;
            if (luggage != null)
            {
                luggage.Width = 40;
                luggage.Height = 30;
                luggage.ImageLocation = economyLuggage;
            }
        }
        PictureBox eskiTiklanan;
        PictureBox tiklanan;
        private void EconomyClick(object sender, EventArgs e)
        {
            tiklanan = sender as PictureBox;
            GroupBox grp = (GroupBox)tiklanan.Parent;
            if (!rdbErkek.Checked == !rdbKadin.Checked)
            {
                MessageBox.Show("Lütfen 'Yolcu Bilgileri' kutucuğundan bir cinsiyet seçiniz");
                return;
            }
            if (tiklanan.Name.StartsWith("E") && tiklanan.ImageLocation != null && tiklanan.ImageLocation == economyErkekKoltuk | tiklanan.ImageLocation == economyKadinKoltuk)
            {
                MessageBox.Show("Lütfen boş bir koltuk seçiniz");
            }
            else
            {
                foreach (Control item in grp.Controls)
                {
                    if (item is PictureBox)
                    {
                        if ((item.Location.X == tiklanan.Location.X && item.Name.StartsWith("E") && item.Name != tiklanan.Name && tiklanan.ImageLocation.Contains("available")) && ((((PictureBox)item).ImageLocation.Contains("woman") && !rdbKadin.Checked) || (((PictureBox)item).ImageLocation.Contains("_man") && !rdbErkek.Checked)))
                        {
                            MessageBox.Show("Seçilen koltuk karşı cinsin yanında olamaz. Lütfen doğru şekilde koltuk seçiniz.");
                            return;
                        }
                        else if (item.Location.X == tiklanan.Location.X && item.Name != "" && tiklanan.ImageLocation.Contains("available") && item.Name != tiklanan.Name)
                        {
                            if (eskiTiklanan != null)
                            {
                                eskiTiklanan.ImageLocation = economyBosKoltuk;
                            }
                            tiklanan.ImageLocation = secilenKoltuk;
                            eskiTiklanan = tiklanan;
                            return;
                        }
                    }
                }
            }
        }

        private void Pb_Click(object sender, EventArgs e)
        {
            PictureBox tiklanan = sender as PictureBox;
            MessageBox.Show(tiklanan.Name);
        }

        private void rdbKadin_CheckedChanged(object sender, EventArgs e)
        {
            if (tiklanan != null && tiklanan.ImageLocation == secilenKoltuk)
                tiklanan.ImageLocation = economyBosKoltuk;
        }

        private void rdbErkek_CheckedChanged(object sender, EventArgs e)
        {
            if (tiklanan != null && tiklanan.ImageLocation == secilenKoltuk)
                tiklanan.ImageLocation = economyBosKoltuk;
        }

        ListViewItem lvi;
        List<ListViewItem> liste = new List<ListViewItem>();
        bool gidisEklendiMi = false;
        public void YolcuEkle()
        {
            int ucret = 0;
            if (cmbBiletTipi.Text == "Economy")
                ucret = 70;
            else
                ucret = 100;
            if (grpEkHizmetler.Controls.Count > 0)
            {
                foreach (Control item in grpEkHizmetler.Controls)
                {
                    if (((CheckBox)item).Checked)
                    {
                        if (item.Text.Contains("Bagaj"))
                            ucret += 30;
                        else if (item.Text.Contains("Yiyecek"))
                            ucret += 10;
                        else if (item.Text.Contains("İçecek"))
                            ucret += 5;
                    }
                }
            }

            sonTiklananKoltukAdi = tiklanan.Name;
            tiklanan.Click += CokluSecim;

            BiletBilgi biletDetay = new BiletBilgi();
            BiletConcrete bc = new BiletConcrete();
            BiletBilgiDal bbd = new BiletBilgiDal();
            Bilet bilet = new Bilet();
            Musteri yolcu = new Musteri();
            MusteriDetay musteriDetay = new MusteriDetay();
            MusteriConcrete mc = new MusteriConcrete();
            MusteriDetayConcrete mdc = new MusteriDetayConcrete();
            SeferlerSeferSaatleriDal sssd = new SeferlerSeferSaatleriDal();
            SeferlerDal sd = new SeferlerDal();
            int sssdId = sssd.GetBySeferIdAndSaatId(seferId, saatID);

            yolcu.Ad = txtAd.Text;
            yolcu.Soyad = txtSoyad.Text;
            yolcu.DogumTarihi = dtpDogumTarihi.Value.Date;
            yolcu.Cinsiyet = rdbErkek.Checked;
            mc._musteriRepository.Insert(yolcu);

            int musteriId = mc.GetIdByEntity(yolcu);
            musteriDetay.Email = txtEmail.Text;
            musteriDetay.Telefon = txtTelefon.Text;
            musteriDetay.MusteriDetayID = musteriId;
            mdc._musteriDetayRepository.Insert(musteriDetay);


            biletDetay.BiletTipi = cmbBiletTipi.Text;
            biletDetay.KoltukNo = tiklanan.Name;
            biletDetay.AlimTarihi = DateTime.Now;

            biletDetay.BiletFiyati = ucret;
            if (!gidisEklendiMi || donusTarihi != null || kayitSayaci == yolcuSayisi)
            {
                biletDetay.SeferTarihi = gidisTarihi.Date;
                biletDetay.SeferSeferSaatID = sssdId;
            }
            else
            {
                biletDetay.SeferTarihi = donusTarihi.Date;
                biletDetay.SeferSeferSaatID = donusSssd;
            }
            biletDetay.SeferSaati = saat;
            biletDetay.MusteriID = musteriId;
            biletDetay.BiletTipi = biletTipi;

            bilet.PNRNo = Tools.PNRNoYap(biletDetay);
            bc._biletRepository.Insert(bilet);
            int biletId = bc.GetIdByEntity(bilet);
            biletDetay.BiletBilgiID = biletId;

            bbd._biletBilgiRepository.Insert(biletDetay);
            gidisEklendiMi = true;
            if (rezerveMi)
            {
                RezerveBilet rezerve = new RezerveBilet()
                {
                    BiletID = bilet.BiletID,
                    MusteriID = musteriId,
                    RezerveTarihi = DateTime.Now,
                    IsBought = false,
                    IsDeleted = false
                };
                RezerveConcrete rc = new RezerveConcrete();
                string seferYonu = sd.GetYonById(seferId);
                rc._rezerveRepository.Insert(rezerve);


                if (yolcuSayisi > 1)
                {
                    lvi = new ListViewItem();
                    lvi.Text = yolcu.Ad;
                    lvi.SubItems.Add(yolcu.Soyad);
                    lvi.SubItems.Add(biletDetay.BiletTipi);
                    lvi.SubItems.Add(seferYonu);
                    lvi.SubItems.Add(biletDetay.SeferSaati);
                    lvi.SubItems.Add(biletDetay.KoltukNo);
                    lvi.SubItems.Add(biletDetay.BiletFiyati.ToString());
                    lvi.SubItems.Add(bilet.PNRNo.ToString());
                    liste.Add(lvi);
                }


                else if (donusVarMi)
                {
                    lvi = new ListViewItem();
                    lvi.Text = yolcu.Ad;
                    lvi.SubItems.Add(yolcu.Soyad);
                    lvi.SubItems.Add(biletDetay.BiletTipi);

                    if (!gidisEklendiMi && donusTarihi != null)
                    {
                        lvi.SubItems.Add(seferYonu);
                    }
                    else
                    {
                        seferYonu = sd.GetYonById(donusId);
                        lvi.SubItems.Add(seferYonu);
                    }

                    lvi.SubItems.Add(biletDetay.SeferSaati);
                    lvi.SubItems.Add(biletDetay.KoltukNo);
                    lvi.SubItems.Add(biletDetay.BiletFiyati.ToString());
                    lvi.SubItems.Add(bilet.PNRNo.ToString());

                    liste.Add(lvi);
                }


                else
                {
                    lvi = new ListViewItem();
                    lvi.Text = yolcu.Ad;
                    lvi.SubItems.Add(yolcu.Soyad);
                    lvi.SubItems.Add(biletDetay.BiletTipi);
                    lvi.SubItems.Add(seferYonu);
                    lvi.SubItems.Add(biletDetay.SeferSaati);
                    lvi.SubItems.Add(biletDetay.KoltukNo);
                    lvi.SubItems.Add(biletDetay.BiletFiyati.ToString());
                    lvi.SubItems.Add(bilet.PNRNo.ToString());
                }
            }
            else
            {
                SatilanBilet satilan = new SatilanBilet();
                satilan.BiletID = biletId;
                satilan.MusteriID = musteriId;
                satilan.SatisTarihi = DateTime.Now;
                SatilanConcrete sc = new SatilanConcrete();
                sc._satilanBiletRepository.Insert(satilan);

                string seferYonu = sd.GetYonById(seferId);

                if (yolcuSayisi > 1)
                {
                    lvi = new ListViewItem();
                    lvi.Text = yolcu.Ad;
                    lvi.SubItems.Add(yolcu.Soyad);
                    lvi.SubItems.Add(biletDetay.BiletTipi);

                    if (!gidisEklendiMi && donusTarihi != null)
                    {
                        lvi.SubItems.Add(seferYonu);
                    }
                    else
                    {
                        seferYonu = sd.GetYonById(donusId);
                        lvi.SubItems.Add(seferYonu);
                    }

                    lvi.SubItems.Add(biletDetay.SeferSaati);
                    lvi.SubItems.Add(biletDetay.KoltukNo);
                    lvi.SubItems.Add(biletDetay.BiletFiyati.ToString());
                    lvi.SubItems.Add(bilet.PNRNo.ToString());
                    liste.Add(lvi);
                    sonTiklananKoltukAdi = biletDetay.KoltukNo;
                }

                else if (donusVarMi)
                {
                    lvi = new ListViewItem();
                    lvi.Text = yolcu.Ad;
                    lvi.SubItems.Add(yolcu.Soyad);
                    lvi.SubItems.Add(biletDetay.BiletTipi);
                    lvi.SubItems.Add(seferYonu);
                    lvi.SubItems.Add(biletDetay.SeferSaati);
                    lvi.SubItems.Add(biletDetay.KoltukNo);
                    lvi.SubItems.Add(biletDetay.BiletFiyati.ToString());
                    lvi.SubItems.Add(bilet.PNRNo.ToString());
                    liste.Add(lvi);
                }

                else
                {
                    lvi = new ListViewItem();
                    lvi.Text = yolcu.Ad;
                    lvi.SubItems.Add(yolcu.Soyad);
                    lvi.SubItems.Add(biletDetay.BiletTipi);
                    lvi.SubItems.Add(seferYonu);
                    //lvi.SubItems.Add(biletDetay.SeferSaati);
                    lvi.SubItems.Add(biletDetay.KoltukNo);
                    lvi.SubItems.Add(biletDetay.BiletFiyati.ToString());
                    lvi.SubItems.Add(bilet.PNRNo.ToString());
                }
            }
        }
        string sonTiklananKoltukAdi = "";
        int gidisDonusSayac = 0;
        private void btnOdemeyeGec_Click(object sender, EventArgs e)
        {
            if (tiklanan == null)
            {
                MessageBox.Show("Önce koltuk seçiniz!");
                return;
            }

            if (kayitSayaci >= 0 && kayitSayaci <= yolcuSayisi)
            {
                kayitSayaci++;
            }

            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Kayıt işlemi yapmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                YolcuEkle();
                Tools.Temizle(grpYolcuBilgileri);
                Tools.Temizle(grpEkHizmetler);
                if (gidisDonusSayac == 2)
                {
                    KoltuklariKaldir();
                    DonusKoltuklariDoldur();
                }
                else
                {
                    KoltuklariDoldur();
                }
                sonTiklananKoltukAdi = tiklanan.Name;
            }
            else
            {
                Tools.Temizle(grpYolcuBilgileri);
                Tools.Temizle(grpEkHizmetler);
                tiklanan.ImageLocation = economyBosKoltuk;
                return;
            }
            if (rezerveMi)
            {
                dr = MessageBox.Show("Rezerve işlemi yapılmıştır", "Bilgi", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                {
                    if (donusVarMi)
                    {
                        if (gidisDonusSayac >= 0 && gidisDonusSayac < 2)
                        {
                            gidisDonusSayac++;
                        }

                        tiklanan.ImageLocation = economyBosKoltuk;
                        KoltuklariKaldir();
                        KoltuklariOlustur();
                        DonusKoltuklariDoldur();
                        lblGidisDonus.Text = "Donus seferi icin koltuk seciniz.";
                        foreach (Control item in grpYolcuBilgileri.Controls)
                        {
                            if (item.Name == "cmbBiletTipi" || item.Name.StartsWith("rdb") || item.Name == "btnOdemeyeGec")
                            {
                                item.Enabled = true;
                            }
                            else
                            {
                                item.Enabled = false;

                            }
                        }
                        if (gidisDonusSayac == 2 && yolcuSayisi == 1)
                        {
                            frmIslemOzeti islemOzeti = new frmIslemOzeti(lvi, liste);
                            frmAnaSayfa anaForm = (frmAnaSayfa)this.Parent.Parent.Parent;
                            anaForm.FormKontrolluGetir(islemOzeti);
                        }
                        eskiTiklanan = null;
                        return;

                    }
                    if (kayitSayaci == yolcuSayisi)
                    {
                        frmIslemOzeti islemOzeti = new frmIslemOzeti(lvi, liste);
                        frmAnaSayfa anaForm = (frmAnaSayfa)this.Parent.Parent.Parent;
                        anaForm.FormKontrolluGetir(islemOzeti);
                    }

                    else
                    {
                        Tools.Temizle(grpYolcuBilgileri);
                        Tools.Temizle(grpEkHizmetler);
                        tiklanan.ImageLocation = economyBosKoltuk;
                        KoltuklariDoldur();
                        lblYolcuSayisiBilgilendirme.Text = "Seçtiğiniz " + yolcuSayisi + " kadar biletten " + kayitSayaci + " kadar eklenmiştir.";
                        eskiTiklanan = null;
                        return;
                    }
                }
            }
            else
            {
                dr = MessageBox.Show("Kayit işlemi yapılmıştır", "Bilgi", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                {
                    if (donusVarMi)
                    {
                        if (gidisDonusSayac >= 0 && gidisDonusSayac < 2)
                        {
                            gidisDonusSayac++;
                        }

                        Tools.Temizle(grpYolcuBilgileri);
                        Tools.Temizle(grpEkHizmetler);
                        tiklanan.ImageLocation = economyBosKoltuk;
                        KoltuklariKaldir();
                        KoltuklariOlustur();
                        DonusKoltuklariDoldur();
                        lblGidisDonus.Text = "Donus seferi icin koltuk seciniz.";
                        foreach (Control item in grpYolcuBilgileri.Controls)
                        {
                            if (item.Name == "cmbBiletTipi" || item.Name.StartsWith("rdb") || item.Name == "btnOdemeyeGec")
                            {
                                item.Enabled = true;
                            }
                            else
                            {
                                item.Enabled = false;
                            }
                        }
                        if (gidisDonusSayac == 2 && yolcuSayisi == 1)
                        {
                            frmIslemOzeti islemOzeti = new frmIslemOzeti(lvi, liste);
                            frmAnaSayfa anaForm = (frmAnaSayfa)this.Parent.Parent.Parent;
                            anaForm.FormKontrolluGetir(islemOzeti);
                        }
                        eskiTiklanan = null;
                        return;

                    }

                    if (kayitSayaci == yolcuSayisi)
                    {
                        frmIslemOzeti islemOzeti = new frmIslemOzeti(lvi, liste);
                        frmAnaSayfa anaForm = (frmAnaSayfa)this.Parent.Parent.Parent;
                        anaForm.FormKontrolluGetir(islemOzeti);
                    }

                    else
                    {
                        Tools.Temizle(grpYolcuBilgileri);
                        Tools.Temizle(grpEkHizmetler);
                        tiklanan.ImageLocation = economyBosKoltuk;
                        KoltuklariDoldur();
                        lblYolcuSayisiBilgilendirme.Text = "Seçtiğiniz " + yolcuSayisi + " kadar biletten " + kayitSayaci + " kadar eklenmiştir.";
                        eskiTiklanan = null;
                        return;
                    }
                }

            }
        }

        private void KoltuklariKaldir()
        {
            grpBusiness1.Controls.Clear();
            grpBusiness2.Controls.Clear();
            grpEconomy1.Controls.Clear();
            grpEconomy2.Controls.Clear();
        }

        private void DonusKoltuklariDoldur()
        {
            businessKadinBiletler = biletBilgiConcrete.BusinessWomanTickets(donusId, donusSaatId, donusTarihi);
            businessErkekBiletler = biletBilgiConcrete.BusinessManTickets(donusId, donusSaatId, donusTarihi);

            economyKadinBiletler = biletBilgiConcrete.EconomyWomanTickets(donusId, donusSaatId, donusTarihi);
            economyErkekBiletler = biletBilgiConcrete.EconomyManTickets(donusId, donusSaatId, donusTarihi);

            BusinessKadinlar(grpBusiness1, grpBusiness2);
            BusinessErkekler(grpBusiness1, grpBusiness2);

            EconomyKadinlar(grpEconomy1, grpEconomy2);
            EconomyErkekler(grpEconomy1, grpEconomy2);
        }

        private void cmbBiletTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            BiletSecimKontrolu();
            if (tiklanan != null && tiklanan.ImageLocation == secilenKoltuk)
                tiklanan.ImageLocation = economyBosKoltuk;
        }

        private void BiletSecimKontrolu()
        {
            if (cmbBiletTipi.Text == "Economy")
            {
                grpBusiness1.Enabled = false;
                grpBusiness2.Enabled = false;
                grpEconomy1.Enabled = true;
                grpEconomy2.Enabled = true;
            }
            else
            {
                grpEconomy1.Enabled = false;
                grpEconomy2.Enabled = false;
                grpBusiness1.Enabled = true;
                grpBusiness2.Enabled = true;

            }
        }
    }
}