using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithClassSql_Crud2
{
    class VeriTabani
    {
        SqlConnection baglanti;

        SqlConnection Baglan()
        {
            string dbName = "aHastane";
            string baglantiCumlesi = $@"Server=DESKTOP-MTU4EKB\SQLEXPRESS;
                                        Database={dbName};
                                        User=sa;
                                        Pwd=123";
            baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            return baglanti;
        }

        void Kapat()
        {
            baglanti.Close();
        }

        public DataTable Listele(string sorguCumlesi)
        {
            SqlDataAdapter adaptor = new SqlDataAdapter(sorguCumlesi, Baglan());
            DataTable dt = new DataTable();
            adaptor.Fill(dt);
            return dt;
        }

        public void Islem(string sorguCumlesi)
        {
            SqlCommand komut = new SqlCommand(sorguCumlesi, Baglan());
            komut.ExecuteNonQuery();
            Kapat();
        }

    }
}
