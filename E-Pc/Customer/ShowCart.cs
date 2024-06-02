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

namespace Customer
{
    public partial class ShowCart : UserControl
    {
        static SelectedItems selectedItem;
        public ShowCart()
        {
            InitializeComponent();
        }

        private void ShowCart_Load(object sender, EventArgs e)
        {
            CartPanel.Controls.Clear();

            DataConnection.conn.Open();

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

                    CartPanel.Controls.Add(selectedItem);
                    selectedItem.NameLabel.Text = DataConnection.reader.GetString(0);
                    selectedItem.TypeLabel.Text = DataConnection.reader.GetString(1);
                    selectedItem.PriceLabel.Text = DataConnection.reader.GetValue(2).ToString();
                    selectedItem.CategoryLabel.Text = DataConnection.reader.GetString(3);
                    selectedItem.DescriptionLabel.Text = DataConnection.reader.GetString(4);
                    selectedItem.QuantityLabel.Text = BuyItems.orderQuantityList[i].ToString();
                }

                DataConnection.reader.Close();
                GC.Collect();
            }

            DataConnection.conn.Close();
        }
    }
}
