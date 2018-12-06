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

namespace ChrisLandGate
{
    public partial class UnscheduledAppointments : Form
    {
        string constring = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
        public UnscheduledAppointments()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "Connected as Gate";
        }

        private void UnscheduledAppointments_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            visit_time.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection cn = new MySqlConnection(constring))
            {
                cn.Open();

                string sql = "insert into final_appointments(visit_time,visit_date,fullname,visitor_address,visitor_city,visitor_telephone,id_method,organization,visit_type,reason,person_visit,img) values(@visit_time,@visit_date,@fullname,@visitor_address,@visitor_city,@visitor_telephone,@id_method,@organization,@visit_type,@reason,@person_visit,@img)";
                using (MySqlCommand cmd = new MySqlCommand(sql,cn))
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    DateTime tm = DateTime.Now;
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

                    var msg = MessageBox.Show("Please Confirm All information" + Environment.NewLine + "Are You sure you want to Confirm?", "infromation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Impromptu Appointment Scheduled","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Camera cm = new Camera();
            cm.Show();
        }
    }
}
