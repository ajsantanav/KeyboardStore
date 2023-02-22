using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoppingCart;

namespace HomePage
{

    public partial class homeForm : Form
    {
        string referrer = "";
        string productPage = "";
        AdminTool adminTool = new AdminTool();


        //Dictionary<Field, Value>
        Dictionary<string, string> products = new Dictionary<string, string>();

        //Dictionary<ProductName, products<Field, Value>>
        Dictionary<string, Dictionary<string, string>> cart =
            new Dictionary<string, Dictionary<string, string>>();

        int start = 0;
        string[] productName = { "K860", "K740", "K845", "K360", "K600", "K780", "K380", "K830", "K375s", "K862", "K120", "K380" };

        Label[] productlabel;
        PictureBox[] productpics;

        


        public homeForm()
        {
            InitializeComponent();
            homePanel.Show();
            categoryPanel.Hide();
            productPanel.Hide();

            for (int i = 1; i < 10; i++)
            {
                productQty.Items.Add("Qty: " + i.ToString());
            }
            productQty.SelectedItem = "Qty: 1";

            products.Add("K860", "ERGO K860 Split Ergonomic Keyboard");
            products.Add("K740", "Illuminated Keyboard K740 Slim design and backlit keys");
            products.Add("K845", "K845 Mechanical Illuminated");
            products.Add("K360", "A corded aluminum mechanical keyboard with a choice of switches. K360 Wireless Keyboard");
            products.Add("K600", "Compact and thin wireless keyboard K600 TV Keyboard");
            products.Add("K780", "Advanced Keyboard with Creative Input Dial K780 Multi-Device Wireless Keyboard");
            products.Add("K380", "K380 MULTI-DEVICE BLUETOOTH KEYBOARD ");
            products.Add("K830", "Advanced Wireless Illuminated Keyboard ILLUMINATED KEYBOARD K830");
            products.Add("K375s", "Advanced Wireless Illuminated Keyboard K375s MULTI-DEVICE Wireless Keyboard and Stand Combo Ergo Series ");
            products.Add("K862", "ERGO K862 Split Keyboard for Business");
            products.Add("K120", "Wireless Mechanical Keyboard with Customizable Emoji Keys Keyboard K120");
            products.Add("K381", "Minimalist Wireless  Illuminated Keyboard K381 Multi-Device Bluetooth Keyboard");


            Label[] productlabel2 = {categoryLabel1,categoryLabel2, categoryLabel3, categoryLabel4, categoryLabel5, categoryLabel6, categoryLabel7,
            categoryLabel8,categoryLabel9,categoryLabel10,categoryLabel11,categoryLabel12};

            PictureBox[] productpics2 = {categoryPic2, categoryPic3, categoryPic4, categoryPic5, categoryPic6, categoryPic7,
            categoryPic8,categoryPic9,categoryPic10,categoryPic11,categoryPic12,categoryPic13};

            for (int i = 0; i < 12; i++)
            {
                String name = productName[i];
                
                productlabel2[i].Text = products[name];
                productpics2[i].Image = (System.Drawing.Image)HomePage.Properties.Resources.ResourceManager.GetObject(name);

                productpics2[i].AccessibleDescription = products[name];

                var imageSize = productpics2[i].Image.Size;
                var fitSize = productpics2[i].ClientSize;
                productpics2[i].SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
                    PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;


            }
            productlabel = productlabel2;
            productpics = productpics2;

            

        }


        

        private void label1_Click(object sender, EventArgs e)
        {
            categoryHeader.Text = "Foldable";
            int start = 3;
            for (int i = 0; i < 12; i++)
            {
                String name = productName[i];
                productlabel[start].Text = products[name];
                productpics[start].Image = (System.Drawing.Image)HomePage.Properties.Resources.ResourceManager.GetObject(name);
                productpics[start].AccessibleName = name;
                start++;
                if (start == 12)
                {
                    start = 0;
                }
            }
            categoryPanel.Show();
            homePanel.Hide();
            productPanel.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void featuredPicture_Click(object sender, EventArgs e)
        {
            referrer = "home";
            homePanel.Hide();
            categoryPanel.Hide();

            productPanel.Show();
        }

        private void mdFeaturedPicture_Click(object sender, EventArgs e)
        {
            referrer = "home";
            homePanel.Hide();
            categoryPanel.Hide();
            productPanel.Show();
        }

        private void smPicture1_Click(object sender, EventArgs e)
        {
            referrer = "home";
            homePanel.Hide();
            categoryPanel.Hide();
            productPanel.Show();
        }

        private void smPicture2_Click(object sender, EventArgs e)
        {
            referrer = "home";
            homePanel.Hide();
            categoryPanel.Hide();
            productPanel.Show();
        }

        private void smPicture3_Click(object sender, EventArgs e)
        {
            referrer = "home";
            homePanel.Hide();
            categoryPanel.Hide();
            productPanel.Show();
        }

        private void smPicture4_Click(object sender, EventArgs e)
        {
            referrer = "home";
            homePanel.Hide();
            categoryPanel.Hide();
            productPanel.Show();
        }

        private void smPicture5_Click(object sender, EventArgs e)
        {
            referrer = "home";
            homePanel.Hide();
            categoryPanel.Hide();
            productPanel.Show();
        }

        private void smPicture6_Click(object sender, EventArgs e)
        {
            referrer = "home";
            homePanel.Hide();
            categoryPanel.Hide();
            productPanel.Show();
        }

        private void smPicture7_Click(object sender, EventArgs e)
        {
            referrer = "home";
            homePanel.Hide();
            categoryPanel.Hide();
            productPanel.Show();
        }

        private void smPicture8_Click(object sender, EventArgs e)
        {
            referrer = "home";
            homePanel.Hide();
            categoryPanel.Hide();
            productPanel.Show();
        }

        private void categoryBack_Click(object sender, EventArgs e)
        {
            homePanel.Show();
            categoryPanel.Hide();
            productPanel.Hide();
        }

        

        private void categoryPic2_Click(object sender, EventArgs e)
        {

            PictureBox picbx = sender as PictureBox;
            setProductPic(picbx);

            

            referrer = "category";
            homePanel.Hide();
            categoryPanel.Hide();
            productPanel.Show();
        }

        private void categoryPic3_Click(object sender, EventArgs e)
        {
            setProductPic(sender as PictureBox);
            referrer = "category";
            homePanel.Hide();
            categoryPanel.Hide();
            productPanel.Show();
        }

        private void categoryPic4_Click(object sender, EventArgs e)
        {
            setProductPic(sender as PictureBox);
            referrer = "category";
            homePanel.Hide();
            categoryPanel.Hide();
            productPanel.Show();
        }

        private void categoryPic5_Click(object sender, EventArgs e)
        {
            setProductPic(sender as PictureBox);
            referrer = "category";
            homePanel.Hide();
            categoryPanel.Hide();
            productPanel.Show();
        }

        private void categoryPic6_Click(object sender, EventArgs e)
        {
            setProductPic(sender as PictureBox);
            referrer = "category";
            homePanel.Hide();
            categoryPanel.Hide();
            productPanel.Show();
        }

        private void categoryPic7_Click(object sender, EventArgs e)
        {
            setProductPic(sender as PictureBox);
            referrer = "category";
            homePanel.Hide();
            categoryPanel.Hide();
            productPanel.Show();
        }

        private void categoryPic8_Click(object sender, EventArgs e)
        {
            setProductPic(sender as PictureBox);
            referrer = "category";
            homePanel.Hide();
            categoryPanel.Hide();
            productPanel.Show();
        }

        private void categoryPic9_Click(object sender, EventArgs e)
        {
            setProductPic(sender as PictureBox);
            referrer = "category";
            homePanel.Hide();
            categoryPanel.Hide();
            productPanel.Show();
        }

        private void categoryPic10_Click(object sender, EventArgs e)
        {
            setProductPic(sender as PictureBox);
            referrer = "category";
            homePanel.Hide();
            categoryPanel.Hide();
            productPanel.Show();
        }

        private void categoryPic11_Click(object sender, EventArgs e)
        {
            setProductPic(sender as PictureBox);
            referrer = "category";
            homePanel.Hide();
            categoryPanel.Hide();
            productPanel.Show();
        }

        private void categoryPic12_Click(object sender, EventArgs e)
        {
            setProductPic(sender as PictureBox);
            referrer = "category";
            homePanel.Hide();
            categoryPanel.Hide();
            productPanel.Show();
        }

        private void categoryPic14_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            setProductPic(pic);
            
            referrer = "category";
            homePanel.Hide();
            categoryPanel.Hide();
            productPanel.Show();
        }

        private void backPicture_Click(object sender, EventArgs e)
        {
            if (referrer == "category")
            {
                categoryPanel.Show();
                homePanel.Hide();
                productPanel.Hide();
            } else if (referrer == "home")
            {
                homePanel.Show();
                categoryPanel.Hide();
                productPanel.Hide();

            }
            productQty.SelectedIndex = 0; 
        }

        private void wirelessLabel_Click(object sender, EventArgs e)
        {
            categoryHeader.Text = "Wireless";
            start = 0;
            for (int i = 0; i < 12; i++)
            {
                String name = productName[i];
                productlabel[start].Text = products[name];
                productpics[start].Image = (System.Drawing.Image)HomePage.Properties.Resources.ResourceManager.GetObject(name);
                productpics[start].AccessibleName = name;
                start++;
                if (start == 12)
                {
                    start = 0;
                }
            }
            categoryPanel.Show();
            homePanel.Hide();
            productPanel.Hide();
        }

        private void mechanicalLabel_Click(object sender, EventArgs e)
        {
            categoryHeader.Text = "Mechanical";
            start = 1;
            for (int i = 0; i < 12; i++)
            {
                String name = productName[i];
                productlabel[start].Text = products[name];
                productpics[start].Image = (System.Drawing.Image)HomePage.Properties.Resources.ResourceManager.GetObject(name);
                productpics[start].AccessibleName = name;
                start++;
                if (start == 12)
                {
                    start = 0;
                }
            }
            categoryPanel.Show();
            homePanel.Hide();
            productPanel.Hide();
        }

        private void backlitLabel_Click(object sender, EventArgs e)
        {
            categoryHeader.Text = "Backlit";
            start = 2;
            for (int i = 0; i < 12; i++)
            {
                String name = productName[i];
                productlabel[start].Text = products[name];
                productpics[start].Image = (System.Drawing.Image)HomePage.Properties.Resources.ResourceManager.GetObject(name);
                productpics[start].AccessibleName = name;
                start++;
                if (start == 12)
                {
                    start = 0;
                }
            }
            categoryPanel.Show();
            homePanel.Hide();
            productPanel.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            setCartItems(cart);
        }

        private void addCartBtn_Click(object sender, EventArgs e)
        {

            cartCount.Text = "0";
            string quant = productQty.SelectedItem.ToString();
            int len = quant.Length - 1;
            char res = quant[len];
            int quantity = res - '0';

            //Add cart Items
            Dictionary<string, string> productInfo = new Dictionary<string, string>();

            string title = productTitle.Text;
            string imgname = productTitle.AccessibleName;
            string description = productDescriptionText.Text;
            string price = productPrice.Text;
            string amount = quantity.ToString();
            string imageLocation = productImage.ImageLocation;

            productInfo.Add("imgname", imgname);
            productInfo.Add("title", title);
            productInfo.Add("price", price);
            productInfo.Add("description", description);
            productInfo.Add("amount", amount);
            productInfo.Add("imageLocation", imageLocation);
            
            try { 
                cart.Add(title, productInfo);
            } catch (ArgumentException)
            {
                cart.Remove(title);
                cart.Add(title, productInfo);
            }

            foreach (KeyValuePair<String, Dictionary<string, string>> entry in cart)
            {
                cartCount.Text = (Int32.Parse(cartCount.Text) + Int32.Parse(entry.Value["amount"])).ToString();
            }

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            homePanel.Show();
            categoryPanel.Hide();
            productPanel.Hide();
        }

        private void submitBttn_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Thanks for sharing your email!");
        }

        private void productImage_Click(object sender, EventArgs e)
        {

        }

        private void productDescriptionText_Click(object sender, EventArgs e)
        {

        }

        private void categoryLabel1_Click(object sender, EventArgs e)
        {

        }

        private void productTitle_Click(object sender, EventArgs e)
        {
            
        }

        private void productQty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cartPictureBox_Click(object sender, EventArgs e)
        {
            setCartItems(cart);
        }

        private void myAccountLabel_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            adminTool.ShowDialog();
            this.Show();
        }
        

        private void adminLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
