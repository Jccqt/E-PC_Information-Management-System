using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Pc
{
    public partial class CustomerOrderCode : Form
    {
        string code = "code";
        public CustomerOrderCode()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_Click(object sender, EventArgs e)
        {
            CodeTextBox.Text = string.Empty;
        }

        private void CodeTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void VerifyButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
