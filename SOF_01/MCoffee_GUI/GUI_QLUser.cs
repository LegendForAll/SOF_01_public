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
    public partial class GUI_QLUser : Form
    {
        BUS_User user_BUS = new BUS_User();

        public GUI_QLUser()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            List<DTO_User> li_user = new List<DTO_User>();
            li_user = user_BUS.SelectAll();
            dataGridView1.DataSource = li_user;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (-1 < numrow && numrow < dataGridView1.RowCount)
            {
                tbx_id.Text = dataGridView1.Rows[numrow].Cells[0].Value.ToString();
                tbx_name.Text = dataGridView1.Rows[numrow].Cells[1].Value.ToString();
                cbx_type.Text = dataGridView1.Rows[numrow].Cells[2].Value.ToString();
                tbx_user.Text = dataGridView1.Rows[numrow].Cells[3].Value.ToString();
                tbx_pass.Text = dataGridView1.Rows[numrow].Cells[4].Value.ToString();
                dtp_date.Value = Convert.ToDateTime(dataGridView1.Rows[numrow].Cells[5].Value.ToString());
                tbx_address.Text = dataGridView1.Rows[numrow].Cells[6].Value.ToString();
            }
        }
    }
}
