using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2;

namespace AtmManagementSystem
{
    public partial class Dashboard : Form
    {
        private bool sidebarExpanded = false;
        //private string currentUser = "";
        public Dashboard()
        {
            InitializeComponent();
            //currentUser = getUser;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            ucContainer.Controls.Add(new Actions());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucContainer.Controls.Clear();
            ucContainer.Controls.Add(new Home());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ucContainer.Controls.Clear();
            ucContainer.Controls.Add(new UserControl1());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ucContainer.Controls.Clear();
            ucContainer.Controls.Add(new SettingsUC());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ucContainer.Controls.Clear();
            ucContainer.Controls.Add(new AboutUC());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ucContainer.Controls.Clear();
            ucContainer.Controls.Add(new Actions());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ucContainer.Controls.Clear();
            ucContainer.Controls.Add(new UserControl1());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ucContainer.Controls.Clear();
            ucContainer.Controls.Add(new AboutUC());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!sidebarExpanded)
            {
                //change panels height
                panel1.Width = 110;
                panel2.Width = 110;
                sidebarExpanded = true;

                //change buttons image alignment
                btnProfile.ImageAlign = ContentAlignment.MiddleLeft;
                btnHome.ImageAlign = ContentAlignment.MiddleLeft;
                btnTransactions.ImageAlign = ContentAlignment.MiddleLeft;
                btnHelp.ImageAlign = ContentAlignment.MiddleLeft;
                btnSettings.ImageAlign = ContentAlignment.MiddleLeft;

                //change buttons text
                btnProfile.Text = "Profile";
                btnHome.Text = "Home";
                btnTransactions.Text = "Transactions";
                btnHelp.Text = "Help";
                btnSettings.Text = "Settings";

            }
            else
            {
                //change panels height
                panel1.Width = 41;
                panel2.Width = 41;
                sidebarExpanded = false;

                //change buttons image alignment
                btnProfile.ImageAlign = ContentAlignment.MiddleLeft;
                btnHome.ImageAlign = ContentAlignment.MiddleLeft;
                btnTransactions.ImageAlign = ContentAlignment.MiddleLeft;
                btnHelp.ImageAlign = ContentAlignment.MiddleLeft;
                btnSettings.ImageAlign = ContentAlignment.MiddleLeft;

                //change buttons text
                btnProfile.Text = "";
                btnHome.Text = "";
                btnTransactions.Text = "";
                btnHelp.Text = "";
                btnSettings.Text = "";
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ucContainer.Controls.Clear();
            ucContainer.Controls.Add(new Home());
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
