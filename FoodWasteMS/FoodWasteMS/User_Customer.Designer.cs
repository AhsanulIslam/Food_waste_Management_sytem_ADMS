namespace FoodWasteMS
{
    partial class User_Customer
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
            this.components = new System.ComponentModel.Container();
            this.dgvCust = new System.Windows.Forms.DataGridView();
            this.cor_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cor_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cor_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.log_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCust)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCust
            // 
            this.dgvCust.AllowUserToAddRows = false;
            this.dgvCust.AllowUserToDeleteRows = false;
            this.dgvCust.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCust.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cor_id,
            this.cor_date,
            this.cor_time,
            this.order_id,
            this.log_type});
            this.dgvCust.Location = new System.Drawing.Point(0, 0);
            this.dgvCust.Name = "dgvCust";
            this.dgvCust.ReadOnly = true;
            this.dgvCust.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCust.Size = new System.Drawing.Size(1092, 622);
            this.dgvCust.TabIndex = 0;
            // 
            // cor_id
            // 
            this.cor_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cor_id.DataPropertyName = "cor_id";
            this.cor_id.HeaderText = "Log Id";
            this.cor_id.Name = "cor_id";
            this.cor_id.ReadOnly = true;
            // 
            // cor_date
            // 
            this.cor_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cor_date.DataPropertyName = "cor_date";
            this.cor_date.HeaderText = "Customer Order Date";
            this.cor_date.Name = "cor_date";
            this.cor_date.ReadOnly = true;
            // 
            // cor_time
            // 
            this.cor_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cor_time.DataPropertyName = "cor_time";
            this.cor_time.HeaderText = "Customer Order Time";
            this.cor_time.Name = "cor_time";
            this.cor_time.ReadOnly = true;
            // 
            // order_id
            // 
            this.order_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.order_id.DataPropertyName = "order_id";
            this.order_id.HeaderText = "Order Id";
            this.order_id.Name = "order_id";
            this.order_id.ReadOnly = true;
            // 
            // log_type
            // 
            this.log_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.log_type.DataPropertyName = "log_type";
            this.log_type.HeaderText = "Log Type";
            this.log_type.Name = "log_type";
            this.log_type.ReadOnly = true;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.dgvCust;
            this.bunifuDragControl1.Vertical = true;
            // 
            // User_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCust);
            this.Name = "User_Customer";
            this.Size = new System.Drawing.Size(1093, 625);
            this.Load += new System.EventHandler(this.User_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCust)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCust;
        private System.Windows.Forms.DataGridViewTextBoxColumn cor_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cor_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn cor_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn log_type;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}
