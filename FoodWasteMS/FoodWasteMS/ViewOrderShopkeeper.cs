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
    public partial class ViewOrderShopkeeper : Form
    {
        string constr = "DATA SOURCE=DESKTOP-K8R8LDS:1521/XE;USER ID=SYSTEM;password=123";
        private MenuShopkeepers s1 { get; set; }
        public ViewOrderShopkeeper(string id,string name,string loc,string p, MenuShopkeepers m)
        {
            InitializeComponent();
            this.lblid.Text = id;
            this.lblfullname.Text = name;
            this.lbladdress.Text = loc;
            this.lblphone.Text = p;
            this.s1 = m;
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
        void loadGridview()
        {
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            string s = "select * from replace_order where SHPKPER_ID  = '" + this.lblid.Text+"'";
            OracleDataAdapter oda = new OracleDataAdapter( s, con);
            DataTable dt = new DataTable();

            this.dgvView.AutoGenerateColumns = false;
            oda.Fill(dt);
            dgvView.DataSource = dt;
            count();
            con.Close();
        }
        void searchData(string value)
        {
            string sql = "select * from replace_order where SHPKPER_ID ='" + this.lblid.Text + "' and product_name like '%" + value + "%'";
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            OracleDataAdapter oda = new OracleDataAdapter(sql, con);
            DataTable dt = new DataTable();

            // this.dgvChooseCake.AutoGenerateColumns = false;
            oda.Fill(dt);
            dgvView.DataSource = dt;
            con.Close();
        }

        private void txtAutoChnager_TextChanged(object sender, EventArgs e)
        {
            searchData(txtAutoChnager.Text);
        }

        private void ViewOrderShopkeeper_Load(object sender, EventArgs e)
        {

            dgvView.BorderStyle = BorderStyle.None;
            dgvView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 25, 72);
            dgvView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvView.BackgroundColor = Color.White;

            dgvView.EnableHeadersVisualStyles = false;
            dgvView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            dgvView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        void count()
        {
            //string query = "select count(product_id) from product_inventory ";
            int sum = 0;
            for (int i = 0; i < dgvView.Rows.Count; i++)
            {
                sum++;
            }
            // int n = dgvProduct.Rows.Add();

            lblCount.Text = sum.ToString();

        }
    }
}
