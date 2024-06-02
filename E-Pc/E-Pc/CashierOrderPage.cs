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
            SortBox.SelectedItem = "Pending";
            TableLabel.Text = "Pending Orders";
        }
        
        private void ShowOrders()
        {
            TableLabel.Text = $"{SortBox.SelectedItem} Orders";
            OrdersPanel.Controls.Clear();
            cartIdList.Clear();

            DataConnection.conn.Open();

            DataConnection.cmd = new SqlCommand("SELECT CartId, OrderDate FROM Carts GROUP BY CartId, OrderDate", DataConnection.conn);
 
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
        }

        private void ViewCartDetails_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            cartIdCount = cartIdList.IndexOf(pic.Tag);
            Form form = new Form();
            form.Controls.Add(new CashierShowCart());
            form.StartPosition = FormStartPosition.CenterScreen;
            form.AutoSize = true;
            form.Text = "View cart";
            form.ShowDialog();
        }

        private void CashierOrderPage_Load(object sender, EventArgs e)
        {
            ShowOrders();
        }
    }
}
