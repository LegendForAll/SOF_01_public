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
        BUS_User bus_user = new BUS_User();
        BUS_BILL bus_bil = new BUS_BILL();
        BUS_BILL_INFO bus_bil_info = new BUS_BILL_INFO();

        public GUI_BILL()
        {
            InitializeComponent();
            dgv_bill.AutoGenerateColumns = false;
            dgv_bill.AllowUserToAddRows = false;

            LoadDataGridBill();
            LoadCombox();
        }

        public void LoadCombox()
        {
            // combox user
            List<DTO_User> ob_user = bus_user.SelectAll();
            cbx_user.DataSource = new BindingSource(ob_user, String.Empty);
            cbx_user.DisplayMember = "Name";
            cbx_user.ValueMember = "Id";
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
            //List<DTO_BILL_INFO> listInfo = bus_bil_info.SelectAll(id_bill);
            //dgv_info.DataSource = listInfo;
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

        private void btn_fill_Click(object sender, EventArgs e)
        {
            List<DTO_BILL> listbill = bus_bil.Select_DATE(dtp_fill.Value);
            dgv_bill.DataSource = listbill;
        }

        private void cbx_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<DTO_BILL> listbill = bus_bil.Select_STATUS(cbx_status.Text);
            dgv_bill.DataSource = listbill;
        }

        private void cbx_user_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<DTO_BILL> listbill = bus_bil.Select_USER(cbx_user.SelectedValue.ToString());
            dgv_bill.DataSource = listbill;
        }


    }
}
