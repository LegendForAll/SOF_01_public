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
    public partial class GUI_ReportNumRepo : Form
    {
        public GUI_ReportNumRepo()
        {
            InitializeComponent();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-EFN18GS;Initial Catalog=DB_SOF_01;Integrated Security=True";

            
                conn.Open();
          
            String query = "SELECT [ID_OBJ], [OBJECT].[DISPLAYNAME], [SUPLIER].[DISPLAYNAME] AS SUPLIERNAME, ";
            query += "[UNIT].[DISPLAYNAME] AS UNITNAME, [NUM_REPO] ";
            query += "FROM [OBJECT], [SUPLIER], [UNIT] ";
            query += "WHERE [OBJECT].ID_SUP = [SUPLIER].[ID_SUP] AND [OBJECT].[ID_UNI] = [UNIT].[ID_UNI] ";
            //query += "GROUP BY [ID_OBJ]";

            SqlCommand cmmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmmd);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            ReportDocument report = new ReportDocument();
            report.Load("E:\\GitHub\\SOF_01_public\\SOF_01\\MCoffee_GUI\\ReportNumRepo.rpt");
            report.SetDataSource(dataSet.Tables["SUPLIER"]);
            
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }
    }
}
