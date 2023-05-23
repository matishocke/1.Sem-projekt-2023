using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opgave_2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SqlConnection connection = DataConnection();

            // open connection
            connection.Open();

            // query and c# sql command class
            string queryKunde = "SELECT * FROM Kunde";
            SqlCommand commandKunde = new SqlCommand(queryKunde, connection);

            // read from database
            SqlDataReader readerKunde = commandKunde.ExecuteReader();

            DataTable tableKunde = new DataTable();
            tableKunde.Load(readerKunde);

            dgv_kunde.DataSource = tableKunde;

            // close connection
            connection.Close();


            // do the same, but for Vare table
            connection.Open();

            string queryVare = "SELECT * FROM Vare";
            SqlCommand commandVare = new SqlCommand(queryVare, connection);
            SqlDataReader readerVare = commandVare.ExecuteReader();
            DataTable tableVare = new DataTable();
            tableVare.Load(readerVare);
            dgv_vare.DataSource = tableVare;

            connection.Close();
        }

        public static SqlConnection DataConnection()
        {
            // connection string to database
            string connectionString = "Data Source=mssql14.unoeuro.com;Initial " +
                "Catalog=minting_dk_db_test;Persist " +
                "Security Info=True;User " +
                "ID=minting_dk;Password=Bf6RnaA4remFHt5czdpx";

            // make connection
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

        private void kundebtn_Opret_Click(object sender, EventArgs e)
        {
            SqlConnection connection = DataConnection();

            connection.Open();

            string fornavn = tb_fornavn.Text;
            string efternavn = tb_efternavn.Text;
            string cpr = tb_cpr.Text;
            string telefon = tb_tlf.Text;
            string adresse = tb_adresse.Text;

            string query = "INSERT INTO Kunde (Fornavn, Efternavn, CprNr, TelefonNr, Adresse) VALUES (" +
                fornavn + ", " + efternavn + ", " + int.Parse(cpr) + ", " + int.Parse(telefon) + ", " + adresse + ")";

            SqlCommand commandVare = new SqlCommand(query, connection);
            commandVare.ExecuteNonQuery();

            connection.Close();
        }
    }
}
