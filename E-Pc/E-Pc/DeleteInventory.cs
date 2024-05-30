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
            DataConnection.conn.Open();
            DataConnection.activeItemIdCount = InventoryGrid.CurrentRow.Index;
            DataConnection.InventoryToDeleteDataInsert();
            DataConnection.conn.Close();

        }

        private void DeleteInventory_Load(object sender, System.EventArgs e)
        {
            DataConnection.GetActiveItemIdList();
            DataConnection.ShowAllInventoryTable();
            foreach (DataGridViewColumn column in InventoryGrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void ReturnBtn_Click(object sender, System.EventArgs e)
        {
            PageObjects.inventoryPage.Show();
            this.Hide();
        }
    }
}
