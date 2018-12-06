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

namespace ChrisLandGate
{
    public partial class VisitingDaysCheck : Form
    {
        string constring = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
        public VisitingDaysCheck()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "Connected as Gate";
        }

        private void VisitingDaysCheck_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Camera cm = new Camera();
            cm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection cn = new MySqlConnection(constring))
            {
                cn.Open();

                string sql = "select * from guardian_info where uniqueNum ='"+textBox1.Text+"'  ";
                using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        try
                        {
                            if (rdr.Read())
                            {

                                /*uniqueNum.Text = (rdr["uniqueNum"].ToString());
                                fullname.Text = (rdr["fullname"].ToString());
                                address.Text = (rdr["address"].ToString());
                                city.Text = (rdr["city"].ToString());
                                telephone.Text = (rdr["telephone"].ToString());
                                vehicleNo.Text = (rdr["vehicleNo"].ToString());
                                id_method.Text = (rdr["id_method"].ToString());
                                ward_name.Text = (rdr["ward_name"].ToString());
                                ward_class.Text = (rdr["ward_class"].ToString());
                                ward_house.Text = (rdr["ward_house"].ToString());
                                house_master.Text = (rdr["house_master"].ToString());
                                housemaster_tel.Text = (rdr["housemaster_tel"].ToString());
                                no_accPeople.Text = (rdr["no_accPeople"].ToString());
                              */

                                uniqueNum.Text = rdr.GetString("uniqueNum");
                                fullname.Text = rdr.GetString("fullname");
                                address.Text = rdr.GetString("address");
                                city.Text = rdr.GetString("city");
                                telephone.Text = rdr.GetString("telephone");
                                vehicleNo.Text = rdr.GetString("vehicleNo");
                                id_method.Text = rdr.GetString("id_method");
                                ward_name.Text = rdr.GetString("ward_name");
                                ward_class.Text = rdr.GetString("ward_class");
                                ward_house.Text = rdr.GetString("ward_house");
                                house_master.Text = rdr.GetString("house_master");
                                housemaster_tel.Text = rdr.GetString("housemaster_tel");
                                no_accPeople.Text = rdr.GetString("no_accPeople");
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

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int x = 100, y = 100; //start position

            Image newImage = Image.FromFile("logo.png");
            int width = 150, height = 70;
            int ix = x, iy = y; //image position
            e.Graphics.DrawImage(newImage, ix, iy, width, height);

            x += 0; //left align texts with logo image
            y += height + 30; //some space below logo

            var header = new Font("Calibri", 21, FontStyle.Bold);
            int hdy = (int)header.GetHeight(e.Graphics); //30; //line height spacing

            var fnt = new Font("Times new Roman", 14, FontStyle.Bold);
            int dy = (int)fnt.GetHeight(e.Graphics); //20; //line height spacing

            e.Graphics.DrawString("Visitor GatePass™", header, Brushes.Black, new PointF(x, y)); y += hdy;
            e.Graphics.DrawString("Unique Number : " + uniqueNum.Text, fnt, Brushes.Black, new PointF(x, y)); y += dy;
            e.Graphics.DrawString("Full Name : " + fullname.Text, fnt, Brushes.Black, new PointF(x, y)); y += dy;
            e.Graphics.DrawString("Method of Identification : " + id_method.Text, fnt, Brushes.Black, new PointF(x, y)); y += dy;
            e.Graphics.DrawString("Ward Name : " + ward_name.Text, fnt, Brushes.Black, new PointF(x, y)); y += dy;
            e.Graphics.DrawString("Ward Class : " + ward_class.Text, fnt, Brushes.Black, new PointF(x, y)); y += dy;
            e.Graphics.DrawString("Ward House : " + ward_house.Text, fnt, Brushes.Black, new PointF(x, y)); y += dy;
            e.Graphics.DrawString("House Master : " + house_master.Text, fnt, Brushes.Black, new PointF(x, y)); y += dy;
            e.Graphics.DrawString("Accompanying People : " + no_accPeople.Text, fnt, Brushes.Black, new PointF(x, y)); y += dy;
        }
    }
}
