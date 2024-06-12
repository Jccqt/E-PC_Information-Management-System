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
using System.Collections;

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
            DialogResult removeItemDialog = MessageBox.Show("Are you sure you want to remove this item from your cart?", "Remove item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(removeItemDialog == DialogResult.Yes)
            {
                BuyItems.totalOrderQuantity -= Convert.ToInt32(BuyItems.orderQuantityList[BuyItems.orderIdList.IndexOf(IdLabel.Text)]);
                BuyItems.orderQuantityList.RemoveAt(this.TabIndex);
                BuyItems.orderIdList.RemoveAt(this.TabIndex);
                PageObjects.cartPage.Close();
                PageObjects.buyItemsPage.CartBtn_Click(sender, e);
            }
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            getPrice();
            QuantityLabel.Text = (Convert.ToInt32(QuantityLabel.Text) + 1).ToString();
            PriceLabel.Text = $"P{(itemPrice * Convert.ToInt32(QuantityLabel.Text))}";

            BuyItems.orderQuantityList.RemoveAt(this.TabIndex);
            BuyItems.orderQuantityList.Insert(this.TabIndex, Convert.ToInt32(QuantityLabel.Text));
            BuyItems.totalOrderQuantity++;
            BuyItems.totalOrderPrice += itemPrice;

            PageObjects.cartPage.TotalQuantityLabel.Text = BuyItems.totalOrderQuantity.ToString();
            PageObjects.cartPage.TotalAmountLabel.Text = $"P{BuyItems.totalOrderPrice}";
        }
        
        void getPrice()
        {
            DataConnection.conn.Open();
            DataConnection.cmd = new SqlCommand("SELECT ItemPrice FROM Products WHERE ItemId = @id", DataConnection.conn);
            DataConnection.cmd.Parameters.AddWithValue("@id", IdLabel.Text);
            itemPrice = Convert.ToDecimal(DataConnection.cmd.ExecuteScalar());
            DataConnection.conn.Close();
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(QuantityLabel.Text) > 1)
            {
                getPrice();
                QuantityLabel.Text = (Convert.ToInt32(QuantityLabel.Text) - 1).ToString();
                PriceLabel.Text = $"P{(itemPrice * Convert.ToInt32(QuantityLabel.Text))}";

                BuyItems.orderQuantityList.RemoveAt(this.TabIndex);
                BuyItems.orderQuantityList.Insert(this.TabIndex, Convert.ToInt32(QuantityLabel.Text));
                BuyItems.totalOrderQuantity--;
                BuyItems.totalOrderPrice -= itemPrice;
                PageObjects.cartPage.TotalQuantityLabel.Text = BuyItems.totalOrderQuantity.ToString();
                PageObjects.cartPage.TotalAmountLabel.Text = $"P{BuyItems.totalOrderPrice}";
            }
            else
            {
                MessageBox.Show("You cannot decrease quantity lower than 1");
            }
        }
    }
}
