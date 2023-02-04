using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sandbox3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("SERVER = localhost; database = pt_sinar; UID = root; pwd = ''");
            string query = "select*from user where USERNAME = '" + textBox1.Text.Trim() + "' and PASSWORD = '" + textBox2.Text.Trim() + "'";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if(dtbl.Rows.Count == 1)
            {
                main objmain = new main();
                this.Hide();
                objmain.Show();
            }
            else
            {
                MessageBox.Show("Check ur Password or Username");
            }
        }
    }
}
