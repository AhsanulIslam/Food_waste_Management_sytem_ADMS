namespace FoodWasteMS
{
    partial class MenuManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuManager));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.back = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.left = new System.Windows.Forms.Panel();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btndiscount = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblphone = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblfullname = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.top = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lbltype = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAssignForCust = new System.Windows.Forms.Button();
            this.btnViewCategory = new System.Windows.Forms.Button();
            this.btnViewCustOrdr = new System.Windows.Forms.Button();
            this.btnViewReplaceREQ = new System.Windows.Forms.Button();
            this.btnAssignforShopkeeper = new System.Windows.Forms.Button();
            this.btnupDate = new System.Windows.Forms.Button();
            this.btnRemvpr = new System.Windows.Forms.Button();
            this.btnAddpro = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.back;
            this.bunifuDragControl1.Vertical = true;
            // 
            // back
            // 
            this.back.Image = global::FoodWasteMS.Properties.Resources.LOGINIMG;
            this.back.Location = new System.Drawing.Point(0, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(1494, 820);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back.TabIndex = 30;
            this.back.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1459, -3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 24);
            this.button3.TabIndex = 13;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(800, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 30);
            this.label18.TabIndex = 16;
            this.label18.Text = "Welcome :";
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.left.Controls.Add(this.SidePanel);
            this.left.Controls.Add(this.btnHistory);
            this.left.Controls.Add(this.btndiscount);
            this.left.Controls.Add(this.label28);
            this.left.Controls.Add(this.label29);
            this.left.Controls.Add(this.lbladdress);
            this.left.Controls.Add(this.label26);
            this.left.Controls.Add(this.label27);
            this.left.Controls.Add(this.lblphone);
            this.left.Controls.Add(this.label24);
            this.left.Controls.Add(this.label25);
            this.left.Controls.Add(this.lblid);
            this.left.Controls.Add(this.label23);
            this.left.Controls.Add(this.label22);
            this.left.Controls.Add(this.lblfullname);
            this.left.Controls.Add(this.lbluser);
            this.left.Controls.Add(this.btnLogOut);
            this.left.Controls.Add(this.label21);
            this.left.Controls.Add(this.label20);
            this.left.Controls.Add(this.pictureBox9);
            this.left.Location = new System.Drawing.Point(-4, -3);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(380, 828);
            this.left.TabIndex = 15;
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.Image = global::FoodWasteMS.Properties.Resources.Clock_30px1;
            this.btnHistory.Location = new System.Drawing.Point(0, 647);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(384, 70);
            this.btnHistory.TabIndex = 31;
            this.btnHistory.Text = "           History";
            this.btnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            this.btnHistory.MouseHover += new System.EventHandler(this.btnHistory_MouseHover);
            // 
            // btndiscount
            // 
            this.btndiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btndiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndiscount.FlatAppearance.BorderSize = 0;
            this.btndiscount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btndiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndiscount.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btndiscount.ForeColor = System.Drawing.Color.White;
            this.btndiscount.Image = global::FoodWasteMS.Properties.Resources.Checked_30px1;
            this.btndiscount.Location = new System.Drawing.Point(3, 571);
            this.btndiscount.Name = "btndiscount";
            this.btndiscount.Size = new System.Drawing.Size(381, 70);
            this.btndiscount.TabIndex = 30;
            this.btndiscount.Text = "       Set Discount";
            this.btndiscount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndiscount.UseVisualStyleBackColor = false;
            this.btndiscount.Click += new System.EventHandler(this.button1_Click);
            this.btndiscount.MouseHover += new System.EventHandler(this.btndiscount_MouseHover);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(49, 506);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(14, 20);
            this.label28.TabIndex = 29;
            this.label28.Text = ":";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(35, 479);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(67, 20);
            this.label29.TabIndex = 28;
            this.label29.Text = "Address";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.ForeColor = System.Drawing.Color.White;
            this.lbladdress.Location = new System.Drawing.Point(69, 505);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(67, 20);
            this.lbladdress.TabIndex = 27;
            this.lbladdress.Text = "Address";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(49, 413);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(14, 20);
            this.label26.TabIndex = 26;
            this.label26.Text = ":";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(35, 388);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(56, 20);
            this.label27.TabIndex = 25;
            this.label27.Text = "Phone";
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone.ForeColor = System.Drawing.Color.White;
            this.lblphone.Location = new System.Drawing.Point(69, 414);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(57, 20);
            this.lblphone.TabIndex = 24;
            this.lblphone.Text = "phone";
            this.lblphone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(49, 253);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(14, 20);
            this.label24.TabIndex = 23;
            this.label24.Text = ":";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(35, 230);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(60, 20);
            this.label25.TabIndex = 22;
            this.label25.Text = "User Id";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.Color.White;
            this.lblid.Location = new System.Drawing.Point(69, 256);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(22, 20);
            this.lblid.TabIndex = 21;
            this.lblid.Text = "id";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(49, 182);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(14, 20);
            this.label23.TabIndex = 20;
            this.label23.Text = ":";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(35, 156);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 20);
            this.label22.TabIndex = 19;
            this.label22.Text = "Full Name";
            // 
            // lblfullname
            // 
            this.lblfullname.AutoSize = true;
            this.lblfullname.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfullname.ForeColor = System.Drawing.Color.White;
            this.lblfullname.Location = new System.Drawing.Point(69, 182);
            this.lblfullname.Name = "lblfullname";
            this.lblfullname.Size = new System.Drawing.Size(79, 20);
            this.lblfullname.TabIndex = 18;
            this.lblfullname.Text = "Full Name";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.Color.White;
            this.lbluser.Location = new System.Drawing.Point(69, 337);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(89, 20);
            this.lbluser.TabIndex = 4;
            this.lbluser.Text = "User Name";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = global::FoodWasteMS.Properties.Resources.Logout_Rounded_Up_30px;
            this.btnLogOut.Location = new System.Drawing.Point(0, 723);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(384, 70);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "           Log Out";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.button10_Click);
            this.btnLogOut.MouseHover += new System.EventHandler(this.btnLogOut_MouseHover);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(50, 340);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(11, 16);
            this.label21.TabIndex = 2;
            this.label21.Text = ":";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(34, 305);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 20);
            this.label20.TabIndex = 1;
            this.label20.Text = "User Name";
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
            // top
            // 
            this.top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.top.Controls.Add(this.button11);
            this.top.Location = new System.Drawing.Point(2, -3);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(1463, 24);
            this.top.TabIndex = 14;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Wide Latin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(1420, -6);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(40, 34);
            this.button11.TabIndex = 29;
            this.button11.Text = "-";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.left;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.top;
            this.bunifuDragControl3.Vertical = true;
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltype.ForeColor = System.Drawing.Color.Black;
            this.lbltype.Location = new System.Drawing.Point(917, 35);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(53, 22);
            this.lbltype.TabIndex = 25;
            this.lbltype.Text = "type";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.lblDate.Location = new System.Drawing.Point(542, 85);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(61, 25);
            this.lblDate.TabIndex = 26;
            this.lblDate.Text = "Date";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.lbltime.Location = new System.Drawing.Point(1049, 85);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(67, 25);
            this.lbltime.TabIndex = 27;
            this.lbltime.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FoodWasteMS.Properties.Resources.Clock_48px;
            this.pictureBox2.Location = new System.Drawing.Point(1100, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FoodWasteMS.Properties.Resources.Calendar_12_48px;
            this.pictureBox1.Location = new System.Drawing.Point(662, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // btnAssignForCust
            // 
            this.btnAssignForCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnAssignForCust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignForCust.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAssignForCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignForCust.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAssignForCust.ForeColor = System.Drawing.Color.White;
            this.btnAssignForCust.Image = global::FoodWasteMS.Properties.Resources.In_Transit_27px;
            this.btnAssignForCust.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssignForCust.Location = new System.Drawing.Point(712, 694);
            this.btnAssignForCust.Name = "btnAssignForCust";
            this.btnAssignForCust.Size = new System.Drawing.Size(770, 68);
            this.btnAssignForCust.TabIndex = 24;
            this.btnAssignForCust.Text = "Assign Delivery Boy For Customer";
            this.btnAssignForCust.UseVisualStyleBackColor = false;
            this.btnAssignForCust.Click += new System.EventHandler(this.btnAssignForCust_Click);
            // 
            // btnViewCategory
            // 
            this.btnViewCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnViewCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCategory.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnViewCategory.ForeColor = System.Drawing.Color.White;
            this.btnViewCategory.Image = global::FoodWasteMS.Properties.Resources.Delivery_27px;
            this.btnViewCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewCategory.Location = new System.Drawing.Point(526, 398);
            this.btnViewCategory.Name = "btnViewCategory";
            this.btnViewCategory.Size = new System.Drawing.Size(770, 68);
            this.btnViewCategory.TabIndex = 23;
            this.btnViewCategory.Text = "View Category";
            this.btnViewCategory.UseVisualStyleBackColor = false;
            this.btnViewCategory.Click += new System.EventHandler(this.btnViewCategory_Click);
            // 
            // btnViewCustOrdr
            // 
            this.btnViewCustOrdr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnViewCustOrdr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewCustOrdr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewCustOrdr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCustOrdr.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnViewCustOrdr.ForeColor = System.Drawing.Color.White;
            this.btnViewCustOrdr.Image = global::FoodWasteMS.Properties.Resources.cart;
            this.btnViewCustOrdr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewCustOrdr.Location = new System.Drawing.Point(618, 546);
            this.btnViewCustOrdr.Name = "btnViewCustOrdr";
            this.btnViewCustOrdr.Size = new System.Drawing.Size(770, 68);
            this.btnViewCustOrdr.TabIndex = 22;
            this.btnViewCustOrdr.Text = "View Customer Order";
            this.btnViewCustOrdr.UseVisualStyleBackColor = false;
            this.btnViewCustOrdr.Click += new System.EventHandler(this.btnViewCustOrdr_Click);
            // 
            // btnViewReplaceREQ
            // 
            this.btnViewReplaceREQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnViewReplaceREQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewReplaceREQ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewReplaceREQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewReplaceREQ.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnViewReplaceREQ.ForeColor = System.Drawing.Color.White;
            this.btnViewReplaceREQ.Image = global::FoodWasteMS.Properties.Resources.repp;
            this.btnViewReplaceREQ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewReplaceREQ.Location = new System.Drawing.Point(572, 472);
            this.btnViewReplaceREQ.Name = "btnViewReplaceREQ";
            this.btnViewReplaceREQ.Size = new System.Drawing.Size(770, 68);
            this.btnViewReplaceREQ.TabIndex = 21;
            this.btnViewReplaceREQ.Text = "View Replace Order Request";
            this.btnViewReplaceREQ.UseVisualStyleBackColor = false;
            this.btnViewReplaceREQ.Click += new System.EventHandler(this.btnViewReplaceREQ_Click);
            // 
            // btnAssignforShopkeeper
            // 
            this.btnAssignforShopkeeper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnAssignforShopkeeper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignforShopkeeper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAssignforShopkeeper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignforShopkeeper.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAssignforShopkeeper.ForeColor = System.Drawing.Color.White;
            this.btnAssignforShopkeeper.Image = global::FoodWasteMS.Properties.Resources.deliv;
            this.btnAssignforShopkeeper.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssignforShopkeeper.Location = new System.Drawing.Point(662, 620);
            this.btnAssignforShopkeeper.Name = "btnAssignforShopkeeper";
            this.btnAssignforShopkeeper.Size = new System.Drawing.Size(770, 68);
            this.btnAssignforShopkeeper.TabIndex = 20;
            this.btnAssignforShopkeeper.Text = "Assign Delivery Boy For shopkeeper";
            this.btnAssignforShopkeeper.UseVisualStyleBackColor = false;
            this.btnAssignforShopkeeper.Click += new System.EventHandler(this.btnAssignforShopkeeper_Click);
            // 
            // btnupDate
            // 
            this.btnupDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnupDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnupDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupDate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnupDate.ForeColor = System.Drawing.Color.White;
            this.btnupDate.Image = global::FoodWasteMS.Properties.Resources.rep;
            this.btnupDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupDate.Location = new System.Drawing.Point(480, 324);
            this.btnupDate.Name = "btnupDate";
            this.btnupDate.Size = new System.Drawing.Size(770, 68);
            this.btnupDate.TabIndex = 19;
            this.btnupDate.Text = "Update product";
            this.btnupDate.UseVisualStyleBackColor = false;
            this.btnupDate.Click += new System.EventHandler(this.btnupDate_Click);
            // 
            // btnRemvpr
            // 
            this.btnRemvpr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnRemvpr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemvpr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemvpr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemvpr.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRemvpr.ForeColor = System.Drawing.Color.White;
            this.btnRemvpr.Image = global::FoodWasteMS.Properties.Resources.Remve_27_white;
            this.btnRemvpr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemvpr.Location = new System.Drawing.Point(432, 250);
            this.btnRemvpr.Name = "btnRemvpr";
            this.btnRemvpr.Size = new System.Drawing.Size(770, 68);
            this.btnRemvpr.TabIndex = 18;
            this.btnRemvpr.Text = "Remove product";
            this.btnRemvpr.UseVisualStyleBackColor = false;
            this.btnRemvpr.Click += new System.EventHandler(this.btnRemvpr_Click);
            // 
            // btnAddpro
            // 
            this.btnAddpro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnAddpro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddpro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddpro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddpro.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAddpro.ForeColor = System.Drawing.Color.White;
            this.btnAddpro.Image = ((System.Drawing.Image)(resources.GetObject("btnAddpro.Image")));
            this.btnAddpro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddpro.Location = new System.Drawing.Point(382, 180);
            this.btnAddpro.Name = "btnAddpro";
            this.btnAddpro.Size = new System.Drawing.Size(770, 68);
            this.btnAddpro.TabIndex = 17;
            this.btnAddpro.Text = "Add product";
            this.btnAddpro.UseVisualStyleBackColor = false;
            this.btnAddpro.Click += new System.EventHandler(this.btnAddpro_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.White;
            this.SidePanel.Location = new System.Drawing.Point(364, 571);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(16, 70);
            this.SidePanel.TabIndex = 34;
            // 
            // MenuManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1494, 820);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.btnAssignForCust);
            this.Controls.Add(this.btnViewCategory);
            this.Controls.Add(this.btnViewCustOrdr);
            this.Controls.Add(this.btnViewReplaceREQ);
            this.Controls.Add(this.btnAssignforShopkeeper);
            this.Controls.Add(this.btnupDate);
            this.Controls.Add(this.btnRemvpr);
            this.Controls.Add(this.btnAddpro);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.left);
            this.Controls.Add(this.top);
            this.Controls.Add(this.back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menumgr";
            this.Load += new System.EventHandler(this.MenuManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.left.ResumeLayout(false);
            this.left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel left;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Panel top;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Button btnViewCustOrdr;
        private System.Windows.Forms.Button btnViewReplaceREQ;
        private System.Windows.Forms.Button btnAssignforShopkeeper;
        private System.Windows.Forms.Button btnupDate;
        private System.Windows.Forms.Button btnRemvpr;
        private System.Windows.Forms.Button btnAddpro;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private System.Windows.Forms.Button btnViewCategory;
        private System.Windows.Forms.Button btnAssignForCust;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblfullname;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btndiscount;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Panel SidePanel;
    }
}