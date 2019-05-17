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
    public partial class GUI_UNIT : Form
    {
        BUS_Unit bus_unit = new BUS_Unit();
        public GUI_UNIT()
        {
            InitializeComponent();
            tbID.Text = bus_unit.nextID().ToString();
            dataGridViewUnit.AutoGenerateColumns = false;
            dataGridViewUnit.AllowUserToAddRows = false;
            LoadDataGridViewUnit();
        }

        public bool isNull(String text)
        {
            if (text.Trim().Equals(""))
                return true;
            return false;
        }
        public void LoadDataGridViewUnit()
        {           
            List<DTO_Unit> listUnit = bus_unit.SelectAll();

            dataGridViewUnit.DataSource = listUnit;
            ID.DataPropertyName = "ID";
            DISPLAYNAME.DataPropertyName = "DisplayName";
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            String id = tbID.Text;
            String name = tbName.Text;
            DTO_Unit unit = new DTO_Unit(id, name);
            
            if (isNull(tbName.Text))
            {
                MessageBox.Show("Tên đơn vị không hợp lệ", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Result result = bus_unit.insert(unit);
            if (result.Flag)
            {
                MessageBox.Show("Thêm mới đơn vị thành công", "Successful", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                tbID.Text = bus_unit.nextID().ToString();
                tbName.Text = String.Empty;
                LoadDataGridViewUnit();
            }
            else
            {
                MessageBox.Show("Thêm mới đơn vị thất bại \nError: " + result.Message, "Failed", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            String id = tbID.Text;
            String name = tbName.Text;
            if (bus_unit.isExist(id))
            {
                DialogResult resultDialog = MessageBox.Show("Bạn có thực sự muốn xóa đơn vị " + name,
                    "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resultDialog == DialogResult.Yes)
                {
                    Result result = bus_unit.delete(id);
                    if (result.Flag)
                    {
                        MessageBox.Show("Xóa đơn vị thành công", "Successful", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        tbID.Text = bus_unit.nextID().ToString();
                        tbName.Text = String.Empty;
                        LoadDataGridViewUnit();
                    }
                    else
                    {
                        MessageBox.Show("Xóa đơn vị thất bại \nError: " + result.Message, "Failed", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("Không tồn tại đơn vị", "Failed", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            String id = tbID.Text;
            String name = tbName.Text;

            if (isNull(tbName.Text))
            {
                MessageBox.Show("Tên đơn vị không hợp lệ", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (bus_unit.isExist(id))
            {
                DTO_Unit unit = new DTO_Unit(id, name);
                Result result = bus_unit.update(unit);
                if (result.Flag)
                {
                    MessageBox.Show("Sửa đơn vị thành công", "Successful", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    LoadDataGridViewUnit();
                }
                else
                {
                    MessageBox.Show("Sửa đơn vị thất bại \nError: " + result.Message, "Failed", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Không tồn tại đơn vị", "Failed", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            tbID.Text = bus_unit.nextID().ToString();
            tbName.Text = String.Empty;
        }

        private void DataGridUnit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                String id = dataGridViewUnit.Rows[e.RowIndex].Cells[0].Value.ToString();
                String name = dataGridViewUnit.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbID.Text = id.ToString();
                tbName.Text = name;
            }
        }
    }
}
