namespace ChrisLandAdmin
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rescheduleAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelAppointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitingDaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerGuardianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gateUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerGateUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerAdminUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gateUserReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chatLogReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instantMessengerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startInstantMessengerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.imgDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.signouttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalappointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitor_managerDataSet2 = new ChrisLandAdmin.visitor_managerDataSet2();
            this.final_appointmentsTableAdapter = new ChrisLandAdmin.visitor_managerDataSet2TableAdapters.final_appointmentsTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalappointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitor_managerDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.instantMessengerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1066, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appointmentToolStripMenuItem,
            this.gateUsersToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // appointmentToolStripMenuItem
            // 
            this.appointmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleAppointmentToolStripMenuItem,
            this.rescheduleAppointmentToolStripMenuItem,
            this.cancelAppointmentsToolStripMenuItem,
            this.visitingDaysToolStripMenuItem});
            this.appointmentToolStripMenuItem.Name = "appointmentToolStripMenuItem";
            this.appointmentToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.appointmentToolStripMenuItem.Text = "Appointment";
            // 
            // scheduleAppointmentToolStripMenuItem
            // 
            this.scheduleAppointmentToolStripMenuItem.Name = "scheduleAppointmentToolStripMenuItem";
            this.scheduleAppointmentToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.scheduleAppointmentToolStripMenuItem.Text = "Schedule Appointment";
            this.scheduleAppointmentToolStripMenuItem.Click += new System.EventHandler(this.scheduleAppointmentToolStripMenuItem_Click);
            // 
            // rescheduleAppointmentToolStripMenuItem
            // 
            this.rescheduleAppointmentToolStripMenuItem.Name = "rescheduleAppointmentToolStripMenuItem";
            this.rescheduleAppointmentToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.rescheduleAppointmentToolStripMenuItem.Text = "Reschedule Appointment";
            this.rescheduleAppointmentToolStripMenuItem.Click += new System.EventHandler(this.rescheduleAppointmentToolStripMenuItem_Click);
            // 
            // cancelAppointmentsToolStripMenuItem
            // 
            this.cancelAppointmentsToolStripMenuItem.Name = "cancelAppointmentsToolStripMenuItem";
            this.cancelAppointmentsToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.cancelAppointmentsToolStripMenuItem.Text = "Cancel Appointments";
            this.cancelAppointmentsToolStripMenuItem.Click += new System.EventHandler(this.cancelAppointmentsToolStripMenuItem_Click);
            // 
            // visitingDaysToolStripMenuItem
            // 
            this.visitingDaysToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerGuardianToolStripMenuItem});
            this.visitingDaysToolStripMenuItem.Name = "visitingDaysToolStripMenuItem";
            this.visitingDaysToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.visitingDaysToolStripMenuItem.Text = "Visiting Days";
            this.visitingDaysToolStripMenuItem.Click += new System.EventHandler(this.visitingDaysToolStripMenuItem_Click);
            // 
            // registerGuardianToolStripMenuItem
            // 
            this.registerGuardianToolStripMenuItem.Name = "registerGuardianToolStripMenuItem";
            this.registerGuardianToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.registerGuardianToolStripMenuItem.Text = "Register Guardian";
            this.registerGuardianToolStripMenuItem.Click += new System.EventHandler(this.registerGuardianToolStripMenuItem_Click);
            // 
            // gateUsersToolStripMenuItem
            // 
            this.gateUsersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerGateUsersToolStripMenuItem,
            this.registerAdminUsersToolStripMenuItem});
            this.gateUsersToolStripMenuItem.Name = "gateUsersToolStripMenuItem";
            this.gateUsersToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.gateUsersToolStripMenuItem.Text = "Users";
            // 
            // registerGateUsersToolStripMenuItem
            // 
            this.registerGateUsersToolStripMenuItem.Name = "registerGateUsersToolStripMenuItem";
            this.registerGateUsersToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.registerGateUsersToolStripMenuItem.Text = "Register Gate Users";
            this.registerGateUsersToolStripMenuItem.Click += new System.EventHandler(this.registerGateUsersToolStripMenuItem_Click);
            // 
            // registerAdminUsersToolStripMenuItem
            // 
            this.registerAdminUsersToolStripMenuItem.Name = "registerAdminUsersToolStripMenuItem";
            this.registerAdminUsersToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.registerAdminUsersToolStripMenuItem.Text = "Register Admin Users.";
            this.registerAdminUsersToolStripMenuItem.Click += new System.EventHandler(this.registerAdminUsersToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gateUserReportsToolStripMenuItem,
            this.visitReportsToolStripMenuItem,
            this.chatLogReportsToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // gateUserReportsToolStripMenuItem
            // 
            this.gateUserReportsToolStripMenuItem.Name = "gateUserReportsToolStripMenuItem";
            this.gateUserReportsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.gateUserReportsToolStripMenuItem.Text = "Gate User Reports";
            this.gateUserReportsToolStripMenuItem.Click += new System.EventHandler(this.gateUserReportsToolStripMenuItem_Click);
            // 
            // visitReportsToolStripMenuItem
            // 
            this.visitReportsToolStripMenuItem.Name = "visitReportsToolStripMenuItem";
            this.visitReportsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.visitReportsToolStripMenuItem.Text = "Visit Reports";
            this.visitReportsToolStripMenuItem.Click += new System.EventHandler(this.visitReportsToolStripMenuItem_Click);
            // 
            // chatLogReportsToolStripMenuItem
            // 
            this.chatLogReportsToolStripMenuItem.Name = "chatLogReportsToolStripMenuItem";
            this.chatLogReportsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.chatLogReportsToolStripMenuItem.Text = "Chat Log Reports";
            // 
            // instantMessengerToolStripMenuItem
            // 
            this.instantMessengerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startInstantMessengerToolStripMenuItem});
            this.instantMessengerToolStripMenuItem.Name = "instantMessengerToolStripMenuItem";
            this.instantMessengerToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.instantMessengerToolStripMenuItem.Text = "&Instant Messenger";
            // 
            // startInstantMessengerToolStripMenuItem
            // 
            this.startInstantMessengerToolStripMenuItem.Name = "startInstantMessengerToolStripMenuItem";
            this.startInstantMessengerToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.startInstantMessengerToolStripMenuItem.Text = "Start Instant Messenger";
            this.startInstantMessengerToolStripMenuItem.Click += new System.EventHandler(this.startInstantMessengerToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 511);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1066, 22);
            this.statusStrip1.TabIndex = 1;
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
            this.label1.Location = new System.Drawing.Point(878, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dashboard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1042, 347);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Overview";
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
            this.personvisitDataGridViewTextBoxColumn,
            this.imgDataGridViewImageColumn,
            this.signouttimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.finalappointmentsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1036, 328);
            this.dataGridView1.TabIndex = 0;
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
            this.visittimeDataGridViewTextBoxColumn.HeaderText = "Visit Time";
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
            this.idmethodDataGridViewTextBoxColumn.HeaderText = "Method of Identification";
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
            this.personvisitDataGridViewTextBoxColumn.HeaderText = "Whom to See";
            this.personvisitDataGridViewTextBoxColumn.Name = "personvisitDataGridViewTextBoxColumn";
            // 
            // imgDataGridViewImageColumn
            // 
            this.imgDataGridViewImageColumn.DataPropertyName = "img";
            this.imgDataGridViewImageColumn.HeaderText = "img";
            this.imgDataGridViewImageColumn.Name = "imgDataGridViewImageColumn";
            this.imgDataGridViewImageColumn.Visible = false;
            // 
            // signouttimeDataGridViewTextBoxColumn
            // 
            this.signouttimeDataGridViewTextBoxColumn.DataPropertyName = "signout_time";
            this.signouttimeDataGridViewTextBoxColumn.HeaderText = "Signout Time";
            this.signouttimeDataGridViewTextBoxColumn.Name = "signouttimeDataGridViewTextBoxColumn";
            // 
            // finalappointmentsBindingSource
            // 
            this.finalappointmentsBindingSource.DataMember = "final_appointments";
            this.finalappointmentsBindingSource.DataSource = this.visitor_managerDataSet2;
            // 
            // visitor_managerDataSet2
            // 
            this.visitor_managerDataSet2.DataSetName = "visitor_managerDataSet2";
            this.visitor_managerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // final_appointmentsTableAdapter
            // 
            this.final_appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 533);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalappointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitor_managerDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rescheduleAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitingDaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerGuardianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gateUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerGateUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gateUserReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chatLogReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instantMessengerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startInstantMessengerToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem cancelAppointmentsToolStripMenuItem;
        private visitor_managerDataSet2 visitor_managerDataSet2;
        private System.Windows.Forms.BindingSource finalappointmentsBindingSource;
        private visitor_managerDataSet2TableAdapters.final_appointmentsTableAdapter final_appointmentsTableAdapter;
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
        private System.Windows.Forms.DataGridViewImageColumn imgDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn signouttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem registerAdminUsersToolStripMenuItem;
    }
}

