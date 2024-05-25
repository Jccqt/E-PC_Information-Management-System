using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data.SqlClient;

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
    }

    public class InputValidation
    {
        public static string numberPattern = @"^[0-9,\.]+$";
    }
}
