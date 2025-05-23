﻿using System;
using System.Collections;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace E_Pc
{
    public partial class Inventory : Form
    {
        static byte[] imageBinary;
        public static int itemIdCount;
        public static ArrayList itemIdList = new ArrayList();
        public static ArrayList itemQuantity = new ArrayList();
        public Inventory()
        {
            InitializeComponent();
            SortBox.SelectedItem = "Available";
        }

        private void SortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataConnection.conn.Open();
            if (SortBox.SelectedItem.Equals("Available"))
            {
                ShowAvailableProducts();
            }
            else
            {
                ShowArchivedProducts();
            }
            DataConnection.conn.Close();
        }

        public void ShowAvailableProducts()
        {
            AddBtn.Visible = true;
            AddProductBtn.Visible = true;
            TableLabel.Text = "Available Products";
            InventoryPanel.Controls.Clear();
            itemIdList.Clear();
            itemQuantity.Clear();

            DataConnection.cmd = new SqlCommand("SELECT ItemId, ItemName, ItemQuantity, ItemImage FROM Products WHERE Active_flag = 1 " +
                $"AND (ItemId LIKE '%{SearchBox.Text}%' " + // search for item id
                $"OR ItemName LIKE '%{SearchBox.Text}%' " + // search for item name
                $"OR ItemQuantity LIKE '{SearchBox.Text}')", DataConnection.conn); // search for item quantity
            DataConnection.reader = DataConnection.cmd.ExecuteReader();
     
            while (DataConnection.reader.Read())
            {
                itemIdList.Add(DataConnection.reader.GetString(0));
                itemQuantity.Add(DataConnection.reader.GetValue(2));

                if (Convert.ToInt32(DataConnection.reader.GetValue(2)) > 0)
                {
                    // will display the item to available products table if the item quantity is more than 0
                    Product product = new Product();

                    if (!DataConnection.reader.GetValue(3).ToString().Equals(""))
                    {
                        byte[] imageBinary = (byte[])DataConnection.reader.GetValue(3);
                        using (MemoryStream ms = new MemoryStream(imageBinary))
                        {
                            product.ItemImage.Image = Image.FromStream(ms);
                            product.ItemImage.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        Array.Clear(imageBinary, 0, imageBinary.Length);
                    }
                    else
                    {
                        product.ItemImage.Image = Properties.Resources.no_image_icon;
                        product.ItemImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    }

                    InventoryPanel.Controls.Add(product);
                    product.ItemImage.Tag = DataConnection.reader.GetString(0);
                    product.ItemName.Text = $"Name: {DataConnection.reader.GetString(1)}";
                    product.ItemQuantity.Text = $"Quantity: {DataConnection.reader.GetValue(2).ToString()}";

                    product.ItemImage.Click += new EventHandler(ViewItem_Click);
                    GC.Collect();
                }
            }
            DataConnection.reader.Close();

            for(int i = 0; i < itemQuantity.Count; i++)
            {
                // will set the active flag of item to inactive and sent to archive table if the item quantity is less than or equal to 0
                if (Convert.ToInt32(itemQuantity[i]) <= 0)
                {
                    DataConnection.cmd = new SqlCommand("UPDATE Products SET Active_flag = 0 WHERE ItemId = @id", DataConnection.conn);
                    DataConnection.cmd.Parameters.AddWithValue("@id", itemIdList[i]);
                    DataConnection.cmd.ExecuteNonQuery();
                }
                GC.Collect();
            }
        }

        private void ViewItem_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            itemIdCount = itemIdList.IndexOf(pic.Tag);
            using(Form form = new Form())
            {
                PageObjects.editItemPage = new EditItem();
                form.Controls.Add(PageObjects.editItemPage);
                form.StartPosition = FormStartPosition.CenterScreen;
                form.AutoSize = true;
                form.ShowDialog();
            }
        }

        public void ShowArchivedProducts()
        {
            AddBtn.Visible = false;
            AddProductBtn.Visible = false;
            TableLabel.Text = "Archived Products";
            itemIdList.Clear();
            InventoryPanel.Controls.Clear();

            DataConnection.cmd = new SqlCommand("SELECT ItemId, ItemName, ItemQuantity, ItemImage FROM Products WHERE Active_flag = 0 " +
                $"AND (ItemId LIKE '%{SearchBox.Text}%' " +
                $"OR ItemName LIKE '%{SearchBox.Text}%' " +
                $"OR ItemQuantity LIKE '{SearchBox.Text}')", DataConnection.conn);
            DataConnection.reader = DataConnection.cmd.ExecuteReader();

            while (DataConnection.reader.Read())
            {
                Product product = new Product();

                if(!DataConnection.reader.GetValue(3).ToString().Equals("")) 
                {
                    byte[] imageBinary = (byte[])DataConnection.reader.GetValue(3);
                    using (MemoryStream ms = new MemoryStream(imageBinary))
                    {
                        product.ItemImage.Image = Image.FromStream(ms);
                        product.ItemImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    Array.Clear(imageBinary, 0, imageBinary.Length);
                }
                else
                {
                    product.ItemImage.Image = Properties.Resources.no_image_icon;
                    product.ItemImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                itemIdList.Add(DataConnection.reader.GetString(0));
                InventoryPanel.Controls.Add(product);
                product.ItemImage.Tag = DataConnection.reader.GetString(0);
                product.ItemName.Text = $"Name: {DataConnection.reader.GetString(1)}";
                product.ItemQuantity.Text = $"Quantity: {DataConnection.reader.GetValue(2).ToString()}";
                product.OutOfStockPic.Visible = true;

                product.ItemImage.Click += new EventHandler(RetrieveItem_Click);
                GC.Collect();
            }
            DataConnection.reader.Close();
        }

        private void RetrieveItem_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            itemIdCount = itemIdList.IndexOf(pic.Tag);
            Form form = new Form();
            form.Controls.Add(new RetrieveItem());
            form.StartPosition = FormStartPosition.CenterScreen;
            form.AutoSize = true;
            form.ShowDialog();
            GC.Collect();
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Controls.Add(new AddProduct());
            form.StartPosition = FormStartPosition.CenterScreen;
            form.AutoSize = true;
            form.ShowDialog();
            GC.Collect();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Controls.Add(new AddProduct());
            form.StartPosition = FormStartPosition.CenterScreen;
            form.AutoSize = true;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.ShowDialog();
            GC.Collect();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            // will show a warning message before exiting the application
            DialogResult exitDialog = MessageBox.Show("Are you sure you want to close the program?" +
                "\nAny unsaved progress will be lost.", "Close application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(exitDialog == DialogResult.Yes)
            {
                Application.Exit(); // will terminate the application
            }
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            PageObjects.adminHomePage.Show();
            this.Close();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            DataConnection.conn.Open();
            if (SortBox.SelectedItem.Equals("Available"))
            {
                ShowAvailableProducts();
            }
            else
            {
                ShowArchivedProducts();
            }
            DataConnection.conn.Close();
        }

        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            PageObjects.reportsPage = new AdminReports();
            PageObjects.reportsPage.Show();
            this.Close();
        }

        private void EmployeeManagementButton_Click(object sender, EventArgs e)
        {
            PageObjects.employeePage = new Employee();
            PageObjects.employeePage.Show();
            this.Close();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            // will show a logout prompt when the user click the Logout icon
            DialogResult logoutDialog = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (logoutDialog == DialogResult.Yes)
            {
                PageObjects.login = new Login();
                // will go back to Login page when the user logs out
                Login.isLogin = false;
                PageObjects.login.Show();
                this.Close();
            }
        }

    }
}
