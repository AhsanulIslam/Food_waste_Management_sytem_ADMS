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
    public partial class AssignDeliverytoSHOPkeeper : Form
    {
        string constr = "DATA SOURCE=DESKTOP-K8R8LDS:1521/XE;USER ID=SYSTEM;password=123";

        public AssignDeliverytoSHOPkeeper()
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

        void loadGridview()
        {
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            OracleDataAdapter oda = new OracleDataAdapter("select * from replace_order", con);
            DataTable dt = new DataTable();

            this.dgvReplaceOrderList.AutoGenerateColumns = false;
            oda.Fill(dt);
            dgvReplaceOrderList.DataSource = dt;
            count();
            con.Close();
        }

        private void dgvReplaceOrderList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtBoxProId.Text = this.dgvReplaceOrderList.CurrentRow.Cells["product_id"].Value.ToString();
            this.txtShpName.Text = this.dgvReplaceOrderList.CurrentRow.Cells["shpkper_name"].Value.ToString();
           this.txtProname.Text = this.dgvReplaceOrderList.CurrentRow.Cells["PRODUCT_NAME"].Value.ToString();
            this.txtboxQuantity.Text = this.dgvReplaceOrderList.CurrentRow.Cells["quantity"].Value.ToString();
            this.txtBoxSHpID.Text = this.dgvReplaceOrderList.CurrentRow.Cells["shpkper_id"].Value.ToString();
            this.txtboXloCation.Text = this.dgvReplaceOrderList.CurrentRow.Cells["SHOPKEEPER_LOCATION"].Value.ToString();
            this.txtphone.Text = this.dgvReplaceOrderList.CurrentRow.Cells["shpkper_phone"].Value.ToString();
            this.txtReplaceID.Text = this.dgvReplaceOrderList.CurrentRow.Cells["REPLACE_ID"].Value.ToString();
        }

        void fillcombo()
        {
            OracleConnection con = new OracleConnection(constr);
            string query = "select delboy_id from deliveryboy";
            OracleCommand cmd = new OracleCommand(query, con);

            OracleDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    string id = Convert.ToString(myreader["delboy_id"]);
                   cmbDeliBOYId.Items.Add(id);
                  
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            con.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // sentnotice();
            PkgNotice();
            del();


          /*  string query1 = "delete from REPLACE_ORDER where REPLACE_ID = '" + txtReplaceID.Text + "'";
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            OracleCommand cmd = new OracleCommand(query1, con);
            cmd.ExecuteNonQuery();*/
            loadGridview();
           // con.Close();
            refresh();
        }
        void del()
        {
            OracleConnection con = new OracleConnection(constr);
            OracleCommand cmd = new OracleCommand("pkgAssignForShopk.deleteReplace", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.Add("Rep_ID", OracleDbType.Int32).Value = txtReplaceID.Text;
            cmd.ExecuteNonQuery();
        }
        void PkgNotice()
        {

            OracleConnection con = new OracleConnection(constr);
            OracleCommand cmd = new OracleCommand("pkgAssignForShopk.insertNotice", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
           
            cmd.Parameters.Add("TO_DATE(dat, 'yyyy-MM-dd')", OracleDbType.Date).Value = Convert.ToDateTime(dtpExpDate.Text); // Convert.ToDateTime(dtpExpDate.Text );
            cmd.Parameters.Add("snam", OracleDbType.Varchar2, 50).Value = txtShpName.Text;
            cmd.Parameters.Add("pnam", OracleDbType.Varchar2, 50).Value = txtProname.Text;
            cmd.Parameters.Add("qua", OracleDbType.Varchar2, 50).Value = txtboxQuantity.Text;
            cmd.Parameters.Add("prc", OracleDbType.Varchar2, 50).Value = txtBoXPrice.Text;
            cmd.Parameters.Add("phn", OracleDbType.Varchar2, 50).Value = txtphone.Text;
            cmd.Parameters.Add("loc", OracleDbType.Varchar2, 50).Value = txtboXloCation.Text;
            cmd.Parameters.Add("delid", OracleDbType.Int32).Value = cmbDeliBOYId.Text;
            cmd.Parameters.Add("pid", OracleDbType.Int32).Value = txtBoxProId.Text;
            cmd.Parameters.Add("ShkCust_id", OracleDbType.Int32).Value = txtBoxSHpID.Text;


            cmd.ExecuteNonQuery();
            MessageBox.Show("Notice Sent to Delivery Boy", "Successful");

            loadGridview();
            refresh();
            con.Close();
        }

      /*  void sentnotice()
        {
            OracleConnection con = new OracleConnection(constr);
            con.Open();
          //  string query = "insert into NoticeDelBoy (notice_id,DATETODELIVERY,SHPKPERCUST_NAME ,SHPKPERCUST_PRODUCT_NAME,SHPKPERCUST_PRODUCT_QUANTITY,SHPKPERCUST_PRODUCT_PRICED,SHPKPERCUST_PHONE,SHPKPERCUST_LOC,delboy_id,PRODUCT_ID,SHPKPER_ID) values (notice_seq.NEXTVAL, TO_DATE('" + this.dtpExpDate.Text + "','yyyy-MM-dd'),'" + txtShpName.Text + "','" + txtProname.Text + "','" + txtboxQuantity.Text + "','" + txtphone.Text + "','" + txtboXloCation.Text + "','" + cmbDeliBOYId.Text + "','" + txtBoxProId.Text +"','" + txtBoxSHpID.Text + "')";
            string query = "insert into NoticeDelBoy (notice_id,DATETODELIVERY,SHPKPERCUST_NAME ,SHPKPERCUST_PRODUCT_NAME,SHPKPERCUST_PRODUCT_QUANTITY,SHPKPERCUST_PRODUCT_PRICE,SHPKPERCUST_PHONE,SHPKPERCUST_LOC,delboy_id,PRODUCT_ID,SHPKPER_ID) values (notice_seq.NEXTVAL, TO_DATE('" + this.dtpExpDate.Text + "','yyyy-MM-dd'),'" + txtShpName.Text + "','" + txtProname.Text + "','" + txtboxQuantity.Text + "','" +txtBoXPrice.Text + "','" + txtphone.Text + "','" + txtboXloCation.Text + "','" + cmbDeliBOYId.Text + "','" + txtBoxProId.Text +"','" + txtBoxSHpID.Text + "')";
            OracleDataAdapter oda1 = new OracleDataAdapter(query, con);
            oda1.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Notice Sent to Delivery Boy", "Successful");
            loadGridview();
            con.Close();
            refresh();
        }*/
        void refresh()
        {
            txtBoxProId.Clear();
            txtboxQuantity.Clear();
            cmbDeliBOYId.Text = "";
            txtboXloCation.Text = "";
            txtBoxSHpID.Text = "";
        }

        private void AssignDeliverytoSHOPkeeper_Load(object sender, EventArgs e)
        {
            
        }

        private void AssignDeliverytoSHOPkeeper_Load_1(object sender, EventArgs e)
        {
            dgvReplaceOrderList.BorderStyle = BorderStyle.None;
            dgvReplaceOrderList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvReplaceOrderList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReplaceOrderList.DefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 25, 72);
            dgvReplaceOrderList.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvReplaceOrderList.BackgroundColor = Color.White;

            dgvReplaceOrderList.EnableHeadersVisualStyles = false;
            dgvReplaceOrderList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvReplaceOrderList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            dgvReplaceOrderList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void txtAutoChnager_TextChanged(object sender, EventArgs e)
        {
            searchData(txtAutoChnager.Text);
        }
        void searchData(string value)
        {
            string sql = "select * from replace_order where product_name like '%" + value + "%'";
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            OracleDataAdapter oda = new OracleDataAdapter(sql, con);
            DataTable dt = new DataTable();

            this.dgvReplaceOrderList.AutoGenerateColumns = false;
            oda.Fill(dt);
            dgvReplaceOrderList.DataSource = dt;
            con.Close();
        }
        void count()
        {
            //string query = "select count(product_id) from product_inventory ";
            int sum = 0;
            for (int i = 0; i < dgvReplaceOrderList.Rows.Count; i++)
            {
                sum++;
            }
            // int n = dgvProduct.Rows.Add();

            lblCount.Text = sum.ToString();

        }
    }
}
