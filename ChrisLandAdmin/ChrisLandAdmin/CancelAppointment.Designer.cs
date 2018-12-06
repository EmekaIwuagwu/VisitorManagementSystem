namespace ChrisLandAdmin
{
    partial class CancelAppointment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fullname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.visitor_managerDataSet5 = new ChrisLandAdmin.visitor_managerDataSet5();
            this.scheduledappointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scheduled_appointmentsTableAdapter = new ChrisLandAdmin.visitor_managerDataSet5TableAdapters.scheduled_appointmentsTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.visitor_managerDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduledappointmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.fullname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by Name";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(352, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fullname
            // 
            this.fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullname.Location = new System.Drawing.Point(137, 23);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(215, 22);
            this.fullname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(16, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(953, 241);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lookup Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cancel Appointments";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 413);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(981, 22);
            this.statusStrip1.TabIndex = 4;
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
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.id);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(534, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(432, 59);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search by ID";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(233, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // id
            // 
            this.id.Enabled = false;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(92, 22);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(143, 22);
            this.id.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Search ID";
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
            this.dataGridView1.Size = new System.Drawing.Size(947, 222);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick_1);
            // 
            // visitor_managerDataSet5
            // 
            this.visitor_managerDataSet5.DataSetName = "visitor_managerDataSet5";
            this.visitor_managerDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scheduledappointmentsBindingSource
            // 
            this.scheduledappointmentsBindingSource.DataMember = "scheduled_appointments";
            this.scheduledappointmentsBindingSource.DataSource = this.visitor_managerDataSet5;
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
            this.visittimeDataGridViewTextBoxColumn.HeaderText = "Sign-in time";
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
            this.visitoraddressDataGridViewTextBoxColumn.HeaderText = "Visitor Address ";
            this.visitoraddressDataGridViewTextBoxColumn.Name = "visitoraddressDataGridViewTextBoxColumn";
            this.visitoraddressDataGridViewTextBoxColumn.Visible = false;
            // 
            // visitorcityDataGridViewTextBoxColumn
            // 
            this.visitorcityDataGridViewTextBoxColumn.DataPropertyName = "visitor_city";
            this.visitorcityDataGridViewTextBoxColumn.HeaderText = "Visitor City";
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
            // CancelAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 435);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CancelAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancel Appointment";
            this.Load += new System.EventHandler(this.CancelAppointment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitor_managerDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduledappointmentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox fullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private visitor_managerDataSet5 visitor_managerDataSet5;
        private System.Windows.Forms.BindingSource scheduledappointmentsBindingSource;
        private visitor_managerDataSet5TableAdapters.scheduled_appointmentsTableAdapter scheduled_appointmentsTableAdapter;
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