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
    public partial class ReplaceOrderRequest : Form
    {
        string constr = "DATA SOURCE=DESKTOP-Q3KCJHO:1521/XE;USER ID=SYSTEM;password=123";

        MenuManager m { get; set; }
        public ReplaceOrderRequest(string username,MenuManager mm)
        {
            InitializeComponent();
            this.lblUser.Text = username;
            loadGridview();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
            Login l = new Login();
            l.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        void loadGridview()
        {
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            OracleDataAdapter oda = new OracleDataAdapter("select * from replace_order", con);
            DataTable dt = new DataTable();

            this.dgvShopkeeperOrderList.AutoGenerateColumns = false;
            oda.Fill(dt);
            dgvShopkeeperOrderList.DataSource = dt;

            count();
            con.Close();
        }

        private void ReplaceOrderRequest_Load(object sender, EventArgs e)
        {

            dgvShopkeeperOrderList.BorderStyle = BorderStyle.None;
            dgvShopkeeperOrderList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvShopkeeperOrderList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvShopkeeperOrderList.DefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 25, 72);
            dgvShopkeeperOrderList.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvShopkeeperOrderList.BackgroundColor = Color.White;

            dgvShopkeeperOrderList.EnableHeadersVisualStyles = false;
            dgvShopkeeperOrderList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvShopkeeperOrderList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            dgvShopkeeperOrderList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        void count()
        {
            //string query = "select count(product_id) from product_inventory ";
            int sum = 0;
            for (int i = 0; i < dgvShopkeeperOrderList.Rows.Count; i++)
            {
                sum++;
            }
            // int n = dgvProduct.Rows.Add();

            lblCount.Text = sum.ToString();

        }

        private void txtAutoChnager_TextChanged(object sender, EventArgs e)
        {
            searchData(txtAutoChnager.Text);
        }
        void searchData(string value)
        {
            string sql = "select * from ordertab where product_name like '%" + value + "%'";
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            OracleDataAdapter oda = new OracleDataAdapter(sql, con);
            DataTable dt = new DataTable();

            this.dgvShopkeeperOrderList.AutoGenerateColumns = false;
            oda.Fill(dt);
            dgvShopkeeperOrderList.DataSource = dt;
            con.Close();
        }
    }
}
