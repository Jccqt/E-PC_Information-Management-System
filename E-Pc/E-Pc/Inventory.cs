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
    public partial class Inventory : Form
    {
        static SqlConnection conn = new SqlConnection(DataConnection.sqlCon);
        static SqlCommand cmd;
        static DataTable inventoryTable = new DataTable();
        static AddInventory addInventoryPage = new AddInventory();
        static DeleteInventory delInventoryPage = new DeleteInventory();
        static UpdateInventory updateInventoryPage = new UpdateInventory();
        static string searchType;

        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            ShowTable();
        }


        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult exitDiag = MessageBox.Show("Are you sure you want to exit the application?", "Exit Application?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(exitDiag == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            addInventoryPage.Show();
            this.Hide();
        }
        public void ShowTable()
        {
            cmd = new SqlCommand("SELECT * FROM Products", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            inventoryTable.Clear();
            adapter.Fill(inventoryTable);
            InventoryGrid.DataSource = inventoryTable;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            delInventoryPage.Show();
            this.Hide();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            updateInventoryPage.Show();
            this.Hide();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if(SearchBox.Text.Equals("Search here.."))
            {
                SearchBox.Clear();
            }
            cmd = new SqlCommand($"SELECT * FROM Products WHERE " +
                $"ItemId LIKE '%{SearchBox.Text}%' " +
                $"OR ItemName LIKE '%{SearchBox.Text}%'" +
                $"OR ItemBrand LIKE '%{SearchBox.Text}%'" +
                $"OR ItemType LIKE '%{SearchBox.Text}%'" +
                $"OR ItemPrice LIKE '{SearchBox.Text}%'" +
                $"OR ItemQuantity LIKE '{SearchBox.Text}%'", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            inventoryTable.Clear();
            adapter.Fill(inventoryTable);
            InventoryGrid.DataSource = inventoryTable;
        }
    }
}
