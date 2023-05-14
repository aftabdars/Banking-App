using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            cardsContainer.Controls.Add(new VisaCard());
            cardsContainer.Controls.Add(new VisaCard());
            cardsContainer.Controls.Add(new VisaCard());
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
