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
        public static string user, fName, lName;
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
            user = "";
            DataConnection.conn.Open();
            cmd = new SqlCommand("SELECT Credentials.Username, Credentials.Password, Employees.Position, Employees.EmpId, " +
                "Employees.FirstName, Employees.LastName " +
                "FROM Credentials LEFT JOIN Employees ON Credentials.EmpId = Employees.EmpId", DataConnection.conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                username = (string)reader.GetValue(0);
                password = (string)reader.GetValue(1);
                if (usernameTxt.Text.Equals(username) && passwordTxt.Text.Equals(password))
                {
                    isLogin = true;
                    position = reader.GetString(2);
                    user = reader.GetValue(3).ToString();
                    fName = reader.GetString(4);
                    lName = reader.GetString(5);
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
