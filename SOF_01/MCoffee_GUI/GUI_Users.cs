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
    public partial class GUI_User : Form
    {
        BUS_User user_BUS = new BUS_User();
        public GUI_User()
        {
            InitializeComponent();
            LoadComboBoxTypeUser();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.AllowUserToAddRows = false;
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

            GUI_User_Load(sender, e);
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
                        GUI_User_Load(sender, e);
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
            if (isNull(txtIdUser2.Text))
            {
                MessageBox.Show("Thông tin User không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                String Id = txtIdUser2.Text;
                String Name = txtNameUser2.Text;
                String Type = cbxType2.Text;
                String Username = txtUsername2.Text;
                String Password = txtUsername2.Text;
                String Address = txtAddress2.Text;

                DTO_User user_DTO = new DTO_User(Id, Name, Type, Username, Password, dtpDateStart2.Value, Address);

                Result result = user_BUS.Update(user_DTO);
                
                if (result.Flag)
                {
                    MessageBox.Show("Sửa thông tin User " + Username + " thành công", "Successful",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GUI_User_Load(sender, e);
                }
                else
                    MessageBox.Show("Sửa thông tin User thất bại\nError: " + result.Message, "Failed",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void GUI_User_Load(object sender, EventArgs e)
        {
            DataTable dtbUser = new DataTable();
            dtbUser = user_BUS.Display("Select * from [USER]");
            dataGridView1.DataSource = dtbUser;

            Id.DataPropertyName = "ID_EMP";
            Name.DataPropertyName = "NAME";
            Type.DataPropertyName = "TYPE";
            Username.DataPropertyName = "USERNAME";
            Password.DataPropertyName = "PASSWORD";
            DateStart.DataPropertyName = "DATESTART";
            Address.DataPropertyName = "ADDRESS";

            dataGridView2.DataSource = dtbUser;

            Id2.DataPropertyName = "ID_EMP";
            Name2.DataPropertyName = "NAME";
            Type2.DataPropertyName = "TYPE";
            Username2.DataPropertyName = "USERNAME";
            Password2.DataPropertyName = "PASSWORD";
            DateStart2.DataPropertyName = "DATESTART";
            Address2.DataPropertyName = "ADDRESS";
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                String Id = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                String Name = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                String Type = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
                String Username = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
                String Password = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
                String DateStart = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
                String Address = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();

                txtIdUser2.Text = Id;
                txtNameUser2.Text = Name;
                cbxType2.Text = Type;
                txtUsername2.Text = Username;
                txtPassword2.Text = Password;
                dtpDateStart2.Text = DateStart;
                txtAddress2.Text = Address;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                String Id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                String Name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                String Type = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                String Username = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                String Password = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                String DateStart = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                String Address = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

                txtIdUser.Text = Id;
                txtNameUser.Text = Name;
                cbxType.Text = Type;
                txtUsername.Text = Username;
                txtPassword.Text = Password;
                dtpDateStart.Text = DateStart;
                txtAddress.Text = Address;
            }
        }

        public void LoadComboBoxTypeUser()
        {
            BUS_User bus_User = new BUS_User();
            List<DTO_TypeUser> listTypeUser = bus_User.SelectAllTypeUser();

            cbxType.DataSource = listTypeUser;
            cbxType.DisplayMember = "Type";
            cbxType.ValueMember = "Id";

            cbxType2.DataSource = listTypeUser;
            cbxType2.DisplayMember = "Type";
            cbxType2.ValueMember = "Id";
        }


        private bool isNull(String text)
        {
            if (text.Trim().Equals(""))
                return true;
            return false;
        }
    }
}
