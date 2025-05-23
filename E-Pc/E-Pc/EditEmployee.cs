﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections;
using System.Net.NetworkInformation;

namespace E_Pc
{
    public partial class EditEmployee : UserControl
    {
        static bool hasSameUsername = false;
        static bool isNewImage = false;
        static byte[] imageBinary;
        static ArrayList usernames = new ArrayList();
        public EditEmployee()
        {
            InitializeComponent();
            ActivityLabel.Text = "Viewing";
        }

        private void EditEmployee_Load(object sender, EventArgs e)
        {
            DataConnection.conn.Open();

            DataConnection.cmd = new SqlCommand("SELECT FirstName, LastName, Birthdate, ContactNum, Position, Address," +
                "Username, Password, EmpImage " +
                "FROM Employees WHERE EmpId = @id", DataConnection.conn);
            DataConnection.cmd.Parameters.AddWithValue("@id", Employee.empIdCount);
            DataConnection.reader = DataConnection.cmd.ExecuteReader();

            if (DataConnection.reader.Read())
            {
                IdLabel.Text = Employee.empIdCount.ToString();
                FirstNameBox.Text = DataConnection.reader.GetString(0);
                LastNameBox.Text = DataConnection.reader.GetString(1);
                BirthdateBox.Text = Convert.ToDateTime(DataConnection.reader.GetValue(2)).ToString("yyyy-MM-dd");
                ContactBox.Text = DataConnection.reader.GetString(3);
                PositionBox.Text = DataConnection.reader.GetString(4);
                AddressBox.Text = DataConnection.reader.GetValue(5).ToString();
                UsernameBox.Text = DataConnection.reader.GetString(6);
                PasswordBox.Text = DataConnection.reader.GetString(7);

                if (!DataConnection.reader.GetValue(8).ToString().Equals(""))
                {
                    byte[] imageBinary = (byte[])DataConnection.reader.GetValue(8);
                    using (MemoryStream ms = new MemoryStream(imageBinary))
                    {
                        EmpImage.Image = Image.FromStream(ms);
                        EmpImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    Array.Clear(imageBinary, 0, imageBinary.Length); // will clear the elements of imageBinary array
                }
                else
                {
                    EmpImage.Image = Properties.Resources.Employee_no_image;
                    EmpImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                
            }
            DataConnection.reader.Close();

            var localDate = DateTime.Now.ToString("yyyy-MM-dd");

            // will get the month difference of employee birth date and current date
            DataConnection.cmd = new SqlCommand("SELECT DATEDIFF(month, @birthdate, @currentdate)", DataConnection.conn);
            DataConnection.cmd.Parameters.AddWithValue("@birthdate", Convert.ToDateTime(BirthdateBox.Text));
            DataConnection.cmd.Parameters.AddWithValue("@currentdate", localDate);
            int age = Convert.ToInt32(DataConnection.cmd.ExecuteScalar()) / 12; // will divide to 12 the month difference to get the age

            AgeBox.Text = age.ToString();

            DataConnection.conn.Close();
        }
        
        void DisableTextBox()
        {
            FirstNameBox.Enabled = false;
            LastNameBox.Enabled = false;
            ContactBox.Enabled = false;
            AddressBox.Enabled = false;
            UsernameBox.Enabled = false;
            PasswordBox.Enabled = false;
        }

        void EnableTextBox()
        {
            FirstNameBox.Enabled = true;
            LastNameBox.Enabled = true;
            ContactBox.Enabled = true;
            AddressBox.Enabled = true;
            UsernameBox.Enabled = true;
            PasswordBox.Enabled = true;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            ActivityLabel.Text = "Editing";
            EnableTextBox();
            EditBtn.Visible = false;
            SaveBtn.Visible = true;
            CancelBtn.Visible = true;

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult cancelDialog = MessageBox.Show("Are you sure you want to cancel the edit?" +
                "\nEdit progress will be lost.", "Cancel edit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cancelDialog == DialogResult.Yes)
            {
                ActivityLabel.Text = "Viewing";
                DisableTextBox();
                EditBtn.Visible = true;
                SaveBtn.Visible = false;
                CancelBtn.Visible = false;
                EditEmployee_Load(sender, e);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
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

            if(!FirstNameBox.Text.Equals("") && !LastNameBox.Text.Equals("") && !ContactBox.Text.Equals("") 
                && !UsernameBox.Text.Equals("") && !PasswordBox.Text.Equals("") && !AddressBox.Text.Equals("") && !hasSameUsername)
            {
                DialogResult saveDialog = MessageBox.Show("Are you sure you want to save details?", "Save details", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (saveDialog == DialogResult.Yes)
                {
                    DataConnection.cmd = new SqlCommand("UPDATE Employees SET FirstName = @fName, LastName = @lName, ContactNum = @contact, " +
                        "Address = @address, Username = @username, Password = @password WHERE EmpId = @id", DataConnection.conn);
                    DataConnection.cmd.Parameters.AddWithValue("@id", Employee.empIdCount);
                    DataConnection.cmd.Parameters.AddWithValue("@fName", FirstNameBox.Text);
                    DataConnection.cmd.Parameters.AddWithValue("@lName", LastNameBox.Text);
                    DataConnection.cmd.Parameters.AddWithValue("@contact", ContactBox.Text);
                    DataConnection.cmd.Parameters.AddWithValue("@address", AddressBox.Text);
                    DataConnection.cmd.Parameters.AddWithValue("@username", UsernameBox.Text);
                    DataConnection.cmd.Parameters.AddWithValue("@password", PasswordBox.Text);
                    DataConnection.cmd.ExecuteNonQuery();

                    if (isNewImage)
                    {
                        DataConnection.cmd = new SqlCommand("UPDATE Employees SET EmpImage = @image WHERE EmpId = @id", DataConnection.conn);
                        DataConnection.cmd.Parameters.AddWithValue("@id", Employee.empIdCount);
                        DataConnection.cmd.Parameters.AddWithValue("@image", imageBinary);
                    }

                    MessageBox.Show("Employee details has been updated!");
                    isNewImage = false;
                    ActivityLabel.Text = "Viewing";
                    DisableTextBox();
                    EditBtn.Visible = true;
                    SaveBtn.Visible = false;
                    CancelBtn.Visible = false;
                }
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
            hasSameUsername = false;
            DataConnection.conn.Close();
        }

        private void SelectImageBtn_Click(object sender, EventArgs e)
        {
            if(SelectImage.ShowDialog() == DialogResult.OK)
            {
                EmpImage.Image = Image.FromFile(SelectImage.FileName);
                EmpImage.SizeMode = PictureBoxSizeMode.StretchImage;
                imageBinary = System.IO.File.ReadAllBytes(SelectImage.FileName);
                isNewImage = true;
            }
        }
    }
}
