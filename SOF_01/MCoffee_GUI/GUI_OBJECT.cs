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
    public partial class GUI_OBJECT : Form
    {
        BUS_Object bus_object = new BUS_Object();
        public GUI_OBJECT()
        {
            InitializeComponent();
            tbID.Text = bus_object.nextID().ToString();
            dataGridViewObject.AutoGenerateColumns = false;
            dataGridViewObject.AllowUserToAddRows = false;
            
            LoadDataGridViewObject();
            LoadComboBoxSuplier();
            LoadComboBoxUnit();
        }

        public bool isNull(String text)
        {
            if (text.Trim().Equals(""))
                return true;
            return false;
        }
        public void LoadDataGridViewObject()
        {
            List<DTO_Object2> listObject = bus_object.SelectAll();
            dataGridViewObject.DataSource = listObject;
            ID.DataPropertyName = "ID";
            DISPLAYNAME.DataPropertyName = "DISPLAYNAME";
            SUPLIER.DataPropertyName = "SUPLIERNAME";
            UNIT.DataPropertyName = "UNITNAME";
            NUMBER_REPO.DataPropertyName = "NUM_REPO";
        }

        public void LoadComboBoxSuplier()
        {
            BUS_Suplier bus_suplier = new BUS_Suplier();
            List<DTO_Suplier> listSuplier = bus_suplier.SelectAll();

            cbSuplier.DataSource = listSuplier;
            cbSuplier.DisplayMember = "DISPLAYNAME";
            cbSuplier.ValueMember = "ID";
        }

        public void LoadComboBoxUnit()
        {
            BUS_Unit bus_unit = new BUS_Unit();
            List<DTO_Unit> listUnit = bus_unit.SelectAll();

            cbUnit.DataSource = listUnit;
            cbUnit.DisplayMember = "DISPLAYNAME";
            cbUnit.ValueMember = "ID";
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (isNull(tbName.Text) || isNull(tbNumberRepo.Text))
            {
                MessageBox.Show("Thông tin nguyên liệu không hợp lệ", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            String id = tbID.Text;
            String name = tbName.Text;
            String id_sup = cbSuplier.SelectedValue.ToString();
            String id_uni = cbUnit.SelectedValue.ToString();
            int num_repo = Int16.Parse(tbNumberRepo.Text);

            DTO_Object obj = new DTO_Object(id, name, id_sup, id_uni, num_repo);
            Result result = bus_object.insert(obj);
            if (result.Flag)
            {
                MessageBox.Show("Thêm mới nguyên liệu thành công", "Successful", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                tbID.Text = bus_object.nextID().ToString();
                tbName.Text = String.Empty;
                tbNumberRepo.Text = String.Empty;
                LoadDataGridViewObject();
            }
            else
                MessageBox.Show("Thêm mới nguyên liệu thất bại \nError: " + result.Message, "Failed", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void dataGridViewObject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String id = dataGridViewObject.Rows[e.RowIndex].Cells[0].Value.ToString();
            String name = dataGridViewObject.Rows[e.RowIndex].Cells[1].Value.ToString();
            String suplier = dataGridViewObject.Rows[e.RowIndex].Cells[2].Value.ToString();
            String unit = dataGridViewObject.Rows[e.RowIndex].Cells[3].Value.ToString();
            String num_repo = dataGridViewObject.Rows[e.RowIndex].Cells[4].Value.ToString();

            tbID.Text = id;
            tbName.Text = name;
            tbNumberRepo.Text = num_repo;
            cbSuplier.SelectedIndex = cbSuplier.FindString(suplier);
            cbUnit.SelectedIndex = cbUnit.FindString(unit);
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (isNull(tbName.Text) || isNull(tbNumberRepo.Text))
            {
                MessageBox.Show("Thông tin nguyên liệu không hợp lệ", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            String id = tbID.Text;
            String name = tbName.Text;
            String id_sup = cbSuplier.SelectedValue.ToString();
            String id_uni = cbUnit.SelectedValue.ToString();
            int num_repo = Int16.Parse(tbNumberRepo.Text);

            DTO_Object obj = new DTO_Object(id, name, id_sup, id_uni, num_repo);
            if (bus_object.isExist(id))
            {
                Result result = bus_object.update(obj);
                if (result.Flag)
                {
                    MessageBox.Show("Sửa nguyên liệu thành công", "Successful", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    LoadDataGridViewObject();
                }
                else
                    MessageBox.Show("Sửa nguyên liệu không thành công \nError: " + result.Message, "Failed", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Không tồn tại nguyên liệu" , "Failed", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            String id = tbID.Text;
            String name = tbName.Text;

            if (bus_object.isExist(id))
            {
                DialogResult resultDialog = MessageBox.Show("Bạn có thực sự muốn xóa nguyên liệu " + name,
                    "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resultDialog == DialogResult.Yes)
                {
                    Result result = bus_object.delete(id);
                    if (result.Flag)
                    {
                        MessageBox.Show("Xóa nguyên liệu thành công", "Successful", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        LoadDataGridViewObject();
                    }
                    else
                        MessageBox.Show("Xóa nguyên liệu không thành công \nError: " + result.Message, "Failed", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Không tồn tại nguyên liệu ", "Failed", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            String id = bus_object.nextID();
            tbID.Text = id.ToString();
            tbName.Text = String.Empty;
            tbNumberRepo.Text = String.Empty;
        }
    }
}
