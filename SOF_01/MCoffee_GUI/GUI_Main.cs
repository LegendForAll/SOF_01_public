using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MCoffee_BUS;
using MCoffee_DTO;
using Untility;

namespace MCoffee_GUI
{
    public partial class GUI_Main : Form
    {
        // use Object nv_BUS doing Layer Business
        BUS_User nv_BUS = new BUS_User();
        BUS_Table tab_BUS = new BUS_Table();
        BUS_BILL bil_BUS = new BUS_BILL();

        public GUI_Main()
        {
            InitializeComponent();
        }

        public string user;
        public string type;

        //visible panel
        public void Isvisible(int options)
        {
            Dictionary<int, Panel> mapOps = new Dictionary<int, Panel>();
            mapOps.Add(0, pn_user);
            mapOps.Add(1, pn_order);
            mapOps.Add(2, pn_repos);
            mapOps.Add(3, pn_report);
            mapOps.Add(4, pn_ops);

            for (int i = 0; i < 5; i++)
            {
                mapOps[i].Visible = false;
            }

            if(options != -1)
                mapOps[options].Visible = true;
        }

        private void GUI_Main_Load(object sender, EventArgs e)
        {
            lb_userName.Text = user;
            lb_type.Text = type;
          
            Dictionary<int, PictureBox> mapOps = new Dictionary<int, PictureBox>();
            mapOps.Add(0, pbx_user);
            mapOps.Add(1, pbx_order);
            mapOps.Add(2, pbx_repos);
            mapOps.Add(3, pbx_report);
            mapOps.Add(4, pbx_ops);

            //locations (x, y)
            int x = 3;
            int y = 3;

            int[] ops = nv_BUS.Options(type);
            for (int i = 0; i < ops.Length; i++)
            {
                if(ops[i] == 0)
                {
                    mapOps[i].Visible = false;
                }
                else
                {
                    var point = new Point(3, y);
                    mapOps[i].Location = point;
                    y = y + 65;
                }
            }

            //panel options
            //Isvisible(-1);
        }

        private void Pbx_user_Click(object sender, EventArgs e)
        {
            MessageBox.Show("user");
            pn_user.BringToFront();
            tabControl1.SelectedTab = tabPage1;

        }

        private void Pbx_order_Click(object sender, EventArgs e)
        {
            MessageBox.Show("order");
            int options = 1;
            pn_order.BringToFront();
            tabControl1.SelectedTab = tabPage2;

            //gridview
            List<DTO_Table> listtab = tab_BUS.SelectAll();
            dataGridView1.DataSource = listtab;

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

        public void ShowBill (String id)
        {
            lst_bill.Items.Clear();
            ListViewItem lsi = new ListViewItem(id.ToString());
            lsi.SubItems.Add("Food");
            lsi.SubItems.Add("Bill");
            lsi.SubItems.Add("Count");
            lsi.SubItems.Add("Price");
            lst_bill.Items.Add(lsi);
        }


        private void Btn_Click(object sender, EventArgs e)
        {
            String id = ((sender as Button).Tag as DTO_Table).ID;
            //MessageBox.Show("ID: " + id);
            ShowBill(id);

            DTO_BILL bill = bil_BUS.SelectID_Table(id);
            tbx_idTable.Text = id;
            tbx_idBill.Text = bill.ID;
        }

        private void Pbx_repos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("repos");
            int options = 2;
            pn_repos.BringToFront();
            tabControl1.SelectedTab = tabPage3;
        }

        private void Pbx_report_Click(object sender, EventArgs e)
        {
            MessageBox.Show("report");
            int options = 3;
            pn_report.BringToFront();
            tabControl1.SelectedTab = tabPage4;

        }

        private void Pbx_ops_Click(object sender, EventArgs e)
        {
            MessageBox.Show("options");
            int options = 4;
            pn_ops.BringToFront();
            tabControl1.SelectedTab = tabPage5;
        }

        private void btn_price_Click(object sender, EventArgs e)
        {
            Form rp_price = new GUI_reportPRICE();
            rp_price.Show();
        }
    }
}
