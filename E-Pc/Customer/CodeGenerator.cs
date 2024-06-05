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
using System.Runtime.CompilerServices;

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

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            DialogResult closeDialog = MessageBox.Show("Are you sure you want to close the cart code page?", "Close page", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(closeDialog == DialogResult.Yes)
            {
                MessageBox.Show("Thankyou for order! You can now proceed to cashier");
                PageObjects.buyItemsPage.Show();
                ((Form)this.TopLevelControl).Close(); // will close the cart order page
            }
        }
        
    }
}
