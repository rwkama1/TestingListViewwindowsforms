using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingListViewJardineriadb
{
    internal class Conexion
    {
        private static string server = "localhost";
        private static string database = "bdjardineria";
        private static string username = "root";
        private static string password = "root";
        private static string _cnn = "Server=" + server + ";Uid=" + username + ";Pwd=" + password + ";Database=" + database + ";SslMode=None";
        internal static MySqlConnection conexion()
        {
            try
            {
                MySqlConnection cnn = new MySqlConnection(_cnn);
                return cnn;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectar a MySQL " + ex.Message);
            }

        }
    }
}
