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
    public partial class GUI_reportCROSSTAB : Form
    {
        public GUI_reportCROSSTAB()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-GAF2823;Initial Catalog=DB_SOF_01;Integrated Security=True";
            conn.Open();
            DateTime dateInput = dtp_bill.Value;

            //String query = "SELECT [BILL_INFO].[ID_BILF], [BILL_INFO].[ID_BIL], [DATETIME] ";
            //query += "FROM [BILL_INFO] ";
            //query += "INNER JOIN [BILL] ON [BILL].[ID_BIL] = [BILL_INFO].[ID_BIL] ";
            //query += "ORDER BY [BILL_INFO].[ID_BILF] ";
            //query += "HAVING [BILL].[DATETIME] = '" + dateInput.ToShortDateString() + "'";

            String query = "SELECT FOOD_CATEGORY.DISPLAYNAME, FOOD.DISPLAYNAME AS Expr1, BILL.DATETIME, BILL.ID_TAB, BILL_INFO.ID_BILF, BILL_INFO.COUNT ";
            query += "FROM BILL INNER JOIN BILL_INFO ON BILL.ID_BIL = BILL_INFO.ID_BIL ";
            query += "INNER JOIN FOOD ON BILL_INFO.ID_FOD = FOOD.ID_FOD ";
            query += "INNER JOIN FOOD_CATEGORY ON FOOD.ID_CAT = FOOD_CATEGORY.ID_CAT ";
            query += "INNER JOIN [USER] ON BILL.ID_EMP = [USER].ID_EMP ";
            query += "GROUP BY FOOD_CATEGORY.DISPLAYNAME, FOOD.DISPLAYNAME, BILL.DATETIME, BILL.ID_TAB, BILL_INFO.ID_BILF, BILL_INFO.COUNT ";
            query += "HAVING [BILL].[DATETIME] = '" + dateInput.ToShortDateString() + "'";

            SqlCommand cmmd = new SqlCommand(query, conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmmd);
            DataSet_Price dataSet1 = new DataSet_Price();
            adapter.Fill(dataSet1.DataTable3);

            ReportDocument report = new ReportDocument();
            report.Load("D:\\HK6\\SOF_01_public-master\\SOF_01_public-master\\SOF_01\\MCoffee_GUI\\RP_Food.rpt");
            report.SetDataSource(dataSet1.Tables["DataTable3"]);

            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }
    }
}
