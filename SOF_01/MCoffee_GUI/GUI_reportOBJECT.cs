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
    public partial class GUI_reportOBJECT : Form
    {
        public GUI_reportOBJECT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-GAF2823;Initial Catalog=DB_SOF_01;Integrated Security=True";
            conn.Open();
            String obs = textBox1.Text;

            String query = "SELECT OBJECT.DISPLAYNAME, SUPLIER.DISPLAYNAME AS Expr1, OBJECT.NUM_REPO, OBJECT.ID_OBJ, UNIT.DISPLAYNAME AS Expr2 ";
            query += "FROM OBJECT INNER JOIN SUPLIER ON OBJECT.ID_SUP = SUPLIER.ID_SUP ";
            query += "INNER JOIN UNIT ON OBJECT.ID_UNI = UNIT.ID_UNI ";
            query += "WHERE [OBJECT].[DISPLAYNAME] = '" + obs + "'";

            SqlCommand cmmd = new SqlCommand(query, conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmmd);

            DataSet_Price dataSet1 = new DataSet_Price();
            adapter.Fill(dataSet1.DataTable4);

            ReportDocument report = new ReportDocument();
            report.Load("D:\\HK6\\SOF_01_public-master\\SOF_01_public-master\\SOF_01\\MCoffee_GUI\\RP_object.rpt");
            report.SetDataSource(dataSet1.Tables["DataTable4"]);

            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }
    }
}
