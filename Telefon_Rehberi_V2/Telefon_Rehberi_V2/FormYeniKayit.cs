using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefon_Rehberi_V2
{
    public partial class FormYeniKayit : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        string sorguCumlesi;
        string baglantiCumlesi;

        public FormYeniKayit()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            FormAnaMenu anaMenu = new FormAnaMenu();
            anaMenu.Show();
            this.Hide();
        }

        private void FormYeniKayit_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnKapat.PerformClick();
        }

        void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            mtxTel.Clear();
            cmbCinsiyet.SelectedIndex = 0; //"Kadın" seçili gelsin istedik.
        }
        void Kaydet()
        {
            try
            {
                baglantiCumlesi = @"Server=DESKTOP-MTU4EKB\SQLEXPRESS; Database=Arehber; User=sa; Pwd=123";
                baglanti = new SqlConnection(baglantiCumlesi);
                baglanti.Open();
                string ad = txtAd.Text;
                string soyad = txtSoyad.Text;
                string tel = mtxTel.Text;
                string cinsiyet = cmbCinsiyet.Text == "Kadın" ? "K" : "E"; //Ternary If kullanımı; araştır, çalış.

                //string cinsiyet;
                //if (cmbCinsiyet.Text=="Kadın")
                //{
                //    cinsiyet = "K";
                //}
                //else
                //{
                //    cinsiyet = "E";
                //}


                sorguCumlesi = $"INSERT INTO tblKisiler VALUES ('{ad}','{soyad}','{cinsiyet}','{tel}')";
                komut = new SqlCommand(sorguCumlesi, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("KAYIT BAŞARILI!");
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata ile karşılaşıldı!");
                //throw; //Koda tekrar geçmemesi için comment yaptık.
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
            //Temizle(); //Metotu metotun içine attık.
        }

        private void FormYeniKayit_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.SelectedIndex = 0;
        }
    }
}
