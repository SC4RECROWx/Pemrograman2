using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sandbox3
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // KONEKSI DATABASE MYSQL DAN MENGAMBIL DATABASE YANG DIPERLUKAN
            MySqlConnection Connect = new MySqlConnection("SERVER = localhost; database = pt_sinar; UID = root; pwd = ''");
            string Query = "select*from user where USERNAME = '" + UserName.Text.Trim() + "' and PASSWORD = '" + PassWord.Text.Trim() + "'";
            MySqlDataAdapter DataAdp = new MySqlDataAdapter(Query, Connect);
            DataTable data = new DataTable();

            // MENGISI DATA UNTUK DIGUNAKAN SEBAGAI SYARAT LOGIN
            DataAdp.Fill(data);
            if(data.Rows.Count == 1)
            {
                // JIKA SYARAT TERPENUHI MAKA FORM INI AKAN DITUTUP
                // DAN AKAN MASUK KE MAIN PROGRAM
                Main objMain_Program = new Main();
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
