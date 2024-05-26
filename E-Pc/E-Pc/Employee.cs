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
    }
}
