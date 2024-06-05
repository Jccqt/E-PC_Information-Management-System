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
            var localDate = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
            int actId = 10000;

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
                PriceLabel.Text += $"\nP{DataConnection.reader.GetValue(1)}";
            }
            TotalAmountLabel.Text = $"P{PaymentPage.totalAmount}";
            PaymentLabel.Text = $"P{PaymentPage.payment}";
            ExchangeLabel.Text = $"P{PaymentPage.exchange}";
            DateLabel.Text = localDate.ToString();
            CashierName.Text = $"{Login.fName} {Login.lName}";
            DataConnection.reader.Close();

            DataConnection.cmd = new SqlCommand($"SELECT COUNT(ActivityId) FROM Audit_Trail WHERE ActivityId LIKE '%{"SALES"}%'", DataConnection.conn);
            actId = Convert.ToInt32(DataConnection.cmd.ExecuteScalar());

            DataConnection.cmd = new SqlCommand("INSERT INTO Audit_Trail VALUES (@actId, @empId, @type, @description, @date)", DataConnection.conn);
            DataConnection.cmd.Parameters.AddWithValue("@actId", $"SALES{actId + 1}");
            DataConnection.cmd.Parameters.AddWithValue("@empId", Login.user);
            DataConnection.cmd.Parameters.AddWithValue("@type", "SALES");
            DataConnection.cmd.Parameters.AddWithValue("@description", $"{Login.fName} {Login.lName} Sold and completed the cartID {CartIdLabel.Text}");
            DataConnection.cmd.Parameters.AddWithValue("@date", localDate);
            DataConnection.cmd.ExecuteNonQuery();

            DataConnection.conn.Close();

            CashierOrderPage.cartIdList.Clear();
            CashierOrderPage.cartIdCount = 0;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }
    }
}
