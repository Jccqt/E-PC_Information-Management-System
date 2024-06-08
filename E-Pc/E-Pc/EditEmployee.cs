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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace E_Pc
{
    public partial class EditEmployee : UserControl
    {
        static bool isNewImage = false;
        static byte[] imageBinary;
        public EditEmployee()
        {
            InitializeComponent();
            ActivityLabel.Text = "Viewing";
        }

        private void EditEmployee_Load(object sender, EventArgs e)
        {
            DataConnection.conn.Open();

            DataConnection.cmd = new SqlCommand("SELECT FirstName, LastName, Age, Birthdate, ContactNum, Position, Address," +
                "Username, Password, EmpImage " +
                "FROM Employees WHERE EmpId = @id", DataConnection.conn);
            DataConnection.cmd.Parameters.AddWithValue("@id", Employee.empIdCount);
            DataConnection.reader = DataConnection.cmd.ExecuteReader();

            if (DataConnection.reader.Read())
            {
                IdLabel.Text = Employee.empIdCount.ToString();
                FirstNameBox.Text = DataConnection.reader.GetString(0);
                LastNameBox.Text = DataConnection.reader.GetString(1);
                AgeBox.Text = DataConnection.reader.GetValue(2).ToString();
                BirthdateBox.Text = Convert.ToDateTime(DataConnection.reader.GetValue(3)).ToString("dd/MM/yyyy");
                ContactBox.Text = DataConnection.reader.GetString(4);
                PositionBox.Text = DataConnection.reader.GetString(5);
                AddressBox.Text = DataConnection.reader.GetValue(6).ToString();
                UsernameBox.Text = DataConnection.reader.GetString(7);
                PasswordBox.Text = DataConnection.reader.GetString(8);

                if (!DataConnection.reader.GetValue(9).ToString().Equals(""))
                {
                    byte[] imageBinary = (byte[])DataConnection.reader.GetValue(9);
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
            DialogResult saveDialog = MessageBox.Show("Are you sure you want to save details?", "Save details", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(saveDialog == DialogResult.Yes)
            {
                DataConnection.conn.Open();
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
                DataConnection.conn.Close();
            }
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
