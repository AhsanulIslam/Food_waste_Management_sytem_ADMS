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
    public partial class userMgr : UserControl
    {

        string constr = "DATA SOURCE=DESKTOP-K8R8LDS:1521/XE;USER ID=SYSTEM;password=123";

        public userMgr()
        {
            InitializeComponent();
            loadGridview();
        }
        void loadGridview()
        {
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            OracleDataAdapter oda = new OracleDataAdapter("select * from log_add", con);
            DataTable dt = new DataTable();

            this.dgvmgr.AutoGenerateColumns = false;
            oda.Fill(dt);
            dgvmgr.DataSource = dt;

            con.Close();
        }

        private void userMgr_Load(object sender, EventArgs e)
        {
            dgvmgr.BorderStyle = BorderStyle.None;
            dgvmgr.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvmgr.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvmgr.DefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 25, 72);
            dgvmgr.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvmgr.BackgroundColor = Color.White;

            dgvmgr.EnableHeadersVisualStyles = false;
            dgvmgr.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvmgr.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            dgvmgr.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
