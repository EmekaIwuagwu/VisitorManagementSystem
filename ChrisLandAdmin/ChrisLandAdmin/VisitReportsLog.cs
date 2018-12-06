﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChrisLandAdmin
{
    public partial class VisitReportsLog : Form
    {
        public VisitReportsLog()
        {
            InitializeComponent();
        }

        private void VisitReportsLog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MyVisitorDataset.final_appointments' table. You can move, or remove it, as needed.
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.final_appointmentsTableAdapter.Fill(this.MyVisitorDataset.final_appointments, Convert.ToDateTime(dateFrom.Text), Convert.ToDateTime(dateTo.Text));
            this.reportViewer1.RefreshReport();
        }
    }
}
