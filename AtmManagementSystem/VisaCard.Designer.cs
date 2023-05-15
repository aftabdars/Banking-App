namespace AtmManagementSystem
{
    partial class VisaCard
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
            this.lblCVV = new System.Windows.Forms.Label();
            this.lblExpiry = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblVisa = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.lblCVV);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.lblExpiry);
            this.panel2.Controls.Add(this.lblNumber);
            this.panel2.Controls.Add(this.lblVisa);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 113);
            this.panel2.TabIndex = 3;
            // 
            // lblCVV
            // 
            this.lblCVV.AutoSize = true;
            this.lblCVV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCVV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCVV.Location = new System.Drawing.Point(181, 73);
            this.lblCVV.Name = "lblCVV";
            this.lblCVV.Size = new System.Drawing.Size(36, 20);
            this.lblCVV.TabIndex = 2;
            this.lblCVV.Text = "123";
            this.lblCVV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblExpiry
            // 
            this.lblExpiry.AutoSize = true;
            this.lblExpiry.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExpiry.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblExpiry.Location = new System.Drawing.Point(105, 73);
            this.lblExpiry.Name = "lblExpiry";
            this.lblExpiry.Size = new System.Drawing.Size(70, 20);
            this.lblExpiry.TabIndex = 2;
            this.lblExpiry.Text = "02/2024";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNumber.Location = new System.Drawing.Point(113, 95);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(100, 15);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "**** **** **** 1234";
            // 
            // lblVisa
            // 
            this.lblVisa.AutoSize = true;
            this.lblVisa.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblVisa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVisa.Location = new System.Drawing.Point(3, 0);
            this.lblVisa.Name = "lblVisa";
            this.lblVisa.Size = new System.Drawing.Size(46, 21);
            this.lblVisa.TabIndex = 0;
            this.lblVisa.Text = "VISA";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblName.Location = new System.Drawing.Point(6, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "John Doe";
            // 
            // VisaCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panel2);
            this.Name = "VisaCard";
            this.Size = new System.Drawing.Size(230, 114);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        public Label lblExpiry;
        public Label lblNumber;
        public Label lblVisa;
        public Label lblCVV;
        public Label lblName;
    }
}
