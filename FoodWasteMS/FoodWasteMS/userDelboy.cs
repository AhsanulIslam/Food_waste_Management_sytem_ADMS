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
    public partial class userDelboy : UserControl
    {

        string constr = "DATA SOURCE=DESKTOP-Q3KCJHO:1521/XE;USER ID=SYSTEM;password=123";
        public userDelboy()
        {
            InitializeComponent();
            loadGridview();
        }

        void loadGridview()
        {
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            OracleDataAdapter oda = new OracleDataAdapter("select * from d_log", con);
            DataTable dt = new DataTable();

            this.dgvDel.AutoGenerateColumns = false;
            oda.Fill(dt);
            dgvDel.DataSource = dt;

            con.Close();
        }

        private void userDelboy_Load(object sender, EventArgs e)
        {
            dgvDel.BorderStyle = BorderStyle.None;
            dgvDel.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvDel.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDel.DefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 25, 72);
            dgvDel.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvDel.BackgroundColor = Color.White;

            dgvDel.EnableHeadersVisualStyles = false;
            dgvDel.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDel.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            dgvDel.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
