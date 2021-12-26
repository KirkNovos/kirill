using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vosmerkaa
{
    public partial class Form1 : Form
    {
        Connect con = new Connect();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            string s = "SELECT * FROM materials_short_k_import ";
            dataGridView1.DataSource = con.ConDS(s).Tables[0];
            string s1 = "SELECT * FROM productmaterial_k_import ";
            dataGridView2.DataSource = con.ConDS(s1).Tables[0];
            string s2 = "SELECT * FROM products_k_import ";
            dataGridView3.DataSource = con.ConDS(s2).Tables[0];
        }
    }
}
