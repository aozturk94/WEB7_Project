using AlSatProjesi_01.DataAccessLayer.SQLConnectionLayer;
using AlSatProjesi_01.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlSatProjesi_01.DataAccessLayer
{
    class ProductsDAL
    {
        public List<Products> GetProducts()
        {
            List<Products> products = new List<Products>();
            try
            {
                string query = $"SELECT * FROM tblProducts";
                using (SqlCommand command=new SqlCommand(query,SQLConnection.Connection))
                {
                    SQLConnection.ConnectionOpen();
                    using (SqlDataReader reader=command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Products product = new Products
                            {
                                ID=Convert.ToInt32(reader[0]),
                                ProductName=reader[1].ToString(),
                                CurrentStock=Convert.ToInt32(reader[2])
                            };

                            products.Add(product);
                        }
                    }
                }
            return products;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                SQLConnection.ConnectionClose();
            }
        }
        public void StockCalculate(int soldQuantity,int ID)
        {
            string query = $"UPDATE tblProducts SET CurrentStock=(CurrentStock-{soldQuantity}) WHERE ID={ID} AND CurrentStock >= {soldQuantity}";
            try
            {
                using (SqlCommand command = new SqlCommand(query, SQLConnection.Connection))
                {
                    SQLConnection.ConnectionOpen();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SQLConnection.ConnectionClose();
            }
        }
    }
}
