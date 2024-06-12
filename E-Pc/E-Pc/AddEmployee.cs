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
using System.Collections;

namespace E_Pc
{
    public partial class AddEmployee : UserControl
    {
        static byte[] imageBinary;
        static bool isNewImage = false;
        static bool hasSameUsername = false;
        static ArrayList usernames = new ArrayList();
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void BirthDatePicker_ValueChanged(object sender, EventArgs e)
        {

            var localDate = DateTime.Now.ToString("yyyy-MM-dd");
            DataConnection.conn.Open();

            DataConnection.cmd = new SqlCommand("SELECT DATEDIFF(month, @birthdate, @currentdate)", DataConnection.conn);
            DataConnection.cmd.Parameters.AddWithValue("@birthdate", Convert.ToDateTime(BirthDatePicker.Value.Date.ToString("yyyy-MM-dd")));
            DataConnection.cmd.Parameters.AddWithValue("@currentdate", localDate);
            int yearsDiff = Convert.ToInt32(DataConnection.cmd.ExecuteScalar());
            yearsDiff /= 12;

            AgeBox.Text = yearsDiff.ToString();

            DataConnection.conn.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            DataConnection.conn.Open();

            DataConnection.cmd = new SqlCommand("SELECT Username FROM Employees", DataConnection.conn);
            DataConnection.reader = DataConnection.cmd.ExecuteReader();

            while (DataConnection.reader.Read())
            {
                usernames.Add(DataConnection.reader.GetString(0));
            }
            DataConnection.reader.Close();

            if (usernames.Contains(UsernameBox.Text))
            {
                hasSameUsername = true;
            }
            else
            {
                hasSameUsername = false;
            }
            usernames.Clear();

            if (!FirstNameBox.Text.Equals("") && !LastNameBox.Text.Equals("") && !ContactBox.Text.Equals("")
                && !PositionBox.Text.Equals("") && !AgeBox.Text.Equals("") && !UsernameBox.Text.Equals("")
                && !PasswordBox.Text.Equals("") && !AddressBox.Text.Equals("") && !hasSameUsername)
            {
                // will only add the employee if there is no empty text box

                int idCount = 0;

                DataConnection.cmd = new SqlCommand("INSERT INTO Employees (FirstName, LastName, BirthDate, ContactNum, " +
                    "Position, Address, Username, Password, Active_flag) VALUES (@fName, @lName, @birthDate, " +
                    "@contact, @position, @address, @username, @password, @flag)", DataConnection.conn);
                DataConnection.cmd.Parameters.AddWithValue("@fName", FirstNameBox.Text);
                DataConnection.cmd.Parameters.AddWithValue("@lName", LastNameBox.Text);
                DataConnection.cmd.Parameters.AddWithValue("@birthDate", Convert.ToDateTime(BirthDatePicker.Value.Date.ToString("yyyy-MM-dd")));
                DataConnection.cmd.Parameters.AddWithValue("@contact", ContactBox.Text);
                DataConnection.cmd.Parameters.AddWithValue("@position", PositionBox.Text);
                DataConnection.cmd.Parameters.AddWithValue("@address", AddressBox.Text);
                DataConnection.cmd.Parameters.AddWithValue("@username", UsernameBox.Text);
                DataConnection.cmd.Parameters.AddWithValue("@password", PasswordBox.Text);
                DataConnection.cmd.Parameters.AddWithValue("@flag", 1);
                DataConnection.cmd.ExecuteNonQuery();

                // will get the latest employee ID
                DataConnection.cmd = new SqlCommand("SELECT EmpId FROM Employees ORDER BY EmpId DESC", DataConnection.conn);
                idCount = Convert.ToInt32(DataConnection.cmd.ExecuteScalar());

                if (isNewImage)
                {
                    // will only add image if the user select an image
                    DataConnection.cmd = new SqlCommand("UPDATE Employees SET EmpImage = @image WHERE EmpId = @id", DataConnection.conn);
                    DataConnection.cmd.Parameters.AddWithValue("@id", idCount);
                    DataConnection.cmd.Parameters.AddWithValue("@image", imageBinary);
                    DataConnection.cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Employee has been added successfully!");
                isNewImage = false;
                ClearTextBox();
                ((Form)this.TopLevelControl).Close();
            }
            else if (hasSameUsername)
            {
                MessageBox.Show("The employee username already existing! Please use another unique username", "Username already existing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // will show an error message if there is an empty text box
                MessageBox.Show("You cannot add employee with some empty details", "Empty details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DataConnection.conn.Close();
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

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            DataConnection.conn.Open();

            var localDate = DateTime.Now.ToString("yyyy-MM-dd");

            DataConnection.cmd = new SqlCommand("SELECT DATEADD(year, -18, @currentDate)", DataConnection.conn);
            DataConnection.cmd.Parameters.AddWithValue("@currentDate", localDate);
            var legalAgeDate = Convert.ToDateTime(DataConnection.cmd.ExecuteScalar());

            BirthDatePicker.MaxDate = legalAgeDate;

            DataConnection.conn.Close();
        }
    }
}
