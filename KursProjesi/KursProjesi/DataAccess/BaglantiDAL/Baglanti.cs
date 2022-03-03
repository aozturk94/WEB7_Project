using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;

namespace KursProjesi.DataAccess.BaglantiDAL
{
   public static  class Baglanti// clasın içini satativ yaptığımızda hepsini static yapmak zorundayız static yapınca sadece buraya özgü bi daha değiştirilemez.
    {
        private static SqlConnection baglantiNesnesi;

        public  static SqlConnection BaglantiNesnesi
        {
            get 
            {
                if (baglantiNesnesi==null)
                {
                    baglantiNesnesi = new SqlConnection(ConfigurationManager.ConnectionStrings["CsKurslar"].ConnectionString);

                }
                return baglantiNesnesi; 
            }
            set 
            {
                baglantiNesnesi = value; 
            }
        }
        public static void Ac()
        {
            if (BaglantiNesnesi.State==ConnectionState.Closed){BaglantiNesnesi.Open();}
        }
        public static void Kapa()
        {
            if (BaglantiNesnesi.State==ConnectionState.Open){BaglantiNesnesi.Close();}
        }

    }
}
