using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAL_S_AUTOMOTIVE_SHOP
{
    public partial class frmLOGIN : Form
    {
        public frmLOGIN()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            this.Close();
            var frmDashboard = new frmDashboard();
            frmDashboard.Show();
        }
    }
}
