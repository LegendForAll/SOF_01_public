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
    public partial class GUI_AddFoodCategory : Form
    {
        BUS_FOOD_CATEGORY food_category_BUS = new BUS_FOOD_CATEGORY();
        public GUI_AddFoodCategory()
        {
            InitializeComponent();
        }

        private void GUI_AddFoodCategory_Load(object sender, EventArgs e)
        {
            String nextID = "";
            food_category_BUS.NextID(ref nextID);
            txbID.Text = nextID.ToString();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            DTO_FOOD_CATEGORY food_category_DTO = new DTO_FOOD_CATEGORY();
            food_category_DTO.ID_CAT = txbID.Text;
            food_category_DTO.NAMECAT = txbName.Text;
            bool result = food_category_BUS.Insert(food_category_DTO);

            if(result)
            {
                MessageBox.Show("Inserted...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                String nextID = "";
                food_category_BUS.NextID(ref nextID);
                txbID.Text = nextID.ToString();
            }
            else
            {
                MessageBox.Show("Error...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
