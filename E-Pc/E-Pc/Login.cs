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

namespace E_Pc
{
    public partial class Login : Form
    {
        static SqlCommand cmd;
        static AdminHome home;
        public static bool isLogin = false;
        static string username, password = "";
        public Login()
        {
            InitializeComponent();
            usernameTxt.Focus();
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            DateTimer.Start();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); // will terminate the application
        }

        private void DateTimer_Tick(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToString("dd/MM/yyy hh:mm:ss tt");
        }


        private void LogInButton_Click(object sender, EventArgs e)
        {
            DataConnection.conn.Open();
            cmd = new SqlCommand("SELECT Username, Password FROM Credentials", DataConnection.conn);
            SqlDataReader reader = cmd.ExecuteReader();
           
            while(reader.Read())
            {
                username = (string)reader.GetValue(0);
                password = (string)reader.GetValue(1);
                if (usernameTxt.Text.Equals(username) && passwordTxt.Text.Equals(password))
                {
                    isLogin = true;
                    
                }
            }
            DataConnection.conn.Close();
            if(isLogin)
            {
                MessageBox.Show("Login successfully!");
                usernameTxt.ResetText();
                passwordTxt.ResetText();
                home = new AdminHome();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed!");
            }
        }

    }
}
