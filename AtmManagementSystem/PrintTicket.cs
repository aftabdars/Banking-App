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

            PrintPreviewDialog printDialog = new PrintPreviewDialog();
            printDialog.Document = printDocument;
            printDialog.ShowDialog();

           // printDialog.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Graphics graphics = e.Graphics;

            // Set the font and other formatting options for the ticket
            //Font font = new Font("Arial", 12);
            //Brush brush = Brushes.Black;
            //int lineHeight = font.Height + 5;

            // Define the content of the ticket
            //string passengerName = Properties.Settings.Default.currentUser;
            //string departureLocation = lblLocation.Text;
            //string arrivalLocation = lblDestination.Text;
            //DateTime departureTime = DateTime.Now;
            //string ticketNumber = new Random().Next(100000,999999).ToString();

            // Draw the ticket elements
            //graphics.DrawString(lblService.Text + "Ticket", font, brush, new PointF(50, 50));
            //graphics.DrawString("Passenger: " + passengerName, font, brush, new PointF(50, 50 + lineHeight));
            //graphics.DrawString("Departure: " + departureLocation, font, brush, new PointF(50, 50 + 2 * lineHeight));
            //graphics.DrawString("Arrival: " + arrivalLocation, font, brush, new PointF(50, 50 + 3 * lineHeight));
            //graphics.DrawString("Departure Time: " + departureTime.ToString(), font, brush, new PointF(50, 50 + 4 * lineHeight));
            //graphics.DrawString("Ticket Number: " + ticketNumber, font, brush, new PointF(50, 50 + 5 * lineHeight));

            Graphics graphics = e.Graphics;
            Font font = new Font("Arial", 12);

            int startX = 50;
            int startY = 150;
            int boxWidth = 750;
            int boxHeight = 20;
            int lineSpacing = 30;
            int labelSpacing = 120; // Adjust this for horizontal spacing

            string passengerName = Properties.Settings.Default.currentUser;
            string flightNumber = new Random().Next(11111111, 99999999).ToString();
            string departureCity = lblLocation.Text;
            string destinationCity = lblDestination.Text;
            DateTime time = DateTime.Now.AddDays(2.4);
            string departureTime = time.ToString();
            //string arrivalTime = time.AddHours(4.3).ToString();
            //string seatNumber = "A10";

            // Draw boxes
            graphics.FillRectangle(new SolidBrush(Color.DarkGray), startX, 50, boxWidth, boxHeight+30);
            graphics.DrawRectangle(Pens.Black, startX, startY, boxWidth, boxHeight);
            graphics.DrawRectangle(Pens.Black, startX, startY + lineSpacing, boxWidth, boxHeight);
            graphics.DrawRectangle(Pens.Black, startX, startY + lineSpacing * 2, boxWidth, boxHeight);
            graphics.DrawRectangle(Pens.Black, startX, startY + lineSpacing * 3, boxWidth, boxHeight);
            graphics.DrawRectangle(Pens.Black, startX, startY + lineSpacing * 4, boxWidth, boxHeight);

            // Draw text
            graphics.DrawString(lblService.Text + " Ticket", new Font("Arial", 17), Brushes.Black, 400, 70, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            graphics.DrawString("Passenger Name:", font, Brushes.Black, startX, startY);
            graphics.DrawString("Flight Number:", font, Brushes.Black, startX, startY + lineSpacing);
            graphics.DrawString("Departure City:", font, Brushes.Black, startX, startY + lineSpacing * 2);
            graphics.DrawString("Destination City:", font, Brushes.Black, startX, startY + lineSpacing * 3);
            graphics.DrawString("Departure Time:", font, Brushes.Black, startX, startY + lineSpacing * 4);

            // Draw centered text inside boxes with horizontal spacing
            graphics.DrawString(passengerName, font, Brushes.Black, new Rectangle(startX + labelSpacing, startY, boxWidth, boxHeight), new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            graphics.DrawString(flightNumber, font, Brushes.Black, new Rectangle(startX + labelSpacing, startY + lineSpacing, boxWidth, boxHeight), new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            graphics.DrawString(departureCity, font, Brushes.Black, new Rectangle(startX + labelSpacing, startY + lineSpacing * 2, boxWidth, boxHeight), new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            graphics.DrawString(destinationCity, font, Brushes.Black, new Rectangle(startX + labelSpacing, startY + lineSpacing * 3, boxWidth, boxHeight), new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            graphics.DrawString(departureTime, font, Brushes.Black, new Rectangle(startX + labelSpacing, startY + lineSpacing * 4, boxWidth, boxHeight), new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
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
            if (lblDestination.Text == "Destination")
            {
                lblDestination.Text = "";
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (lblDestination.Text == "")
            {
                lblDestination.Text = "Destination";
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (lblService.Text == "Service (bus/train/plane)")
            {
                lblService.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (lblService.Text == "")
            {
                lblService.Text = "Service (bus/train/plane)";
            }
        }

        private void lblYear_Enter(object sender, EventArgs e)
        {
            
        }

        private void lblYear_Leave(object sender, EventArgs e)
        {
            
        }

        private void lblLocation_Enter(object sender, EventArgs e)
        {
            if (lblLocation.Text == "Your Location")
            {
                lblLocation.Text = "";
            }
        }

        private void lblLocation_Leave(object sender, EventArgs e)
        {
            if (lblLocation.Text == "")
            {
                lblLocation.Text = "Your Location";
            }
        }
    }
}
