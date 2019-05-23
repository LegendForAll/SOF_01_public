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
    public partial class GUI_Login : Form
    {
        // use Object nv_BUS doing Layer Business
        BUS_User nv_BUS = new BUS_User();
        public GUI_Login()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            var dictionary = new Dictionary<string, string>();
            dictionary = nv_BUS.Login(txt_userName.Text, txt_passWord.Text);
            if (dictionary == null)
                MessageBox.Show("Username or password not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                GUI_Main ui_main = new GUI_Main();
                ui_main.user = dictionary["DUsername"].ToString();
                ui_main.type = dictionary["DType"].ToString();
                this.Hide();
                ui_main.ShowDialog();
                this.Show();
            }
        }

        private void GUI_Login_Load(object sender, EventArgs e)
        {
            DataTable tblNV = new DataTable();
            tblNV = nv_BUS.Display("Select * from [USER]");
            dataGridView1.DataSource = tblNV;
            ID.DataPropertyName = "ID_EMP";
            Name.DataPropertyName = "NAME";
            Type.DataPropertyName = "TYPE";
            Username.DataPropertyName = "USERNAME";
            Password.DataPropertyName = "PASSWORD";
            DateStart.DataPropertyName = "DATESTART";
            Address.DataPropertyName = "ADDRESS";
        }
    }
}
