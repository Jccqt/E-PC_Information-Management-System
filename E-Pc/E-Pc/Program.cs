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
    }

    public class PageObjects
    {
        #region Inventory Objects
        public static byte[] imageBinary = new byte[0];
        public static bool isNewImage = false;
        public static Inventory inventoryPage = new Inventory();
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
