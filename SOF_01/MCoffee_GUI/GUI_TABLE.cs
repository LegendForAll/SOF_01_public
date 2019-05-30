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
    public partial class GUI_TABLE : Form
    {
        BUS_Table tab_BUS = new BUS_Table();

        public GUI_TABLE()
        {
            InitializeComponent();
        }

        public void loadFlowpanel()
        {
            fpn_table.Controls.Clear();
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

        private void Btn_Click(object sender, EventArgs e)
        {
            
        }

        private void GUI_TABLE_Load(object sender, EventArgs e)
        {
            loadFlowpanel();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbx_status.SelectedIndex.ToString());
        }
    }
}
