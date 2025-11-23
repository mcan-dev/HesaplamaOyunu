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
    public partial class AnaMenuForm : Form
    {
        int hileliBaslangicSeviyesi = 1; 
       
        public AnaMenuForm(int baslangicSeviyesi)
        {
            InitializeComponent();
            this.hileliBaslangicSeviyesi = baslangicSeviyesi;
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("kayit.txt"))
            {
                System.IO.File.Delete("kayit.txt");
            }
            btnDevamEt.Enabled = false;

            // Oyunu, hileli seviye bilgisiyle başlat. Hile yoksa bu değeri 1'dir.
            OyunForm oyunEkrani = new OyunForm(hileliBaslangicSeviyesi);
            oyunEkrani.anaMenuForm = this;
            oyunEkrani.Show();
            this.Hide();
        }

        private void btnSkorlar_Click(object sender, EventArgs e)
        {
            SkorForm skorEkrani = new SkorForm();
            skorEkrani.GeriDonulecekMenu = this; 
            skorEkrani.Show();
            this.Hide();
        }

        private void AnaMenuForm_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("kayit.txt"))
            {
                btnDevamEt.Enabled = true;
            }
            else
            {
                btnDevamEt.Enabled = false;
            }
        }

        private void btnDevamEt_Click_1(object sender, EventArgs e)
        {
            string[] kayitBilgileri = System.IO.File.ReadAllLines("kayit.txt");

            int seviye = Convert.ToInt32(kayitBilgileri[0]);
            int blok = Convert.ToInt32(kayitBilgileri[1]);
            int puan = Convert.ToInt32(kayitBilgileri[2]);
            int dogru = Convert.ToInt32(kayitBilgileri[3]);
            int yanlis = Convert.ToInt32(kayitBilgileri[4]);
            int sure = Convert.ToInt32(kayitBilgileri[5]);

            OyunForm oyunEkrani = new OyunForm(seviye, blok, puan, dogru, yanlis, sure);
            oyunEkrani.anaMenuForm = this;
            oyunEkrani.Show();
            this.Hide();
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}