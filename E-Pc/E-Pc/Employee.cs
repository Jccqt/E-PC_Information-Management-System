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
        public Employee()
        {
            InitializeComponent();
        }

        void ShowActiveEmployees()
        {
            DataConnection.conn.Open();

            DataConnection.cmd = new SqlCommand("SELECT EmpId, FirstName, LastName, EmpImage FROM Employees " +
                "WHERE Active_flag = 1", DataConnection.conn);
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

                EmployeePanel.Controls.Add(employee);
            }
            DataConnection.reader.Close();
            DataConnection.conn.Close();

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            ShowActiveEmployees();
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
    }
}
