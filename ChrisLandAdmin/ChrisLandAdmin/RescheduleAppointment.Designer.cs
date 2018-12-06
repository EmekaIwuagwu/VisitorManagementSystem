namespace ChrisLandAdmin
{
    partial class RescheduleAppointment
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.visit_date = new System.Windows.Forms.DateTimePicker();
            this.ID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.visit_time = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.person_visit = new System.Windows.Forms.TextBox();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.visitor_managerDataSet4 = new ChrisLandAdmin.visitor_managerDataSet4();
            this.scheduledappointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scheduled_appointmentsTableAdapter = new ChrisLandAdmin.visitor_managerDataSet4TableAdapters.scheduled_appointmentsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visittimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitoraddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitorcityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitortelephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organizationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visittypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personvisitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitor_managerDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduledappointmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reschedule Appointment";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.visit_date);
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.visit_time);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.person_visit);
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
            this.groupBox1.Location = new System.Drawing.Point(16, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 180);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // visit_date
            // 
            this.visit_date.Location = new System.Drawing.Point(364, 148);
            this.visit_date.Name = "visit_date";
            this.visit_date.Size = new System.Drawing.Size(200, 20);
            this.visit_date.TabIndex = 34;
            // 
            // ID
            // 
            this.ID.Enabled = false;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(81, 145);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(60, 21);
            this.ID.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(50, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 15);
            this.label14.TabIndex = 32;
            this.label14.Text = "ID :";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(849, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 35);
            this.button2.TabIndex = 31;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(849, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 35);
            this.button1.TabIndex = 30;
            this.button1.Text = "Reschedule";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(277, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 15);
            this.label12.TabIndex = 28;
            this.label12.Text = "SignIn Date";
            // 
            // visit_time
            // 
            this.visit_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visit_time.Location = new System.Drawing.Point(660, 128);
            this.visit_time.Name = "visit_time";
            this.visit_time.Size = new System.Drawing.Size(180, 21);
            this.visit_time.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(573, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "SignIn Time:";
            // 
            // person_visit
            // 
            this.person_visit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.person_visit.Location = new System.Drawing.Point(660, 93);
            this.person_visit.Name = "person_visit";
            this.person_visit.Size = new System.Drawing.Size(180, 21);
            this.person_visit.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(573, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "Whom to See";
            // 
            // reason
            // 
            this.reason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reason.Location = new System.Drawing.Point(660, 56);
            this.reason.Name = "reason";
            this.reason.Size = new System.Drawing.Size(180, 21);
            this.reason.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(588, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Reason:";
            // 
            // visit_type
            // 
            this.visit_type.FormattingEnabled = true;
            this.visit_type.Items.AddRange(new object[] {
            "Please Select",
            "Official",
            "Unofficial"});
            this.visit_type.Location = new System.Drawing.Point(660, 24);
            this.visit_type.Name = "visit_type";
            this.visit_type.Size = new System.Drawing.Size(180, 21);
            this.visit_type.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(580, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Visit Type:";
            // 
            // organization
            // 
            this.organization.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organization.Location = new System.Drawing.Point(364, 111);
            this.organization.Name = "organization";
            this.organization.Size = new System.Drawing.Size(180, 21);
            this.organization.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(280, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 18;
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
            this.id_method.Location = new System.Drawing.Point(364, 78);
            this.id_method.Name = "id_method";
            this.id_method.Size = new System.Drawing.Size(180, 21);
            this.id_method.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(292, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID Method:";
            // 
            // visitor_telephone
            // 
            this.visitor_telephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitor_telephone.Location = new System.Drawing.Point(364, 48);
            this.visitor_telephone.Name = "visitor_telephone";
            this.visitor_telephone.Size = new System.Drawing.Size(180, 21);
            this.visitor_telephone.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(290, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Telephone :";
            // 
            // visitor_city
            // 
            this.visitor_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitor_city.Location = new System.Drawing.Point(364, 16);
            this.visitor_city.Name = "visitor_city";
            this.visitor_city.Size = new System.Drawing.Size(180, 21);
            this.visitor_city.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "City :";
            // 
            // visitor_address
            // 
            this.visitor_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitor_address.Location = new System.Drawing.Point(81, 53);
            this.visitor_address.Multiline = true;
            this.visitor_address.Name = "visitor_address";
            this.visitor_address.Size = new System.Drawing.Size(180, 82);
            this.visitor_address.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Address:";
            // 
            // fullname
            // 
            this.fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullname.Location = new System.Drawing.Point(81, 19);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(180, 21);
            this.fullname.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Full name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(959, 245);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Overview";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 589);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(983, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.textBox10);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(16, 502);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(395, 57);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(284, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(127, 21);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(156, 22);
            this.textBox10.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(30, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Search Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.visittimeDataGridViewTextBoxColumn,
            this.visitdateDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.visitoraddressDataGridViewTextBoxColumn,
            this.visitorcityDataGridViewTextBoxColumn,
            this.visitortelephoneDataGridViewTextBoxColumn,
            this.idmethodDataGridViewTextBoxColumn,
            this.organizationDataGridViewTextBoxColumn,
            this.visittypeDataGridViewTextBoxColumn,
            this.reasonDataGridViewTextBoxColumn,
            this.personvisitDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.scheduledappointmentsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(953, 226);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // visitor_managerDataSet4
            // 
            this.visitor_managerDataSet4.DataSetName = "visitor_managerDataSet4";
            this.visitor_managerDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scheduledappointmentsBindingSource
            // 
            this.scheduledappointmentsBindingSource.DataMember = "scheduled_appointments";
            this.scheduledappointmentsBindingSource.DataSource = this.visitor_managerDataSet4;
            // 
            // scheduled_appointmentsTableAdapter
            // 
            this.scheduled_appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // visittimeDataGridViewTextBoxColumn
            // 
            this.visittimeDataGridViewTextBoxColumn.DataPropertyName = "visit_time";
            this.visittimeDataGridViewTextBoxColumn.HeaderText = "Sign-in Time";
            this.visittimeDataGridViewTextBoxColumn.Name = "visittimeDataGridViewTextBoxColumn";
            // 
            // visitdateDataGridViewTextBoxColumn
            // 
            this.visitdateDataGridViewTextBoxColumn.DataPropertyName = "visit_date";
            this.visitdateDataGridViewTextBoxColumn.HeaderText = "Visit Date";
            this.visitdateDataGridViewTextBoxColumn.Name = "visitdateDataGridViewTextBoxColumn";
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "Full Name";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            // 
            // visitoraddressDataGridViewTextBoxColumn
            // 
            this.visitoraddressDataGridViewTextBoxColumn.DataPropertyName = "visitor_address";
            this.visitoraddressDataGridViewTextBoxColumn.HeaderText = "visitor_address";
            this.visitoraddressDataGridViewTextBoxColumn.Name = "visitoraddressDataGridViewTextBoxColumn";
            this.visitoraddressDataGridViewTextBoxColumn.Visible = false;
            // 
            // visitorcityDataGridViewTextBoxColumn
            // 
            this.visitorcityDataGridViewTextBoxColumn.DataPropertyName = "visitor_city";
            this.visitorcityDataGridViewTextBoxColumn.HeaderText = "visitor_city";
            this.visitorcityDataGridViewTextBoxColumn.Name = "visitorcityDataGridViewTextBoxColumn";
            this.visitorcityDataGridViewTextBoxColumn.Visible = false;
            // 
            // visitortelephoneDataGridViewTextBoxColumn
            // 
            this.visitortelephoneDataGridViewTextBoxColumn.DataPropertyName = "visitor_telephone";
            this.visitortelephoneDataGridViewTextBoxColumn.HeaderText = "Visitor Telephone";
            this.visitortelephoneDataGridViewTextBoxColumn.Name = "visitortelephoneDataGridViewTextBoxColumn";
            // 
            // idmethodDataGridViewTextBoxColumn
            // 
            this.idmethodDataGridViewTextBoxColumn.DataPropertyName = "id_method";
            this.idmethodDataGridViewTextBoxColumn.HeaderText = "ID Method";
            this.idmethodDataGridViewTextBoxColumn.Name = "idmethodDataGridViewTextBoxColumn";
            // 
            // organizationDataGridViewTextBoxColumn
            // 
            this.organizationDataGridViewTextBoxColumn.DataPropertyName = "organization";
            this.organizationDataGridViewTextBoxColumn.HeaderText = "Organization";
            this.organizationDataGridViewTextBoxColumn.Name = "organizationDataGridViewTextBoxColumn";
            // 
            // visittypeDataGridViewTextBoxColumn
            // 
            this.visittypeDataGridViewTextBoxColumn.DataPropertyName = "visit_type";
            this.visittypeDataGridViewTextBoxColumn.HeaderText = "Visit Type";
            this.visittypeDataGridViewTextBoxColumn.Name = "visittypeDataGridViewTextBoxColumn";
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "Reason";
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            // 
            // personvisitDataGridViewTextBoxColumn
            // 
            this.personvisitDataGridViewTextBoxColumn.DataPropertyName = "person_visit";
            this.personvisitDataGridViewTextBoxColumn.HeaderText = "Who to see";
            this.personvisitDataGridViewTextBoxColumn.Name = "personvisitDataGridViewTextBoxColumn";
            // 
            // RescheduleAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 611);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RescheduleAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reschedule Appointment";
            this.Load += new System.EventHandler(this.RescheduleAppointment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitor_managerDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduledappointmentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox visitor_city;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox visitor_address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox id_method;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox visitor_telephone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox person_visit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox reason;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox visit_type;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox organization;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox visit_time;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker visit_date;
        private System.Windows.Forms.DataGridView dataGridView1;
        private visitor_managerDataSet4 visitor_managerDataSet4;
        private System.Windows.Forms.BindingSource scheduledappointmentsBindingSource;
        private visitor_managerDataSet4TableAdapters.scheduled_appointmentsTableAdapter scheduled_appointmentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visittimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitoraddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitorcityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitortelephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn organizationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visittypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personvisitDataGridViewTextBoxColumn;
    }
}