using PersonelTakipProgramı.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakipProgramı.BusinessLayer
{
    class BL //Hocadan al.
    {
        public static string Tc_PersonelKontrolEt(string pNo, string tcNo)
        {   
            CalisanDAL calisanDAL = new CalisanDAL();
            string mesaj = string.Empty;
            int pNoAdet = calisanDAL.Duplicate("");
            int tcNoAdet = calisanDAL.Duplicate("");

            if (pNoAdet == 1 && tcNoAdet == 1)
            {
                mesaj = "Bu personel numarası ve TC kimlik numarası kullanılmaktadır!";

            }
            else if (pNoAdet == 1)
            {
                mesaj = "Bu personel numarası kullanılmaktadır!";
            }
            else
            {
                mesaj = "Bu TC Kimlik numarası kullanılmaktadır!";
            }
            return mesaj;
        }
    }
}
