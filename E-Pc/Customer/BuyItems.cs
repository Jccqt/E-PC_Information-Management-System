using System;
using System.Collections;
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
using System.Runtime.Remoting.Channels;


namespace Customer
{
    public partial class BuyItems : Form
    {
        static int cartPrice;
        static string selectedItem;
        static Items item;
        public static int itemIdIndex;
        public static int totalOrderQuantity;
        public static decimal totalOrderPrice;
        public static ArrayList itemIdList = new ArrayList();
        public static ArrayList orderIdList = new ArrayList();
        public static ArrayList orderQuantityList = new ArrayList();
        public BuyItems()
        {
            InitializeComponent();
            SortBox.SelectedItem = "All";
            selectedItem = "CPU";

        }

        #region Select item type
        private void SortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowItems();
        }

        private void CpuBtn_Click(object sender, EventArgs e)
        {
            selectedItem = "CPU";
            ShowItems();
        }

        private void MotherboardBtn_Click(object sender, EventArgs e)
        {
            selectedItem = "MOTHERBOARD";
            ShowItems();
        }

        private void RamBtn_Click(object sender, EventArgs e)
        {
            selectedItem = "RAM";

            ShowItems();
        }

        private void PsuBtn_Click(object sender, EventArgs e)
        {
            selectedItem = "PSU";
            ShowItems();
        }

        private void StorageBtn_Click(object sender, EventArgs e)
        {
            selectedItem = "DISK";
            ShowItems();
        }

        private void GpuBtn_Click(object sender, EventArgs e)
        {
            selectedItem = "GPU";
            ShowItems();
        }

        private void OthersBtn_Click(object sender, EventArgs e)
        {
            selectedItem = "OTHERS";
            ShowItems();
        }
        #endregion

        public void ShowItems()
        {
            DataConnection.conn.Open();
            TableLabel.Text = selectedItem;
            ItemsPanel.Controls.Clear();

            if (SortBox.SelectedItem.Equals("All"))
            {
                DataConnection.cmd = new SqlCommand($"SELECT ItemId, ItemName, ItemPrice, ItemImage FROM Products " +
                $"WHERE ItemType LIKE '%{selectedItem}%' AND Active_flag = 1", DataConnection.conn);
            }
            else
            {
                DataConnection.cmd = new SqlCommand($"SELECT ItemId, ItemName, ItemPrice, ItemImage FROM Products " +
                $"WHERE Category LIKE '{SortBox.SelectedItem}' AND ItemType LIKE '%{selectedItem}%' AND Active_flag = 1", DataConnection.conn);
            }
            DataConnection.reader = DataConnection.cmd.ExecuteReader();

            while (DataConnection.reader.Read())
            {
                item = new Items();

                if (!DataConnection.reader.GetValue(3).ToString().Equals(""))
                {
                    byte[] imageBinary = (byte[])DataConnection.reader.GetValue(3);
                    using (MemoryStream ms = new MemoryStream(imageBinary))
                    {
                        item.ItemImage.Image = Image.FromStream(ms);
                        item.ItemImage.SizeMode = PictureBoxSizeMode.StretchImage;
                        item.ItemImage.Refresh();
                    }
                    Array.Clear(imageBinary, 0, imageBinary.Length);

                }
                else
                {
                    item.ItemImage.Image = Properties.Resources.no_image_icon;
                    item.ItemImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                itemIdList.Add(DataConnection.reader.GetString(0));
                ItemsPanel.Controls.Add(item);
                item.ItemImage.Tag = DataConnection.reader.GetString(0);
                item.ItemName.Text = $"Name: {DataConnection.reader.GetString(1)}";
                item.ItemPrice.Text = $"Price: P{DataConnection.reader.GetValue(2)}";
                

                item.ItemImage.Click += new EventHandler(ViewItem_Click);

                GC.Collect();
            }
            DataConnection.reader.Close();
            DataConnection.conn.Close();
        }

        private void ViewItem_Click(object sender,  EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            itemIdIndex = itemIdList.IndexOf(pic.Tag);
            Form form = new Form();
            form.Controls.Add(new ViewItem());
            form.StartPosition = FormStartPosition.CenterScreen;
            form.AutoSize = true;
            form.Text = "View Product";
            form.ShowDialog();
        }

        private void BuyItems_Load(object sender, EventArgs e)
        {
            ShowItems();
        }
        public void CartBtn_Click(object sender, EventArgs e)
        {
            CustomerShowCart cartPage = new CustomerShowCart();
            cartPage.Show();
            this.Hide();
        }
    }
}
