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
    public partial class GUI_QLTable : Form
    {
        BUS_Table tab_BUS = new BUS_Table();

        public GUI_QLTable()
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
                if(item.AREA != "AR1_DEL")
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
        }

        public void resetView(DTO_Table cTable)
        {

            tbx_id.Text = cTable.ID;
            ntd_number.Value = Convert.ToInt32(cTable.NUMBER);
            ntd_limit.Value = Convert.ToInt32(cTable.LIMIT);
            if(cTable.STATUS == "0")
            {
                cbx_status.SelectedIndex = 0;
            }
            else
            {
                cbx_status.SelectedIndex = 1;
            }

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            String id = ((sender as Button).Tag as DTO_Table).ID;
            MessageBox.Show(id);
            DTO_Table cur_table = new DTO_Table();
            cur_table = tab_BUS.Select_ID(id);
            resetView(cur_table);
        }

        private void GUI_QLTable_Load(object sender, EventArgs e)
        {
            loadFlowpanel();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DTO_Table tab = new DTO_Table(tbx_id.Text, ntd_number.Value.ToString(), "AR1", ntd_limit.Value.ToString(), cbx_status.SelectedIndex.ToString());
            Result result = tab_BUS.update(tab);

            if(result.Flag)
            {
                MessageBox.Show("Updated...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadFlowpanel();
            }
            else
            {
                MessageBox.Show("Error...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DTO_Table tab = new DTO_Table(tbx_id.Text, ntd_number.Value.ToString(), "AR1_DEL", ntd_limit.Value.ToString(), cbx_status.SelectedIndex.ToString());
            Result result = tab_BUS.update(tab);

            if (result.Flag)
            {
                MessageBox.Show("Deleted...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadFlowpanel();
            }
            else
            {
                MessageBox.Show("Error...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
