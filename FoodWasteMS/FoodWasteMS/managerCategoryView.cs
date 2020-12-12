using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodWasteMS
{
    public partial class managerCategoryView : Form
    {
        MenuManager m { get; set; }
        public managerCategoryView(string n,string i, string p, string a,string u,MenuManager M)
        {
            InitializeComponent();
            lblfullname.Text = n;
            lbladdress.Text = a;
            lblid.Text = i;
            lblphone.Text = p;
            lbluser.Text = u;
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
