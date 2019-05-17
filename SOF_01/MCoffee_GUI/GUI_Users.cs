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

namespace MCoffee_GUI
{
    public partial class GUI_Users : Form
    {
        BUS_User user_BUS = new BUS_User();
        public GUI_Users()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(txtIdUser.Text!="" && txtNameUser.Text!="" && txtType.Text!="" &&
                txtUsername.Text!="" && txtPassword.Text!="" &&
                dtpDateStart.Value.ToString()!="" && txtAddress.Text!="")
            {
                DTO_User user_DTO = new DTO_User(txtIdUser.Text, txtNameUser.Text, txtType.Text, txtUsername.Text,
                                             txtPassword.Text, dtpDateStart.Value, txtAddress.Text);
                if (user_BUS.Insert(user_DTO))
                {
                    MessageBox.Show("Thêm nhân viên mới thành công!", "Successful", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!!!", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền dữ liệu", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            User_GUI_Load(sender, e);
        }
        private void User_GUI_Load(object sender, EventArgs e)
        {
            DataTable dtbUser = new DataTable();
            dtbUser = user_BUS.Display("Select * from [USER]");
            dataGridView1.DataSource = dtbUser;
            dataGridView1.AllowUserToAddRows = false;
        }
    }
}
