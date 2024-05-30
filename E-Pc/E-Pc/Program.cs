using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace E_Pc
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }

    public class DataConnection
    {
        public static string sqlCon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Jc\\E-PC_Information-Management-System\\E-Pc\\E-Pc\\E-PCdb.mdf;Integrated Security=True";
        public static SqlConnection conn = new SqlConnection(sqlCon);
        public static SqlCommand cmd;
        public static SqlDataAdapter adapter;
        public static SqlDataReader reader;
        public static int idCount = 0;
        public static int ItemIdCount = 0;
        public static ArrayList ItemIdList = new ArrayList();

        public static void InventorySearch()
        {
            cmd = new SqlCommand($"SELECT * FROM Products WHERE " +
                $"ItemId LIKE '%{PageObjects.inventoryPage.SearchBox.Text}%' " +
                $"OR ItemName LIKE '%{PageObjects.inventoryPage.SearchBox.Text}%'" +
                $"OR ItemBrand LIKE '%{PageObjects.inventoryPage.SearchBox.Text}%'" +
                $"OR ItemType LIKE '%{PageObjects.inventoryPage.SearchBox.Text}%'" +
                $"OR ItemPrice LIKE '{PageObjects.inventoryPage.SearchBox.Text}%'" +
                $"OR ItemQuantity LIKE '{PageObjects.inventoryPage.SearchBox.Text}%'", conn);
            adapter = new SqlDataAdapter(cmd);
            PageObjects.inventoryTable.Clear();
            adapter.Fill(PageObjects.inventoryTable);
            PageObjects.inventoryPage.InventoryGrid.DataSource = PageObjects.inventoryTable;
        }

        public static void ShowActiveInventoryTable()
        {
            cmd = new SqlCommand("SELECT ItemID AS [Item ID]," +
                "ItemName AS Name," +
                "ItemBrand AS Brand," +
                "ItemPrice AS Price," +
                "ItemQuantity AS Quantity," +
                "ItemType AS Type," +
                "Category AS Category," +
                "ItemDescription AS Description," +
                "ItemMemo AS Memo," +
                "DateCreation AS [Created on]," +
                "Active_flag AS Flag FROM Products WHERE Active_flag = 1", conn);
            adapter = new SqlDataAdapter(cmd);
            PageObjects.activeInventoryTable.Clear();
            adapter.Fill(PageObjects.activeInventoryTable);
            PageObjects.addInventoryPage.InventoryGrid.DataSource = PageObjects.activeInventoryTable;
        }

        public static void ShowAllInventoryTable()
        {
            cmd = new SqlCommand("SELECT ItemID AS [Item ID]," +
                "ItemName AS Name," +
                "ItemBrand AS Brand," +
                "ItemPrice AS Price," +
                "ItemQuantity AS Quantity," +
                "ItemType AS Type," +
                "Category AS Category," +
                "ItemDescription AS Description," +
                "ItemMemo AS Memo," +
                "DateCreation AS [Created on]," +
                "Active_flag AS Flag FROM Products", conn);
            adapter = new SqlDataAdapter(cmd);
            PageObjects.inventoryTable.Clear();
            adapter.Fill(PageObjects.inventoryTable);
            PageObjects.updateInventoryPage.InventoryGrid.DataSource = PageObjects.inventoryTable;
            PageObjects.inventoryPage.InventoryGrid.DataSource = PageObjects.inventoryTable;
        }

        public static void AddProduct()
        {
            var date = DateTime.Now;
            idCount = 2000;

            cmd = new SqlCommand("SELECT COUNT(ItemType) FROM Products WHERE ItemType = @type", conn);
            cmd.Parameters.AddWithValue("@type", PageObjects.addInventoryPage.TypeBox.SelectedItem);
            idCount += int.Parse(cmd.ExecuteScalar().ToString());

            cmd = new SqlCommand("INSERT INTO Products (ItemId, ItemName, ItemBrand, ItemPrice, ItemQuantity, ItemType, Category, ItemDescription, DateCreation, Active_flag) " +
                "VALUES (@id, @name, @brand, @quantity, @price, @type, @category, @description, @date, @flag)", conn);
            cmd.Parameters.AddWithValue("@id", $"{PageObjects.addInventoryPage.TypeBox.SelectedItem.ToString().ToUpper()}{idCount + 1}");
            cmd.Parameters.AddWithValue("@name", PageObjects.addInventoryPage.NameBox.Text);
            cmd.Parameters.AddWithValue("@brand", PageObjects.addInventoryPage.BrandBox.Text);
            cmd.Parameters.AddWithValue("@quantity", PageObjects.addInventoryPage.QuantityBox.Text);
            cmd.Parameters.AddWithValue("@price", PageObjects.addInventoryPage.PriceBox.Text);
            cmd.Parameters.AddWithValue("@type", PageObjects.addInventoryPage.TypeBox.SelectedItem);
            cmd.Parameters.AddWithValue("@category", PageObjects.addInventoryPage.CategoryBox.SelectedItem);
            cmd.Parameters.AddWithValue("@description", PageObjects.addInventoryPage.DescriptionBox.Text);
            cmd.Parameters.AddWithValue("@date", Convert.ToDateTime(date));
            cmd.Parameters.AddWithValue("@flag", 1);
            cmd.ExecuteNonQuery();

            if (PageObjects.isNewImage)
            {
                cmd = new SqlCommand("UPDATE Products SET ItemImage = @image WHERE ItemId = @id", conn);
                cmd.Parameters.AddWithValue("@id", $"{PageObjects.addInventoryPage.TypeBox.SelectedItem.ToString().ToUpper()}{idCount + 1}");
                cmd.Parameters.AddWithValue("@image", PageObjects.imageBinary);
                cmd.ExecuteNonQuery();
            }
        }

        public static void CheckDuplicateProduct()
        {
            cmd = new SqlCommand("SELECT ItemName FROM Products WHERE ItemName = @name", conn);
            cmd.Parameters.AddWithValue("@name", PageObjects.addInventoryPage.NameBox.Text);
            reader = cmd.ExecuteReader();
        }

        public static void GetItemIdList()
        {
            ItemIdList.Clear();
            conn.Open();
            cmd = new SqlCommand("SELECT ItemId FROM Products", conn);
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ItemIdList.Add(reader.GetValue(0));
                }
            }

            reader.Close();
            conn.Close();
        }

        public static void InventoryDataInsert()
        {
            var localDate = DateTime.Now.ToString("dd/mm/yyyy hh:mm tt");

            cmd = new SqlCommand("SELECT * FROM Products WHERE ItemId = @id", conn);
            cmd.Parameters.AddWithValue("@id", ItemIdList[ItemIdCount]);
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                PageObjects.updateInventoryPage.ItemIdBox.Text = reader.GetString(0);
                PageObjects.updateInventoryPage.NameBox.Text = reader.GetString(1);
                PageObjects.updateInventoryPage.BrandBox.Text = reader.GetString(2);
                PageObjects.updateInventoryPage.PriceBox.Text = reader.GetValue(3).ToString();
                PageObjects.updateInventoryPage.QuantityBox.Text = reader.GetValue(4).ToString();
                PageObjects.updateInventoryPage.TypeBox.Text = reader.GetString(5);
                PageObjects.updateInventoryPage.CategoryBox.Text = reader.GetString(6);
                PageObjects.updateInventoryPage.DescriptionBox.Text = reader.GetString(7);
                PageObjects.updateInventoryPage.MemoBox.Text = $"Updated on {localDate} - ";
                
                if(!reader.GetValue(10).ToString().Equals(""))
                {
                    byte[] imageBinary = (byte[])reader.GetValue(10);
                    using (MemoryStream ms = new MemoryStream(imageBinary))
                    {
                        PageObjects.updateInventoryPage.ItemImage.Image = Image.FromStream(ms);
                        PageObjects.updateInventoryPage.ItemImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    PageObjects.updateInventoryPage.ItemImage.Image = Properties.Resources.no_image_icon;
                    PageObjects.updateInventoryPage.ItemImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }


                if (reader.GetValue(11).ToString().Equals("1"))
                {
                    PageObjects.updateInventoryPage.ActiveBox.Select();
                }
                else
                {
                    PageObjects.updateInventoryPage.InactiveBox.Select();
                }


            }
            reader.Close();
        }

        public static void updateInventory()
        {

            cmd = new SqlCommand("UPDATE Products SET ItemName = @name, ItemBrand = @brand, ItemPrice = @price, ItemType = @type" +
                ", Category = @category, ItemDescription = @description, ItemMemo = @memo" +
                ", Active_flag = @flag WHERE ItemId = @id", conn);
            cmd.Parameters.AddWithValue("@id", ItemIdList[ItemIdCount]);
            cmd.Parameters.AddWithValue("@name", PageObjects.updateInventoryPage.NameBox.Text);
            cmd.Parameters.AddWithValue("@brand", PageObjects.updateInventoryPage.BrandBox.Text);
            cmd.Parameters.AddWithValue("@price", PageObjects.updateInventoryPage.PriceBox.Text);
            cmd.Parameters.AddWithValue("@type", PageObjects.updateInventoryPage.TypeBox.Text);
            cmd.Parameters.AddWithValue("@category", PageObjects.updateInventoryPage.CategoryBox.Text);
            cmd.Parameters.AddWithValue("@description", PageObjects.updateInventoryPage.DescriptionBox.Text);
            cmd.Parameters.AddWithValue("@memo", PageObjects.updateInventoryPage.MemoBox.Text);
 
            if (PageObjects.updateInventoryPage.ActiveBox.Checked)
            {
                cmd.Parameters.AddWithValue("@flag", 1);
            }
            else
            {
                cmd.Parameters.AddWithValue("@flag", 0);
            }
            cmd.ExecuteNonQuery();
            

            if (PageObjects.isNewImage)
            {
                cmd = new SqlCommand("UPDATE Products SET ItemImage = @image WHERE ItemId = @id", conn);
                cmd.Parameters.AddWithValue("@id", ItemIdList[ItemIdCount]);
                cmd.Parameters.AddWithValue("@image", PageObjects.imageBinary);
                cmd.ExecuteNonQuery();

                PageObjects.isNewImage = false;
            }
            
        }
    }

    public class PageObjects
    {
        #region Inventory Objects
        public static byte[] imageBinary = new byte[0];
        public static bool isNewImage = false;
        public static Inventory inventoryPage = new Inventory();
        public static AddInventory addInventoryPage = new AddInventory();
        public static DeleteInventory deleteInventoryPage = new DeleteInventory();
        public static UpdateInventory updateInventoryPage = new UpdateInventory();
        public static DataTable activeInventoryTable = new DataTable();
        public static DataTable inventoryTable = new DataTable();
        public static DataTable deletedInventoryTable = new DataTable();
        #endregion

        #region Employee Objects
        public static Employee employeePage = new Employee();
        public static AddEmployee addEmployeePage = new AddEmployee();
        public static RemoveEmployee removeEmployeePage = new RemoveEmployee();
        public static UpdateEmployee updateEmployeePage = new UpdateEmployee();
        public static DataTable employeeTable = new DataTable();
        public static DataTable removedEmployeeTable = new DataTable();
        #endregion
    }

    public class InputValidation
    {
        public static string numberPattern = @"^[0-9,\.]+$";
        public static string numericPattern = @"^[0-9]+$";
        public static string datePattern = @"^[0-9]{4}-[0-9]{2}-[0-9]{2}$";
    }
}
