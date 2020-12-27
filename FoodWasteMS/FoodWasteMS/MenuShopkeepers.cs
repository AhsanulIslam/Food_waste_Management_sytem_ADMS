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
    public partial class MenuShopkeepers : Form
    {
        string constr = "DATA SOURCE=DESKTOP-K8R8LDS:1521/XE;USER ID=SYSTEM;password=123";
        
        private Login F1 { get; set;  }

        public MenuShopkeepers()
        {
            InitializeComponent();
        }

        public MenuShopkeepers(string username, Login f1)
        {
            InitializeComponent();
            this.lbluser.Text = username;
          
            this.F1 = f1;
            OracleConnection con = new OracleConnection(constr);

            con.Open();
            string q1 = "select * from shopkeeper where shpkper_uname ='"+username+"'";
            OracleCommand oc = new OracleCommand(q1, con);
            OracleDataReader odr = oc.ExecuteReader();
            if (odr.Read())
            {
                lblfullname.Text = (odr["shpkper_fname"].ToString());
                lblid.Text = (odr["shpkper_id"].ToString());
                lblphone.Text = (odr["shpkper_phone"].ToString());
                lbladdress.Text = (odr["shpkper_address"].ToString());
            }
            con.Close();

            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("A colourless, transparent, \nodourless liquid that formsthe seas, \nlakes, rivers, and rain and is the basis \nof the fluids of living organisms.",btnreadWater);
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("A small baked unleavened cake, \ntypically crisp, flat, and sweet.", btnreadBiscut);
        }

        private void btnreadSoft_MouseHover(object sender, EventArgs e)
        {
             toolTip1.Show("A soft drink is a drink that usually \ncontains carbonated water, a sweetener, \nand a natural or artificial flavoring. \nThe sweetener may be a sugar, \nhigh-fructose corn syrup, fruit juice, \na sugar substitute, or some combination of these",btnreadSoft);
        }

        private void btnreadMilk_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("An opaque white fluid \nrich in fat and protein, secreted \nby female mammals for the nourishment \nof their young.", btnreadMilk);
        }

        private void button2_MouseHover_1(object sender, EventArgs e)
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

        private void btnChooseCake_Click(object sender, EventArgs e)
        {
            shopkeeperChooseItemCake ca = new shopkeeperChooseItemCake(this.lblid.Text,this.lblfullname.Text,this);
            ca.Show();
        }

        private void btnChooseSoftDrink_Click(object sender, EventArgs e)
        {
            shopkeeperchooseSoftDrink soft = new shopkeeperchooseSoftDrink(lblid.Text, this.lblfullname.Text, this);
            soft.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // shopkeeperchooseSoftDrink s = new shopkeeperchooseSoftDrink(lblid.Text, this);
           // s.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelOrderShopkeeper cancelOrderShopkeeper = new CancelOrderShopkeeper(this.lblid.Text,this);
            cancelOrderShopkeeper.Show();
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            ViewOrderShopkeeper v = new ViewOrderShopkeeper(lblid.Text,lblfullname.Text,lbladdress.Text,lblphone.Text,this);
            v.Show();
        }

        private void MenuShopkeepers_Load(object sender, EventArgs e)
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

        private void btnLogOut_MouseHover(object sender, EventArgs e)
        {
            SidePanel.Height = btnLogOut.Height;
            SidePanel.Top = btnLogOut.Top;
        }

        private void btnCancel_MouseHover(object sender, EventArgs e)
        {
            SidePanel.Height = btnCancel.Height;
            SidePanel.Top = btnCancel.Top;
        }

        private void btnViewOrder_MouseHover(object sender, EventArgs e)
        {
            SidePanel.Height = btnViewOrder.Height;
            SidePanel.Top = btnViewOrder.Top;
        }
    }
}
