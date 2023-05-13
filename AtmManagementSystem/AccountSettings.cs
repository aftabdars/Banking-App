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
    public partial class AccountSettings : UserControl
    {
        public AccountSettings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Controls.Clear();
            //this.Controls.Add(new ChangeEmail());
            DialogWindow dw = new DialogWindow();
            dw.Controls.Add(new ChangeEmail());
            dw.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new PasswordSettings());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogWindow dw = new DialogWindow();
            dw.Controls.Add(new ChangePhone());
            dw.Show();
        }
    }
}
