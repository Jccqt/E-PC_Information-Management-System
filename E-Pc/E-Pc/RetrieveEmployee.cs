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

namespace E_Pc
{
    public partial class RetrieveEmployee : UserControl
    {
        public RetrieveEmployee()
        {
            InitializeComponent();
        }

        private void RetrieveBtn_Click(object sender, EventArgs e)
        {
            DialogResult retrieveDialog = MessageBox.Show("Are you sure you want to retrieve this employee?", "Retrieve item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(retrieveDialog == DialogResult.Yes)
            {
                DataConnection.conn.Open();

                DataConnection.cmd = new SqlCommand("UPDATE Employees SET Active_flag = 1 WHERE EmpId = @id", DataConnection.conn);
                DataConnection.cmd.Parameters.AddWithValue("@id", Employee.empIdCount);
                DataConnection.cmd.ExecuteNonQuery();

                MessageBox.Show("Employee has been successfully retrieved!");
                PageObjects.employeePage.ShowActiveEmployees();
                DataConnection.conn.Close();
                ((Form)this.TopLevelControl).Close();
            }
        }

        private void RetrieveEmployee_Load(object sender, EventArgs e)
        {
            DataConnection.conn.Open();

            DataConnection.cmd = new SqlCommand("SELECT EmpId, FirstName, LastName, Position, ContactNum, EmpImage FROM Employees WHERE EmpId = @id", DataConnection.conn);
            DataConnection.cmd.Parameters.AddWithValue("@id", Employee.empIdCount);
            DataConnection.reader = DataConnection.cmd.ExecuteReader();

            if (DataConnection.reader.Read())
            {
                IdLabel.Text = DataConnection.reader.GetValue(0).ToString();
                NameLabel.Text = $"{DataConnection.reader.GetString(1)} {DataConnection.reader.GetString(2)}";
                PositionLabel.Text = DataConnection.reader.GetValue(3).ToString();
                ContactLabel.Text = DataConnection.reader.GetValue(4).ToString();

                if (!DataConnection.reader.GetValue(5).ToString().Equals(""))
                {
                    byte[] imageBinary = (byte[])DataConnection.reader.GetValue(5);
                    using (MemoryStream ms = new MemoryStream(imageBinary))
                    {
                        EmpImage.Image = Image.FromStream(ms);
                        EmpImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    Array.Clear(imageBinary, 0, imageBinary.Length);
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
    }
}
