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
    public partial class Actions : UserControl
    {
        public Actions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogWindow dw = new DialogWindow();
            dw.Controls.Add(new SendMoney());
            dw.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogWindow dw = new DialogWindow();
            dw.Controls.Add(new MobileTopUp());
            dw.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogWindow dw = new DialogWindow();
            dw.Controls.Add(new BillPayment());
            dw.Show();
        }
    }
}
