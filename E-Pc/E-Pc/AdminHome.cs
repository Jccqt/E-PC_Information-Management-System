using System;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace E_Pc
{

    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            UserLabel.Text = $"{Login.fName} {Login.lName}";
            DateTimer.Start();
        }


        private void LogoutLogo_Click(object sender, EventArgs e)
        {
            // will show a logout prompt when the user click the Logout icon
            DialogResult logoutDialog = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (logoutDialog == DialogResult.Yes)
            {
                using(Login login = new Login())
                {
                    // will go back to Login page when the user logs out
                    Login.isLogin = false;
                    login.Show();
                    this.Close();
                }
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            // will show a logout prompt when the user click the Logout icon
            DialogResult logoutDialog = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (logoutDialog == DialogResult.Yes)
            {
                PageObjects.login = new Login();
                // will go back to Login page when the user logs out
                Login.isLogin = false;
                PageObjects.login.Show();
                this.Close();
            }
        }

        private void inventoryButton_Click_1(object sender, EventArgs e)
        {
            PageObjects.inventoryPage = new Inventory();
            PageObjects.inventoryPage.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit(); // will close/terminate the application
        }

        private void DateTimer_Tick(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToString("dd/MM/yyy hh:mm:ss tt");
        }

        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            using(AdminReports reports = new AdminReports())
            {
                reports.ShowDialog();
                this.Hide();
            }
        }

        private void EmployeeManagementButton_Click(object sender, EventArgs e)
        {
            PageObjects.employeePage = new Employee();
            PageObjects.employeePage.Show();
            this.Hide();
        }
    }
}
