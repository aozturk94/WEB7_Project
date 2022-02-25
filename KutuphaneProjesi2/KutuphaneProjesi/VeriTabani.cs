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
            string baglantiCumlesi = $"Server={sName}; Database={dName}; User={uName}; Pwd={pass}";
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
            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
        }
        public string TableName { get; set; }
        
        public DataTable dt;
        public void Islem() 
        {
            string kosul = "WHERE Durum='False'";
            if (TableName!="tblOdunc")
            {
                kosul = "";
            }
            string sorguCumlesi = $"SELECT * FROM {TableName} {kosul}";
            SqlDataAdapter adaptor = new SqlDataAdapter(sorguCumlesi, baglanti);
            dt = new DataTable();
            adaptor.Fill(dt);
        }

        public void Islem(Odunc yeniOdunc)
        {
            string sorguCumlesi = "INSERT INTO tblOdunc (UyeID, KitapISBN, VerilisTarihi, Durum) VALUES" +
                "(@uyeID,@kitapISBN,@verilisTarihi,@durum)";
            SqlCommand komut = new SqlCommand(sorguCumlesi, baglanti);
            komut.Parameters.AddWithValue("@uyeID", yeniOdunc.UyeID);
            komut.Parameters.AddWithValue("@kitapISBN", yeniOdunc.KitapISBN);
            komut.Parameters.AddWithValue("@verilisTarihi", yeniOdunc.VerilisTarihi.ToString("yyyy-MM-dd"));
            komut.Parameters.AddWithValue("@durum", yeniOdunc.Durum);
            Ac();
            komut.ExecuteNonQuery();
            Kapat();
        }

        public void Islem(string silinecekID)
        {
            string sorguCumlesi = $"UPDATE {TableName} SET Durum='TRUE' WHERE ID=@silinecekid";
            SqlCommand komut = new SqlCommand(sorguCumlesi, baglanti);
            komut.Parameters.AddWithValue("@silinecekid", silinecekID);
            Ac();
            komut.ExecuteNonQuery();
            Kapat();
        }
    }
}
