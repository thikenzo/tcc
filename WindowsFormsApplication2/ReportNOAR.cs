using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.LookAndFeel;


namespace WindowsFormsApplication2
{
    public partial class ReportNOAR : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportNOAR()
        {
            InitializeComponent();
        }

        private void ReportNOAR_Load(object sender, EventArgs e)
        {
            ReportNOAR report = new ReportNOAR();
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
