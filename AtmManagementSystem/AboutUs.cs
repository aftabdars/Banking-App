﻿using System;
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
    public partial class AboutUs : UserControl
    {
        public AboutUs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new AboutUC());
        }
    }
}
