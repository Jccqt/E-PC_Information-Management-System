using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace E_Pc
{
    public partial class UpdateInventory : Form
    {
        static SqlCommand cmd;
        static bool isExisting = false, isTextEmpty = false;
        public UpdateInventory()
        {
            InitializeComponent();
        }

        private void UpdateInventory_Load(object sender, EventArgs e)
        {
            DataConnection.ItemIdList.Clear();
            DataConnection.GetItemIdList();
            DataConnection.ShowAllInventoryTable();
            foreach (DataGridViewColumn column in InventoryGrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            var localDate = DateTime.Now;
            var time = DateTime.Now.ToString("HH:mm tt");

            DataConnection.conn.Open();

            if (ItemIdBox.Text.Equals("") || NameBox.Text.Equals("") || BrandBox.Text.Equals("") || PriceBox.Text.Equals("")
                || QuantityBox.Text.Equals("") || TypeBox.Text.Equals("") || CategoryBox.Text.Equals(""))
            {
                isTextEmpty = true;
            }
            else
            {
                isTextEmpty = false;
            }
            
            if (!isTextEmpty)
            {
                DialogResult updateDiag = MessageBox.Show("Do you want to save changes?", "Save details", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (updateDiag == DialogResult.Yes)
                {
                    DataConnection.updateInventory();
                    DataConnection.ShowAllInventoryTable();
                    MessageBox.Show("Item has been updated!");

                    // will clear all text box in UpdateInventory page
                    ItemIdBox.Clear();
                    ClearTextBox();
                    isExisting = false;
                    isTextEmpty = false;
                    Array.Clear(PageObjects.imageBinary, 0, PageObjects.imageBinary.Length);
                }

            }
            else
            {
                MessageBox.Show("Please complete the empty details!", "Empty details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DataConnection.conn.Close();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            PageObjects.inventoryPage.Show();
            this.Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult exitDiag = MessageBox.Show("Are you sure you want to exit the application?", "Exit Application?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitDiag == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        void ClearTextBox()
        {
            NameBox.Clear();
            BrandBox.Clear();
            PriceBox.Clear();
            QuantityBox.Clear();
            TypeBox.ResetText();
            MemoBox.Clear();
            DescriptionBox.Clear();
            CategoryBox.ResetText();
            ItemImage.Image = null;
            ActiveBox.Checked = false;
            InactiveBox.Checked = false;
        }

        private void InventoryGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataConnection.conn.Open();
            ClearTextBox();
            DataConnection.ItemIdCount = InventoryGrid.CurrentRow.Index;
            DataConnection.InventoryDataInsert();
            DataConnection.conn.Close();
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

        public byte[] getImageBinary()
        {
            return PageObjects.imageBinary;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            // will clear all text box in UpdateInventory page
            ItemIdBox.Clear();
            ClearTextBox();
        }
    }
}
