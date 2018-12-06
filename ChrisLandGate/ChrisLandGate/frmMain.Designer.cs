namespace ChrisLandGate
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
            this.appointmentsAndVisitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unscheduledAppointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduledAppointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitingDaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instantMessengerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startInstantMessengerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label11 = new System.Windows.Forms.Label();
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
            this.visitor_managerDataSet3 = new ChrisLandGate.visitor_managerDataSet3();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.final_appointmentsTableAdapter = new ChrisLandGate.visitor_managerDataSet3TableAdapters.final_appointmentsTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalappointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitor_managerDataSet3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appointmentsAndVisitsToolStripMenuItem,
            this.instantMessengerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1048, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "&Appointments and Visits";
            // 
            // appointmentsAndVisitsToolStripMenuItem
            // 
            this.appointmentsAndVisitsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unscheduledAppointmentsToolStripMenuItem,
            this.scheduledAppointmentsToolStripMenuItem,
            this.visitingDaysToolStripMenuItem});
            this.appointmentsAndVisitsToolStripMenuItem.Name = "appointmentsAndVisitsToolStripMenuItem";
            this.appointmentsAndVisitsToolStripMenuItem.Size = new System.Drawing.Size(148, 20);
            this.appointmentsAndVisitsToolStripMenuItem.Text = "&Appointments and Visits";
            // 
            // unscheduledAppointmentsToolStripMenuItem
            // 
            this.unscheduledAppointmentsToolStripMenuItem.Name = "unscheduledAppointmentsToolStripMenuItem";
            this.unscheduledAppointmentsToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.unscheduledAppointmentsToolStripMenuItem.Text = "Unscheduled Appointments";
            this.unscheduledAppointmentsToolStripMenuItem.Click += new System.EventHandler(this.unscheduledAppointmentsToolStripMenuItem_Click);
            // 
            // scheduledAppointmentsToolStripMenuItem
            // 
            this.scheduledAppointmentsToolStripMenuItem.Name = "scheduledAppointmentsToolStripMenuItem";
            this.scheduledAppointmentsToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.scheduledAppointmentsToolStripMenuItem.Text = "Scheduled Appointments";
            this.scheduledAppointmentsToolStripMenuItem.Click += new System.EventHandler(this.scheduledAppointmentsToolStripMenuItem_Click);
            // 
            // visitingDaysToolStripMenuItem
            // 
            this.visitingDaysToolStripMenuItem.Name = "visitingDaysToolStripMenuItem";
            this.visitingDaysToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.visitingDaysToolStripMenuItem.Text = "Visiting Days";
            this.visitingDaysToolStripMenuItem.Click += new System.EventHandler(this.visitingDaysToolStripMenuItem_Click);
            // 
            // instantMessengerToolStripMenuItem
            // 
            this.instantMessengerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startInstantMessengerToolStripMenuItem});
            this.instantMessengerToolStripMenuItem.Name = "instantMessengerToolStripMenuItem";
            this.instantMessengerToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.instantMessengerToolStripMenuItem.Text = "Instant Messenger";
            // 
            // startInstantMessengerToolStripMenuItem
            // 
            this.startInstantMessengerToolStripMenuItem.Name = "startInstantMessengerToolStripMenuItem";
            this.startInstantMessengerToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.startInstantMessengerToolStripMenuItem.Text = "Start Instant Messenger";
            this.startInstantMessengerToolStripMenuItem.Click += new System.EventHandler(this.startInstantMessengerToolStripMenuItem_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(797, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 24);
            this.label11.TabIndex = 4;
            this.label11.Text = "&Dashboard";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 116);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1024, 217);
            this.groupBox1.TabIndex = 6;
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
            this.dataGridView1.Size = new System.Drawing.Size(1018, 198);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick_1);
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
            this.visittimeDataGridViewTextBoxColumn.HeaderText = "Visit time";
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
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "Full name";
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
            this.personvisitDataGridViewTextBoxColumn.HeaderText = "Who to See";
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
            this.finalappointmentsBindingSource.DataSource = this.visitor_managerDataSet3;
            // 
            // visitor_managerDataSet3
            // 
            this.visitor_managerDataSet3.DataSetName = "visitor_managerDataSet3";
            this.visitor_managerDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(15, 414);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 86);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(355, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(128, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Search Name";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 535);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1048, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // final_appointmentsTableAdapter
            // 
            this.final_appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 557);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalappointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitor_managerDataSet3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem appointmentsAndVisitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unscheduledAppointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduledAppointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitingDaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instantMessengerToolStripMenuItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem startInstantMessengerToolStripMenuItem;
        private visitor_managerDataSet3 visitor_managerDataSet3;
        private System.Windows.Forms.BindingSource finalappointmentsBindingSource;
        private visitor_managerDataSet3TableAdapters.final_appointmentsTableAdapter final_appointmentsTableAdapter;
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
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}

