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

namespace Form02_SQL
{
    public partial class Form3 : Form
    {
        SqlConnection baglanti;
        SqlDataAdapter adapter; //Çektiğim verileri table formatına uygun bir şekilde bir nesneye atabimemi sağlayacak.
        string baglantiCumlesi = @"Server=DESKTOP-MTU4EKB\SQLEXPRESS; Database=Sirket50; User=sa; Pwd=123;";
        string sorguCumlesi;
        DataTable dt;
        public Form3()
        {
            InitializeComponent();
        }
        void VerileriCek()
        {
            //tblPersonel tablosundaki verileri getirecek.
            sorguCumlesi = "SELECT*FROM tblPersonel";
            baglanti = new SqlConnection(baglantiCumlesi);
            adapter = new SqlDataAdapter(sorguCumlesi, baglanti); //Verileri buraya çektik. DataAdapter kendisi open ve close komutlarını otomatik yapıyor. Açar, işini bitirir kapatır.
            dt = new DataTable();
            adapter.Fill(dt); //dt'yi doldurduk.
            dgvPersonel.DataSource = dt;
            dgvPersonel.Columns[0].Visible = false;
            dgvPersonel.Columns["IlceID"].Visible = false;

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            VerileriCek();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
