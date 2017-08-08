using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.LookAndFeel;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication2
{
    public partial class ReportNOAR2 : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportNOAR2()
        {
            InitializeComponent();
        }

        private void ReportNOAR2_Load(object sender, EventArgs e)
        {
            ReportNOAR2 report = new ReportNOAR2();
            ReportPrintTool printTool = new ReportPrintTool(report);

            // Invoke the Ribbon Print Preview form   
            // and load the report document into it.  
            printTool.ShowRibbonPreview();

            // Invoke the Ribbon Print Preview form modally  
            // with the specified look and feel settings.  
            printTool.ShowRibbonPreviewDialog(UserLookAndFeel.Default);

            // Invoke the Print Preview form   
            // and load the report document into it.  
            printTool.ShowPreview();

            // Invoke the Print Preview form modally  
            // with the specified look and feel settings.  
            printTool.ShowPreviewDialog(UserLookAndFeel.Default);



        }
    }
}
