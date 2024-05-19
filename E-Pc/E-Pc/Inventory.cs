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
        static SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\E-PCdb.mdf;Integrated Security=True");
        static string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
        static string path = System.IO.Path.GetDirectoryName(executable);
        
        static SqlCommand cmd;
        static DataTable inventoryTable = new DataTable();
        static AddInventory addInventoryPage = new AddInventory();

        public Inventory()
        {
            InitializeComponent();
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            ShowInventory();
        }

        public void ShowInventory()
        {
            
            
            cmd = new SqlCommand("SELECT * FROM Products", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(inventoryTable);
            InventoryGrid.DataSource = inventoryTable;
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
    }
}
