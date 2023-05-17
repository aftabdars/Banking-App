using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtmManagementSystem
{
    public partial class PrintTicket : UserControl
    {
        public PrintTicket()
        {
            InitializeComponent();
        }

        private void PrintHandler()
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            printDialog.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;

            // Set the font and other formatting options for the ticket
            Font font = new Font("Arial", 12);
            Brush brush = Brushes.Black;
            int lineHeight = font.Height + 5;

            // Define the content of the ticket
            string passengerName = Properties.Settings.Default.currentUser;
            string departureLocation = lblLocation.Text;
            string arrivalLocation = lblDestination.Text;
            DateTime departureTime = DateTime.Now;
            string ticketNumber = new Random().ToString();

            // Draw the ticket elements
            graphics.DrawString(lblService + "Ticket", font, brush, new PointF(50, 50));
            graphics.DrawString("Passenger: " + passengerName, font, brush, new PointF(50, 50 + lineHeight));
            graphics.DrawString("Departure: " + departureLocation, font, brush, new PointF(50, 50 + 2 * lineHeight));
            graphics.DrawString("Arrival: " + arrivalLocation, font, brush, new PointF(50, 50 + 3 * lineHeight));
            graphics.DrawString("Departure Time: " + departureTime.ToString(), font, brush, new PointF(50, 50 + 4 * lineHeight));
            graphics.DrawString("Ticket Number: " + ticketNumber, font, brush, new PointF(50, 50 + 5 * lineHeight));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintHandler();

            this.Parent.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Parent.Hide();
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            
        }

        private void lblYear_Enter(object sender, EventArgs e)
        {
            
        }

        private void lblYear_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
