using AlSatProjesi_01.DataAccessLayer;
using AlSatProjesi_01.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlSatProjesi_01.BusinessLayer
{
    class BL
    {
        SalesDAL salesDAL = new SalesDAL();
        ProductsDAL productsDAL = new ProductsDAL();
        private List<Products> getProducts;

        public List<Products> GetProducts
        {
            get { return getProducts=productsDAL.GetProducts(); }
            set { getProducts = value; }
        }
        public bool BLSave(Orders orders)
        {
            return salesDAL.Save(orders);
        }

        public void StockCalculate(int soldQuantity, int ID)
        {
            productsDAL.StockCalculate(soldQuantity, ID);
        }
    }
}
