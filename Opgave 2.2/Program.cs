using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Address of database
            string connectionString = "Data Source=mssql14.unoeuro.com;Initial " +
                "Catalog=minting_dk_db_test;Persist " +
                "Security Info=True;User " +
                "ID=minting_dk;Password=Bf6RnaA4remFHt5czdpx";

            SqlConnection connection = new SqlConnection(connectionString);
            // Open connection to database
            connection.Open();

            string query = "SELECT * FROM Kunde ORDER BY Adresse";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = (int)reader["KundeID"];
                string name = (string)reader["Adresse"];

                Console.WriteLine($"ID: {id}, Name: {name}");
            }
            // Close connection to databse
            reader.Close();
            
            Console.ReadLine();
        }
    }
}
