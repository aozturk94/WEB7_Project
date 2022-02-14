using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_02_Sayi_Tahmin
{
    public partial class Form1 : Form
    {
        public int hedef;
        public int puan;
        public int hak;
      
        public Form1()
        {
            InitializeComponent();
        }
            
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            hedef = rnd.Next(1, 100);
            puan = 50;
            hak = 5;
            btnBaslat.Text = "Yeniden Başlat";
            AktifEt();
            lblTahminler.Text = "";
            lblPuan.Text = puan.ToString();
            lblHak.Text = hak.ToString();
            lblMesaj.Text = "OYUN BAŞLADI!";
            lblHile.Text = "Hile: " + hedef.ToString(); // Bu satır silinecek
            txtTahmin.Focus();
        }
        void AktifEt()
        {
            txtTahmin.Enabled = true;
            btnTahmin.Enabled = true;
            btnBaslat.Enabled = false;
        }
        void PasifEt()
        {
            txtTahmin.Enabled = false;
            btnTahmin.Enabled = false;
            btnBaslat.Enabled = true;
            btnBaslat.Focus();
        }
        void KontrolEt(int tahmin)
        {
            string sozcuk = "";
            if (tahmin > hedef)
            {
                sozcuk = "KÜÇÜK";
            }
            else if (tahmin < hedef)
            {
                sozcuk = "BÜYÜK";
            }
            if (tahmin != hedef)
            {
                //tahmin hedeften büyükse
                hak -= 1;
                puan -= 10;
                lblPuan.Text = puan.ToString();
                lblHak.Text = hak.ToString();
                if (hak == 0)
                {
                    lblMesaj.Text = "OYUN BİTTİ KAYBETTİNİZ";
                    PasifEt();
                }
                else
                {
                    lblMesaj.Text = "DAHA " + sozcuk + " SAYI GİRİNİZ";
                }
            }
            else
            {
                lblMesaj.Text = "Tebrikler Oyunu Kazandınız";
                PasifEt();
            }
        }
        void TahminClick()
        {
            while (txtTahmin.Text!="")
            {
            int tahmin = int.Parse(txtTahmin.Text);
            KontrolEt(tahmin);
            lblTahminler.Text += "  " + txtTahmin.Text;
            txtTahmin.Clear();
            txtTahmin.Focus();
            }          
         }
        private void btnTahmin_Click(object sender, EventArgs e)
        {
            TahminClick();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PasifEt();
        }

        private void txtTahmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.K)
            {
                TahminClick();
            }
        }
    }
}
