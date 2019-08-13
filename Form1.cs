using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace Perpustakaan
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = connectionService.getConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private Boolean login(string sUsername, string sPassword)
        {
            string SQL = "SELECT username,password FROM tb_user";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(SQL, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if ((sUsername == reader.GetString(0)) && (sPassword == reader.GetString(1)))
                {
                    conn.Close();
                    return true;
                }
            }
            conn.Close();
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (login(textBox1.Text, textBox2.Text))
            {
                this.Hide();
                Home oHome = new Home();
                oHome.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username atau password salah !", "Gagal login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
