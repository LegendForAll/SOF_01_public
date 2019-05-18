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
    public partial class GUI_RESEARCH : Form
    {
        BUS_FOOD_CATEGORY cate_BUS = new BUS_FOOD_CATEGORY();
        BUS_FOOD food_BUS = new BUS_FOOD();
        BUS_Object object_BUS = new BUS_Object();
        BUS_Suplier suplier_BUS = new BUS_Suplier();

        List<DTO_FOOD> listFood;
        List<DTO_Object2> listOb;

        public GUI_RESEARCH()
        {
            InitializeComponent();
            loadFlowPanel();

            dgv_object.AutoGenerateColumns = false;
            dgv_object.AllowUserToAddRows = false;
            loadGridView();
            loadCombobox();
        }

        public void loadGridView()
        {
            listOb = new List<DTO_Object2>();
            listOb = object_BUS.SelectAll();

            dgv_object.DataSource = listOb;
            G_ID.DataPropertyName = "ID";
            G_NAME.DataPropertyName = "DISPLAYNAME";
            G_SUPLIER.DataPropertyName = "SUPLIERNAME";
            G_UNIT.DataPropertyName = "UNITNAME";
            G_NUM.DataPropertyName = "NUM_REPO";
        }

        public void loadCombobox()
        {
            List<DTO_Suplier> listSup = new List<DTO_Suplier>();
            listSup = suplier_BUS.SelectAll();

            cbx_suplier.DataSource = new BindingSource(listSup, String.Empty);
            cbx_suplier.DisplayMember = "DISPLAYNAME";
            cbx_suplier.ValueMember = "ID";
        }

        public void loadFlowPanel()
        {
            List<DTO_FOOD_CATEGORY> listCate = new List<DTO_FOOD_CATEGORY>();
            cate_BUS.SelectAll(ref listCate);

            fpn_category.Controls.Clear();

            //flowpanel
            foreach (DTO_FOOD_CATEGORY item in listCate)
            {
                //create button table
                Button btn = new Button();
                btn.Text = item.NAMECAT + Environment.NewLine;
                btn.Size = new Size(80, 80);
                fpn_category.Controls.Add(btn);

                //add event button_click
                btn.Click += Btn_Click;
                btn.Tag = item;
            }
        }

        public void ShowFood(String category)
        {
            listFood = new List<DTO_FOOD>();
            food_BUS.SelectAllByCategory(ref listFood, category);
            fpn_food.Controls.Clear();

            //flowpanel
            foreach (DTO_FOOD item in listFood)
            {
                //create button table
                Button btn_food = new Button();
                btn_food.Text = item.DISPLAYNAME + Environment.NewLine + item.OUTPUTPRICE;
                btn_food.Size = new Size(100, 80);
                fpn_food.Controls.Add(btn_food);

                //add event button_click
                btn_food.Tag = item;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            String cate = ((sender as Button).Tag as DTO_FOOD_CATEGORY).NAMECAT;
            MessageBox.Show("ID: " + cate);
            ShowFood(cate);
        }

        private void cbx_price_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listFood != null)
            {
                fpn_food.Controls.Clear();

                //flowpanel
                foreach (DTO_FOOD item in listFood)
                {
                    //create button table
                    Double temp = Convert.ToDouble(item.OUTPUTPRICE);
                    if(temp >= Convert.ToDouble(cbx_price.Text))
                    {
                        Button btn_food = new Button();
                        btn_food.Text = item.DISPLAYNAME + Environment.NewLine + item.OUTPUTPRICE;
                        btn_food.Size = new Size(100, 80);
                        fpn_food.Controls.Add(btn_food);

                        //add event button_click
                        btn_food.Tag = item;
                    }
                }
            }
        }

        private void cbx_suplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            listOb = new List<DTO_Object2>();
            listOb = object_BUS.Select_SUPLIER(cbx_suplier.Text);

            dgv_object.DataSource = listOb;
            G_ID.DataPropertyName = "ID";
            G_NAME.DataPropertyName = "DISPLAYNAME";
            G_SUPLIER.DataPropertyName = "SUPLIERNAME";
            G_UNIT.DataPropertyName = "UNITNAME";
            G_NUM.DataPropertyName = "NUM_REPO";
        }

        private void tbx_object_TextChanged(object sender, EventArgs e)
        {
            listOb = new List<DTO_Object2>();
            listOb = object_BUS.Select_NAME(tbx_object.Text);

            dgv_object.DataSource = listOb;
            G_ID.DataPropertyName = "ID";
            G_NAME.DataPropertyName = "DISPLAYNAME";
            G_SUPLIER.DataPropertyName = "SUPLIERNAME";
            G_UNIT.DataPropertyName = "UNITNAME";
            G_NUM.DataPropertyName = "NUM_REPO";
        }
    }
}
