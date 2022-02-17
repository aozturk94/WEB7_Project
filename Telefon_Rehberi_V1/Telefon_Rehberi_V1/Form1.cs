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

namespace Telefon_Rehberi_V1
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlDataAdapter adapter;
        DataTable dt;
        SqlCommand komut;
        string baglantiCumlesi = @"Server=DESKTOP-MTU4EKB\SQLEXPRESS; Database=Arehber; User=sa; Pwd=123";
        string sorguCumlesi;
        public Form1()
        {
            InitializeComponent();
        }

        void Aktar()
        {
            lblID.Text = dgwKisiler.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dgwKisiler.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dgwKisiler.CurrentRow.Cells[2].Value.ToString();
            txtTelNo.Text = dgwKisiler.CurrentRow.Cells[4].Value.ToString();
            //rdbKadin.Checked = dgwKisiler.CurrentRow.Cells[3].Value.ToString() == "K" ? true : false;
            //rdbErkek.Checked = dgwKisiler.CurrentRow.Cells[3].Value.ToString() == "E" ? true : false;

            if (dgwKisiler.CurrentRow.Cells[3].Value.ToString() == "K")
            {
                rdbKadin.Checked = true;
            }

            else
            {
                rdbErkek.Checked = true;
            }
        }

        void KisilerGetir()
        {
            sorguCumlesi = "SELECT*FROM tblKisiler";
            baglanti = new SqlConnection(baglantiCumlesi);
            adapter = new SqlDataAdapter(sorguCumlesi, baglanti);
            dt = new DataTable();
            adapter.Fill(dt);
            dgwKisiler.DataSource = dt;
            dgwKisiler.Columns[0].Visible = false;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            KisilerGetir();
        }

        private void dgwKisiler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Aktar();
        }
        void Duzelt()
        {
            string id = lblID.Text;
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string cinsiyet;
            if (rdbKadin.Checked==true)
            {
                cinsiyet = "K";
            }
            else
            {
                cinsiyet = "E";
            }

            string tel = txtTelNo.Text;

            sorguCumlesi = $"UPDATE tblKisiler SET " +
                             $"Ad='{ad}', Soyad='{soyad}', Cinsiyet='{cinsiyet}', Telefon='{tel}' " +
                                $"WHERE ID={id}";

            baglanti = new SqlConnection(baglantiCumlesi);
            komut = new SqlCommand(sorguCumlesi, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery(); //Git ve execute et demek.
            baglanti.Close();
            KisilerGetir();
        }
        private void btnDuzelt_Click(object sender, EventArgs e)
        {
            Duzelt();
        }

        void Sil()
        {
            string id = lblID.Text; //Globalde tanımlayıp burda değer atayabiliriz.
            sorguCumlesi = $"DELETE tblKisiler WHERE ID={id}";
            baglanti = new SqlConnection(baglantiCumlesi);
            komut = new SqlCommand(sorguCumlesi, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KisilerGetir();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
        }

        void Kaydet()
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string tel = txtTelNo.Text;
            string cinsiyet;
            if (rdbKadin.Checked == true)
            {
                cinsiyet = "K";
            }
            else
            {
                cinsiyet = "E";
            }

            sorguCumlesi =$"INSERT INTO tblKisiler VALUES ('{ad}','{soyad}','{cinsiyet}','{tel}')"; //ID otomatik eklenmeyecek.
            baglanti = new SqlConnection(baglantiCumlesi);
            komut = new SqlCommand(sorguCumlesi, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KisilerGetir();
        }

        void YeniKayitFormuHazirla()
        {
            //Textboxları temizler, Düzelt ve Sil'i pasif yapar. Ad textbox'sına focuslanır vs.
            lblID.Text = "Yeni Kayıt";
            txtAd.Text="";
            txtSoyad.Clear();
            txtTelNo.ResetText(); //Font ayarlarını da resetler. Clear da kullanabilir.
            rdbKadin.Checked = true;
            txtAd.Focus();
            AktifPasif();
        }
        void AktifPasif()
        {
            if (btnDuzelt.Enabled==true)
            {
                btnDuzelt.Enabled = false;
                btnSil.Enabled = false;
                dgwKisiler.Enabled = false;
            }
            else
            {
                btnDuzelt.Enabled = true;
                btnSil.Enabled = true;
                dgwKisiler.Enabled = true;
            }
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            if (btnYeni.Text=="Yeni")
            {
                btnYeni.Text = "Kaydet";
                YeniKayitFormuHazirla();
            }
            else
            {
                btnYeni.Text = "Yeni";
                AktifPasif();
                Kaydet();

            }
            
        }

        void Arama()
        {
            DataView dw = dt.DefaultView; //dt'nin standart görüntüsünü atadık.
            string ara = txtAranan.Text;
            dw.RowFilter = $"Ad LIKE '{ara}%'"; //OR Soyad LIKE '{ara}%'--> Eklenebilir. //LIKE burada 'ara'dakine benzer demek. Genelde '%' ile beraber kullanılır.
            dgwKisiler.DataSource = dw; //dw'yi data kaynağı olarak dgwKisilere ekledik.
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            Arama();
        }

        private void txtAranan_KeyUp(object sender, KeyEventArgs e) //Filtreleyip sadeleştirmek için kullandık.
        {
            Arama();
        }

        //private void txtAranan_KeyDown(object sender, KeyEventArgs e) //Bu KeyPress'ten daha iyi ama ikinci basmada filtreliyor. Bu yüzden KeyUp daha iyi!
        //{
        //    Arama();
        //}

        //private void txtAranan_KeyPress(object sender, KeyPressEventArgs e) //Her bastığımızda filtrelesin diye kullandık ama GEREKSİZ KEYDOWN DAHA İYİ OLUR!
        //{
        //    Arama();
        //}
    }
}
