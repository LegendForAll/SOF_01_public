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
    public partial class GUI_AddFood : Form
    {
        BUS_FOOD food_BUS = new BUS_FOOD();
        BUS_FOOD_CATEGORY food_category_BUS = new BUS_FOOD_CATEGORY();
        public GUI_AddFood()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            DTO_FOOD food_DTO= new DTO_FOOD();
            food_DTO.ID_FOD = txbID.Text;
            food_DTO.ID_CAT = cbCategory.SelectedValue.ToString();
            food_DTO.DISPLAYNAME = txbName.Text;
            food_DTO.OUTPUTPRICE = txbPrice.Text;

            bool result =  food_BUS.Insert(food_DTO);

            if(result)
            {
                MessageBox.Show("Inserted...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                String nextID = "";
                food_BUS.NextID(ref nextID);
                txbID.Text = nextID.ToString();
            }
            else
            {
                MessageBox.Show("Error...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void GUI_AddFood_Load(object sender, EventArgs e)
        {
            String nextID = "";
            food_BUS.NextID(ref nextID);
            txbID.Text = nextID.ToString();

            List<DTO_FOOD_CATEGORY> listcategory = new List<DTO_FOOD_CATEGORY>();
            food_category_BUS.SelectAll(ref listcategory);

            cbCategory.Items.Add(listcategory);
            cbCategory.DataSource = listcategory;
            cbCategory.DisplayMember = "NAMECAT";
            cbCategory.ValueMember = "ID_CAT";
        }
    }
}
