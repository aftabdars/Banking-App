namespace AtmManagementSystem
{
    partial class ChangeEmail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.newEmail = new System.Windows.Forms.TextBox();
            this.prevEmail = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.settingsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.button1);
            this.settingsPanel.Controls.Add(this.button3);
            this.settingsPanel.Controls.Add(this.newEmail);
            this.settingsPanel.Controls.Add(this.prevEmail);
            this.settingsPanel.Controls.Add(this.pass);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.settingsPanel.Location = new System.Drawing.Point(0, 58);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(447, 402);
            this.settingsPanel.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(170, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(170, 304);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // newEmail
            // 
            this.newEmail.Location = new System.Drawing.Point(121, 133);
            this.newEmail.Name = "newEmail";
            this.newEmail.Size = new System.Drawing.Size(200, 23);
            this.newEmail.TabIndex = 1;
            this.newEmail.Text = "New Email";
            this.newEmail.Enter += new System.EventHandler(this.textBox4_Enter);
            this.newEmail.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // prevEmail
            // 
            this.prevEmail.Location = new System.Drawing.Point(121, 63);
            this.prevEmail.Name = "prevEmail";
            this.prevEmail.Size = new System.Drawing.Size(200, 23);
            this.prevEmail.TabIndex = 1;
            this.prevEmail.Text = "Previous Email";
            this.prevEmail.Enter += new System.EventHandler(this.textBox2_Enter);
            this.prevEmail.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(121, 192);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(200, 23);
            this.pass.TabIndex = 1;
            this.pass.Text = "Password";
            this.pass.Enter += new System.EventHandler(this.textBox1_Enter);
            this.pass.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 65);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email Settings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangeEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.panel1);
            this.Name = "ChangeEmail";
            this.Size = new System.Drawing.Size(447, 460);
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel settingsPanel;
        private TextBox newEmail;
        private TextBox prevEmail;
        private TextBox pass;
        private Panel panel1;
        private Label label1;
        private Button button1;
        private Button button3;
    }
}
