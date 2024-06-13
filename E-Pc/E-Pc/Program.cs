using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Security.Policy;
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
        public static string sqlCon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Nicol\\OneDrive\\Documents\\Jc\\E-PC_Information-Management-System\\E-Pc\\E-Pc\\E-PCdb.mdf;Integrated Security=True";
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
        public static Inventory inventoryPage;
        public static AdminHome adminHomePage = new AdminHome();
        public static CashierOrderPage cashierOrderPage = new CashierOrderPage();
        public static CashierShowCart cartPage;
        public static Employee employeePage;
        public static AdminReports reportsPage = new AdminReports();
        public static Login login;
        public static EditItem editItemPage;
        #endregion

        #region Employee Objects

        #endregion
    }

    public class InputValidation
    {
        public static string numberPattern = @"^[0-9,\.]+$";
        public static string numericPattern = @"^[0-9]+$";
        public static string datePattern = @"^[0-9]{4}-[0-9]{2}-[0-9]{2}$";
    }
}
