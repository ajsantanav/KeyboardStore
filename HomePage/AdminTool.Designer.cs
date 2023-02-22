
namespace HomePage
{
    partial class AdminTool
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminTool));
            this.textBox_SearchValue = new System.Windows.Forms.TextBox();
            this.comboBox_SearchParam = new System.Windows.Forms.ComboBox();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView_All = new System.Windows.Forms.DataGridView();
            this.button_ExitWithoutSaving = new System.Windows.Forms.Button();
            this.button_SaveAndExit = new System.Windows.Forms.Button();
            this.button_ViewOrdersOnly = new System.Windows.Forms.Button();
            this.button_UndoChanges = new System.Windows.Forms.Button();
            this.button_CommitChanges = new System.Windows.Forms.Button();
            this.button_FindRecord = new System.Windows.Forms.Button();
            this.button_ViewAll = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_DeleteValue = new System.Windows.Forms.TextBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridView_Orders = new System.Windows.Forms.DataGridView();
            this.combinedDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combinedDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label_Copyright = new System.Windows.Forms.Label();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Culumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_All)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combinedDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combinedDBDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Location = new System.Drawing.Point(745, 17);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(74, 13);
            label3.TabIndex = 4;
            label3.Text = "Logged IN as:";
            // 
            // textBox_SearchValue
            // 
            this.textBox_SearchValue.Location = new System.Drawing.Point(537, 103);
            this.textBox_SearchValue.Name = "textBox_SearchValue";
            this.textBox_SearchValue.Size = new System.Drawing.Size(227, 20);
            this.textBox_SearchValue.TabIndex = 0;
            // 
            // comboBox_SearchParam
            // 
            this.comboBox_SearchParam.FormattingEnabled = true;
            this.comboBox_SearchParam.Items.AddRange(new object[] {
            "UserID",
            "Username",
            "OrderID",
            "Last Name"});
            this.comboBox_SearchParam.Location = new System.Drawing.Point(126, 103);
            this.comboBox_SearchParam.MaxDropDownItems = 12;
            this.comboBox_SearchParam.Name = "comboBox_SearchParam";
            this.comboBox_SearchParam.Size = new System.Drawing.Size(397, 21);
            this.comboBox_SearchParam.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(21, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search records by:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Forte", 40F);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(36, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(472, 60);
            this.label2.TabIndex = 3;
            this.label2.Text = "Administrator Tool";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(824, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID*";
            // 
            // dataGridView_All
            // 
            this.dataGridView_All.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_All.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dataGridView_All.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView_All.Location = new System.Drawing.Point(26, 183);
            this.dataGridView_All.Name = "dataGridView_All";
            this.dataGridView_All.Size = new System.Drawing.Size(880, 296);
            this.dataGridView_All.TabIndex = 6;
            // 
            // button_ExitWithoutSaving
            // 
            this.button_ExitWithoutSaving.BackColor = System.Drawing.Color.LightSlateGray;
            this.button_ExitWithoutSaving.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ExitWithoutSaving.Font = new System.Drawing.Font("Forte", 20F);
            this.button_ExitWithoutSaving.ForeColor = System.Drawing.SystemColors.Menu;
            this.button_ExitWithoutSaving.Location = new System.Drawing.Point(730, 582);
            this.button_ExitWithoutSaving.Name = "button_ExitWithoutSaving";
            this.button_ExitWithoutSaving.Size = new System.Drawing.Size(177, 68);
            this.button_ExitWithoutSaving.TabIndex = 7;
            this.button_ExitWithoutSaving.Text = "Exit without Saving";
            this.button_ExitWithoutSaving.UseVisualStyleBackColor = false;
            this.button_ExitWithoutSaving.Click += new System.EventHandler(this.button_ExitWithoutSaving_Click);
            // 
            // button_SaveAndExit
            // 
            this.button_SaveAndExit.BackColor = System.Drawing.Color.LightSlateGray;
            this.button_SaveAndExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SaveAndExit.Font = new System.Drawing.Font("Forte", 20F);
            this.button_SaveAndExit.ForeColor = System.Drawing.SystemColors.Menu;
            this.button_SaveAndExit.Location = new System.Drawing.Point(329, 582);
            this.button_SaveAndExit.Name = "button_SaveAndExit";
            this.button_SaveAndExit.Size = new System.Drawing.Size(378, 68);
            this.button_SaveAndExit.TabIndex = 8;
            this.button_SaveAndExit.Text = "Save and Exit";
            this.button_SaveAndExit.UseVisualStyleBackColor = false;
            this.button_SaveAndExit.Click += new System.EventHandler(this.button_SaveAndExit_Click);
            // 
            // button_ViewOrdersOnly
            // 
            this.button_ViewOrdersOnly.BackColor = System.Drawing.Color.LightSlateGray;
            this.button_ViewOrdersOnly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ViewOrdersOnly.Font = new System.Drawing.Font("Forte", 20F);
            this.button_ViewOrdersOnly.ForeColor = System.Drawing.SystemColors.Menu;
            this.button_ViewOrdersOnly.Location = new System.Drawing.Point(730, 497);
            this.button_ViewOrdersOnly.Name = "button_ViewOrdersOnly";
            this.button_ViewOrdersOnly.Size = new System.Drawing.Size(177, 65);
            this.button_ViewOrdersOnly.TabIndex = 10;
            this.button_ViewOrdersOnly.Text = "Orders Only";
            this.button_ViewOrdersOnly.UseVisualStyleBackColor = false;
            this.button_ViewOrdersOnly.Click += new System.EventHandler(this.button_ViewOrdersOnly_Click);
            // 
            // button_UndoChanges
            // 
            this.button_UndoChanges.BackColor = System.Drawing.Color.LightSlateGray;
            this.button_UndoChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_UndoChanges.Font = new System.Drawing.Font("Forte", 20F);
            this.button_UndoChanges.ForeColor = System.Drawing.SystemColors.Menu;
            this.button_UndoChanges.Location = new System.Drawing.Point(26, 582);
            this.button_UndoChanges.Name = "button_UndoChanges";
            this.button_UndoChanges.Size = new System.Drawing.Size(274, 68);
            this.button_UndoChanges.TabIndex = 11;
            this.button_UndoChanges.Text = "UnDo";
            this.button_UndoChanges.UseVisualStyleBackColor = false;
            this.button_UndoChanges.Click += new System.EventHandler(this.button_UndoChanges_Click);
            // 
            // button_CommitChanges
            // 
            this.button_CommitChanges.BackColor = System.Drawing.Color.LightSlateGray;
            this.button_CommitChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CommitChanges.Font = new System.Drawing.Font("Forte", 20F);
            this.button_CommitChanges.ForeColor = System.Drawing.SystemColors.Menu;
            this.button_CommitChanges.Location = new System.Drawing.Point(26, 497);
            this.button_CommitChanges.Name = "button_CommitChanges";
            this.button_CommitChanges.Size = new System.Drawing.Size(273, 65);
            this.button_CommitChanges.TabIndex = 12;
            this.button_CommitChanges.Text = "Save Changes";
            this.button_CommitChanges.UseVisualStyleBackColor = false;
            this.button_CommitChanges.Click += new System.EventHandler(this.button_commitChanges_Click);
            // 
            // button_FindRecord
            // 
            this.button_FindRecord.BackColor = System.Drawing.Color.LightSlateGray;
            this.button_FindRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_FindRecord.Font = new System.Drawing.Font("Forte", 10F);
            this.button_FindRecord.ForeColor = System.Drawing.SystemColors.Menu;
            this.button_FindRecord.Location = new System.Drawing.Point(777, 97);
            this.button_FindRecord.Name = "button_FindRecord";
            this.button_FindRecord.Size = new System.Drawing.Size(129, 32);
            this.button_FindRecord.TabIndex = 13;
            this.button_FindRecord.Text = "FIND RECORD";
            this.button_FindRecord.UseVisualStyleBackColor = false;
            this.button_FindRecord.Click += new System.EventHandler(this.button_FindRecord_Click);
            // 
            // button_ViewAll
            // 
            this.button_ViewAll.BackColor = System.Drawing.Color.LightSlateGray;
            this.button_ViewAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ViewAll.Font = new System.Drawing.Font("Forte", 20F);
            this.button_ViewAll.ForeColor = System.Drawing.SystemColors.Menu;
            this.button_ViewAll.Location = new System.Drawing.Point(329, 497);
            this.button_ViewAll.Name = "button_ViewAll";
            this.button_ViewAll.Size = new System.Drawing.Size(378, 65);
            this.button_ViewAll.TabIndex = 14;
            this.button_ViewAll.Text = "ALL Fields";
            this.button_ViewAll.UseVisualStyleBackColor = false;
            this.button_ViewAll.Click += new System.EventHandler(this.button_ViewAll_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(119, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "with UserID:";
            this.label5.Visible = false;
            // 
            // textBox_DeleteValue
            // 
            this.textBox_DeleteValue.Location = new System.Drawing.Point(191, 135);
            this.textBox_DeleteValue.Name = "textBox_DeleteValue";
            this.textBox_DeleteValue.Size = new System.Drawing.Size(203, 20);
            this.textBox_DeleteValue.TabIndex = 17;
            this.textBox_DeleteValue.Visible = false;
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.DarkRed;
            this.button_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Delete.Font = new System.Drawing.Font("Forte", 10F);
            this.button_Delete.ForeColor = System.Drawing.Color.White;
            this.button_Delete.Location = new System.Drawing.Point(406, 131);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(117, 28);
            this.button_Delete.TabIndex = 18;
            this.button_Delete.Text = "DELETE";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Visible = false;
            this.button_Delete.VisibleChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Location = new System.Drawing.Point(26, 139);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 17);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Delete Record";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dataGridView_Orders
            // 
            this.dataGridView_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column21,
            this.Column22,
            this.Culumn23});
            this.dataGridView_Orders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView_Orders.Location = new System.Drawing.Point(329, 183);
            this.dataGridView_Orders.Name = "dataGridView_Orders";
            this.dataGridView_Orders.Size = new System.Drawing.Size(345, 296);
            this.dataGridView_Orders.TabIndex = 20;
            this.dataGridView_Orders.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("NSimSun", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(523, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 14);
            this.label6.TabIndex = 21;
            this.label6.Text = "<-- Permanent Change";
            this.label6.Visible = false;
            // 
            // label_Copyright
            // 
            this.label_Copyright.AutoSize = true;
            this.label_Copyright.BackColor = System.Drawing.Color.Transparent;
            this.label_Copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Copyright.ForeColor = System.Drawing.Color.SaddleBrown;
            //this.label_Copyright.Image = global::HomePage.Properties.Resources
            this.label_Copyright.Location = new System.Drawing.Point(535, 665);
            this.label_Copyright.Name = "label_Copyright";
            this.label_Copyright.Size = new System.Drawing.Size(387, 20);
            this.label_Copyright.TabIndex = 22;
            this.label_Copyright.Text = "Designed by A-Team, CST4708. NYCCT Fall 2021 (C)";
            // 
            // Column21
            // 
            this.Column21.DataPropertyName = "OrderId";
            this.Column21.HeaderText = "OrderID";
            this.Column21.Name = "Column21";
            // 
            // Column22
            // 
            this.Column22.DataPropertyName = "OrderTotal";
            this.Column22.HeaderText = "Order Total";
            this.Column22.Name = "Column22";
            // 
            // Culumn23
            // 
            this.Culumn23.DataPropertyName = "UserId";
            this.Culumn23.HeaderText = "UserID";
            this.Culumn23.Name = "Culumn23";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Username";
            this.Column1.HeaderText = "Username";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "UserId";
            this.Column2.HeaderText = "UserID";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "OrderId";
            this.Column3.HeaderText = "OrderId";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "OrderTotal";
            this.Column4.HeaderText = "Ordertotal";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "name";
            this.Column5.HeaderText = "First Name";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Lname";
            this.Column6.HeaderText = "Last Name";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Email";
            this.Column7.HeaderText = "Email";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "city";
            this.Column8.HeaderText = "City";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "address";
            this.Column9.HeaderText = "Street";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "state";
            this.Column10.HeaderText = "State";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Zipcode";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Passocde";
            this.Column12.Name = "Column12";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 694);
            this.Controls.Add(this.label_Copyright);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView_Orders);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.textBox_DeleteValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_ViewAll);
            this.Controls.Add(this.button_FindRecord);
            this.Controls.Add(this.button_CommitChanges);
            this.Controls.Add(this.button_UndoChanges);
            this.Controls.Add(this.button_ViewOrdersOnly);
            this.Controls.Add(this.button_SaveAndExit);
            this.Controls.Add(this.button_ExitWithoutSaving);
            this.Controls.Add(this.dataGridView_All);
            this.Controls.Add(this.label4);
            this.Controls.Add(label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_SearchParam);
            this.Controls.Add(this.textBox_SearchValue);
            this.Name = "Form1";
            this.Text = "Administrator Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_All)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combinedDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combinedDBDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_SearchValue;
        private System.Windows.Forms.ComboBox comboBox_SearchParam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView_All;
        private System.Windows.Forms.Button button_ExitWithoutSaving;
        private System.Windows.Forms.Button button_SaveAndExit;
        private System.Windows.Forms.Button button_ViewOrdersOnly;
        private System.Windows.Forms.Button button_UndoChanges;
        private System.Windows.Forms.Button button_CommitChanges;
        private System.Windows.Forms.Button button_FindRecord;
        private System.Windows.Forms.Button button_ViewAll;
        private System.Windows.Forms.BindingSource combinedDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_DeleteValue;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.BindingSource combinedDBDataSetBindingSource1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.BindingSource repositoryBindingSource;
        private System.Windows.Forms.DataGridView dataGridView_Orders;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_Copyright;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Culumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
    }
}