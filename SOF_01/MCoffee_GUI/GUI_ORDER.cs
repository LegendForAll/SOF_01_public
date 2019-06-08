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
    public partial class GUI_ORDER : Form
    {

        BUS_BILL bus_bill = new BUS_BILL();
        BUS_BILL_INFO bus_infoBill = new BUS_BILL_INFO();
        BUS_Table tab_BUS = new BUS_Table();
        BUS_FOOD_CATEGORY food_category_BUS = new BUS_FOOD_CATEGORY();
        BUS_FOOD food_BUS = new BUS_FOOD();
        BUS_Table table_BUS = new BUS_Table();
        public DTO_BILL bill;
        List<DTO_Menu> listbill_info = new List<DTO_Menu>();
        List<DTO_BILL_INFO> list_in = new List<DTO_BILL_INFO>();
        int status_tab;

        int isOder = 0;


        public GUI_ORDER()
        {
            InitializeComponent();
            LoadDataGridBill();
        }

        public void LoadDataGridBill()
        {

            //button load
            btn_order.Enabled = false;
            btn_add.Enabled = false;
            btn_reset.Enabled = false;
            btn_submit.Enabled = false;

            List<DTO_BILL> listbill = bus_bill.SelectAll();

            fpn_table.Controls.Clear();
            //table
            List<DTO_Table> listtab = tab_BUS.SelectAll();
            //flowpanel
            foreach (DTO_Table item in listtab)
            {
                if (item.AREA != "AR1_DEL")
                {
                    //create button table
                    Button btn = new Button();
                    btn.Text = item.ID + Environment.NewLine;
                    btn.Size = new Size(80, 80);
                    fpn_table.Controls.Add(btn);

                    //add event button_click
                    btn.Click += Btn_Click;
                    btn.Tag = item;

                    //set color
                    switch (item.STATUS.ToString())
                    {
                        case "1":
                            {
                                btn.BackColor = Color.Silver;
                                break;
                            }
                        case "0":
                            {
                                btn.BackColor = Color.White;
                                break;
                            }
                    }
                }
            }
        }

        public void ShowBill(String id)
        {
            lst_bill.Items.Clear();
            bill = bus_bill.SelectID_Table(id);
            listbill_info = bus_infoBill.SelectAll(bill.ID);
            //if(listbill_info != null)
            //{
            //    foreach (DTO_Menu item in listbill_info)
            //    {
            //        ListViewItem lsi = new ListViewItem(item.DISPLAYNAME.ToString());
            //        lsi.SubItems.Add(item.COUNT.ToString());
            //        lsi.SubItems.Add(item.PRICE.ToString());
            //        lst_bill.Items.Add(lsi);
            //    }
            //    btn_order.Enabled = false;
            //}
            //else
            //{
            //    btn_order.Enabled = true;
            //    MessageBox.Show("You can order.");
            //}
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            String id = ((sender as Button).Tag as DTO_Table).ID;
            ShowBill(id);
            lb_id_table.Text = id;
            if((sender as Button).BackColor == Color.Silver)
            {
                status_tab = 1;
                btn_add.Enabled = false;
                btn_order.Enabled = false;
                btn_submit.Enabled = false;
            }
            if ((sender as Button).BackColor == Color.White)
            {
                status_tab = 0;
                //btn_add.Enabled = true;
                btn_order.Enabled = true;
                //btn_submit.Enabled = true;
            }
            if ((sender as Button).BackColor == Color.Green)
            {
                status_tab = -1;
            }
        }

        private void GUI_ORDER_Load(object sender, EventArgs e)
        {
            List<DTO_FOOD_CATEGORY> listcategory = new List<DTO_FOOD_CATEGORY>();
            food_category_BUS.SelectAll(ref listcategory);

            cbx_category.DataSource = listcategory;
            cbx_category.DisplayMember = "NAMECAT";
            cbx_category.ValueMember = "ID_CAT";

            btn_add.Enabled = false;
            btn_order.Enabled = false;
            btn_submit.Enabled = false;
        }

        private void cbx_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<DTO_FOOD> listfood = new List<DTO_FOOD>();
            food_BUS.SelectAllByCategory(ref listfood, cbx_category.Text);

            cbx_food.DataSource = listfood;
            cbx_food.DisplayMember = "DISPLAYNAME";
            cbx_food.ValueMember = "ID_FOD";
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            if(listbill_info == null)
            {
                btn_add.Enabled = true;
                btn_submit.Enabled = true;
                MessageBox.Show("Table id null.");
                String id_bill_current = bus_bill.nextID();
                lb_ID.Text = id_bill_current;
                list_in.Clear();
                //MessageBox.Show(list_in.ToString());
            }
            else
            {
                //init bill
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(ntd_food.Value == 0)
            {
                MessageBox.Show("Food is not null.");
            }
            else
            {
                btn_reset.Enabled = true;
                String id_info = bus_infoBill.nextID();
                //bus_infoBill = new BUS_BILL_INFO();
                //DTO_BILL_INFO temp_info = new DTO_BILL_INFO(id_info, cbx_food.SelectedValue.ToString(), lb_ID.Text,
                //                                        Convert.ToInt32(ntd_food.Value),
                //                                        Convert.ToDouble(lb_price_food.Text) * Convert.ToInt32(ntd_food.Value));
                //bus_infoBill.insert(temp_info);
                //MessageBox.Show("ID: " + id_info +" "+ cbx_food.SelectedValue.ToString() + " " + lb_ID.Text + Convert.ToInt32(ntd_food.Value).ToString() + " " + lb_price_food.Text);

                list_in.Add(new DTO_BILL_INFO(id_info, cbx_food.SelectedValue.ToString(), lb_ID.Text,
                                                        Convert.ToInt32(ntd_food.Value),
                                                        Convert.ToDouble(lb_price_food.Text) * Convert.ToInt32(ntd_food.Value)));
                //MessageBox.Show(list_in[0].PRICE.ToString());

                //convert list bill - list menu
                lst_bill.Items.Clear();
                List<DTO_BILL_INFO> temp = list_in;
                if (temp.Count() != 0)
                {
                    foreach (DTO_BILL_INFO item in temp)
                    {
                        ListViewItem lsi = new ListViewItem(item.ID_FOD);
                        lsi.SubItems.Add(item.COUNT.ToString());
                        lsi.SubItems.Add(item.PRICE.ToString());
                        lst_bill.Items.Add(lsi);
                    }
                    //btn_order.Enabled = false;
                }

                //predict price
                Double sum_price = 0, subprice = 0;
                if (temp.Count() != 0)
                {
                    foreach (DTO_BILL_INFO item in temp)
                    {
                        sum_price += item.PRICE;
                    }

                    lb_sum.Text = sum_price.ToString();
                    lb_sub.Text = subprice.ToString();

                }
            }
        }

        private void cbx_food_SelectedIndexChanged(object sender, EventArgs e)
        {
            DTO_FOOD _food = new DTO_FOOD();
            food_BUS.Select_ID(ref _food, cbx_food.SelectedValue.ToString());
            //MessageBox.Show("price: " +  _food.OUTPUTPRICE);
            lb_price_food.Text = _food.OUTPUTPRICE;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if(ntd_price.Value == 0)
            {
                MessageBox.Show("Don't input price!");
            }
            else
            {
                List<DTO_BILL_INFO> temp = list_in;
                Double sum_price = 0, subprice = 0;
                Double custom_price = Convert.ToDouble(ntd_price.Value);

                if (temp.Count() != 0)
                {
                    foreach (DTO_BILL_INFO item in temp)
                    {
                        sum_price += item.PRICE;
                        //insert bill infor
                        String id_info = bus_infoBill.nextID();
                        DTO_BILL_INFO temp_bill_info = new DTO_BILL_INFO(id_info, item.ID_FOD, item.ID_BIL, item.COUNT, item.PRICE);
                        bus_infoBill.insert(temp_bill_info);
                    }
                    subprice = custom_price - sum_price;



                    //insert bill 
                    DTO_BILL bill = new DTO_BILL(lb_ID.Text, dtp_time.Value, "U02", lb_id_table.Text, "DONE", sum_price, subprice);
                    Result result = bus_bill.insert(bill);

                    //insert bill info
                    lst_bill.Items.Clear();
                    lb_sum.Text = sum_price.ToString();
                    lb_sub.Text = subprice.ToString();

                    btn_add.Enabled = false;
                    btn_order.Enabled = false;
                    btn_submit.Enabled = false;
                    btn_reset.Enabled = false;
                }
                else
                {
                    MessageBox.Show("You must add food for bill");
                }

            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            List<DTO_BILL_INFO> temp = list_in;
            if (temp.Count() != 0)
            {
                foreach (DTO_BILL_INFO item in temp)
                {
                    bus_infoBill = new BUS_BILL_INFO();
                    bus_infoBill.delete(item.ID);
                }

                btn_add.Enabled = false;
                btn_order.Enabled = false;
                btn_submit.Enabled = false;
                btn_reset.Enabled = false;
            }

            lst_bill.Items.Clear();
            lb_sum.Text = ".....";
            lb_sub.Text = ".....";
            lb_price_food.Text = "...";
            lb_ID.Text = "ID";
            MessageBox.Show("Reset");
        }

        private void btn_free_Click(object sender, EventArgs e)
        {
            if (status_tab == -1)
                MessageBox.Show("Choose table to free.");
            if (status_tab == 0)
                MessageBox.Show("Table is null.");
            if (status_tab == 1)
            {
                DTO_Table tab = new DTO_Table();
                tab = table_BUS.Select_ID(lb_id_table.Text);
                DTO_Table tabTemp = new DTO_Table(tab.ID, tab.NUMBER, tab.AREA, tab.LIMIT, "0");
                table_BUS.update(tabTemp);
                LoadDataGridBill();
            }
        }

        private void btn_put_Click(object sender, EventArgs e)
        {
            if (status_tab == -1)
                MessageBox.Show("Choose table to put.");
            if (status_tab == 0)
            {
                DTO_Table tab = new DTO_Table();
                tab = table_BUS.Select_ID(lb_id_table.Text);
                DTO_Table tabTemp = new DTO_Table(tab.ID, tab.NUMBER, tab.AREA, tab.LIMIT, "1");
                table_BUS.update(tabTemp);
                LoadDataGridBill();
            }
            if (status_tab == 1)
            {
                MessageBox.Show("Table is busy.");
            }
        }
    }
}
