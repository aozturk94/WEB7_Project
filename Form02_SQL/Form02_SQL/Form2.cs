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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        void DepartmanGetir()
        {
            string baglantiCumlesi = @"Server=DESKTOP-MTU4EKB\SQLEXPRESS; Database=Sirket50; User=sa; Pwd=123;";
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            SqlCommand komut = new SqlCommand(); //Sql komutlarını kullanmak için bu ti lazım.
            komut.CommandText = "SELECT*FROM tblDepartman"; //Komut nesnesi bu SQL satırını çalıştırsın demek.
            komut.Connection = baglanti; //Connection özelliğini bağlantıya atamak için.
            baglanti.Open();

            SqlDataReader dr = komut.ExecuteReader(); //Kendisine verilen komut neticesinde (okunan) değerleri içinde tutucak.
            while (dr.Read())
            {
                int id = (int)dr["ID"]; //int'e çevirip değişkene atadık, int değer barındırsa bile bir object.
                string departmanAd = dr["DepartmanAd"].ToString(); //Üsteki nedenden dolayı .ToString()
                lstDepartmanlar.Items.Add($"{id}\t{departmanAd}");
            }

            baglanti.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            DepartmanGetir(); 
        }
    }
}
