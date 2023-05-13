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
        public Home()
        {
            InitializeComponent();
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
    }
}
