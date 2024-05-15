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
    }
}
