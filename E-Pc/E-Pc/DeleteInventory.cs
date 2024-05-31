using System;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace E_Pc
{
    public partial class DeleteInventory : Form
    {
        public DeleteInventory()
        {
            InitializeComponent();
        }

        private void InventoryGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearTextBox();
            QuantityToDeleteBox.Enabled = true;
            DataConnection.conn.Open();
            DataConnection.activeItemIdCount = InventoryGrid.CurrentRow.Index;
            DataConnection.InventoryToDeleteDataInsert();
            DataConnection.conn.Close();

        }

        private void DeleteInventory_Load(object sender, System.EventArgs e)
        {
            DataConnection.GetDeletedItemIdList();
            DataConnection.GetActiveItemIdList();
            DataConnection.ShowDeletedInventory();
            DataConnection.ShowActiveInventoryTable();
            foreach (DataGridViewColumn column in InventoryGrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            foreach(DataGridViewColumn column in DeletedInventoryGrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void ReturnBtn_Click(object sender, System.EventArgs e)
        {
            PageObjects.inventoryPage.Show();
            this.Hide();
        }

        private void DeleteBtn_Click(object sender, System.EventArgs e)
        {
            if(!QuantityToDeleteBox.Text.Equals(""))
            {
                DialogResult deleteDialog = MessageBox.Show("Are you sure you want to decrease the item quantity?", "Decrease Quantity", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (deleteDialog == DialogResult.Yes)
                {
                    DataConnection.conn.Open();
                    DataConnection.DeleteInventory();
                    DataConnection.conn.Close();

                    MessageBox.Show("Item quantity has been decreased!");
                    MessageBox.Show("Please refresh the Deleted Inventory table");
                    ClearTextBox();
                    QuantityToDeleteBox.Enabled = false;
                    Array.Clear(PageObjects.imageBinary, 0, PageObjects.imageBinary.Length);
                }
            }
            else
            {
                MessageBox.Show("Invalid delete quantity! Please enter a valid quantity", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ClearTextBox()
        {
            NameBox.Clear();
            BrandBox.Clear();
            StatusBox.Clear();
            QuantityBox.Clear();
            QuantityToDeleteBox.Clear();
            TypeBox.ResetText();
            MemoBox.Clear();
            CategoryBox.ResetText();
            DeletionIdBox.Clear();
            DeletedQuantityBox.Clear();
            StatusBox.Clear();
            ItemImage.Image = null;
        }

        private void DeletedInventoryRefresh_Click(object sender, EventArgs e)
        {
           
            DataConnection.GetDeletedItemIdList();
            DataConnection.ShowDeletedInventory();
            foreach (DataGridViewColumn column in DeletedInventoryGrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void DeletedInventoryGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            ClearTextBox();
            QuantityToDeleteBox.Enabled = false;
            DataConnection.conn.Open();
            DataConnection.deletedItemIdCount = DeletedInventoryGrid.CurrentRow.Index;
            DataConnection.DeletedInventoryDataInsert();
            DataConnection.conn.Close();

        }


    }
}
