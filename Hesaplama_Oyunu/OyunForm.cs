using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatematikOyunu
{
    public partial class OyunForm : Form
    {
        Label[] soruEtiketleri;
        TextBox[] cevapKutulari;
        CheckBox[] pasKutulari;
        int[] dogruCevaplar = new int[5];

        int mevcutSeviye = 1;
        int dogruSayisi = 0;
        int yanlisSayisi = 0;
        int kalanSure;
        int mevcutBlok = 1;
        int toplamPuan = 0;

        List<Soru> pasGecilenSorular = new List<Soru>();
        bool degerlendirmeAsamasindaMi = false;

        public AnaMenuForm anaMenuForm;
        public OyunForm()
        {
            InitializeComponent();
        }
        public OyunForm(int baslangicSeviyesi)
        {
            InitializeComponent();
            mevcutSeviye = baslangicSeviyesi;
        }
        public OyunForm(int seviye, int blok, int puan, int dogru, int yanlis, int sure)
        {
            InitializeComponent(); 

            this.mevcutSeviye = seviye;
            this.mevcutBlok = blok;
            this.toplamPuan = puan;
            this.dogruSayisi = dogru;
            this.yanlisSayisi = yanlis;
            this.kalanSure = sure;
        }

        private void OyunForm_Load(object sender, EventArgs e)
        {
            soruEtiketleri = new Label[] { lblSoru1, lblSoru2, lblSoru3, lblSoru4, lblSoru5 };
            cevapKutulari = new TextBox[] { txtCevap1, txtCevap2, txtCevap3, txtCevap4, txtCevap5 };
            pasKutulari = new CheckBox[] { chkPas1, chkPas2, chkPas3, chkPas4, chkPas5 };

            // Eğer oyun 1. bloktan BAŞLAMIYORSA (yani "Devam Et" ile yüklendiyse)
            // ekranı mevcut bilgilerle doldur ve süreyi başlat.
            if (mevcutBlok != 1)
            {
                lblPuan.Text = "Puan: " + toplamPuan;
                lblDurum.Text = "Doğru: " + dogruSayisi + " - Yanlış: " + yanlisSayisi;
            }
            YeniBlokHazirla();
        }

        private void YeniBlokHazirla()
        {
            for (int i = 0; i < 5; i++)
            {
                cevapKutulari[i].Text = "";
                cevapKutulari[i].BackColor = Color.White;
                cevapKutulari[i].Enabled = true;
                pasKutulari[i].Checked = false;
                pasKutulari[i].Enabled = true;
                soruEtiketleri[i].Visible = true;
                cevapKutulari[i].Visible = true;
                pasKutulari[i].Visible = true;
            }

            Random rastgele = new Random();
            for (int i = 0; i < 5; i++)
            {
                int minSayi, maxSayi;
                switch (mevcutSeviye)
                {
                    case 1: minSayi = 1; maxSayi = 10; break;
                    case 2: minSayi = 2; maxSayi = 21; break;
                    case 3: minSayi = 10; maxSayi = 51; break;
                    case 4: minSayi = 25; maxSayi = 101; break;
                    case 5: minSayi = 50; maxSayi = 151; break;
                    default: minSayi = 100; maxSayi = 251; break;
                }
                int sayi1 = rastgele.Next(minSayi, maxSayi);
                int sayi2 = rastgele.Next(minSayi, maxSayi);
                int islemTuru = rastgele.Next(1, 5);
                string soruMetni = "";

                switch (islemTuru)
                {
                    case 1:
                        dogruCevaplar[i] = sayi1 + sayi2;
                        soruMetni = sayi1 + " + " + sayi2 + " = ?";
                        break;
                    case 2:
                        if (sayi1 < sayi2) { int gecici = sayi1; sayi1 = sayi2; sayi2 = gecici; }
                        dogruCevaplar[i] = sayi1 - sayi2;
                        soruMetni = sayi1 + " - " + sayi2 + " = ?";
                        break;
                    case 3:
                        sayi1 = rastgele.Next(minSayi, (maxSayi / 4) + 2);
                        sayi2 = rastgele.Next(minSayi, (maxSayi / 4) + 2);
                        if (sayi1 == 0) sayi1 = 1; if (sayi2 == 0) sayi2 = 1;
                        dogruCevaplar[i] = sayi1 * sayi2;
                        soruMetni = sayi1 + " x " + sayi2 + " = ?";
                        break;
                    case 4:
                        int bolen = rastgele.Next(minSayi, maxSayi);
                        if (bolen == 0) bolen = 1;
                        int sonuc = rastgele.Next(1, 11);
                        int bolunen = bolen * sonuc;
                        dogruCevaplar[i] = sonuc;
                        soruMetni = bolunen + " / " + bolen + " = ?";
                        break;
                }
                soruEtiketleri[i].Text = (i + 1) + ") " + soruMetni;
            }
            kalanSure = 60 + ((mevcutSeviye - 1) * 10);
            lblKalanSure.Text = "Süre: " + kalanSure;
            degerlendirmeAsamasindaMi = false;
            btnCevaplariKontrolEt.Text = "Cevapları Kontrol Et";
            Text = "Matematik Oyunu - Seviye " + mevcutSeviye + " - Blok " + mevcutBlok + "/4";
            timer1.Start();
            btnKaydetVeCik.Enabled = true;
        }

        private void btnCevaplariKontrolEt_Click(object sender, EventArgs e)
        {
            if (degerlendirmeAsamasindaMi == false)
            {
                timer1.Stop();
                degerlendirmeAsamasindaMi = true;
                for (int i = 0; i < 5; i++)
                {
                    cevapKutulari[i].Enabled = false;
                    pasKutulari[i].Enabled = false;
                    if (soruEtiketleri[i].Visible)
                    {
                        if (pasKutulari[i].Checked)
                        {
                            if (mevcutBlok > 4)
                            {
                                yanlisSayisi++;
                                cevapKutulari[i].BackColor = Color.LightCoral;
                                soruEtiketleri[i].Text += " (Doğrusu: " + dogruCevaplar[i] + ")";
                            }
                            else
                            {
                                pasGecilenSorular.Add(new Soru { SoruMetni = soruEtiketleri[i].Text, DogruCevap = dogruCevaplar[i] });
                                cevapKutulari[i].BackColor = Color.LightGray;
                            }
                        }
                        else if (string.IsNullOrWhiteSpace(cevapKutulari[i].Text))
                        {
                            pasGecilenSorular.Add(new Soru { SoruMetni = soruEtiketleri[i].Text, DogruCevap = dogruCevaplar[i] });
                            cevapKutulari[i].BackColor = Color.LightGray;
                        }
                        else
                        {
                            int kullaniciCevabi;
                            if (int.TryParse(cevapKutulari[i].Text, out kullaniciCevabi) && kullaniciCevabi == dogruCevaplar[i])
                            {
                                dogruSayisi++;
                                toplamPuan += 10 * mevcutSeviye; 
                                lblPuan.Text = "Puan: " + toplamPuan; 
                                cevapKutulari[i].BackColor = Color.LightGreen;
                            }
                            else
                            {
                                yanlisSayisi++;
                                cevapKutulari[i].BackColor = Color.LightCoral;
                                soruEtiketleri[i].Text += " (Doğrusu: " + dogruCevaplar[i] + ")";
                            }
                        }
                    }
                }
                lblDurum.Text = "Doğru: " + dogruSayisi + " - Yanlış: " + yanlisSayisi;
                if (yanlisSayisi >= 10)
                {
                    MessageBox.Show("10 soruya yanlış cevap verdiğiniz için seviyeyi geçemediniz.", "Oyun Bitti");
                    NihaiSonucuHesapla(); 
                    return; 
                }
                if (mevcutBlok < 4)
                    btnCevaplariKontrolEt.Text = "Sonraki Blok";
                else if (pasGecilenSorular.Count > 0)
                    btnCevaplariKontrolEt.Text = "Pas Sorularına Geç";
                else
                    btnCevaplariKontrolEt.Text = "Seviyeyi Bitir";
            }
            else
            {
                mevcutBlok++;
                if (mevcutBlok > 4)
                {
                    if (pasGecilenSorular.Count > 0)
                    {
                        PasSorulariniHazirla();
                    }
                    else
                    {
                        NihaiSonucuHesapla();
                    }
                }
                else
                {
                    YeniBlokHazirla();
                }
            }
        }
        private void PasSorulariniHazirla()
        {
            for (int i = 0; i < 5; i++)
            {
                soruEtiketleri[i].Visible = false;
                cevapKutulari[i].Visible = false;
                pasKutulari[i].Visible = false;
                cevapKutulari[i].Text = "";
                cevapKutulari[i].BackColor = Color.White;
                pasKutulari[i].Checked = false;
            }
            for (int i = 0; i < pasGecilenSorular.Count && i < 5; i++)
            {
                soruEtiketleri[i].Visible = true;
                cevapKutulari[i].Visible = true;
                pasKutulari[i].Visible = true;
                soruEtiketleri[i].Text = pasGecilenSorular[i].SoruMetni;
                dogruCevaplar[i] = pasGecilenSorular[i].DogruCevap;
                cevapKutulari[i].Enabled = true;
                pasKutulari[i].Enabled = true;
            }
            pasGecilenSorular.Clear();
            degerlendirmeAsamasindaMi = false;
            btnCevaplariKontrolEt.Text = "Cevapları Kontrol Et";
            Text = "Matematik Oyunu - Pas Soruları";
            kalanSure = 30; 
            timer1.Start();
        }

        private void NihaiSonucuHesapla()
        {
            timer1.Stop();
            if (dogruSayisi >= 11)
            {
                string yildizlar = "";
                if (dogruSayisi >= 19) yildizlar = "★★★";
                else if (dogruSayisi >= 16) yildizlar = "★★☆";
                else yildizlar = "★☆☆";
                MessageBox.Show("Tebrikler, Seviye " + mevcutSeviye + " tamamlandı!\nKazandığın yıldız: " + yildizlar);
                mevcutSeviye++;
                System.IO.File.WriteAllText("kayit.txt", mevcutSeviye.ToString());
                mevcutBlok = 1;
                dogruSayisi = 0;
                yanlisSayisi = 0;
                YeniBlokHazirla();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Seviyeyi geçemedin. Oyun bitti!");
                btnCevaplariKontrolEt.Enabled = false;

                try
                {
                    string oyuncuAdi = Microsoft.VisualBasic.Interaction.InputBox("Skor listesi için adınızı girin:", "Oyun Bitti - Skor Kaydet", "Oyuncu1");
                    if (!string.IsNullOrWhiteSpace(oyuncuAdi))
                    {
                        int puan = toplamPuan;
                        string skorSatiri = oyuncuAdi + " | doğru: " + dogruSayisi + ", yanlış: " + yanlisSayisi + ", puan: " + toplamPuan;
                   

                        System.IO.File.AppendAllText("skorlar.txt", skorSatiri + Environment.NewLine);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Skor kaydedilirken bir hata oluştu: " + ex.Message);
                }

                if (anaMenuForm != null)
                {
                    anaMenuForm.Show();
                }
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kalanSure--;
            lblKalanSure.Text = "Süre: " + kalanSure;
            if (kalanSure <= 0)
            {
                timer1.Stop();
                MessageBox.Show("Süre bitti! Seviyeyi geçemedin.");

                // Oyun bittiği için, seviye sonu ve skor kaydetme mantığını çağır.
                NihaiSonucuHesapla();

                Application.Restart(); 
            }
        }

        private void OyunForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void chkPas1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPas1.Checked)
            {

                txtCevap1.Enabled = false;
                txtCevap1.Text = "";
                txtCevap1.BackColor = Color.LightGray;
            }
            else
            {

                txtCevap1.Enabled = true;
                txtCevap1.BackColor = Color.White;
            }
        }

        private void chkPas2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPas2.Checked)
            {
                txtCevap2.Enabled = false;
                txtCevap2.Text = "";
                txtCevap2.BackColor = Color.LightGray;
            }
            else
            {
                txtCevap2.Enabled = true;
                txtCevap2.BackColor = Color.White;
            }
        }

        private void chkPas3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPas3.Checked)
            {
                txtCevap3.Enabled = false;
                txtCevap3.Text = "";
                txtCevap3.BackColor = Color.LightGray;
            }
            else
            {
                txtCevap3.Enabled = true;
                txtCevap3.BackColor = Color.White;
            }
        }

        private void chkPas4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPas4.Checked)
            {
                txtCevap4.Enabled = false;
                txtCevap4.Text = "";
                txtCevap4.BackColor = Color.LightGray;
            }
            else
            {
                txtCevap4.Enabled = true;
                txtCevap4.BackColor = Color.White;
            }
        }

        private void chkPas5_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPas5.Checked)
            {
                txtCevap5.Enabled = false;
                txtCevap5.Text = "";
                txtCevap5.BackColor = Color.LightGray;
            }
            else
            {
                txtCevap5.Enabled = true;
                txtCevap5.BackColor = Color.White;
            }
        }
        

        private void OyunForm_VisibleChanged(object sender, EventArgs e)
        {
            // Bu form her görünür olduğunda, kayıt dosyasının varlığını tekrar kontrol et.
            if (System.IO.File.Exists("kayit.txt"))
            {
                btnKaydetVeCik.Enabled = true;
            }
            else
            {
                btnKaydetVeCik.Enabled = false;
            }
        }

        private void btnKaydetVeCik_Click(object sender, EventArgs e)
        {
            string[] kayitBilgileri =
{
     mevcutSeviye.ToString(), mevcutBlok.ToString(), toplamPuan.ToString(),
     dogruSayisi.ToString(), yanlisSayisi.ToString(), kalanSure.ToString()
 };
            System.IO.File.WriteAllLines("kayit.txt", kayitBilgileri);
            MessageBox.Show("Oyun kaydedildi!");
            if (anaMenuForm != null) { anaMenuForm.Show(); }
            this.Close();
        }
    }
}