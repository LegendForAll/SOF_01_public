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
using System.Data.SqlClient;

namespace MCoffee_GUI
{
    public partial class GUI_QLCategory : Form
    {
        BUS_FOOD_CATEGORY food_category_BUS = new BUS_FOOD_CATEGORY();
        public GUI_QLCategory()
        {
            InitializeComponent();
        }

        private void GUI_QLCategory_Load(object sender, EventArgs e)
        {
            List<DTO_FOOD_CATEGORY> listcategory = new List<DTO_FOOD_CATEGORY>();
            food_category_BUS.SelectAll(ref listcategory);
            dgvFoodCategory.Columns.Clear();
            dgvFoodCategory.DataSource = null;
            dgvFoodCategory.AutoGenerateColumns = false;
            //dgvFoodCategory.AllowUserToAddRows = false;
            dgvFoodCategory.DataSource = listcategory;
            DataGridViewTextBoxColumn clID_FOD = new DataGridViewTextBoxColumn();
            clID_FOD.Name = "ID_CAT";
            clID_FOD.HeaderText = "ID";
            clID_FOD.DataPropertyName = "ID_CAT";
            dgvFoodCategory.Columns.Add(clID_FOD);
            DataGridViewTextBoxColumn clDISPLAYNAME = new DataGridViewTextBoxColumn();
            clDISPLAYNAME.Name = "DISPLAYNAME";
            clDISPLAYNAME.HeaderText = "NAME";
            clDISPLAYNAME.DataPropertyName = "DISPLAYNAME";
            dgvFoodCategory.Columns.Add(clDISPLAYNAME);
        }

        private void dgvFoodCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (-1 < numrow && numrow < dgvFoodCategory.RowCount)
            {
                txbID.Text = dgvFoodCategory.Rows[numrow].Cells[0].Value.ToString();
                txbName.Text = dgvFoodCategory.Rows[numrow].Cells[1].Value.ToString();
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dgvFoodCategory.CurrentCellAddress.Y;
            if (-1 < currentRowIndex && currentRowIndex < dgvFoodCategory.RowCount)
            {
                try
                {
                    DTO_FOOD_CATEGORY category_DTO = new DTO_FOOD_CATEGORY();
                    category_DTO.ID_CAT = txbID.Text;
                    category_DTO.DISPLAYNAME = txbName.Text;
                    food_category_BUS.Update(category_DTO);
                    MessageBox.Show("Update thanh cong");
                    GUI_QLCategory_Load(sender, e);
                }
                catch (Exception f)
                { }

                finally
                {

                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dgvFoodCategory.CurrentCellAddress.Y;
            if (-1 < currentRowIndex && currentRowIndex < dgvFoodCategory.RowCount)
            {
                try
                {
                    food_category_BUS.Delete(txbID.Text);
                    MessageBox.Show("Xóa Thành Công");
                    GUI_QLCategory_Load(sender, e);
                }
                catch (Exception f)
                { }

                finally
                {

                }
            }
        }
    }
}
