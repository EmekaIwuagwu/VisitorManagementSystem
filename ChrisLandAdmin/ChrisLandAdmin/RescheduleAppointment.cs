using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace ChrisLandAdmin
{
    public partial class RescheduleAppointment : Form
    {
        string constring = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
        public RescheduleAppointment()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "Connected as Admin";
        }

        private void RescheduleAppointment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'visitor_managerDataSet4.scheduled_appointments' table. You can move, or remove it, as needed.
            this.scheduled_appointmentsTableAdapter.Fill(this.visitor_managerDataSet4.scheduled_appointments);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void selectToRescheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string sql = "update scheduled_appointments set visit_time=@visit_time,visit_date=@visit_date,fullname=@fullname,visitor_address=@visitor_address,visitor_city=@visitor_city,visitor_telephone=@visitor_telephone,id_method=@id_method,organization=@organization,visit_type=@visit_type,reason=@reason,person_visit=@person_visit where id=@id";
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    try
                    {
                        string Date = Convert.ToDateTime(visit_date.Text).ToString("yyyy-MM-dd");
                        cmd.Parameters.AddWithValue("@id", ID.Text);
                        cmd.Parameters.AddWithValue("@visit_time", visit_time.Text);
                        cmd.Parameters.AddWithValue("@visit_date", Date);
                        cmd.Parameters.AddWithValue("@fullname", fullname.Text);
                        cmd.Parameters.AddWithValue("@visitor_address", visitor_address.Text);
                        cmd.Parameters.AddWithValue("@visitor_city", visitor_city.Text);
                        cmd.Parameters.AddWithValue("@visitor_telephone", visitor_telephone.Text);
                        cmd.Parameters.AddWithValue("@id_method", id_method.Text);
                        cmd.Parameters.AddWithValue("@organization", organization.Text);
                        cmd.Parameters.AddWithValue("@visit_type", visit_type.Text);
                        cmd.Parameters.AddWithValue("@reason", reason.Text);
                        cmd.Parameters.AddWithValue("@person_visit", person_visit.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Appointment Rescheduled", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.scheduled_appointmentsTableAdapter.Fill(this.visitor_managerDataSet4.scheduled_appointments);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ID.Text = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                visit_time.Text = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                visit_date.Text = dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                fullname.Text = dataGridView1.SelectedRows[0].Cells[3].Value + string.Empty;
                visitor_address.Text = dataGridView1.SelectedRows[0].Cells[4].Value + string.Empty;
                visitor_city.Text = dataGridView1.SelectedRows[0].Cells[5].Value + string.Empty;
                visitor_telephone.Text = dataGridView1.SelectedRows[0].Cells[6].Value + string.Empty;
                id_method.Text = dataGridView1.SelectedRows[0].Cells[7].Value + string.Empty;
                organization.Text = dataGridView1.SelectedRows[0].Cells[8].Value + string.Empty;
                visit_type.Text = dataGridView1.SelectedRows[0].Cells[9].Value + string.Empty;
                reason.Text = dataGridView1.SelectedRows[0].Cells[10].Value + string.Empty;
                person_visit.Text = dataGridView1.SelectedRows[0].Cells[11].Value + string.Empty;

            }
        }
    }
}
