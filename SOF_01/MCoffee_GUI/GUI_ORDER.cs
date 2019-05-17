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
    public partial class GUI_ORDER : Form
    {

        BUS_BILL bus_bill = new BUS_BILL();

        public GUI_ORDER()
        {
            InitializeComponent();
            LoadDataGridBill();
        }

        public void LoadDataGridBill()
        {
            List<DTO_BILL> listbill = bus_bill.SelectAll();
            dgv_bill.DataSource = listbill;
        }
    }
}
