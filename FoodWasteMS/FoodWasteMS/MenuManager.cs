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
//using Oracle.DataAccess.Types;
//using Oracle.DataAccess.Client;
//using System.Data.Common.DbDataReader;
namespace FoodWasteMS
{
    public partial class MenuManager : Form
    {
        string constr = "DATA SOURCE=DESKTOP-Q3KCJHO:1521/XE;USER ID=SYSTEM;password=123";

        private Login F1 { get; set;  }
        public MenuManager()
        {
            InitializeComponent();
            SidePanel.Height = btndiscount.Height;
            SidePanel.Top = btndiscount.Top;
        }

        public MenuManager(string username,string type, Login f1)
        {
            InitializeComponent();
            this.lbluser.Text = username;
            this.lbltype.Text = type;
            this.F1 = f1;

            OracleConnection con = new OracleConnection(constr);

            con.Open();
            string q1 = "select * from manager where mgr_uname ='" + username + "'";
            OracleCommand oc = new OracleCommand(q1, con);
            OracleDataReader odr = oc.ExecuteReader();
            if (odr.Read())
            {
                lblfullname.Text = (odr["mgr_fname"].ToString());
                lblid.Text = (odr["mgr_id"].ToString());
                lblphone.Text = (odr["mgr_phone"].ToString());
                lbladdress.Text = (odr["mgr_address"].ToString());
            }
            con.Close();

        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddpro_Click(object sender, EventArgs e)
        {
            Addproduct a = new Addproduct();
            a.Show();
        }

        private void btnRemvpr_Click(object sender, EventArgs e)
        {
            RemoveProduct rem = new RemoveProduct();
            rem.Show();
        }

        private void btnupDate_Click(object sender, EventArgs e)
        {
            UpdateProduct up = new UpdateProduct();
            up.Show();
        }

        private void btnViewCategory_Click(object sender, EventArgs e)
        {
            managerCategoryView ct = new managerCategoryView(lblfullname.Text,lblid.Text,lblphone.Text,lbladdress.Text,lbluser.Text,this);
            ct.Show();
        }

        private void btnViewReplaceREQ_Click(object sender, EventArgs e)
        {
            ReplaceOrderRequest rep = new ReplaceOrderRequest(this.lbluser.Text,this);
            rep.Show();
        }

        private void btnViewCustOrdr_Click(object sender, EventArgs e)
        {
            OrderCustomer orc = new OrderCustomer(this.lbluser.Text,this);
            orc.Show();
        }

        private void btnAssignforShopkeeper_Click(object sender, EventArgs e)
        {
            AssignDeliverytoSHOPkeeper ass = new AssignDeliverytoSHOPkeeper();
            ass.Show();
        }

        private void btnAssignForCust_Click(object sender, EventArgs e)
        {
          
            AssiginDeliveryCUSTOMER ass = new AssiginDeliveryCUSTOMER();
            ass.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
          
            Login l = new Login();
            l.Show();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void MenuManager_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblDate.Text = DateTime.Now.ToLongDateString();
            lbltime.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetDiscount s = new SetDiscount();
            s.Show();
            
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            History h = new History();
            h.Show();
           
        }

        private void btndiscount_MouseHover(object sender, EventArgs e)
        {
            SidePanel.Height = btndiscount.Height;
            SidePanel.Top = btndiscount.Top;
        }

        private void btnHistory_MouseHover(object sender, EventArgs e)
        {
            SidePanel.Height = btnHistory.Height;
            SidePanel.Top = btnHistory.Top;
        }

        private void btnLogOut_MouseHover(object sender, EventArgs e)
        {
            SidePanel.Height = btnLogOut.Height;
            SidePanel.Top = btnLogOut.Top;
        }
    }
    }

