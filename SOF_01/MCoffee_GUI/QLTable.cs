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
    public partial class QLTable : Form
    {
        BUS_TABLE table_BUS = new BUS_TABLE();
        BUS_FOOD food_BUS = new BUS_FOOD();
        BUS_FOOD_CATEGORY food_category_BUS = new BUS_FOOD_CATEGORY();
        BUS_BILL bill_BUS = new BUS_BILL();
        BUS_BILL_INFO bill_info_BUS = new BUS_BILL_INFO();
        public QLTable()
        {
            InitializeComponent();
        }
        private void LoadTable()
        {
            flpTable.Controls.Clear();
            List<DTO_TABLE> ListTable = new List<DTO_TABLE>();
            table_BUS.SelectAll(ref ListTable);
            foreach (DTO_TABLE item in ListTable)
            {
                Button btn = new Button() { Width = 100, Height = 100 };
                btn.Tag = item;
                btn.Click += btn_Click;
                switch (item.STATUS)
                {
                    case 0:
                        btn.BackColor = Color.Aqua;
                        btn.Text = "Ban " + item.NUMBER + "\ncó người";
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        btn.Text = "Ban " + item.NUMBER + "\ntrống";
                        break;
                }

                flpTable.Controls.Add(btn);
            }
        }
        private void QLTable_Load(object sender, EventArgs e)
        {

            List<DTO_FOOD_CATEGORY> listcategory = new List<DTO_FOOD_CATEGORY>();
            food_category_BUS.SelectAll(ref listcategory);
            cbCategory.DataSource = listcategory;
            cbCategory.DisplayMember = "DISPLAYNAME";
            cbCategory.Text = listcategory[0].DISPLAYNAME;

            List<DTO_FOOD> listfood = new List<DTO_FOOD>();
            food_BUS.SelectAllByCategory(ref listfood, cbCategory.Text);
            cbFood.DataSource = listfood;
            cbFood.DisplayMember = "DISPLAYNAME";
            cbFood.Text = listfood[0].DISPLAYNAME;
            LoadTable();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbFood.Text = null;
            List<DTO_FOOD> listfood = new List<DTO_FOOD>();
            food_BUS.SelectAllByCategory(ref listfood, (cbCategory.SelectedItem as DTO_FOOD_CATEGORY).DISPLAYNAME);
            cbFood.DataSource = listfood;
            cbFood.DisplayMember = "DISPLAYNAME";
        }
        void btn_Click(object sender, EventArgs e)
        {
            string tableID = ((sender as Button).Tag as DTO_TABLE).ID_TAB;
            lvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
            int sumprice = 0;
            String IdBill = "1";
            bool test = bill_BUS.FindIdBillByIdTable(ref IdBill, tableID.ToString());
            if (!test)
                sumprice = 0;
            else
                bill_info_BUS.Sumprice(ref sumprice, IdBill);
            lbTongTien.Text ="Sum:"+ sumprice.ToString();
        }
        void ShowBill(string id)
        {
            lvBill.Items.Clear();
            List<DTO_Menu> listmenu=new List<DTO_Menu>();
            bill_info_BUS.SelectAllByTableNumber(ref listmenu, id.ToString());
            foreach (DTO_Menu item in listmenu)
            {
                ListViewItem lsvItem = new ListViewItem(item.DISPLAYNAME.ToString());
                lsvItem.SubItems.Add(item.COUNT.ToString());
                lsvItem.SubItems.Add(item.PRICE.ToString());
                lvBill.Items.Add(lsvItem);
            }

        }

        private void btThemMon_Click(object sender, EventArgs e)
        {
            DTO_TABLE table = lvBill.Tag as DTO_TABLE;
            DTO_BILL_INFO bill_info = new DTO_BILL_INFO();
            int ID_BillInfo = 1;
            bill_info_BUS.NextID(ref ID_BillInfo);
            bill_info.ID_BILF = ID_BillInfo.ToString();
            bill_info.COUNT = Convert.ToInt32(nupCount.Value);
            String IdBill="1";
            bool test=bill_BUS.FindIdBillByIdTable(ref IdBill, table.NUMBER.ToString());
            if (!test)
            { 
                DTO_BILL bill = new DTO_BILL();
                int ID_Bill = 1;
                bill_BUS.NextID(ref ID_Bill);
                IdBill = ID_Bill.ToString();
                bill.ID_BIL = ID_Bill.ToString();
                bill.ID_TAB = table.ID_TAB.ToString();
                bill.STATUS = "1";
                bill.SUBPRICE =0;
                bill.SUMPRICE = 0;
                bill.ID_EMP = "A";
                bill.DATETIME = DateTime.Now;
                bill_BUS.Insert(bill);
            }
            DTO_FOOD food = new DTO_FOOD();
            food_BUS.SelectAllByName(ref food, cbFood.Text);
            bill_info.ID_FOD = food.ID_FOD;
            bill_info.ID_BIL = IdBill;
            bill_info.PRICE = bill_info.COUNT * food.OUTPUTPRICE;
            bill_info_BUS.Insert(bill_info);
            int sumprice = 0;
            bill_info_BUS.Sumprice(ref sumprice, IdBill);
            bill_BUS.UpdateSumPrice(sumprice, IdBill);
            ShowBill(table.NUMBER);
            table_BUS.UpdateStatus(table.NUMBER.ToString(), 0);
            LoadTable();
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            DTO_TABLE table = lvBill.Tag as DTO_TABLE;
            String IdBill = "1";
            bool test = bill_BUS.FindIdBillByIdTable(ref IdBill, table.NUMBER.ToString());
            if(test)
            {
                bill_BUS.UpdateSubPrice(Int32.Parse(txtSubPrice.Text), IdBill);
                table_BUS.UpdateStatus(table.NUMBER.ToString(), 1);
                bill_BUS.UpdateStatus(IdBill,"0");
                LoadTable();
                ShowBill(table.NUMBER);
            }
        }

        private void cbFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            DTO_FOOD food = new DTO_FOOD();
            bool test = food_BUS.SelectAllByName(ref food, cbFood.Text);
            if(test)
                pbFood.Image = new Bitmap(food.PICTURE);
        }
    }
}
