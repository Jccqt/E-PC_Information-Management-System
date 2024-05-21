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
    public partial class EmployeeManagementPage : Form
    {
        static AddEmployee addEmpPage = new AddEmployee();
        static SqlConnection conn = new SqlConnection(DataConnection.sqlCon);
        static SqlCommand cmd;
        static DataTable employeeTable = new DataTable();
        public EmployeeManagementPage()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            addEmpPage.Show();
            this.Hide();
        }

        private void EmployeeManagementPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_E_PCdbDataSet_Employees.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this._E_PCdbDataSet_Employees.Employees);

        }

        void ShowData()
        {
            cmd = new SqlCommand();
        }
    }
}
