using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Perpustakaan
{
    class connectionService
    {
        public static MySqlConnection getConnection()
        {
            MySqlConnection conn = null;
            try
            {
                string sConnString = "server=localhost ;database=perpusvisual ;uid=root;password=;";
                conn = new MySqlConnection(sConnString);
            }
            catch (MySqlException sqlex)
            {
                throw new Exception(sqlex.Message.ToString());
            }
            return conn;
        }
    }
}
