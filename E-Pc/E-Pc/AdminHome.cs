using System;
using System.Windows.Forms;

namespace E_Pc
{

    public partial class AdminHome : Form
    {
        static Login login = new Login();
        static Employee employeePage = new Employee();
        static DialogResult diag = new DialogResult();
        static CustomerOrderCode verify;
        bool sidebarExpand;
        public AdminHome()
        {
            InitializeComponent();
        }




        private void AdminHome_Load(object sender, EventArgs e)
        {
            DateTimer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verify = new CustomerOrderCode();
            verify.Show();
            this.Hide();
        }
       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            verify = new CustomerOrderCode();
            verify.Show();
            this.Hide();
        }

        private void LogoutLogo_Click(object sender, EventArgs e)
        {
            // will show a logout prompt when the user click the Logout icon
            diag = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diag == DialogResult.Yes)
            {
                // will go back to Login page when the user logs out
                Login.isLogin = false;
                login.Show();
                this.Close();
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            // will show a logout prompt when the user click the Logout button
            diag = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diag == DialogResult.Yes)
            {
                // will go back to Login page when the user logs out
                Login.isLogin = false;
                login.Show();
                this.Close();
            }
        }

        private void inventoryButton_Click_1(object sender, EventArgs e)
        {
            PageObjects.inventoryPage.Show();
            this.Hide();
            GC.Collect();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit(); // will close/terminate the application
        }

        private void DateTimer_Tick(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToString("dd/MM/yyy hh:mm:ss tt");
        }

        private void EmployeeManagementButton_Click(object sender, EventArgs e)
        {
            employeePage.Show();
            this.Hide();
        }
    }
}
