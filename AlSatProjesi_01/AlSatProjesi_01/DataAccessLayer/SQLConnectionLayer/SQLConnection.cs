using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlSatProjesi_01.DataAccessLayer.SQLConnectionLayer
{
    class SQLConnection
    {
        private static SqlConnection connection;

        public static SqlConnection Connection
        { 
            get 
            {
                if (connection==null)
                {
                    connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Cs"].ConnectionString);
                }
                return connection;
            }
            set { connection = value; }
        }

        public static void ConnectionOpen()
        {
            if (Connection.State==ConnectionState.Closed)
            {
                Connection.Open();
            }
        }
        public static void ConnectionClose()
        {
            if (Connection.State==ConnectionState.Open)
            {
                Connection.Close();
            }
        }
    }
}
