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
    public partial class AddInventory : Form
    {
        static Inventory inventoryPage = new Inventory();
        static SqlConnection conn = new SqlConnection(DataConnection.sqlCon);
        static SqlCommand cmd;
        static DataTable inventoryTable = new DataTable();
        static string idToCheck;
        static bool isExisting = false;
        
        public AddInventory()
        {
            InitializeComponent();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            inventoryPage.Show();
            this.Hide();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var date = DateTime.Now;

            conn.Open();
            cmd = new SqlCommand("SELECT ItemId FROM Products WHERE ItemId = '"+ItemIdBox.Text+"'", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                // will check if the Item ID is already existing
                idToCheck = reader.GetValue(0).ToString();
                if (idToCheck.Equals(ItemIdBox.Text.ToString()))
                {
                    isExisting = true;
                }
            }
            reader.Close();
            if (!isExisting)
            {
                cmd = new SqlCommand("INSERT INTO Products VALUES (@id, @name, @brand, @quantity, @price, @type, @memo, @date)", conn);
                cmd.Parameters.AddWithValue("@id", ItemIdBox.Text);
                cmd.Parameters.AddWithValue("@name", NameBox.Text);
                cmd.Parameters.AddWithValue("@brand", BrandBox.Text);
                cmd.Parameters.AddWithValue("@quantity", QuantityBox.Text);
                cmd.Parameters.AddWithValue("@price", PriceBox.Text);
                cmd.Parameters.AddWithValue("@type", TypeBox.Text);
                cmd.Parameters.AddWithValue("@memo", MemoBox.Text);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.ExecuteNonQuery();
                ShowTable();
                MessageBox.Show("Item has been added successfully!");
            }
            else
            {
                MessageBox.Show("Item was already existing!");
            }
            isExisting = false;
            conn.Close();
        }

        void ClearTextBox()
        {
            // will clear all the textbox in AddInventory form
            ItemIdBox.Clear();
            NameBox.Clear();
            BrandBox.Clear();
            QuantityBox.Clear();
            PriceBox.Clear();
            MemoBox.Clear();
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
                Application.Exit();
            }
        }

        private void AddInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_E_PCdbDataSet_ProductsAdd.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this._E_PCdbDataSet_ProductsAdd.Products);
            ShowTable();
            ItemIdBox.Focus();
        }

        public void ShowTable()
        {
            cmd = new SqlCommand("SELECT * FROM Products", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            inventoryTable.Clear();
            adapter.Fill(inventoryTable);
            InventoryGrid.DataSource = inventoryTable;
        }
    }
}
