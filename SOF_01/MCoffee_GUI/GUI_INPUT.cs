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
    public partial class GUI_INPUT : Form
    {
        BUS_Object bus_object = new BUS_Object();
        BUS_Input bus_input = new BUS_Input();
        BUS_InputInfo bus_input_info = new BUS_InputInfo();
        List<int> listOldCount;

        public GUI_INPUT()
        {
            InitializeComponent();
            String nextID = bus_input.nextID();
            tbID.Text = nextID.ToString();
            dataGridViewInput.AutoGenerateColumns = false;
            dataGridViewInput.AllowUserToAddRows = false;

            dataGridViewInputInfo.AutoGenerateColumns = false;
            LoadDataGridComboBoxColumn();
            LoadDataGridInput();
        }

        public void LoadDataGridComboBoxColumn()
        {
            List<DTO_Object2> objects = bus_object.SelectAll();
            OBJECT.DataSource = new BindingSource(objects, String.Empty);
            OBJECT.DisplayMember = "DISPLAYNAME";
            OBJECT.ValueMember = "ID";
        }

        public void LoadDataGridInput()
        {
            List<DTO_Input> listInput = bus_input.SelectAll();
            dataGridViewInput.DataSource = listInput;
            ID.DataPropertyName = "ID";
            DATEINPUT.DataPropertyName = "DATEINPUT";
        }

        public void LoadDataGridInputInfo(String id_input)
        {
            List<DTO_InputInfo> listInfo = bus_input_info.SelectAll(id_input);
            dataGridViewInputInfo.DataSource = listInfo;
            OBJECT.DataPropertyName = "ID_OBJ";
            EMPLOYEE.DataPropertyName = "ID_EMP";
            Count.DataPropertyName = "COUNT";
            PRICEINPUT.DataPropertyName = "INPUTPRICE";
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            String id = tbID.Text;
            DateTime date_input = dtpInput.Value;

            DTO_Input input = new DTO_Input(id, date_input);
            DTO_InputInfo input_info = new DTO_InputInfo();
            int i = 0;

            List<DTO_InputInfo> list = new List<DTO_InputInfo>();
            if (bus_input.isExist(id))
            {
                MessageBox.Show("Tồn tại phiếu nhập", "Failed", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                return;
            }

            Result result = bus_input.insert(input);

            if (result.Flag)
            {
                for (i = 0; i < dataGridViewInputInfo.RowCount - 1; i++)
                {
                    input_info.ID = bus_input_info.nextID();
                    input_info.ID_INP = id;
                    input_info.ID_OBJ = dataGridViewInputInfo.Rows[i].Cells[0].Value.ToString();
                    input_info.ID_EMP = dataGridViewInputInfo.Rows[i].Cells[1].Value.ToString();
                    input_info.COUNT = Int16.Parse(dataGridViewInputInfo.Rows[i].Cells[2].Value.ToString());
                    input_info.INPUTPRICE = dataGridViewInputInfo.Rows[i].Cells[3].Value.ToString();

                    int num = bus_object.getNum_Repo(input_info.ID_OBJ);
                    bus_object.updateNumRepo(input_info.ID_OBJ, num + input_info.COUNT);
                    result = bus_input_info.insert(input_info);
                }

                if (result.Flag)
                {
                    MessageBox.Show("Tạo phiếu nhập thành công", "Sucessfull", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    btReset_Click(sender, e);
                    LoadDataGridInput();
                }
                else
                    MessageBox.Show("Tạo thông tin phiếu nhập không thành công \nError: " + result.Message, "Failed", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Tạo phiếu nhập không thành công \nError: " + result.Message, "Failed", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
        }

        private void dataGridViewInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String id = dataGridViewInput.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            tbID.Text = id.ToString();
            dtpInput.Value = (DateTime) dataGridViewInput.Rows[e.RowIndex].Cells["DATEINPUT"].Value;
            LoadDataGridInputInfo(id);

            listOldCount = new List<int>();
            listOldCount.Clear();
            for (int i = 0; i < dataGridViewInputInfo.RowCount; i++)
            {
                int count = Int16.Parse(dataGridViewInputInfo.Rows[i].Cells["Count"].Value.ToString());
                listOldCount.Add(count);
            }
               
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            String id = bus_input.nextID();
            tbID.Text = id.ToString();
            dataGridViewInputInfo.DataSource = null;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            int i;
            String id = tbID.Text;
            
            if (!bus_input.isExist(id))
            {
                MessageBox.Show("Không tồn tại phiếu nhập", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DTO_Input input = new DTO_Input();
            input.ID = id;
            input.DATEINPUT = dtpInput.Value;

            DTO_InputInfo info = new DTO_InputInfo();
            List<DTO_InputInfo> listInfo = bus_input_info.SelectAll(id);

            Result result = bus_input.update(input);
            if (result.Flag)
            {
                for (i = 0; i < dataGridViewInputInfo.RowCount; i++)
                {
                    info.ID = listInfo[i].ID;
                    info.ID_INP = id;
                    info.ID_OBJ = dataGridViewInputInfo.Rows[i].Cells["OBJECT"].Value.ToString();
                    info.ID_EMP = dataGridViewInputInfo.Rows[i].Cells["EMPLOYEE"].Value.ToString();
                    info.COUNT = Int16.Parse(dataGridViewInputInfo.Rows[i].Cells["Count"].Value.ToString());
                    info.INPUTPRICE = dataGridViewInputInfo.Rows[i].Cells["PRICEINPUT"].Value.ToString();
                    
                    result = bus_input_info.update(info);

                    int delta = listOldCount[i] - info.COUNT;
                    if (delta != 0)
                    {
                        int num_repo = bus_object.getNum_Repo(info.ID_OBJ);
                        bus_object.updateNumRepo(info.ID_OBJ, num_repo + Math.Abs(delta));
                    }
                }
                    if (result.Flag)
                    {
                        MessageBox.Show("Sửa thông tin phiếu nhập thành công", "Successful", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        LoadDataGridInput();
                        LoadDataGridInputInfo(id);
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin phiếu nhập không thành công \nError: " + result.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            else
                MessageBox.Show("Sửa thông tin phiếu nhập không thành công \nError: " + result.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            String id = tbID.Text;
            if (!bus_input.isExist(id))
            {
                MessageBox.Show("Không tồn tại phiếu nhập", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Result result = bus_input_info.delete(id);
            if (result.Flag)
            {
                result = bus_input.delete(id);

                if (result.Flag)
                {
                    MessageBox.Show("Xóa phiếu nhập thành công", "Successfull", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    btReset_Click(sender, e);
                    LoadDataGridInput();
                }
                else
                    MessageBox.Show("Xóa phiếu nhập không thành công \n" + result.Message, "Failed", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Xóa thông tin phiếu nhập không thành công \n" + result.Message, "Failed", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
            }
        }
    }
}
