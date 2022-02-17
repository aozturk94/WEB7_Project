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
    public partial class FormListeleme : Form
    {
        public FormListeleme()
        {
            InitializeComponent();
        }

        SqlConnection baglanti;
        SqlDataAdapter adapter;
        SqlCommand komut;
        string baglantiCumlesi = @"Server=DESKTOP-MTU4EKB\SQLEXPRESS; Database=Arehber; User=sa; Pwd=123";
        string sorguCumlesi;
        DataTable dt;
        void Doldur()
        {
            sorguCumlesi = $"SELECT*FROM tblKisiler";
            baglanti = new SqlConnection(baglantiCumlesi);
            adapter = new SqlDataAdapter(sorguCumlesi, baglanti);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvKisiler.DataSource = dt;
            dgvKisiler.Columns[0].Visible = false;
        }
        private void FormListeleme_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            FormAnaMenu anaForm = new FormAnaMenu();
            anaForm.Show();
            this.Hide();
        }

        private void FormListeleme_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnKapat.PerformClick();
        }

        void Guncelle()
        {
            string cinsiyet = cmbCinsiyet.SelectedIndex == 0 ? "K" : "E";
            string id = dgvKisiler.CurrentRow.Cells[0].Value.ToString();
            sorguCumlesi = $"UPDATE tblKisiler SET Ad='{txtAd.Text}',Soyad='{txtSoyad.Text}', Cinsiyet='{cinsiyet}', Telefon='{mtxTel.Text}' WHERE ID='{id}'";
            baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            komut = new SqlCommand(sorguCumlesi, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Doldur();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }


        void Aktar()
        {
            txtAd.Text = dgvKisiler.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dgvKisiler.CurrentRow.Cells[2].Value.ToString();
            cmbCinsiyet.SelectedIndex = dgvKisiler.CurrentRow.Cells[3].Value.ToString() == "K" ? 0 : 1;
            mtxTel.Text = dgvKisiler.CurrentRow.Cells[4].Value.ToString();
        }
        private void dgvKisiler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Aktar();
        }

        void Sil()
        {
            string id = dgvKisiler.CurrentRow.Cells[0].Value.ToString();
            sorguCumlesi = $"DELETE tblKisiler WHERE ID='{id}'";
            baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            komut = new SqlCommand(sorguCumlesi, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Doldur();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
        }
    }
}
