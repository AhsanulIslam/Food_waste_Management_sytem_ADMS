namespace FoodWasteMS
{
    partial class userMgr
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
            this.dgvmgr = new System.Windows.Forms.DataGridView();
            this.modate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.log_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmgr)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvmgr
            // 
            this.dgvmgr.AllowUserToAddRows = false;
            this.dgvmgr.AllowUserToDeleteRows = false;
            this.dgvmgr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmgr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modate,
            this.product_name,
            this.quant,
            this.pri,
            this.log_type});
            this.dgvmgr.Location = new System.Drawing.Point(0, 0);
            this.dgvmgr.Name = "dgvmgr";
            this.dgvmgr.ReadOnly = true;
            this.dgvmgr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmgr.Size = new System.Drawing.Size(1093, 625);
            this.dgvmgr.TabIndex = 0;
            // 
            // modate
            // 
            this.modate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modate.DataPropertyName = "modate";
            this.modate.HeaderText = "Date";
            this.modate.Name = "modate";
            this.modate.ReadOnly = true;
            // 
            // product_name
            // 
            this.product_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.product_name.DataPropertyName = "product_name";
            this.product_name.HeaderText = "product Name";
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
            // pri
            // 
            this.pri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pri.DataPropertyName = "pri";
            this.pri.HeaderText = "Price";
            this.pri.Name = "pri";
            this.pri.ReadOnly = true;
            // 
            // log_type
            // 
            this.log_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.log_type.DataPropertyName = "log_type";
            this.log_type.HeaderText = "Log Type";
            this.log_type.Name = "log_type";
            this.log_type.ReadOnly = true;
            // 
            // userMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvmgr);
            this.Name = "userMgr";
            this.Size = new System.Drawing.Size(1093, 625);
            this.Load += new System.EventHandler(this.userMgr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmgr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvmgr;
        private System.Windows.Forms.DataGridViewTextBoxColumn modate;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quant;
        private System.Windows.Forms.DataGridViewTextBoxColumn pri;
        private System.Windows.Forms.DataGridViewTextBoxColumn log_type;
    }
}
