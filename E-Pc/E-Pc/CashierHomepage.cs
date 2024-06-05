using System;
using System.Windows.Forms;

namespace E_Pc
{
    public partial class CashierHomepage : Form
    {
        public CashierHomepage()
        {
            InitializeComponent();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            using(CashierOrderPage orderPage = new CashierOrderPage())
            {
                // will display the Orders page for cashier
                orderPage.ShowDialog();
                this.Hide();
            }
        }
    }
}
