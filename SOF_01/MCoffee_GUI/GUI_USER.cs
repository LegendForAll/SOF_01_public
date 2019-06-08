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
    public partial class GUI_USER : Form
    {

        BUS_User user_BUS = new BUS_User();
        public GUI_USER()
        {
            InitializeComponent();
            auto_id();
        }

        public void auto_id()
        {
            String id = user_BUS.nextID();
            tbx_id.Text = id;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cbx_status.SelectedIndex.ToString());
            DTO_User iuser = new DTO_User(tbx_id.Text,tbx_name.Text,cbx_type.Text, tbx_user.Text, tbx_pass.Text, dtp_date.Value, tbx_address.Text);
            bool result = user_BUS.Insert(iuser);
            if (result)
            {
                MessageBox.Show("Inserted...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                auto_id();
            }
            else
            {
                MessageBox.Show("Error...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
