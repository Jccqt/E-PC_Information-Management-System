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
        static bool isExisting = false;
        public RemoveEmployee()
        {
            InitializeComponent();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DataConnection.conn.Open();

            
            
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
