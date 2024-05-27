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
    public partial class RemoveEmployee : Form
    {
        static SqlCommand cmd;
        static bool isExisting = false, isTextEmpty = false, isLogin = false;
        public RemoveEmployee()
        {
            InitializeComponent();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string removeId = "";

            DataConnection.conn.Open();


            if (EmpIdBox.Text.Equals(""))
            {
                isTextEmpty = true;
            }
            else
            {
                isTextEmpty = false;
            }

            if(isExisting && !isTextEmpty)
            {
                DialogResult removeDialog = MessageBox.Show("Are you sure you want to remove the employee?", "Remove Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(removeDialog == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO Removed_Employees (EmpId, FirstName, LastName, Age, Birthdate, ContactNum, Position, Address) " +
                        "SELECT EmpId, FirstName, LastName, Age, Birthdate, ContactNum, Position, Address FROM Employees WHERE EmpId = @id", DataConnection.conn);
                    cmd.Parameters.AddWithValue("@id", EmpIdBox.Text);
                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("SELECT RemovedId FROM Removed_Employees ORDER BY RemovedId DESC", DataConnection.conn);
                    removeId = cmd.ExecuteScalar().ToString();

                    cmd = new SqlCommand("UPDATE Removed_Employees SET Memo = @memo WHERE RemovedId = @removedId", DataConnection.conn);
                    cmd.Parameters.AddWithValue("@memo", MemoBox.Text);
                    cmd.Parameters.AddWithValue("@removedId", removeId);
                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("DELETE FROM Employees WHERE EmpId = @id", DataConnection.conn);
                    cmd.Parameters.AddWithValue("@id", EmpIdBox.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Employee has been removed successfully!", "Employee Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ShowRemovedData();
                    EmpIdBox.Clear();
                    MemoBox.Clear();
                    isExisting = false;
                    isTextEmpty = false;
                    CheckPic.Visible = false;

                }
            }
            else
            {
                MessageBox.Show("Please verify the employee first!", "Employee not verified", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataConnection.conn.Close();
        }

        private void VerifyBtn_Click(object sender, EventArgs e)
        {
            DataConnection.conn.Open();
            var localDate = DateTime.Now.ToString("dd/mm/yyyy hh:ss tt");

            cmd = new SqlCommand("SELECT EmpId FROM Employees WHERE EmpId = @id", DataConnection.conn);
            cmd.Parameters.AddWithValue("@id", EmpIdBox.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            if(reader.Read())
            {
                isExisting = true;
                CheckPic.Visible = true;
                MemoBox.Text = $"Removed on {localDate} - ";
                MessageBox.Show("Employee has been found!", "Employee exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                isExisting = false;
                CheckPic.Visible = false;
                MessageBox.Show("Employee is not existing!", "Employee do not exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            reader.Close();
            DataConnection.conn.Close();
        }

        void ShowRemovedData()
        {
            cmd = new SqlCommand("SELECT * FROM Removed_Employees", DataConnection.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            PageObjects.removedEmployeeTable.Clear();
            adapter.Fill(PageObjects.removedEmployeeTable);
            RemovedEmployeeGrid.DataSource = PageObjects.removedEmployeeTable;
        }

        private void RemoveEmployee_Load(object sender, EventArgs e)
        {
            ShowRemovedData();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EmpIdBox_TextChanged(object sender, EventArgs e)
        {
            if (isExisting)
            {
                isExisting = false;
                MemoBox.Clear();
                CheckPic.Visible = false;
            }
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            PageObjects.employeePage.Show();
            this.Hide();
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            PageObjects.inventoryPage.Show();
            this.Hide();
        }
    }
}
