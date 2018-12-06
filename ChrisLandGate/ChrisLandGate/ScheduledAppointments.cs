using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ChrisLandGate
{
    public partial class ScheduledAppointments : Form
    {
        string constring = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
        public ScheduledAppointments()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "Connected as Gate";
        }

        private void ScheduledAppointments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'visitor_managerDataSet4.scheduled_appointments' table. You can move, or remove it, as needed.
            this.scheduled_appointmentsTableAdapter.Fill(this.visitor_managerDataSet4.scheduled_appointments);
        }

        private void confirmAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                 id.Text = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
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
                pictureBox1.Image = byteArrayToImage((byte[])dataGridView1.CurrentRow.Cells[12].Value);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private Image byteArrayToImage(byte[] byteArray)
        {
            MemoryStream ms = new MemoryStream(byteArray);
            Image img = Image.FromStream(ms);
            return img;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void confirmAppointmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Camera cm = new Camera();
            cm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id.Text = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string sql = "insert into final_appointments(visit_time,visit_date,fullname,visitor_address,visitor_city,visitor_telephone,id_method,organization,visit_type,reason,person_visit,img) values(@visit_time,@visit_date,@fullname,@visitor_address,@visitor_city,@visitor_telephone,@id_method,@organization,@visit_type,@reason,@person_visit,@img)";
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byte[] img = ms.ToArray();

                    string Date = Convert.ToDateTime(visit_date.Text).ToString("yyyy-MM-dd");
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
                    cmd.Parameters.AddWithValue("@img", img);

                    var msg = MessageBox.Show("You are about to Confirm Information" + Environment.NewLine + "Are you sure you want to do this?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Appointment Confirmed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }

                        string sql2 = "delete from scheduled_appointments where id ='"+id.Text+"'";
                        using (MySqlCommand cmd2 = new MySqlCommand(sql2, con))
                        {
                            cmd2.ExecuteNonQuery();
                            Close();
                        }
                    }//Yay! Its working 100% I did it :D 
                }
            }
        }
    }
}
