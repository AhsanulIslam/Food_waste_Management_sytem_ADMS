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

namespace FoodWasteMS
{
    public partial class Addproduct : Form
    {
        string constr = "DATA SOURCE=DESKTOP-K8R8LDS:1521/XE;USER ID=SYSTEM;password=123";
        public Addproduct()
        {
            InitializeComponent();
            fillcombo();
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

        void refresh()
        {
            this.txtboxProName.Clear();
            this.txtboxProPrice.Clear();
            this.txtboxProQuantity.Clear();
            this.cmbCategoryId.Text = "";
        }

        void add()
        {

            OracleConnection con = new OracleConnection(constr);
            OracleCommand cmd = new OracleCommand("PRODUCTMANAGER.InsertPro", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            //    try
            //   {
            // cmd.Parameters.Add("proid", OracleDbType.Int32).Value = "PRODUCTINVENTORY_SEQ.NEXTVAL";
           // cmd.Parameters.Add(dtpExpDate.ToString("dd-MMM-yyyy"), OracleDbType.Date).Value = dtpExpDate;
                cmd.Parameters.Add("TO_DATE(dat, 'yyyy-MM-dd')", OracleDbType.Date).Value = Convert.ToDateTime(dtpExpDate.Text); // Convert.ToDateTime(dtpExpDate.Text );
                cmd.Parameters.Add("pnam", OracleDbType.Varchar2, 50).Value = txtboxProName.Text;
                cmd.Parameters.Add("cid", OracleDbType.Int32).Value = cmbCategoryId.Text;
                cmd.Parameters.Add("qua", OracleDbType.Int32).Value = txtboxProQuantity.Text;
                cmd.Parameters.Add("prc", OracleDbType.Int32).Value = txtboxProPrice.Text;
               

                cmd.ExecuteNonQuery();
                MessageBox.Show("Insertion Done", "Successful");

        //   }
          // catch (Exception ex)
          // {
       
           //    System.Console.WriteLine(ex.ToString());
            
       //     }
            loadGridview();
            refresh();
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           add();
         /* OracleConnection con = new OracleConnection(constr);
            con.Open();
            
         //   string proid = this.txtboxProId.Text.ToString();
            string proname = this.txtboxProName.Text.ToString();
            string catid = this.cmbCategoryId.Text.ToString();
            string proprice = this.txtboxProPrice.Text.ToString();
            string expdate = this.dtpExpDate.Value.ToString();
            string quantity = this.txtboxProQuantity.Text.ToString();


            string que = "insert into log_add (modate, product_name ,quant, pri ,log_type ) values (  sysdate,'" + proname + "','" + quantity + "','" + proprice + "','"+ lblAdding.Text+ "')"; //

            OracleCommand oc = new OracleCommand(que, con);
            oc.ExecuteNonQuery();

            //                string query = "insert into product_inventory (product_id, expire_date,product_name, cat_id, quantity, price) values (  PRODUCTINVENTORY_SEQ.NEXTVAL, TO_DATE('2014-02-22','yyyy-MM-dd'),'" + txtboxProName.Text.ToString() + "','" + cmbCategoryId.Text.ToString() + "','" + txtboxProQuantity.Text.ToString() + "','" + txtboxProPrice.Text.ToString() + "')"; //  +"', price ='" + proprice + "' where product_id='" + proid + "'";


            string query = "insert into product_inventory (product_id, expire_date,product_name, cat_id, quantity, price) values (  PRODUCTINVENTORY_SEQ.NEXTVAL, TO_DATE('"+ this.dtpExpDate.Text + "','yyyy-MM-dd'),'" + proname + "','" + catid + "','" + quantity + "','" + proprice + "')"; //
                OracleDataAdapter oda = new OracleDataAdapter(query, con);
                oda.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Insertion Done","Successful");


                  
           

           // con.Close();                                //+ "','TO_DATE('" + dateTimePicker1.Value.ToString() + "','mm/dd/yyyy')')"; 


          //  OracleConnection con1 = new OracleConnection(constr);
          //  con1.Open();
            

            loadGridview();

            con.Close();
          //  con1.Close();*/
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
        }

        void loadGridview()
        {
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            OracleDataAdapter oda = new OracleDataAdapter("select * from product_inventory", con);
            DataTable dt = new DataTable();

            this.dgvProduct.AutoGenerateColumns = false;
            oda.Fill(dt);
            dgvProduct.DataSource = dt;
            count();
            con.Close();
        }

        void searchData(string value)
        {
            string sql = "select * from product_inventory where product_name like '%" + value + "%'";
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            OracleDataAdapter oda = new OracleDataAdapter(sql, con);
            DataTable dt = new DataTable();

            this.dgvProduct.AutoGenerateColumns = false;
            oda.Fill(dt);
            dgvProduct.DataSource = dt;
            con.Close();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchData(txtAutoChnager.Text);
        }

        private void Addproduct_Load(object sender, EventArgs e)
        {
            dgvProduct.BorderStyle = BorderStyle.None;
            dgvProduct.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvProduct.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProduct.DefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 25, 72);
            dgvProduct.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvProduct.BackgroundColor = Color.White;

            dgvProduct.EnableHeadersVisualStyles = false;
            dgvProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProduct.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            dgvProduct.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        void count()
        {
            //string query = "select count(product_id) from product_inventory ";
            int sum = 0;
            for(int i =0; i< dgvProduct.Rows.Count;i++)
            {
                sum++;
            }
            // int n = dgvProduct.Rows.Add();

            lblCount.Text = sum.ToString();

        }
    }
}
