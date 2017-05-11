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

namespace Popcornia
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Regsiter_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            String conString = @"Data Source=SHERIF\SQLEXPRESS;Initial Catalog=PopCornia;Persist Security Info=True;User ID=sa;Password=123456";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand query = new SqlCommand();
            if(username.Text == "" || name.Text == "" || password.Text == "" || email.Text == "" || email.Text == "" || birthdate.Text == "" || address.Text == "" || phone.Text == "")
            {
                MessageBox.Show("Please don't leave blank fields!");
            }
            else {
                 query.CommandText = "INSERT INTO Users(Username, Name, Password, Email, BirthDate, Address, Telephone, isAdmin) VALUES ('" +
                 username.Text + "', '" +
                 name.Text + "', '" +
                 password.Text + "', '" +
                 email.Text + "', '" +
                 birthdate.Value + "', '" +
                 address.Text + "', '" +
                 phone.Text + "', 0" + //NOT ADMIN = 0
                 ");";
                query.Connection = connection;
                query.CommandType = CommandType.Text;
                try
                {
                    query.ExecuteNonQuery();
                    MessageBox.Show("Successful!");
                    this.Close();
                }
                catch(Exception x)
                {
                    MessageBox.Show("Username already exist");
                }
            }
            

        }
    }
}
