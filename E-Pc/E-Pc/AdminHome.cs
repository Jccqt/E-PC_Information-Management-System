using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {

        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            DateTimer.Start();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            verify = new CustomerOrderCode();
            verify.Show();
            this.Hide();
        }
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            // if sidebar expand, minimize
            if (sidebarExpand)
            {

                sidebar.Width -= 10;


                if (sidebar.Width == sidebar.MinimumSize.Width)
                {

                    sidebarExpand = false;
                    sidebarTimer.Stop();

                }
            }
            else
            {
                sidebar.Width += 10;

                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            verify = new CustomerOrderCode();
            verify.Show();
            this.Hide();
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

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
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

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
