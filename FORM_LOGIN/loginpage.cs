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
            // KONEKSI DATABASE MYSQL
            MySqlConnection Connect = new MySqlConnection("SERVER = localhost; database = pt_sinar; UID = root; pwd = ''");
            string Query = "select*from user where USERNAME = '" + UserName.Text.Trim() + "' and PASSWORD = '" + PassWord.Text.Trim() + "'";
            MySqlDataAdapter DataAdp = new MySqlDataAdapter(Query, Connect);
            DataTable data = new DataTable();

            // MENGISI DATA UNTUK DIGUNAKAN SEBAGAI SYARAT LOGIN
            DataAdp.Fill(data);
            if(data.Rows.Count == 1)
            {
                main objMain_Program = new main();
                this.Hide();
                objMain_Program.Show();
            }
            else
            {
                MessageBox.Show("Check ur Password or Username");
            }
        }
    }
}
