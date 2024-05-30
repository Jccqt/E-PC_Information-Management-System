using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace E_Pc
{
    public partial class AddInventory : Form
    {
        static string idToCheck;
        static bool isExisting = false, isTextEmpty = false;
        public AddInventory()
        {
            InitializeComponent();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            PageObjects.inventoryPage.Show();
            this.Hide();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            DataConnection.conn.Open();

            // will check if the Item ID is already existing
            DataConnection.CheckDuplicateProduct();

            if (DataConnection.reader.Read())
            {
                idToCheck = DataConnection.reader.GetValue(0).ToString().ToUpper();
                if (idToCheck.Equals(NameBox.Text.ToString().ToUpper()))
                {
                    isExisting = true;
                }
            }
            DataConnection.reader.Close();

            // will check if the details are complete
            if (NameBox.Text.Equals("") || BrandBox.Text.Equals("") || PriceBox.Text.Equals("") || QuantityBox.Text.Equals("") || TypeBox.Text.Equals(""))
            {
                isTextEmpty = true;
            }
            else
            {
                isTextEmpty = false;
            }

            // will proceed to add product if the item is not existing and item details are complete
            if (!isExisting && !isTextEmpty && Regex.IsMatch(QuantityBox.Text, InputValidation.numberPattern) && Regex.IsMatch(PriceBox.Text, InputValidation.numberPattern))
            {

                DataConnection.AddProduct();
                ClearTextBox();
                isTextEmpty = false;
                isExisting = false;
                PageObjects.isNewImage = false;
                Array.Clear(PageObjects.imageBinary, 0, PageObjects.imageBinary.Length); // will reset the elements of imageBinary array

                MessageBox.Show("The item has been successfully added!", "New item added.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (isTextEmpty)
            {
                // will show an error message is there's an empty box
                MessageBox.Show("Please make sure that input boxes is not empty.", "Empty input.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(QuantityBox.Text, InputValidation.numberPattern) || !Regex.IsMatch(PriceBox.Text, InputValidation.numberPattern))
            {
                // will show an error message if the input for Quantity or Price has a character included
                MessageBox.Show("Invalid input on Quantity or Price! Please enter a valid input.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // will show an warning message if the item is already existing on the database
                MessageBox.Show("You cannot add the item because it is already existing.", "Item existing already!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            DataConnection.ShowActiveInventoryTable(); // will show the table of active products
            DataConnection.conn.Close();
        }

        void ClearTextBox()
        {
            // will clear all the details in AddInventory form
            NameBox.Clear();
            BrandBox.Clear();
            QuantityBox.Clear();
            PriceBox.Clear();
            TypeBox.ResetText();
            CategoryBox.ResetText();
            DescriptionBox.Clear();
            ItemImage.Image = null;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult exitDiag = MessageBox.Show("Are you sure you want to exit the application?", "Exit Application?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitDiag == DialogResult.Yes)
            {
                Application.Exit(); // will terminate the application
            }
        }

        private void SelectImageBtn_Click(object sender, EventArgs e)
        {
            if (SelectImageDialog.ShowDialog() == DialogResult.OK)
            {
                ItemImage.Image = Image.FromFile(SelectImageDialog.FileName);
                ItemImage.SizeMode = PictureBoxSizeMode.StretchImage;
                PageObjects.imageBinary = System.IO.File.ReadAllBytes(SelectImageDialog.FileName);
                PageObjects.isNewImage = true;
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            // will refresh and show the table of active products
            DataConnection.ShowActiveInventoryTable();
        }

        private void AddInventory_Load(object sender, EventArgs e)
        {
            ItemImage.Image = Properties.Resources.no_image_icon;
            ItemImage.SizeMode = PictureBoxSizeMode.StretchImage;
            DataConnection.ShowActiveInventoryTable();
            NameBox.Focus();
        }

    }
}
