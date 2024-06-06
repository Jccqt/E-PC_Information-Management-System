using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;

namespace E_Pc
{
    public partial class Employee : Form
    {
        public static int empIdCount = 0;
        public Employee()
        {
            InitializeComponent();
            SortBox.SelectedItem = "Active";
        }

        void ShowActiveEmployees()
        {
            EmployeePanel.Controls.Clear();
            TableLabel.Text = $"{SortBox.SelectedItem} Employees";
            DataConnection.cmd = new SqlCommand("SELECT EmpId, FirstName, LastName, EmpImage FROM Employees " +
                $"WHERE Active_flag = 1 AND (FirstName LIKE '%{SearchBox.Text}%' OR LastName LIKE '%{SearchBox.Text}%')", DataConnection.conn);
            DataConnection.reader = DataConnection.cmd.ExecuteReader();

            while( DataConnection.reader.Read())
            {
                ShowEmployee employee = new ShowEmployee();

                if(!DataConnection.reader.GetValue(3).ToString().Equals(""))
                {
                    byte[] imageBinary = (byte[])DataConnection.reader.GetValue(3);
                    using (MemoryStream ms = new MemoryStream(imageBinary))
                    {
                        employee.EmpImage.Image = Image.FromStream(ms);
                        employee.EmpImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    Array.Clear(imageBinary, 0, imageBinary.Length);
                }
                else
                {
                    employee.EmpImage.Image = Properties.Resources.Employee_no_image;
                    employee.EmpImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                employee.IdLabel.Text = DataConnection.reader.GetValue(0).ToString();
                employee.NameLabel.Text = $"{DataConnection.reader.GetString(1)} {DataConnection.reader.GetString(2)}";

                employee.EmpImage.Tag = DataConnection.reader.GetValue(0);
                employee.DeleteBtn.Tag = DataConnection.reader.GetValue(0);
                EmployeePanel.Controls.Add(employee);
                employee.EmpImage.Click += new EventHandler(ViewEmployee_Click);
                employee.DeleteBtn.Click += new EventHandler(DeleteEmployee_Click);
            }
            DataConnection.reader.Close();
            GC.Collect();

        }

        private void DeleteEmployee_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            empIdCount = Convert.ToInt32(pic.Tag);

            DialogResult deleteDialog = MessageBox.Show("Are you sure you want to remove this employee?" +
                "\nThis employee will be sent to inactive table", "Remove Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (deleteDialog == DialogResult.Yes)
            {
                DataConnection.conn.Open();
                DataConnection.cmd = new SqlCommand("UPDATE Employees SET Active_flag = 0 WHERE EmpId = @id", DataConnection.conn);
                DataConnection.cmd.Parameters.AddWithValue("@id", empIdCount);
                DataConnection.cmd.ExecuteNonQuery();

                MessageBox.Show("Employee has been sent to inactive table");
                ShowActiveEmployees();
                DataConnection.conn.Close();
            }
        }

        void ShowInactiveEmployees()
        {
            EmployeePanel.Controls.Clear();
            TableLabel.Text = $"{SortBox.SelectedItem} Employees";
            DataConnection.cmd = new SqlCommand("SELECT EmpId, FirstName, LastName, EmpImage FROM Employees " +
                $"WHERE Active_flag = 0 AND (FirstName LIKE '%{SearchBox.Text}%' OR LastName LIKE '%{SearchBox.Text}%')", DataConnection.conn);
            DataConnection.reader = DataConnection.cmd.ExecuteReader();

            while (DataConnection.reader.Read())
            {
                ShowEmployee employee = new ShowEmployee();

                if (!DataConnection.reader.GetValue(3).ToString().Equals(""))
                {
                    byte[] imageBinary = (byte[])DataConnection.reader.GetValue(3);
                    using (MemoryStream ms = new MemoryStream(imageBinary))
                    {
                        employee.EmpImage.Image = Image.FromStream(ms);
                        employee.EmpImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    Array.Clear(imageBinary, 0, imageBinary.Length);
                }
                else
                {
                    employee.EmpImage.Image = Properties.Resources.Employee_no_image;
                    employee.EmpImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                employee.IdLabel.Text = DataConnection.reader.GetValue(0).ToString();
                employee.NameLabel.Text = $"{DataConnection.reader.GetString(1)} {DataConnection.reader.GetString(2)}";

                EmployeePanel.Controls.Add(employee);
            }
            DataConnection.reader.Close();
            GC.Collect();
        }

        private void ViewEmployee_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            empIdCount = Convert.ToInt32(pic.Tag);
            Form form = new Form();
            form.Controls.Add(new EditEmployee());
            form.StartPosition = FormStartPosition.CenterScreen;
            form.AutoSize = true;
            form.ShowDialog();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            // will show a warning message before exiting the application
            DialogResult exitDialog = MessageBox.Show("Are you sure you want to close the program?" +
                "\nAny unsaved progress will be lost.", "Close application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (exitDialog == DialogResult.Yes)
            {
                Application.Exit(); // will terminate the application
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Controls.Add(new AddEmployee());
            form.ClientSize = new System.Drawing.Size(874, 392);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void SortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataConnection.conn.Open();

            if (SortBox.SelectedItem.Equals("Active"))
            {
                ShowActiveEmployees();
            }
            else
            {
                ShowInactiveEmployees();
            }

            DataConnection.conn.Close();
        }

        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            PageObjects.reportsPage = new AdminReports();
            PageObjects.reportsPage.Show();
            this.Close();
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            PageObjects.inventoryPage = new Inventory();
            PageObjects.inventoryPage.Show();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PageObjects.adminHomePage.Show();
            this.Close();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            DataConnection.conn.Open();
            if (SortBox.SelectedItem.Equals("Active"))
            {
                ShowActiveEmployees();
            }
            else
            {
                ShowInactiveEmployees();
            }
            DataConnection.conn.Close();
        }
    }
}
