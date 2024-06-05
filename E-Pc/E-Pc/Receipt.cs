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

namespace E_Pc
{
    public partial class Receipt : UserControl
    {
        public Receipt()
        {
            InitializeComponent();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            DataConnection.conn.Open();
            CartIdLabel.Text = CashierOrderPage.cartIdList[CashierOrderPage.cartIdCount].ToString();

            DataConnection.cmd = new SqlCommand("SELECT Carts.OrderQuantity, Carts.OrderPrice, Products.ItemName " +
                "FROM Carts RIGHT JOIN Products ON Carts.ItemId = Products.ItemId WHERE CartId = @cartId", DataConnection.conn);
            DataConnection.cmd.Parameters.AddWithValue("@cartId", CashierOrderPage.cartIdList[CashierOrderPage.cartIdCount]);
            DataConnection.reader = DataConnection.cmd.ExecuteReader();

            while( DataConnection.reader.Read())
            {
                NameLabel.Text += $"\n{DataConnection.reader.GetString(2)}";
                QuantityLabel.Text += $"\n{DataConnection.reader.GetValue(0)}";
                PriceLabel.Text += $"\n{DataConnection.reader.GetValue(1)}";
            }
            TotalAmountLabel.Text = $"P{PaymentPage.totalAmount}";
            ExchangeLabel.Text = $"P{PaymentPage.exchange}";
            DataConnection.reader.Close();
            DataConnection.conn.Close();

        }


    }
}
