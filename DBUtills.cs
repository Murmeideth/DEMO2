using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DemoExam
{
    class DBUtills
    {
        public static MySqlConnection GetDBConenction()
        {
            string host = "192.168.4.151";
            int port = 3311;
            string database = "user4_db";
            string user = "user4";
            string password = "home";

            return MySQLUtills.GetDBConnection(host, port, database, user, password);
        }
    }
}
