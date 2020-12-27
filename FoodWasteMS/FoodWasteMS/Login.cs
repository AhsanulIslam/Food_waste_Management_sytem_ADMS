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
using System.Configuration;
//using System.Data.OracleClient;
using System.Data.SqlClient;

namespace FoodWasteMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        string constr = "DATA SOURCE=DESKTOP-K8R8LDS:1521/XE;USER ID=SYSTEM;password=123";

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        

        private void clickshow_CheckedChanged(object sender, EventArgs e)
        {
              if(clickshow.Checked)
            {
                txtpassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            log();
        }

        private void log()
        {
            string userName = txtUser.Text.ToString();
            string password = txtpassword.Text.ToString();
            string cmbType = cmbUsertype.Text.ToString();

            OracleConnection con = new OracleConnection(constr);
        
            con.Open();
           
           
          /* string query = "Select count(*) From login where username ='" + userName + "' and password ='" + password + "'and usertype  ='" + cmbType + "'";
            string query2 = "Select usertype From login where username='" + userName + "' and password ='" + password + "'";

            OracleDataAdapter oda = new OracleDataAdapter(query,con);
            DataTable dt = new DataTable();
            oda.Fill(dt);

           
                if (dt.Rows[0][0].ToString() == "1")
                {
                    OracleDataAdapter oda1 = new OracleDataAdapter(query2, con);
                    DataTable dt1 = new DataTable();
                    oda1.Fill(dt1);
                    if (dt1.Rows[0][0].ToString() == "Delivery Boy")
                    {
                        this.Hide();
                        MenuDeliveryBoy m = new MenuDeliveryBoy(this.txtUser.Text, this.cmbUsertype.Text, this);
                        m.Show();
                    }
                }
                */

                string q11 = "select count(*) from manager where mgr_uname ='" + userName + "' and password ='" + password + "'";
                OracleDataAdapter oda22 = new OracleDataAdapter(q11, con);
                DataTable dt22 = new DataTable();
                oda22.Fill(dt22);
               //OracleCommand cmd = new OracleCommand("select mgr_uname from manager",con);
              // OracleDataReader dr = cmd.ExecuteReader();
             //  AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();
              // while (dr.Read())
              // {
              //     mycollection.Add(dr.GetString(0));
              // }
                if (dt22.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    MenuManager m = new MenuManager(this.txtUser.Text, this.cmbUsertype.Text, this);
                    m.Show();
                }
             //  else if (dt22.Rows[0][0].ToString() == "0")
        //    {
        //        MessageBox.Show("Not Correct");
        //    }


                string q1 = "select count(*) from shopkeeper where shpkper_uname ='" + userName + "' and password ='" + password + "'";
                OracleDataAdapter oda2 = new OracleDataAdapter(q1, con);
                DataTable dt2 = new DataTable();
                oda2.Fill(dt2);

                if (dt2.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    MenuShopkeepers m = new MenuShopkeepers(this.txtUser.Text, this);
                    m.Show();
                }




                string q2 = "select count(*) from Customer where cust_uname ='" + userName + "' and password ='" + password + "'";
                OracleDataAdapter oda3 = new OracleDataAdapter(q2, con);
                DataTable dt3 = new DataTable();
                oda3.Fill(dt3);

                if (dt3.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    MenuCustomer m = new MenuCustomer(this.txtUser.Text, this.cmbUsertype.Text, this);
                    m.Show();
                }

            string q5 = "select count(*) from DELIVERYBOY where DELBOY_UNAME ='" + userName + "' and password ='" + password + "'";
            OracleDataAdapter oda5 = new OracleDataAdapter(q5, con);
            DataTable dt5 = new DataTable();
            oda5.Fill(dt5);

            if (dt5.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                MenuDeliveryBoy m = new MenuDeliveryBoy(this.txtUser.Text, this.cmbUsertype.Text, this);
                m.Show();
            }


            con.Close();

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            signUp s = new signUp();
            s.Show();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=" + txtboxSearch.Text);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/");

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=" + txtboxSearch.Text);

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/");
        }

        
        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        

        private void txtboxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                System.Diagnostics.Process.Start("https://www.google.com/search?q=" + txtboxSearch.Text);
                btnsearch.PerformClick();
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=" + txtboxSearch.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        
           
}
    
}
/*
  
*/