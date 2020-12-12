using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace FoodWasteMS
{
    public partial class User_Customer : UserControl
    {

        string constr = "DATA SOURCE=DESKTOP-Q3KCJHO:1521/XE;USER ID=SYSTEM;password=123";

        public User_Customer()
        {
            InitializeComponent();
            loadGridview();
        }

        void loadGridview()
        {
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            OracleDataAdapter oda = new OracleDataAdapter("select * from cust_order_log", con);
            DataTable dt = new DataTable();

            this.dgvCust.AutoGenerateColumns = false;
            oda.Fill(dt);
            dgvCust.DataSource = dt;
           
            con.Close();
        }

        private void User_Customer_Load(object sender, EventArgs e)
        {
            dgvCust.BorderStyle = BorderStyle.None;
            dgvCust.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvCust.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCust.DefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 25, 72);
            dgvCust.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvCust.BackgroundColor = Color.White;

            dgvCust.EnableHeadersVisualStyles = false;
            dgvCust.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCust.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            dgvCust.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
