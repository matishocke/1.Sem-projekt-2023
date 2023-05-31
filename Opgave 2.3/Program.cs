using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_2._3
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


            System.IO.File.WriteAllText("Salgsstatistik.txt", "");

            // Open connection to database
            connection.Open();

            string query = "SELECT * FROM Vare WHERE Dato BETWEEN '2023-01-01' AND '2023-06-01' ORDER BY Dato";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            Console.WriteLine("SALGSSTATISTIK 2023 - Fra dato: 01-01-2023  Til dato: 01-06-2023");
            Console.WriteLine();
            System.IO.File.AppendAllText("Salgsstatistik.txt", "SALGSSTATISTIK 2023 - Fra dato: 01-01-2023  Til dato: 01-06-2023"
                + Environment.NewLine + Environment.NewLine);

            double sum = 0;
            // Loops through every row in the database table. When there is no more rows, the while-loop breaks.
            while (reader.Read())
            {
                // reads the values in all of the columns
                double pris = (double)reader["Pris"];
                string navn = (string)reader["VareNavn"];
                DateTime dato = (DateTime)reader["Dato"];
                int kundeNr = (int)reader["kundeNr"];

                string udprint = $"Kundenummer: {kundeNr}, Vare: {navn}, Dato: {dato} Pris: {pris}";

                // Appends the values to the text file.
                System.IO.File.AppendAllText("Salgsstatistik.txt", udprint + Environment.NewLine);
                Console.WriteLine(udprint);
                sum += pris;
            }
            // Close connection to database
            reader.Close();

            System.IO.File.AppendAllText("Salgsstatistik.txt", "I alt kr. " + sum);
            Console.WriteLine("I alt kr. " + sum);

            Console.ReadLine();
        }
    }
}
