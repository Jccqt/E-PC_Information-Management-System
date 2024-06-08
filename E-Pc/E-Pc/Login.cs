using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace E_Pc
{
    public partial class Login : Form
    {
        static SqlCommand cmd;
        public static bool isLogin = false;
        static string username, password, position;
        public static string userId, fName, lName;
        public Login()
        {
            InitializeComponent();
            usernameTxt.Focus(); // will focus the insert mode in username box
        }


        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); // will terminate the application
        }


        private void LogInButton_Click(object sender, EventArgs e)
        {
            userId = "";
            DataConnection.conn.Open();
            cmd = new SqlCommand("SELECT EmpId, Position, FirstName, LastName, Username, Password FROM Employees WHERE Active_flag = 1", DataConnection.conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                username = (string)reader.GetValue(4);
                password = (string)reader.GetValue(5);
                if (usernameTxt.Text.Equals(username) && passwordTxt.Text.Equals(password))
                {
                    isLogin = true;
                    userId = reader.GetValue(0).ToString();
                    position = reader.GetString(1);
                    fName = reader.GetString(2);
                    lName = reader.GetString(3);
                }
            }
            DataConnection.conn.Close();
            if (isLogin && position.Equals("Admin")) 
            {
                // will display the admin homepage if the employee position is admin
                using (AdminHome admin = new AdminHome())
                {
                    MessageBox.Show("Login successfully!");
                    usernameTxt.ResetText();
                    passwordTxt.ResetText();
                    admin.ShowDialog();
                    this.Hide();
                }
            }
            else if (isLogin && position.Equals("Cashier"))
            {
                // will display the cashier homepage if the employee position is cashier
                using(CashierHomepage cashier = new CashierHomepage())
                {
                    MessageBox.Show("Login successfully!");
                    usernameTxt.ResetText();
                    passwordTxt.ResetText();
                    cashier.ShowDialog();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Login failed!");
            }
        }

    }
}
