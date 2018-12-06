using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace ChrisLandGate
{
    public partial class Login : Form
    {
        string constring = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
        public Login()
        {
            Thread t = new Thread(new ThreadStart(Splash));
            t.Start();
            InitializeComponent();

            string str = string.Empty;
            for (int i = 0; i < 50000; i++)
            {
                str += i.ToString();
            }
            t.Abort();
        }

        private void Splash()
        {
            SplashScreen.SplashForm frm = new SplashScreen.SplashForm();
            frm.AppName = "GatePass™";
            Application.Run(frm);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();
                string sql = "select userid,password from vms_gateusers where userid = '" + userid.Text + "' and password = '" + password.Text + "' ";
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        frmMain frm = new frmMain();
                        LodgeReport();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username and Password", "Failed Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LodgeReport()
        {
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                DateTime localDate = DateTime.Now;
                string date = System.DateTime.Now.ToString("yyyy-MM-dd");
                string data = "Login Successful using username As : '" + userid.Text + "' by '" + localDate + "' Today: '" + date + "'";
                string sql = "insert into visitor_managerreports(data,date)values(@data,@date)";
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    try
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@data", data);
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.ExecuteNonQuery();
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
