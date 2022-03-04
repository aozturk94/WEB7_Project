using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XYZBilisim.KayitSistemi.DataAccesLayer.DAL;
using XYZBilisim.KayitSistemi.EntityLayer;

namespace XYZBilisim.KayitSistemi.BusinessLayer
{
    class Business
    {
        KayitlarDAL kayitlarDAL = new KayitlarDAL();

        private List<Kayit> allkursiyer;
        public List<Kayit> AllKursiyer
        {
            get 
            {
                allkursiyer = kayitlarDAL.GetAll();
                return allkursiyer; 
            }
            set { allkursiyer = value; }
        }
    }
}
