using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartPage
{
    public partial class ShoppingCart : Form
    {
        /* cart Keys
         * title, price, description,amount, imageLocation
         * entry.Value["title"],
         * entry.Value["price"],
         * entry.Value["description"],
         * entry.Value["amount"],
         * entry.Value["imageLocation"]
        */
        private Dictionary<string, Dictionary<string, string>> _cart =
            new Dictionary<string, Dictionary<string, string>>();

        public ShoppingCart()
        {
            InitializeComponent();
        }
        public ShoppingCart(Dictionary<string, Dictionary<string, string>> incomingCart)
        {
            InitializeComponent();
            _cart = incomingCart;

            //generate cart items

            int count = 0;
            BindingSource bindingSource1 = new BindingSource();
            dataGridView1.DataSource = bindingSource1;
            foreach (KeyValuePair<string, Dictionary<string, string>> entry in _cart)
            {

               Image pdImage = (System.Drawing.Image)CartPage.Properties.Resources.ResourceManager.GetObject(entry.Value["imgname"]);
               string pdDescription = entry.Value["description"];
               int pdQuantity= Int32.Parse(entry.Value["amount"]);

                // Populate the data source.
                //setPicture,setModel, setPrice
                bindingSource1.Add(new product(pdImage, pdDescription, pdQuantity, 199.99));
               
            }
            // Initialize the DataGridView.
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoSize = true;
            dataGridView1.DataSource = bindingSource1;

            sizeDGV(dataGridView1);

            DataGridViewColumn column = dataGridView1.Columns[3];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ((DataGridViewImageColumn)dataGridView1.Columns[3]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.Rows[0].Height = 100;

        }

        void sizeDGV(DataGridView dgv)
        {
            DataGridViewElementStates states = DataGridViewElementStates.None;
            dgv.ScrollBars = ScrollBars.None;
            var totalHeight = dgv.Rows.GetRowsHeight(states) + dgv.ColumnHeadersHeight;
            totalHeight += dgv.Rows.Count * 4;  // a correction I need
            var totalWidth = dgv.Columns.GetColumnsWidth(states) + dgv.RowHeadersWidth;
            dgv.ClientSize = new Size(totalWidth, totalHeight);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private class product
        {
            private Image setPicture;
            private string setModel;
            private double setPrice;
            private int setQuantity;

            public product(Image picture, string model, int setQuantity, double price)
            {
                this.setPicture = picture;
                this.setModel = model;
                this.setPrice = price;
                this.setQuantity = setQuantity;
            }


            public string model
            {
                get
                {
                    return setModel;
                }

                set
                {
                    setModel = value;
                }
            }
            public int quantity
            {
                get
                {
                    return setQuantity;
                }
                set
                {
                    setQuantity = value;
                }
            }

            public double Price
            {
                get
                {
                    return setPrice;
                }
                set
                {
                    setPrice = value;
                }
            }

            public Image Picture
            {
                get
                {
                    return setPicture;
                }
                set
                {
                    setPicture = value;
                }
            }
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
        


        }
    }
}
