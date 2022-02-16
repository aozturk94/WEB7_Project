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

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            KisilerGetir();
            
        }

        private void dgwKisiler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Aktar();
        }
    }
}
