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
using System.Collections;
using Customer;
using System.IO;

namespace E_Pc
{
    public partial class aaaa : UserControl
    {
        static SelectedItems selectedItem;

        public aaaa()
        {
            InitializeComponent();
            CodeLabel.Text = CashierOrderPage.cartIdList[CashierOrderPage.cartIdCount].ToString();
        }

        private void CashierShowCart_Load(object sender, EventArgs e)
        {
            DataConnection.conn.Open();

            DataConnection.cmd = new SqlCommand("SELECT Carts.OrderQuantity, Carts.OrderPrice, Products.ItemName, " +
                "Products.Category, Products.ItemDescription, Products.ItemImage FROM Carts RIGHT JOIN Products ON Carts.ItemId = Products.ItemId WHERE CartId = @cartId", DataConnection.conn);
            DataConnection.cmd.Parameters.AddWithValue("@cartId", CashierOrderPage.cartIdList[CashierOrderPage.cartIdCount]);
            DataConnection.reader = DataConnection.cmd.ExecuteReader();

            while( DataConnection.reader.Read())
            {
                selectedItem = new SelectedItems();

                if (!DataConnection.reader.GetValue(5).ToString().Equals(""))
                {
                    byte[] imageBinary = (byte[])DataConnection.reader.GetValue(5);
                    using (MemoryStream ms = new MemoryStream(imageBinary))
                    {
                        selectedItem.ItemImage.Image = Image.FromStream(ms);
                        selectedItem.ItemImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    Array.Clear(imageBinary, 0, imageBinary.Length);

                }
                else
                {
                    selectedItem.ItemImage.Image = Properties.Resources.no_image_icon;
                    selectedItem.ItemImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                selectedItem.QuantityLabel.Text = DataConnection.reader.GetValue(0).ToString();
                selectedItem.PriceLabel.Text = DataConnection.reader.GetValue(1).ToString();
                selectedItem.NameLabel.Text = DataConnection.reader.GetString(2);
                selectedItem.CategoryLabel.Text = DataConnection.reader.GetString(3);
                selectedItem.DescriptionLabel.Text = DataConnection.reader.GetString(4);

                CartPanel.Controls.Add(selectedItem);
            }
            DataConnection.reader.Close();

            DataConnection.cmd = new SqlCommand("SELECT SUM(OrderQuantity) FROM Carts WHERE CartId = @cartId", DataConnection.conn);
            DataConnection.cmd.Parameters.AddWithValue("@cartId", CashierOrderPage.cartIdList[CashierOrderPage.cartIdCount]);
            TotalQuantityLabel.Text = DataConnection.cmd.ExecuteScalar().ToString();

            DataConnection.cmd = new SqlCommand("SELECT SUM(OrderPrice) FROM Carts WHERE CartId = @cartId", DataConnection.conn);
            DataConnection.cmd.Parameters.AddWithValue("@cartId", CashierOrderPage.cartIdList[CashierOrderPage.cartIdCount]);
            TotalAmountLabel.Text = $"P{DataConnection.cmd.ExecuteScalar().ToString()}";

            DataConnection.conn.Close();
        }
    }
}
