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
    class SalesDAL
    {
        public bool Save(Orders orders)
        {
            string query = $"INSERT INTO tblOrders VALUES (@p1,@p2,@p3)";
            try
            {
                using (SqlCommand command = new SqlCommand(query, SQLConnection.Connection))
                {
                    command.Parameters.AddWithValue("@p1", orders.OrderDate);
                    command.Parameters.AddWithValue("@p2", orders.ProductID);
                    command.Parameters.AddWithValue("@p3", orders.SoldQuantity);
                    SQLConnection.ConnectionOpen();
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                SQLConnection.ConnectionClose();
            }
        }
    }
}
