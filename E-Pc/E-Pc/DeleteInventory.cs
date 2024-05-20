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
    public partial class DeleteInventory : Form
    {
        static SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\E-PC_Information-Management-System\\E-Pc\\E-Pc\\E-PCdb.mdf;Integrated Security=True");
        static SqlCommand cmd;
        static DataTable deletedTable = new DataTable();
        static Inventory inventoryPage = new Inventory();
        static bool isExisting = false;
        public DeleteInventory()
        {
            InitializeComponent();
        }

        private void DeleteInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_E_PCdbDataSet_ProductsDel.Deleted_Products' table. You can move, or remove it, as needed.
            this.deleted_ProductsTableAdapter.Fill(this._E_PCdbDataSet_ProductsDel.Deleted_Products);
            ShowData();

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var localDate = DateTime.Now;

            conn.Open();

            if (isExisting)
            {
                // will show a deletion message
                DialogResult delDiag = MessageBox.Show("Are you sure you want to delete this item?", "Delete Item", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (delDiag == DialogResult.OK)
                {
                    // will insert select records from Products table to Deleted_Products table
                    cmd = new SqlCommand("INSERT INTO Deleted_Products (ItemId, ItemName, ItemBrand, ItemPrice, ItemQuantity, ItemType)"
                    + "SELECT ItemId, ItemName, ItemBrand, ItemPrice, ItemQuantity, ItemType FROM Products WHERE ItemId = '" + ItemIdBox.Text + "'", conn);
                    cmd.ExecuteNonQuery();

                    // will update the selected record in Deleted_Products table
                    cmd = new SqlCommand("UPDATE Deleted_Products SET ItemMemo = @memo, Date = @date WHERE ItemId = '" + ItemIdBox.Text + "'", conn);
                    cmd.Parameters.AddWithValue("@memo", MemoBox.Text);
                    cmd.Parameters.AddWithValue("@date", localDate);
                    cmd.ExecuteNonQuery();

                    // will delete the specific record in Products table
                    cmd = new SqlCommand("DELETE FROM Products WHERE ItemId = '" + ItemIdBox.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item has been deleted successfully!");
                    ItemIdBox.Clear();
                    MemoBox.Clear();
                }
            }
            else
            {
                // will show a message if the item is not verified as existing
                MessageBox.Show("Please verify the item first!","Item Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            isExisting = false;
            ShowData();
            conn.Close();
            pictureBox1.Visible = false;
        }

        void ShowData()
        {
            cmd = new SqlCommand("SELECT * FROM Deleted_Products", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            deletedTable.Clear();
            adapter.Fill(deletedTable);
            DeletedProductsGrid.DataSource = deletedTable;
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

        private void VerifyBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("SELECT ItemId, ItemName, ItemBrand, ItemPrice, ItemQuantity, ItemType FROM Products WHERE ItemId = '" + ItemIdBox.Text + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                isExisting = true;
                pictureBox1.Visible = true;
                MessageBox.Show("Item found!");
            }
            else
            {
                isExisting = false;
                MessageBox.Show("Item has not been found!");
            }
            reader.Close();
            conn.Close();
        }
    }
}
