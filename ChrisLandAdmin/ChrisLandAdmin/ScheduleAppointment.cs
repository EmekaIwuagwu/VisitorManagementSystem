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
    public partial class ScheduleAppointment : Form
    {
        string constring = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
        public ScheduleAppointment()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "Connected as Admin";
            // string time = DateTime.Now.ToString("hh:mm tt");

            visit_time.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void ScheduleAppointment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'visitor_managerDataSet3.staff_names' table. You can move, or remove it, as needed.
            this.staff_namesTableAdapter.Fill(this.visitor_managerDataSet3.staff_names);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (fullname.Text == "")
            {
                MessageBox.Show("Fullname Cannot be Left Blank", "information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (visitor_address.Text == "")
            {
                MessageBox.Show("Address Field Cannot be Left Blank", "information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            else if (visitor_city.Text == "")
            {
                MessageBox.Show("City Cannot be Left Blank", "information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            else if (visitor_telephone.Text == "")
            {
                MessageBox.Show("Telephone Cannot be Left Blank", "information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            else if (id_method.Text == "")
            {
                MessageBox.Show("Method of Identification", "information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            else if (organization.Text == "")
            {
                MessageBox.Show("Organization Cannot be Left Blank", "information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (visit_type.Text == "")
            {

                MessageBox.Show("Visit Type Is Required!", "information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            else if (person_visit.Text == "")
            {
                MessageBox.Show("Person to Visit is Required!", "information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                using (MySqlConnection con = new MySqlConnection(constring))
                {
                    con.Open();
                    string sql = "insert into scheduled_appointments(visit_time,visit_date,fullname,visitor_address,visitor_city,visitor_telephone,id_method,organization,visit_type,reason,person_visit) values(@visit_time,@visit_date,@fullname,@visitor_address,@visitor_city,@visitor_telephone,@id_method,@organization,@visit_type,@reason,@person_visit)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        try
                        {
                            
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

                            var msg = MessageBox.Show("Please Confirm Information Again" + Environment.NewLine + "Are You sure Information is Correct?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (msg == DialogResult.Yes)
                            {
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Appointment Scheduled!", "New Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
