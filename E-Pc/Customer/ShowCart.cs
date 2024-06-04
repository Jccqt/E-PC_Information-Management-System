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
using System.IO;
using System.Collections;

namespace Customer
{
    public partial class ShowCart : UserControl
    {
        static SelectedItems selectedItem;
        static ArrayList itemPrices = new ArrayList();
        public ShowCart()
        {
            InitializeComponent();
            TotalQuantityLabel.Text = BuyItems.totalOrderQuantity.ToString();
        }

        public void ShowCart_Load(object sender, EventArgs e)
        {
            CartPanel.Controls.Clear();
            itemPrices.Clear();
            DataConnection.conn.Open();
            BuyItems.totalOrderPrice = 0;
            for(int i = 0; i < BuyItems.orderIdList.Count; i++)
            {
                

                DataConnection.cmd = new SqlCommand("SELECT ItemName, ItemType, ItemPrice, Category, ItemDescription, ItemImage FROM Products WHERE ItemId = @id", DataConnection.conn);
                DataConnection.cmd.Parameters.AddWithValue("@id", BuyItems.orderIdList[i]);
                DataConnection.reader = DataConnection.cmd.ExecuteReader();

                
                if (DataConnection.reader.Read())
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

                    decimal itemPrice = Convert.ToDecimal(DataConnection.reader.GetValue(2)) * Convert.ToInt32(BuyItems.orderQuantityList[i]);

                    CartPanel.Controls.Add(selectedItem);
                    selectedItem.NameLabel.Text = DataConnection.reader.GetString(0);
                    selectedItem.TypeLabel.Text = DataConnection.reader.GetString(1);
                    selectedItem.PriceLabel.Text = $"P{itemPrice}";
                    selectedItem.CategoryLabel.Text = DataConnection.reader.GetString(3);
                    selectedItem.DescriptionLabel.Text = DataConnection.reader.GetString(4);
                    selectedItem.QuantityLabel.Text = BuyItems.orderQuantityList[i].ToString();
                    selectedItem.IdLabel.Text = BuyItems.orderIdList[i].ToString();

                    itemPrices.Add(itemPrice);
                    BuyItems.totalOrderPrice += itemPrice;
                }

                DataConnection.reader.Close();
                GC.Collect();
            }

            DataConnection.conn.Close();
            TotalAmountLabel.Text = BuyItems.totalOrderPrice.ToString();
        }

        private void CheckoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult checkoutDialog = MessageBox.Show("Are you sure you want to proceed to checkout?", "Checkout orders", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var localDate = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");

            if(checkoutDialog == DialogResult.Yes)
            {
                DataConnection.conn.Open();

                DataConnection.cmd = new SqlCommand("SELECT CartId FROM Carts ORDER BY CartId DESC", DataConnection.conn);
                int cartId = Convert.ToInt32(DataConnection.cmd.ExecuteScalar()) + 1;

                for (int i = 0; i < BuyItems.orderIdList.Count; i++)
                {
                    DataConnection.cmd = new SqlCommand("INSERT INTO Carts(CartId, ItemId, OrderQuantity, OrderPrice, OrderDate) VALUES (@cartId, @id, @quantity, @price, @date)", DataConnection.conn);
                    DataConnection.cmd.Parameters.AddWithValue("@cartId", cartId);
                    DataConnection.cmd.Parameters.AddWithValue("@id", BuyItems.orderIdList[i]);
                    DataConnection.cmd.Parameters.AddWithValue("@quantity", BuyItems.orderQuantityList[i]);
                    DataConnection.cmd.Parameters.AddWithValue("@price", itemPrices[i]);
                    DataConnection.cmd.Parameters.AddWithValue("@date", Convert.ToDateTime(localDate));
                    DataConnection.cmd.ExecuteNonQuery();
                }
                DataConnection.conn.Close();

                Form form = new Form();
                form.Controls.Add(new CodeGenerator());
                form.StartPosition = FormStartPosition.CenterScreen;
                form.AutoSize = true;
                form.Text = "Order code";
                form.ShowDialog();
                ((Form)this.TopLevelControl).Close();
            }
        }
    }
}
