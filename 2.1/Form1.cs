using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shocknet_dk_db_shockDataSet1.Vare' table. You can move, or remove it, as needed.
            this.vareTableAdapter.Fill(this.shocknet_dk_db_shockDataSet1.Vare);
            // TODO: This line of code loads data into the 'shocknet_dk_db_shockDataSet.kunde' table. You can move, or remove it, as needed.
            this.kundeTableAdapter.Fill(this.shocknet_dk_db_shockDataSet.kunde);

        }
    }
}
