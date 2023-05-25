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
        private void UpdateGridVARE()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var selectQuery =
                from a in dc.GetTable<Vare>()
                select a;
            dgv_vare.DataSource = selectQuery;
        }

        private void ClearTextBoxes()
        {
            
            tb_cpr.Text = "";
            tb_fornavn.Text = "";
            tb_efternavn.Text = "";
            tb_tlf.Text = "";
            tb_adresse.Text = "";
            tb_Email.Text = "";
        }
        private void ClearTextBoxesVARE()
        {
            
            tb_stoerrelse.Text = "";
            tb_varenavn.Text = "";
            tb_pris.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            UpdateGridVARE();
        }

        private void kundebtn_Opret_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dcCreat = new DataClasses1DataContext();

            kunde newKunde = new kunde();
            
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

        private void varebtn_Opret_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dcCreat = new DataClasses1DataContext();

            Vare newVare = new Vare();
            
            newVare.Storrelse = Convert.ToDouble(tb_stoerrelse.Text);
            newVare.VareNavn = tb_varenavn.Text;
            newVare.Pris = Convert.ToDouble(tb_pris.Text);

            dcCreat.Vares.InsertOnSubmit(newVare);
            dcCreat.SubmitChanges();

            MessageBox.Show("Varen er tilføjet");

            UpdateGridVARE();
        }

        private void dgv_kunde_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            tb_cpr.Text = dgv_kunde.CurrentRow.Cells[6].Value.ToString();
            tb_fornavn.Text = dgv_kunde.CurrentRow.Cells[1].Value.ToString();
            tb_efternavn.Text = dgv_kunde.CurrentRow.Cells[2].Value.ToString();
            tb_tlf.Text = dgv_kunde.CurrentRow.Cells[3].Value.ToString();
            tb_adresse.Text = dgv_kunde.CurrentRow.Cells[5].Value.ToString();
            tb_Email.Text = dgv_kunde.CurrentRow.Cells[4].Value.ToString();
        }

        private void dgv_vare_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            tb_stoerrelse.Text = dgv_vare.CurrentRow.Cells[1].Value.ToString();
            tb_varenavn.Text = dgv_vare.CurrentRow.Cells[2].Value.ToString();
            tb_pris.Text = dgv_vare.CurrentRow.Cells[3].Value.ToString();
        }

        private void kundebtn_AEndre_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dcChange = new DataClasses1DataContext();
            kunde kundeChange = dcChange.kundes.FirstOrDefault();
            
            //kundeChange1 => kundeChange1.Fornavn.Equals(tb_fornavn.Text)
            kundeChange.cprnummer = Convert.ToInt32(tb_cpr.Text);
            kundeChange.Fornavn = tb_fornavn.Text;
            kundeChange.Efternavn = tb_efternavn.Text;
            kundeChange.TelefonNr = Convert.ToInt32(tb_tlf.Text);
            kundeChange.Adresse = tb_adresse.Text;
            kundeChange.Email = tb_Email.Text;
            
            dcChange.SubmitChanges();

            MessageBox.Show("Udvalgte Kunde Er Nu Blevet Updateret");

            UpdateGrid();
        }

        private void varebtn_AEndre_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dcChange = new DataClasses1DataContext();
            Vare vareChange = dcChange.Vares.FirstOrDefault();
                

            vareChange.Storrelse = Convert.ToDouble(tb_stoerrelse.Text);
            vareChange.VareNavn = tb_varenavn.Text;
            vareChange.Pris = Convert.ToDouble(tb_pris.Text);

            dcChange.SubmitChanges();

            MessageBox.Show("Udvalgte VARE Er Nu Blevet Updateret");

            UpdateGridVARE();
        }

        private void kundebtn_Slet_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dcDelete = new DataClasses1DataContext();
            kunde kundeDelete = dcDelete.kundes.FirstOrDefault
                (kundeDelete1 => kundeDelete1.kundeNr.Equals(dgv_kunde.CurrentRow.Cells[0].Value));
            dcDelete.kundes.DeleteOnSubmit(kundeDelete);
            dcDelete.SubmitChanges();
            MessageBox.Show("Udvalgte VARE Er NU Slettet");
            UpdateGrid();
        }

        private void varebtn_Slet_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dcDelete = new DataClasses1DataContext();
            Vare vareDelete = dcDelete.Vares.FirstOrDefault
                (vareDelete1 => vareDelete1.Varenr.Equals(dgv_vare.CurrentRow.Cells[0].Value));
            dcDelete.Vares.DeleteOnSubmit(vareDelete);
            dcDelete.SubmitChanges();
            MessageBox.Show("Udvalgte VARE Er NU Slettet");
            UpdateGridVARE();
        }
    }
}
