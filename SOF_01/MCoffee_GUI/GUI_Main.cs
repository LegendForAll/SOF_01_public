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

namespace MCoffee_GUI
{
    public partial class GUI_Main : Form
    {
        // use Object nv_BUS doing Layer Business
        BUS_User nv_BUS = new BUS_User();

        public GUI_Main()
        {
            InitializeComponent();
        }

        public string user;
        public string type;

        private void GUI_Main_Load(object sender, EventArgs e)
        {
            lb_userName.Text = user;
            lb_type.Text = type;
          
            Dictionary<int, TabPage> mapOps = new Dictionary<int, TabPage>();
            mapOps.Add(0, tb_user);
            mapOps.Add(1, tb_order);
            mapOps.Add(2, tb_repos);
            mapOps.Add(3, tb_report);
            mapOps.Add(4, tb_option);

            int[] ops = nv_BUS.Options(type);
            for (int i = 0; i < ops.Length; i++)
            {
                if(ops[i] == 0)
                {
                    tab_main.TabPages.Remove(mapOps[i]);
                }
            }
        }
    }
}
