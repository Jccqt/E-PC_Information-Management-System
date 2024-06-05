using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Collections;
using System.Text.RegularExpressions;

namespace E_Pc
{
    public partial class PaymentPage : Form
    {
        public static decimal totalAmount = 0;
        public static int totalQuantity = 0;
        public static decimal exchange = 0;
        public static decimal payment = 0;
        static bool isPaid = false;
        static ArrayList itemId = new ArrayList();
        static ArrayList itemQuantity = new ArrayList()
;        public PaymentPage()
        {
            InitializeComponent();
        }

        private void PaymentPage_Load(object sender, EventArgs e)
        {
            DataConnection.conn.Open();
            CodeLabel.Text = CashierOrderPage.cartIdList[CashierOrderPage.cartIdCount].ToString();

            DataConnection.cmd = new SqlCommand("SELECT Carts.OrderQuantity, Carts.OrderPrice, Carts.OrderDate, " +
                "Products.ItemName, Products.ItemType, Products.Category, Products.ItemImage, Carts.ItemId " +
                "FROM Carts RIGHT JOIN Products ON Carts.ItemId = Products.ItemId WHERE CartId = @cartId", DataConnection.conn);
            DataConnection.cmd.Parameters.AddWithValue("@cartId", CashierOrderPage.cartIdList[CashierOrderPage.cartIdCount]);
            DataConnection.reader = DataConnection.cmd.ExecuteReader();

            while(DataConnection.reader.Read())
            {
                PaymentItems items = new PaymentItems();

                if (!DataConnection.reader.GetValue(6).ToString().Equals(""))
                {
                    byte[] imageBinary = (byte[])DataConnection.reader.GetValue(6);
                    using (MemoryStream ms = new MemoryStream(imageBinary))
                    {
                        items.ItemImage.Image = Image.FromStream(ms);
                        items.ItemImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    Array.Clear(imageBinary, 0, imageBinary.Length);

                }
                else
                {
                    items.ItemImage.Image = Properties.Resources.no_image_icon;
                    items.ItemImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                items.QuantityLabel.Text = DataConnection.reader.GetValue(0).ToString();
                items.PriceLabel.Text = DataConnection.reader.GetValue(1).ToString();
                items.NameLabel.Text = DataConnection.reader.GetString(3);
                items.TypeLabel.Text = DataConnection.reader.GetString(4);
                items.CategoryLabel.Text = DataConnection.reader.GetString(5);

                DateLabel.Text = DataConnection.reader.GetValue(2).ToString();
                itemId.Add(DataConnection.reader.GetString(7));
                itemQuantity.Add(DataConnection.reader.GetValue(0));
                CartPanel.Controls.Add(items);
            }
            DataConnection.reader.Close();

            DataConnection.cmd = new SqlCommand("SELECT SUM(OrderQuantity) FROM Carts WHERE CartId = @cartId", DataConnection.conn);
            DataConnection.cmd.Parameters.AddWithValue("@cartId", CashierOrderPage.cartIdList[CashierOrderPage.cartIdCount]);
            totalQuantity = Convert.ToInt32(DataConnection.cmd.ExecuteScalar());
            TotalAmountBox.Text = totalQuantity.ToString();

            DataConnection.cmd = new SqlCommand("SELECT SUM(OrderPrice) FROM Carts WHERE CartId = @cartId", DataConnection.conn);
            DataConnection.cmd.Parameters.AddWithValue("@cartId", CashierOrderPage.cartIdList[CashierOrderPage.cartIdCount]);
            totalAmount = Convert.ToDecimal(DataConnection.cmd.ExecuteScalar());
            TotalAmountBox.Text = $"P{totalAmount}";

            DataConnection.conn.Close();
            GC.Collect();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            PageObjects.cartPage.Show();
            this.Close();
        }

        private void PaymentBox_TextChanged(object sender, EventArgs e)
        {
            if (!PaymentBox.Text.Equals("") && Regex.IsMatch(PaymentBox.Text, InputValidation.numberPattern))
            {

                if (totalAmount <= Convert.ToDecimal(PaymentBox.Text))
                {
                    ExchangeBox.Text = (Convert.ToDecimal(PaymentBox.Text) - totalAmount).ToString();
                    isPaid = true;
                    exchange = Convert.ToDecimal(ExchangeBox.Text);
                    payment = Convert.ToDecimal(PaymentBox.Text);
                }
                else
                {
                    ExchangeBox.Text = "0.00";
                    isPaid = false;
                }
            }
            else if (!PaymentBox.Text.Equals("") && !Regex.IsMatch(PaymentBox.Text, InputValidation.numberPattern))
            {
                // will show an error message if the payment box has a character
                MessageBox.Show("Please input numbers only!", "Invalid input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PaymentBox.Text = PaymentBox.Text.Remove(PaymentBox.Text.Length - 1); // will remove the character in PaymentBox
                
            }
            else
            {
                ExchangeBox.Text = "0.00";
                isPaid = false;
            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            if (isPaid)
            {
                DataConnection.conn.Open();

                for (int i = 0; i < itemId.Count; i++)
                {
                    DataConnection.cmd = new SqlCommand("SELECT ItemQuantity FROM Products WHERE ItemId = @id", DataConnection.conn);
                    DataConnection.cmd.Parameters.AddWithValue("@id", itemId[i]);
                    int currentQuantity = Convert.ToInt32(DataConnection.cmd.ExecuteScalar());

                    DataConnection.cmd = new SqlCommand("UPDATE Products SET ItemQuantity = @quantity WHERE ItemId = @id", DataConnection.conn);
                    DataConnection.cmd.Parameters.AddWithValue("@id", itemId[i]);
                    DataConnection.cmd.Parameters.AddWithValue("@quantity", currentQuantity - Convert.ToInt32(itemQuantity[i]));
                    DataConnection.cmd.ExecuteNonQuery();

                    DataConnection.cmd = new SqlCommand("UPDATE Carts SET Status = @status WHERE CartId = @cartId", DataConnection.conn);
                    DataConnection.cmd.Parameters.AddWithValue("@cartId", CashierOrderPage.cartIdList[CashierOrderPage.cartIdCount]);
                    DataConnection.cmd.Parameters.AddWithValue("@status", "Completed");
                    DataConnection.cmd.ExecuteNonQuery();
                }
                DataConnection.conn.Close();

                Form form = new Form();
                form.Controls.Add(new Receipt());
                form.ClientSize = new System.Drawing.Size(374, 726);
                form.FormBorderStyle = FormBorderStyle.None;
                form.ShowDialog();
                form.AutoSize = true;
                
            }
            else
            {
                MessageBox.Show("Insufficient payment! Please re-enter the payment", "Insufficient Payment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PaymentBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
