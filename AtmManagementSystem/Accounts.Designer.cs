namespace AtmManagementSystem
{
    partial class Accounts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounts));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Occupationtb = new System.Windows.Forms.TextBox();
            this.Usernametb = new System.Windows.Forms.TextBox();
            this.Phonetb = new System.Windows.Forms.TextBox();
            this.Addresstb = new System.Windows.Forms.TextBox();
            this.Fnametb = new System.Windows.Forms.TextBox();
            this.AccNametb = new System.Windows.Forms.TextBox();
            this.AccNumtb = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Passwordtb = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.emailtb = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 71);
            this.panel1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(753, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 71);
            this.button2.TabIndex = 10;
            this.button2.Text = "X";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "ATM MANAGEMENT SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(437, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Create an account";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Occupationtb
            // 
            this.Occupationtb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Occupationtb.Location = new System.Drawing.Point(441, 290);
            this.Occupationtb.MaxLength = 50;
            this.Occupationtb.Name = "Occupationtb";
            this.Occupationtb.Size = new System.Drawing.Size(200, 23);
            this.Occupationtb.TabIndex = 7;
            this.Occupationtb.Text = "Enter your Occupation";
            this.Occupationtb.Enter += new System.EventHandler(this.Occupationtb_Enter);
            this.Occupationtb.Leave += new System.EventHandler(this.Occupationtb_Leave);
            // 
            // Usernametb
            // 
            this.Usernametb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Usernametb.Location = new System.Drawing.Point(441, 162);
            this.Usernametb.MaxLength = 50;
            this.Usernametb.Name = "Usernametb";
            this.Usernametb.Size = new System.Drawing.Size(200, 23);
            this.Usernametb.TabIndex = 5;
            this.Usernametb.Text = "Enter your desired Username";
            this.Usernametb.Enter += new System.EventHandler(this.Usernametb_Enter);
            this.Usernametb.Leave += new System.EventHandler(this.Usernametb_Leave);
            // 
            // Phonetb
            // 
            this.Phonetb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Phonetb.Location = new System.Drawing.Point(443, 98);
            this.Phonetb.MaxLength = 50;
            this.Phonetb.Name = "Phonetb";
            this.Phonetb.Size = new System.Drawing.Size(198, 23);
            this.Phonetb.TabIndex = 4;
            this.Phonetb.Text = "Enter your Phone Number";
            this.Phonetb.Enter += new System.EventHandler(this.Phonetb_Enter);
            this.Phonetb.Leave += new System.EventHandler(this.Phonetb_Leave);
            // 
            // Addresstb
            // 
            this.Addresstb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Addresstb.Location = new System.Drawing.Point(184, 354);
            this.Addresstb.MaxLength = 150;
            this.Addresstb.Multiline = true;
            this.Addresstb.Name = "Addresstb";
            this.Addresstb.Size = new System.Drawing.Size(165, 78);
            this.Addresstb.TabIndex = 3;
            this.Addresstb.Text = "Enter your Address";
            this.Addresstb.Enter += new System.EventHandler(this.Addresstb_Enter);
            this.Addresstb.Leave += new System.EventHandler(this.Addresstb_Leave);
            // 
            // Fnametb
            // 
            this.Fnametb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Fnametb.Location = new System.Drawing.Point(184, 226);
            this.Fnametb.MaxLength = 30;
            this.Fnametb.Name = "Fnametb";
            this.Fnametb.Size = new System.Drawing.Size(165, 23);
            this.Fnametb.TabIndex = 2;
            this.Fnametb.Text = "Enter your Father\'s Name";
            this.Fnametb.Enter += new System.EventHandler(this.Fnametb_Enter);
            this.Fnametb.Leave += new System.EventHandler(this.Fnametb_Leave);
            // 
            // AccNametb
            // 
            this.AccNametb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AccNametb.Location = new System.Drawing.Point(184, 162);
            this.AccNametb.MaxLength = 25;
            this.AccNametb.Name = "AccNametb";
            this.AccNametb.Size = new System.Drawing.Size(165, 23);
            this.AccNametb.TabIndex = 1;
            this.AccNametb.Text = "Enter your Full Name";
            this.AccNametb.Enter += new System.EventHandler(this.AccNametb_Enter);
            this.AccNametb.Leave += new System.EventHandler(this.AccNametb_Leave);
            // 
            // AccNumtb
            // 
            this.AccNumtb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AccNumtb.Location = new System.Drawing.Point(184, 98);
            this.AccNumtb.MaxLength = 13;
            this.AccNumtb.Name = "AccNumtb";
            this.AccNumtb.Size = new System.Drawing.Size(165, 23);
            this.AccNumtb.TabIndex = 0;
            this.AccNumtb.Text = "National ID card number";
            this.AccNumtb.Enter += new System.EventHandler(this.AccNumtb_Enter);
            this.AccNumtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AccNumtb_KeyPress);
            this.AccNumtb.Leave += new System.EventHandler(this.AccNumtb_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 450);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 13);
            this.panel2.TabIndex = 27;
            // 
            // Passwordtb
            // 
            this.Passwordtb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Passwordtb.Location = new System.Drawing.Point(441, 226);
            this.Passwordtb.MaxLength = 50;
            this.Passwordtb.Name = "Passwordtb";
            this.Passwordtb.Size = new System.Drawing.Size(200, 23);
            this.Passwordtb.TabIndex = 6;
            this.Passwordtb.Text = "Enter your desired Password";
            this.Passwordtb.Enter += new System.EventHandler(this.Passwordtb_Enter);
            this.Passwordtb.Leave += new System.EventHandler(this.Passwordtb_Leave);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(437, 392);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 32);
            this.button3.TabIndex = 9;
            this.button3.Text = "Login";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // emailtb
            // 
            this.emailtb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emailtb.Location = new System.Drawing.Point(184, 290);
            this.emailtb.MaxLength = 50;
            this.emailtb.Name = "emailtb";
            this.emailtb.Size = new System.Drawing.Size(165, 23);
            this.emailtb.TabIndex = 28;
            this.emailtb.Text = "Enter your email";
            this.emailtb.Enter += new System.EventHandler(this.textBox1_Enter);
            this.emailtb.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.emailtb);
            this.Controls.Add(this.Passwordtb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.AccNumtb);
            this.Controls.Add(this.AccNametb);
            this.Controls.Add(this.Fnametb);
            this.Controls.Add(this.Addresstb);
            this.Controls.Add(this.Phonetb);
            this.Controls.Add(this.Usernametb);
            this.Controls.Add(this.Occupationtb);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Accounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounts";
            this.Enter += new System.EventHandler(this.Accounts_Enter);
            this.Leave += new System.EventHandler(this.Accounts_Leave);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private TextBox Occupationtb;
        private TextBox Usernametb;
        private TextBox Phonetb;
        private TextBox Addresstb;
        private TextBox Fnametb;
        private TextBox AccNametb;
        private TextBox AccNumtb;
        private Panel panel2;
        private Button button2;
        private TextBox Passwordtb;
        private Button button3;
        private TextBox emailtb;
    }
}