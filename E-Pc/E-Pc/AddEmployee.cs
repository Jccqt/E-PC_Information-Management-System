using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Pc
{
    public partial class AddEmployee : Form
    {
        static SqlCommand cmd;
        static string nameToCheck, inputToCheck;
        static bool isExisting = false, isTextEmpty = false;

        public AddEmployee()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult exitDiag = MessageBox.Show("Are you sure you want to exit the application?", "Exit Application?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitDiag == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var localDate = DateTime.Now;

            DataConnection.conn.Open();

            cmd = new SqlCommand("SELECT FirstName, LastName FROM Employees WHERE FirstName = @fName AND LastName = @lName", DataConnection.conn);
            cmd.Parameters.AddWithValue("@fName", FirstNameBox.Text);
            cmd.Parameters.AddWithValue("@lName", LastNameBox.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                isExisting = true;
            }
            else
            {
                isExisting = false;
            }
            reader.Close();

            if (FirstNameBox.Text.Equals("") || LastNameBox.Text.Equals("") || AgeBox.Text.Equals("") || BirthdateBox.Text.Equals("")
                || ContactBox.Text.Equals("") || PositionBox.Text.Equals("") || AddressBox.Text.Equals(""))
            {
                isTextEmpty = true;
            }
            else
            {
                isTextEmpty = false;
            }

            if(!isExisting && !isTextEmpty && Regex.IsMatch(BirthdateBox.Text, InputValidation.datePattern) &&
                Regex.IsMatch(ContactBox.Text, InputValidation.numericPattern) && Regex.IsMatch(AgeBox.Text, InputValidation.numericPattern))
            {
                cmd = new SqlCommand("INSERT INTO Employees Values (@fName, @lName, @age, @birthdate, @contact, @position, @address)", DataConnection.conn);
                cmd.Parameters.AddWithValue("@fName", FirstNameBox.Text);
                cmd.Parameters.AddWithValue("@lName", LastNameBox.Text);
                cmd.Parameters.AddWithValue("@age", AgeBox.Text);
                cmd.Parameters.AddWithValue("@birthdate", Convert.ToDateTime(BirthdateBox.Text));
                cmd.Parameters.AddWithValue("@contact", ContactBox.Text);
                cmd.Parameters.AddWithValue("@position", PositionBox.Text);
                cmd.Parameters.AddWithValue("@address", AddressBox.Text);
                cmd.ExecuteNonQuery();
                ClearTextBox();
                isExisting = false;
                isTextEmpty = false;

                MessageBox.Show("Employee has been added successfully!", "Employee added", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if(isExisting)
            {
                MessageBox.Show("Employee is already existing!", "Employee exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (isTextEmpty)
            {
                MessageBox.Show("Empty details! Please complete the employee details", "Empty details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Invalid input on age, birthdate or contact!" +
                    "\n Please enter a valid age, contact and birthdate (yyyy-mm-dd)", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ShowTable();
            DataConnection.conn.Close();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            PageObjects.employeePage.Show();
            this.Hide();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            ShowTable();
        }

        void ClearTextBox()
        {
            FirstNameBox.Clear();
            LastNameBox.Clear();
            AgeBox.Clear();
            BirthdateBox.Clear();
            ContactBox.Clear();
            PositionBox.Clear();
            AddressBox.Clear();
        }

        void ShowTable()
        {
            cmd = new SqlCommand("SELECT * FROM Employees", DataConnection.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            PageObjects.employeeTable.Clear();
            adapter.Fill(PageObjects.employeeTable);
            EmployeeGrid.DataSource = PageObjects.employeeTable;
        }
    }
}
