using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage
{
    public partial class loginForm : Form
    {
        SqlConnection conn;
        register registerForm = new register();
        homeForm homeForm = new homeForm();

        static String adminUser = "user1";

        public loginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String username = usernameText.Text;
            String password = passwordText.Text;

            if (username.Trim().Equals(""))
            {
                MessageBox.Show("Username is required!", "Login Error!");
                return;
            }

            if (password.Trim().Equals(""))
            {
                MessageBox.Show("Password is required!", "Login Error!");
                return;
            }

            conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Adrian\\Desktop\\CST4718\\Fall2021-CST4708.mdf;Integrated Security=True;Connect Timeout=30";
            conn.Open();

            SqlCommand query = new SqlCommand();
            query.Parameters.Add("@username", SqlDbType.VarChar, 100, "username").Value = username;
            query.Parameters.Add("@password", SqlDbType.VarChar, 100, "password").Value = password;
            query.CommandText = "SELECT COUNT(*) FROM Users WHERE username = @username AND password = @password";
            query.Connection = conn;

            int result = (Int32)query.ExecuteScalar();

            conn.Close();

            if (result == 1)
            {
                String LoggedUser = username;

                // Do login stuff here. Open new frame?
                MessageBox.Show("Login successful!");
                this.Hide();
                homeForm.ShowDialog();
                this.Show();
                

            }
            else
            {
                MessageBox.Show("Username or password is incorrect!");
            }

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            registerForm.ShowDialog();
            this.Show();
        }
    }
}