using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace App1
{
    internal class connect
    {
        private MySqlConnection con = new MySqlConnection("datasource = localhost; database = parking; port = 3306; username = root; password = 230690vfnmdfie");
        public MySqlConnection connect_()
        { 
        return con;
        }

        public void open()
        { 
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
        }

        public void close()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();

        }

    }
}