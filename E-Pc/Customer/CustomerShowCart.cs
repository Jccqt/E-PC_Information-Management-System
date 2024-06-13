using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer
{
    public partial class CustomerShowCart : Form
    {
        static ArrayList itemPrices = new ArrayList();
        public CustomerShowCart()
        {
            InitializeComponent();
            
        }

        private void CustomerShowCart_Load(object sender, EventArgs e)
        {
            if(BuyItems.totalOrderQuantity == 0)
            {
                // will not show the checkout button if there's no item in the cart
                CheckoutBtn.Visible = false;
                CheckoutArrow.Visible = false;
            }
            else
            {
                // will show the checkout button if there's an item in the cart
                CheckoutBtn.Visible = true;
                CheckoutArrow.Visible = true;
            }

            BuyItems.totalOrderPrice = 0; // will reset the total order price everytime the cart is loaded
            TotalQuantityLabel.Text = BuyItems.totalOrderQuantity.ToString(); // will set the total quantity label to total order quantity from BuyItems class
            CartPanel.Controls.Clear(); // will clear the controls inside CartPanel
            itemPrices.Clear(); // will clear the elements inside itemPrices

            DataConnection.conn.Open();

            for(int i = 0; i < BuyItems.orderIdList.Count; i++) // will loop based on the number of orders
            {
                // will retrieve data from selected records in Products table
                DataConnection.cmd = new SqlCommand("SELECT ItemName, ItemType, ItemPrice, Category, ItemDescription, ItemImage FROM Products WHERE ItemId = @id", DataConnection.conn);
                DataConnection.cmd.Parameters.AddWithValue("@id", BuyItems.orderIdList[i]);
                DataConnection.reader = DataConnection.cmd.ExecuteReader();

                if (DataConnection.reader.Read())
                {
                    SelectedItems selectedItem = new SelectedItems(); // new object for SelectedItems class

                    if (!DataConnection.reader.GetValue(5).ToString().Equals(""))
                    {
                        byte[] imageBinary = (byte[])DataConnection.reader.GetValue(5);
                        using (MemoryStream ms = new MemoryStream(imageBinary))
                        {
                            selectedItem.ItemImage.Image = Image.FromStream(ms);
                            selectedItem.ItemImage.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        Array.Clear(imageBinary, 0, imageBinary.Length); // will clear the elements of imageBinary array
                    }
                    else
                    {
                        // will set the itemImage to no image png if it does not have a value in database
                        selectedItem.ItemImage.Image = Properties.Resources.no_image_icon;
                        selectedItem.ItemImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    decimal itemPrice = Convert.ToDecimal(DataConnection.reader.GetValue(2)) * Convert.ToInt32(BuyItems.orderQuantityList[i]);
                    selectedItem.TabIndex = i;
                    selectedItem.NameLabel.Text = DataConnection.reader.GetString(0);
                    selectedItem.TypeLabel.Text = DataConnection.reader.GetString(1);
                    selectedItem.PriceLabel.Text = $"P{itemPrice}";
                    selectedItem.CategoryLabel.Text = DataConnection.reader.GetString(3);
                    selectedItem.DescriptionLabel.Text = DataConnection.reader.GetString(4);
                    selectedItem.QuantityLabel.Text = BuyItems.orderQuantityList[i].ToString();
                    selectedItem.IdLabel.Text = BuyItems.orderIdList[i].ToString();

                    CartPanel.Controls.Add(selectedItem); // will add the selectedItem object to CartPanel for display
                    itemPrices.Add(itemPrice); // will add the item price to the array
                    BuyItems.totalOrderPrice += itemPrice; // will increase the totalOrderPrice
                }

                DataConnection.reader.Close();
            }
            TotalAmountLabel.Text = $"P{BuyItems.totalOrderPrice}";
            DataConnection.conn.Close();
            GC.Collect(); // will force garbage collection to reduce resource consumption
        }

        private void ContinueBtn_Click(object sender, EventArgs e)
        {
            PageObjects.buyItemsPage.Show();
            this.Close();
        }

        private void CheckoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult checkoutDialog = MessageBox.Show("Are you sure you want to proceed to checkout?", "Checkout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var localDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");

            if (checkoutDialog == DialogResult.Yes)
            {
                DataConnection.conn.Open();

                DataConnection.cmd = new SqlCommand("SELECT CartId FROM Carts ORDER BY CartId DESC", DataConnection.conn);
                int cartId = Convert.ToInt32(DataConnection.cmd.ExecuteScalar());

                if(cartId == 0)
                {
                    cartId = 10000;
                }
                else
                {
                    cartId += 1;
                }

                for (int i = 0; i < BuyItems.orderIdList.Count; i++)
                {
                    DataConnection.cmd = new SqlCommand("INSERT INTO Carts(CartId, ItemId, OrderQuantity, OrderPrice, OrderDate, Status) VALUES (@cartId, @id, @quantity, @price, @date, @status)", DataConnection.conn);
                    DataConnection.cmd.Parameters.AddWithValue("@cartId", cartId);
                    DataConnection.cmd.Parameters.AddWithValue("@id", BuyItems.orderIdList[i]);
                    DataConnection.cmd.Parameters.AddWithValue("@quantity", BuyItems.orderQuantityList[i]);
                    DataConnection.cmd.Parameters.AddWithValue("@price", itemPrices[i]);
                    DataConnection.cmd.Parameters.AddWithValue("@date", Convert.ToDateTime(localDate));
                    DataConnection.cmd.Parameters.AddWithValue("@status", "Pending");
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
