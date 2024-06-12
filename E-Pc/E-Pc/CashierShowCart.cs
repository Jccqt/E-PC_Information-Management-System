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
using Customer;
using System.IO;

namespace E_Pc
{
    public partial class CashierShowCart : Form
    {
        public CashierShowCart()
        {
            InitializeComponent();
        }

        private void CashierShowCart_Load(object sender, EventArgs e)
        {
            // will get the specific element from cartIdList array and insert it to Code label
            CodeLabel.Text = CashierOrderPage.cartIdList[CashierOrderPage.cartIdCount].ToString();

            DataConnection.conn.Open();

            DataConnection.cmd = new SqlCommand("SELECT Carts.ItemId, Carts.OrderQuantity, Carts.OrderPrice, Carts.OrderDate, Carts.Status, " +
                "Products.ItemName, Products.ItemType, Products.Category, Products.ItemDescription, Products.ItemImage " +
                "FROM Carts RIGHT JOIN Products ON Carts.ItemId = Products.ItemId WHERE CartId = @cartId", DataConnection.conn);
            DataConnection.cmd.Parameters.AddWithValue("@cartId", CashierOrderPage.cartIdList[CashierOrderPage.cartIdCount]);
            DataConnection.reader = DataConnection.cmd.ExecuteReader();

            while(DataConnection.reader.Read())
            {
                SelectedItems items = new SelectedItems();

                if (!DataConnection.reader.GetValue(9).ToString().Equals(""))
                {
                    byte[] imageBinary = (byte[])DataConnection.reader.GetValue(9);
                    using (MemoryStream ms = new MemoryStream(imageBinary))
                    {
                        items.ItemImage.Image = Image.FromStream(ms);
                        items.ItemImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    Array.Clear(imageBinary, 0, imageBinary.Length);

                }
                else
                {
                    items.ItemImage.Image = Properties.Resources.no_image_icon;
                    items.ItemImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                items.ItemIdLabel.Text = DataConnection.reader.GetString(0);
                items.QuantityLabel.Text = DataConnection.reader.GetValue(1).ToString();
                items.PriceLabel.Text = DataConnection.reader.GetValue(2).ToString();
                items.NameLabel.Text = DataConnection.reader.GetString(5);
                items.TypeLabel.Text = DataConnection.reader.GetString(6);
                items.CategoryLabel.Text = DataConnection.reader.GetString(7);
                items.DescriptionLabel.Text = DataConnection.reader.GetString(8);

                DateLabel.Text = DataConnection.reader.GetValue(3).ToString();
                StatusLabel.Text = DataConnection.reader.GetString(4);
                CartPanel.Controls.Add(items);
            }
            DataConnection.reader.Close();

            if (StatusLabel.Text.Equals("Completed") || StatusLabel.Text.Equals("Cancelled"))
            {
                // will hide the checkout button if the order was already completed
                CheckoutBtn.Visible = false;
                checkoutArrowBtn.Visible = false;
            }

            DataConnection.cmd = new SqlCommand("SELECT SUM(OrderQuantity) FROM Carts WHERE CartId = @cartId", DataConnection.conn);
            DataConnection.cmd.Parameters.AddWithValue("@cartId", CashierOrderPage.cartIdList[CashierOrderPage.cartIdCount]);
            TotalQuantityLabel.Text = DataConnection.cmd.ExecuteScalar().ToString();

            DataConnection.cmd = new SqlCommand("SELECT SUM(OrderPrice) FROM Carts WHERE CartId = @cartId", DataConnection.conn);
            DataConnection.cmd.Parameters.AddWithValue("@cartId", CashierOrderPage.cartIdList[CashierOrderPage.cartIdCount]);
            TotalAmountLabel.Text = $"P{DataConnection.cmd.ExecuteScalar()}";

            DataConnection.conn.Close();
            GC.Collect();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            PageObjects.cashierOrderPage.Show();
            this.Close();
        }

        private void CheckoutBtn_Click(object sender, EventArgs e)
        {
            PaymentPage payment = new PaymentPage();
            payment.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
