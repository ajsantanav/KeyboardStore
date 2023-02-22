using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HomePage
{
    public partial class AdminTool : Form
    {

        DataTable dataTable;
        SqlDataAdapter sqlAdapter;

        private string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Adrian\\Desktop\\CST4718\\Fall2021-CST4708.mdf;Integrated Security=True;Connect Timeout=30";

        public AdminTool()
        {
            InitializeComponent();//loading the form
            dataGridView_All.DataError += DataGridView_All_DataError;
            dataGridView_Orders.DataError += DataGridView_Orders_DataError;
        }

        private void DataGridView_Orders_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("There was an error with one of the fields. Please check that the values are appropriate.");
        }

        private void DataGridView_All_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("There was an error with one of the fields. Please check that the values are appropriate.");
        }

        private SqlConnection GetConnection()
        //method to create connectioninstead of creating myconn every time. returns a variable so it's easy to use
        {
            SqlConnection myconn;
            myconn = new SqlConnection();
            myconn.ConnectionString = ConnectionString;
            myconn.Open();
            return myconn;
        }

        private void LoadData()//method loading the data into the form's gridview thingy
        {
            var myconn = GetConnection();
            dataTable = new DataTable();
            SqlCommand mycommand = new SqlCommand();
            mycommand.CommandText = @"SELECT * FROM Users";
            mycommand.Connection = myconn;
            sqlAdapter = new SqlDataAdapter();
            sqlAdapter.SelectCommand = mycommand;
            sqlAdapter.Fill(dataTable);
            //label4.Text = 
        }

        private void RefreshCombinedTable()
        {
            dataGridView_All.AutoGenerateColumns = false;
            dataGridView_All.DataSource = dataTable;
        }

        private void RefreshOrdersTable()
        {
            dataGridView_Orders.AutoGenerateColumns = false;
            dataGridView_Orders.DataSource = dataTable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //automatically loads full table on Form1_Load
            this.LoadData();
            this.RefreshCombinedTable();



            /*  Code for hashing the password column if needed:
             *  
             *  
             *  
             *  protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
              {
                  if (e.Row.RowType == DataControlRowType.DataRow)
                  {
                      DataRowView drv = e.Row.DataItem as DataRowView;
                      object data = drv["password"];
                      Byte[] bys = (Byte[])data;
                      //transform bys to string then show it on row
                      string str = Convert.ToBase64String(bys);
                      e.Row.Cells[2].Text = str;
                  }
              }
            *
            *
            *
            *
            */
        }

        private void button_commitChanges_Click(object sender, EventArgs e)//works well
        {
            try
            {
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlAdapter);
                sqlAdapter.Update(dataTable);
            }
            catch (SqlException ex)
            {
                //dataTable.RejectChanges(); don't need it i think though
                MessageBox.Show($"There was an error saving changes. Please make sure all " +
                    $"required fields are filled out.\n\n\n" +
                    $"Required Fields:\n" +
                    $"1. UserID;\n" +
                    $"2. Username;\n" +
                    $"3. E-mail;\n" +
                    $"4. First Name;\n" +
                    $"5. Last Name.\n" +
                    $"\n\n\n  Error:  {ex.Message}");
            }
        }


        private void button_ViewAll_Click(object sender, EventArgs e)//works well
        {
            //visibility change swapping on click to ALL fields table:
            dataGridView_Orders.Visible = false;
            dataGridView_All.Visible = true;
            RefreshCombinedTable();
        }

        private void button_ViewOrdersOnly_Click(object sender, EventArgs e)//works well
        {
            //visibility change swapping on click to ORDERS fields table:

            dataGridView_All.Visible = false;
            dataGridView_Orders.Visible = true;
            this.RefreshOrdersTable();
        }


        private void button_SaveAndExit_Click(object sender, EventArgs e)//works well
        {
            try
            {
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlAdapter);
                sqlAdapter.Update(dataTable);
                Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"There was an error saving changes. Please make sure all " +
                                   $"required fields are filled out.\n\n\n" +
                                   $"Required Fields:\n" +
                                   $"1. UserId;\n" +
                                   $"2. username;\n" +
                                   $"3. E-mail;\n" +
                                   $"4. First Name;\n" +
                                   $"5. Last Name.\n" +
                                   $"\n\n\n  Error:  {ex.Message}");
            }

        }

        private void button_ExitWithoutSaving_Click(object sender, EventArgs e)//works well
        {
            Controls.Clear();
            Close();
        }

        private void button_UndoChanges_Click(object sender, EventArgs e)//works well
        {
            //returns the initial last saved data:
            this.LoadData();

            if (dataGridView_All.Visible)
            {
                this.RefreshCombinedTable();
            }
            else if (dataGridView_Orders.Visible == true)
            {
                this.RefreshOrdersTable();
            }
        }

        private void button_FindRecord_Click(object sender, EventArgs e) //works well
        {
            SqlConnection myconn;
            myconn = new SqlConnection();
            myconn.ConnectionString = ConnectionString;
            myconn.Open();
            SqlCommand mycommand = new SqlCommand();

            if (comboBox_SearchParam.SelectedItem == null)
            {
                MessageBox.Show("No parameters chosen");
            }
            else if (comboBox_SearchParam.SelectedItem != null & String.IsNullOrEmpty(textBox_SearchValue.Text))
            {
                MessageBox.Show("No search value provided");

            }
            else if (comboBox_SearchParam.SelectedItem == "UserId" && textBox_SearchValue != null)
            {
                mycommand.Parameters.Add("@UserId", SqlDbType.VarChar, 100);
                mycommand.Parameters["@UserId"].Value = textBox_SearchValue.Text;
                mycommand.CommandText = "SELECT * FROM Users where UserId = @UserId";
                mycommand.Connection = myconn;
                SqlDataAdapter myadapter = new SqlDataAdapter();
                myadapter.SelectCommand = mycommand;
                dataTable = new DataTable();
                myadapter.Fill(dataTable);
                dataGridView_All.DataSource = dataTable;
                dataGridView_Orders.DataSource = dataTable;
            }
            else if (comboBox_SearchParam.SelectedItem == "username")
            {
                mycommand.Parameters.Add("@username", SqlDbType.VarChar, 100);
                mycommand.Parameters["@username"].Value = textBox_SearchValue.Text;
                mycommand.CommandText = "SELECT * FROM Users where Username = @Username";
                mycommand.Connection = myconn;
                SqlDataAdapter myadapter = new SqlDataAdapter();
                myadapter.SelectCommand = mycommand;
                dataTable = new DataTable();
                myadapter.Fill(dataTable);
                dataGridView_All.DataSource = dataTable;
                dataGridView_Orders.DataSource = dataTable;
            }
            else if (comboBox_SearchParam.SelectedItem == "OrderId")
            {
                mycommand.Parameters.Add("@OrderId", SqlDbType.VarChar, 100);
                mycommand.Parameters["@OrderId"].Value = textBox_SearchValue.Text;
                mycommand.CommandText = "SELECT * FROM Users where OrderId = @OrderId";
                mycommand.Connection = myconn;
                SqlDataAdapter myadapter = new SqlDataAdapter();
                myadapter.SelectCommand = mycommand;
                dataTable = new DataTable();
                myadapter.Fill(dataTable);
                dataGridView_All.DataSource = dataTable;
                dataGridView_Orders.DataSource = dataTable;
            }
            else if (comboBox_SearchParam.SelectedItem == "Last Name")
            {
                mycommand.Parameters.Add("@name", SqlDbType.VarChar, 100);
                mycommand.Parameters["@name"].Value = textBox_SearchValue.Text;
                mycommand.CommandText = "SELECT * FROM Users where name = @name";
                mycommand.Connection = myconn;
                SqlDataAdapter myadapter = new SqlDataAdapter();
                myadapter.SelectCommand = mycommand;
                dataTable = new DataTable();
                myadapter.Fill(dataTable);
                dataGridView_All.DataSource = dataTable;
                dataGridView_Orders.DataSource = dataTable;
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)//works well. Saves as commitbutton after!!!
        {
            var userIdValue = textBox_DeleteValue.Text;

            var conn = this.GetConnection();
            SqlCommand delcommand = new SqlCommand();
            delcommand.Connection = conn;
            delcommand.CommandText = "DELETE FROM Users WHERE UserId = @UserId";
            delcommand.Parameters.Add("@UserId", SqlDbType.VarChar, 100);
            delcommand.Parameters["@UserId"].Value = userIdValue;
            delcommand.ExecuteNonQuery();

            this.LoadData();
            this.RefreshCombinedTable();
            MessageBox.Show($"UserId: {userIdValue} was deleted");

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)//works well
        {
            if (checkBox1.Checked == false)
            {
                label5.Visible = false;
                textBox_DeleteValue.Visible = false;
                button_Delete.Visible = false;
                label6.Visible = false;
            }
            else
            {
                label5.Visible = true;
                textBox_DeleteValue.Visible = true;
                button_Delete.Visible = true;
                label6.Visible = true;

            }

        }
    }
}
