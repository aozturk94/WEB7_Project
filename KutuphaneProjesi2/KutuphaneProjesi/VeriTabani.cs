using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProjesi
{ 
    class VeriTabani
    {
        SqlConnection baglanti;
        public VeriTabani() 
        {
            BaglantiOlustur();
        }
        void BaglantiOlustur() 
        {
            string sName = $@"DESKTOP-MTU4EKB\SQLEXPRESS";
            string dName = "aKutuphane";
            string uName = "sa";
            string pass = "123";
            string baglantiCumlesi = $"Server {sName}; Database={dName}; User={uName}; Pwd{pass}";
            baglanti = new SqlConnection(baglantiCumlesi);

        }
        void Ac()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }
        void Kapat()
        {
            if (baglanti.State==ConnectionState.Open)
            {
                baglanti.Close();
            }
        }
        public string TableName { get; set; }
        public void Islem() 
        {
            string sorguCumlesi = $"SELECT * FROM {TableName}";
            SqlDataAdapter adaptor = new SqlDataAdapter(sorguCumlesi,baglanti);

        }
    }
}
