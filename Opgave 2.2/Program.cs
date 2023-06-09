﻿using System;
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
            SqlConnection connection = new SqlConnection("Data Source=mssql15.unoeuro.com;Initial " +
            "Catalog=shocknet_dk_db_shock;Persist " +
            "Security Info=True;User " +
            "ID=shocknet_dk;Password=FkEHxcB432DAbamzp5tw");


            System.IO.File.WriteAllText("Varer.txt", "");

            // Open connection to database
            connection.Open();

            string query = "SELECT * FROM Vare ORDER BY Pris";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            // Loops through every row in the database table. When there is no more rows, the while-loop breaks.
            while (reader.Read())
            {
                // reads the values in all of the columns
                int id = (int)reader["Varenr"];
                double pris = (double)reader["Pris"];
                double størrelse = (double)reader["Storrelse"];
                string navn = (string)reader["VareNavn"];
                DateTime dato = (DateTime)reader["Dato"];
                int kundeNr = (int)reader["kundeNr"];

                string udprint = $"VareNr: {id}, Pris: {pris}, Størrelse: {størrelse}, Navn: {navn}, Dato: {dato}, kundeNr: {kundeNr}";

                // Appends the values to the text file.
                System.IO.File.AppendAllText("Varer.txt", udprint + Environment.NewLine);
                Console.WriteLine(udprint);
            }
            // Close connection to database
            reader.Close();
            
            Console.ReadLine();
        }
    }
}
