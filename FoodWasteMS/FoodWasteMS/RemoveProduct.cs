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

    public partial class RemoveProduct : Form
    {
        string constr = "DATA SOURCE=DESKTOP-Q3KCJHO:1521/XE;USER ID=SYSTEM;password=123";

        public RemoveProduct()
        {
            InitializeComponent();
            loadGridview();
            fillcombo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void dgvProRem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtboxid.Text = this.dgvProRem.CurrentRow.Cells["product_id"].Value.ToString();
            this.txtboxProName.Text = this.dgvProRem.CurrentRow.Cells["product_name"].Value.ToString();
            this.cmbCategoryId.Text = this.dgvProRem.CurrentRow.Cells["cat_id"].Value.ToString();
            this.txtboxProQuantity.Text = this.dgvProRem.CurrentRow.Cells["quantity"].Value.ToString();

            this.txtboxProPrice.Text = this.dgvProRem.CurrentRow.Cells["price"].Value.ToString();
            this.dtpExpDate.Text = this.dgvProRem.CurrentRow.Cells["expire_date"].Value.ToString(); ;
        }
        void loadGridview()
        {
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            OracleDataAdapter oda = new OracleDataAdapter("select * from product_inventory", con);
            DataTable dt = new DataTable();

            this.dgvProRem.AutoGenerateColumns = false;
            oda.Fill(dt);
            dgvProRem.DataSource = dt;
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

        void refresh()
        {
            txtboxid.Clear();
            txtboxProName.Clear();
            txtboxProPrice.Clear();
            txtboxProQuantity.Clear();
            cmbCategoryId.Text = "";
        }

        void del()
        {
            OracleConnection con = new OracleConnection(constr);
            OracleCommand cmd = new OracleCommand("PRODUCTMANAGER.DELETEPRO", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            //   try
            //{
            cmd.Parameters.Add("PID", OracleDbType.Int32).Value = txtboxid.Text;


            cmd.ExecuteNonQuery();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            del();
            /* OracleConnection con = new OracleConnection(constr);
             con.Open();
             string proid = this.txtboxid.Text.ToString();
             string query = "delete from product_inventory where product_id = '" + proid + "'";


             OracleCommand cmd = new OracleCommand(query, con);
             cmd.ExecuteNonQuery();*/
            OracleConnection con = new OracleConnection(constr);
            con.Open();

            string que = "insert into log_add (modate, product_name ,quant, pri ,log_type ) values (  sysdate,'" + txtboxProName.Text + "','" + txtboxProQuantity.Text + "','" + txtboxProPrice.Text + "','" + lblRemove.Text + "')"; //

            OracleCommand oc = new OracleCommand(que, con);
            oc.ExecuteNonQuery();


            MessageBox.Show("Deletion Done.");
            loadGridview();
            refresh();


            con.Close();
        }
        void searchData(string value)
        {
            string sql = "select * from product_inventory where product_name like '%" + value + "%'";
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            OracleDataAdapter oda = new OracleDataAdapter(sql, con);
            DataTable dt = new DataTable();

            this.dgvProRem.AutoGenerateColumns = false;
            oda.Fill(dt);
            dgvProRem.DataSource = dt;
            con.Close();
        }
        private void txtAutoChnager_TextChanged(object sender, EventArgs e)
        {
            searchData(txtAutoChnager.Text);

        }

        private void RemoveProduct_Load(object sender, EventArgs e)
        {
            dgvProRem.BorderStyle = BorderStyle.None;
            dgvProRem.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvProRem.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProRem.DefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 25, 72);
            dgvProRem.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvProRem.BackgroundColor = Color.White;

            dgvProRem.EnableHeadersVisualStyles = false;
            dgvProRem.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProRem.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            dgvProRem.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        void count()
        {
            //string query = "select count(product_id) from product_inventory ";
            int sum = 0;
            for (int i = 0; i < dgvProRem.Rows.Count; i++)
            {
                sum++;
            }
            // int n = dgvProduct.Rows.Add();

            lblCount.Text = sum.ToString();

        }
    }
}
