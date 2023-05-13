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
    public partial class AddCard : UserControl
    {
        public AddCard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

        private void textBox5_Enter(object sender, EventArgs e)
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
        }

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
    }
}
