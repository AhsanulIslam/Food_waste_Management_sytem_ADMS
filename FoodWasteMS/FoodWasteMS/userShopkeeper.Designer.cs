namespace FoodWasteMS
{
    partial class userShopkeeper
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvShop = new System.Windows.Forms.DataGridView();
            this.slogdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.log_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShop)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShop
            // 
            this.dgvShop.AllowUserToAddRows = false;
            this.dgvShop.AllowUserToDeleteRows = false;
            this.dgvShop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.slogdate,
            this.productid,
            this.product_name,
            this.quant,
            this.log_type});
            this.dgvShop.Location = new System.Drawing.Point(0, 0);
            this.dgvShop.Name = "dgvShop";
            this.dgvShop.ReadOnly = true;
            this.dgvShop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShop.Size = new System.Drawing.Size(1093, 622);
            this.dgvShop.TabIndex = 0;
            // 
            // slogdate
            // 
            this.slogdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.slogdate.DataPropertyName = "slogdate";
            this.slogdate.HeaderText = "Date";
            this.slogdate.Name = "slogdate";
            this.slogdate.ReadOnly = true;
            // 
            // productid
            // 
            this.productid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productid.DataPropertyName = "productid";
            this.productid.HeaderText = "Product Id";
            this.productid.Name = "productid";
            this.productid.ReadOnly = true;
            // 
            // product_name
            // 
            this.product_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.product_name.DataPropertyName = "product_name";
            this.product_name.HeaderText = "Product Name";
            this.product_name.Name = "product_name";
            this.product_name.ReadOnly = true;
            // 
            // quant
            // 
            this.quant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quant.DataPropertyName = "quant";
            this.quant.HeaderText = "Quantity";
            this.quant.Name = "quant";
            this.quant.ReadOnly = true;
            // 
            // log_type
            // 
            this.log_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.log_type.DataPropertyName = "log_type";
            this.log_type.HeaderText = "Log Type";
            this.log_type.Name = "log_type";
            this.log_type.ReadOnly = true;
            // 
            // userShopkeeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvShop);
            this.Name = "userShopkeeper";
            this.Size = new System.Drawing.Size(1093, 625);
            this.Load += new System.EventHandler(this.userShopkeeper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShop;
        private System.Windows.Forms.DataGridViewTextBoxColumn slogdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn productid;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quant;
        private System.Windows.Forms.DataGridViewTextBoxColumn log_type;
    }
}
