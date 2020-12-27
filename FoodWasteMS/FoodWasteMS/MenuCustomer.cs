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
using System.Data.SqlClient;

namespace FoodWasteMS
{
    public partial class MenuCustomer : Form
    {
        string constr = "DATA SOURCE=DESKTOP-K8R8LDS:1521/XE;USER ID=SYSTEM;password=123";

        private Login F1 { get; set; }

        public MenuCustomer(string username, string type, Login f1)
        {
            InitializeComponent();

            this.lbluser.Text = username;
            //this.lbltype.Text = type;
            this.F1 = f1;

            OracleConnection con = new OracleConnection(constr);

            con.Open();
            string q1 = "select * from customer where cust_uname ='" + username + "'";
            OracleCommand oc = new OracleCommand(q1, con);
            OracleDataReader odr = oc.ExecuteReader();
            if (odr.Read())
            {
                lblfullname.Text = (odr["cust_fname"].ToString());
                lblid.Text = (odr["cust_id"].ToString());
                lblphone.Text = (odr["cust_phone"].ToString());
                lbladdress.Text = (odr["cust_address"].ToString());
            }
            con.Close();
        }

        private void btnreadWater_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("A colourless, transparent, \nodourless liquid that formsthe seas, \nlakes, rivers, and rain and is the basis \nof the fluids of living organisms.", btnreadWater);

        }

        private void btnreadBiscut_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("A small baked unleavened cake, \ntypically crisp, flat, and sweet.", btnreadBiscut);

        }

        private void btnreadSoft_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("A soft drink is a drink that usually \ncontains carbonated water, a sweetener, \nand a natural or artificial flavoring. \nThe sweetener may be a sugar, \nhigh-fructose corn syrup, fruit juice, \na sugar substitute, or some combination of these", btnreadSoft);

        }

        private void btnreadCake_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("An item of soft sweet food made \nfrom a mixture of flour, fat, eggs, sugar, \nand other ingredients, baked and sometimes \niced or decorated.", btnreadCake);

        }

        private void btnread_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("A very thin, long strip \nof pasta or a similar flour paste, \neaten with a sauce or in a soup.", btnread);

        }

        private void btnpasta_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("a dish originally from Italy \nconsisting of dough made from \ndurum wheat and water,\n extruded or stamped into various shapes \nand typically cooked in boiling water.", btnpasta);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Login l = new Login();
            l.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            customerChooseitemSoftDrink n = new customerChooseitemSoftDrink(lblid.Text, lblfullname.Text);
            n.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            customerChooseItemCake c = new customerChooseItemCake(lblid.Text,lblfullname.Text);
            c.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
            Login l = new Login();
            l.Show();
        }

        private void MenuCustomer_Load(object sender, EventArgs e)
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

        private void button12_Click(object sender, EventArgs e)
        {
            MessageCustomer m = new MessageCustomer();
            m.Show();
            
        }

        private void btnLogHistory_Click(object sender, EventArgs e)
        {
            OrderListForCust o = new OrderListForCust(lbluser.Text,this);
            o.Show();
        }

        private void button12_MouseHover(object sender, EventArgs e)
        {
            SidePanel.Height = btnLogHistory.Height;
            SidePanel.Top = btnLogHistory.Top;
        }

        private void btnLogHistory_MouseHover(object sender, EventArgs e)
        {
            SidePanel.Height = btnLogHistory.Height;
            SidePanel.Top = btnLogHistory.Top;
        }

        private void btnLogOut_MouseMove(object sender, MouseEventArgs e)
        {
            SidePanel.Height = btnLogOut.Height;
            SidePanel.Top = btnLogOut.Top;
        }

        private void btnInbox_MouseMove(object sender, MouseEventArgs e)
        {
            SidePanel.Height = btnInbox.Height;
            SidePanel.Top = btnInbox.Top;
        }
    }
}
