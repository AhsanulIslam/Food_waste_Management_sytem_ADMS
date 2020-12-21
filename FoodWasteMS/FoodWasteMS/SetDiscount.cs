using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace FoodWasteMS
{
    public partial class SetDiscount : Form
    {

        string constr = "DATA SOURCE=DESKTOP-Q3KCJHO:1521/XE;USER ID=SYSTEM;password=123";

        public SetDiscount()
        {
            InitializeComponent();
            loadGridview();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtItemId.Text = this.dgvDiscount.CurrentRow.Cells["item_id"].Value.ToString();
            this.txtPrice.Text = this.dgvDiscount.CurrentRow.Cells["price"].Value.ToString();

        }

        private void button10_Click(object sender, EventArgs e)
        {
           /// OracleConnection con = new OracleConnection(constr);
           // con.Open();


            string discount = txtDiscount.Text;
            double numVal1 = Convert.ToDouble(discount);
          
            string price = txtPrice.Text; 
            double numVal2 = Convert.ToDouble(price);

           
            double afterDiscountPrice = numVal2 - (numVal2 * (numVal1 / 100));          
                                                                                         
            int current = Convert.ToInt32(afterDiscountPrice);

            //    textBox1.Text = current.ToString();

            OracleConnection con = new OracleConnection(constr);
            OracleCommand cmd = new OracleCommand("pkgDiscount.updateItem", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            //   try
            //{
            cmd.Parameters.Add("itm_ID", OracleDbType.Int32).Value = txtItemId.Text;
            cmd.Parameters.Add("Prc", OracleDbType.Int32).Value = current;


            cmd.ExecuteNonQuery();

            /*

            String qry = "update item set PRICE ='" + current + "' where item_id ='" + txtItemId.Text + "'";

            OracleCommand cmd = new OracleCommand(qry, con);
            cmd.ExecuteNonQuery();
            */
            MessageBox.Show("Discount Done.", "Successful");
            loadGridview();

            con.Close();


        }

        void loadGridview()
        {
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            OracleDataAdapter oda = new OracleDataAdapter("select * from item", con);
            DataTable dt = new DataTable();

            this.dgvDiscount.AutoGenerateColumns = false;
            oda.Fill(dt);
            dgvDiscount.DataSource = dt;
            count();
            con.Close();
        }

        void update()
        {
            OracleConnection con = new OracleConnection(constr);
            OracleCommand cmd = new OracleCommand("pkgDiscount.updateItem", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            //   try
            //{
            cmd.Parameters.Add("itm_ID", OracleDbType.Int32).Value = txtItemId.Text;
            cmd.Parameters.Add("Prc", OracleDbType.Int32).Value = txtItemId.Text;


            cmd.ExecuteNonQuery();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            string proid = this.txtItemId.Text.ToString();
            OracleCommand cmd = new OracleCommand("pkgDiscount.delete_itm", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("itm_ID", OracleDbType.Int32).Value = proid;

            cmd.ExecuteNonQuery();

            /*
            string query = "delete from item where item_id = '" + proid + "'";


            OracleCommand cmd = new OracleCommand(query, con);
            cmd.ExecuteNonQuery();*/
            MessageBox.Show("Remove Done.");
            loadGridview();

            con.Close();
        }

        private void btnSent_Click(object sender, EventArgs e)
        {

            OracleConnection con = new OracleConnection(constr);
            OracleCommand cmd = new OracleCommand("pkgDiscount.txtsent", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            cmd.Parameters.Add("ms", OracleDbType.Varchar2, 50).Value = txtboxMessage.Text;
            cmd.ExecuteNonQuery();
            /* OracleConnection con = new OracleConnection(constr);
             con.Open();

             string q = "insert into messagepass values ('"+txtboxMessage.Text+"')";

             OracleCommand c = new OracleCommand(q, con);
             c.ExecuteNonQuery();*/
            MessageBox.Show("Message Sent","Done");
            con.Close();
            txtboxMessage.Clear();
        }

        private void txtAutoChnager_TextChanged(object sender, EventArgs e)
        {

            searchData(txtAutoChnager.Text);
        }
           
private void SetDiscount_Load(object sender, EventArgs e)
        {
            dgvDiscount.BorderStyle = BorderStyle.None;
            dgvDiscount.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvDiscount.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDiscount.DefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 25, 72);
            dgvDiscount.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvDiscount.BackgroundColor = Color.White;

            dgvDiscount.EnableHeadersVisualStyles = false;
            dgvDiscount.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDiscount.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            dgvDiscount.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    

    //  private void txtAutoChnager_TextChanged(object sender, EventArgs e)
    //  {

    //   }
    void searchData(string value)
        {
            string sql = "select * from item where product_name like '%" + value + "%'";
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            OracleDataAdapter oda = new OracleDataAdapter(sql, con);
            DataTable dt = new DataTable();

            this.dgvDiscount.AutoGenerateColumns = false;
            oda.Fill(dt);
            dgvDiscount.DataSource = dt;
            con.Close();
        }

        void count()
        {
            //string query = "select count(product_id) from product_inventory ";
            int sum = 0;
            for (int i = 0; i < dgvDiscount.Rows.Count; i++)
            {
                sum++;
            }


            // int n = dgvProduct.Rows.Add();

            lblCount.Text = (sum).ToString();

        }

        private void btnSent_MouseHover(object sender, EventArgs e)
        {
            SidePanel.Height = btnSent.Height;
            SidePanel.Top = btnSent.Top;
        }

        private void btnRem_MouseHover(object sender, EventArgs e)
        {
            SidePanel.Height = btnRem.Height;
            SidePanel.Top = btnRem.Top;
        }

        private void btnDisSet_MouseHover(object sender, EventArgs e)
        {
            SidePanel.Height = btnDisSet.Height;
            SidePanel.Top = btnDisSet.Top;
        }
    }
}
