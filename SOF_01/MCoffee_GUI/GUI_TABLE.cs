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
                if (item.AREA != "AR1_DEL")
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

        private void Btn_Click(object sender, EventArgs e)
        {
            
        }

        public void auto_id()
        {
            String id = tab_BUS.nextID();
            tbx_id.Text = id;
        }

        private void GUI_TABLE_Load(object sender, EventArgs e)
        {
            loadFlowpanel();
            auto_id();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cbx_status.SelectedIndex.ToString());
            DTO_Table itable = new DTO_Table(tbx_id.Text, ntd_number.Value.ToString(), "AR1", ntd_limit.Value.ToString(), cbx_status.SelectedIndex.ToString());
            Result result = tab_BUS.insert(itable);
            if(result.Flag)
            {
                MessageBox.Show("Inserted...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadFlowpanel();
                auto_id();
            }
            else
            {
                MessageBox.Show("Error...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Form frm_up = new GUI_QLTable();
            this.Hide();
            frm_up.ShowDialog();
            this.Show();
        }
    }
}
