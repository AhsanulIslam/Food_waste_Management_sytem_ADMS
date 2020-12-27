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
    public partial class AssiginDeliveryCUSTOMER : Form
    {
        string constr = "DATA SOURCE=DESKTOP-K8R8LDS:1521/XE;USER ID=SYSTEM;password=123";

        public AssiginDeliveryCUSTOMER()
        {
            InitializeComponent();
            loadGridview();
            fillcombo();
            loadGridview2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        void loadGridview2()
        {
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            OracleDataAdapter oda = new OracleDataAdapter("select * from TotalPrice", con);
            DataTable dt = new DataTable();


            this.dgvPrice.AutoGenerateColumns = false;
            oda.Fill(dt);

            dgvPrice.DataSource = dt;
        }
            void loadGridview()
        {
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            OracleDataAdapter oda = new OracleDataAdapter("select * from ordertab ", con);
            DataTable dt = new DataTable();
            

            this.dgvCustAssign.AutoGenerateColumns = false;
            oda.Fill(dt);

            dgvCustAssign.DataSource = dt;
          //  dgvCustAssign.Rows


         /*   foreach(DataRow item in dt.Rows)
            {
                int n = dgvCustAssign.Rows.Add();
                dgvCustAssign.Rows[n].Cells[0].Value ="false";
                dgvCustAssign.Rows[n].Cells[1].Value = item["ORDER_ID"].ToString();
                dgvCustAssign.Rows[n].Cells[2].Value = item["CUST_ID"].ToString();
                dgvCustAssign.Rows[n].Cells[3].Value = item["CUST_NAME"].ToString();
                dgvCustAssign.Rows[n].Cells[4].Value = item["PRO_ID"].ToString();
                dgvCustAssign.Rows[n].Cells[5].Value = item["PRODUCT_NAME"].ToString();
                dgvCustAssign.Rows[n].Cells[6].Value = item["QUANTITY"].ToString();
                dgvCustAssign.Rows[n].Cells[7].Value = item["PRICEPER"].ToString();
                dgvCustAssign.Rows[n].Cells[8].Value = item["TOTAL_PRICE"].ToString();
                dgvCustAssign.Rows[n].Cells[9].Value = item["CUST_LOC"].ToString();
                dgvCustAssign.Rows[n].Cells[10].Value = item["CUST_PHONE"].ToString();
                dgvCustAssign.Rows[n].Cells[11].Value = item["EXPIRE_DATE"].ToString();
                dgvCustAssign.Rows[n].Cells[12].Value = item["ORDER_DATE"].ToString();
                dgvCustAssign.Rows[n].Cells[13].Value = item["FINAL_TOTALPRICE"].ToString();
            }*/
            count();
            con.Close();
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
        void sentnotice()
        {
            OracleConnection con = new OracleConnection(constr);
            con.Open();

           try
            {
                foreach (DataGridViewRow datarow in dgvCustAssign.Rows)
                {
                    if (datarow.Cells[0].Value!=null && bool.Parse(datarow.Cells[0].Value.ToString()))
                    {
                        string query = "insert into NoticeDelBoy (notice_id,DATETODELIVERY,SHPKPERCUST_NAME ,SHPKPERCUST_PRODUCT_NAME,SHPKPERCUST_PRODUCT_QUANTITY,SHPKPERCUST_PRODUCT_PRICE,SHPKPERCUST_PHONE,SHPKPERCUST_LOC,delboy_id,PRODUCT_ID,SHPKPER_ID,Total_price) values (notice_seq.NEXTVAL, TO_DATE('" + this.dtpExpDate.Text + "','yyyy-MM-dd'),'" + datarow.Cells[3].Value.ToString() + "','" + datarow.Cells[5].Value.ToString() + "','" + datarow.Cells[6].Value.ToString() + "','" + datarow.Cells[7].Value.ToString() + "','" + datarow.Cells[10].Value.ToString() + "','" + datarow.Cells[9].Value.ToString() + "','" + cmbDeliBOYId.Text + "','" + datarow.Cells[4].Value.ToString() + "','" + datarow.Cells[2].Value.ToString() + "','" + datarow.Cells[8].Value.ToString() + "')";

                        //string query = "insert into NoticeDelBoy (notice_id,DATETODELIVERY,SHPKPERCUST_NAME ,SHPKPERCUST_PRODUCT_NAME,SHPKPERCUST_PRODUCT_QUANTITY,SHPKPERCUST_PRODUCT_PRICE,SHPKPERCUST_PHONE,SHPKPERCUST_LOC,delboy_id,PRODUCT_ID,SHPKPER_ID) values (notice_seq.NEXTVAL, TO_DATE('" + this.dtpExpDate.Text + "','yyyy-MM-dd'),'" + txtShpName.Text + "','" + txtProname.Text + "','" + txtboxQuantity.Text + "','" + txtBoXPrice.Text + "','" + txtphone.Text + "','" + txtboXloCation.Text + "','" + cmbDeliBOYId.Text + "','" + txtBoxProId.Text + "','" + txtBoxSHpID.Text + "')";
                        OracleCommand cmd = new OracleCommand(query, con);
                        cmd.ExecuteNonQuery();

                        string query1 = "delete from ordertab where ORDER_ID = '" + datarow.Cells[1].Value.ToString() + "'";
                        OracleCommand cmd1 = new OracleCommand(query1, con);
                        cmd1.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Notice Sent to Delivery Boy", "Successful");
               
            }
           catch(Exception ex)
            {
               // Console.WriteLine(ex);
               MessageBox.Show(ex.ToString());
            }
            con.Close();
            refresh();
        }
        void refresh()
        {
            txtBoxProId.Clear();
            txtboxQuantity.Clear();
            cmbDeliBOYId.Text = "";
            txtboXloCation.Text = "";
            txtBoxCustID.Text = "";
        }

        private void btnSentNotice_Click(object sender, EventArgs e)
        {
            sentnotice();
            loadGridview();
        }

        private void dgvCustAssign_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtOrderID.Text = this.dgvCustAssign.CurrentRow.Cells["ORDER_ID"].Value.ToString();
            this.txtBoxCustID.Text = this.dgvCustAssign.CurrentRow.Cells["CUST_ID"].Value.ToString();
            this.txtCustName.Text = this.dgvCustAssign.CurrentRow.Cells["CUST_NAME"].Value.ToString();
            this.txtProname.Text = this.dgvCustAssign.CurrentRow.Cells["PRODUCT_NAME"].Value.ToString();
            this.txtTotal.Text = this.dgvCustAssign.CurrentRow.Cells["TOTAL_PRICE"].Value.ToString();
            this.txtBoXPrice.Text = this.dgvCustAssign.CurrentRow.Cells["PRICEPER"].Value.ToString();
            this.txtboXloCation.Text = this.dgvCustAssign.CurrentRow.Cells["CUST_LOC"].Value.ToString();
            this.txtphone.Text = this.dgvCustAssign.CurrentRow.Cells["CUST_PHONE"].Value.ToString();
            this.txtboxQuantity.Text = this.dgvCustAssign.CurrentRow.Cells["Quantity"].Value.ToString();
           // this.txtexpdate.Text = this.dgvCustAssign.CurrentRow.Cells["EXPIRE_DATE"].Value.ToString();
          //  this.txtOrderID.Text = this.dgvCustAssign.CurrentRow.Cells["ORDER_DATE"].Value.ToString();
            this.txtTOtalFOFUllorder.Text = this.dgvCustAssign.CurrentRow.Cells["FINAL_TOTALPRICE"].Value.ToString();

        }

        private void AssiginDeliveryCUSTOMER_Load(object sender, EventArgs e)
        {
            dgvCustAssign.BorderStyle = BorderStyle.None;
            dgvCustAssign.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvCustAssign.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCustAssign.DefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 25, 72);
            dgvCustAssign.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvCustAssign.BackgroundColor = Color.White;

            dgvCustAssign.EnableHeadersVisualStyles = false;
            dgvCustAssign.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCustAssign.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            dgvCustAssign.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;




            dgvPrice.BorderStyle = BorderStyle.None;
            dgvPrice.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvPrice.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPrice.DefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 25, 72);
            dgvPrice.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvPrice.BackgroundColor = Color.White;

            dgvPrice.EnableHeadersVisualStyles = false;
            dgvPrice.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPrice.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            dgvPrice.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
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

            this.dgvCustAssign.AutoGenerateColumns = false;
            oda.Fill(dt);
            dgvCustAssign.DataSource = dt;
            con.Close();
        }

        void count()
        {
            //string query = "select count(product_id) from product_inventory ";
            int sum = 0;
            for (int i = 0; i < dgvCustAssign.Rows.Count; i++)
            {
                sum++;
            }

            
            // int n = dgvProduct.Rows.Add();

            lblCount.Text = sum.ToString();

        }
    }
}
