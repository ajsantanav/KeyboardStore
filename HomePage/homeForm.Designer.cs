
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;
using ShoppingCart;
namespace HomePage
{
    partial class homeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homeForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backlitLabel = new System.Windows.Forms.Label();
            this.mechanicalLabel = new System.Windows.Forms.Label();
            this.wirelessLabel = new System.Windows.Forms.Label();
            this.foldableLabel = new System.Windows.Forms.Label();
            this.myAccountLabel = new System.Windows.Forms.Label();
            this.myOrdersLabel = new System.Windows.Forms.Label();
            this.cartPictureBox = new System.Windows.Forms.PictureBox();
            this.cartCount = new System.Windows.Forms.Label();
            this.featuredPicture = new System.Windows.Forms.PictureBox();
            this.mdFeaturedPicture = new System.Windows.Forms.PictureBox();
            this.smPicture6 = new System.Windows.Forms.PictureBox();
            this.smPicture4 = new System.Windows.Forms.PictureBox();
            this.smPicture1 = new System.Windows.Forms.PictureBox();
            this.smPicture8 = new System.Windows.Forms.PictureBox();
            this.smPicture7 = new System.Windows.Forms.PictureBox();
            this.smPicture5 = new System.Windows.Forms.PictureBox();
            this.smPicture3 = new System.Windows.Forms.PictureBox();
            this.smPicture2 = new System.Windows.Forms.PictureBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.submitBttn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.productPanel = new System.Windows.Forms.Panel();
            this.productQty = new System.Windows.Forms.ComboBox();
            this.productImage = new System.Windows.Forms.PictureBox();
            this.productDescriptionText = new System.Windows.Forms.Label();
            this.productDecription = new System.Windows.Forms.Label();
            this.buyNowBtn = new System.Windows.Forms.Button();
            this.addCartBtn = new System.Windows.Forms.Button();
            this.productPrice = new System.Windows.Forms.Label();
            this.productTitle = new System.Windows.Forms.Label();
            this.backPicture = new System.Windows.Forms.PictureBox();
            this.categoryPanel = new System.Windows.Forms.Panel();
            this.categoryLabel1 = new System.Windows.Forms.Label();
            this.categoryLabel2 = new System.Windows.Forms.Label();
            this.categoryLabel3 = new System.Windows.Forms.Label();
            this.categoryLabel4 = new System.Windows.Forms.Label();
            this.categoryLabel5 = new System.Windows.Forms.Label();
            this.categoryLabel6 = new System.Windows.Forms.Label();
            this.categoryLabel7 = new System.Windows.Forms.Label();
            this.categoryLabel8 = new System.Windows.Forms.Label();
            this.categoryLabel9 = new System.Windows.Forms.Label();
            this.categoryLabel10 = new System.Windows.Forms.Label();
            this.categoryLabel11 = new System.Windows.Forms.Label();
            this.categoryLabel12 = new System.Windows.Forms.Label();
            this.categoryHeader = new System.Windows.Forms.Label();
            this.categoryBack = new System.Windows.Forms.PictureBox();
            this.categoryPic13 = new System.Windows.Forms.PictureBox();
            this.categoryPic12 = new System.Windows.Forms.PictureBox();
            this.categoryPic11 = new System.Windows.Forms.PictureBox();
            this.categoryPic10 = new System.Windows.Forms.PictureBox();
            this.categoryPic9 = new System.Windows.Forms.PictureBox();
            this.categoryPic8 = new System.Windows.Forms.PictureBox();
            this.categoryPic7 = new System.Windows.Forms.PictureBox();
            this.categoryPic6 = new System.Windows.Forms.PictureBox();
            this.categoryPic5 = new System.Windows.Forms.PictureBox();
            this.categoryPic4 = new System.Windows.Forms.PictureBox();
            this.categoryPic3 = new System.Windows.Forms.PictureBox();
            this.categoryPic2 = new System.Windows.Forms.PictureBox();
            this.homePanel = new System.Windows.Forms.Panel();
            this.adminLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.featuredPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdFeaturedPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smPicture6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smPicture4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smPicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smPicture8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smPicture7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smPicture5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smPicture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smPicture2)).BeginInit();
            this.productPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPicture)).BeginInit();
            this.categoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPic13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPic12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPic11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPic10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPic9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPic8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPic7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPic2)).BeginInit();
            this.homePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 32);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // backlitLabel
            // 
            this.backlitLabel.AutoSize = true;
            this.backlitLabel.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.backlitLabel.Location = new System.Drawing.Point(422, 20);
            this.backlitLabel.Name = "backlitLabel";
            this.backlitLabel.Size = new System.Drawing.Size(62, 25);
            this.backlitLabel.TabIndex = 3;
            this.backlitLabel.Text = "Backlit";
            this.backlitLabel.Click += new System.EventHandler(this.backlitLabel_Click);
            // 
            // mechanicalLabel
            // 
            this.mechanicalLabel.AutoSize = true;
            this.mechanicalLabel.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.mechanicalLabel.Location = new System.Drawing.Point(317, 20);
            this.mechanicalLabel.Name = "mechanicalLabel";
            this.mechanicalLabel.Size = new System.Drawing.Size(99, 25);
            this.mechanicalLabel.TabIndex = 2;
            this.mechanicalLabel.Text = "Mechanical";
            this.mechanicalLabel.Click += new System.EventHandler(this.mechanicalLabel_Click);
            // 
            // wirelessLabel
            // 
            this.wirelessLabel.AutoSize = true;
            this.wirelessLabel.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.wirelessLabel.Location = new System.Drawing.Point(229, 20);
            this.wirelessLabel.Name = "wirelessLabel";
            this.wirelessLabel.Size = new System.Drawing.Size(77, 25);
            this.wirelessLabel.TabIndex = 1;
            this.wirelessLabel.Text = "Wireless";
            this.wirelessLabel.Click += new System.EventHandler(this.wirelessLabel_Click);
            // 
            // foldableLabel
            // 
            this.foldableLabel.AutoSize = true;
            this.foldableLabel.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.foldableLabel.Location = new System.Drawing.Point(490, 20);
            this.foldableLabel.Name = "foldableLabel";
            this.foldableLabel.Size = new System.Drawing.Size(80, 25);
            this.foldableLabel.TabIndex = 4;
            this.foldableLabel.Text = "Foldable";
            this.foldableLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // myAccountLabel
            // 
            this.myAccountLabel.AutoSize = true;
            this.myAccountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.myAccountLabel.Location = new System.Drawing.Point(772, 20);
            this.myAccountLabel.Name = "myAccountLabel";
            this.myAccountLabel.Size = new System.Drawing.Size(73, 15);
            this.myAccountLabel.TabIndex = 6;
            this.myAccountLabel.Text = "My Account";
            this.myAccountLabel.Click += new System.EventHandler(this.myAccountLabel_Click);
            // 
            // myOrdersLabel
            // 
            this.myOrdersLabel.AutoSize = true;
            this.myOrdersLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.myOrdersLabel.Location = new System.Drawing.Point(851, 20);
            this.myOrdersLabel.Name = "myOrdersLabel";
            this.myOrdersLabel.Size = new System.Drawing.Size(65, 15);
            this.myOrdersLabel.TabIndex = 7;
            this.myOrdersLabel.Text = "My Orders";
            // 
            // cartPictureBox
            // 
            this.cartPictureBox.BackColor = System.Drawing.Color.White;
            this.cartPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("cartPictureBox.Image")));
            this.cartPictureBox.Location = new System.Drawing.Point(976, 17);
            this.cartPictureBox.Name = "cartPictureBox";
            this.cartPictureBox.Size = new System.Drawing.Size(32, 28);
            this.cartPictureBox.TabIndex = 8;
            this.cartPictureBox.TabStop = false;
            this.cartPictureBox.Click += new System.EventHandler(this.cartPictureBox_Click);
            // 
            // cartCount
            // 
            this.cartCount.AutoSize = true;
            this.cartCount.BackColor = System.Drawing.Color.Red;
            this.cartCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cartCount.ForeColor = System.Drawing.Color.White;
            this.cartCount.Location = new System.Drawing.Point(995, 17);
            this.cartCount.Name = "cartCount";
            this.cartCount.Size = new System.Drawing.Size(13, 15);
            this.cartCount.TabIndex = 9;
            this.cartCount.Text = "0";
            this.cartCount.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // featuredPicture
            // 
            this.featuredPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.featuredPicture.Image = ((System.Drawing.Image)(resources.GetObject("featuredPicture.Image")));
            this.featuredPicture.Location = new System.Drawing.Point(41, 17);
            this.featuredPicture.Name = "featuredPicture";
            this.featuredPicture.Size = new System.Drawing.Size(537, 276);
            this.featuredPicture.TabIndex = 10;
            this.featuredPicture.TabStop = false;
            this.featuredPicture.Click += new System.EventHandler(this.featuredPicture_Click);
            // 
            // mdFeaturedPicture
            // 
            this.mdFeaturedPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mdFeaturedPicture.Image = ((System.Drawing.Image)(resources.GetObject("mdFeaturedPicture.Image")));
            this.mdFeaturedPicture.Location = new System.Drawing.Point(584, 18);
            this.mdFeaturedPicture.Name = "mdFeaturedPicture";
            this.mdFeaturedPicture.Size = new System.Drawing.Size(356, 276);
            this.mdFeaturedPicture.TabIndex = 11;
            this.mdFeaturedPicture.TabStop = false;
            this.mdFeaturedPicture.Click += new System.EventHandler(this.mdFeaturedPicture_Click);
            // 
            // smPicture6
            // 
            this.smPicture6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smPicture6.Image = ((System.Drawing.Image)(resources.GetObject("smPicture6.Image")));
            this.smPicture6.Location = new System.Drawing.Point(403, 299);
            this.smPicture6.Name = "smPicture6";
            this.smPicture6.Size = new System.Drawing.Size(175, 135);
            this.smPicture6.TabIndex = 12;
            this.smPicture6.TabStop = false;
            this.smPicture6.Click += new System.EventHandler(this.smPicture6_Click);
            // 
            // smPicture4
            // 
            this.smPicture4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smPicture4.Image = ((System.Drawing.Image)(resources.GetObject("smPicture4.Image")));
            this.smPicture4.Location = new System.Drawing.Point(765, 299);
            this.smPicture4.Name = "smPicture4";
            this.smPicture4.Size = new System.Drawing.Size(175, 135);
            this.smPicture4.TabIndex = 13;
            this.smPicture4.TabStop = false;
            this.smPicture4.Click += new System.EventHandler(this.smPicture4_Click);
            // 
            // smPicture1
            // 
            this.smPicture1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smPicture1.Image = ((System.Drawing.Image)(resources.GetObject("smPicture1.Image")));
            this.smPicture1.Location = new System.Drawing.Point(946, 17);
            this.smPicture1.Name = "smPicture1";
            this.smPicture1.Size = new System.Drawing.Size(175, 135);
            this.smPicture1.TabIndex = 14;
            this.smPicture1.TabStop = false;
            this.smPicture1.Click += new System.EventHandler(this.smPicture1_Click);
            // 
            // smPicture8
            // 
            this.smPicture8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smPicture8.Image = ((System.Drawing.Image)(resources.GetObject("smPicture8.Image")));
            this.smPicture8.Location = new System.Drawing.Point(41, 300);
            this.smPicture8.Name = "smPicture8";
            this.smPicture8.Size = new System.Drawing.Size(175, 135);
            this.smPicture8.TabIndex = 15;
            this.smPicture8.TabStop = false;
            this.smPicture8.Click += new System.EventHandler(this.smPicture8_Click);
            // 
            // smPicture7
            // 
            this.smPicture7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smPicture7.Image = ((System.Drawing.Image)(resources.GetObject("smPicture7.Image")));
            this.smPicture7.Location = new System.Drawing.Point(222, 300);
            this.smPicture7.Name = "smPicture7";
            this.smPicture7.Size = new System.Drawing.Size(175, 135);
            this.smPicture7.TabIndex = 16;
            this.smPicture7.TabStop = false;
            this.smPicture7.Click += new System.EventHandler(this.smPicture7_Click);
            // 
            // smPicture5
            // 
            this.smPicture5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smPicture5.Image = ((System.Drawing.Image)(resources.GetObject("smPicture5.Image")));
            this.smPicture5.Location = new System.Drawing.Point(584, 300);
            this.smPicture5.Name = "smPicture5";
            this.smPicture5.Size = new System.Drawing.Size(175, 135);
            this.smPicture5.TabIndex = 17;
            this.smPicture5.TabStop = false;
            this.smPicture5.Click += new System.EventHandler(this.smPicture5_Click);
            // 
            // smPicture3
            // 
            this.smPicture3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smPicture3.Image = ((System.Drawing.Image)(resources.GetObject("smPicture3.Image")));
            this.smPicture3.Location = new System.Drawing.Point(946, 299);
            this.smPicture3.Name = "smPicture3";
            this.smPicture3.Size = new System.Drawing.Size(175, 135);
            this.smPicture3.TabIndex = 18;
            this.smPicture3.TabStop = false;
            this.smPicture3.Click += new System.EventHandler(this.smPicture3_Click);
            // 
            // smPicture2
            // 
            this.smPicture2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smPicture2.Image = ((System.Drawing.Image)(resources.GetObject("smPicture2.Image")));
            this.smPicture2.Location = new System.Drawing.Point(946, 158);
            this.smPicture2.Name = "smPicture2";
            this.smPicture2.Size = new System.Drawing.Size(175, 135);
            this.smPicture2.TabIndex = 19;
            this.smPicture2.TabStop = false;
            this.smPicture2.Click += new System.EventHandler(this.smPicture2_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(54, 505);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(299, 20);
            this.emailTextBox.TabIndex = 20;
            this.emailTextBox.Text = "Please Enter Your Email";
            // 
            // submitBttn
            // 
            this.submitBttn.Location = new System.Drawing.Point(359, 504);
            this.submitBttn.Name = "submitBttn";
            this.submitBttn.Size = new System.Drawing.Size(75, 23);
            this.submitBttn.TabIndex = 21;
            this.submitBttn.Text = "Submit";
            this.submitBttn.UseVisualStyleBackColor = true;
            this.submitBttn.Click += new System.EventHandler(this.submitBttn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(459, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(853, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(1064, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(1064, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.Location = new System.Drawing.Point(1064, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label7.Location = new System.Drawing.Point(879, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label8.Location = new System.Drawing.Point(701, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label9.Location = new System.Drawing.Point(525, 409);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 15);
            this.label9.TabIndex = 29;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label10.Location = new System.Drawing.Point(339, 409);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 30;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label11.Location = new System.Drawing.Point(151, 409);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 15);
            this.label11.TabIndex = 31;
            this.label11.Text = "label11";
            // 
            // productPanel
            // 
            this.productPanel.Controls.Add(this.productQty);
            this.productPanel.Controls.Add(this.productImage);
            this.productPanel.Controls.Add(this.productDescriptionText);
            this.productPanel.Controls.Add(this.productDecription);
            this.productPanel.Controls.Add(this.buyNowBtn);
            this.productPanel.Controls.Add(this.addCartBtn);
            this.productPanel.Controls.Add(this.productPrice);
            this.productPanel.Controls.Add(this.productTitle);
            this.productPanel.Controls.Add(this.backPicture);
            this.productPanel.Location = new System.Drawing.Point(-2, 71);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(1140, 555);
            this.productPanel.TabIndex = 32;
            // 
            // productQty
            // 
            this.productQty.BackColor = System.Drawing.Color.White;
            this.productQty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productQty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.productQty.FormattingEnabled = true;
            this.productQty.Location = new System.Drawing.Point(399, 205);
            this.productQty.Name = "productQty";
            this.productQty.Size = new System.Drawing.Size(66, 23);
            this.productQty.TabIndex = 8;
            this.productQty.SelectedIndexChanged += new System.EventHandler(this.productQty_SelectedIndexChanged);
            // 
            // productImage
            // 
            this.productImage.Image = ((System.Drawing.Image)(resources.GetObject("productImage.Image")));
            this.productImage.Location = new System.Drawing.Point(43, 54);
            this.productImage.Name = "productImage";
            this.productImage.Size = new System.Drawing.Size(334, 226);
            this.productImage.TabIndex = 7;
            this.productImage.TabStop = false;
            this.productImage.Click += new System.EventHandler(this.productImage_Click);
            // 
            // productDescriptionText
            // 
            this.productDescriptionText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.productDescriptionText.Location = new System.Drawing.Point(396, 352);
            this.productDescriptionText.Name = "productDescriptionText";
            this.productDescriptionText.Size = new System.Drawing.Size(658, 119);
            this.productDescriptionText.TabIndex = 6;
            this.productDescriptionText.Text = resources.GetString("productDescriptionText.Text");
            this.productDescriptionText.Click += new System.EventHandler(this.productDescriptionText_Click);
            // 
            // productDecription
            // 
            this.productDecription.AutoSize = true;
            this.productDecription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.productDecription.Location = new System.Drawing.Point(396, 313);
            this.productDecription.Name = "productDecription";
            this.productDecription.Size = new System.Drawing.Size(92, 21);
            this.productDecription.TabIndex = 5;
            this.productDecription.Text = "Description:";
            // 
            // buyNowBtn
            // 
            this.buyNowBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.buyNowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyNowBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buyNowBtn.Location = new System.Drawing.Point(491, 252);
            this.buyNowBtn.Name = "buyNowBtn";
            this.buyNowBtn.Size = new System.Drawing.Size(75, 23);
            this.buyNowBtn.TabIndex = 4;
            this.buyNowBtn.Text = "Buy Now";
            this.buyNowBtn.UseVisualStyleBackColor = false;
            // 
            // addCartBtn
            // 
            this.addCartBtn.BackColor = System.Drawing.Color.Gold;
            this.addCartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCartBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addCartBtn.Location = new System.Drawing.Point(396, 252);
            this.addCartBtn.Name = "addCartBtn";
            this.addCartBtn.Size = new System.Drawing.Size(89, 23);
            this.addCartBtn.TabIndex = 3;
            this.addCartBtn.Text = "Add to Cart";
            this.addCartBtn.UseVisualStyleBackColor = false;
            this.addCartBtn.Click += new System.EventHandler(this.addCartBtn_Click);
            // 
            // productPrice
            // 
            this.productPrice.AutoSize = true;
            this.productPrice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.productPrice.Location = new System.Drawing.Point(395, 167);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(47, 21);
            this.productPrice.TabIndex = 2;
            this.productPrice.Text = "Price:";
            // 
            // productTitle
            // 
            this.productTitle.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.productTitle.Location = new System.Drawing.Point(394, 48);
            this.productTitle.Name = "productTitle";
            this.productTitle.Size = new System.Drawing.Size(500, 119);
            this.productTitle.TabIndex = 1;
            this.productTitle.Text = "Logitech MX Keys Advanced Wireless Illuminated Keyboard, Tactile Responsive Typin" +
    "g, Backlighting, Bluetooth, USB-C, Apple macOS, Microsoft Windows, Linux, iOS, A" +
    "ndroid, Metal Build - Graphite";
            this.productTitle.Click += new System.EventHandler(this.productTitle_Click);
            // 
            // backPicture
            // 
            this.backPicture.Image = ((System.Drawing.Image)(resources.GetObject("backPicture.Image")));
            this.backPicture.Location = new System.Drawing.Point(43, 15);
            this.backPicture.Name = "backPicture";
            this.backPicture.Size = new System.Drawing.Size(100, 28);
            this.backPicture.TabIndex = 0;
            this.backPicture.TabStop = false;
            this.backPicture.Click += new System.EventHandler(this.backPicture_Click);
            // 
            // categoryPanel
            // 
            this.categoryPanel.Controls.Add(this.categoryLabel1);
            this.categoryPanel.Controls.Add(this.categoryLabel2);
            this.categoryPanel.Controls.Add(this.categoryLabel3);
            this.categoryPanel.Controls.Add(this.categoryLabel4);
            this.categoryPanel.Controls.Add(this.categoryLabel5);
            this.categoryPanel.Controls.Add(this.categoryLabel6);
            this.categoryPanel.Controls.Add(this.categoryLabel7);
            this.categoryPanel.Controls.Add(this.categoryLabel8);
            this.categoryPanel.Controls.Add(this.categoryLabel9);
            this.categoryPanel.Controls.Add(this.categoryLabel10);
            this.categoryPanel.Controls.Add(this.categoryLabel11);
            this.categoryPanel.Controls.Add(this.categoryLabel12);
            this.categoryPanel.Controls.Add(this.categoryHeader);
            this.categoryPanel.Controls.Add(this.categoryBack);
            this.categoryPanel.Controls.Add(this.categoryPic13);
            this.categoryPanel.Controls.Add(this.categoryPic12);
            this.categoryPanel.Controls.Add(this.categoryPic11);
            this.categoryPanel.Controls.Add(this.categoryPic10);
            this.categoryPanel.Controls.Add(this.categoryPic9);
            this.categoryPanel.Controls.Add(this.categoryPic8);
            this.categoryPanel.Controls.Add(this.categoryPic7);
            this.categoryPanel.Controls.Add(this.categoryPic6);
            this.categoryPanel.Controls.Add(this.categoryPic5);
            this.categoryPanel.Controls.Add(this.categoryPic4);
            this.categoryPanel.Controls.Add(this.categoryPic3);
            this.categoryPanel.Controls.Add(this.categoryPic2);
            this.categoryPanel.Location = new System.Drawing.Point(0, 59);
            this.categoryPanel.Name = "categoryPanel";
            this.categoryPanel.Size = new System.Drawing.Size(1137, 555);
            this.categoryPanel.TabIndex = 33;
            // 
            // categoryLabel1
            // 
            this.categoryLabel1.Location = new System.Drawing.Point(48, 189);
            this.categoryLabel1.Name = "categoryLabel1";
            this.categoryLabel1.Size = new System.Drawing.Size(206, 34);
            this.categoryLabel1.TabIndex = 26;
            this.categoryLabel1.Text = "label23";
            this.categoryLabel1.Click += new System.EventHandler(this.categoryLabel1_Click);
            // 
            // categoryLabel2
            // 
            this.categoryLabel2.Location = new System.Drawing.Point(321, 188);
            this.categoryLabel2.Name = "categoryLabel2";
            this.categoryLabel2.Size = new System.Drawing.Size(206, 34);
            this.categoryLabel2.TabIndex = 25;
            this.categoryLabel2.Text = "label22";
            // 
            // categoryLabel3
            // 
            this.categoryLabel3.Location = new System.Drawing.Point(591, 189);
            this.categoryLabel3.Name = "categoryLabel3";
            this.categoryLabel3.Size = new System.Drawing.Size(206, 34);
            this.categoryLabel3.TabIndex = 24;
            this.categoryLabel3.Text = "label21";
            // 
            // categoryLabel4
            // 
            this.categoryLabel4.Location = new System.Drawing.Point(852, 187);
            this.categoryLabel4.Name = "categoryLabel4";
            this.categoryLabel4.Size = new System.Drawing.Size(206, 34);
            this.categoryLabel4.TabIndex = 23;
            this.categoryLabel4.Text = "label20";
            // 
            // categoryLabel5
            // 
            this.categoryLabel5.Location = new System.Drawing.Point(48, 353);
            this.categoryLabel5.Name = "categoryLabel5";
            this.categoryLabel5.Size = new System.Drawing.Size(206, 34);
            this.categoryLabel5.TabIndex = 22;
            this.categoryLabel5.Text = "label19";
            // 
            // categoryLabel6
            // 
            this.categoryLabel6.Location = new System.Drawing.Point(321, 352);
            this.categoryLabel6.Name = "categoryLabel6";
            this.categoryLabel6.Size = new System.Drawing.Size(206, 34);
            this.categoryLabel6.TabIndex = 21;
            this.categoryLabel6.Text = "label18";
            // 
            // categoryLabel7
            // 
            this.categoryLabel7.Location = new System.Drawing.Point(591, 349);
            this.categoryLabel7.Name = "categoryLabel7";
            this.categoryLabel7.Size = new System.Drawing.Size(206, 34);
            this.categoryLabel7.TabIndex = 20;
            this.categoryLabel7.Text = "label17";
            // 
            // categoryLabel8
            // 
            this.categoryLabel8.Location = new System.Drawing.Point(852, 349);
            this.categoryLabel8.Name = "categoryLabel8";
            this.categoryLabel8.Size = new System.Drawing.Size(206, 34);
            this.categoryLabel8.TabIndex = 19;
            this.categoryLabel8.Text = "label16";
            // 
            // categoryLabel9
            // 
            this.categoryLabel9.Location = new System.Drawing.Point(48, 516);
            this.categoryLabel9.Name = "categoryLabel9";
            this.categoryLabel9.Size = new System.Drawing.Size(206, 34);
            this.categoryLabel9.TabIndex = 18;
            this.categoryLabel9.Text = "label15";
            // 
            // categoryLabel10
            // 
            this.categoryLabel10.Location = new System.Drawing.Point(321, 516);
            this.categoryLabel10.Name = "categoryLabel10";
            this.categoryLabel10.Size = new System.Drawing.Size(206, 34);
            this.categoryLabel10.TabIndex = 17;
            this.categoryLabel10.Text = "label14";
            // 
            // categoryLabel11
            // 
            this.categoryLabel11.Location = new System.Drawing.Point(591, 516);
            this.categoryLabel11.Name = "categoryLabel11";
            this.categoryLabel11.Size = new System.Drawing.Size(206, 34);
            this.categoryLabel11.TabIndex = 16;
            this.categoryLabel11.Text = "label13";
            // 
            // categoryLabel12
            // 
            this.categoryLabel12.Location = new System.Drawing.Point(852, 516);
            this.categoryLabel12.Name = "categoryLabel12";
            this.categoryLabel12.Size = new System.Drawing.Size(206, 34);
            this.categoryLabel12.TabIndex = 15;
            this.categoryLabel12.Text = "label12";
            // 
            // categoryHeader
            // 
            this.categoryHeader.AutoSize = true;
            this.categoryHeader.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.categoryHeader.Location = new System.Drawing.Point(89, 1);
            this.categoryHeader.Name = "categoryHeader";
            this.categoryHeader.Size = new System.Drawing.Size(242, 45);
            this.categoryHeader.TabIndex = 14;
            this.categoryHeader.Text = "Category Name";
            this.categoryHeader.Click += new System.EventHandler(this.label12_Click);
            // 
            // categoryBack
            // 
            this.categoryBack.Image = ((System.Drawing.Image)(resources.GetObject("categoryBack.Image")));
            this.categoryBack.Location = new System.Drawing.Point(49, 17);
            this.categoryBack.Name = "categoryBack";
            this.categoryBack.Size = new System.Drawing.Size(34, 23);
            this.categoryBack.TabIndex = 13;
            this.categoryBack.TabStop = false;
            this.categoryBack.Click += new System.EventHandler(this.categoryBack_Click);
            // 
            // categoryPic13
            // 
            this.categoryPic13.BackColor = System.Drawing.Color.White;
            this.categoryPic13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryPic13.Location = new System.Drawing.Point(855, 392);
            this.categoryPic13.Name = "categoryPic13";
            this.categoryPic13.Size = new System.Drawing.Size(205, 120);
            this.categoryPic13.TabIndex = 12;
            this.categoryPic13.TabStop = false;
            this.categoryPic13.Click += new System.EventHandler(this.categoryPic14_Click);
            // 
            // categoryPic12
            // 
            this.categoryPic12.BackColor = System.Drawing.Color.White;
            this.categoryPic12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryPic12.Location = new System.Drawing.Point(592, 390);
            this.categoryPic12.Name = "categoryPic12";
            this.categoryPic12.Size = new System.Drawing.Size(205, 120);
            this.categoryPic12.TabIndex = 10;
            this.categoryPic12.TabStop = false;
            this.categoryPic12.Click += new System.EventHandler(this.categoryPic12_Click);
            // 
            // categoryPic11
            // 
            this.categoryPic11.BackColor = System.Drawing.Color.White;
            this.categoryPic11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryPic11.Location = new System.Drawing.Point(324, 393);
            this.categoryPic11.Name = "categoryPic11";
            this.categoryPic11.Size = new System.Drawing.Size(205, 120);
            this.categoryPic11.TabIndex = 9;
            this.categoryPic11.TabStop = false;
            this.categoryPic11.Click += new System.EventHandler(this.categoryPic11_Click);
            // 
            // categoryPic10
            // 
            this.categoryPic10.BackColor = System.Drawing.Color.White;
            this.categoryPic10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryPic10.Location = new System.Drawing.Point(49, 393);
            this.categoryPic10.Name = "categoryPic10";
            this.categoryPic10.Size = new System.Drawing.Size(205, 120);
            this.categoryPic10.TabIndex = 8;
            this.categoryPic10.TabStop = false;
            this.categoryPic10.Click += new System.EventHandler(this.categoryPic10_Click);
            // 
            // categoryPic9
            // 
            this.categoryPic9.BackColor = System.Drawing.Color.White;
            this.categoryPic9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryPic9.Location = new System.Drawing.Point(855, 225);
            this.categoryPic9.Name = "categoryPic9";
            this.categoryPic9.Size = new System.Drawing.Size(205, 120);
            this.categoryPic9.TabIndex = 7;
            this.categoryPic9.TabStop = false;
            this.categoryPic9.Click += new System.EventHandler(this.categoryPic9_Click);
            // 
            // categoryPic8
            // 
            this.categoryPic8.BackColor = System.Drawing.Color.White;
            this.categoryPic8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryPic8.Location = new System.Drawing.Point(592, 223);
            this.categoryPic8.Name = "categoryPic8";
            this.categoryPic8.Size = new System.Drawing.Size(205, 120);
            this.categoryPic8.TabIndex = 6;
            this.categoryPic8.TabStop = false;
            this.categoryPic8.Click += new System.EventHandler(this.categoryPic8_Click);
            // 
            // categoryPic7
            // 
            this.categoryPic7.BackColor = System.Drawing.Color.White;
            this.categoryPic7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryPic7.Location = new System.Drawing.Point(324, 226);
            this.categoryPic7.Name = "categoryPic7";
            this.categoryPic7.Size = new System.Drawing.Size(205, 120);
            this.categoryPic7.TabIndex = 5;
            this.categoryPic7.TabStop = false;
            this.categoryPic7.Click += new System.EventHandler(this.categoryPic7_Click);
            // 
            // categoryPic6
            // 
            this.categoryPic6.BackColor = System.Drawing.Color.White;
            this.categoryPic6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryPic6.Location = new System.Drawing.Point(49, 226);
            this.categoryPic6.Name = "categoryPic6";
            this.categoryPic6.Size = new System.Drawing.Size(205, 120);
            this.categoryPic6.TabIndex = 4;
            this.categoryPic6.TabStop = false;
            this.categoryPic6.Click += new System.EventHandler(this.categoryPic6_Click);
            // 
            // categoryPic5
            // 
            this.categoryPic5.BackColor = System.Drawing.Color.White;
            this.categoryPic5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryPic5.Location = new System.Drawing.Point(855, 64);
            this.categoryPic5.Name = "categoryPic5";
            this.categoryPic5.Size = new System.Drawing.Size(205, 120);
            this.categoryPic5.TabIndex = 3;
            this.categoryPic5.TabStop = false;
            this.categoryPic5.Click += new System.EventHandler(this.categoryPic5_Click);
            // 
            // categoryPic4
            // 
            this.categoryPic4.BackColor = System.Drawing.Color.White;
            this.categoryPic4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryPic4.Location = new System.Drawing.Point(592, 62);
            this.categoryPic4.Name = "categoryPic4";
            this.categoryPic4.Size = new System.Drawing.Size(205, 120);
            this.categoryPic4.TabIndex = 2;
            this.categoryPic4.TabStop = false;
            this.categoryPic4.Click += new System.EventHandler(this.categoryPic4_Click);
            // 
            // categoryPic3
            // 
            this.categoryPic3.BackColor = System.Drawing.Color.White;
            this.categoryPic3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryPic3.Location = new System.Drawing.Point(324, 65);
            this.categoryPic3.Name = "categoryPic3";
            this.categoryPic3.Size = new System.Drawing.Size(205, 120);
            this.categoryPic3.TabIndex = 1;
            this.categoryPic3.TabStop = false;
            this.categoryPic3.Click += new System.EventHandler(this.categoryPic3_Click);
            // 
            // categoryPic2
            // 
            this.categoryPic2.BackColor = System.Drawing.Color.White;
            this.categoryPic2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryPic2.Location = new System.Drawing.Point(49, 65);
            this.categoryPic2.Name = "categoryPic2";
            this.categoryPic2.Size = new System.Drawing.Size(205, 120);
            this.categoryPic2.TabIndex = 0;
            this.categoryPic2.TabStop = false;
            this.categoryPic2.Click += new System.EventHandler(this.categoryPic2_Click);
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.label11);
            this.homePanel.Controls.Add(this.label10);
            this.homePanel.Controls.Add(this.label9);
            this.homePanel.Controls.Add(this.label8);
            this.homePanel.Controls.Add(this.label7);
            this.homePanel.Controls.Add(this.label6);
            this.homePanel.Controls.Add(this.label5);
            this.homePanel.Controls.Add(this.label4);
            this.homePanel.Controls.Add(this.label3);
            this.homePanel.Controls.Add(this.label2);
            this.homePanel.Controls.Add(this.submitBttn);
            this.homePanel.Controls.Add(this.emailTextBox);
            this.homePanel.Controls.Add(this.smPicture2);
            this.homePanel.Controls.Add(this.smPicture3);
            this.homePanel.Controls.Add(this.smPicture5);
            this.homePanel.Controls.Add(this.smPicture7);
            this.homePanel.Controls.Add(this.smPicture8);
            this.homePanel.Controls.Add(this.smPicture1);
            this.homePanel.Controls.Add(this.smPicture4);
            this.homePanel.Controls.Add(this.smPicture6);
            this.homePanel.Controls.Add(this.mdFeaturedPicture);
            this.homePanel.Controls.Add(this.featuredPicture);
            this.homePanel.Location = new System.Drawing.Point(0, 71);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(1137, 555);
            this.homePanel.TabIndex = 34;
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.adminLabel.Location = new System.Drawing.Point(693, 20);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(69, 15);
            this.adminLabel.TabIndex = 35;
            this.adminLabel.Text = "Admin Tool";
            this.adminLabel.Click += new System.EventHandler(this.adminLabel_Click);
            // 
            // homeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1138, 626);
            this.Controls.Add(this.adminLabel);
            this.Controls.Add(this.wirelessLabel);
            this.Controls.Add(this.cartCount);
            this.Controls.Add(this.cartPictureBox);
            this.Controls.Add(this.myOrdersLabel);
            this.Controls.Add(this.myAccountLabel);
            this.Controls.Add(this.foldableLabel);
            this.Controls.Add(this.backlitLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mechanicalLabel);
            this.Controls.Add(this.productPanel);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.categoryPanel);
            this.Name = "homeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.featuredPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdFeaturedPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smPicture6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smPicture4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smPicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smPicture8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smPicture7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smPicture5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smPicture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smPicture2)).EndInit();
            this.productPanel.ResumeLayout(false);
            this.productPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPicture)).EndInit();
            this.categoryPanel.ResumeLayout(false);
            this.categoryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPic13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPic12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPic11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPic10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPic9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPic8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPic7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPic2)).EndInit();
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public void setProductPic(System.Windows.Forms.PictureBox picbx)
        {
            productTitle.Text = picbx.AccessibleDescription;
            productTitle.AccessibleName = picbx.AccessibleName;
            productImage.Image = picbx.Image;

            var imageSize = productImage.Image.Size;
            var fitSize = productImage.ClientSize;
            productImage.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
                PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
        }

        public void setCartItems(Dictionary<string, Dictionary<string, string>> incomingCart)
        {

            CartPage.ShoppingCart cartForm = new CartPage.ShoppingCart(cart);
            cartForm.ShowDialog();
        }





        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label backlitLabel;
        private System.Windows.Forms.Label mechanicalLabel;
        private System.Windows.Forms.Label wirelessLabel;
        private System.Windows.Forms.Label foldableLabel;
        private System.Windows.Forms.Label myAccountLabel;
        private System.Windows.Forms.Label myOrdersLabel;
        private System.Windows.Forms.PictureBox cartPictureBox;
        private System.Windows.Forms.Label cartCount;
        private System.Windows.Forms.PictureBox featuredPicture;
        private System.Windows.Forms.PictureBox mdFeaturedPicture;
        private System.Windows.Forms.PictureBox smPicture6;
        private System.Windows.Forms.PictureBox smPicture4;
        private System.Windows.Forms.PictureBox smPicture1;
        private System.Windows.Forms.PictureBox smPicture8;
        private System.Windows.Forms.PictureBox smPicture7;
        private System.Windows.Forms.PictureBox smPicture5;
        private System.Windows.Forms.PictureBox smPicture3;
        private System.Windows.Forms.PictureBox smPicture2;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button submitBttn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel productPanel;
        private System.Windows.Forms.ComboBox productQty;
        private System.Windows.Forms.PictureBox productImage;
        private System.Windows.Forms.Label productDescriptionText;
        private System.Windows.Forms.Label productDecription;
        private System.Windows.Forms.Button buyNowBtn;
        private System.Windows.Forms.Button addCartBtn;
        private System.Windows.Forms.Label productPrice;
        private System.Windows.Forms.Label productTitle;
        private System.Windows.Forms.PictureBox backPicture;
        private System.Windows.Forms.Panel categoryPanel;
        private System.Windows.Forms.Label categoryHeader;
        private System.Windows.Forms.PictureBox categoryBack;
        private System.Windows.Forms.PictureBox categoryPic13;
        private System.Windows.Forms.PictureBox categoryPic12;
        private System.Windows.Forms.PictureBox categoryPic11;
        private System.Windows.Forms.PictureBox categoryPic10;
        private System.Windows.Forms.PictureBox categoryPic9;
        private System.Windows.Forms.PictureBox categoryPic8;
        private System.Windows.Forms.PictureBox categoryPic7;
        private System.Windows.Forms.PictureBox categoryPic6;
        private System.Windows.Forms.PictureBox categoryPic5;
        private System.Windows.Forms.PictureBox categoryPic4;
        private System.Windows.Forms.PictureBox categoryPic3;
        private System.Windows.Forms.PictureBox categoryPic2;
        private System.Windows.Forms.Label categoryLabel1;
        private System.Windows.Forms.Label categoryLabel2;
        private System.Windows.Forms.Label categoryLabel3;
        private System.Windows.Forms.Label categoryLabel4;
        private System.Windows.Forms.Label categoryLabel5;
        private System.Windows.Forms.Label categoryLabel6;
        private System.Windows.Forms.Label categoryLabel7;
        private System.Windows.Forms.Label categoryLabel8;
        private System.Windows.Forms.Label categoryLabel9;
        private System.Windows.Forms.Label categoryLabel10;
        private System.Windows.Forms.Label categoryLabel11;
        private System.Windows.Forms.Label categoryLabel12;
        private System.Windows.Forms.Panel homePanel;
        private Label adminLabel;
    }
}

