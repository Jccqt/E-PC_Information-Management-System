using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        static bool isExisting = false, isTextEmpty = false;
        
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
            int idCount = 2000;

            conn.Open();
            cmd = new SqlCommand("SELECT * FROM Products WHERE ItemType = @type", conn);
            cmd.Parameters.AddWithValue("@type", TypeBox.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                idCount++;
            }

            reader.Close();

            cmd = new SqlCommand("SELECT ItemName FROM Products WHERE ItemName = @name", conn);
            cmd.Parameters.AddWithValue("@name", NameBox.Text);
            reader = cmd.ExecuteReader();
  
            if (reader.Read())
            {
                // will check if the Item ID is already existing
                idToCheck = reader.GetValue(0).ToString().ToUpper();
                if (idToCheck.Equals(NameBox.Text.ToString().ToUpper()))
                {
                    isExisting = true;
                }
            }
            reader.Close();

            if (NameBox.Text.Equals("") || BrandBox.Text.Equals("") || PriceBox.Text.Equals("") || QuantityBox.Text.Equals("") || TypeBox.Text.Equals(""))
            {
                isTextEmpty = true;
            }

            if (!isExisting && !isTextEmpty)
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO Products VALUES (@id, @name, @brand, @quantity, @price, @type, @memo, @date)", conn);
                    cmd.Parameters.AddWithValue("@id", $"{TypeBox.Text.ToUpper()}{idCount + 1}");
                    cmd.Parameters.AddWithValue("@name", NameBox.Text);
                    cmd.Parameters.AddWithValue("@brand", BrandBox.Text);
                    cmd.Parameters.AddWithValue("@quantity", QuantityBox.Text);
                    cmd.Parameters.AddWithValue("@price", PriceBox.Text);
                    cmd.Parameters.AddWithValue("@type", TypeBox.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@memo", MemoBox.Text);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.ExecuteNonQuery();
                    ShowTable();
                    ClearTextBox();
                    MessageBox.Show("Item has been added successfully!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Invalid input on Price or Quantity.", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(isTextEmpty)
            {
               
                MessageBox.Show("Please make sure that input box/es is not empty.", "Empty input box/es.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("You cannot add the item because it is already existing.", "Item existing already!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            isTextEmpty = false;
            isExisting = false;
            conn.Close();
        }

        void ClearTextBox()
        {
            // will clear all the textbox in AddInventory form
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
            ShowTable();
            NameBox.Focus();
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
