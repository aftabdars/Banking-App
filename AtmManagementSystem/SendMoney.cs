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
    public partial class SendMoney : UserControl
    {
        public SendMoney()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.databasePath);
                conn.Open();
                //Check Account Balance
                SqlCommand cmd = new SqlCommand("select Balance from [dbo].[Accounts.tb] " +
                    "where Username = @user", conn);
                cmd.Parameters.AddWithValue("@user", Properties.Settings.Default.currentUser);
                Int32 currentBalance = (Int32)cmd.ExecuteScalar();

                if (currentBalance < Int32.Parse(textBox2.Text))
                {
                    MessageBox.Show("Not enough Balance");
                    return;
                }

                //ADD TO THE OTHER ACCOUNT
                cmd = new SqlCommand("update [dbo].[Accounts.tb] " +
                    "Set Balance " +
                    "= " +
                    "(Balance + @amount) where username = @user", conn);
                cmd.Parameters.AddWithValue("@amount", textBox2.Text);
                cmd.Parameters.AddWithValue("@user", textBox1.Text);
                int rowsAffected = cmd.ExecuteNonQuery();

                //if the username isn't found
                if(rowsAffected == 0)
                {
                    MessageBox.Show("Receiver Doesn't Exist.");
                    return;
                }

                cmd = new SqlCommand("insert into [dbo].[Transactions] " +
                    "(Date, Name, Amount, Username, Type)" +
                    "values" +
                    "(@date, @purpose, @amount, @user, 'incoming')", conn);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                cmd.Parameters.AddWithValue("@purpose", textBox5.Text);
                cmd.Parameters.AddWithValue("@amount", textBox2.Text);
                cmd.Parameters.AddWithValue("@user", textBox1.Text);
                cmd.ExecuteNonQuery();

                //REMOVE FROM THIS ACCOUNT
                cmd = new SqlCommand("update [dbo].[Accounts.tb] " +
                    "Set Balance " +
                    "= " +
                    "(Balance - @amount) where username = @user", conn);
                cmd.Parameters.AddWithValue("@amount", textBox2.Text);
                cmd.Parameters.AddWithValue("@user", Properties.Settings.Default.currentUser);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("insert into [dbo].[Transactions] " +
                    "(Date, Name, Amount, Username, Type)" +
                    "values" +
                    "(@date, @purpose, @amount, @user, 'outgoing')", conn);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                cmd.Parameters.AddWithValue("@purpose", textBox5.Text);
                cmd.Parameters.AddWithValue("@amount", textBox2.Text);
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

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Receiver's Username")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Receiver's Username";
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Amount")
            {
                textBox2.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Amount";
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Purpose")
            {
                textBox5.Text = "";
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Purpose";
            }
        }

        private void textBox4_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "PIN Code/Password")
            {
                textBox4.Text = "";
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "PIN Code/Password";
            }
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "Message/Comments (Optional)")
            {
                richTextBox1.Text = "";
            }
        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                richTextBox1.Text = "Message/Comments (Optional)";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Parent.Hide();
        }
    }
}
