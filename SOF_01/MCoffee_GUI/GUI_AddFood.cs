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
            food_DTO.ID_CAT = cbIDCAT.Text;
            food_DTO.DISPLAYNAME = txbName.Text;
            food_DTO.OUTPUTPRICE = Int32.Parse(txbPrice.Text);
            food_DTO.PICTURE = openFileDialog1.FileName;
            food_BUS.Insert(food_DTO);
            int nextID = 0;
            food_BUS.NextID(ref nextID);
            txbID.Text = nextID.ToString();
        }

        private void GUI_AddFood_Load(object sender, EventArgs e)
        {
            int nextID = 0;
            food_BUS.NextID(ref nextID);
            txbID.Text = nextID.ToString();
            List<DTO_FOOD_CATEGORY> listcategory=new List<DTO_FOOD_CATEGORY>();
            food_category_BUS.SelectAll(ref listcategory);
            cbCategory.Items.Add(listcategory);
            cbCategory.DataSource = listcategory;
            cbCategory.DisplayMember = "NAMECAT";
            cbIDCAT.DataSource = cbCategory.DataSource;
            cbIDCAT.DisplayMember = "ID_CAT";
            cbIDCAT.Text = "1";
        }

        private void btSelectPicture_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                pbPicture.Image = new Bitmap( openFileDialog1.FileName);
            }
        }
    }
}
