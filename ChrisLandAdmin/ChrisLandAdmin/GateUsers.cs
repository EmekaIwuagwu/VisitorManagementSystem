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

namespace ChrisLandAdmin
{
    public partial class GateUsers : Form
    {
        string constring = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
        public GateUsers()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "Connected as Admin";
        }

        private void GateUsers_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                try
                {
                    string sql = "insert into vms_gateusers (userid,password,password2,fullname) values (@userid,@password,@password2,@fullname)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@userid", userid.Text);
                        cmd.Parameters.AddWithValue("@password", password.Text);
                        cmd.Parameters.AddWithValue("@password2", password2.Text);
                        cmd.Parameters.AddWithValue("@fullname", fullname.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registeration Complete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
