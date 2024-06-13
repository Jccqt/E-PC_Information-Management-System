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
using System.Text.RegularExpressions;
using System.Collections;

namespace E_Pc
{
    public partial class AddProduct : UserControl
    {
        static int idCount;
        static bool isNewImage = false;
        static bool hasSameName = false;
        static byte[] imageBinary;
        static ArrayList itemNames = new ArrayList();
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            DataConnection.conn.Open();

            DataConnection.cmd = new SqlCommand("SELECT ItemName FROM Products", DataConnection.conn);
            DataConnection.reader = DataConnection.cmd.ExecuteReader();

            while (DataConnection.reader.Read())
            {
                itemNames.Add(DataConnection.reader.GetString(0));
            }
            DataConnection.reader.Close();

            if (itemNames.Contains(NameBox.Text))
            {
                hasSameName = true;
            }
            else
            {
                hasSameName = false;
            }

            if (!NameBox.Text.Equals("") && !BrandBox.Text.Equals("") && !TypeBox.SelectedItem.Equals("") && !CategoryBox.SelectedItem.Equals("") &&
                !PriceBox.Text.Equals("") && !QuantityBox.Text.Equals("") && !hasSameName)
            {
                idCount = 2000;
                var localDate = DateTime.Now.ToString("yyyy-MM-dd");


                DataConnection.cmd = new SqlCommand("SELECT COUNT(ItemType) FROM Products WHERE ItemType = @type", DataConnection.conn);
                DataConnection.cmd.Parameters.AddWithValue("@type", TypeBox.SelectedItem);
                idCount += Convert.ToInt32(DataConnection.cmd.ExecuteScalar());

                DataConnection.cmd = new SqlCommand("INSERT INTO Products(ItemId, ItemName, ItemBrand, " +
                    "ItemPrice, ItemQuantity, ItemType, Category, ItemDescription, DateCreation, Active_flag) " +
                    "VALUES (@id, @name, @brand, @price, @quantity, @type, @category, @description, @date, @flag)", DataConnection.conn);
                DataConnection.cmd.Parameters.AddWithValue("@id", $"{TypeBox.SelectedItem.ToString().ToUpper()}{idCount + 1}");
                DataConnection.cmd.Parameters.AddWithValue("@name", NameBox.Text);
                DataConnection.cmd.Parameters.AddWithValue("@brand", BrandBox.Text);
                DataConnection.cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(PriceBox.Text));
                DataConnection.cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(QuantityBox.Text));
                DataConnection.cmd.Parameters.AddWithValue("@type", TypeBox.SelectedItem);
                DataConnection.cmd.Parameters.AddWithValue("@category", CategoryBox.SelectedItem);
                DataConnection.cmd.Parameters.AddWithValue("@description", DescriptionBox.Text);
                DataConnection.cmd.Parameters.AddWithValue("@date", Convert.ToDateTime(localDate));
                
                if(Convert.ToInt32(QuantityBox.Text) <= 0)
                {
                    // will set the active flag to 0 and display to archive table if the item quantity is less than or equal to 0
                    DataConnection.cmd.Parameters.AddWithValue("@flag", 0);
                }
                else
                {
                    // will set the active flag to 1 and display to available products table if the item quantity is more than 0
                    DataConnection.cmd.Parameters.AddWithValue("@flag", 1);
                }
                DataConnection.cmd.ExecuteNonQuery();

                if (isNewImage)
                {
                    DataConnection.cmd = new SqlCommand("UPDATE Products SET ItemImage = @image WHERE ItemId = @id", DataConnection.conn);
                    DataConnection.cmd.Parameters.AddWithValue("@id", $"{TypeBox.SelectedItem.ToString().ToUpper()}{idCount + 1}");
                    DataConnection.cmd.Parameters.AddWithValue("@image", imageBinary);
                    DataConnection.cmd.ExecuteNonQuery();
                    Array.Clear(imageBinary, 0, imageBinary.Length);
                }

                if (Convert.ToInt32(QuantityBox.Text) <= 0)
                {
                    MessageBox.Show("Item has been added to archive table successfully!");
                }
                else
                {
                    MessageBox.Show("Item has been added to available products table successfully!");
                }
                
                ClearTextBox();
                isNewImage = false;
                ((Form)this.TopLevelControl).Close();
                PageObjects.inventoryPage.ShowAvailableProducts();
                PageObjects.inventoryPage.Show();
            }
            else if (hasSameName)
            {
                MessageBox.Show("Item name was already existing!", "Item name existing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // will show an error message if there is an empty details
                MessageBox.Show("Cannot be saved because of empty details. Please complete the details first", "Empty details!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataConnection.conn.Close();
            hasSameName = false;
        }

        private void SelectImageBtn_Click(object sender, EventArgs e)
        {
            if(OpenImage.ShowDialog() == DialogResult.OK)
            {
                ItemImage.Image = Image.FromFile(OpenImage.FileName);
                ItemImage.SizeMode = PictureBoxSizeMode.StretchImage;
                imageBinary = System.IO.File.ReadAllBytes(OpenImage.FileName);
                isNewImage = true;
            }
        }

        void ClearTextBox()
        {
            NameBox.Clear();
            BrandBox.Clear();
            PriceBox.Clear();
            QuantityBox.Clear();
            DescriptionBox.Clear();
            ItemImage.Image = null;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void PriceBox_TextChanged(object sender, EventArgs e)
        {
            if(!PriceBox.Text.Equals("") && !Regex.IsMatch(PriceBox.Text, InputValidation.numberPattern))
            {
                // will show an error message if the payment box has a character
                MessageBox.Show("Please input numbers only!", "Invalid input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PriceBox.Text = PriceBox.Text.Remove(PriceBox.Text.Length - 1);
            }
        }

        private void QuantityBox_TextChanged(object sender, EventArgs e)
        {
            if(!QuantityBox.Text.Equals("") && !Regex.IsMatch(QuantityBox.Text, InputValidation.numericPattern))
            {
                // will show an error message if the payment box has a character
                MessageBox.Show("Please input numbers only!", "Invalid input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                QuantityBox.Text = QuantityBox.Text.Remove(QuantityBox.Text.Length - 1);
            }
        }
    }
}
