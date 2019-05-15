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
    public partial class GUI_SUPLIER : Form
    {
        BUS_Suplier bus_suplier = new BUS_Suplier();
        public GUI_SUPLIER()
        {
            InitializeComponent();
            BUS_Suplier bus_suplier = new BUS_Suplier();
            String nextID = bus_suplier.nextID();
            tbId.Text = nextID.ToString();
        }

        public  bool isNull(String text)
        {
            if (text.Trim().Equals(""))
                return true;
            return false;
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            if (isNull(tbName.Text) || isNull(tbAddress.Text) || isNull(tbPhoneNumber.Text))
            {
                MessageBox.Show("Thông tin nhà cung cấp không hợp lệ", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            String id = tbId.Text;
            String name = tbName.Text;
            String address = tbAddress.Text;
            String phone = tbPhoneNumber.Text;
            DateTime contract = dtContract.Value;

            DTO_Suplier suplier = new DTO_Suplier(id, name, address, phone, contract);          
            Result result = bus_suplier.insert(suplier);
            if (result.Flag)
            {
                MessageBox.Show("Thêm nhà cung cấp thành công", "Successful", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                btReset_Click_1(sender, e);

                GUI_SUPLIER_Load(sender, e);
            }
            else
                MessageBox.Show("Thêm nhà cung cấp không thành công \nError: " + result.Message, "Failed", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void GUI_SUPLIER_Load(object sender, EventArgs e)
        {
            BUS_Suplier bus_suplier = new BUS_Suplier();
            List<DTO_Suplier> listSuplier = bus_suplier.SelectAll();

            dataGridSuplier.AutoGenerateColumns = false;
            dataGridSuplier.AllowUserToAddRows = false;
            dataGridSuplier.DataSource = listSuplier;

            ID.DataPropertyName = "ID";
            DISPLAYNAME.DataPropertyName = "DISPLAYNAME";
            ADDRESS.DataPropertyName = "ADDRESS";
            PHONENUMBER.DataPropertyName = "PHONENUMBER";
            CONTRACTDATE.DataPropertyName = "CONTRACTDATE";
        }

        private void dataGridSuplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                tbId.Text = dataGridSuplier.Rows[row].Cells[0].Value.ToString();
                tbName.Text = dataGridSuplier.Rows[row].Cells[1].Value.ToString();
                tbAddress.Text = dataGridSuplier.Rows[row].Cells[2].Value.ToString();
                tbPhoneNumber.Text = dataGridSuplier.Rows[row].Cells[3].Value.ToString();
                dtContract.Value = (DateTime)dataGridSuplier.Rows[row].Cells[4].Value;
            }           
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (isNull(tbName.Text) || isNull(tbAddress.Text) || isNull(tbPhoneNumber.Text))
            {
                MessageBox.Show("Tên đơn vị không hợp lệ", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            String Id = tbId.Text;
            String name = tbName.Text;
            String address = tbAddress.Text;
            String phone = tbPhoneNumber.Text;
            DateTime contract = dtContract.Value;

            DTO_Suplier suplier = new DTO_Suplier(Id, name, address, phone, contract);
            if (bus_suplier.isExist(Id))
            {

                Result result = bus_suplier.update(suplier);
                if (result.Flag)
                {
                    MessageBox.Show("Sửa nhà cung cấp thành công", "Successful", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    GUI_SUPLIER_Load(sender, e);

                }
                else
                    MessageBox.Show("Sửa nhà cung cấp thất bại \nError: " + result.Message, "Failed", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Không tồn tại nhà cung cấp", "Failed", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            String id = tbId.Text;
            String name = tbName.Text;

            if (bus_suplier.isExist(id))
            {               
                DialogResult resultDialog = MessageBox.Show("Bạn có muốn xóa nhà cung cấp " + name, "Information", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);
                if (resultDialog == DialogResult.Yes)
                {
                    Result result = bus_suplier.delete(id);
                    if (result.Flag)
                    {
                        MessageBox.Show("Xóa nhà cung cấp thành công", "Sucessful", MessageBoxButtons.OK,
                           MessageBoxIcon.Information);

                        GUI_SUPLIER_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhà cung cấp thất bại \nError: " + result.Message, "Failed", MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("Không tồn tại nhà cung cấp", "Failed", MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
        }

        private void btReset_Click_1(object sender, EventArgs e)
        {
            BUS_Suplier bus_suplier = new BUS_Suplier();
            String id = bus_suplier.nextID();
            tbId.Text = id.ToString();
            tbName.Text = String.Empty;
            tbAddress.Text = String.Empty;
            tbPhoneNumber.Text = String.Empty;
            dtContract.Value = DateTime.Now;
        }
    }
}
