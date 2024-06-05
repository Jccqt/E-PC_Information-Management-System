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

namespace E_Pc
{
    public partial class AddEmployee : UserControl
    {
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
    }
}
