using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer
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
            Application.Run(new Home());
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
        public static BuyItems buyItemsPage = new BuyItems();
        public static CustomerShowCart cartPage;
    }

}
