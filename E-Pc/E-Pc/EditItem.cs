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

namespace E_Pc
{
    public partial class EditItem : UserControl
    {
        public static int originalQuantity;
        static bool isNewImage = false;
        static byte[] imageBinary;
        public EditItem()
        {
            InitializeComponent();
            ActivityLabel.Text = "Viewing"; // will set the Activity Title to Viewing mode
        }

        private void EditItem_Load(object sender, EventArgs e)
        {
            DataConnection.conn.Open();

            DataConnection.cmd = new SqlCommand("SELECT ItemId, ItemName, ItemBrand, ItemPrice, ItemQuantity, " +
                "ItemType, Category, ItemDescription, ItemImage FROM Products WHERE ItemId = @id", DataConnection.conn);
            DataConnection.cmd.Parameters.AddWithValue("@id", Inventory.itemIdList[Inventory.itemIdCount]);
            DataConnection.reader = DataConnection.cmd.ExecuteReader();

            if (DataConnection.reader.Read())
            {
                // will set the values for labels if the reader retrieves value from database
                IdLabel.Text = DataConnection.reader.GetString(0);
                NameBox.Text = DataConnection.reader.GetString(1);
                BrandBox.Text = DataConnection.reader.GetString(2);
                PriceBox.Text = DataConnection.reader.GetValue(3).ToString();
                QuantityBox.Text = DataConnection.reader.GetValue(4).ToString();
                originalQuantity = Convert.ToInt32(DataConnection.reader.GetValue(4));
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
                    Array.Clear(imageBinary, 0, imageBinary.Length); // will clear the elements of imageBinary array
                }
                else
                {
                    // will set the item image to no image
                    ItemImage.Image = Properties.Resources.no_image_icon;
                    ItemImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            DataConnection.reader.Close();
            DataConnection.conn.Close();
        }

        void EnableTextBox()
        {
            NameBox.Enabled = true;
            BrandBox.Enabled = true;
            QuantityBox.Enabled = true;
            PriceBox.Enabled = true;
            DescriptionBox.Enabled = true;
            SelectImageBtn.Visible = true;
        }

        void DisableTextBox()
        {
            NameBox.Enabled = false;
            BrandBox.Enabled = false;
            QuantityBox.Enabled = false;
            PriceBox.Enabled = false;
            DescriptionBox.Enabled = false;
            SelectImageBtn.Visible = false;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            ActivityLabel.Text = "Editing";
            EnableTextBox();
            EditBtn.Visible = false;
            SaveBtn.Visible = true;
            CancelBtn.Visible = true;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult cancelDialog = MessageBox.Show("Are you sure you want to cancel the edit?" +
                "\nEdit progress will be lost.", "Cancel edit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(cancelDialog == DialogResult.Yes)
            {
                ActivityLabel.Text = "Viewing";
                DisableTextBox();
                EditBtn.Visible = true;
                SaveBtn.Visible = false;
                CancelBtn.Visible = false;
                PlusBtn.Visible = false;
                MinusBtn.Visible = false;
                QuantityActivityLabel.ResetText();
                Remarks.ResetText();
                EditItem_Load(sender, e);
            }

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            int idCount = 10000;
            var localDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm tt");
            DialogResult saveDialog = MessageBox.Show("Are you sure you want to save changes?", "Save changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(saveDialog == DialogResult.Yes)
            {
                DataConnection.conn.Open();

                DataConnection.cmd = new SqlCommand("UPDATE Products SET ItemName = @name, ItemBrand = @brand, " +
                    "ItemPrice = @price, ItemQuantity = @quantity, ItemDescription = @description WHERE ItemId = @id", DataConnection.conn);
                DataConnection.cmd.Parameters.AddWithValue("@id", IdLabel.Text);
                DataConnection.cmd.Parameters.AddWithValue("@name", NameBox.Text);
                DataConnection.cmd.Parameters.AddWithValue("@brand", BrandBox.Text);
                DataConnection.cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(PriceBox.Text));
                DataConnection.cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(QuantityBox.Text));
                DataConnection.cmd.Parameters.AddWithValue("@description", DescriptionBox.Text);
                DataConnection.cmd.ExecuteNonQuery();

                if (isNewImage)
                {
                    DataConnection.cmd = new SqlCommand("UPDATE Products SET ItemImage = @image WHERE ItemId = @id", DataConnection.conn);
                    DataConnection.cmd.Parameters.AddWithValue("@id", IdLabel.Text);
                    DataConnection.cmd.Parameters.AddWithValue("@image", imageBinary);
                    DataConnection.cmd.ExecuteNonQuery();
                }

                if (QuantityActivityLabel.Visible)
                {
                    DataConnection.cmd = new SqlCommand($"SELECT COUNT(ActivityId) FROM Audit_Trail WHERE ActivityId LIKE '%{"INVTRY"}%'", DataConnection.conn);
                    idCount += Convert.ToInt32(DataConnection.cmd.ExecuteScalar());

                    DataConnection.cmd = new SqlCommand("INSERT INTO Audit_Trail VALUES (@actId, @empId, @type, @description, @date)", DataConnection.conn);
                    DataConnection.cmd.Parameters.AddWithValue("@actId", $"INVTRY{idCount}");
                    DataConnection.cmd.Parameters.AddWithValue("@empId", Login.userId);
                    DataConnection.cmd.Parameters.AddWithValue("@type", "INVENTORY");
                    DataConnection.cmd.Parameters.AddWithValue("@description", $"{Login.fName} {Login.lName} {Remarks.Text}");
                    DataConnection.cmd.Parameters.AddWithValue("@date", localDate);
                    DataConnection.cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Item has been updated!");
                PageObjects.inventoryPage.ShowAvailableProducts();
                DataConnection.conn.Close();
                isNewImage = false;
                ActivityLabel.Text = "Viewing";
                DisableTextBox();
                EditBtn.Visible = true;
                SaveBtn.Visible = false;
                CancelBtn.Visible = false;
                PlusBtn.Visible = false;
                MinusBtn.Visible = false;
                QuantityActivityLabel.ResetText();
                Remarks.ResetText();

            }
        }

        private void SelectImageBtn_Click(object sender, EventArgs e)
        {
            if(SelectImage.ShowDialog() == DialogResult.OK)
            {
                ItemImage.Image = Image.FromFile(SelectImage.FileName);
                ItemImage.SizeMode = PictureBoxSizeMode.StretchImage;
                imageBinary = System.IO.File.ReadAllBytes(SelectImage.FileName);
                isNewImage = true;
            }
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            using(Form form = new Form())
            {
                AddRemoveQuantity addPage = new AddRemoveQuantity();
                addPage.AddDeleteHeader.Text = "Adding quantity";
                addPage.AddDeleteLabel.Text = "Quantity to add";
                form.Controls.Add(addPage);
                form.StartPosition = FormStartPosition.Manual;
                form.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) + 100, (Screen.PrimaryScreen.WorkingArea.Height / 2) - 200);
                form.ClientSize = new System.Drawing.Size(566, 526);
                form.ShowDialog();
                GC.Collect();
            }
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            using (Form form = new Form())
            {
                AddRemoveQuantity removePage = new AddRemoveQuantity();
                removePage.AddDeleteHeader.Text = "Removing quantity";
                removePage.AddDeleteLabel.Text = "Quantity to remove";
                form.Controls.Add(removePage);
                form.StartPosition = FormStartPosition.Manual;
                form.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) + 100, (Screen.PrimaryScreen.WorkingArea.Height / 2) - 200);
                form.ClientSize = new System.Drawing.Size(566, 526);
                form.ShowDialog();
                GC.Collect();
            }
        }

        private void EditBtn_Click_1(object sender, EventArgs e)
        {
            ActivityLabel.Text = "Editing";
            EnableTextBox();
            EditBtn.Visible = false;
            SaveBtn.Visible = true;
            CancelBtn.Visible = true;
            PlusBtn.Visible = true;
            MinusBtn.Visible = true;
        }
    }
}
