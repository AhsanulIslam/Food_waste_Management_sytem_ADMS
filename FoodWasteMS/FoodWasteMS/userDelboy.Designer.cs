namespace FoodWasteMS
{
    partial class userDelboy
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
            this.dgvDel = new System.Windows.Forms.DataGridView();
            this.dog_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.log_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDel
            // 
            this.dgvDel.AllowUserToAddRows = false;
            this.dgvDel.AllowUserToDeleteRows = false;
            this.dgvDel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dog_date,
            this.notid,
            this.log_type});
            this.dgvDel.Location = new System.Drawing.Point(0, 0);
            this.dgvDel.Name = "dgvDel";
            this.dgvDel.ReadOnly = true;
            this.dgvDel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDel.Size = new System.Drawing.Size(1093, 622);
            this.dgvDel.TabIndex = 0;
            // 
            // dog_date
            // 
            this.dog_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dog_date.DataPropertyName = "dog_date";
            this.dog_date.HeaderText = "Date";
            this.dog_date.Name = "dog_date";
            this.dog_date.ReadOnly = true;
            // 
            // notid
            // 
            this.notid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.notid.DataPropertyName = "notid";
            this.notid.HeaderText = "Notice Id";
            this.notid.Name = "notid";
            this.notid.ReadOnly = true;
            // 
            // log_type
            // 
            this.log_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.log_type.DataPropertyName = "log_type";
            this.log_type.HeaderText = "Log Type";
            this.log_type.Name = "log_type";
            this.log_type.ReadOnly = true;
            // 
            // userDelboy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDel);
            this.Name = "userDelboy";
            this.Size = new System.Drawing.Size(1093, 622);
            this.Load += new System.EventHandler(this.userDelboy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dog_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn notid;
        private System.Windows.Forms.DataGridViewTextBoxColumn log_type;
    }
}
