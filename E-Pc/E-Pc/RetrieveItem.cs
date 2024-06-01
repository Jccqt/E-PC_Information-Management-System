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
using System.IO;

namespace E_Pc
{
    public partial class RetrieveItem : UserControl
    {
        public RetrieveItem()
        {
            InitializeComponent();
        }

        private void RetrieveItem_Load(object sender, EventArgs e)
        {
            DataConnection.conn.Open();

            DataConnection.cmd = new SqlCommand("SELECT ItemName, ItemType, ItemQuantity, DeletionDate, ItemImage FROM Products WHERE ItemId = @id", DataConnection.conn);
            DataConnection.cmd.Parameters.AddWithValue("@id", Inventory.itemIdList[Inventory.itemIdCount]);
            DataConnection.reader = DataConnection.cmd.ExecuteReader();

            if (DataConnection.reader.Read())
            {
                NameLabel.Text = DataConnection.reader.GetString(0);
                IdLabel.Text = Inventory.itemIdList[Inventory.itemIdCount].ToString();
                TypeLabel.Text = DataConnection.reader.GetString(1);
                QuantityLabel.Text = DataConnection.reader.GetValue(2).ToString();
                DeletionDateLabel.Text = DataConnection.reader.GetValue(3).ToString();

                if (!DataConnection.reader.GetValue(4).ToString().Equals(""))
                {
                    byte[] imageBinary = (byte[])DataConnection.reader.GetValue(4);
                    using (MemoryStream ms = new MemoryStream(imageBinary))
                    {
                        ItemImage.Image = Image.FromStream(ms);
                        ItemImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    Array.Clear(imageBinary, 0, imageBinary.Length);
                }
                else
                {
                    ItemImage.Image = Properties.Resources.no_image_icon;
                    ItemImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                DataConnection.reader.Close();
                DataConnection.conn.Close();
            }
        }

        private void RetrieveBtn_Click(object sender, EventArgs e)
        {
            DialogResult retrieveDialog = MessageBox.Show("Are you sure you want to retrieve the item?", "Retrieve item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(retrieveDialog == DialogResult.Yes)
            {
                DataConnection.conn.Open();

                DataConnection.cmd = new SqlCommand("UPDATE Products SET Active_flag = 1, DeletionDate = NULL WHERE ItemId = @id", DataConnection.conn);
                DataConnection.cmd.Parameters.AddWithValue("@id", Inventory.itemIdList[Inventory.itemIdCount]);
                DataConnection.cmd.ExecuteNonQuery();

                MessageBox.Show("Item has been successfully retrieved!");
                PageObjects.inventoryPage.ShowArchivedProducts();
                DataConnection.conn.Close();
                ((Form)this.TopLevelControl).Close();
            }
        }
    }
}
