using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Pc
{
    public partial class DeleteInventory : Form
    {
        static SqlCommand cmd;
        static bool isExisting = false, isTextEmpty = false;
        public DeleteInventory()
        {
            InitializeComponent();
        }

        private void DeleteInventory_Load(object sender, EventArgs e)
        {
            ShowDeletedData();
            ItemIdBox.Focus();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var localDate = DateTime.Now;
            string deletionId = "";
            int Quantity = 0;

            DataConnection.conn.Open();

            cmd = new SqlCommand("SELECT ItemQuantity FROM Products WHERE ItemId = @id", DataConnection.conn);
            cmd.Parameters.AddWithValue("@id", ItemIdBox.Text);
            Quantity = Convert.ToInt32(cmd.ExecuteScalar());

            if (QuantityBox.Text.Equals(""))
            {
                isTextEmpty = true;

            }
            else
            {
                isTextEmpty = false;
            }

            if (isExisting && !isTextEmpty && Regex.IsMatch(QuantityBox.Text,  InputValidation.numberPattern))
            {
                // will show a deletion message
                DialogResult delDiag = MessageBox.Show("Are you sure you want to delete this item?", "Delete Item", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (delDiag == DialogResult.OK)
                {
                    if(Quantity < Convert.ToInt32(QuantityBox.Text))
                    {
                        MessageBox.Show("Invalid quantity! Please enter a valid quantity.");
                    }
                    else if(Quantity > Convert.ToInt32(QuantityBox.Text))
                    {
                        // will decrease the quantity of the item

                        // will insert selected records from Products table to Deleted_Products table
                        cmd = new SqlCommand("INSERT INTO Deleted_Products (ItemId, ItemName, ItemBrand, ItemType) " +
                            "SELECT ItemId, ItemName, ItemBrand, ItemType FROM Products Where ItemId = @id", DataConnection.conn);
                        cmd.Parameters.AddWithValue("@id", ItemIdBox.Text);
                        cmd.ExecuteNonQuery();

                        // will select the latest deletion ID from Deleted_Products table
                        cmd = new SqlCommand("SELECT * FROM Deleted_Products ORDER BY DeletionId DESC", DataConnection.conn);
                        deletionId = cmd.ExecuteScalar().ToString();

                        // will update the selected record in Deleted_Products table
                        cmd = new SqlCommand("UPDATE Deleted_Products SET DeletedQuantity = @quantity, ItemMemo = @memo, Date = @date WHERE DeletionId = @id", DataConnection.conn);
                        cmd.Parameters.AddWithValue("@id", deletionId);
                        cmd.Parameters.AddWithValue("@quantity", QuantityBox.Text);
                        cmd.Parameters.AddWithValue("@memo", MemoBox.Text);
                        cmd.Parameters.AddWithValue("@date", localDate);
                        cmd.ExecuteNonQuery();

                        // will update the quantity of of the selected record in Products table
                        cmd = new SqlCommand("UPDATE Products SET ItemQuantity = @quantity WHERE ItemId = @id", DataConnection.conn);
                        cmd.Parameters.AddWithValue("@id", ItemIdBox.Text);
                        cmd.Parameters.AddWithValue("@quantity", Quantity -  Convert.ToInt32(QuantityBox.Text));
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Item has been decreased successfully!");

                        ItemIdBox.Clear();
                        MemoBox.Clear();
                        isExisting = false;
                        isTextEmpty = false;
                    }
                    else if(Quantity == Convert.ToInt32(QuantityBox.Text))
                    {
                        // will remove the item if the quantity input is same to the available quantity of the item

                        // will insert selected records from Products table to Deleted_Products table
                        cmd = new SqlCommand("INSERT INTO Deleted_Products (ItemId, ItemName, ItemBrand, ItemType) " +
                            "SELECT ItemId, ItemName, ItemBrand, ItemType FROM Products Where ItemId = @id", DataConnection.conn);
                        cmd.Parameters.AddWithValue("@id", ItemIdBox.Text);
                        cmd.ExecuteNonQuery();

                        // will select the latest deletion ID from Deleted_Products table
                        cmd = new SqlCommand("SELECT * FROM Deleted_Products ORDER BY DeletionId DESC", DataConnection.conn);
                        deletionId = cmd.ExecuteScalar().ToString();

                        // will update the selected record in Deleted_Products table
                        cmd = new SqlCommand("UPDATE Deleted_Products SET DeletedQuantity = @quantity, ItemMemo = @memo, Date = @date WHERE DeletionId = @delId", DataConnection.conn);
                        cmd.Parameters.AddWithValue("@delId", deletionId);
                        cmd.Parameters.AddWithValue("@quantity", Quantity);
                        cmd.Parameters.AddWithValue("@memo", MemoBox.Text);
                        cmd.Parameters.AddWithValue("date", localDate);
                        cmd.ExecuteNonQuery();

                        // will delete the specific record in Products table
                        cmd = new SqlCommand("DELETE FROM Products WHERE ItemId = @id", DataConnection.conn);
                        cmd.Parameters.AddWithValue("@id", ItemIdBox.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Item has been deleted successfully!");

                        ItemIdBox.Clear();
                        MemoBox.Clear();
                        isExisting = false;
                        isTextEmpty = false;
                    }

                }
            }
            else if (isTextEmpty)
            {
                // will show an error message if the Quantity box is empty
                MessageBox.Show("Quantity box is empty!", "Empty box.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(QuantityBox.Text, InputValidation.numberPattern))
            {
                // will show an error message if the Quantity input has a character included
                MessageBox.Show("Invalid input! Please enter a valid quantity.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // will show an error message if the item is not verified as existing
                MessageBox.Show("Please verify the item first!","Item Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ShowDeletedData();
            DataConnection.conn.Close();
        }

        void ShowDeletedData()
        {
            cmd = new SqlCommand("SELECT * FROM Deleted_Products", DataConnection.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            PageObjects.deletedInventoryTable.Clear();
            adapter.Fill(PageObjects.deletedInventoryTable);
            DeletedProductsGrid.DataSource = PageObjects.deletedInventoryTable;
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

        private void VerifyBtn_Click(object sender, EventArgs e)
        {
            var localDateTime = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
            DataConnection.conn.Open();
            cmd = new SqlCommand("SELECT ItemId FROM Products WHERE ItemId = @id", DataConnection.conn);
            cmd.Parameters.AddWithValue("@id", ItemIdBox.Text.ToUpper());
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                isExisting = true;
                CheckPic.Visible = true;
                QuantityBox.Clear();
                MemoBox.Text = $"Deleted on {localDateTime} - ";
                MessageBox.Show("Item has been found!", "Item exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                isExisting = false;
                CheckPic.Visible = false;
                MessageBox.Show("Item is not existing", "Item do not exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            reader.Close();
            DataConnection.conn.Close();
        }

        private void DeletionIdBox_TextChanged(object sender, EventArgs e)
        {
            if (isExisting)
            {
                isExisting = false;
                CheckPic.Visible = false;
                ClearTextBox();
            }
        }

        void ClearTextBox()
        {
            ItemIdBox.Clear();
            QuantityBox.Clear();
            MemoBox.Clear();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
