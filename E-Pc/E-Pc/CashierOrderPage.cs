using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Management;

namespace E_Pc
{
    public partial class CashierOrderPage : Form
    {
        static Cart cart;
        public static int cartIdCount;
        public static ArrayList cartIdList = new ArrayList();
        public CashierOrderPage()
        {
            InitializeComponent();
        }
        
        private void ShowOrders()
        {
            var localDate = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");

            TableLabel.Text = $"{SortBox.SelectedItem} Orders"; // will set the table label basted on sortbox selected item
            OrdersPanel.Controls.Clear(); // will clear and remove all controls in OrdersPanel
            cartIdList.Clear(); // will clear the cartIdList array

            DataConnection.conn.Open();

            DataConnection.cmd = new SqlCommand("SELECT CartId, OrderDate FROM Carts WHERE Status = @status GROUP BY CartId, OrderDate", DataConnection.conn);
            DataConnection.cmd.Parameters.AddWithValue("@status", SortBox.SelectedItem);
            DataConnection.reader = DataConnection.cmd.ExecuteReader();

            while (DataConnection.reader.Read())
            {
                cart = new Cart();
                cartIdList.Add(DataConnection.reader.GetValue(0));
                cart.CartIdLabel.Text = $"Order code: {DataConnection.reader.GetValue(0)}";
                cart.DateLabel.Text = $"Date: {DataConnection.reader.GetValue(1)}";
                cart.CartImage.Image = Properties.Resources._714_7147174_png_file_svg_transparent_background_shopping_cart_icon;
                cart.CartImage.SizeMode = PictureBoxSizeMode.StretchImage;
                cart.CartImage.Tag = DataConnection.reader.GetValue(0);
                OrdersPanel.Controls.Add(cart);

                cart.CartImage.Click += new EventHandler(ViewCartDetails_Click);
            }
            DataConnection.reader.Close();
            DataConnection.conn.Close();
            GC.Collect();
        }

        private void ViewCartDetails_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            cartIdCount = cartIdList.IndexOf(pic.Tag);
            PageObjects.cartPage = new CashierShowCart();
            PageObjects.cartPage.Show();
            this.Hide();
            GC.Collect();
        }

        private void CashierOrderPage_Load(object sender, EventArgs e)
        {

            SortBox.SelectedItem = "Pending";
            ShowOrders(); // will display the pending carts
        }

        private void SortBox_SelectedIndexChanged(object sender, EventArgs e)
        { 
            ShowOrders(); // will display the different carts based on selected sort
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {

        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
