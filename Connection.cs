using MySql.Data.MySqlClient;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomDesktop
{
    internal class DBConnection
    {
        public IDbConnection GetConnection(string username, string password)
        {

                // Use string interpolation to create the connection string
                string connectionString = $"Server=localhost;Database=ecom;Uid={username};Pwd={password}";

            // Create and return a new MySqlConnection object


            using (MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    return con;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }

        }



        public IDbConnection GetRootConnection()
        {

            // Use string interpolation to create the connection string
            string connectionString = $"Server=localhost;Database=ecom;Uid=root;Pwd=";

            // Create and return a new MySqlConnection object


            using (MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    return con;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }

        }
    }



}
