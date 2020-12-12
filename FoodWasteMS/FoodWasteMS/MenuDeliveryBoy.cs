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
    public partial class MenuDeliveryBoy : Form
    {
        string constr = "DATA SOURCE=DESKTOP-Q3KCJHO:1521/XE;USER ID=SYSTEM;password=123";

        private Login F1 { get; set; }

        public MenuDeliveryBoy()
        {
            InitializeComponent();
          
        }
        public MenuDeliveryBoy(string username,string type, Login f1)
        {
            InitializeComponent();
            this.lblUser.Text = username;
            this.lbltype.Text = type;
            this.F1 = f1;

            OracleConnection con = new OracleConnection(constr);

            con.Open();
            string q1 = "select * from DELIVERYBOY  where DELBOY_UNAME ='" + username + "'";
            OracleCommand oc = new OracleCommand(q1, con);
            OracleDataReader odr = oc.ExecuteReader();
            if (odr.Read())
            {
                lblfullname.Text = (odr["DELBOY_FNAME"].ToString());
                lblid.Text = (odr["delboy_id"].ToString());
                lblphone.Text = (odr["delboy_phone"].ToString());
              //  lbladdress.Text = (odr["shpkper_address"].ToString());
            }
            loadGridview();
            con.Close();
        }

        void loadGridview()
        {
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            string s = "select * from NoticeDelBoy where delboy_id  = '" + this.lblid.Text + "'";
            OracleDataAdapter oda = new OracleDataAdapter(s, con);
            DataTable dt = new DataTable();

            this.dgvDeli.AutoGenerateColumns = false;
            oda.Fill(dt);
            dgvDeli.DataSource = dt;
            count();
            con.Close();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
            Login l = new Login();
            l.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(constr);
            con.Open();


            string que = "insert into d_log (dog_date , notid ,log_type ) values (  sysdate,'" + txtNotice.Text + "','" + lblDel.Text + "')"; //

            OracleCommand oc = new OracleCommand(que, con);
            oc.ExecuteNonQuery();



            string query = "delete from NoticeDelBoy where notice_id = '" + txtNotice.Text + "'";


            OracleCommand cmd = new OracleCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Order Id "+dgvDeli.CurrentRow.Cells[0].Value.ToString() +" Delivery Done.","Thanks");
            loadGridview();

            con.Close();
        }

        private void dgvDeli_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtNotice.Text = this.dgvDeli.CurrentRow.Cells["notice_id"].Value.ToString();

        }

        private void MenuDeliveryBoy_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblDate.Text = DateTime.Now.ToLongDateString();
            lbltime.Text = DateTime.Now.ToLongTimeString();
            dgvDeli.BorderStyle = BorderStyle.None;
            dgvDeli.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvDeli.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDeli.DefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 25, 72);
            dgvDeli.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvDeli.BackgroundColor = Color.White;

            dgvDeli.EnableHeadersVisualStyles = false;
            dgvDeli.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDeli.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            dgvDeli.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void txtAutoChnager_TextChanged(object sender, EventArgs e)
        {
            searchData(txtAutoChnager.Text);
        }


       
private void back_Click(object sender, EventArgs e)
        {
           
        }
    


    void searchData(string value)
    {
        string sql = "select * from NoticeDelBoy where  delboy_id  = '" + this.lblid.Text + "' and  SHPKPERCUST_NAME like '%" + value + "%'";
        OracleConnection con = new OracleConnection(constr);
        con.Open();
        OracleDataAdapter oda = new OracleDataAdapter(sql, con);
        DataTable dt = new DataTable();

        this.dgvDeli.AutoGenerateColumns = false;
        oda.Fill(dt);
            dgvDeli.DataSource = dt;
        con.Close();
    }
    void count()
    {
        //string query = "select count(product_id) from product_inventory ";
        int sum = 0;
        for (int i = 0; i < dgvDeli.Rows.Count; i++)
        {
            sum++;
        }
        // int n = dgvProduct.Rows.Add();

        lblCount.Text = sum.ToString();

    }

        private void btnLogOut_MouseHover(object sender, EventArgs e)
        {
            SidePanel.Height = btnLogOut.Height;
            SidePanel.Top = btnLogOut.Top;
        }

        private void btnDone_MouseHover(object sender, EventArgs e)
        {
            SidePanel.Height = btnDone.Height;
            SidePanel.Top = btnDone.Top;
        }
    }
}
