using System.Data.SqlClient;

namespace AtmManagementSystem
{
    public partial class ChangePassword : UserControl
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new AccountSettings());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Parent.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.databasePath);
                conn.Open();

                //Check current email
                SqlCommand cmd = new SqlCommand("select Password from [dbo].[Accounts.tb] " +
                    "where Username = @user", conn);
                cmd.Parameters.AddWithValue("@user", Properties.Settings.Default.currentUser);
                String currentEmail = (String)cmd.ExecuteScalar();

                if (currentEmail != prevEmail.Text)
                {
                    MessageBox.Show("Your current Password didn't match the one on account");
                    return;
                }
                /*Check password
                cmd = new SqlCommand("select Password from [dbo].[Accounts.tb] " +
                    "where Username = @user", conn);
                cmd.Parameters.AddWithValue("@user", Properties.Settings.Default.currentUser);
                String pwd = (String)cmd.ExecuteScalar();

                if (pwd != pass.Text)
                {
                    MessageBox.Show("Wrong Password");
                    return;
                }*/

                //change email
                cmd = new SqlCommand("update [dbo].[Accounts.tb] " +
                    "Set Password " +
                    "= " +
                    "(@email) where username = @user", conn);
                cmd.Parameters.AddWithValue("@email", newEmail.Text);
                cmd.Parameters.AddWithValue("@user", Properties.Settings.Default.currentUser);
                cmd.ExecuteNonQuery();

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Password Changed Successfully");

            this.Parent.Hide();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (prevEmail.Text == "Previous Password")
            {
                prevEmail.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (prevEmail.Text == "")
            {
                prevEmail.Text = "Previous Password";
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (newEmail.Text == "New Password")
            {
                newEmail.Text = "";
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (newEmail.Text == "")
            {
                newEmail.Text = "New Password";
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
