namespace FoodWasteMS
{
    partial class SetDiscount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetDiscount));
            this.left = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnSent = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnRem = new System.Windows.Forms.Button();
            this.txtboxMessage = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.btnDisSet = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.top = new System.Windows.Forms.Panel();
            this.dgvDiscount = new System.Windows.Forms.DataGridView();
            this.item_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXPIRE_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUST_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MGR_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label22 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bottom = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAutoChnager = new System.Windows.Forms.TextBox();
            this.left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscount)).BeginInit();
            this.bottom.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.left.Controls.Add(this.SidePanel);
            this.left.Controls.Add(this.btnSent);
            this.left.Controls.Add(this.label3);
            this.left.Controls.Add(this.label1);
            this.left.Controls.Add(this.label20);
            this.left.Controls.Add(this.btnRem);
            this.left.Controls.Add(this.txtboxMessage);
            this.left.Controls.Add(this.txtDiscount);
            this.left.Controls.Add(this.btnDisSet);
            this.left.Controls.Add(this.pictureBox9);
            this.left.Location = new System.Drawing.Point(0, 0);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(380, 833);
            this.left.TabIndex = 16;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.White;
            this.SidePanel.Location = new System.Drawing.Point(364, 312);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(16, 67);
            this.SidePanel.TabIndex = 36;
            // 
            // btnSent
            // 
            this.btnSent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSent.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSent.ForeColor = System.Drawing.Color.White;
            this.btnSent.Image = global::FoodWasteMS.Properties.Resources.Checked_30px;
            this.btnSent.Location = new System.Drawing.Point(-10, 312);
            this.btnSent.Name = "btnSent";
            this.btnSent.Size = new System.Drawing.Size(390, 67);
            this.btnSent.TabIndex = 12;
            this.btnSent.Text = "                   Sent";
            this.btnSent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSent.UseVisualStyleBackColor = true;
            this.btnSent.Click += new System.EventHandler(this.btnSent_Click);
            this.btnSent.MouseHover += new System.EventHandler(this.btnSent_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(61, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sent Message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(288, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "%";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(71, 429);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(110, 20);
            this.label20.TabIndex = 9;
            this.label20.Text = "Discount Rate";
            // 
            // btnRem
            // 
            this.btnRem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRem.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRem.ForeColor = System.Drawing.Color.White;
            this.btnRem.Image = global::FoodWasteMS.Properties.Resources.Remve_27_white;
            this.btnRem.Location = new System.Drawing.Point(-10, 593);
            this.btnRem.Name = "btnRem";
            this.btnRem.Size = new System.Drawing.Size(390, 67);
            this.btnRem.TabIndex = 8;
            this.btnRem.Text = "        Remove Product";
            this.btnRem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRem.UseVisualStyleBackColor = true;
            this.btnRem.Click += new System.EventHandler(this.button1_Click);
            this.btnRem.MouseHover += new System.EventHandler(this.btnRem_MouseHover);
            // 
            // txtboxMessage
            // 
            this.txtboxMessage.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxMessage.Location = new System.Drawing.Point(65, 257);
            this.txtboxMessage.Multiline = true;
            this.txtboxMessage.Name = "txtboxMessage";
            this.txtboxMessage.Size = new System.Drawing.Size(255, 36);
            this.txtboxMessage.TabIndex = 7;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtDiscount.Location = new System.Drawing.Point(75, 467);
            this.txtDiscount.Multiline = true;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(236, 31);
            this.txtDiscount.TabIndex = 6;
            // 
            // btnDisSet
            // 
            this.btnDisSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisSet.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisSet.ForeColor = System.Drawing.Color.White;
            this.btnDisSet.Image = global::FoodWasteMS.Properties.Resources.Checked_30px;
            this.btnDisSet.Location = new System.Drawing.Point(-10, 675);
            this.btnDisSet.Name = "btnDisSet";
            this.btnDisSet.Size = new System.Drawing.Size(390, 67);
            this.btnDisSet.TabIndex = 4;
            this.btnDisSet.Text = "         Set Discount";
            this.btnDisSet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDisSet.UseVisualStyleBackColor = true;
            this.btnDisSet.Click += new System.EventHandler(this.button10_Click);
            this.btnDisSet.MouseHover += new System.EventHandler(this.btnDisSet_MouseHover);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::FoodWasteMS.Properties.Resources.AccountIcon_white;
            this.pictureBox9.Location = new System.Drawing.Point(146, 24);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(93, 93);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 0;
            this.pictureBox9.TabStop = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Wide Latin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(1423, -7);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(40, 35);
            this.button11.TabIndex = 29;
            this.button11.Text = "-";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1460, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 25);
            this.button3.TabIndex = 17;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.top.Controls.Add(this.button11);
            this.top.Location = new System.Drawing.Point(0, 0);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(1463, 24);
            this.top.TabIndex = 18;
            // 
            // dgvDiscount
            // 
            this.dgvDiscount.AllowUserToAddRows = false;
            this.dgvDiscount.AllowUserToDeleteRows = false;
            this.dgvDiscount.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvDiscount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item_id,
            this.PRODUCT_ID,
            this.PRODUCT_NAME,
            this.QUANTITY,
            this.EXPIRE_DATE,
            this.PRICE,
            this.CAT_ID,
            this.CUST_ID,
            this.MGR_ID});
            this.dgvDiscount.Location = new System.Drawing.Point(386, 230);
            this.dgvDiscount.Name = "dgvDiscount";
            this.dgvDiscount.ReadOnly = true;
            this.dgvDiscount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiscount.Size = new System.Drawing.Size(1096, 590);
            this.dgvDiscount.TabIndex = 19;
            this.dgvDiscount.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // item_id
            // 
            this.item_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.item_id.DataPropertyName = "item_id";
            this.item_id.HeaderText = "item_id";
            this.item_id.Name = "item_id";
            this.item_id.ReadOnly = true;
            // 
            // PRODUCT_ID
            // 
            this.PRODUCT_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRODUCT_ID.DataPropertyName = "PRODUCT_ID";
            this.PRODUCT_ID.HeaderText = "Product Id";
            this.PRODUCT_ID.Name = "PRODUCT_ID";
            this.PRODUCT_ID.ReadOnly = true;
            // 
            // PRODUCT_NAME
            // 
            this.PRODUCT_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRODUCT_NAME.DataPropertyName = "PRODUCT_NAME";
            this.PRODUCT_NAME.HeaderText = "Product Name";
            this.PRODUCT_NAME.Name = "PRODUCT_NAME";
            this.PRODUCT_NAME.ReadOnly = true;
            // 
            // QUANTITY
            // 
            this.QUANTITY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QUANTITY.DataPropertyName = "QUANTITY";
            this.QUANTITY.HeaderText = "Quantity";
            this.QUANTITY.Name = "QUANTITY";
            this.QUANTITY.ReadOnly = true;
            // 
            // EXPIRE_DATE
            // 
            this.EXPIRE_DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EXPIRE_DATE.DataPropertyName = "EXPIRE_DATE";
            this.EXPIRE_DATE.HeaderText = "Expired Date";
            this.EXPIRE_DATE.Name = "EXPIRE_DATE";
            this.EXPIRE_DATE.ReadOnly = true;
            // 
            // PRICE
            // 
            this.PRICE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRICE.DataPropertyName = "PRICE";
            this.PRICE.HeaderText = "Price Per product";
            this.PRICE.Name = "PRICE";
            this.PRICE.ReadOnly = true;
            // 
            // CAT_ID
            // 
            this.CAT_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CAT_ID.DataPropertyName = "CAT_ID";
            this.CAT_ID.HeaderText = "Category Id";
            this.CAT_ID.Name = "CAT_ID";
            this.CAT_ID.ReadOnly = true;
            // 
            // CUST_ID
            // 
            this.CUST_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CUST_ID.DataPropertyName = "CUST_ID";
            this.CUST_ID.HeaderText = "CUST_ID";
            this.CUST_ID.Name = "CUST_ID";
            this.CUST_ID.ReadOnly = true;
            this.CUST_ID.Visible = false;
            // 
            // MGR_ID
            // 
            this.MGR_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MGR_ID.DataPropertyName = "MGR_ID";
            this.MGR_ID.HeaderText = "MGR_ID";
            this.MGR_ID.Name = "MGR_ID";
            this.MGR_ID.ReadOnly = true;
            this.MGR_ID.Visible = false;
            // 
            // txtItemId
            // 
            this.txtItemId.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtItemId.Location = new System.Drawing.Point(386, 30);
            this.txtItemId.Multiline = true;
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(236, 31);
            this.txtItemId.TabIndex = 20;
            this.txtItemId.Visible = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtPrice.Location = new System.Drawing.Point(386, 67);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(236, 31);
            this.txtPrice.TabIndex = 21;
            this.txtPrice.Visible = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.top;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.dgvDiscount;
            this.bunifuDragControl3.Vertical = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.White;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label22.Location = new System.Drawing.Point(691, 359);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 20);
            this.label22.TabIndex = 19;
            this.label22.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 24F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(842, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 38);
            this.label2.TabIndex = 26;
            this.label2.Text = "Product List For Customers";
            // 
            // bottom
            // 
            this.bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.bottom.Controls.Add(this.label8);
            this.bottom.Controls.Add(this.lblCount);
            this.bottom.Location = new System.Drawing.Point(387, 778);
            this.bottom.Name = "bottom";
            this.bottom.Size = new System.Drawing.Size(1096, 42);
            this.bottom.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(434, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 22);
            this.label8.TabIndex = 32;
            this.label8.Text = "Total Products :";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.White;
            this.lblCount.Location = new System.Drawing.Point(590, 11);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(65, 22);
            this.lblCount.TabIndex = 31;
            this.lblCount.Text = "count";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.txtAutoChnager);
            this.panel3.Location = new System.Drawing.Point(386, 176);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1097, 57);
            this.panel3.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 38);
            this.label4.TabIndex = 27;
            this.label4.Text = "All Products";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::FoodWasteMS.Properties.Resources.Search_40px;
            this.pictureBox1.Location = new System.Drawing.Point(1058, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // txtAutoChnager
            // 
            this.txtAutoChnager.BackColor = System.Drawing.Color.White;
            this.txtAutoChnager.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoChnager.ForeColor = System.Drawing.Color.Black;
            this.txtAutoChnager.Location = new System.Drawing.Point(870, 16);
            this.txtAutoChnager.Multiline = true;
            this.txtAutoChnager.Name = "txtAutoChnager";
            this.txtAutoChnager.Size = new System.Drawing.Size(224, 32);
            this.txtAutoChnager.TabIndex = 26;
            this.txtAutoChnager.TextChanged += new System.EventHandler(this.txtAutoChnager_TextChanged);
            // 
            // SetDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1494, 820);
            this.Controls.Add(this.bottom);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtItemId);
            this.Controls.Add(this.dgvDiscount);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.left);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SetDiscount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SetDiscount";
            this.Load += new System.EventHandler(this.SetDiscount_Load);
            this.left.ResumeLayout(false);
            this.left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscount)).EndInit();
            this.bottom.ResumeLayout(false);
            this.bottom.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel left;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.DataGridView dgvDiscount;
        private System.Windows.Forms.Button btnDisSet;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtboxMessage;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private System.Windows.Forms.Button btnRem;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel bottom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtAutoChnager;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXPIRE_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUST_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MGR_ID;
        private System.Windows.Forms.Panel SidePanel;
    }
}