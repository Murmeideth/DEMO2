using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace DemoExam
{
    class MySQLUtills
    {
        public static MySqlConnection GetDBConnection(string host, int port, string database, string user, string password)
        {
            String connString = "Server = " + host + "; Port = " + port.ToString() + "; Database = " + database + "; User = " + user + "; Password =" + password + ";";

            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }
    }
}
