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
    public partial class shopkeeperChooseItemCake : Form
    {
        string constr = "DATA SOURCE=DESKTOP-Q3KCJHO:1521/XE;USER ID=SYSTEM;password=123";
        private MenuShopkeepers s1 { get; set; }
       
     
        public shopkeeperChooseItemCake(string id,string name,MenuShopkeepers m)
        {
            InitializeComponent();
            loadGridview();
            fillcombo();
            this.s1 = m;
            this.lblId.Text = id;
            this.lblShopkeepername.Text = name;

        DateTime d = DateTime.Now.AddMonths(1);
            dtpHide.Value = d;

        }

        void refresh()
        {
            txtProName.Clear();
            txtboxQuantity.Clear();
            cmbLocation.Text = "";
            cmbPhone.Text = "";
        }
            private void btnreplace_Click(object sender, EventArgs e)
        {
         


            //quantity ---- inventory

            string id = this.txtboxid.Text.ToString();
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            string i = txtQuantiry.Text.ToString();
            int numVal = Int32.Parse(i);
            if (numVal > 0)

            {
                string qry = "update product_inventory set quantity = (quantity - '"+Int32.Parse(txtboxQuantity.Text.ToString())+"') where product_id='" + id + "'";

                OracleDataAdapter oda = new OracleDataAdapter(qry, con);

                OracleCommand cmd = new OracleCommand(qry, con);
                cmd.ExecuteNonQuery();

                // string query = "insert into replace_order (REPLACE_ID,EXPIRE_DATE,shpkper_id ,quantity,PRODUCT_ID,product_name,shopkeeper_Location) values ( replaceOrder_seq.NEXTVAL, TO_DATE('" + this.dtpExpDate.Text + "','yyyy-MM-dd'),'" + lblId.Text + "','" + txtboxQuantity.Text + "'," + txtboxid + "','" + txtProName.Text + "','" + cmbLocation.Text + "')";
             //   string query = "insert into replace_order (REPLACE_ID,EXPIRE_DATE ,quantity,PRODUCT_ID,product_name,shopkeeper_Location,shpkper_phone) values ( replaceOrder_seq.NEXTVAL, TO_DATE('" + this.dtpExpDate.Text + "','yyyy-MM-dd'),'" + txtboxQuantity.Text + "','"+txtboxid.Text +"','" + txtProName.Text + "','" + cmbLocation.Text +"','" + cmbPhone.Text + "')";
                

                string query = "insert into replace_order (REPLACE_ID,EXPIRE_DATE,SHPKPERORDERDATE,shpkper_id,quantity,PRODUCT_ID,product_name,shopkeeper_Location,shpkper_phone,SHPKPER_NAME) values ( replaceOrder_seq.NEXTVAL, TO_DATE('" + this.dtpExpDate.Text + "','yyyy-MM-dd'),SYSDATE,'" + lblId.Text + "','" + txtboxQuantity.Text + "','" + txtboxid.Text + "','" + txtProName.Text + "','" + cmbLocation.Text + "','" + cmbPhone.Text + "','" + lblShopkeepername.Text + "')";

                OracleDataAdapter oda1 = new OracleDataAdapter(query, con);
                oda1.SelectCommand.ExecuteNonQuery();


                //TO_CHAR(ADD_MONTHS(HIREDATE, 1), 'DD-MON-YYYY')
                //    string q1 = "insert into item (item_id ,EXPIRE_DATE,PRODUCT_ID ,QUANTITY ,PRODUCT_NAME ,PRICE ,CAT_ID) values ( item_seq.NEXTVAL, TO_CHAR(ADD_MONTHS(SYSDATE, 1),'yyyy-MM-dd'),'" + txtboxid.Text + "','" + txtboxQuantity.Text + "','" + txtProName.Text + "','" + txtboxPrice.Text + "','" + txtboxCatid.Text + "')";



                string q1 = "insert into item (item_id ,EXPIRE_DATE,PRODUCT_ID ,QUANTITY ,PRODUCT_NAME ,PRICE ,CAT_ID) values ( item_seq.NEXTVAL, TO_DATE('" + this.dtpHide.Text + "','yyyy-MM-dd'),'" + txtboxid.Text + "','" + txtboxQuantity.Text + "','" + txtProName.Text + "','" + txtboxPrice.Text + "','" + txtboxCatid.Text + "')";
                OracleDataAdapter oda2 = new OracleDataAdapter(q1, con);
                oda2.SelectCommand.ExecuteNonQuery();

                MessageBox.Show("Order is on Process.", "Successful");
                loadGridview();
                con.Close();
                refresh();
            }
            else
            {
                MessageBox.Show("Out of stock", "Try later");

            }

            // Insert orderreplac( Manager ) 6
            /*  if (numVal > 0)
              {
                  string query = "insert into replace_order (REPLACE_ID,shpkper_id ,quantity,product_name,shopkeeper_Location) values ( replaceOrder_seq.NEXTVAL,'" + lblId.Text + "','" + txtboxQuantity.Text + "','" + txtProName.Text + "','" + cmbLocation.Text + "')";
                  OracleDataAdapter oda = new OracleDataAdapter(query, con);
                  oda.SelectCommand.ExecuteNonQuery();
                  MessageBox.Show("Done", "Successful");

                  loadGridview();

                  con.Close();
              }*/


            //Insert item  sysdate + 1  (

          /*  if (numVal > 0)
            {
                string q1 = "insert into item (item_id ,EXPIRE_DATE,product_id ,quantity,product_name,price,cat_id) values ( item_seq.NEXTVAL, TO_DATE('" + this.dtpExpDate.Text + "','yyyy-MM-dd'),'" + txtboxid.Text + "','" + txtboxQuantity.Text + "','" + txtProName.Text + "','" + txtboxPrice.Text + "','"+txtboxCatid+"')";
                OracleDataAdapter oda2 = new OracleDataAdapter(q1, con);
                oda2.SelectCommand.ExecuteNonQuery();

                MessageBox.Show("Order is on Process.", "Successful");
                loadGridview();
                con.Close();

            }
            */
        }

        void fillcombo()
        {
            OracleConnection con = new OracleConnection(constr);
            string query = "select shpkper_address, shpkper_phone from shopkeeper";
            OracleCommand cmd = new OracleCommand(query, con);

            OracleDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    string loc = Convert.ToString(myreader["shpkper_address"]);
                    string phone = Convert.ToString(myreader["shpkper_phone"]);
                    cmbLocation.Items.Add(loc);
                    cmbPhone.Items.Add(phone);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
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
        void loadGridview()
        {
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            OracleDataAdapter oda = new OracleDataAdapter("select * from pro_view_cake", con);
            DataTable dt = new DataTable();

            this.dgvChooseCake.AutoGenerateColumns = false;
            oda.Fill(dt);
            dgvChooseCake.DataSource = dt;
            count();
            con.Close();
        }
        void searchData(string value)
        {
            string sql = "select * from product_inventory where cat_id =101 and product_name like '%" + value + "%'";
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            OracleDataAdapter oda = new OracleDataAdapter(sql, con);
            DataTable dt = new DataTable();

           // this.dgvChooseCake.AutoGenerateColumns = false;
            oda.Fill(dt);
            dgvChooseCake.DataSource = dt;
            con.Close();
        }

        private void txtAutoChnager_TextChanged(object sender, EventArgs e)
        {
            searchData(txtAutoChnager.Text);

        }

        private void dgvChooseCake_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtboxid.Text = this.dgvChooseCake.CurrentRow.Cells["product_id"].Value.ToString();
            this.txtProName.Text = this.dgvChooseCake.CurrentRow.Cells["product_name"].Value.ToString();
            this.txtboxCatid.Text = this.dgvChooseCake.CurrentRow.Cells["cat_id"].Value.ToString();
            this.txtQuantiry.Text = this.dgvChooseCake.CurrentRow.Cells["quantity"].Value.ToString();
           this.txtboxPrice.Text = this.dgvChooseCake.CurrentRow.Cells["price"].Value.ToString();
            this.dtpExpDate.Text = this.dgvChooseCake.CurrentRow.Cells["expire_date"].Value.ToString();

        }

        private void shopkeeperChooseItemCake_Load(object sender, EventArgs e)
        {

            dgvChooseCake.BorderStyle = BorderStyle.None;
            dgvChooseCake.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvChooseCake.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvChooseCake.DefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 25, 72);
            dgvChooseCake.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvChooseCake.BackgroundColor = Color.White;

            dgvChooseCake.EnableHeadersVisualStyles = false;
            dgvChooseCake.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvChooseCake.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            dgvChooseCake.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

     
        void count()
        {
            //string query = "select count(product_id) from product_inventory ";
            int sum = 0;
            for (int i = 0; i < dgvChooseCake.Rows.Count; i++)
            {
                sum++;
            }
            // int n = dgvProduct.Rows.Add();

            lblCount.Text = sum.ToString();

        }
    }
}
