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
    public partial class userShopkeeper : UserControl
    {
        string constr = "DATA SOURCE=DESKTOP-K8R8LDS:1521/XE;USER ID=SYSTEM;password=123";
        public userShopkeeper()
        {
            InitializeComponent();
            loadGridview();
        }

        void loadGridview()
        {
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            OracleDataAdapter oda = new OracleDataAdapter("select * from shop_log_cancel_order", con);
            DataTable dt = new DataTable();

            this.dgvShop.AutoGenerateColumns = false;
            oda.Fill(dt);
            dgvShop.DataSource = dt;

            con.Close();
        }

        private void userShopkeeper_Load(object sender, EventArgs e)
        {
            dgvShop.BorderStyle = BorderStyle.None;
            dgvShop.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvShop.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvShop.DefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 25, 72);
            dgvShop.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvShop.BackgroundColor = Color.White;

            dgvShop.EnableHeadersVisualStyles = false;
            dgvShop.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvShop.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            dgvShop.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }
    }
}
