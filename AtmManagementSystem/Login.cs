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

namespace AtmManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accounts signup = new Accounts();
            signup.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String password = "";
            try
            {
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.databasePath);
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "select Password from [dbo].[Accounts.tb]" +
                    "where Username = '" + textBox2.Text + "'"
                    , conn);
                password = (String)cmd.ExecuteScalar();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            
            if(password != textBox1.Text)
            {
                MessageBox.Show("Password Incorrect!");
                return;
            }

            Properties.Settings.Default.currentUser = textBox2.Text;
            this.Hide();
            new Dashboard().Show();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter your Password")
            {
                textBox1.Text = "";
                textBox1.PasswordChar = '*';
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Enter your user ID";
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Enter your user ID")
            {
                textBox2.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter your Password";
                textBox1.PasswordChar = '\0';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accounts signup = new Accounts();
            signup.Show();
        }

        private void Login_Load_1(object sender, EventArgs e)
        {
            
        }
    }
}
