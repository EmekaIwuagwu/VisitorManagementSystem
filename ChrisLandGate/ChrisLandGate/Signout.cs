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

namespace ChrisLandGate
{
    public partial class Signout : Form
    {
        string constring = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
        public Signout()
        {
            InitializeComponent();
        }

        private void Signout_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            toolStripStatusLabel1.Text = "Connected as Gate";
            signout_time.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection cn = new MySqlConnection(constring))
            {
                cn.Open();
                DateTime time = DateTime.Now;
                string sql = "update final_appointments set visit_time=@visit_time,visit_date=@visit_date,fullname=@fullname,visitor_address=@visitor_address,visitor_city=@visitor_city,visitor_telephone=@visitor_telephone,id_method=@id_method,organization=@organization,visit_type=@visit_type,reason=@reason,person_visit=@person_visit,signout_time=@signout_time where id=@id";
                using (MySqlCommand cmd = new MySqlCommand(sql,cn))
                {
                    var msg = MessageBox.Show("This would Confirm Signout for This visitor. " + Environment.NewLine + "Continue?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        try
                        {
                            string date = Convert.ToDateTime(visit_date.Text).ToString("yyyy-MM-dd");
                            cmd.Parameters.AddWithValue("@visit_time", visit_time.Text);
                            cmd.Parameters.AddWithValue("@visit_date", date);
                            cmd.Parameters.AddWithValue("@fullname", fullname.Text);
                            cmd.Parameters.AddWithValue("@visitor_address", visitor_address.Text);
                            cmd.Parameters.AddWithValue("@visitor_city", visitor_city.Text);
                            cmd.Parameters.AddWithValue("@visitor_telephone", visitor_telephone.Text);
                            cmd.Parameters.AddWithValue("@id_method", id_method.Text);
                            cmd.Parameters.AddWithValue("@organization", organization.Text);
                            cmd.Parameters.AddWithValue("@visit_type", visit_type.Text);
                            cmd.Parameters.AddWithValue("@reason", reason.Text);
                            cmd.Parameters.AddWithValue("@person_visit", person_visit.Text);
                            cmd.Parameters.AddWithValue("@id", id.Text);
                            cmd.Parameters.AddWithValue("@signout_time", signout_time.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Signout Confirmed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmMain frm = new frmMain();
                            frm.dataGridView1.Update();
                            frm.dataGridView1.Refresh();
                            Close();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
            }
        }
    }
}
