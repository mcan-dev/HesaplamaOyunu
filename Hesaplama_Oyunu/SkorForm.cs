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
    public partial class SkorForm : Form
    {
        public AnaMenuForm GeriDonulecekMenu; 

        public SkorForm()
        {
            InitializeComponent();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            if (GeriDonulecekMenu != null)
            {
                GeriDonulecekMenu.Show();
            }
            this.Close(); 
        }

        private void SkorForm_Load(object sender, EventArgs e)
        {
            // Listeyi her açılışta temizle
            lstSkorlar.Items.Clear();

            if (System.IO.File.Exists("skorlar.txt"))
            {
                string[] skorlar = System.IO.File.ReadAllLines("skorlar.txt");
                lstSkorlar.Items.AddRange(skorlar);
            }
            else
            {
                lstSkorlar.Items.Add("Henüz kaydedilmiş bir skor yok.");
            }
        }

        private void SkorForm_Load_1(object sender, EventArgs e)
        {
            lstSkorlar.Items.Clear();

            if (System.IO.File.Exists("skorlar.txt"))
            {
                string[] skorlar = System.IO.File.ReadAllLines("skorlar.txt");
                lstSkorlar.Items.AddRange(skorlar);
            }
            else
            {
                lstSkorlar.Items.Add("Henüz kaydedilmiş bir skor yok.");
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("skorlar.txt"))
            {
                try
                {
                    System.IO.File.Delete("skorlar.txt");
                    MessageBox.Show("Skor tablosu başarıyla temizlendi!", "Bilgi");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dosya silinirken bir hata oluştu: " + ex.Message, "Hata");
                }
            }
            else
            {
                MessageBox.Show("Zaten temizlenecek bir skor kaydı bulunmuyor.", "Bilgi");
            }

            lstSkorlar.Items.Clear();
            lstSkorlar.Items.Add("Henüz kaydedilmiş bir skor yok.");
        }
    }
}
