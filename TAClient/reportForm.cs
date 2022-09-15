using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TAClient
{
    public partial class reportForm : Form
    {
        private int repYear;
        private int repId;

        public reportForm(int year, int rep)
        {
            repYear = year;
            repId = rep;
            InitializeComponent();
        }

        private void reportForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            taService.taService ws = new taService.taService();
            String repSource = "";
            switch (repId)
            {
                case 0:
                    dt = ws.GetSalePlan(repYear);
                    repSource = "TAClient.Report0.rdlc";
                    rwReport.RefreshReport();
                    break;
                case 1:
                    dt = ws.GetTrade(repYear);
                    repSource = "TAClient.Report1.rdlc";
                    break;
                case 2:
                    dt = ws.GetTradeStructure(repYear);
                    repSource = "TAClient.Report2.rdlc";
                    break;
                case 3:
                    dt = ws.GetTradePayment(repYear);
                    repSource = "TAClient.Report3.rdlc";
                    break;
                case 4:
                    dt = ws.GetTradeRetail(repYear);
                    repSource = "TAClient.Report4.rdlc";
                    break;
                case 5:
                    dt = ws.GetTradeRhytm(repYear);
                    repSource = "TAClient.Report5.rdlc";
                    break;
                case 6:
                    dt = ws.GetTradeSeason(repYear);
                    repSource = "TAClient.Report6.rdlc";
                    break;
                case 7:
                    dt = ws.GetAvgPrice(repYear);
                    repSource = "TAClient.Report7.rdlc";
                    break;
                default:
                    this.Close();
                    break;
            }
            Microsoft.Reporting.WinForms.ReportDataSource rds1 = new Microsoft.Reporting.WinForms.ReportDataSource("ds1", dt);
            rwReport.LocalReport.DataSources.Add(rds1);
            rwReport.LocalReport.ReportEmbeddedResource = repSource;
            rwReport.RefreshReport();
        }
    }
}
