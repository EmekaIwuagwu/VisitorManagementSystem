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
    public partial class RegisterGuardian : Form
    {
        string constring = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
        public RegisterGuardian()
        {
            InitializeComponent();
            label10.Text = "House Master /" +Environment.NewLine +"Mistress Name :";
            toolStripStatusLabel1.Text = "Connected as Admin";
        }

        private void RegisterGuardian_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

     /*   public string UniqueNumber()
        {
            string uniqueNum;
            Random rand = new Random();
            string text = "CHRISLAND";
            string fulltext = text + rand.Next(1, 900);
            uniqueNum = fulltext;
            return uniqueNum;
        }

        */

        private void button1_Click(object sender, EventArgs e)
        {
            if (fullname.Text == "")
            {
                MessageBox.Show("Full Name cannot be Left Blank!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            else if (address.Text == "")
            {
                MessageBox.Show("Address Feild Cannot be Left Blank", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (vehicleNo.Text == "")
            {
                MessageBox.Show("Vehicle Number Cannot be Left Blank", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (no_accPeople.Text == "")
            {
                MessageBox.Show("Number of Accompanying People Cannot be Left Blank", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (ward_name.Text == "")
            {
                MessageBox.Show("Ward Name cannot be Left Blank!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (ward_house.Text == "")
            {
                MessageBox.Show("Ward House cannot be Left Blank!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (ward_class.Text == "")
            {
                MessageBox.Show("Ward Class cannot be Left Blank!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (house_master.Text == "")
            {
                MessageBox.Show("House Master cannot be Left Blank!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (housemaster_tel.Text == "")
            {
                MessageBox.Show("House Master Number cannot be Left Blank!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            else
            {
                using (MySqlConnection cn = new MySqlConnection(constring))
                {
                    cn.Open();
                    string sql = "insert into guardian_info(fullname,address,city,telephone,vehicleNo,no_accPeople,ward_name,ward_house,ward_class,house_master,housemaster_tel,uniqueNum,id_method) values(@fullname,@address,@city,@telephone,@vehicleNo,@no_accPeople,@ward_name,@ward_house,@ward_class,@house_master,@housemaster_tel,@uniqueNum,@id_method)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        try
                        {
                            string uniqueNum;
                            Random rand = new Random();
                            string text = "CHRISLAND";
                            string fulltext = text + rand.Next(1, 900);
                            uniqueNum = fulltext;

                            cmd.Parameters.AddWithValue("@fullname", fullname.Text);
                            cmd.Parameters.AddWithValue("@address", address.Text);
                            cmd.Parameters.AddWithValue("@city", city.Text);
                            cmd.Parameters.AddWithValue("@telephone", telephone.Text);
                            cmd.Parameters.AddWithValue("@vehicleNo", vehicleNo.Text);
                            cmd.Parameters.AddWithValue("@no_accPeople", no_accPeople.Text);
                            cmd.Parameters.AddWithValue("@ward_name", ward_name.Text);
                            cmd.Parameters.AddWithValue("@ward_house", ward_house.Text);
                            cmd.Parameters.AddWithValue("@ward_class", ward_class.Text);
                            cmd.Parameters.AddWithValue("@house_master", house_master.Text);
                            cmd.Parameters.AddWithValue("@housemaster_tel", housemaster_tel.Text);
                            cmd.Parameters.AddWithValue("@uniqueNum", uniqueNum);
                            cmd.Parameters.AddWithValue("@id_method", id_method.Text);

                            var msg = MessageBox.Show("You are about to Register a New Guardian " + Environment.NewLine + "Please Re-Confirm Information Again, are You sure You want to Continue? ", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (msg == DialogResult.Yes)
                            {
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Registeration Complete "+Environment.NewLine+" Visitor Unique ID is : '"+ uniqueNum + "'", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
}
