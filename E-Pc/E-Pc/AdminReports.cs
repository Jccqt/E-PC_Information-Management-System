using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace E_Pc
{
    public partial class AdminReports : Form
    {
        static AuditTrailHeader auditHeader = new AuditTrailHeader();
        public AdminReports()
        {
            InitializeComponent();
            TopSalesHeader salesHeader = new TopSalesHeader();
            SalesPanel.Controls.Add(salesHeader);
        }

        private void AdminReports_Load(object sender, EventArgs e)
        {
            DataConnection.conn.Open();
            ShowAudit();
            ShowTopSales();
            DataConnection.conn.Close();
        }

        private void ShowAudit()
        {
            AuditPanel.Controls.Clear();
            AuditPanel.Controls.Add(auditHeader);
           
            DataConnection.cmd = new SqlCommand($"SELECT * FROM Audit_Trail WHERE YEAR(ActivityDate) = @year AND MONTH(ActivityDate) = @month AND DAY(ActivityDate) = @day", DataConnection.conn);
            DataConnection.cmd.Parameters.AddWithValue("@year", AuditDatePicker.Value.Year);
            DataConnection.cmd.Parameters.AddWithValue("@month", AuditDatePicker.Value.Month);
            DataConnection.cmd.Parameters.AddWithValue("@day", AuditDatePicker.Value.Day);
            DataConnection.reader = DataConnection.cmd.ExecuteReader();
            
            while (DataConnection.reader.Read())
            {
                AuditTrail audit = new AuditTrail();

                audit.ActIdLabel.Text = DataConnection.reader.GetString(0);
                audit.EmpIdLabel.Text = DataConnection.reader.GetValue(1).ToString();
                audit.TypeLabel.Text = DataConnection.reader.GetString(2);
                audit.DescriptionLabel.Text = DataConnection.reader.GetString(3);
                audit.DateLabel.Text = DataConnection.reader.GetValue(4).ToString();

                AuditPanel.Controls.Add(audit);
            }
            DataConnection.reader.Close();
        }

        private void ShowTopSales()
        {
            int counter = 1;
            DataConnection.cmd = new SqlCommand("SELECT Carts.ItemId, SUM(Carts.OrderQuantity), Products.ItemImage " +
                "FROM Carts RIGHT JOIN Products ON Carts.ItemId = Products.ItemId " +
                $"WHERE Carts.Status = @status GROUP BY Carts.ItemId, Products.ItemImage " +
                $"ORDER BY SUM(Carts.OrderQuantity) DESC", DataConnection.conn);
            DataConnection.cmd.Parameters.AddWithValue("@status", "Completed");
            DataConnection.reader = DataConnection.cmd.ExecuteReader();

            while (DataConnection.reader.Read())
            {
                TopSales sales = new TopSales();

                if (!DataConnection.reader.GetValue(2).ToString().Equals(""))
                {
                    byte[] imageBinary = (byte[])DataConnection.reader.GetValue(2);
                    using (MemoryStream ms = new MemoryStream(imageBinary))
                    {
                        sales.ItemImage.Image = Image.FromStream(ms);
                        sales.ItemImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    Array.Clear(imageBinary, 0, imageBinary.Length);
                }
                else
                {
                    sales.ItemImage.Image = Properties.Resources.no_image_icon;
                   sales.ItemImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                sales.CounterLabel.Text = counter.ToString();
                sales.IdLabel.Text = DataConnection.reader.GetString(0);
                sales.QuantityLabel.Text = DataConnection.reader.GetValue(1).ToString();
                SalesPanel.Controls.Add(sales);
                counter++;
            }
            DataConnection.reader.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PageObjects.adminHomePage.Show();
            this.Hide();
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            PageObjects.inventoryPage = new Inventory();
            PageObjects.inventoryPage.Show();
            this.Close();
        }

        private void EmployeeManagementButton_Click(object sender, EventArgs e)
        {
            PageObjects.employeePage = new Employee();
            PageObjects.employeePage.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // will show a warning message before exiting the application
            DialogResult exitDialog = MessageBox.Show("Are you sure you want to close the program?" +
                "\nAny unsaved progress will be lost.", "Close application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (exitDialog == DialogResult.Yes)
            {
                Application.Exit(); // will terminate the application
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            // will show a logout prompt when the user click the Logout icon
            DialogResult logoutDialog = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (logoutDialog == DialogResult.Yes)
            {
                PageObjects.login = new Login();
                // will go back to Login page when the user logs out
                Login.isLogin = false;
                PageObjects.login.Show();
                this.Close();
            }
        }

        private void AuditDatePicker_ValueChanged(object sender, EventArgs e)
        {
            DataConnection.conn.Open();
            ShowAudit();
            DataConnection.conn.Close();
        }
    }
}
