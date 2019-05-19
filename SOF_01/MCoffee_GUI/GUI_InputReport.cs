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
    public partial class GUI_InputReport : Form
    {
        public GUI_InputReport()
        {
            InitializeComponent();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-EFN18GS;Initial Catalog=DB_SOF_01;Integrated Security=True";
            conn.Open();
            DateTime dateInput = dtpdateInput.Value;
             
            String query = "SELECT [INPUT].[ID_INP], [DATEINPUT] ";
            query += "FROM INPUT ";
            query += "GROUP BY INPUT.ID_INP, DATEINPUT ";
            query += "HAVING DATEINPUT = '" + dateInput.ToShortDateString() + "'";

            SqlCommand cmmd = new SqlCommand(query, conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmmd);
            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet, "InputReport");
            
            ReportDocument report = new ReportDocument();
            report.Load("E:\\GitHub\\SOF_01_public\\SOF_01\\MCoffee_GUI\\InputReport.rpt");
            report.SetDataSource(dataSet.Tables["InputReport"]);

            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }

        private void btShowAll_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-EFN18GS;Initial Catalog=DB_SOF_01;Integrated Security=True";
            conn.Open();
            DateTime dateInput = dtpdateInput.Value;

            String query = "SELECT [INPUT].[ID_INP], [DATEINPUT] ";
            query += "FROM INPUT ";
            query += "GROUP BY INPUT.ID_INP, DATEINPUT ";
           

            SqlCommand cmmd = new SqlCommand(query, conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmmd);
            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet, "InputReport");

            ReportDocument report = new ReportDocument();
            report.Load("E:\\GitHub\\SOF_01_public\\SOF_01\\MCoffee_GUI\\InputReport.rpt");
            report.SetDataSource(dataSet.Tables["InputReport"]);

            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }
    }
}
