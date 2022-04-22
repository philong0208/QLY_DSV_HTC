﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace FrmMain.cs
{
    public partial class XtraReport_DSLTC : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport_DSLTC(string nienkhoa, int hk)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = nienkhoa;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = hk;
            this.sqlDataSource1.Fill();

        }


    }
}
