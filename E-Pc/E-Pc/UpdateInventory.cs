using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Pc
{
    public partial class UpdateInventory : Form
    {
        static SqlConnection conn = new SqlConnection(DataConnection.sqlCon);
        static SqlCommand cmd;
        static DataTable inventoryTable = new DataTable();
        static Inventory inventoryPage = new Inventory();
        static bool isExisting = false, isTextBox = false;
        public UpdateInventory()
        {
            InitializeComponent();
        }

        private void VerifyBtn_Click(object sender, EventArgs e)
        {
            var localDateTime = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM Products WHERE ItemId = @id", conn);
            cmd.Parameters.AddWithValue("@id", ItemIdBox.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();


            if (reader.HasRows)
            {
                isExisting = true;
                CheckPic.Visible = true;
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
                CheckPic.Visible = false;
                MessageBox.Show("Item has not been found!");
            }
            conn.Close();
        }

        private void UpdateInventory_Load(object sender, EventArgs e)
        {
            ShowData();
            ItemIdBox.Focus();

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            var localDate = DateTime.Now;
            var time = DateTime.Now.ToString("HH:mm tt");

            conn.Open();

            if (isExisting)
            {
                DialogResult updateDiag = MessageBox.Show("Do you want to save changes?", "Save details", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(updateDiag == DialogResult.Yes)
                {
                    cmd = new SqlCommand("UPDATE Products SET ItemName = @name, ItemBrand = @brand," +
                        "ItemPrice = @price, ItemQuantity = @quantity, ItemType = @type, ItemMemo = @memo, Date = @date WHERE ItemId = @id", conn);
                    cmd.Parameters.AddWithValue("@id", ItemIdBox.Text);
                    cmd.Parameters.AddWithValue("@name", NameBox.Text);
                    cmd.Parameters.AddWithValue("@brand", BrandBox.Text);
                    cmd.Parameters.AddWithValue("@price", PriceBox.Text);
                    cmd.Parameters.AddWithValue("@quantity", QuantityBox.Text);
                    cmd.Parameters.AddWithValue("@type", TypeBox.Text);
                    cmd.Parameters.AddWithValue("@memo", MemoBox.Text);
                    cmd.Parameters.AddWithValue("@date", localDate);
                    cmd.ExecuteNonQuery();
                    ShowData();
                    MessageBox.Show("Item has been updated!");

                    // will clear all text box in UpdateInventory page
                    ItemIdBox.Clear();
                    ClearTextBox(); 
                    isExisting = false;
                }

            }
            else
            {
                // will show a message if the item is not verified as existing
                MessageBox.Show("Please verify the item first!", "Item Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
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
        void ShowData()
        {
            cmd = new SqlCommand("SELECT * FROM Products", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            inventoryTable.Clear();
            adapter.Fill(inventoryTable);
            InventoryGrid.DataSource = inventoryTable;
        }

        private void ItemIdBox_TextChanged(object sender, EventArgs e)
        {
            if (isExisting)
            {
                isExisting = false;
                CheckPic.Visible = false;
                ClearTextBox(); // will clear all text box in UpdateInventory page

            }
        }

        void ClearTextBox()
        {
            NameBox.Clear();
            BrandBox.Clear();
            PriceBox.Clear();
            QuantityBox.Clear();
            TypeBox.Clear();
            MemoBox.Clear();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            // will clear all text box in UpdateInventory page
            ItemIdBox.Clear();
            ClearTextBox();
        }
    }
}
