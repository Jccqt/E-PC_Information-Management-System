using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

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
        public static string sqlCon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Nicol\\OneDrive\\Documents\\Jc\\E-PC_Information-Management-System\\E-Pc\\E-Pc\\E-PCdb.mdf;Integrated Security=True";
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
            PageObjects.inventoryTable.Clear();
            adapter.Fill(PageObjects.inventoryTable);
            PageObjects.inventoryPage.InventoryGrid.DataSource = PageObjects.inventoryTable;
        }

        public static void ShowActiveInventoryTable()
        {
            cmd = new SqlCommand("SELECT * FROM Products WHERE Active_flag = 1", conn);
            PageObjects.inventoryTable.Clear();
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(PageObjects.inventoryTable);
            PageObjects.inventoryPage.InventoryGrid.DataSource = PageObjects.inventoryTable;
            PageObjects.addInventoryPage.InventoryGrid.DataSource = PageObjects.inventoryTable;
        }

        public static void ShowAllInventoryTable()
        {
            cmd = new SqlCommand("SELECT * FROM Products", conn);
            adapter = new SqlDataAdapter(cmd);
            PageObjects.inventoryTable.Clear();
            adapter.Fill(PageObjects.inventoryTable);
            PageObjects.updateInventoryPage.InventoryGrid.DataSource = PageObjects.inventoryTable;
        }

        public static void AddProduct()
        {
            var date = DateTime.Now;
            idCount = 2000;

            cmd = new SqlCommand("INSERT INTO Products VALUES (@id, @name, @brand, @quantity, @price, @type, @category , @date, @flag)", conn);
            cmd.Parameters.AddWithValue("@id", $"{PageObjects.addInventoryPage.TypeBox.SelectedItem.ToString().ToUpper()}{idCount + 1}");
            cmd.Parameters.AddWithValue("@name", PageObjects.addInventoryPage.NameBox.Text);
            cmd.Parameters.AddWithValue("@brand", PageObjects.addInventoryPage.BrandBox.Text);
            cmd.Parameters.AddWithValue("@quantity", PageObjects.addInventoryPage.QuantityBox.Text);
            cmd.Parameters.AddWithValue("@price", PageObjects.addInventoryPage.PriceBox.Text);
            cmd.Parameters.AddWithValue("@type", PageObjects.addInventoryPage.TypeBox.SelectedItem);
            cmd.Parameters.AddWithValue("@category", PageObjects.addInventoryPage.CategoryBox.SelectedItem);
            cmd.Parameters.AddWithValue("@date", Convert.ToDateTime(date));
            cmd.Parameters.AddWithValue("@flag", 1);
            cmd.ExecuteNonQuery();
        }

        public static void CheckDuplicateProduct()
        {
            cmd = new SqlCommand("SELECT * FROM Products WHERE ItemType = @type", conn);
            cmd.Parameters.AddWithValue("@type", PageObjects.addInventoryPage.TypeBox.Text);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                idCount++;
            }
            reader.Close();

            cmd = new SqlCommand("SELECT ItemName FROM Products WHERE ItemName = @name", conn);
            cmd.Parameters.AddWithValue("@name", PageObjects.addInventoryPage.NameBox.Text);
            reader = cmd.ExecuteReader();
        }

        public static void GetItemIdList()
        {
            ItemIdList.Clear();
            conn.Open();
            cmd = new SqlCommand("SELECT ItemId FROM Products WHERE Active_flag = 1", conn);
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
    }

    public class InputValidation
    {
        public static string numberPattern = @"^[0-9,\.]+$";
        public static string numericPattern = @"^[0-9]+$";
        public static string datePattern = @"^[0-9]{4}-[0-9]{2}-[0-9]{2}$";
    }

    public class PageObjects
    {
        #region Inventory Objects
        public static Inventory inventoryPage = new Inventory();
        public static AddInventory addInventoryPage = new AddInventory();
        public static DeleteInventory deleteInventoryPage = new DeleteInventory();
        public static UpdateInventory updateInventoryPage = new UpdateInventory();
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
}
