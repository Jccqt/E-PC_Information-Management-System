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
        public AdminReports()
        {
            InitializeComponent();
            TopSalesHeader salesHeader = new TopSalesHeader();
            SalesPanel.Controls.Add(salesHeader);
        }

        private void AdminReports_Load(object sender, EventArgs e)
        {
            #region Add months
            for(int i = 1; i <= 12; i++)
            {
                SalesMonth.Items.Add(i);
                EmployeeMonth.Items.Add(i);
            }
            #endregion

            #region Add years
            for (int i = 2024; i <= 2034; i++)
            {
                SalesYear.Items.Add(i);
                EmployeeYear.Items.Add(i);
            }
            #endregion

            SalesYear.SelectedItem = Convert.ToInt32(DateTime.Now.Year);
            SalesMonth.SelectedItem = Convert.ToInt32(DateTime.Now.Month);
            EmployeeYear.SelectedItem = Convert.ToInt32(DateTime.Now.Year);
            EmployeeMonth.SelectedItem = Convert.ToInt32(DateTime.Now.Month);

            DataConnection.conn.Open();
            ShowAudit();
            ShowTopSales();
            ShowTopEmployee();
            DataConnection.conn.Close();
        }

        private void ShowAudit()
        {
            AuditTrailHeader auditHeader = new AuditTrailHeader();
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

        private void ShowTopEmployee()
        {
            TopEmployeeHeader employeeHeader = new TopEmployeeHeader();
            EmployeePanel.Controls.Clear();
            EmployeePanel.Controls.Add(employeeHeader);

            int counter = 1;

            DataConnection.cmd = new SqlCommand("SELECT EmpId, SUM(SalesAmount), SUM(SalesQuantity) FROM Employee_sales " +
                "WHERE Month(SalesDate) = @month AND Year(SalesDate) = @year " +
                "GROUP BY EmpId ORDER BY SUM(SalesAmount) DESC", DataConnection.conn);
            DataConnection.cmd.Parameters.AddWithValue("@month", Convert.ToInt32(EmployeeMonth.SelectedItem));
            DataConnection.cmd.Parameters.AddWithValue("@year", Convert.ToInt32(EmployeeYear.SelectedItem));
            DataConnection.reader = DataConnection.cmd.ExecuteReader();

            while (DataConnection.reader.Read())
            {
                TopEmployee employee = new TopEmployee();
                
                employee.IdLabel.Text = DataConnection.reader.GetValue(0).ToString();
                employee.QuantityLabel.Text = DataConnection.reader.GetValue(2).ToString();
                employee.SalesLabel.Text = DataConnection.reader.GetValue(1).ToString();
                employee.CounterLabel.Text = counter.ToString();

                EmployeePanel.Controls.Add(employee);
                counter++;
            }
            DataConnection.reader.Close();
        }
        private void ShowTopSales()
        {
            TopSalesHeader salesHeader = new TopSalesHeader();
            SalesPanel.Controls.Clear();
            SalesPanel.Controls.Add(salesHeader);

            int counter = 1;
            DataConnection.cmd = new SqlCommand("SELECT Carts.ItemId, SUM(Carts.OrderQuantity), SUM(Carts.OrderPrice), Products.ItemImage " +
                "FROM Carts RIGHT JOIN Products ON Carts.ItemId = Products.ItemId " +
                $"WHERE Carts.Status = @status AND Month(Carts.OrderDate) = @month AND Year(Carts.OrderDate) = @year GROUP BY Carts.ItemId, Products.ItemImage " +
                $"ORDER BY SUM(Carts.OrderPrice) DESC", DataConnection.conn);
            DataConnection.cmd.Parameters.AddWithValue("@status", "Completed");
            DataConnection.cmd.Parameters.AddWithValue("@month", Convert.ToInt32(SalesMonth.SelectedItem));
            DataConnection.cmd.Parameters.AddWithValue("@year", Convert.ToInt32(SalesYear.SelectedItem));
            DataConnection.reader = DataConnection.cmd.ExecuteReader();

            while (DataConnection.reader.Read())
            {
                TopSales sales = new TopSales();

                if (!DataConnection.reader.GetValue(3).ToString().Equals(""))
                {
                    byte[] imageBinary = (byte[])DataConnection.reader.GetValue(3);
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
                sales.SalesLabel.Text = DataConnection.reader.GetValue(2).ToString();
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

        private void SalesMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataConnection.conn.Open();
            ShowTopSales();
            DataConnection.conn.Close();
        }

        private void SalesYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataConnection.conn.Open();
            ShowTopSales();
            DataConnection.conn.Close();
        }

        private void EmployeeMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataConnection.conn.Open();
            ShowTopEmployee();
            DataConnection.conn.Close();
        }

        private void EmployeeYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataConnection.conn.Open();
            ShowTopEmployee();
            DataConnection.conn.Close();
        }
    }
}
