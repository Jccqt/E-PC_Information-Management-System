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
        static SqlCommand cmd;
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
            PageObjects.addInventoryPage.Show();
            this.Hide();
        }
        public void ShowTable()
        {
            cmd = new SqlCommand("SELECT * FROM Products", DataConnection.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            PageObjects.inventoryTable.Clear();
            adapter.Fill(PageObjects.inventoryTable);
            InventoryGrid.DataSource = PageObjects.inventoryTable;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            PageObjects.deleteInventoryPage.Show();
            this.Hide();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            PageObjects.updateInventoryPage.Show();
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
                $"OR ItemQuantity LIKE '{SearchBox.Text}%'", DataConnection.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            PageObjects.inventoryTable.Clear();
            adapter.Fill(PageObjects.inventoryTable);
            InventoryGrid.DataSource = PageObjects.inventoryTable;
        }

        private void EmployeeManagementButton_Click(object sender, EventArgs e)
        {
            PageObjects.employeePage.Show();
            this.Hide();
        }
    }
}
