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
        BUS_BILL_INFO bus_infoBill = new BUS_BILL_INFO();
        BUS_Table tab_BUS = new BUS_Table();
        public DTO_BILL bill;
        List<DTO_Menu> listbill_info;


        public GUI_ORDER()
        {
            InitializeComponent();
            LoadDataGridBill();
        }

        public void LoadDataGridBill()
        {
            List<DTO_BILL> listbill = bus_bill.SelectAll();
            dgv_bill.DataSource = listbill;

            //table
            List<DTO_Table> listtab = tab_BUS.SelectAll();
            //flowpanel
            foreach (DTO_Table item in listtab)
            {
                //create button table
                Button btn = new Button();
                btn.Text = item.ID + Environment.NewLine;
                btn.Size = new Size(80, 80);
                fpn_table.Controls.Add(btn);

                //add event button_click
                btn.Click += Btn_Click;
                btn.Tag = item;

                //set color
                switch (item.STATUS.ToString())
                {
                    case "1":
                        {
                            btn.BackColor = Color.Silver;
                            break;
                        }
                    case "0":
                        {
                            btn.BackColor = Color.White;
                            break;
                        }
                }
            }
        }

        public void ShowBill(String id)
        {
            lst_bill.Items.Clear();
            bill = bus_bill.SelectID_Table(id);
            listbill_info = bus_infoBill.SelectAll(bill.ID);
            if(listbill_info != null)
            {
                foreach (DTO_Menu item in listbill_info)
                {
                    ListViewItem lsi = new ListViewItem(item.DISPLAYNAME.ToString());
                    lsi.SubItems.Add(item.COUNT.ToString());
                    lsi.SubItems.Add(item.PRICE.ToString());
                    lst_bill.Items.Add(lsi);
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            String id = ((sender as Button).Tag as DTO_Table).ID;
            ShowBill(id);
            
        }
    }
}
