using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void BuyPartsBtn_Click(object sender, EventArgs e)
        {
            using (BuyItems buyItemPage  = new BuyItems())
            {
                buyItemPage.ShowDialog();
                this.Hide();
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
