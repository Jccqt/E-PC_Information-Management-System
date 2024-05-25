using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

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
        public static string sqlCon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\E-PC_Information-Management-System\\E-Pc\\E-Pc\\E-PCdb.mdf;Integrated Security=True";
        public static SqlConnection conn = new SqlConnection(sqlCon);
    }

    public class InputValidation
    {
        public static string numberPattern = @"^[0-9,\.]+$";
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
