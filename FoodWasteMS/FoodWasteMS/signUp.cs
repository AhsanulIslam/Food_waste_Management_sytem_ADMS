using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Oracle.ManagedDataAccess.Client;


namespace FoodWasteMS
{
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
        }
        string constr = "DATA SOURCE=DESKTOP-K8R8LDS:1521/XE;USER ID=SYSTEM;password=123";


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clickshow_CheckedChanged(object sender, EventArgs e)
        {
            if (clickshow.Checked)
            {
                txtpassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = false;
            }
        }

        void signupCustomer()
        {
            string type = cmbUsertype.Text.ToString();
            string fulname = txtboxFullname.Text.ToString();

            OracleConnection con = new OracleConnection(constr);
            OracleCommand cmd = new OracleCommand("signupCUst", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            try
            {
                cmd.Parameters.Add("cnm", OracleDbType.Varchar2, 50).Value = txtboxFullname.Text;
                cmd.Parameters.Add("cunm", OracleDbType.Varchar2, 50).Value = txtUser.Text;
                cmd.Parameters.Add("pas", OracleDbType.Varchar2, 50).Value = txtpassword.Text;
                cmd.Parameters.Add("phn", OracleDbType.Varchar2, 50).Value = txtphone.Text;
                cmd.Parameters.Add("add", OracleDbType.Varchar2, 50).Value = txtAddress.Text;
                

                cmd.ExecuteNonQuery();
                MessageBox.Show("Registation Successful " + fulname + " as a " + type + " !!", "Welcome");


            }
            catch (Exception ex)
            {

                System.Console.WriteLine("Exception: {0}", ex.ToString());
                con.Close();
            }
        }
        void signupShopkeeper()
        {
            string type = cmbUsertype.Text.ToString();
            string fulname = txtboxFullname.Text.ToString();

            OracleConnection con = new OracleConnection(constr);
            OracleCommand cmd = new OracleCommand("signupshopkeeper", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            try
            {
                cmd.Parameters.Add("snm", OracleDbType.Varchar2, 50).Value = txtboxFullname.Text;
                cmd.Parameters.Add("sunm", OracleDbType.Varchar2, 50).Value = txtUser.Text;
                cmd.Parameters.Add("pas", OracleDbType.Varchar2, 50).Value = txtpassword.Text;
                cmd.Parameters.Add("phn", OracleDbType.Varchar2, 50).Value = txtphone.Text;
                cmd.Parameters.Add("add", OracleDbType.Varchar2, 50).Value = txtAddress.Text;


                cmd.ExecuteNonQuery();
                MessageBox.Show("Registation Successful " + fulname + " as a " + type + " !!", "Welcome");

            }
            catch (Exception ex)
            {

                System.Console.WriteLine("Exception: {0}", ex.ToString());
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            OracleConnection con = new OracleConnection(constr);
           
                string fulname = txtboxFullname.Text.ToString();
                string userName = txtUser.Text.ToString();
                string password = txtpassword.Text.ToString();
                string phone = txtphone.Text.ToString();
                string address = txtAddress.Text.ToString();
              
                string type = cmbUsertype.Text.ToString();    


                con.Open();

                if (type == "Shopkeeper")
                {
                //  string query1 = "insert into Shopkeeper (shpkper_id,shpkper_fname ,shpkper_uname ,password ,shpkper_phone ,shpkper_address ) values(shopkeeper_seq.NEXTVAL,'" + fulname + "','" + userName + "','" + password + "','" + phone + "','" + address + "')";

                //  OracleDataAdapter oda = new OracleDataAdapter(query1, con);
                //  oda.SelectCommand.ExecuteNonQuery();
                signupShopkeeper();
                    txtboxFullname.Clear();
                    txtUser.Clear();
                    txtpassword.Clear();
                    txtphone.Clear();
                    txtAddress.Clear();


                   

                   
                }
                else if(type == "Customer")
                {

                //string query2 = "insert into Customer (cust_id, cust_fname, cust_uname ,password ,cust_phone, cust_address ) values (customer_seq.NEXTVAL,'" + fulname + "','" + userName + "','" + password + "','" + phone + "','" + address + "')";
                //
                //  OracleDataAdapter oda = new OracleDataAdapter(query2, con);
                //  oda.SelectCommand.ExecuteNonQuery();
                signupCustomer();
                        txtboxFullname.Clear();
                        txtUser.Clear();
                        txtpassword.Clear();
                        txtphone.Clear();
                        txtAddress.Clear();
                

                        
                 }
                else
                {
                    MessageBox.Show("Registation not Successful !!","Error");

                }   
                    

                
           
            con.Close();

        }
    }
}
