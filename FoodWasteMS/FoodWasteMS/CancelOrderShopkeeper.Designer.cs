namespace FoodWasteMS
{
    partial class CancelOrderShopkeeper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelOrderShopkeeper));
            this.button3 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.top = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dgvCancelOrder = new System.Windows.Forms.DataGridView();
            this.REPLACE_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shpkper_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mgr_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SHOPKEEPER_LOCATION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shpkper_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SHPKPERORDERDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expire_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel10 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtrepId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxProId = new System.Windows.Forms.TextBox();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblidShopkeeper = new System.Windows.Forms.Label();
            this.txtAutoChnager = new System.Windows.Forms.TextBox();
            this.bottom = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCancel = new System.Windows.Forms.Label();
            this.top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancelOrder)).BeginInit();
            this.panel10.SuspendLayout();
            this.bottom.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1462, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 22);
            this.button3.TabIndex = 4;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Wide Latin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(1422, -3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(40, 25);
            this.button11.TabIndex = 13;
            this.button11.Text = "-";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.top.Controls.Add(this.button11);
            this.top.Location = new System.Drawing.Point(3, -2);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(1465, 22);
            this.top.TabIndex = 5;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.dgvCancelOrder;
            this.bunifuDragControl1.Vertical = true;
            // 
            // dgvCancelOrder
            // 
            this.dgvCancelOrder.AllowUserToAddRows = false;
            this.dgvCancelOrder.AllowUserToDeleteRows = false;
            this.dgvCancelOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCancelOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCancelOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.REPLACE_ID,
            this.shpkper_id,
            this.mgr_id,
            this.product_id,
            this.PRODUCT_NAME,
            this.quantity,
            this.SHOPKEEPER_LOCATION,
            this.shpkper_phone,
            this.SHPKPERORDERDATE,
            this.Expire_date});
            this.dgvCancelOrder.Location = new System.Drawing.Point(383, 199);
            this.dgvCancelOrder.Name = "dgvCancelOrder";
            this.dgvCancelOrder.ReadOnly = true;
            this.dgvCancelOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCancelOrder.Size = new System.Drawing.Size(1099, 622);
            this.dgvCancelOrder.TabIndex = 32;
            this.dgvCancelOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCancelOrder_CellDoubleClick);
            // 
            // REPLACE_ID
            // 
            this.REPLACE_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.REPLACE_ID.DataPropertyName = "REPLACE_ID";
            this.REPLACE_ID.HeaderText = "REPLACE_ID";
            this.REPLACE_ID.Name = "REPLACE_ID";
            this.REPLACE_ID.ReadOnly = true;
            this.REPLACE_ID.Visible = false;
            // 
            // shpkper_id
            // 
            this.shpkper_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.shpkper_id.DataPropertyName = "shpkper_id";
            this.shpkper_id.HeaderText = "shpkper_id";
            this.shpkper_id.Name = "shpkper_id";
            this.shpkper_id.ReadOnly = true;
            this.shpkper_id.Visible = false;
            // 
            // mgr_id
            // 
            this.mgr_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mgr_id.DataPropertyName = "mgr_id";
            this.mgr_id.HeaderText = "mgr_id";
            this.mgr_id.Name = "mgr_id";
            this.mgr_id.ReadOnly = true;
            this.mgr_id.Visible = false;
            // 
            // product_id
            // 
            this.product_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.product_id.DataPropertyName = "product_id";
            this.product_id.HeaderText = "Product id";
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            // 
            // PRODUCT_NAME
            // 
            this.PRODUCT_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRODUCT_NAME.DataPropertyName = "PRODUCT_NAME";
            this.PRODUCT_NAME.HeaderText = "Product Name";
            this.PRODUCT_NAME.Name = "PRODUCT_NAME";
            this.PRODUCT_NAME.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // SHOPKEEPER_LOCATION
            // 
            this.SHOPKEEPER_LOCATION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SHOPKEEPER_LOCATION.DataPropertyName = "SHOPKEEPER_LOCATION";
            this.SHOPKEEPER_LOCATION.HeaderText = "Location";
            this.SHOPKEEPER_LOCATION.Name = "SHOPKEEPER_LOCATION";
            this.SHOPKEEPER_LOCATION.ReadOnly = true;
            // 
            // shpkper_phone
            // 
            this.shpkper_phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.shpkper_phone.DataPropertyName = "shpkper_phone";
            this.shpkper_phone.HeaderText = "Phone";
            this.shpkper_phone.Name = "shpkper_phone";
            this.shpkper_phone.ReadOnly = true;
            // 
            // SHPKPERORDERDATE
            // 
            this.SHPKPERORDERDATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SHPKPERORDERDATE.DataPropertyName = "SHPKPERORDERDATE";
            this.SHPKPERORDERDATE.HeaderText = "Order Date";
            this.SHPKPERORDERDATE.Name = "SHPKPERORDERDATE";
            this.SHPKPERORDERDATE.ReadOnly = true;
            // 
            // Expire_date
            // 
            this.Expire_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Expire_date.DataPropertyName = "Expire_date";
            this.Expire_date.HeaderText = "Expired Date";
            this.Expire_date.Name = "Expire_date";
            this.Expire_date.ReadOnly = true;
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
            this.bunifuDragControl3.TargetControl = this.top;
            this.bunifuDragControl3.Vertical = true;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel10.Controls.Add(this.label4);
            this.panel10.Controls.Add(this.txtQuantity);
            this.panel10.Controls.Add(this.txtrepId);
            this.panel10.Controls.Add(this.label3);
            this.panel10.Controls.Add(this.label1);
            this.panel10.Controls.Add(this.txtboxProId);
            this.panel10.Controls.Add(this.txtProName);
            this.panel10.Controls.Add(this.label2);
            this.panel10.Controls.Add(this.btnCancel);
            this.panel10.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel10.Location = new System.Drawing.Point(-2, -2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(379, 851);
            this.panel10.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(75, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "Product Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtQuantity.Location = new System.Drawing.Point(79, 498);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(233, 31);
            this.txtQuantity.TabIndex = 22;
            // 
            // txtrepId
            // 
            this.txtrepId.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtrepId.Location = new System.Drawing.Point(79, 159);
            this.txtrepId.Multiline = true;
            this.txtrepId.Name = "txtrepId";
            this.txtrepId.ReadOnly = true;
            this.txtrepId.Size = new System.Drawing.Size(233, 31);
            this.txtrepId.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(75, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Replace Product Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Product Id";
            // 
            // txtboxProId
            // 
            this.txtboxProId.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtboxProId.Location = new System.Drawing.Point(79, 400);
            this.txtboxProId.Multiline = true;
            this.txtboxProId.Name = "txtboxProId";
            this.txtboxProId.ReadOnly = true;
            this.txtboxProId.Size = new System.Drawing.Size(233, 31);
            this.txtboxProId.TabIndex = 11;
            // 
            // txtProName
            // 
            this.txtProName.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtProName.Location = new System.Drawing.Point(79, 281);
            this.txtProName.Multiline = true;
            this.txtProName.Name = "txtProName";
            this.txtProName.ReadOnly = true;
            this.txtProName.Size = new System.Drawing.Size(233, 31);
            this.txtProName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(75, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Product Name";
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::FoodWasteMS.Properties.Resources.Cancel_30px;
            this.btnCancel.Location = new System.Drawing.Point(-7, 646);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(386, 76);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "       Cancel Replace Request";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblidShopkeeper
            // 
            this.lblidShopkeeper.AutoSize = true;
            this.lblidShopkeeper.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidShopkeeper.ForeColor = System.Drawing.Color.White;
            this.lblidShopkeeper.Location = new System.Drawing.Point(406, 212);
            this.lblidShopkeeper.Name = "lblidShopkeeper";
            this.lblidShopkeeper.Size = new System.Drawing.Size(135, 22);
            this.lblidShopkeeper.TabIndex = 18;
            this.lblidShopkeeper.Text = "idshopkeeper";
            this.lblidShopkeeper.Visible = false;
            // 
            // txtAutoChnager
            // 
            this.txtAutoChnager.BackColor = System.Drawing.Color.White;
            this.txtAutoChnager.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoChnager.ForeColor = System.Drawing.Color.Black;
            this.txtAutoChnager.Location = new System.Drawing.Point(864, 11);
            this.txtAutoChnager.Multiline = true;
            this.txtAutoChnager.Name = "txtAutoChnager";
            this.txtAutoChnager.Size = new System.Drawing.Size(224, 32);
            this.txtAutoChnager.TabIndex = 35;
            this.txtAutoChnager.TextChanged += new System.EventHandler(this.txtAutoChnager_TextChanged);
            // 
            // bottom
            // 
            this.bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.bottom.Controls.Add(this.label9);
            this.bottom.Controls.Add(this.lblCount);
            this.bottom.Location = new System.Drawing.Point(383, 779);
            this.bottom.Name = "bottom";
            this.bottom.Size = new System.Drawing.Size(1099, 42);
            this.bottom.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(456, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 22);
            this.label9.TabIndex = 32;
            this.label9.Text = "Total Orders :";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.White;
            this.lblCount.Location = new System.Drawing.Point(600, 10);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(65, 22);
            this.lblCount.TabIndex = 31;
            this.lblCount.Text = "count";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.txtAutoChnager);
            this.panel3.Location = new System.Drawing.Point(383, 157);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1099, 47);
            this.panel3.TabIndex = 54;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::FoodWasteMS.Properties.Resources.Search_40px;
            this.pictureBox2.Location = new System.Drawing.Point(1052, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(16, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 38);
            this.label8.TabIndex = 27;
            this.label8.Text = "All Orders";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(873, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 1);
            this.panel1.TabIndex = 28;
            // 
            // lblCancel
            // 
            this.lblCancel.AutoSize = true;
            this.lblCancel.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancel.ForeColor = System.Drawing.Color.Black;
            this.lblCancel.Location = new System.Drawing.Point(836, 49);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(214, 38);
            this.lblCancel.TabIndex = 56;
            this.lblCancel.Text = "Cancel Order";
            // 
            // CancelOrderShopkeeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1494, 820);
            this.Controls.Add(this.lblCancel);
            this.Controls.Add(this.bottom);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvCancelOrder);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblidShopkeeper);
            this.Controls.Add(this.top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CancelOrderShopkeeper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CancelOrderShopkeeper";
            this.Load += new System.EventHandler(this.CancelOrderShopkeeper_Load);
            this.top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancelOrder)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.bottom.ResumeLayout(false);
            this.bottom.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel top;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private System.Windows.Forms.DataGridView dgvCancelOrder;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lblidShopkeeper;
        private System.Windows.Forms.TextBox txtboxProId;
        private System.Windows.Forms.TextBox txtProName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtAutoChnager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtrepId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn REPLACE_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn shpkper_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn mgr_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SHOPKEEPER_LOCATION;
        private System.Windows.Forms.DataGridViewTextBoxColumn shpkper_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn SHPKPERORDERDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expire_date;
        private System.Windows.Forms.Panel bottom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCancel;
    }
}