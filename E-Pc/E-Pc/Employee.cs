using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace E_Pc
{
    public partial class Employee : Form
    {

        static SqlCommand cmd;
        public Employee()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            PageObjects.addEmployeePage.Show();
            this.Hide();
        }

        private void EmployeeManagementPage_Load(object sender, EventArgs e)
        {
            ShowTable();
        }

        void ShowTable()
        {
            cmd = new SqlCommand("SELECT * FROM Employees", DataConnection.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            PageObjects.employeeTable.Clear();
            adapter.Fill(PageObjects.employeeTable);
            EmployeeGrid.DataSource = PageObjects.employeeTable;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult exitDiag = MessageBox.Show("Are you sure you want to exit the application?", "Exit Application?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitDiag == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            PageObjects.inventoryPage.Show();
            this.Hide();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            PageObjects.updateEmployeePage.Show();
            this.Hide();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            PageObjects.removeEmployeePage.Show();
            this.Hide();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchBox.Text.Equals("Search here.."))
            {
                SearchBox.Clear();
            }

            cmd = new SqlCommand("SELECT * FROM Employees WHERE " +
                $"EmpId LIKE '%{SearchBox.Text}' " +
                $"OR FirstName LIKE '%{SearchBox.Text}%' " +
                $"OR LastName LIKE '%{SearchBox.Text}%' " +
                $"OR Age LIKE '{SearchBox.Text}%' " +
                $"OR Birthdate LIKE '%{SearchBox.Text}%' " +
                $"OR ContactNum LIKE '{SearchBox.Text}%' " +
                $"OR Position LIKE '%{SearchBox.Text}%' " +
                $"OR Address LIKE '%{SearchBox.Text}%'", DataConnection.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            PageObjects.employeeTable.Clear();
            adapter.Fill(PageObjects.employeeTable);
            EmployeeGrid.DataSource = PageObjects.employeeTable;
        }
    }
}
