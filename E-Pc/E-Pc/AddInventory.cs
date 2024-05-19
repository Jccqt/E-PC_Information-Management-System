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
        static SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Nicol\\OneDrive\\Documents\\Jc\\E-PC_Information-Management-System\\E-Pc\\E-Pc\\E-PCdb.mdf;Integrated Security=True");
        static SqlCommand cmd;
        
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
            MessageBox.Show("Item has been added successfully!");
            conn.Close();
        }

        void ClearTextBox()
        {
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
    }
}
