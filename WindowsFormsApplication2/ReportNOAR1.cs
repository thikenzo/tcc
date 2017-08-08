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
    public partial class ReportNOAR1 : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportNOAR1()
        {
            InitializeComponent();
        }
        private void ReportNOAR1_Load(object sender, EventArgs e)
        {
            ReportNOAR1 report = new ReportNOAR1();
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
