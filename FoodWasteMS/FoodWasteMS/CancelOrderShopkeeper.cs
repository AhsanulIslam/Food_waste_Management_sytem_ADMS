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

namespace FoodWasteMS
{
    public partial class CancelOrderShopkeeper : Form
    {
        string constr = "DATA SOURCE=DESKTOP-K8R8LDS:1521/XE;USER ID=SYSTEM;password=123";

        MenuShopkeepers m { get; set; }
        public CancelOrderShopkeeper(string id,MenuShopkeepers M)
        {
            InitializeComponent();
            this.m = M;
            this.lblidShopkeeper.Text = id;
            loadGridview();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        void refresh()
        {
            txtProName.Clear();
            txtboxProId.Clear();
            txtrepId.Clear();
            txtQuantity.Clear();
           
        }
        void loadGridview()
        {
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            string s = "select * from replace_order where SHPKPER_ID  = '" + this.lblidShopkeeper.Text + "'";
            OracleDataAdapter oda = new OracleDataAdapter(s, con);
            DataTable dt = new DataTable();

            this.dgvCancelOrder.AutoGenerateColumns = false;
            oda.Fill(dt);
            dgvCancelOrder.DataSource = dt;
            count();
           
            con.Close();
        }
        void searchData(string value)
        {
            string sql = "select * from replace_order where SHPKPER_ID ='" + this.lblidShopkeeper.Text + "' and product_name like '%" + value + "%'";
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            OracleDataAdapter oda = new OracleDataAdapter(sql, con);
            DataTable dt = new DataTable();

            // this.dgvChooseCake.AutoGenerateColumns = false;
            oda.Fill(dt);
            dgvCancelOrder.DataSource = dt;
            con.Close();
        }
        private void txtAutoChnager_TextChanged(object sender, EventArgs e)
        {
            searchData(txtAutoChnager.Text);
        }

        private void dgvCancelOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtboxProId.Text = this.dgvCancelOrder.CurrentRow.Cells["product_id"].Value.ToString();
            this.txtProName.Text = this.dgvCancelOrder.CurrentRow.Cells["product_name"].Value.ToString();
            this.txtrepId.Text = this.dgvCancelOrder.CurrentRow.Cells["REPLACE_ID"].Value.ToString();
            this.txtQuantity.Text = this.dgvCancelOrder.CurrentRow.Cells["quantity"].Value.ToString();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            rem();

            OracleConnection con = new OracleConnection(constr);
            con.Open();

            string que = "insert into shop_log_cancel_order (slogdate , productid ,product_name , quant  ,log_type ) values (  sysdate,'" + txtboxProId.Text + "','" + txtProName.Text + "','" + txtQuantity.Text + "','" + lblCancel.Text + "')"; //

            OracleCommand oc = new OracleCommand(que, con);
            oc.ExecuteNonQuery();
            refresh();
            loadGridview();
        }
        void rem ()
        {


            string id = this.txtboxProId.Text.ToString();
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            string i = txtQuantity.Text.ToString();
            int numVal = Int32.Parse(i);
            if (numVal > 0)

            {
                string qry = "update product_inventory set quantity = (quantity + '" + Int32.Parse(txtQuantity.Text.ToString()) + "') where product_id='" + id + "'";

                OracleDataAdapter oda = new OracleDataAdapter(qry, con);

                OracleCommand cmd1 = new OracleCommand(qry, con);
                cmd1.ExecuteNonQuery();
            }

                
            string rproid = this.txtrepId.Text.ToString();
            string query = "delete from replace_order where REPLACE_ID = '" + rproid + "'";


            OracleCommand cmd = new OracleCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cancellation Done.","Done");
            loadGridview();

            con.Close();
        }

        private void CancelOrderShopkeeper_Load(object sender, EventArgs e)
        {
            dgvCancelOrder.BorderStyle = BorderStyle.None;
            dgvCancelOrder.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvCancelOrder.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCancelOrder.DefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 25, 72);
            dgvCancelOrder.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvCancelOrder.BackgroundColor = Color.White;

            dgvCancelOrder.EnableHeadersVisualStyles = false;
            dgvCancelOrder.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCancelOrder.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            dgvCancelOrder.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }


        void count()
        {
            //string query = "select count(product_id) from product_inventory ";
            int sum = 0;
            for (int i = 0; i < dgvCancelOrder.Rows.Count; i++)
            {
                sum++;
            }
            // int n = dgvProduct.Rows.Add();

            lblCount.Text = sum.ToString();

        }

    }
}
