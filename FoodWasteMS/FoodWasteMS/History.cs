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
    public partial class History : Form
    {
        string constr = "DATA SOURCE=DESKTOP-K8R8LDS:1521/XE;USER ID=SYSTEM;password=123";

        public History()
        {
            InitializeComponent();
            SidePanel.Height = btnMgr.Height;
            SidePanel.Top = btnMgr.Top;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnCustomer.Height;
            SidePanel.Top = btnCustomer.Top;
            user_Customer1.BringToFront();
        }

        private void btnMgr_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnMgr.Height;
            SidePanel.Top = btnMgr.Top;
            userMgr1.BringToFront();
        }

        private void btnSHopkeeper_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnSHopkeeper.Height;
            SidePanel.Top = btnSHopkeeper.Top;
            userShopkeeper1.BringToFront();
        }

        private void btnDelboy_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnDelboy.Height;
            SidePanel.Top = btnDelboy.Top;
            userDelboy1.BringToFront();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
