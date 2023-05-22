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
    public partial class AddMoney : UserControl
    {
        public AddMoney()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.databasePath);
                conn.Open();
                SqlCommand cmd = new SqlCommand("update [dbo].[Accounts.tb] " +
                    "Set Balance " +
                    "= " +
                    "(Balance + @amount) where username = @user", conn);
                cmd.Parameters.AddWithValue("@amount", lblAmount.Text);
                cmd.Parameters.AddWithValue("@user", Properties.Settings.Default.currentUser);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("insert into [dbo].[Transactions] " +
                    "(Date, Name, Amount, Username, Type)" +
                    "values" +
                    "(@date, @purpose, @amount, @user, 'incoming')", conn);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                cmd.Parameters.AddWithValue("@purpose", "Add Money");
                cmd.Parameters.AddWithValue("@amount", lblAmount.Text);
                cmd.Parameters.AddWithValue("@user", Properties.Settings.Default.currentUser);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Money Successfully Added");

            this.Parent.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Parent.Hide();
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            CVV.Text = "";
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (lblAmount.Text == "Amount")
            {
                lblAmount.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (lblAmount.Text == "")
            {
                lblAmount.Text = "Amount";
            }
        }

        private void lblYear_Enter(object sender, EventArgs e)
        {
            if (lblYear.Text == "2024")
            {
                lblYear.Text = "";
            }
        }

        private void lblYear_Leave(object sender, EventArgs e)
        {
            if (lblYear.Text == "")
            {
                lblYear.Text = "2024";
            }
        }

        private void lblNumber_Enter(object sender, EventArgs e)
        {
            if (lblNumber.Text == "Card Number")
            {
                lblNumber.Text = "";
            }
        }

        private void lblNumber_Leave(object sender, EventArgs e)
        {
            if (lblNumber.Text == "")
            {
                lblNumber.Text = "Card Number";
            }
        }

        private void lblMonth_Enter(object sender, EventArgs e)
        {
            if (lblMonth.Text == "01")
            {
                lblMonth.Text = "";
            }
        }

        private void lblMonth_Leave(object sender, EventArgs e)
        {
            if (lblMonth.Text == "")
            {
                lblMonth.Text = "01";
            }
        }

        private void lblCVV_Enter(object sender, EventArgs e)
        {
            if (CVV.Text == "CVV")
            {
                CVV.Text = "";
            }
        }

        private void lblCVV_Leave(object sender, EventArgs e)
        {
            if (CVV.Text == "")
            {
                CVV.Text = "CVV";
            }
        }
    }
}
