using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MCoffee_DTO;
using MCoffee_BUS;
using Untility;

namespace MCoffee_GUI
{
    public partial class GUI_BILL : Form
    {

        BUS_BILL bus_bil = new BUS_BILL();
        BUS_BILL_INFO bus_bil_info = new BUS_BILL_INFO();

        public GUI_BILL()
        {
            InitializeComponent();
            dgv_bill.AutoGenerateColumns = false;
            dgv_bill.AllowUserToAddRows = false;

            LoadDataGridBill();
        }

        public void LoadDataGridBill()
        {
            List<DTO_BILL> listbill = bus_bil.SelectAll();
            dgv_bill.DataSource = listbill;

            ID.DataPropertyName = "ID";
            ID_USER.DataPropertyName = "ID_EMP";
            STATUS_BILL.DataPropertyName = "STATUS";
            BILL_PRICE.DataPropertyName = "SUMPRICE";
            SUB_BILL.DataPropertyName = "SUMPRICE";
        }

        public void LoadDataGridBillInfo(String id_bill)
        {
            List<DTO_BILL_INFO> listInfo = bus_bil_info.SelectAll(id_bill);
            dgv_info.DataSource = listInfo;
        }

        private void dgv_bill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                String id = dgv_bill.Rows[e.RowIndex].Cells[0].Value.ToString();
                
                DTO_BILL bill = bus_bil.SelectID(id);
                MessageBox.Show(id);
                tbx_idBill.Text = id;
                tbx_idTable.Text = bill.ID_TAB;
                dtp_bill.Value = bill.DATETIME;

                //select bill_info from id_bill
                LoadDataGridBillInfo(id);
            }
        }

        private void dtp_fill_ValueChanged(object sender, EventArgs e)
        {
            //List<DTO_BILL> listbill = bus_bil.Select_DATE(dtp_fill.Value);
            //dgv_bill.DataSource = listbill;
            //MessageBox.Show(dtp_fill.Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<DTO_BILL> listbill = bus_bil.Select_DATE(dtp_fill.Value);
            dgv_bill.DataSource = listbill;
            MessageBox.Show(dtp_fill.Value.ToString("yyyy-MM-dd 00:00:00.0000000"));
        }
    }
}
