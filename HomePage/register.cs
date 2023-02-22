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
    public partial class register : Form
    {
        SqlConnection myconn;
        public register()
        {
            InitializeComponent();

        }

        private void phoneNumcb_CheckedChanged(object sender, EventArgs e)
        {
            phonelbl.Visible = phoneNumcb.Checked;
            phonetb.Visible = phoneNumcb.Checked;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addrcb_CheckedChanged(object sender, EventArgs e)
        {
            stlbl.Visible = addrcb.Checked;
            sttb.Visible = addrcb.Checked;
            statelbl.Visible = addrcb.Checked;
            statetb.Visible = addrcb.Checked;
            citlbl.Visible = addrcb.Checked;
            cittb.Visible = addrcb.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ((consenttb.Checked == false) || (passtb.Text == "") || (usrtb.Text == "") || (emtb.Text == "") || (fNtb.Text == "") || (lNtb.Text == ""))
            {
                MessageBox.Show("Please Finish filling out the Form!");
            }
            else
            {
                myconn = new SqlConnection();
                myconn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Adrian\\Desktop\\CST4718\\Fall2021-CST4708.mdf;Integrated Security=True;Connect Timeout=30";
                myconn.Open();

                SqlCommand mycommand = new SqlCommand();
                mycommand.Connection = myconn;
                mycommand.CommandText = "INSERT INTO Users (username, email, name, password, address, city, state) VALUES (@user, @email, @name, @pass, @address, @city, @state)";
                mycommand.Parameters.Add("@user", SqlDbType.VarChar, 50, "username");
                mycommand.Parameters["@user"].Value = usrtb.Text;
                mycommand.Parameters.Add("@name", SqlDbType.VarChar, 50, "name");
                mycommand.Parameters["@name"].Value = fNtb.Text + " " + lNtb.Text;
                mycommand.Parameters.Add("@email", SqlDbType.VarChar, 50, "email");
                mycommand.Parameters["@email"].Value = emtb.Text;
                mycommand.Parameters.Add("@pass", SqlDbType.VarChar, 50, "password");
                mycommand.Parameters["@pass"].Value = passtb.Text;
                mycommand.Parameters.Add("@address", SqlDbType.VarChar, 50, "address");
                mycommand.Parameters["@address"].Value = sttb.Text;
                mycommand.Parameters.Add("@city", SqlDbType.VarChar, 50, "city");
                mycommand.Parameters["@city"].Value = cittb.Text;
                mycommand.Parameters.Add("@state", SqlDbType.VarChar, 50, "state");
                mycommand.Parameters["@state"].Value = statetb.Text;

                mycommand.ExecuteNonQuery();

                MessageBox.Show("Thank you for Registering With Us");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void fNlbl_Click(object sender, EventArgs e)
        {

        }

        private void emlbl_Click(object sender, EventArgs e)
        {

        }

        private void lnlbl_Click(object sender, EventArgs e)
        {

        }

        private void phonelbl_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void passlbl_Click(object sender, EventArgs e)
        {

        }

        private void usrLbl_Click(object sender, EventArgs e)
        {

        }

        private void statelbl_Click(object sender, EventArgs e)
        {

        }

        private void stlbl_Click(object sender, EventArgs e)
        {

        }

        private void citlbl_Click(object sender, EventArgs e)
        {

        }
    }
}
