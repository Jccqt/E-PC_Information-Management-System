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

namespace Customer
{
    public partial class CodeGenerator : UserControl
    {
        public CodeGenerator()
        {
            InitializeComponent();
        }

        private void CodeGenerator_Load(object sender, EventArgs e)
        {
            DataConnection.conn.Open();

            DataConnection.cmd = new SqlCommand("SELECT CartId FROM Carts ORDER BY CartId DESC", DataConnection.conn);
            OrderCodeLabel.Text = DataConnection.cmd.ExecuteScalar().ToString();

            DataConnection.conn.Close();
        }

    }
}
