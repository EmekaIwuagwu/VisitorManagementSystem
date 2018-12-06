using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChrisLandAdmin
{
    public partial class GateUserReports : Form
    {
        public GateUserReports()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "Connected as Admin";
        }

        private void GateUserReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GateReports.visitor_managerreports' table. You can move, or remove it, as needed.
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.visitor_managerreportsTableAdapter.Fill(this.GateReports.visitor_managerreports, Convert.ToDateTime(dateFrom.Text), Convert.ToDateTime(dateTo.Text));
            this.reportViewer1.RefreshReport();
        }
    }
}
