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
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblVisa = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.lblAmount);
            this.panel2.Controls.Add(this.lblNumber);
            this.panel2.Controls.Add(this.lblVisa);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 113);
            this.panel2.TabIndex = 3;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAmount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAmount.Location = new System.Drawing.Point(6, 73);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(67, 20);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "$690.42";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNumber.Location = new System.Drawing.Point(4, 98);
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
        private Label lblAmount;
        private Label lblNumber;
        private Label lblVisa;
    }
}
