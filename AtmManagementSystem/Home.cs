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
    public partial class Home : UserControl
    {
        //private string currentUser;
        public Home()
        {
            InitializeComponent();
            //currentUser = getUser;
        }

        private void drawCards(DataTable cards)
        {
            foreach (DataRow row in cards.Rows)
            {
                //generate card component
                VisaCard card = new();
                card.lblName.Text = row["Name"].ToString();
                string cardNumber = System.Text.RegularExpressions.Regex.Replace(row["CardNumber"].ToString(), ".{4}", "$0 ");
                card.lblNumber.Text = cardNumber;
                DateTime expiryDate = (DateTime)row["Expiry"];
                card.lblExpiry.Text = expiryDate.ToString("MM/yyyy");
                card.lblCVV.Text = row["CVV"].ToString();
                cardsContainer.Controls.Add(card);
            }
        }

        private DataTable getCards()
        {
            DataTable dataTable = new();
            string connString = Properties.Settings.Default.databasePath;
            string query = "select * from [dbo].[Cards] where Username = '" + Properties.Settings.Default.currentUser + "'";

            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(dataTable);
            conn.Close();
            da.Dispose();
            return dataTable;
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy");
            label3.Text = Properties.Settings.Default.currentUser;
            DataTable cards = getCards();
            drawCards(cards);
            //edit balance, transaction, expense, income
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogWindow dw = new DialogWindow();
            dw.Controls.Add(new SendMoney());
            dw.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogWindow dw = new DialogWindow();
            dw.Controls.Add(new MobileTopUp());
            dw.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogWindow dw = new DialogWindow();
            dw.Controls.Add(new BillPayment());
            dw.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogWindow dw = new DialogWindow();
            dw.Controls.Add(new AddCard());
            dw.Show();
        }

        private void cardsContainer_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
