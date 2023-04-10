using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace EcomDesktop
{
    internal class Queries
    {

        // Create a new DBConnection object
        DBConnection dbConnection = new DBConnection();


        public bool PerformLogin(string email, string pwd)
        {
            

            // Call the GetConnection() function and store the result
            IDbConnection connection = dbConnection.GetConnection(email, pwd);

            // Check if the connection object is not null
            if (connection != null)
            {
                // The connection was successful
                return true;
            }
            else
            {
                // The connection was not successful
                return false;
            }
        }





        public List<Product> getProducts()
        {
            var products = new List<Product> { };
            

            using (IDbConnection connection = dbConnection.GetRootConnection())
            {
                connection.Open();

                // Create a new command
                IDbCommand command = connection.CreateCommand();

                // Set the command text and parameters
                command.CommandText = "SELECT * FROM product";

                // Execute the command and retrieve the results
                using (IDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Process the data here
                        int productId = reader.GetInt32(0);
                        string productName = reader.GetString(1);
                        float price = reader.GetFloat(2);
                        int quantity = reader.GetInt32(3);
                        string supplier = reader.GetString(4);
                        string category = reader.GetString(5);

                        Product product = new Product(productId,productName,price,quantity,supplier,category);
                        

                        products.Add(product);


                    }
                }

                connection.Close();
            }

            return products;


        }




        public void DeleteProduct(int id)
        {

            // Create a connection to the database
            using (IDbConnection connection = dbConnection.GetRootConnection())
            {
                connection.Open();

                // Create a new command
                IDbCommand command = connection.CreateCommand();

                // Set the command text and parameters
                command.CommandText = "DELETE FROM product WHERE ProductId = @id";
                command.Parameters.Add(new MySqlParameter("id", id.ToString()));

                // Execute the command
                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public void CreateProduct(string name, float price, int quantity, string supplier, string category)
        {

            // Create a connection to the database
            using (IDbConnection connection = dbConnection.GetRootConnection())
            {
                connection.Open();

                // Create a new command
                IDbCommand command = connection.CreateCommand();

                // Set the command text and parameters
                command.CommandText = "INSERT INTO product VALUES (0, @name,@price,@quantity,@supplier,@category)";
                command.Parameters.Add(new MySqlParameter("name", name.ToString()));
                command.Parameters.Add(new MySqlParameter("price", price));
                command.Parameters.Add(new MySqlParameter("quantity", quantity));
                command.Parameters.Add(new MySqlParameter("supplier", supplier.ToString()));
                command.Parameters.Add(new MySqlParameter("category", category.ToString()));

                // Execute the command
                command.ExecuteNonQuery();

                connection.Close();
            }
        }




    }
}