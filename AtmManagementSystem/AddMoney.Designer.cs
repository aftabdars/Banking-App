namespace AtmManagementSystem
{
    partial class AddMoney
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblYear = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CVV = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.TextBox();
            this.lblMonth = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblYear);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.CVV);
            this.panel2.Controls.Add(this.lblAmount);
            this.panel2.Controls.Add(this.lblMonth);
            this.panel2.Controls.Add(this.lblNumber);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 247);
            this.panel2.TabIndex = 3;
            // 
            // lblYear
            // 
            this.lblYear.Location = new System.Drawing.Point(207, 71);
            this.lblYear.MaxLength = 4;
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(119, 23);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "2024";
            this.lblYear.Enter += new System.EventHandler(this.lblYear_Enter);
            this.lblYear.Leave += new System.EventHandler(this.lblYear_Leave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(170, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(171, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CVV
            // 
            this.CVV.Location = new System.Drawing.Point(170, 103);
            this.CVV.Name = "CVV";
            this.CVV.Size = new System.Drawing.Size(156, 23);
            this.CVV.TabIndex = 5;
            this.CVV.Text = "CVV";
            this.CVV.Enter += new System.EventHandler(this.lblCVV_Enter);
            this.CVV.Leave += new System.EventHandler(this.lblCVV_Leave);
            // 
            // lblAmount
            // 
            this.lblAmount.Location = new System.Drawing.Point(170, 13);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(156, 23);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "Amount";
            this.lblAmount.Enter += new System.EventHandler(this.textBox2_Enter);
            this.lblAmount.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // lblMonth
            // 
            this.lblMonth.Location = new System.Drawing.Point(170, 71);
            this.lblMonth.MaxLength = 2;
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(31, 23);
            this.lblMonth.TabIndex = 3;
            this.lblMonth.Text = "01";
            this.lblMonth.Enter += new System.EventHandler(this.lblMonth_Enter);
            this.lblMonth.Leave += new System.EventHandler(this.lblMonth_Leave);
            // 
            // lblNumber
            // 
            this.lblNumber.Location = new System.Drawing.Point(170, 42);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(156, 23);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "Card Number";
            this.lblNumber.Enter += new System.EventHandler(this.lblNumber_Enter);
            this.lblNumber.Leave += new System.EventHandler(this.lblNumber_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 100);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 100);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Money";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddMoney";
            this.Size = new System.Drawing.Size(500, 347);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Button button2;
        private Button button1;
        private TextBox CVV;
        private TextBox lblAmount;
        private TextBox lblNumber;
        private Panel panel1;
        private Label label1;
        private TextBox lblMonth;
        private TextBox lblYear;
    }
}
