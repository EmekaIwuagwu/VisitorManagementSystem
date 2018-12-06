namespace ChrisLandAdmin
{
    partial class ScheduleAppointment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.person_visit = new System.Windows.Forms.ComboBox();
            this.staffnamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitor_managerDataSet3 = new ChrisLandAdmin.visitor_managerDataSet3();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.reason = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.visit_type = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.organization = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.id_method = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.visitor_telephone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.visitor_city = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.visitor_address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fullname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.staff_namesTableAdapter = new ChrisLandAdmin.visitor_managerDataSet3TableAdapters.staff_namesTableAdapter();
            this.label11 = new System.Windows.Forms.Label();
            this.visit_date = new System.Windows.Forms.DateTimePicker();
            this.visit_time = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffnamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitor_managerDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 443);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(619, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "&Schedule Appointment";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.visit_time);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.visit_date);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.person_visit);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.reason);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.visit_type);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.organization);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.id_method);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.visitor_telephone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.visitor_city);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.visitor_address);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.fullname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 360);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // person_visit
            // 
            this.person_visit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.staffnamesBindingSource, "names", true));
            this.person_visit.DataSource = this.staffnamesBindingSource;
            this.person_visit.DisplayMember = "names";
            this.person_visit.FormattingEnabled = true;
            this.person_visit.Location = new System.Drawing.Point(389, 148);
            this.person_visit.Name = "person_visit";
            this.person_visit.Size = new System.Drawing.Size(180, 21);
            this.person_visit.TabIndex = 25;
            this.person_visit.ValueMember = "names";
            // 
            // staffnamesBindingSource
            // 
            this.staffnamesBindingSource.DataMember = "staff_names";
            this.staffnamesBindingSource.DataSource = this.visitor_managerDataSet3;
            // 
            // visitor_managerDataSet3
            // 
            this.visitor_managerDataSet3.DataSetName = "visitor_managerDataSet3";
            this.visitor_managerDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(25, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 34);
            this.button3.TabIndex = 24;
            this.button3.Text = "Lodge Information";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(177, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 34);
            this.button2.TabIndex = 23;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(302, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Whom to See";
            // 
            // reason
            // 
            this.reason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reason.Location = new System.Drawing.Point(389, 108);
            this.reason.Name = "reason";
            this.reason.Size = new System.Drawing.Size(180, 21);
            this.reason.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(317, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Reason:";
            // 
            // visit_type
            // 
            this.visit_type.FormattingEnabled = true;
            this.visit_type.Items.AddRange(new object[] {
            "Please Select",
            "Official",
            "Personal",
            "Emergency"});
            this.visit_type.Location = new System.Drawing.Point(389, 69);
            this.visit_type.Name = "visit_type";
            this.visit_type.Size = new System.Drawing.Size(180, 21);
            this.visit_type.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(309, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Visit Type:";
            // 
            // organization
            // 
            this.organization.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organization.Location = new System.Drawing.Point(389, 33);
            this.organization.Name = "organization";
            this.organization.Size = new System.Drawing.Size(180, 21);
            this.organization.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(293, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Organization";
            // 
            // id_method
            // 
            this.id_method.FormattingEnabled = true;
            this.id_method.Items.AddRange(new object[] {
            "Please Select",
            "ID Card ",
            "Passport",
            "Voters Card",
            "National ID Card"});
            this.id_method.Location = new System.Drawing.Point(96, 222);
            this.id_method.Name = "id_method";
            this.id_method.Size = new System.Drawing.Size(180, 21);
            this.id_method.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "ID Method:";
            // 
            // visitor_telephone
            // 
            this.visitor_telephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitor_telephone.Location = new System.Drawing.Point(96, 192);
            this.visitor_telephone.Name = "visitor_telephone";
            this.visitor_telephone.Size = new System.Drawing.Size(180, 21);
            this.visitor_telephone.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telephone :";
            // 
            // visitor_city
            // 
            this.visitor_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitor_city.Location = new System.Drawing.Point(96, 164);
            this.visitor_city.Name = "visitor_city";
            this.visitor_city.Size = new System.Drawing.Size(180, 21);
            this.visitor_city.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "City :";
            // 
            // visitor_address
            // 
            this.visitor_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitor_address.Location = new System.Drawing.Point(96, 67);
            this.visitor_address.Multiline = true;
            this.visitor_address.Name = "visitor_address";
            this.visitor_address.Size = new System.Drawing.Size(180, 82);
            this.visitor_address.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address:";
            // 
            // fullname
            // 
            this.fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullname.Location = new System.Drawing.Point(96, 30);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(180, 21);
            this.fullname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Full name :";
            // 
            // staff_namesTableAdapter
            // 
            this.staff_namesTableAdapter.ClearBeforeFill = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(298, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "SignIn Date";
            // 
            // visit_date
            // 
            this.visit_date.Location = new System.Drawing.Point(377, 190);
            this.visit_date.Name = "visit_date";
            this.visit_date.Size = new System.Drawing.Size(200, 20);
            this.visit_date.TabIndex = 27;
            // 
            // visit_time
            // 
            this.visit_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visit_time.Location = new System.Drawing.Point(389, 228);
            this.visit_time.Name = "visit_time";
            this.visit_time.Size = new System.Drawing.Size(180, 21);
            this.visit_time.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(315, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 15);
            this.label12.TabIndex = 28;
            this.label12.Text = "Visit Time";
            // 
            // ScheduleAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 465);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScheduleAppointment";
            this.Text = "Schedule Appointment";
            this.Load += new System.EventHandler(this.ScheduleAppointment_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffnamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitor_managerDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox reason;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox visit_type;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox organization;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox id_method;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox visitor_telephone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox visitor_city;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox visitor_address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ComboBox person_visit;
        private visitor_managerDataSet3 visitor_managerDataSet3;
        private System.Windows.Forms.BindingSource staffnamesBindingSource;
        private visitor_managerDataSet3TableAdapters.staff_namesTableAdapter staff_namesTableAdapter;
        private System.Windows.Forms.DateTimePicker visit_date;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox visit_time;
        private System.Windows.Forms.Label label12;
    }
}