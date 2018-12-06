using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChrisLandAdmin
{
    public partial class frmMain : Form
    {
        public frmMain()
        {

            InitializeComponent();
            toolStripStatusLabel1.Text = "Connected as Admin";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'visitor_managerDataSet2.final_appointments' table. You can move, or remove it, as needed.
            this.final_appointmentsTableAdapter.Fill(this.visitor_managerDataSet2.final_appointments);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void scheduleAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleAppointment sa = new ScheduleAppointment();
            sa.Show();
        }

        private void rescheduleAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RescheduleAppointment ra = new RescheduleAppointment();
            ra.Show();
        }

        private void cancelAppointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelAppointment ca = new CancelAppointment();
            ca.Show();
        }

        private void registerGuardianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterGuardian rg = new RegisterGuardian();
            rg.Show();
        }

        private void registerGateUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GateUsers gu = new GateUsers();
            gu.Show();
        }

        private void visitingDaysToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registerAdminUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminUsers adm = new AdminUsers();
            adm.Show();
        }

        private void gateUserReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GateUserReports gate = new GateUserReports();
            gate.Show();
        }

        private void visitReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitReportsLog visit = new VisitReportsLog();
            visit.Show();
        }

        private void startInstantMessengerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*byte[] imwindow = Properties.Resources.ChatTestNowx;
            string dir = "C:\\IMserver";
            System.IO.Directory.CreateDirectory(dir);
            File.WriteAllBytes("C:\\IMserver\\ChatWindow.exe", imwindow);
            Process myp = new Process();
            myp.StartInfo.FileName = "ChatWindow.exe";
            myp.Start();*/

            Form1 frm1 = new Form1();
            frm1.Show(); 
        }
    }
}
