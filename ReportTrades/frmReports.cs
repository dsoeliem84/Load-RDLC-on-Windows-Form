using Microsoft.Reporting.WinForms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace ReportTrades
{
    public partial class frmReports : Form
    {
        private const string _connectionString = "Data Source=NETCORE-PROJECT;Initial Catalog=CyberQuotes_Test;Integrated Security=True";
        private const string _storedProcName = "SP_GetTraderInfoByDates";

        public frmReports()
        {
            InitializeComponent();
        }

        private void btnLoadReport_Click(object sender, EventArgs e)
        {
            RptViewerTrades.LocalReport.ReportEmbeddedResource = "ReportTrades.Reports.RptTrades.rdlc";

            ReportParameter[] rptParams = new ReportParameter[2];
            rptParams[0] = new ReportParameter("rp_FromDate", dptFormDate.Value.Date.ToShortDateString());
            rptParams[1] = new ReportParameter("rp_ToDate", dtpToDate.Value.Date.ToShortDateString());

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "dsTradesReport";
            reportDataSource.Value = GetDataTradesData(dptFormDate.Value.Date, dtpToDate.Value.Date);

            var pageSettings = new PageSettings();
            pageSettings.Margins = new Margins(5, 5, 5, 5);
            RptViewerTrades.SetPageSettings(pageSettings);

            RptViewerTrades.LocalReport.DataSources.Clear();
            RptViewerTrades.LocalReport.SetParameters(rptParams);
            RptViewerTrades.LocalReport.DataSources.Add(reportDataSource);
            RptViewerTrades.RefreshReport();

        }

        private DataTable GetDataTradesData(DateTime pFromDate, DateTime pToDate)
        {
            //DateTime pStartDate, DateTime pEndDate

            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(_storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("pStartDate", pFromDate));
                    command.Parameters.Add(new SqlParameter("pEndDate", pToDate));

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }
    }
}
