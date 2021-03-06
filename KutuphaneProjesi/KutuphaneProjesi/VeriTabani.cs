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
        private string sorguCumlesi;
        public string SorguCumlesi
        {
            get { return sorguCumlesi ; }
            set { sorguCumlesi = value; }
        }

        SqlConnection baglanti;
        public VeriTabani()
        {
            baglanti=Baglan();
        }
        
        public VeriTabani(string sorguCumlesi)
        {
            baglanti = Baglan();
            SorguCumlesi = sorguCumlesi;
        }

        SqlConnection Baglan()
        {
            string dbName = "aKutuphane";
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

        public DataTable Listele()
        {
            SqlDataAdapter adaptor = new SqlDataAdapter(sorguCumlesi, baglanti);
            DataTable dt = new DataTable();
            adaptor.Fill(dt);
            return dt;
        }

        public void Islem(string sorguCumlesi)
        {
            SqlCommand komut = new SqlCommand(sorguCumlesi, baglanti);
            komut.ExecuteNonQuery();
            Kapat();
        }

        public string TableName { get; set; }
        
        /// <summary>
        /// Bu kullanım şekli 'SELECT' işlemi içindir.
        /// </summary>
        public void Query()
        {
            sorguCumlesi = $"SELECT*FROM {TableName}";
            Islem(sorguCumlesi);
        }

        /// <summary>
        /// Bu kullanım şekli 'DELETE' işlemi içindir.
        /// </summary>
        /// <param name="kosul">Silinmek istenen kayda dair koşul.</param>
        public void Query(string condition)
        {
            sorguCumlesi = $"DELETE FROM {TableName} WHERE {condition}";
            Islem(sorguCumlesi);
        }
        /// <summary>
        /// Bu kullanım şekli 'UPDATE' işlemi içindir.
        /// </summary>
        /// <param name="columnNames">Colunm adını belirtir.</param>
        /// <param name="colunmValues">Girilecek değeri belirtir.</param>
        /// <param name="condition"></param>
        public void Query(List<string> columnNames, List<string> colunmValues, string condition)
        {
            string text = "";
            for (int i = 0; i < columnNames.Count; i++)
            {
                text += columnNames[i] + "='" + colunmValues[i] + "',";
            }

            text = text.Substring(0, text.Length - 1);
            sorguCumlesi = $"UPDATE {TableName} SET {text} WHERE {condition}";
            Islem(sorguCumlesi);
        }
        /// <summary>
        /// Bu kullanım şekli 'INSERT...INTO' işlemi içindir.
        /// </summary>
        /// <param name="columnNames"></param>
        /// <param name="colunmValues"></param>
        public void Query(List<string> columnNames, List<string> colunmValues)
        {
            string text = "";
            string text2 = "";
            for (int i = 0; i < columnNames.Count; i++)
            {
                text += columnNames[i] + ",";
                text2 += "'"+colunmValues[i] + "',";
            }

            text = text.Substring(0, text.Length - 1);
            text2 = text2.Substring(0, text2.Length - 1);
            sorguCumlesi = $"INSERT INTO {TableName} ({text}) VALUES ({text2})";
            Islem(sorguCumlesi);
        }
    }
}
