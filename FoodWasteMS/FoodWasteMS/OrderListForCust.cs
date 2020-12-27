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
    public partial class OrderListForCust : Form
    {

        string constr = "DATA SOURCE=DESKTOP-K8R8LDS:1521/XE;USER ID=SYSTEM;password=123";
        private MenuCustomer F1 { get; set; }

        public OrderListForCust(string username, MenuCustomer f1)
        {
            InitializeComponent();
           
            this.lbluser.Text = username;
            //this.lbltype.Text = type;
            this.F1 = f1;

            OracleConnection con = new OracleConnection(constr);

            con.Open();
            string q1 = "select * from customer where cust_uname ='" + username + "'";
            OracleCommand oc = new OracleCommand(q1, con);
            OracleDataReader odr = oc.ExecuteReader();
            if (odr.Read())
            {
                lblfullname.Text = (odr["cust_fname"].ToString());
                lblid.Text = (odr["cust_id"].ToString());
                lblphone.Text = (odr["cust_phone"].ToString());
                lbladdress.Text = (odr["cust_address"].ToString());
            }
            con.Close();
            loadGridview();
        }

        void loadGridview()
        {
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            OracleDataAdapter oda = new OracleDataAdapter("select * from Cust_ORDER_History where CUST_ID ='" + lblid.Text + "'", con);
            DataTable dt = new DataTable();

            this.dgvHistory.AutoGenerateColumns = false;
            oda.Fill(dt);
            dgvHistory.DataSource = dt;
            count();

            con.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void OrderListForCust_Load(object sender, EventArgs e)
        {

            dgvHistory.BorderStyle = BorderStyle.None;
            dgvHistory.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvHistory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHistory.DefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 25, 72);
            dgvHistory.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvHistory.BackgroundColor = Color.White;

            dgvHistory.EnableHeadersVisualStyles = false;
            dgvHistory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            dgvHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        void count()
        {
            //string query = "select count(product_id) from product_inventory ";
            int sum = 0;
            for (int i = 0; i < dgvHistory.Rows.Count; i++)
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
            string sql = "select * from Cust_ORDER_History where product_name like '%" + value + "%'";
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            OracleDataAdapter oda = new OracleDataAdapter(sql, con);
            DataTable dt = new DataTable();

            this.dgvHistory.AutoGenerateColumns = false;
            oda.Fill(dt);
            dgvHistory.DataSource = dt;
            con.Close();
        }
    }
}
