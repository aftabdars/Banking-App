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

namespace WinFormsApp2
{
    public partial class UserControl1 : UserControl
    {
        private DataTable getTransactions()
        {
            DataTable dataTable = new();
            string connString = AtmManagementSystem.Properties.Settings.Default.databasePath;
            string query = "select * from [dbo].[Transactions] where Username = '" + AtmManagementSystem.Properties.Settings.Default.currentUser + "'";

            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(dataTable);
            conn.Close();
            da.Dispose();

            transactionsView.DataSource = dataTable;

            return dataTable;
        }

        public UserControl1()
        {
            InitializeComponent();
            getTransactions();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
