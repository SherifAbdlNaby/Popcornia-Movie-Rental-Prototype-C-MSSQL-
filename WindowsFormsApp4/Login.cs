using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
namespace Popcornia
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            invalidTest.Hide();
            String conString = @"Data Source=SHERIF\SQLEXPRESS;Initial Catalog=Popcornia;Persist Security Info=True;User ID=sa;Password=123456";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand query = new SqlCommand();
            query.CommandText = "Select * from [Users] WHERE username = '" + textBox1.Text + "' AND password ='" + textBox2.Text + "'";
            query.Connection = connection;
            query.CommandType = CommandType.Text;
            SqlDataReader reader = query.ExecuteReader();
            if (reader.Read())
            {
                if ((bool)reader["isAdmin"] == true)
                {
                    //LOAD ADMIN
                    Admin AdminPanel = new Admin();
                    string mydate = Convert.ToDateTime(reader["BirthDate"]).ToShortDateString().ToString();
                    AdminPanel.loadWindow((string)reader["Username"], (string)reader["Name"], (string)reader["Email"], (string)reader["Address"], (string)reader["Telephone"], mydate);
                    this.Hide();
                    AdminPanel.ShowDialog();
                    this.Show();
                }
               else
                {
                    //LOAD NORMIE
                    User UserPanel = new User((int)reader["UserID"]);
                    string mydate = Convert.ToDateTime(reader["BirthDate"]).ToShortDateString().ToString();
                    UserPanel.loadWindow((string)reader["Username"], (string)reader["Name"], (string)reader["Email"], (string)reader["Address"], (string)reader["Telephone"], mydate);
                    this.Hide();
                    UserPanel.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                invalidTest.Show();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register RegisterForm = new Register();
            this.Hide();
            RegisterForm.ShowDialog();
            this.Show();
        }
    }
}
