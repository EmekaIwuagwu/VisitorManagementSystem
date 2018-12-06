using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.IO;
using System.Diagnostics;

namespace ChrisLandGate
{
    public partial class frmMain : Form
    {
        string constring = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'visitor_managerDataSet3.final_appointments' table. You can move, or remove it, as needed.
            this.final_appointmentsTableAdapter.Fill(this.visitor_managerDataSet3.final_appointments);

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            toolStripStatusLabel1.Text = "Connected as Gate";

           // timer1.Start();
        }

        private void unscheduledAppointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnscheduledAppointments ua = new UnscheduledAppointments();
            ua.Show();
        }

        private void scheduledAppointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduledAppointments sa = new ScheduledAppointments();
            sa.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void visitingDaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitingDaysCheck vd = new VisitingDaysCheck();
            vd.Show();
        }

        public void refreshDb()
        {
            this.final_appointmentsTableAdapter.Fill(this.visitor_managerDataSet3.final_appointments);
        }

        private void signoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Signout signout = new Signout();
            signout.id.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            signout.visit_time.Text= this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            signout.visit_date.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            signout.fullname.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            signout.visitor_address.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            signout.visitor_city.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            signout.visitor_telephone.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            signout.id_method.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            signout.organization.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            signout.visit_type.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            signout.reason.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            signout.person_visit.Text = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();
            signout.pictureBox2.Image = byteArrayToImage((byte[])dataGridView1.CurrentRow.Cells[12].Value);
            signout.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            signout.pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            signout.ShowDialog();
        }

        private Image byteArrayToImage(byte[] byteArray)
        {
            MemoryStream ms = new MemoryStream(byteArray);
            Image img = Image.FromStream(ms);
            return img;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            refreshDb();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Camera cm = new Camera();
            cm.Show();
        }

        private void startInstantMessengerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
