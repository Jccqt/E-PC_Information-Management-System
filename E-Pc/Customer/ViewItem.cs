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
using Customer;
using static Guna.UI2.WinForms.Suite.Descriptions;
using Customer.Properties;

namespace Customer
{
    public partial class ViewItem : UserControl
    {
        static byte[] imageBinary;
        static int Quantity;
        public ViewItem()
        {
            InitializeComponent();
            ActivityLabel.Text = "Viewing";
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            if(Quantity < Convert.ToInt32(QuantityBox.Text))
            {
                Quantity++;
                QuantityToOrder.Text = Quantity.ToString();
            }
            else
            {
                MessageBox.Show("Cannot exceed order quantity!");
            }
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            if(Quantity > 0)
            {
                Quantity--;
                QuantityToOrder.Text = Quantity.ToString();
            }
            else
            {
                MessageBox.Show("Cannot make order quantity less than 0");
            }
        }

        private void ViewItem_Load(object sender, EventArgs e)
        {
            Quantity = 0;
            DataConnection.conn.Open();

            DataConnection.cmd = new SqlCommand("SELECT ItemId, ItemName, ItemBrand, ItemPrice, ItemQuantity, " +
                "ItemType, Category, ItemDescription, ItemImage FROM Products WHERE ItemId = @id", DataConnection.conn);
            DataConnection.cmd.Parameters.AddWithValue("@id", BuyItems.itemIdList[BuyItems.itemIdIndex]);
            DataConnection.reader = DataConnection.cmd.ExecuteReader();

            if (DataConnection.reader.Read())
            {
                IdLabel.Text = DataConnection.reader.GetString(0);
                NameBox.Text = DataConnection.reader.GetString(1);
                BrandBox.Text = DataConnection.reader.GetString(2);
                PriceBox.Text = DataConnection.reader.GetValue(3).ToString();
                QuantityBox.Text = DataConnection.reader.GetValue(4).ToString();
                TypeBox.Text = DataConnection.reader.GetString(5);
                CategoryBox.Text = DataConnection.reader.GetString(6);
                DescriptionBox.Text = DataConnection.reader.GetString(7);

                if (!DataConnection.reader.GetValue(8).ToString().Equals(""))
                {
                    byte[] imageBinary = (byte[])DataConnection.reader.GetValue(8);
                    using (MemoryStream ms = new MemoryStream(imageBinary))
                    {
                        ItemImage.Image = Image.FromStream(ms);
                        ItemImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    Array.Clear(imageBinary, 0, imageBinary.Length);
                }
                else
                {
                    ItemImage.Image = Resources.no_image_icon;
                    ItemImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }

            }
            DataConnection.reader.Close();
            DataConnection.conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void QuantityToOrder_Click(object sender, EventArgs e)
        {

        }

        private void AddToCartBtn_Click(object sender, EventArgs e)
        {
            if(Quantity <= 0)
            {
                MessageBox.Show("Invalid quantity! Please select order quantity higher than 0");
            }
            else
            {
                if (BuyItems.orderIdList.Contains(IdLabel.Text))
                {
                    DialogResult orderAlreadyExist = MessageBox.Show("Item is already existing to the cart!" +
                        "\nDo you want to add your new order quantity to the existing order?", "Order already exist!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (orderAlreadyExist == DialogResult.Yes)
                    {
                        int originalQuantity = Convert.ToInt32(BuyItems.orderQuantityList[BuyItems.orderIdList.IndexOf(IdLabel.Text)]);
                        BuyItems.orderQuantityList.RemoveAt(BuyItems.orderIdList.IndexOf(IdLabel.Text));
                        BuyItems.orderQuantityList.Insert(BuyItems.orderIdList.IndexOf(IdLabel.Text), Quantity + originalQuantity);
                        MessageBox.Show("Item has been added to the cart!");
                        BuyItems.totalOrderQuantity += Quantity;
                        Quantity = 0;
                        ((Form)this.TopLevelControl).Close();
                        
                    }
                }
                else
                {

                    BuyItems.totalOrderQuantity += Quantity;
                    BuyItems.orderIdList.Add(IdLabel.Text);
                    BuyItems.orderQuantityList.Add(Quantity);
                    MessageBox.Show("Item has been added to the cart!");
                    Quantity = 0;
                    ((Form)this.TopLevelControl).Close();
                }
            }
        }
    }
}
