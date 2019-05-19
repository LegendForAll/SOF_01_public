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
using MCoffee_BUS;
using MCoffee_DTO;

namespace MCoffee_GUI
{
    public partial class GUI_ReportNumRepo : Form
    {
        BUS_Object bus_object = new BUS_Object();

        public GUI_ReportNumRepo()
        {
            InitializeComponent();
            LoadCbObject();
        }

        public void LoadCbObject()
        {
            List<DTO_Object2> objects = bus_object.SelectAll();
            cbObjects.DataSource = new BindingSource(objects, String.Empty);
            cbObjects.DisplayMember = "DISPLAYNAME";
            cbObjects.ValueMember = "ID";
        }
        private void btCreate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-EFN18GS;Initial Catalog=DB_SOF_01;Integrated Security=True";  
            
            conn.Open();
            String nameObject = cbObjects.SelectedValue.ToString();

            String query = "SELECT * ";
            query += "FROM OBJECT ";
            query += "WHERE ID_OBJ = '" + nameObject + "'";

            SqlCommand cmmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmmd);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "OBJECT");
            ReportDocument report = new ReportDocument();
            report.Load("E:\\GitHub\\SOF_01_public\\SOF_01\\MCoffee_GUI\\ReportNumRepo.rpt");
            report.SetDataSource(dataSet.Tables["OBJECT"]);
            
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }
    }
}
