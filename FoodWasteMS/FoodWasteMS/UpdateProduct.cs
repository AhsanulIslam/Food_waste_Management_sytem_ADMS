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
    public partial class UpdateProduct : Form
    {
        string constr = "DATA SOURCE=DESKTOP-K8R8LDS:1521/XE;USER ID=SYSTEM;password=123";

        public UpdateProduct()
        {
            InitializeComponent();
            loadGridview();
            fillcombo();
        }


        void update()
        {
            OracleConnection con = new OracleConnection(constr);
            OracleCommand cmd = new OracleCommand("PRODUCTMANAGER.UPDATEPRO", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
         //   try
         //   {
                cmd.Parameters.Add("PID", OracleDbType.Int32).Value = txtboxid.Text;
                cmd.Parameters.Add("PN", OracleDbType.Varchar2, 50).Value = txtboxProName.Text;
                cmd.Parameters.Add("CAT", OracleDbType.Int32).Value = cmbCategoryId.Text;
                cmd.Parameters.Add("QNTY", OracleDbType.Int32).Value = txtboxProQuantity.Text;
                cmd.Parameters.Add("PR", OracleDbType.Int32).Value = txtboxProPrice.Text;
               cmd.Parameters.Add("TO_DATE(ED, 'yyyy-MM-dd')", OracleDbType.Date).Value = Convert.ToDateTime(dtpExpDate.Text);

            

            cmd.ExecuteNonQuery();
            MessageBox.Show("Upgradation Done.", "Successful");
            loadGridview();
            refresh();
            con.Close(); 

        }


        private void button10_Click(object sender, EventArgs e)
        {
            update();
           /* OracleConnection con = new OracleConnection(constr);
            con.Open();
            string proid = this.txtboxid.Text.ToString();
            string proname = this.txtboxProName.Text.ToString();
            string catid = this.cmbCategoryId.Text.ToString();
            string quantity = this.txtboxProQuantity.Text.ToString();
            string proprice = this.txtboxProPrice.Text.ToString();
            string expdate = this.dtpExpDate.Text;

         
            String qry = "update product_inventory set product_name ='" + proname + "', cat_id='" + catid + "', quantity='" + quantity + "', price ='" + proprice + "', expire_date = TO_DATE('" + expdate + "','yyyy-MM-dd') where product_id='" + proid + "'";

            OracleCommand cmd = new OracleCommand(qry, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Upgradation Done.","Successful");
            loadGridview();
            refresh();
            con.Close();*/

        }
        void refresh()
        {
            this.txtboxProName.Clear();
            this.txtboxProPrice.Clear();
            this.txtboxProQuantity.Clear();
            this.cmbCategoryId.Text = "";
        }


        void loadGridview()
        {
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            OracleDataAdapter oda = new OracleDataAdapter("select * from product_inventory", con);
            DataTable dt = new DataTable();

            this.dgvRemPro.AutoGenerateColumns = false;
            oda.Fill(dt);
            dgvRemPro.DataSource = dt;
            count();

            con.Close();
        }

        void fillcombo()
        {
            OracleConnection con = new OracleConnection(constr);
            string query = "select cat_id  from category";
            OracleCommand cmd = new OracleCommand(query, con);

            OracleDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    string id = Convert.ToString(myreader["cat_id"]);
                    cmbCategoryId.Items.Add(id);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            con.Close();
        }

        private void dgvRemPro_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.txtboxid.Text = this.dgvRemPro.CurrentRow.Cells["product_id"].Value.ToString();
            this.txtboxProName.Text = this.dgvRemPro.CurrentRow.Cells["product_name"].Value.ToString();
            this.cmbCategoryId.Text = this.dgvRemPro.CurrentRow.Cells["cat_id"].Value.ToString();
            this.txtboxProQuantity.Text = this.dgvRemPro.CurrentRow.Cells["quantity"].Value.ToString();

            this.txtboxProPrice.Text = this.dgvRemPro.CurrentRow.Cells["price"].Value.ToString();
            this.dtpExpDate.Text = this.dgvRemPro.CurrentRow.Cells["expire_date"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtAutoChnager_TextChanged(object sender, EventArgs e)
        {
            searchData(txtAutoChnager.Text);

        }
        void searchData(string value)
        {
            string sql = "select * from product_inventory where product_name like '%" + value + "%'";
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            OracleDataAdapter oda = new OracleDataAdapter(sql, con);
            DataTable dt = new DataTable();

            this.dgvRemPro.AutoGenerateColumns = false;
            oda.Fill(dt);
            dgvRemPro.DataSource = dt;
            con.Close();
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            dgvRemPro.BorderStyle = BorderStyle.None;
            dgvRemPro.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvRemPro.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRemPro.DefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 25, 72);
            dgvRemPro.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvRemPro.BackgroundColor = Color.White;

            dgvRemPro.EnableHeadersVisualStyles = false;
            dgvRemPro.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRemPro.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            dgvRemPro.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        void count()
        {
            //string query = "select count(product_id) from product_inventory ";
            int sum = 0;
            for (int i = 0; i < dgvRemPro.Rows.Count; i++)
            {
                sum++;
            }
            // int n = dgvProduct.Rows.Add();

            lblCount.Text = sum.ToString();

        }
    }
}
