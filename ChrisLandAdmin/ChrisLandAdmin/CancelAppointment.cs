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

namespace ChrisLandAdmin
{
    public partial class CancelAppointment : Form
    {
        string constring = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
        public CancelAppointment()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "Connected as Admin";
        }

        private void CancelAppointment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'visitor_managerDataSet5.scheduled_appointments' table. You can move, or remove it, as needed.
            this.scheduled_appointmentsTableAdapter.Fill(this.visitor_managerDataSet5.scheduled_appointments);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection cn = new MySqlConnection(constring))
            {
                cn.Open();

                string sql = "select * from scheduled_appointments where fullname like '%" + fullname.Text + "%'";
                try
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(sql, cn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();

                string sql = "select * from scheduled_appointments where id = '"+this.id.Text+"'";
                using (MySqlDataAdapter da = new MySqlDataAdapter(sql, con))
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        private void cancelAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
                id.Text = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
            }
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            using (MySqlConnection cn = new MySqlConnection(constring))
            {
                cn.Open();
                string sql = "delete from scheduled_appointments where id ='" + this.id.Text + "'";
                using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                {
                    try
                    {
                        var msg = MessageBox.Show("You are about to Cancel An Appointment" + Environment.NewLine + "Are You sure you want to Cancel?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (msg == DialogResult.Yes)
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Appointment Cancelled!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else if (msg == DialogResult.No)
                        {
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }
    }
}
