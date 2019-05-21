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
using System.Data.SqlClient;

namespace MCoffee_GUI
{
    public partial class GUI_Users : Form
    {
        BUS_User user_BUS = new BUS_User();
        public GUI_Users()
        {
            InitializeComponent();
            LoadComboBoxTypeUser();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            String Id = txtIdUser.Text;
            if (txtIdUser.Text != "" && txtNameUser.Text != "" && cbxType.Text != "" &&
                txtUsername.Text != "" && txtPassword.Text != "" &&
                dtpDateStart.Value.ToString() != "" && txtAddress.Text != "")
            {
                DTO_User user_DTO = new DTO_User(txtIdUser.Text, txtNameUser.Text, cbxType.Text, txtUsername.Text,
                                             txtPassword.Text, dtpDateStart.Value, txtAddress.Text);
                if (user_BUS.isExit(Id))
                {
                    MessageBox.Show("User đã tồn tại", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
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
        public void LoadComboBoxTypeUser()
        {
            BUS_User bus_User = new BUS_User();
            List<DTO_TypeUser> listTypeUser = bus_User.SelectAllTypeUser();

            cbxType.DataSource = listTypeUser;
            cbxType.DisplayMember = "Type";
            cbxType.ValueMember = "Id";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String Id = txtIdUser.Text;
            String name = txtUsername.Text;

            if (user_BUS.isExit(Id))
            {
                DialogResult resultDialog = MessageBox.Show("Bạn có thực sự muốn xóa User " + name,
                                            "Infomation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resultDialog == DialogResult.Yes)
                {
                    Result result = user_BUS.Delete(Id);
                    if (result.Flag)
                    {
                        MessageBox.Show("Xóa User thành công", "Successful", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        User_GUI_Load(sender, e);
                    }
                    else
                        MessageBox.Show("Xóa User không thành công\nError:" + result.Message,
                                        "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("User không tồn tại", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
