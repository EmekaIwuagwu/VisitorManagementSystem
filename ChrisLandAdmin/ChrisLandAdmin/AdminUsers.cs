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
    public partial class AdminUsers : Form
    {
        string constring = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
        public AdminUsers()
        {
            InitializeComponent();
        }

        private void AdminUsers_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection cn = new MySqlConnection(constring))
            {
                cn.Open();
                string sql = "insert into admin_login(userid,password,password2,fullname) values (@userid,@password,@password2,@fullname)";
                using (MySqlCommand cmd = new MySqlCommand(sql,cn))
                {
                    cmd.Parameters.AddWithValue("@userid",userid.Text);
                    cmd.Parameters.AddWithValue("@password", password.Text);
                    cmd.Parameters.AddWithValue("@password2", password2.Text);
                    cmd.Parameters.AddWithValue("@fullname", fullname.Text);

                    try
                    {
                        var msg = MessageBox.Show("Please Confirm Information", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if(msg == DialogResult.Yes)
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("User Registered", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
}
