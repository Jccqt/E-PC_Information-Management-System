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
    public partial class UpdateInventory : Form
    {
        static SqlCommand cmd;
        static DataTable inventoryTable = new DataTable();
        static Inventory inventoryPage = new Inventory();
        static bool isExisting = false, isTextEmpty = false;
        public UpdateInventory()
        {
            InitializeComponent();
        }

        private void VerifyBtn_Click(object sender, EventArgs e)
        {
            var localDateTime = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
            DataConnection.conn.Open();
            cmd = new SqlCommand("SELECT * FROM Products WHERE ItemId = @id", DataConnection.conn);
            cmd.Parameters.AddWithValue("@id", ItemIdBox.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();


            if (reader.HasRows)
            {
                isExisting = true;
                
                MessageBox.Show("Item found!");
                if (reader.Read())
                {
                    ItemIdBox.Text = reader.GetString(0);
                    NameBox.Text = reader.GetString(1);
                    BrandBox.Text = reader.GetString(2);
                    PriceBox.Text = reader.GetValue(3).ToString();
                    QuantityBox.Text = reader.GetValue(4).ToString();
                    TypeBox.Text = reader.GetString(5);
                    MemoBox.Text = $"Updated on {localDateTime} - ";
                }
            }
            else
            {
                reader.Close();
                isExisting = false;
               
                MessageBox.Show("Item has not been found!");
            }
            DataConnection.conn.Close();
        }

        private void UpdateInventory_Load(object sender, EventArgs e)
        {
            DataConnection.ShowAllInventoryTable();
            ItemIdBox.Focus();
            DataConnection.GetItemIdList();

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            var localDate = DateTime.Now;
            var time = DateTime.Now.ToString("HH:mm tt");

            DataConnection.conn.Open();

            if(ItemIdBox.Text.Equals("") || NameBox.Text.Equals("") || BrandBox.Text.Equals("") || PriceBox.Text.Equals("")
                || QuantityBox.Text.Equals("") || TypeBox.Text.Equals(""))
            {
                isTextEmpty = true;
            }
            else
            {
                isTextEmpty = false;
            }

            if (isExisting && !isTextEmpty && Regex.IsMatch(PriceBox.Text, InputValidation.numberPattern) && Regex.IsMatch(QuantityBox.Text, InputValidation.numberPattern))
            {
                DialogResult updateDiag = MessageBox.Show("Do you want to save changes?", "Save details", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(updateDiag == DialogResult.Yes)
                {
                    cmd = new SqlCommand("UPDATE Products SET ItemName = @name, ItemBrand = @brand," +
                        "ItemPrice = @price, ItemQuantity = @quantity, ItemType = @type, ItemMemo = @memo, Date = @date WHERE ItemId = @id", DataConnection.conn);
                    cmd.Parameters.AddWithValue("@id", ItemIdBox.Text);
                    cmd.Parameters.AddWithValue("@name", NameBox.Text);
                    cmd.Parameters.AddWithValue("@brand", BrandBox.Text);
                    cmd.Parameters.AddWithValue("@price", PriceBox.Text);
                    cmd.Parameters.AddWithValue("@quantity", QuantityBox.Text);
                    cmd.Parameters.AddWithValue("@type", TypeBox.Text);
                    cmd.Parameters.AddWithValue("@memo", MemoBox.Text);
                    cmd.Parameters.AddWithValue("@date", localDate);
                    cmd.ExecuteNonQuery();
                    DataConnection.ShowAllInventoryTable();
                    MessageBox.Show("Item has been updated!");

                    // will clear all text box in UpdateInventory page
                    ItemIdBox.Clear();
                    ClearTextBox(); 
                    isExisting = false;
                    isTextEmpty = false;
                }

            }
            else if (isTextEmpty == true)
            {
                MessageBox.Show("Please complete the empty details!", "Empty details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(Regex.IsMatch(PriceBox.Text, InputValidation.numberPattern) || Regex.IsMatch(QuantityBox.Text, InputValidation.numberPattern))
            {
                MessageBox.Show("Invalid input on Price or Quantity.", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // will show a message if the item is not verified as existing
                MessageBox.Show("Please verify the item first!", "Item Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataConnection.conn.Close();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            inventoryPage.Show();
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
            ActiveBox.ResetText();
            InactiveBox.ResetText();
        }

        private void InventoryGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show($"{DataConnection.ItemIdList[InventoryGrid.CurrentRow.Index]}");
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            // will clear all text box in UpdateInventory page
            ItemIdBox.Clear();
            ClearTextBox();
        }
    }
}
