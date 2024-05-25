using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Pc
{
    public partial class Employee : Form
    {

        static SqlConnection conn = new SqlConnection(DataConnection.sqlCon);
        static SqlCommand cmd;
        static DataTable employeeTable = new DataTable();
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
            ShowData();
        }

        void ShowData()
        {
            cmd = new SqlCommand("SELECT * FROM Employees", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            employeeTable.Clear();
            adapter.Fill(employeeTable);
            EmployeeGrid.DataSource = employeeTable;
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
    }
}
