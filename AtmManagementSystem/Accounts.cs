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
    public partial class Accounts : Form
    {
        public Accounts()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Haier\source\repos\AtmManagementSystem\Database1.mdf;Integrated Security=True");



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Pintb_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AccNumtb_Enter(object sender, EventArgs e)
        {
            if (AccNumtb.Text == "National ID card number")
            {
                AccNumtb.Text = "";
            }
        }

        private void AccNumtb_Leave(object sender, EventArgs e)
        {
            if (AccNumtb.Text == "")
            {
                AccNumtb.Text = "National ID card number";
            }
        }

        private void Accounts_Enter(object sender, EventArgs e)
        {

        }

        private void Accounts_Leave(object sender, EventArgs e)
        {

        }

        private void Fnametb_Enter(object sender, EventArgs e)
        {
            if (Fnametb.Text == "Enter your Father's Name")
            {
                Fnametb.Text = "";
            }
        }

        private void Fnametb_Leave(object sender, EventArgs e)
        {
            if (Fnametb.Text == "")
            {
                Fnametb.Text = "Enter your Father's Name";
            }
        }

        private void AccNametb_Enter(object sender, EventArgs e)
        {
            if (AccNametb.Text == "Enter your Full Name")
            {
                AccNametb.Text = "";
            }
        }

        private void AccNametb_Leave(object sender, EventArgs e)
        {
            if (AccNametb.Text == "")
            {
                AccNametb.Text = "Enter your Full Name";
            }
        }

        private void Addresstb_Enter(object sender, EventArgs e)
        {
            if (Addresstb.Text == "Enter your Address")
            {
                Addresstb.Text = "";
            }
        }

        private void Addresstb_Leave(object sender, EventArgs e)
        {
            if (Addresstb.Text == "")
            {
                Addresstb.Text = "Enter your Address";
            }
        }

        private void Phonetb_Enter(object sender, EventArgs e)
        {
            if (Phonetb.Text == "Enter your Phone Number")
            {
                Phonetb.Text = "";
            }
        }

        private void Phonetb_Leave(object sender, EventArgs e)
        {
            if (Phonetb.Text == "")
            {
                Phonetb.Text = "Enter your Phone Number";
            }
        }

        private void Usernametb_Enter(object sender, EventArgs e)
        {
            if (Usernametb.Text == "Enter your desired Username")
            {
                Usernametb.Text = "";
            }
        }

        private void Usernametb_Leave(object sender, EventArgs e)
        {
            if (Usernametb.Text == "")
            {
                Usernametb.Text = "Enter your desired Username";
            }
        }

        private void Passwordtb_Enter(object sender, EventArgs e)
        {
            if (Passwordtb.Text == "Enter your desired Password")
            {
                Passwordtb.Text = "";
                Passwordtb.PasswordChar = '*';
            }
        }

        private void Passwordtb_Leave(object sender, EventArgs e)
        {
            if (Passwordtb.Text == "")
            {
                Passwordtb.Text = "Enter your desired Password";
                Passwordtb.PasswordChar = '\0';
            }
        }

        private void Occupationtb_Enter(object sender, EventArgs e)
        {
            if (Occupationtb.Text == "Enter your Occupation")
            {
                Occupationtb.Text = "";
            }
        }

        private void Occupationtb_Leave(object sender, EventArgs e)
        {
            if (Occupationtb.Text == "")
            {
                Occupationtb.Text = "Enter your Occupation";
            }
        }
    }
}
