﻿using System;
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
    public partial class Form1 : Form
    {

        static SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\E-PCdb.mdf;Integrated Security=True");
        static SqlCommand cmd;
        static AdminHome home;
        static bool isLogin = false;
        static string username, password = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("SELECT Username, Password FROM Credentials", conn);
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
            conn.Close();
            if(isLogin)
            {
                MessageBox.Show("Login successfully!");
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
