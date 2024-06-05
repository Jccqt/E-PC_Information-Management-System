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
        static SelectedItems selectedItem;
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
                selectedItem = new SelectedItems();

                if (!DataConnection.reader.GetValue(9).ToString().Equals(""))
                {
                    byte[] imageBinary = (byte[])DataConnection.reader.GetValue(9);
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

                selectedItem.ItemIdLabel.Text = DataConnection.reader.GetString(0);
                selectedItem.QuantityLabel.Text = DataConnection.reader.GetValue(1).ToString();
                selectedItem.PriceLabel.Text = DataConnection.reader.GetValue(2).ToString();
                selectedItem.NameLabel.Text = DataConnection.reader.GetString(5);
                selectedItem.TypeLabel.Text = DataConnection.reader.GetString(6);
                selectedItem.CategoryLabel.Text = DataConnection.reader.GetString(7);
                selectedItem.DescriptionLabel.Text = DataConnection.reader.GetString(8);

                DateLabel.Text = DataConnection.reader.GetValue(3).ToString();
                StatusLabel.Text = DataConnection.reader.GetString(4);
                CartPanel.Controls.Add(selectedItem);
            }
            DataConnection.reader.Close();
            DataConnection.conn.Close();
            GC.Collect();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            PageObjects.cashierOrderPage.Show();
            this.Close();
        }
    }
}
