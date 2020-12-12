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
using Oracle.ManagedDataAccess.Types;
//using Oracle.DataAccess.Client;
namespace FoodWasteMS
{
    public partial class customerChooseItemCake : Form
    {
        string constr = "DATA SOURCE=DESKTOP-Q3KCJHO:1521/XE;USER ID=SYSTEM;password=123";
        DataTable dt = new DataTable();
        int total_price = 0;
       int  counteradd =0;
        int counterdelete = 0;
        int countNums = 1;

        public customerChooseItemCake(string id, string n)
        {
            InitializeComponent();
            dt.Clear();
            fillcombo();
            loadGridview();
            lblCustId.Text = id;
            lblCustName.Text = n;
         
        }

        void refresh()
        {
            txtProName.Clear();
            txtboxQuantity.Clear();
            cmbLocation.Text = "";
            cmbPhone.Text = "";
            txtTotal.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        void searchData(string value)
        {
            string sql = "select * from item where cat_id =101 and product_name like '%" + value + "%'";
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            OracleDataAdapter oda = new OracleDataAdapter(sql, con);
            DataTable dt = new DataTable();

            // this.dgvChooseCake.AutoGenerateColumns = false;
            oda.Fill(dt);
            dgvCakes.DataSource = dt;
            con.Close();
        }

        private void dgvCakes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtProName.Text = this.dgvCakes.CurrentRow.Cells["PRODUCT_NAME"].Value.ToString();
         //   this.txtboxProName.Text = this.dgvCakes.CurrentRow.Cells["product_name"].Value.ToString();
            this.txtProid.Text = this.dgvCakes.CurrentRow.Cells["PRODUCT_ID"].Value.ToString();
            this.txtboxItemId.Text = this.dgvCakes.CurrentRow.Cells["item_id"].Value.ToString();

            this.txtPrice.Text = this.dgvCakes.CurrentRow.Cells["price"].Value.ToString();
            this.txtitemIdTemp.Text = this.dgvCakes.CurrentRow.Cells["item_id"].Value.ToString();
            this.dtpHide.Text = this.dgvCakes.CurrentRow.Cells["expire_date"].Value.ToString();
        }

        private void txtboxQuantity_Leave(object sender, EventArgs e)
        {
            try
            {
                txtTotal.Text = Convert.ToString(Convert.ToInt32(txtboxQuantity.Text) * Convert.ToInt32(txtPrice.Text));
            }
            catch (Exception EX)
            {

            }
        }

        private void btnAddQueue_Click(object sender, EventArgs e)
        {
            counteradd++;
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            string id = this.txtboxItemId.Text.ToString();
            txtBoxAddTOueueQuantity.Text = txtboxQuantity.Text;
            //  string i = txtboxQuantity.Text.ToString();
            //  int numVal = Int32.Parse(i);
            //    if (numVal > 0)

            //     {



            int stock = 0;
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from item where PRODUCT_NAME ='" + txtProName.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                oda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    stock = Convert.ToInt32(dr["quantity"].ToString());
                }

                if (Convert.ToInt32(txtboxQuantity.Text) > stock)
                {
                    MessageBox.Show("out of stock");
                }
                else
                {
                string qry = "update item set quantity = (quantity - '" + Int32.Parse(txtboxQuantity.Text.ToString()) + "') where item_id='" + id + "'";

                OracleDataAdapter oda1 = new OracleDataAdapter(qry, con);

                OracleCommand cmd1 = new OracleCommand(qry, con);
                cmd1.ExecuteNonQuery();


                total_price = total_price + (Convert.ToInt32(txtPrice.Text) * Convert.ToInt32(txtboxQuantity.Text));
                lblFinalTotal.Text = total_price.ToString();

                dgvTemp.Rows.Add(txtProName.Text, txtboxQuantity.Text, txtTotal.Text, txtPrice.Text, cmbLocation.Text, cmbPhone.Text, lblFinalTotal.Text, dtpHide.Text, txtitemIdTemp.Text);            

                    loadGridview();
                    refresh();

                }
           // }
        //    else
          //  {
            //    MessageBox.Show("Out of stock", "Try later");

            //}
            }
        void loadGridview()
        {
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            OracleDataAdapter oda = new OracleDataAdapter("select * from item where cat_id =101", con);
            DataTable dt = new DataTable();

            this.dgvCakes.AutoGenerateColumns = false;
            oda.Fill(dt);
            dgvCakes.DataSource = dt;
            count();
            con.Close();
        }
        void fillcombo()
        {
            OracleConnection con = new OracleConnection(constr);
            string query = "select cust_address, cust_phone from customer";
            OracleCommand cmd = new OracleCommand(query, con);

            OracleDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    string loc = Convert.ToString(myreader["cust_address"]);
                    string phone = Convert.ToString(myreader["cust_phone"]);
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
        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;
           
            int i =  Convert.ToInt32(dgvTemp.CurrentRow.Cells[2].Value);
          //  int iI =  Convert.ToInt32(dgvTemp.CurrentRow.Cells[].Value);
            int j = ((Convert.ToInt32 (lblFinalTotal.Text)) - i ) ;
            lblFinalTotal.Text = j.ToString();
            int rowindex = dgvTemp.CurrentCell.RowIndex;
            dgvTemp.Rows.RemoveAt(rowindex);
            rem();
            refresh();

            if(counteradd==counterdelete)
            {
                lblFinalTotal.Text = x.ToString();
                total_price = 0;
            }

        }
        void rem()
        {

            counterdelete++;

            string id = this.txtitemIdTemp.Text.ToString();
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            string i = txtboxQuantity.Text.ToString();
           // int numVal = Int32.Parse(i);
          //  if (numVal > 0)

        //    {
               // int j = Convert.ToInt32(dgvTemp.CurrentRow.Cells[1].Value);

                string qry = "update item set quantity = (quantity + '" + Int32.Parse(txtBoxAddTOueueQuantity.Text.ToString()) + "') where item_id='" + id + "'";

                OracleDataAdapter oda = new OracleDataAdapter(qry, con);

                OracleCommand cmd1 = new OracleCommand(qry, con);
                cmd1.ExecuteNonQuery();
            loadGridview();
          //  }
        }

            void insertIntoGridview()
            {
            
            OracleConnection con = new OracleConnection(constr);
            con.Open();
          

            for (int i = 0; i < dgvTemp.Rows.Count; i++)
            {

               // OracleCommand o = new OracleCommand("insert into ordertab (order_id,countNum,PRODUCT_NAME,quantity,Total_price,PRICE,cust_loc,cust_phone,EXPIRE_DATE,order_date,cust_id,CUST_NAME) values (ordertab_seq.NEXTVAL,TOTALORDERPRICE_SEQ.NEXTVAL,'" + dgvTemp.Rows[i].Cells[0].Value +"','"+ dgvTemp.Rows[i].Cells[1].Value + "','" + dgvTemp.Rows[i].Cells[2].Value + "','" + dgvTemp.Rows[i].Cells[3].Value + "','" + dgvTemp.Rows[i].Cells[4].Value + "','" + dgvTemp.Rows[i].Cells[5].Value + "',TO_DATE('" + this.dtpHide.Text + "','yyyy-MM-dd'),SYSDATE,'" + lblCustId.Text + "','" + lblCustName.Text + "')", con);
                OracleCommand o = new OracleCommand("insert into ordertab (order_id,PRODUCT_NAME,quantity,Total_price,priceper,cust_loc,cust_phone,EXPIRE_DATE,order_date,cust_id,cust_name,PRO_ID ) values (ordertab_seq.NEXTVAL,'" + dgvTemp.Rows[i].Cells[0].Value + "','" + dgvTemp.Rows[i].Cells[1].Value + "','" + dgvTemp.Rows[i].Cells[2].Value + "','" + dgvTemp.Rows[i].Cells[3].Value + "','" + dgvTemp.Rows[i].Cells[4].Value + "','" + dgvTemp.Rows[i].Cells[5].Value + "',TO_DATE('" + this.dtpHide.Text + "','yyyy-MM-dd'),SYSDATE,'" + lblCustId.Text + "','" + lblCustName.Text + "','"+txtProid.Text+ "')", con);

                o.ExecuteNonQuery();


               
            }
            con.Close();
            dgvTemp.Rows.Clear();
            MessageBox.Show("Order is confirmed", "Thanks");

        }

       /* void insertOrderHistory()
        {

            OracleConnection con = new OracleConnection(constr);
            con.Open();


            for (int i = 0; i < dgvTemp.Rows.Count; i++)
            {

                // OracleCommand o = new OracleCommand("insert into ordertab (order_id,countNum,PRODUCT_NAME,quantity,Total_price,PRICE,cust_loc,cust_phone,EXPIRE_DATE,order_date,cust_id,CUST_NAME) values (ordertab_seq.NEXTVAL,TOTALORDERPRICE_SEQ.NEXTVAL,'" + dgvTemp.Rows[i].Cells[0].Value +"','"+ dgvTemp.Rows[i].Cells[1].Value + "','" + dgvTemp.Rows[i].Cells[2].Value + "','" + dgvTemp.Rows[i].Cells[3].Value + "','" + dgvTemp.Rows[i].Cells[4].Value + "','" + dgvTemp.Rows[i].Cells[5].Value + "',TO_DATE('" + this.dtpHide.Text + "','yyyy-MM-dd'),SYSDATE,'" + lblCustId.Text + "','" + lblCustName.Text + "')", con);
                OracleCommand o2 = new OracleCommand("insert into Cust_ORDER_History (PRODUCT_NAME,quantity,Total_price,priceper,cust_loc,cust_phone,EXPIRE_DATE,order_date,cust_id,cust_name,PRO_ID ) values ('" + dgvTemp.Rows[i].Cells[0].Value + "','" + dgvTemp.Rows[i].Cells[1].Value + "','" + dgvTemp.Rows[i].Cells[2].Value + "','" + dgvTemp.Rows[i].Cells[3].Value + "','" + dgvTemp.Rows[i].Cells[4].Value + "','" + dgvTemp.Rows[i].Cells[5].Value + "',TO_DATE('" + this.dtpHide.Text + "','yyyy-MM-dd'),SYSDATE,'" + lblCustId.Text + "','" + lblCustName.Text + "','" + txtProid.Text + "')", con);

                o2.ExecuteNonQuery();

            }
            con.Close();
       //     dgvTemp.Rows.Clear();
          //  MessageBox.Show("Order is confirmed", "Thanks");

        }*/

        private void btnreplace_Click(object sender, EventArgs e)
        {
            OracleConnection con1 = new OracleConnection(constr);
            con1.Open();


            for (int i = 0; i < dgvTemp.Rows.Count; i++)
            {

                // OracleCommand o = new OracleCommand("insert into ordertab (order_id,countNum,PRODUCT_NAME,quantity,Total_price,PRICE,cust_loc,cust_phone,EXPIRE_DATE,order_date,cust_id,CUST_NAME) values (ordertab_seq.NEXTVAL,TOTALORDERPRICE_SEQ.NEXTVAL,'" + dgvTemp.Rows[i].Cells[0].Value +"','"+ dgvTemp.Rows[i].Cells[1].Value + "','" + dgvTemp.Rows[i].Cells[2].Value + "','" + dgvTemp.Rows[i].Cells[3].Value + "','" + dgvTemp.Rows[i].Cells[4].Value + "','" + dgvTemp.Rows[i].Cells[5].Value + "',TO_DATE('" + this.dtpHide.Text + "','yyyy-MM-dd'),SYSDATE,'" + lblCustId.Text + "','" + lblCustName.Text + "')", con);
               // OracleCommand cm = new OracleCommand("insert into Cust_ORDER_History (PRODUCT_NAME, quantity, Total_price, priceper, cust_loc, cust_phone, EXPIRE_DATE, order_date, cust_id, cust_name, PRO_ID ) values ('" + dgvTemp.Rows[i].Cells[0].Value + "','" + dgvTemp.Rows[i].Cells[1].Value + "','" + dgvTemp.Rows[i].Cells[2].Value + "','" + dgvTemp.Rows[i].Cells[3].Value + "','" + dgvTemp.Rows[i].Cells[4].Value + "','" + dgvTemp.Rows[i].Cells[5].Value + "',TO_DATE('" + this.dtpHide.Text + "','yyyy-MM-dd'),SYSDATE,'" + lblCustId.Text + "','" + lblCustName.Text + "','" + txtProid.Text + "')", con1);

            //    cm.ExecuteNonQuery();

            }




            OracleConnection con = new OracleConnection(constr);
            con.Open();
            insertIntoGridview();
          //  insertOrderHistory();
            OracleCommand o = new OracleCommand("insert into TotalPrice(CUST_ID,Totalprice) values ('" + this.lblCustId.Text + "','" + Convert.ToInt32(lblFinalTotal.Text) + "')", con);
            o.ExecuteNonQuery();
            con.Close();
            total_price = 0;
            lblFinalTotal.Text = total_price.ToString();
            refresh();

        }

        private void txtAutoChnager_TextChanged(object sender, EventArgs e)
        {
            searchData(txtAutoChnager.Text);
        }

        private void dgvTemp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtitemIdTemp.Text = this.dgvTemp.CurrentRow.Cells[8].Value.ToString();
            this.txtBoxAddTOueueQuantity.Text = this.dgvTemp.CurrentRow.Cells[1].Value.ToString();

        }

        private void customerChooseItemCake_Load(object sender, EventArgs e)
        {

            dgvCakes.BorderStyle = BorderStyle.None;
            dgvCakes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvCakes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCakes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 25, 72);
            dgvCakes.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvCakes.BackgroundColor = Color.White;

            dgvCakes.EnableHeadersVisualStyles = false;
            dgvCakes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCakes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            dgvCakes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            dgvTemp.BorderStyle = BorderStyle.None;
            dgvTemp.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvTemp.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTemp.DefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 25, 72);
            dgvTemp.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvTemp.BackgroundColor = Color.White;

            dgvTemp.EnableHeadersVisualStyles = false;
            dgvTemp.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTemp.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            dgvTemp.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }


        void count()
        {
            //string query = "select count(product_id) from product_inventory ";
            int sum = 0;
            for (int i = 0; i < dgvCakes.Rows.Count; i++)
            {
                sum++;
            }
            // int n = dgvProduct.Rows.Add();

            lblCount.Text = sum.ToString();

        }

        private void btnAddQueue_MouseHover(object sender, EventArgs e)
        {
            SidePanel.Height = btnAddQueue.Height;
            SidePanel.Top = btnAddQueue.Top;
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            SidePanel.Height = btnDelete.Height;
            SidePanel.Top = btnDelete.Top;
        }

        private void btnConfirm_MouseHover(object sender, EventArgs e)
        {
            SidePanel.Height = btnConfirm.Height;
            SidePanel.Top = btnConfirm.Top;
        }
    }
}

// DataRow data = dt.NewRow();
//  data["PRODUCT_NAME"] = txtProName.Text;
//  data["price"] = txtPrice.Text;
//   data["Quantity"] = txtboxQuantity.Text;
// data["Total"] = txtTotal.Text;
// data["Location"] = cmbLocation.Text;
// data["Phone"] = cmbPhone.Text;
// data["EXPIRE_DATE"] = dtpHide.Text;



//  dt.Rows.Add(data);
//  dgvTemp.DataSource = dt;

// total_price = total_price + Convert.ToInt32(data["Total"].ToString());