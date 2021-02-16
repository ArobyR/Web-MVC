using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Web.DBConnection
{
    public static class ConnectionMySql
    {
        public static MySqlConnection GetConnectionToDB()
        {
            string server = "127.0.0.1";
            string database = "movie";
            string uid = "root";
            string pwd = "";

            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = $"SERVER={server}; DATABASE={database}; UID={uid}; PWD={pwd};";
            cn.Open();
            return cn;
        } 
    }
}