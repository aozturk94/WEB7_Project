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
    public class Business
    {
        static KayitlarDAL kayitlarDAL = new KayitlarDAL();
        static Kayit kayit = null;
        public void RegularlySave(List<string> liste)
        {

        }
    }
}
