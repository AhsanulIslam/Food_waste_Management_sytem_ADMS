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
    public partial class customerChooseitemSoftDrink : Form
    {
        string constr = "DATA SOURCE=DESKTOP-K8R8LDS:1521/XE;USER ID=SYSTEM;password=123";
        DataTable dt = new DataTable();
        int total_price = 0;
        int counteradd = 0;
        int counterdelete = 0;
        public customerChooseitemSoftDrink(string id, string n)
        {
            InitializeComponent();
            dt.Clear();
            fillcombo();
            loadGridview();
            lblCustId.Text = id;
            lblCustName.Text = n;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

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
        void fillcombo()
        {
            OracleConnection con = new OracleConnection(constr);
            string query = "select cust_address, cust_phone from Customer";
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
        void loadGridview()
        {
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            OracleDataAdapter oda = new OracleDataAdapter("select * from item where cat_id =102", con);
            DataTable dt = new DataTable();

            this.dgvSOftdrink.AutoGenerateColumns = false;
            oda.Fill(dt);
            dgvSOftdrink.DataSource = dt;
            count();
            con.Close();
        }
        void searchData(string value)
        {
            string sql = "select * from item where cat_id =102 and product_name like '%" + value + "%'";
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            OracleDataAdapter oda = new OracleDataAdapter(sql, con);
            DataTable dt = new DataTable();

            // this.dgvChooseCake.AutoGenerateColumns = false;
            oda.Fill(dt);
            dgvSOftdrink.DataSource = dt;
            con.Close();
        }

        private void txtAutoChnager_TextChanged(object sender, EventArgs e)
        {
            searchData(txtAutoChnager.Text);
        }

        private void dgvSOftdrink_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtProName.Text = this.dgvSOftdrink.CurrentRow.Cells["PRODUCT_NAME"].Value.ToString();
            //   this.txtboxProName.Text = this.dgvCakes.CurrentRow.Cells["product_name"].Value.ToString();
            // this.cmbCategoryId.Text = this.dgvCakes.CurrentRow.Cells["cat_id"].Value.ToString();
            // this.txtboxProQuantity.Text = this.dgvCakes.CurrentRow.Cells["quantity"].Value.ToString();
            this.txtboxItemId.Text = this.dgvSOftdrink.CurrentRow.Cells["item_id"].Value.ToString();
            this.txtProid.Text = this.dgvSOftdrink.CurrentRow.Cells["PRODUCT_ID"].Value.ToString();

            this.txtPrice.Text = this.dgvSOftdrink.CurrentRow.Cells["price"].Value.ToString();
            this.txtitemIdTemp.Text = this.dgvSOftdrink.CurrentRow.Cells["item_id"].Value.ToString();
            this.dtpHide.Text = this.dgvSOftdrink.CurrentRow.Cells["expire_date"].Value.ToString();
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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int x = 0;

            int i = Convert.ToInt32(dgvTemp.CurrentRow.Cells[2].Value);
            int tot = Convert.ToInt32(dgvTemp.CurrentRow.Cells[6].Value);

            //  int iI =  Convert.ToInt32(dgvTemp.CurrentRow.Cells[].Value);

            int j = ((Convert.ToInt32(lblFinalTotal.Text)) - i);



            lblFinalTotal.Text = j.ToString();
            int rowindex = dgvTemp.CurrentCell.RowIndex;
            dgvTemp.Rows.RemoveAt(rowindex);
            rem();
            refresh();
            if (counteradd == counterdelete)
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

                //   OracleCommand o = new OracleCommand("insert into ordertab (order_id,PRODUCT_NAME,quantity,Total_price,priceper,cust_loc,cust_phone,EXPIRE_DATE,order_date,cust_id,cust_name ) values (ordertab_seq.NEXTVAL,'" + dgvTemp.Rows[i].Cells[0].Value + "','" + dgvTemp.Rows[i].Cells[1].Value + "','" + dgvTemp.Rows[i].Cells[2].Value + "','" + dgvTemp.Rows[i].Cells[3].Value + "','" + dgvTemp.Rows[i].Cells[4].Value + "','" + dgvTemp.Rows[i].Cells[5].Value + "',TO_DATE('" + this.dtpHide.Text + "','yyyy-MM-dd'),SYSDATE,'" + lblCustId.Text + "','" + lblCustName.Text + "')", con);
                // OracleCommand o = new OracleCommand("insert into ordertab (order_id,PRODUCT_NAME,quantity,Total_price,priceper,cust_loc,cust_phone,Final_Totalprice,EXPIRE_DATE,order_date,cust_id,cust_name ) values (ordertab_seq.NEXTVAL,'" + dgvTemp.Rows[i].Cells[0].Value + "','" + dgvTemp.Rows[i].Cells[1].Value + "','" + dgvTemp.Rows[i].Cells[2].Value + "','" + dgvTemp.Rows[i].Cells[3].Value + "','" + dgvTemp.Rows[i].Cells[4].Value + "','" + dgvTemp.Rows[i].Cells[5].Value + "','" + dgvTemp.Rows[i].Cells[6].Value + "',TO_DATE('" + this.dtpHide.Text + "','yyyy-MM-dd'),SYSDATE,'" + lblCustId.Text + "','" + lblCustName.Text + "')", con);
             //   OracleCommand o = new OracleCommand("insert into ordertab (order_id,PRODUCT_NAME,quantity,Total_price,priceper,cust_loc,cust_phone,Final_Totalprice,EXPIRE_DATE,order_date,cust_id,cust_name ) values (ordertab_seq.NEXTVAL,'" + dgvTemp.Rows[i].Cells[0].Value + "','" + dgvTemp.Rows[i].Cells[1].Value + "','" + dgvTemp.Rows[i].Cells[2].Value + "','" + dgvTemp.Rows[i].Cells[3].Value + "','" + dgvTemp.Rows[i].Cells[4].Value + "','" + dgvTemp.Rows[i].Cells[5].Value + "','" + dgvTemp.Rows[i].Cells[6].Value + "',TO_DATE('" + this.dtpHide.Text + "','yyyy-MM-dd'),SYSDATE,'" + lblCustId.Text + "','" + lblCustName.Text + "')", con);
                OracleCommand o = new OracleCommand("insert into ordertab (order_id,PRODUCT_NAME,quantity,Total_price,priceper,cust_loc,cust_phone,EXPIRE_DATE,order_date,cust_id,cust_name,PRO_ID ) values (ordertab_seq.NEXTVAL,'" + dgvTemp.Rows[i].Cells[0].Value + "','" + dgvTemp.Rows[i].Cells[1].Value + "','" + dgvTemp.Rows[i].Cells[2].Value + "','" + dgvTemp.Rows[i].Cells[3].Value + "','" + dgvTemp.Rows[i].Cells[4].Value + "','" + dgvTemp.Rows[i].Cells[5].Value +"',TO_DATE('" + this.dtpHide.Text + "','yyyy-MM-dd'),SYSDATE,'" + lblCustId.Text + "','" + lblCustName.Text + "','" + txtProid.Text + "')", con);

                o.ExecuteNonQuery();

            }
            con.Close();
            dgvTemp.Rows.Clear();
            MessageBox.Show("Order is confirmed", "Thanks");

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            OracleConnection con1 = new OracleConnection(constr);
            con1.Open();


            for (int i = 0; i < dgvTemp.Rows.Count; i++)
            {

                // OracleCommand o = new OracleCommand("insert into ordertab (order_id,countNum,PRODUCT_NAME,quantity,Total_price,PRICE,cust_loc,cust_phone,EXPIRE_DATE,order_date,cust_id,CUST_NAME) values (ordertab_seq.NEXTVAL,TOTALORDERPRICE_SEQ.NEXTVAL,'" + dgvTemp.Rows[i].Cells[0].Value +"','"+ dgvTemp.Rows[i].Cells[1].Value + "','" + dgvTemp.Rows[i].Cells[2].Value + "','" + dgvTemp.Rows[i].Cells[3].Value + "','" + dgvTemp.Rows[i].Cells[4].Value + "','" + dgvTemp.Rows[i].Cells[5].Value + "',TO_DATE('" + this.dtpHide.Text + "','yyyy-MM-dd'),SYSDATE,'" + lblCustId.Text + "','" + lblCustName.Text + "')", con);
                OracleCommand cm = new OracleCommand("insert into Cust_ORDER_History (PRODUCT_NAME,quantity,Total_price,priceper,cust_loc,cust_phone,EXPIRE_DATE,order_date,cust_id,cust_name,PRO_ID ) values ('" + dgvTemp.Rows[i].Cells[0].Value + "','" + dgvTemp.Rows[i].Cells[1].Value + "','" + dgvTemp.Rows[i].Cells[2].Value + "','" + dgvTemp.Rows[i].Cells[3].Value + "','" + dgvTemp.Rows[i].Cells[4].Value + "','" + dgvTemp.Rows[i].Cells[5].Value + "',TO_DATE('" + this.dtpHide.Text + "','yyyy-MM-dd'),SYSDATE,'" + lblCustId.Text + "','" + lblCustName.Text + "','" + txtProid.Text + "')", con1);

                cm.ExecuteNonQuery();

            }




            OracleConnection con = new OracleConnection(constr);
            con.Open();
           insertIntoGridview();
            OracleCommand o = new OracleCommand("insert into TotalPrice(CUST_ID,Totalprice) values ('" +this.lblCustId.Text + "','" + Convert.ToInt32(lblFinalTotal.Text) + "')", con);
            o.ExecuteNonQuery();
            con.Close();
            total_price = 0;
            lblFinalTotal.Text = total_price.ToString();
            refresh();

        }

        

        private void dgvTemp_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            this.txtitemIdTemp.Text = this.dgvTemp.CurrentRow.Cells[8].Value.ToString();
            this.txtBoxAddTOueueQuantity.Text = this.dgvTemp.CurrentRow.Cells[1].Value.ToString();
        }

        private void customerChooseitemSoftDrink_Load(object sender, EventArgs e)
        {

            dgvSOftdrink.BorderStyle = BorderStyle.None;
            dgvSOftdrink.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvSOftdrink.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSOftdrink.DefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 25, 72);
            dgvSOftdrink.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvSOftdrink.BackgroundColor = Color.White;

            dgvSOftdrink.EnableHeadersVisualStyles = false;
            dgvSOftdrink.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSOftdrink.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            dgvSOftdrink.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;



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
            for (int i = 0; i < dgvSOftdrink.Rows.Count; i++)
            {
                sum++;
            }
            // int n = dgvProduct.Rows.Add();

            lblCount.Text = sum.ToString();

        }

        private void btnConfirm_MouseMove(object sender, MouseEventArgs e)
        {
            SidePanel.Height = btnConfirm.Height;
            SidePanel.Top = btnConfirm.Top;
        }

        private void btnAddQueue_MouseHover(object sender, EventArgs e)
        {
             SidePanel.Height = btnAddQueue.Height;
            SidePanel.Top = btnAddQueue.Top;
        }

        private void btnDelete_MouseMove(object sender, MouseEventArgs e)
        {
            SidePanel.Height = btnDelete.Height;
            SidePanel.Top = btnDelete.Top;
        }
    }
}
