using Opgave_2._1.Database;
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
        // make connection
        SqlConnection connection = new SqlConnection("Data Source=mssql15.unoeuro.com;Initial " +
            "Catalog=shocknet_dk_db_shock;Persist " +
            "Security Info=True;User " +
            "ID=shocknet_dk;Password=FkEHxcB432DAbamzp5tw");

        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateGrid ()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var selectQuery =
                from a in dc.GetTable<kunde>()
                select a;
            dgv_kunde.DataSource = selectQuery;
        }

        private void ClearTextBoxes()
        {
            tb_kundeNr.Text = "";
            tb_cpr.Text = "";
            tb_fornavn.Text = "";
            tb_efternavn.Text = "";
            tb_tlf.Text = "";
            tb_adresse.Text = "";
            tb_Email.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void kundebtn_Opret_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dcCreat = new DataClasses1DataContext();

            kunde newKunde = new kunde();
            newKunde.kundeNr = Convert.ToInt32(tb_kundeNr.Text);
            newKunde.cprnummer = Convert.ToInt32(tb_cpr.Text);
            newKunde.Fornavn = tb_fornavn.Text;
            newKunde.Efternavn = tb_efternavn.Text;
            newKunde.TelefonNr = Convert.ToInt32(tb_tlf.Text);
            newKunde.Adresse = tb_adresse.Text;
            newKunde.Email = tb_Email.Text;

            dcCreat.kundes.InsertOnSubmit(newKunde);
            dcCreat.SubmitChanges();

            MessageBox.Show("Kunden er tilføjet");

            UpdateGrid();
        }

        private void dgv_kunde_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_kundeNr.Text = dgv_kunde.CurrentRow.Cells[0].Value.ToString();
            tb_kundeNr.Enabled = false;
            tb_cpr.Text = dgv_kunde.CurrentRow.Cells[6].Value.ToString();
            tb_fornavn.Text = dgv_kunde.CurrentRow.Cells[1].Value.ToString();
            tb_efternavn.Text = dgv_kunde.CurrentRow.Cells[2].Value.ToString();
            tb_tlf.Text = dgv_kunde.CurrentRow.Cells[3].Value.ToString();
            tb_adresse.Text = dgv_kunde.CurrentRow.Cells[5].Value.ToString();
            tb_Email.Text = dgv_kunde.CurrentRow.Cells[4].Value.ToString();
        }

        private void kundebtn_AEndre_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dcChange = new DataClasses1DataContext();
            kunde kundeChange = dcChange.kundes.FirstOrDefault
                (kundeChange1 => kundeChange1.kundeNr.Equals(tb_kundeNr.Text));

            //kundeChange1 => kundeChange1.Fornavn.Equals(tb_fornavn.Text)
            kundeChange.cprnummer = Convert.ToInt32(tb_cpr.Text);
            kundeChange.Fornavn = tb_fornavn.Text;
            kundeChange.Efternavn = tb_efternavn.Text;
            kundeChange.TelefonNr = Convert.ToInt32(tb_tlf.Text);
            kundeChange.Adresse = tb_adresse.Text;
            kundeChange.Email = tb_Email.Text;
            
            dcChange.SubmitChanges();

            MessageBox.Show("Udvalgte Er Nu Blevet Ændret");

            UpdateGrid();
        }

        private void kundebtn_Slet_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dcDelete = new DataClasses1DataContext();
            kunde kundeDelete = dcDelete.kundes.FirstOrDefault
                (kundeDelete1 => kundeDelete1.kundeNr.Equals(dgv_kunde.CurrentRow.Cells[0].Value));
            dcDelete.kundes.DeleteOnSubmit(kundeDelete);
            dcDelete.SubmitChanges();
            MessageBox.Show("Udvalgte Er Slettet");
            UpdateGrid();
        }
    }
}
