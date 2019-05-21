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
    public partial class GUI_QLFood : Form
    {
        BUS_FOOD food_BUS = new BUS_FOOD();
        BUS_FOOD_CATEGORY food_category_BUS = new BUS_FOOD_CATEGORY();
        public GUI_QLFood()
        {
            InitializeComponent();
        }

        private void GUI_QLFood_Load(object sender, EventArgs e)
        {
            List<DTO_FOOD_CATEGORY> listcategoryView = new List<DTO_FOOD_CATEGORY>();
            food_category_BUS.SelectAll(ref listcategoryView);
            cbViewCategory.DataSource = listcategoryView;
            cbViewCategory.DisplayMember = "NAMECAT";
            

            List<DTO_FOOD_CATEGORY> listcategory = new List<DTO_FOOD_CATEGORY>();
            food_category_BUS.SelectAll(ref listcategory);
            cbCategory.DataSource = listcategory;
            cbCategory.DisplayMember = "NAMECAT";
            cbIDcategory.DataSource = listcategory;
            cbIDcategory.DisplayMember = "ID_CAT";
            cbIDcategory.Text = "1";

            List<DTO_FOOD> listfood = new List<DTO_FOOD>();
            food_BUS.SelectAllByCategory(ref listfood, cbViewCategory.Text);
            dgvFoodCategory.DataSource = listfood;
            dgvFoodCategory.AllowUserToAddRows = false;
            if (listfood.Count == 0)
            {
                MessageBox.Show("Chưa có nhân viên nào trong danh sách");
            }
            else
            {
                txbID.Text = dgvFoodCategory.CurrentRow.Cells["ID_FOD"].Value.ToString();
                txbName.Text = dgvFoodCategory.CurrentRow.Cells["DISPLAYNAME"].Value.ToString();
                txbPrice.Text = dgvFoodCategory.CurrentRow.Cells["OUTPUTPRICE"].Value.ToString();
            }
            DTO_FOOD food = new DTO_FOOD();
            bool test = food_BUS.SelectAllByName(ref food, txbName.Text);
            if (test)
                pbPicture.Image = new Bitmap(food.PICTURE);
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCategory.Text = cbViewCategory.Text;
            List<DTO_FOOD> listfood = new List<DTO_FOOD>();
            food_BUS.SelectAllByCategory(ref listfood, cbViewCategory.Text);
            dgvFoodCategory.Columns.Clear();
            dgvFoodCategory.DataSource = null;
            dgvFoodCategory.AutoGenerateColumns = false;
            dgvFoodCategory.AllowUserToAddRows = false;
            dgvFoodCategory.DataSource = listfood;
            DataGridViewTextBoxColumn clID_FOD = new DataGridViewTextBoxColumn();
            clID_FOD.Name = "ID_FOD";
            clID_FOD.HeaderText = "ID";
            clID_FOD.DataPropertyName = "ID_FOD";
            dgvFoodCategory.Columns.Add(clID_FOD);
            DataGridViewTextBoxColumn clDISPLAYNAME = new DataGridViewTextBoxColumn();
            clDISPLAYNAME.Name = "DISPLAYNAME";
            clDISPLAYNAME.HeaderText = "NAME";
            clDISPLAYNAME.DataPropertyName = "DISPLAYNAME";
            dgvFoodCategory.Columns.Add(clDISPLAYNAME);
            DataGridViewTextBoxColumn clOUTPUTPRICE = new DataGridViewTextBoxColumn();
            clOUTPUTPRICE.Name = "OUTPUTPRICE";
            clOUTPUTPRICE.HeaderText = "PRICE";
            clOUTPUTPRICE.DataPropertyName = "OUTPUTPRICE";
            dgvFoodCategory.Columns.Add(clOUTPUTPRICE);       
        }

        private void dgvFoodCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (-1 < numrow && numrow < dgvFoodCategory.RowCount)
            {
                txbID.Text = dgvFoodCategory.Rows[numrow].Cells[0].Value.ToString();
                txbName.Text = dgvFoodCategory.Rows[numrow].Cells[1].Value.ToString();
                txbPrice.Text = dgvFoodCategory.Rows[numrow].Cells[2].Value.ToString();
            }
            cbCategory.Text = cbViewCategory.Text;
            DTO_FOOD food = new DTO_FOOD();
            bool test = food_BUS.SelectAllByName(ref food, txbName.Text);
            if (test)
                pbPicture.Image = new Bitmap(food.PICTURE);
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dgvFoodCategory.CurrentCellAddress.Y;
            if (-1 < currentRowIndex && currentRowIndex < dgvFoodCategory.RowCount)
            {
                try
                {
                    DTO_FOOD food_DTO = new DTO_FOOD();
                    food_DTO.ID_FOD = txbID.Text;
                    food_DTO.OUTPUTPRICE = Int32.Parse( txbPrice.Text);
                    food_DTO.DISPLAYNAME = txbName.Text;
                    food_DTO.ID_CAT = cbIDcategory.Text;
                    food_DTO.PICTURE = openFileDialog1.FileName;
                    food_BUS.Update(food_DTO);
                    MessageBox.Show("Update thanh cong");
                    cbCategory_SelectedIndexChanged(sender, e);
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
                    food_BUS.Delete(txbID.Text);
                    MessageBox.Show("Xóa Thành Công");
                    cbCategory_SelectedIndexChanged(sender, e);
                }
                catch (Exception f)
                { }

                finally
                {

                }
            }
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            cbCategory.Text = cbViewCategory.Text;
            List<DTO_FOOD> listfood = new List<DTO_FOOD>();
            food_BUS.Search(ref listfood, cbViewCategory.Text,txbSearch.Text);
            dgvFoodCategory.Columns.Clear();
            dgvFoodCategory.DataSource = null;
            dgvFoodCategory.AutoGenerateColumns = false;
            dgvFoodCategory.AllowUserToAddRows = false;
            dgvFoodCategory.DataSource = listfood;
            DataGridViewTextBoxColumn clID_FOD = new DataGridViewTextBoxColumn();
            clID_FOD.Name = "ID_FOD";
            clID_FOD.HeaderText = "ID";
            clID_FOD.DataPropertyName = "ID_FOD";
            dgvFoodCategory.Columns.Add(clID_FOD);
            DataGridViewTextBoxColumn clDISPLAYNAME = new DataGridViewTextBoxColumn();
            clDISPLAYNAME.Name = "DISPLAYNAME";
            clDISPLAYNAME.HeaderText = "NAME";
            clDISPLAYNAME.DataPropertyName = "DISPLAYNAME";
            dgvFoodCategory.Columns.Add(clDISPLAYNAME);
            DataGridViewTextBoxColumn clOUTPUTPRICE = new DataGridViewTextBoxColumn();
            clOUTPUTPRICE.Name = "OUTPUTPRICE";
            clOUTPUTPRICE.HeaderText = "PRICE";
            clOUTPUTPRICE.DataPropertyName = "OUTPUTPRICE";
            dgvFoodCategory.Columns.Add(clOUTPUTPRICE);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {

        }

        private void btSelectPicture_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                pbPicture.Image = new Bitmap(openFileDialog1.FileName);
            }
        }
    }
}
