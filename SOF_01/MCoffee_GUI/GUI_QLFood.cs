﻿using System;
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
            cbViewCategory.Items.Add(listcategoryView);
            cbViewCategory.DataSource = listcategoryView;
            cbViewCategory.DisplayMember = "NAMECAT";
            cbViewCategory.ValueMember = "ID_CAT";


            List<DTO_FOOD_CATEGORY> listcategory = new List<DTO_FOOD_CATEGORY>();
            food_category_BUS.SelectAll(ref listcategory);
            cbCategory.Items.Add(listcategory);
            cbCategory.DataSource = listcategory;
            cbCategory.DisplayMember = "NAMECAT";
            cbCategory.ValueMember = "ID_CAT";

            List<DTO_FOOD> listfood = new List<DTO_FOOD>();
            food_BUS.SelectAllByCategory(ref listfood, cbViewCategory.Text);
            dgvFoodCategory.DataSource = listfood;
            dgvFoodCategory.AllowUserToAddRows = false;
            if (listfood.Count == 0)
            {
                MessageBox.Show("Food is null.");
            }
            else
            {
                txbID.Text = dgvFoodCategory.CurrentRow.Cells["ID_FOD"].Value.ToString();
                txbName.Text = dgvFoodCategory.CurrentRow.Cells["DISPLAYNAME"].Value.ToString();
                txbPrice.Text = dgvFoodCategory.CurrentRow.Cells["OUTPUTPRICE"].Value.ToString();
            }
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
                    food_DTO.OUTPUTPRICE = txbPrice.Text;
                    food_DTO.DISPLAYNAME = txbName.Text;
                    food_DTO.ID_CAT = cbCategory.SelectedValue.ToString();

                    bool result = food_BUS.Update(food_DTO);

                    if(result)
                    {
                        MessageBox.Show("Updated...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbCategory_SelectedIndexChanged(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Error...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                   
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
                    MessageBox.Show("Deleted...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbCategory_SelectedIndexChanged(sender, e);
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
