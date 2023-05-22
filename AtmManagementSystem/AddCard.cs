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
    public partial class AddCard : UserControl
    {
        public AddCard()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/yyyy";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new();
            try
            {
                SqlConnection conn = new SqlConnection (Properties.Settings.Default.databasePath);
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into [dbo].[Cards] " +
                    "(Name, CardNumber, Expiry, CVV, Username) " +
                    "values " +
                    "(@name, @number, @expiry, @cvv, @user)", conn);
                cmd.Parameters.AddWithValue("@name", textBox4.Text);
                cmd.Parameters.AddWithValue("@number", Encryption.Encrypt(textBox1.Text, 69));
                cmd.Parameters.AddWithValue("@expiry", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@cvv", textBox2.Text);
                cmd.Parameters.AddWithValue("@user", Properties.Settings.Default.currentUser);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Card Successfully added");

            this.Parent.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Parent.Hide();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void AddCard_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter your Card Number")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter your Card Number";
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Enter the CVV on the back")
            {
                textBox2.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Enter the CVV on the back";
            }
        }

        /*private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Expiry Date eg. 02/2022")
            {
                textBox5.Text = "";
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Expiry Date eg. 02/2022";
            }
        }*/

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Enter the name on card")
            {
                textBox4.Text = "";
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Enter the name on card";
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
