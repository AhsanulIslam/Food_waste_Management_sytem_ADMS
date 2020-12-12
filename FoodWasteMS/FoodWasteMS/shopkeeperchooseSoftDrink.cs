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
    public partial class shopkeeperchooseSoftDrink : Form
    {
        string constr = "DATA SOURCE=DESKTOP-Q3KCJHO:1521/XE;USER ID=SYSTEM;password=123";
        private MenuShopkeepers s1 { get; set; }
        string i;

        public shopkeeperchooseSoftDrink(string id, string name, MenuShopkeepers m)
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
            OracleDataAdapter oda = new OracleDataAdapter("select * from pro_view_drinks", con);
            DataTable dt = new DataTable();

            this.dgvSoftDrink.AutoGenerateColumns = false;
            oda.Fill(dt);
            dgvSoftDrink.DataSource = dt;
            count();
            con.Close();
        }
        void searchData(string value)
        {
            string sql = "select * from product_inventory where cat_id =102 and product_name like '%" + value + "%'";
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            OracleDataAdapter oda = new OracleDataAdapter(sql, con);
            DataTable dt = new DataTable();

            // this.dgvChooseCake.AutoGenerateColumns = false;
            oda.Fill(dt);
            dgvSoftDrink.DataSource = dt;
            con.Close();
        }
        private void txtAutoChnager_TextChanged(object sender, EventArgs e)
        {
            searchData(txtAutoChnager.Text);
        }
       

        private void btnreplace_Click(object sender, EventArgs e)
        {
            replace();
        }

        void refresh()
        {
            txtProName.Clear();
            txtboxQuantity.Clear();
            cmbLocation.Text = "";
            cmbPhone.Text = "";
        }
        void replace()
        {



            //quantity ---- inventory

            string id = this.txtboxid.Text.ToString();
            OracleConnection con = new OracleConnection(constr);
            con.Open();
             i = txtQuantiry.Text.ToString();
            int numVal = Int32.Parse(i);
            if (numVal > 0)

            {
                string qry = "update product_inventory set quantity = (quantity - '" + Int32.Parse(txtboxQuantity.Text.ToString()) + "') where product_id='" + id + "'";

                OracleDataAdapter oda = new OracleDataAdapter(qry, con);

                OracleCommand cmd = new OracleCommand(qry, con);
                cmd.ExecuteNonQuery();

                // string query = "insert into replace_order (REPLACE_ID,EXPIRE_DATE,shpkper_id ,quantity,PRODUCT_ID,product_name,shopkeeper_Location) values ( replaceOrder_seq.NEXTVAL, TO_DATE('" + this.dtpExpDate.Text + "','yyyy-MM-dd'),'" + lblId.Text + "','" + txtboxQuantity.Text + "'," + txtboxid + "','" + txtProName.Text + "','" + cmbLocation.Text + "')";
                //   string query = "insert into replace_order (REPLACE_ID,EXPIRE_DATE ,quantity,PRODUCT_ID,product_name,shopkeeper_Location,shpkper_phone) values ( replaceOrder_seq.NEXTVAL, TO_DATE('" + this.dtpExpDate.Text + "','yyyy-MM-dd'),'" + txtboxQuantity.Text + "','"+txtboxid.Text +"','" + txtProName.Text + "','" + cmbLocation.Text +"','" + cmbPhone.Text + "')";

                //TO_CHAR (SYSDATE, 'MM-DD-YYYY HH24:MI:SS')
                string query = "insert into replace_order (REPLACE_ID,EXPIRE_DATE,SHPKPERORDERDATE,shpkper_id,quantity,PRODUCT_ID,product_name,shopkeeper_Location,shpkper_phone,shpkper_name) values ( replaceOrder_seq.NEXTVAL, TO_DATE('" + this.dtpExpDate.Text + "','yyyy-MM-dd'),SYSDATE,'" + lblId.Text + "','" + txtboxQuantity.Text + "','" + txtboxid.Text + "','" + txtProName.Text + "','" + cmbLocation.Text + "','" + cmbPhone.Text + "','" +lblShopkeepername.Text+ "')";

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

        private void dgvSoftDrink_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtboxid.Text = this.dgvSoftDrink.CurrentRow.Cells["product_id"].Value.ToString();
            this.txtProName.Text = this.dgvSoftDrink.CurrentRow.Cells["product_name"].Value.ToString();
            this.txtboxCatid.Text = this.dgvSoftDrink.CurrentRow.Cells["cat_id"].Value.ToString();
            this.txtQuantiry.Text = this.dgvSoftDrink.CurrentRow.Cells["quantity"].Value.ToString();
            this.txtboxPrice.Text = this.dgvSoftDrink.CurrentRow.Cells["price"].Value.ToString();
            this.dtpExpDate.Text = this.dgvSoftDrink.CurrentRow.Cells["expire_date"].Value.ToString();

        }

        private void shopkeeperchooseSoftDrink_Load(object sender, EventArgs e)
        {
            dgvSoftDrink.BorderStyle = BorderStyle.None;
            dgvSoftDrink.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvSoftDrink.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSoftDrink.DefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 25, 72);
            dgvSoftDrink.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvSoftDrink.BackgroundColor = Color.White;

            dgvSoftDrink.EnableHeadersVisualStyles = false;
            dgvSoftDrink.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSoftDrink.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            dgvSoftDrink.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

      
        void count()
        {
            //string query = "select count(product_id) from product_inventory ";
            int sum = 0;
            for (int i = 0; i < dgvSoftDrink.Rows.Count; i++)
            {
                sum++;
            }
            // int n = dgvProduct.Rows.Add();

            lblCount.Text = sum.ToString();

        }
    }
}
