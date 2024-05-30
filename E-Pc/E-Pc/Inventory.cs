using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

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
            DataConnection.ShowAllInventoryTable();
        }


        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult exitDiag = MessageBox.Show("Are you sure you want to exit the application?", "Exit Application?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitDiag == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            PageObjects.addInventoryPage.Refresh();
            PageObjects.addInventoryPage.Show();
            this.Hide();
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
            if (SearchBox.Text.Equals("Search here.."))
            {
                SearchBox.Clear();
            }
            DataConnection.InventorySearch();
        }

        private void EmployeeManagementButton_Click(object sender, EventArgs e)
        {
            PageObjects.employeePage.Show();
            this.Hide();
        }
    }
}
