using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakipProgramı.ToolsLayer.Connections
{
    class SQLConnection
    {
        private static SqlConnection connection;

        public static SqlConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CsPersonel"].ConnectionString);
                }
                return connection;
            }
            set
            {
                connection = value;
            }
        }
        public static void ConOpen()
        {
            if (Connection.State == ConnectionState.Closed) Connection.Open();
        }
        public static void ConClose() //Con=Connection
        {
            if (Connection.State == ConnectionState.Open) Connection.Close(); //Gerçekleşecek tek durum varsa bu şekilde düzenlenebilir.
        }
    }
}
