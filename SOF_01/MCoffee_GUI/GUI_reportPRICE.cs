using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace MCoffee_GUI
{
    public partial class GUI_reportPRICE : Form
    {
        public GUI_reportPRICE()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-GAF2823;Initial Catalog=DB_SOF_01;Integrated Security=True";
            conn.Open();
            DateTime dateInput = dtp_bill.Value;

            String query = "SELECT [BILL].[ID_BIL], [BILL].[DATETIME], [TABLE].[ID_TAB], [BILL].[SUMPRICE], [BILL].[SUBPRICE], [USER].[NAME] ";
            query += "FROM [BILL] INNER JOIN [TABLE] ON [BILL].[ID_TAB] = [TABLE].[ID_TAB] ";
            query += "INNER JOIN [USER] ON [BILL].[ID_EMP] = [USER].[ID_EMP] ";
            query += "GROUP BY [BILL].[ID_BIL], [BILL].[DATETIME], [TABLE].[ID_TAB], [BILL].[SUMPRICE], [BILL].[SUBPRICE], [USER].[NAME] ";
            query += "HAVING [BILL].[DATETIME] = '" + dateInput.ToShortDateString() + "'";

            SqlCommand cmmd = new SqlCommand(query, conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmmd);

            DataSet_Price dataSet1 = new DataSet_Price();
            adapter.Fill(dataSet1.DataTable2);

            ReportDocument report = new ReportDocument();
            report.Load("D:\\HK6\\SOF_01_public-master\\SOF_01_public-master\\SOF_01\\MCoffee_GUI\\RP_price.rpt");
            report.SetDataSource(dataSet1.Tables["DataTable2"]);

            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }
    }
}
