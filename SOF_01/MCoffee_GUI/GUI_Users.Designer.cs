namespace MCoffee_GUI
{
    partial class GUI_User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.dtpDateStart = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtNameUser = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtIdUser = new System.Windows.Forms.TextBox();
            this.btnDateStart = new System.Windows.Forms.Button();
            this.btnAddress = new System.Windows.Forms.Button();
            this.btnPassword = new System.Windows.Forms.Button();
            this.btnUsername = new System.Windows.Forms.Button();
            this.btnTypeUser = new System.Windows.Forms.Button();
            this.btnNameUser = new System.Windows.Forms.Button();
            this.btnIdUser = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Id2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateStart2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxType2 = new System.Windows.Forms.ComboBox();
            this.dtpDateStart2 = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtNameUser2 = new System.Windows.Forms.TextBox();
            this.txtUsername2 = new System.Windows.Forms.TextBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.txtIdUser2 = new System.Windows.Forms.TextBox();
            this.btnDateStart2 = new System.Windows.Forms.Button();
            this.btnAddress2 = new System.Windows.Forms.Button();
            this.btnPassword2 = new System.Windows.Forms.Button();
            this.btnUsername2 = new System.Windows.Forms.Button();
            this.btnTypeUser2 = new System.Windows.Forms.Button();
            this.btnNameUser2 = new System.Windows.Forms.Button();
            this.btnIdUser2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1118, 1065);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbxType);
            this.tabPage1.Controls.Add(this.dtpDateStart);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnInsert);
            this.tabPage1.Controls.Add(this.txtAddress);
            this.tabPage1.Controls.Add(this.txtNameUser);
            this.tabPage1.Controls.Add(this.txtUsername);
            this.tabPage1.Controls.Add(this.txtPassword);
            this.tabPage1.Controls.Add(this.txtIdUser);
            this.tabPage1.Controls.Add(this.btnDateStart);
            this.tabPage1.Controls.Add(this.btnAddress);
            this.tabPage1.Controls.Add(this.btnPassword);
            this.tabPage1.Controls.Add(this.btnUsername);
            this.tabPage1.Controls.Add(this.btnTypeUser);
            this.tabPage1.Controls.Add(this.btnNameUser);
            this.tabPage1.Controls.Add(this.btnIdUser);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1102, 1018);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thêm/Xóa Nhân viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(310, 154);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(568, 33);
            this.cbxType.TabIndex = 26;
            // 
            // dtpDateStart
            // 
            this.dtpDateStart.Location = new System.Drawing.Point(310, 341);
            this.dtpDateStart.Name = "dtpDateStart";
            this.dtpDateStart.Size = new System.Drawing.Size(568, 31);
            this.dtpDateStart.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.Type,
            this.Username,
            this.Password,
            this.DateStart,
            this.Address});
            this.dataGridView1.Location = new System.Drawing.Point(28, 549);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1059, 452);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Name
            // 
            this.Name.HeaderText = "Họ tên";
            this.Name.Name = "Name";
            // 
            // Type
            // 
            this.Type.HeaderText = "Loại User";
            this.Type.Name = "Type";
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // DateStart
            // 
            this.DateStart.HeaderText = "Date Start";
            this.DateStart.Name = "DateStart";
            // 
            // Address
            // 
            this.Address.HeaderText = "Địa chỉ";
            this.Address.Name = "Address";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(729, 468);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 46);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(545, 468);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(149, 46);
            this.btnInsert.TabIndex = 14;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(310, 403);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(568, 31);
            this.txtAddress.TabIndex = 13;
            // 
            // txtNameUser
            // 
            this.txtNameUser.Location = new System.Drawing.Point(310, 95);
            this.txtNameUser.Name = "txtNameUser";
            this.txtNameUser.Size = new System.Drawing.Size(568, 31);
            this.txtNameUser.TabIndex = 12;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(310, 214);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(568, 31);
            this.txtUsername.TabIndex = 10;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(310, 275);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(568, 31);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtIdUser
            // 
            this.txtIdUser.Location = new System.Drawing.Point(310, 36);
            this.txtIdUser.Name = "txtIdUser";
            this.txtIdUser.Size = new System.Drawing.Size(568, 31);
            this.txtIdUser.TabIndex = 7;
            // 
            // btnDateStart
            // 
            this.btnDateStart.Location = new System.Drawing.Point(37, 341);
            this.btnDateStart.Name = "btnDateStart";
            this.btnDateStart.Size = new System.Drawing.Size(181, 41);
            this.btnDateStart.TabIndex = 6;
            this.btnDateStart.Text = "Ngày vào làm";
            this.btnDateStart.UseVisualStyleBackColor = true;
            // 
            // btnAddress
            // 
            this.btnAddress.Location = new System.Drawing.Point(37, 403);
            this.btnAddress.Name = "btnAddress";
            this.btnAddress.Size = new System.Drawing.Size(181, 41);
            this.btnAddress.TabIndex = 5;
            this.btnAddress.Text = "Địa chỉ";
            this.btnAddress.UseVisualStyleBackColor = true;
            // 
            // btnPassword
            // 
            this.btnPassword.Location = new System.Drawing.Point(37, 275);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(181, 41);
            this.btnPassword.TabIndex = 4;
            this.btnPassword.Text = "Password";
            this.btnPassword.UseVisualStyleBackColor = true;
            // 
            // btnUsername
            // 
            this.btnUsername.Location = new System.Drawing.Point(37, 214);
            this.btnUsername.Name = "btnUsername";
            this.btnUsername.Size = new System.Drawing.Size(181, 41);
            this.btnUsername.TabIndex = 3;
            this.btnUsername.Text = "Username";
            this.btnUsername.UseVisualStyleBackColor = true;
            // 
            // btnTypeUser
            // 
            this.btnTypeUser.Location = new System.Drawing.Point(37, 154);
            this.btnTypeUser.Name = "btnTypeUser";
            this.btnTypeUser.Size = new System.Drawing.Size(181, 41);
            this.btnTypeUser.TabIndex = 2;
            this.btnTypeUser.Text = "Loại Nhân viên";
            this.btnTypeUser.UseVisualStyleBackColor = true;
            // 
            // btnNameUser
            // 
            this.btnNameUser.Location = new System.Drawing.Point(37, 95);
            this.btnNameUser.Name = "btnNameUser";
            this.btnNameUser.Size = new System.Drawing.Size(181, 41);
            this.btnNameUser.TabIndex = 1;
            this.btnNameUser.Text = "Họ Tên";
            this.btnNameUser.UseVisualStyleBackColor = true;
            // 
            // btnIdUser
            // 
            this.btnIdUser.Location = new System.Drawing.Point(37, 36);
            this.btnIdUser.Name = "btnIdUser";
            this.btnIdUser.Size = new System.Drawing.Size(181, 41);
            this.btnIdUser.TabIndex = 0;
            this.btnIdUser.Text = "Mã Nhân viên";
            this.btnIdUser.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.cbxType2);
            this.tabPage2.Controls.Add(this.dtpDateStart2);
            this.tabPage2.Controls.Add(this.btnUpdate);
            this.tabPage2.Controls.Add(this.txtAddress2);
            this.tabPage2.Controls.Add(this.txtNameUser2);
            this.tabPage2.Controls.Add(this.txtUsername2);
            this.tabPage2.Controls.Add(this.txtPassword2);
            this.tabPage2.Controls.Add(this.txtIdUser2);
            this.tabPage2.Controls.Add(this.btnDateStart2);
            this.tabPage2.Controls.Add(this.btnAddress2);
            this.tabPage2.Controls.Add(this.btnPassword2);
            this.tabPage2.Controls.Add(this.btnUsername2);
            this.tabPage2.Controls.Add(this.btnTypeUser2);
            this.tabPage2.Controls.Add(this.btnNameUser2);
            this.tabPage2.Controls.Add(this.btnIdUser2);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1102, 1018);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sửa Nhân viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id2,
            this.Name2,
            this.Type2,
            this.Username2,
            this.Password2,
            this.DateStart2,
            this.Address2});
            this.dataGridView2.Location = new System.Drawing.Point(28, 549);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(1059, 452);
            this.dataGridView2.TabIndex = 26;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // Id2
            // 
            this.Id2.HeaderText = "Id";
            this.Id2.Name = "Id2";
            // 
            // Name2
            // 
            this.Name2.HeaderText = "Họ tên";
            this.Name2.Name = "Name2";
            // 
            // Type2
            // 
            this.Type2.HeaderText = "Loại User";
            this.Type2.Name = "Type2";
            // 
            // Username2
            // 
            this.Username2.HeaderText = "Username";
            this.Username2.Name = "Username2";
            // 
            // Password2
            // 
            this.Password2.HeaderText = "Password";
            this.Password2.Name = "Password2";
            // 
            // DateStart2
            // 
            this.DateStart2.HeaderText = "Date Start";
            this.DateStart2.Name = "DateStart2";
            // 
            // Address2
            // 
            this.Address2.HeaderText = "Địa chỉ";
            this.Address2.Name = "Address2";
            // 
            // cbxType2
            // 
            this.cbxType2.FormattingEnabled = true;
            this.cbxType2.Location = new System.Drawing.Point(310, 154);
            this.cbxType2.Name = "cbxType2";
            this.cbxType2.Size = new System.Drawing.Size(568, 33);
            this.cbxType2.TabIndex = 25;
            // 
            // dtpDateStart2
            // 
            this.dtpDateStart2.Enabled = false;
            this.dtpDateStart2.Location = new System.Drawing.Point(310, 341);
            this.dtpDateStart2.Name = "dtpDateStart2";
            this.dtpDateStart2.Size = new System.Drawing.Size(568, 31);
            this.dtpDateStart2.TabIndex = 23;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(729, 468);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(149, 46);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(310, 403);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(568, 31);
            this.txtAddress2.TabIndex = 20;
            // 
            // txtNameUser2
            // 
            this.txtNameUser2.Location = new System.Drawing.Point(310, 95);
            this.txtNameUser2.Name = "txtNameUser2";
            this.txtNameUser2.Size = new System.Drawing.Size(568, 31);
            this.txtNameUser2.TabIndex = 19;
            // 
            // txtUsername2
            // 
            this.txtUsername2.Location = new System.Drawing.Point(310, 214);
            this.txtUsername2.Name = "txtUsername2";
            this.txtUsername2.Size = new System.Drawing.Size(568, 31);
            this.txtUsername2.TabIndex = 17;
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(310, 275);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(568, 31);
            this.txtPassword2.TabIndex = 16;
            this.txtPassword2.UseSystemPasswordChar = true;
            // 
            // txtIdUser2
            // 
            this.txtIdUser2.Enabled = false;
            this.txtIdUser2.Location = new System.Drawing.Point(310, 36);
            this.txtIdUser2.Name = "txtIdUser2";
            this.txtIdUser2.ReadOnly = true;
            this.txtIdUser2.Size = new System.Drawing.Size(568, 31);
            this.txtIdUser2.TabIndex = 14;
            // 
            // btnDateStart2
            // 
            this.btnDateStart2.Location = new System.Drawing.Point(37, 341);
            this.btnDateStart2.Name = "btnDateStart2";
            this.btnDateStart2.Size = new System.Drawing.Size(181, 41);
            this.btnDateStart2.TabIndex = 13;
            this.btnDateStart2.Text = "Ngày vào làm";
            this.btnDateStart2.UseVisualStyleBackColor = true;
            // 
            // btnAddress2
            // 
            this.btnAddress2.Location = new System.Drawing.Point(37, 403);
            this.btnAddress2.Name = "btnAddress2";
            this.btnAddress2.Size = new System.Drawing.Size(181, 41);
            this.btnAddress2.TabIndex = 12;
            this.btnAddress2.Text = "Địa chỉ";
            this.btnAddress2.UseVisualStyleBackColor = true;
            // 
            // btnPassword2
            // 
            this.btnPassword2.Location = new System.Drawing.Point(37, 275);
            this.btnPassword2.Name = "btnPassword2";
            this.btnPassword2.Size = new System.Drawing.Size(181, 41);
            this.btnPassword2.TabIndex = 11;
            this.btnPassword2.Text = "Password";
            this.btnPassword2.UseVisualStyleBackColor = true;
            // 
            // btnUsername2
            // 
            this.btnUsername2.Location = new System.Drawing.Point(37, 214);
            this.btnUsername2.Name = "btnUsername2";
            this.btnUsername2.Size = new System.Drawing.Size(181, 41);
            this.btnUsername2.TabIndex = 10;
            this.btnUsername2.Text = "Username";
            this.btnUsername2.UseVisualStyleBackColor = true;
            // 
            // btnTypeUser2
            // 
            this.btnTypeUser2.Location = new System.Drawing.Point(37, 154);
            this.btnTypeUser2.Name = "btnTypeUser2";
            this.btnTypeUser2.Size = new System.Drawing.Size(181, 41);
            this.btnTypeUser2.TabIndex = 9;
            this.btnTypeUser2.Text = "Loại Nhân viên";
            this.btnTypeUser2.UseVisualStyleBackColor = true;
            // 
            // btnNameUser2
            // 
            this.btnNameUser2.Location = new System.Drawing.Point(37, 95);
            this.btnNameUser2.Name = "btnNameUser2";
            this.btnNameUser2.Size = new System.Drawing.Size(181, 41);
            this.btnNameUser2.TabIndex = 8;
            this.btnNameUser2.Text = "Họ Tên";
            this.btnNameUser2.UseVisualStyleBackColor = true;
            // 
            // btnIdUser2
            // 
            this.btnIdUser2.Location = new System.Drawing.Point(37, 36);
            this.btnIdUser2.Name = "btnIdUser2";
            this.btnIdUser2.Size = new System.Drawing.Size(181, 41);
            this.btnIdUser2.TabIndex = 7;
            this.btnIdUser2.Text = "Mã Nhân viên";
            this.btnIdUser2.UseVisualStyleBackColor = true;
            // 
            // GUI_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1136, 1112);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            //this.Name = "GUI_User";
            this.Text = "GUI_Users";
            this.Load += new System.EventHandler(this.GUI_User_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnIdUser;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnNameUser;
        private System.Windows.Forms.Button btnTypeUser;
        private System.Windows.Forms.Button btnUsername;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtNameUser;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtIdUser;
        private System.Windows.Forms.Button btnDateStart;
        private System.Windows.Forms.Button btnAddress;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtNameUser2;
        private System.Windows.Forms.TextBox txtUsername2;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.TextBox txtIdUser2;
        private System.Windows.Forms.Button btnDateStart2;
        private System.Windows.Forms.Button btnAddress2;
        private System.Windows.Forms.Button btnPassword2;
        private System.Windows.Forms.Button btnUsername2;
        private System.Windows.Forms.Button btnTypeUser2;
        private System.Windows.Forms.Button btnNameUser2;
        private System.Windows.Forms.Button btnIdUser2;
        private System.Windows.Forms.DateTimePicker dtpDateStart;
        private System.Windows.Forms.DateTimePicker dtpDateStart2;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.ComboBox cbxType2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateStart2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address2;
    }
}