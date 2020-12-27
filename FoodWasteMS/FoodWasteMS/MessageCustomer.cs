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
    public partial class MessageCustomer : Form
    {

        string constr = "DATA SOURCE=DESKTOP-K8R8LDS:1521/XE;USER ID=SYSTEM;password=123";

        public MessageCustomer()
        {
            InitializeComponent();
            fill_listBox();
        }

        void fill_listBox()
        {
            listBox1.Items.Clear();
            OracleConnection con = new OracleConnection(constr);

            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select mes from messagepass";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                listBox1.Items.Add(dr["mes"].ToString());
            }
            con.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            OracleConnection con = new OracleConnection(constr);

            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from messagepass where mes ='"+listBox1.SelectedItem.ToString()+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                txtboxDel.Text= dr["mes"].ToString();
            }
            con.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(constr);

            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from messagepass where mes ='" + txtboxDel.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted");
            txtboxDel.Text = "";
            fill_listBox();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
