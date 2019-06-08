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

            Dictionary<int, TabPage> tabOps = new Dictionary<int, TabPage>();
            tabOps.Add(0, tabPage1);
            tabOps.Add(1, tabPage2);
            tabOps.Add(2, tabPage3);
            tabOps.Add(3, tabPage4);
            tabOps.Add(4, tabPage5);

            //locations (x, y)
            int x = 6;
            int y = 3;

            int[] ops = nv_BUS.Options(type);
            for (int i = 0; i < ops.Length; i++)
            {
                if(ops[i] == 0)
                {
                    mapOps[i].Visible = false;
                    tabControl1.TabPages.Remove(tabOps[i]);
                }
                else
                {
                    var point = new Point(x, y);
                    mapOps[i].Location = point;
                    y = y + 65;
                }
            }
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
            pn_order.BringToFront();
            tabControl1.SelectedTab = tabPage2;
            Form frm_order = new GUI_ORDER();
            this.Hide();
            frm_order.ShowDialog();
            this.Show();
        }

        private void Pbx_repos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("repos");
            pn_repos.BringToFront();
            tabControl1.SelectedTab = tabPage3;
        }

        private void Pbx_report_Click(object sender, EventArgs e)
        {
            MessageBox.Show("report");
            pn_report.BringToFront();
            tabControl1.SelectedTab = tabPage4;

        }

        private void Pbx_ops_Click(object sender, EventArgs e)
        {
            MessageBox.Show("options");
            pn_ops.BringToFront();
            tabControl1.SelectedTab = tabPage5;
            Form frm = new GUI_QLFood();
            frm.Show();
        }

        private void btn_price_Click(object sender, EventArgs e)
        {
            Form rp_price = new GUI_reportPRICE();
            rp_price.Show();
        }

        private void btn_Food_Click(object sender, EventArgs e)
        {
            Form rp_food = new GUI_reportCROSSTAB();
            rp_food.Show();
        }

        private void btn_repos_Click(object sender, EventArgs e)
        {
            Form rp_repos = new GUI_reportOBJECT();
            rp_repos.Show();
        }

        private void btn_FOD_Click(object sender, EventArgs e)
        {
            Form frm_food = new GUI_AddFood();
            this.Hide();
            frm_food.ShowDialog();
            this.Show();
        }

        private void btn_CATE_Click(object sender, EventArgs e)
        {
            Form frm_category = new GUI_AddFoodCategory();
            this.Hide();
            frm_category.ShowDialog();
            this.Show();
        }

        private void btn_BIL_Click(object sender, EventArgs e)
        {
            Form frm_bil = new GUI_BILL();
            this.Hide();
            frm_bil.ShowDialog();
            this.Show();
        }

        private void btn_Table_Click(object sender, EventArgs e)
        {
            Form frm_tab = new GUI_TABLE();
            this.Hide();
            frm_tab.ShowDialog();
            this.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Form frm = new GUI_QLUser();
            frm.Show();
        }
    }
}
