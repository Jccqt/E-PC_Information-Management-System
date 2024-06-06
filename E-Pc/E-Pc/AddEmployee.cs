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
using System.Security.Cryptography;

namespace E_Pc
{
    public partial class AddEmployee : UserControl
    {
        static byte[] imageBinary;
        static bool isNewImage = false;
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void BirthDatePicker_ValueChanged(object sender, EventArgs e)
        {
            var localDate = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
            DataConnection.conn.Open();

            DataConnection.cmd = new SqlCommand("SELECT DATEDIFF(month, @birthdate, @currentdate)", DataConnection.conn);
            DataConnection.cmd.Parameters.AddWithValue("@birthdate", BirthDatePicker.Value.Date);
            DataConnection.cmd.Parameters.AddWithValue("@currentdate", localDate);
            int yearsDiff = Convert.ToInt32(DataConnection.cmd.ExecuteScalar());

            AgeBox.Text = (yearsDiff / 12).ToString();
            DataConnection.conn.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            DataConnection.conn.Open();

            int idCount = 0;

            DataConnection.cmd = new SqlCommand("INSERT INTO Employees (FirstName, LastName, Age, BirthDate, ContactNum, " +
                "Position, Address, Active_flag) VALUES (@fName, @lName, @age, @birthDate, " +
                "@contact, @position, @address, @flag)", DataConnection.conn);
            DataConnection.cmd.Parameters.AddWithValue("@fName", FirstNameBox.Text);
            DataConnection.cmd.Parameters.AddWithValue("@lName", LastNameBox.Text);
            DataConnection.cmd.Parameters.AddWithValue("@age", AgeBox.Text);
            DataConnection.cmd.Parameters.AddWithValue("@birthDate", BirthDatePicker.Value);
            DataConnection.cmd.Parameters.AddWithValue("@contact", ContactBox.Text);
            DataConnection.cmd.Parameters.AddWithValue("@position", PositionBox.Text);
            DataConnection.cmd.Parameters.AddWithValue("@address", AddressBox.Text);
            DataConnection.cmd.Parameters.AddWithValue("@flag", 1);
            DataConnection.cmd.ExecuteNonQuery();

            DataConnection.cmd = new SqlCommand("SELECT EmpId FROM Employees ORDER BY EmpId DESC", DataConnection.conn);
            idCount = Convert.ToInt32(DataConnection.cmd.ExecuteScalar());

            DataConnection.cmd = new SqlCommand("INSERT INTO Credentials (EmpId, Username, Password) VALUES (@empId, @username, @password)", DataConnection.conn);
            DataConnection.cmd.Parameters.AddWithValue("@empId", idCount);
            DataConnection.cmd.Parameters.AddWithValue("@username", UsernameBox.Text);
            DataConnection.cmd.Parameters.AddWithValue("@password", PasswordBox.Text);
            DataConnection.cmd.ExecuteNonQuery();


            if (isNewImage)
            {
                DataConnection.cmd = new SqlCommand("UPDATE Employees SET EmpImage = @image WHERE EmpId = @id", DataConnection.conn);
                DataConnection.cmd.Parameters.AddWithValue("@id", idCount);
                DataConnection.cmd.Parameters.AddWithValue("@image", imageBinary);
                DataConnection.cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Employee has been added successfully!");
            DataConnection.conn.Close();
            isNewImage = false;
            ClearTextBox();
        }

        void ClearTextBox()
        {
            FirstNameBox.Clear();
            LastNameBox.Clear();
            ContactBox.Clear();
            AgeBox.Clear();
            UsernameBox.Clear();
            PasswordBox.Clear();
            AddressBox.Clear();
        }

        private void SelectImageBtn_Click(object sender, EventArgs e)
        {
            if(SelectImage.ShowDialog () == DialogResult.OK)
            {
                EmpImage.Image = Image.FromFile(SelectImage.FileName);
                EmpImage.SizeMode = PictureBoxSizeMode.StretchImage;
                imageBinary = System.IO.File.ReadAllBytes(SelectImage.FileName);
                isNewImage = true;
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }
    }
}
