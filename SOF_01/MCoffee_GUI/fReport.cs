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
    public partial class fReport : Form
    {
        public fReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String max = txtMax.Text;
            String min = txtMin.Text;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-6RCLIFI;Initial Catalog=DB_SOF_01;Integrated Security=True";


            conn.Open();

            //String query = "SELECT * FROM [FOOD]";
            String query = " SELECT* FROM [FOOD] WHERE [OUTPUTPRICE] BETWEEN '" + min + "' AND '" + max + "'";

            SqlCommand cmmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmmd);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet,"FOOD");
            ReportDocument report = new ReportDocument();
            report.Load("C:\\Users\\HoangMai\\SOF_01_public\\SOF_01\\MCoffee_GUI\\CrystalReport1.rpt");
            report.SetDataSource(dataSet.Tables["FOOD"]);

            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }
    }
}
