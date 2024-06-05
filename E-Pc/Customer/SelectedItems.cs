using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Customer
{
    public partial class SelectedItems : UserControl
    {
        static decimal itemPrice;
        public SelectedItems()
        {
            InitializeComponent();
            
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            using(BuyItems items = new BuyItems())
            {
                using(CustomerShowCart cart = new CustomerShowCart())
                {
                    BuyItems.totalOrderQuantity = Convert.ToInt32(cart.TotalQuantityLabel.Text)
                    - Convert.ToInt32(BuyItems.orderQuantityList[BuyItems.orderIdList.IndexOf(IdLabel.Text)]);
                    BuyItems.orderQuantityList.Remove(BuyItems.orderQuantityList[BuyItems.orderIdList.IndexOf(IdLabel.Text)]);
                    BuyItems.orderIdList.Remove(IdLabel.Text);
                    this.Dispose();
                    cart.Dispose();
                    items.CartBtn_Click(sender, e);
                }
            }
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            getPrice();
            QuantityLabel.Text = (Convert.ToInt32(QuantityLabel.Text) + 1).ToString();
            PriceLabel.Text = (itemPrice * Convert.ToInt32(QuantityLabel.Text)).ToString();

            BuyItems.orderQuantityList.Insert(BuyItems.orderIdList.IndexOf(IdLabel.Text), Convert.ToInt32(QuantityLabel.Text));

        }
        
        void getPrice()
        {
            DataConnection.conn.Open();
            DataConnection.cmd = new SqlCommand("SELECT ItemPrice FROM Products WHERE ItemId = @id", DataConnection.conn);
            DataConnection.cmd.Parameters.AddWithValue("@id", IdLabel.Text);
            itemPrice = Convert.ToDecimal(DataConnection.cmd.ExecuteScalar());
            DataConnection.conn.Close();
        }
    }
}
