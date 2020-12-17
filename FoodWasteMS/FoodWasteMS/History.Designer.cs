namespace FoodWasteMS
{
    partial class History
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
            this.left = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnDelboy = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.button11 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.top = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.userMgr1 = new FoodWasteMS.userMgr();
            this.userShopkeeper1 = new FoodWasteMS.userShopkeeper();
            this.userDelboy1 = new FoodWasteMS.userDelboy();
            this.user_Customer1 = new FoodWasteMS.User_Customer();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnMgr = new System.Windows.Forms.Button();
            this.btnSHopkeeper = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.left.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.left.Controls.Add(this.SidePanel);
            this.left.Controls.Add(this.btnDelboy);
            this.left.Controls.Add(this.btnCustomer);
            this.left.Controls.Add(this.btnMgr);
            this.left.Controls.Add(this.btnSHopkeeper);
            this.left.Controls.Add(this.pictureBox9);
            this.left.Location = new System.Drawing.Point(0, 0);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(383, 831);
            this.left.TabIndex = 16;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.White;
            this.SidePanel.Location = new System.Drawing.Point(368, 209);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(16, 85);
            this.SidePanel.TabIndex = 33;
            // 
            // btnDelboy
            // 
            this.btnDelboy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelboy.FlatAppearance.BorderSize = 0;
            this.btnDelboy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelboy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelboy.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelboy.ForeColor = System.Drawing.Color.White;
            this.btnDelboy.Image = global::FoodWasteMS.Properties.Resources.Worker_30px;
            this.btnDelboy.Location = new System.Drawing.Point(0, 463);
            this.btnDelboy.Name = "btnDelboy";
            this.btnDelboy.Size = new System.Drawing.Size(383, 79);
            this.btnDelboy.TabIndex = 32;
            this.btnDelboy.Text = "        Delivery Boy Log";
            this.btnDelboy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelboy.UseVisualStyleBackColor = true;
            this.btnDelboy.Click += new System.EventHandler(this.btnDelboy_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(388, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1094, 60);
            this.panel3.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 38);
            this.label1.TabIndex = 27;
            this.label1.Text = "Log List";
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.SidePanel;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this;
            this.bunifuDragControl3.Vertical = true;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Wide Latin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(1423, -6);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(40, 30);
            this.button11.TabIndex = 39;
            this.button11.Text = "-";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1460, -1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 25);
            this.button3.TabIndex = 37;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.top.Location = new System.Drawing.Point(379, -1);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(1038, 19);
            this.top.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(836, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 38);
            this.label2.TabIndex = 40;
            this.label2.Text = "All Logs";
            // 
            // userMgr1
            // 
            this.userMgr1.Location = new System.Drawing.Point(388, 186);
            this.userMgr1.Name = "userMgr1";
            this.userMgr1.Size = new System.Drawing.Size(1093, 625);
            this.userMgr1.TabIndex = 18;
            // 
            // userShopkeeper1
            // 
            this.userShopkeeper1.Location = new System.Drawing.Point(388, 186);
            this.userShopkeeper1.Name = "userShopkeeper1";
            this.userShopkeeper1.Size = new System.Drawing.Size(1093, 625);
            this.userShopkeeper1.TabIndex = 20;
            // 
            // userDelboy1
            // 
            this.userDelboy1.Location = new System.Drawing.Point(388, 186);
            this.userDelboy1.Name = "userDelboy1";
            this.userDelboy1.Size = new System.Drawing.Size(1093, 622);
            this.userDelboy1.TabIndex = 19;
            // 
            // user_Customer1
            // 
            this.user_Customer1.Location = new System.Drawing.Point(388, 186);
            this.user_Customer1.Name = "user_Customer1";
            this.user_Customer1.Size = new System.Drawing.Size(1093, 625);
            this.user_Customer1.TabIndex = 17;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.userMgr1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Image = global::FoodWasteMS.Properties.Resources.Customer_30px;
            this.btnCustomer.Location = new System.Drawing.Point(0, 293);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(383, 79);
            this.btnCustomer.TabIndex = 31;
            this.btnCustomer.Text = "         Customer Log";
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnMgr
            // 
            this.btnMgr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnMgr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMgr.FlatAppearance.BorderSize = 0;
            this.btnMgr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMgr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMgr.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnMgr.ForeColor = System.Drawing.Color.White;
            this.btnMgr.Image = global::FoodWasteMS.Properties.Resources.Businessman_30px;
            this.btnMgr.Location = new System.Drawing.Point(0, 209);
            this.btnMgr.Name = "btnMgr";
            this.btnMgr.Size = new System.Drawing.Size(383, 85);
            this.btnMgr.TabIndex = 30;
            this.btnMgr.Text = "        Manager Log";
            this.btnMgr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMgr.UseVisualStyleBackColor = false;
            this.btnMgr.Click += new System.EventHandler(this.btnMgr_Click);
            // 
            // btnSHopkeeper
            // 
            this.btnSHopkeeper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSHopkeeper.FlatAppearance.BorderSize = 0;
            this.btnSHopkeeper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSHopkeeper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSHopkeeper.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSHopkeeper.ForeColor = System.Drawing.Color.White;
            this.btnSHopkeeper.Image = global::FoodWasteMS.Properties.Resources.Collaborator_Male_30px;
            this.btnSHopkeeper.Location = new System.Drawing.Point(0, 378);
            this.btnSHopkeeper.Name = "btnSHopkeeper";
            this.btnSHopkeeper.Size = new System.Drawing.Size(383, 79);
            this.btnSHopkeeper.TabIndex = 3;
            this.btnSHopkeeper.Text = "      Shopkeeper Log";
            this.btnSHopkeeper.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSHopkeeper.UseVisualStyleBackColor = true;
            this.btnSHopkeeper.Click += new System.EventHandler(this.btnSHopkeeper_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::FoodWasteMS.Properties.Resources.AccountIcon_white;
            this.pictureBox9.Location = new System.Drawing.Point(140, 30);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(93, 93);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 0;
            this.pictureBox9.TabStop = false;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1494, 820);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.left);
            this.Controls.Add(this.top);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.userMgr1);
            this.Controls.Add(this.userShopkeeper1);
            this.Controls.Add(this.userDelboy1);
            this.Controls.Add(this.user_Customer1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "History";
            this.left.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel left;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnDelboy;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnMgr;
        private System.Windows.Forms.Button btnSHopkeeper;
        private System.Windows.Forms.PictureBox pictureBox9;
        private User_Customer user_Customer1;
        private userMgr userMgr1;
        private userDelboy userDelboy1;
        private userShopkeeper userShopkeeper1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button3;
    }
}