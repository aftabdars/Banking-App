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

namespace WinFormsApp2
{
    public partial class UserControl1 : UserControl
    {
        private DataTable getTransactions()
        {
            DataTable dataTable = new();
            string connString = AtmManagementSystem.Properties.Settings.Default.databasePath;
            string query = "select * from [dbo].[Transactions] where Username = '" + AtmManagementSystem.Properties.Settings.Default.currentUser + "'";

            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(dataTable);
            conn.Close();
            da.Dispose();

            transactionsView.DataSource = dataTable;

            return dataTable;
        }

        public UserControl1()
        {
            InitializeComponent();
            getTransactions();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dTable = getTransactions();
            PrintDocument document = new PrintDocument();
            document.PrintPage += new PrintPageEventHandler(document_PrintPage);

            PrintPreviewDialog ppDialog = new PrintPreviewDialog();
            ppDialog.Document = document;
            ppDialog.Show();
            void document_PrintPage(object sender, PrintPageEventArgs e)
            {
                PrintDocument document = (PrintDocument)sender;
                Graphics g = e.Graphics;

                Brush brush = new SolidBrush(Color.FromArgb(86, 137, 176));
                Pen pen = new Pen(brush);
                Font font = new Font("Arial", 8);


                //FoRMATS/////////////////////////

                StringFormat formatLeft = new StringFormat(StringFormatFlags.NoClip);
                StringFormat formatCenter = new StringFormat(formatLeft);
                StringFormat formatRight = new StringFormat(formatLeft);

                formatCenter.Alignment = StringAlignment.Center;
                formatRight.Alignment = StringAlignment.Far;
                formatLeft.Alignment = StringAlignment.Near;

                //GET TOTALS AND NAME////////////
                string connString = AtmManagementSystem.Properties.Settings.Default.databasePath;
                string query = "select Name from [dbo].[Accounts.tb] where Username = '" + AtmManagementSystem.Properties.Settings.Default.currentUser + "'";

                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                string name = (string)cmd.ExecuteScalar();

                var sumIncome = dTable.AsEnumerable()
                //.Where(x => x.Field<String>("Type") == "incoming")
                .Where(x => x.Field<String>("Type").Trim() == "incoming")
                .Sum(x => x.Field<int>("Amount"))
                .ToString(); // 30

                var sumExpense = dTable.AsEnumerable()
                    .Where(x => x.Field<String>("Type").Trim() == "outgoing")
                    .Sum(x => x.Field<int>("Amount"))
                    .ToString(); // 30
                //CREATE HEADINGS And TOTALS///////


                g.DrawString("BANKING MANAGEMENET SYSTEM", new Font("Arial", 18, FontStyle.Bold), new SolidBrush(Color.DeepSkyBlue), 420, 5,formatCenter);
                g.DrawString(name + "'s Banking Statement", new Font("Arial", 16, FontStyle.Bold), new SolidBrush(Color.DeepSkyBlue), 420, 30, formatCenter);
                g.DrawString("Total Income: " + sumIncome, new Font("Arial", 10,FontStyle.Bold), new SolidBrush(Color.Black), 10, 85, formatLeft);
                g.DrawString("Total Expense: " + sumExpense, new Font("Arial", 10,FontStyle.Bold), new SolidBrush(Color.Red), 10, 105, formatLeft);

                //CREATE ROWS/////////////////////

                int x = 0, y = 160, width = 122, height = 30;

                foreach (DataColumn column in dTable.Columns)
                {
                    g.DrawRectangle(pen, x, y, width, height);
                    g.FillRectangle(new SolidBrush(Color.DeepSkyBlue),x,y,width,height);
                    SizeF size = g.MeasureString(column.ColumnName, font);
                    float xPadding = (width - size.Width) / 2;

                    g.DrawString(column.ColumnName, new Font("Arial", 10), new SolidBrush(Color.White), x + xPadding, y + 5);
                    x += width;
                }


                x = 0;
                y += 30;
                int columnCount = dTable.Columns.Count;

                foreach (DataRow row in dTable.Rows)
                {
                    int index = dTable.Rows.IndexOf(row);
                    for (int i = 0; i < columnCount; i++)
                    {
                        if( index == 0 || index%2 == 0)
                        {
                            g.DrawRectangle(pen, x, y, width, height);
                            SizeF size = g.MeasureString(row[i].ToString(), font);
                            float xPadding = (width - size.Width) / 2;

                            g.DrawString(row[i].ToString(), font, brush, x + xPadding, y + 5);
                            x += width;
                        }
                        else
                        {
                            g.DrawRectangle(pen, x, y, width, height);
                            g.FillRectangle(brush, x, y, width, height);
                            SizeF size = g.MeasureString(row[i].ToString(), font);
                            float xPadding = (width - size.Width) / 2;

                            g.DrawString(row[i].ToString(), font, new SolidBrush(Color.White), x + xPadding, y + 5);
                            x += width;
                        }
                    }
                    x = 0;
                    y += 30;
                }
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
