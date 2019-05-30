namespace MCoffee_GUI
{
    partial class GUI_BILL
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
            this.dgv_bill = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_USER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS_BILL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BILL_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUB_BILL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_info = new System.Windows.Forms.DataGridView();
            this.tbx_idBill = new System.Windows.Forms.TextBox();
            this.tbx_idTable = new System.Windows.Forms.TextBox();
            this.dtp_bill = new System.Windows.Forms.DateTimePicker();
            this.dtp_fill = new System.Windows.Forms.DateTimePicker();
            this.btn_fill = new System.Windows.Forms.Button();
            this.cbx_user = new System.Windows.Forms.ComboBox();
            this.cbx_status = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_bill
            // 
            this.dgv_bill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ID_USER,
            this.STATUS_BILL,
            this.BILL_PRICE,
            this.SUB_BILL});
            this.dgv_bill.Location = new System.Drawing.Point(13, 42);
            this.dgv_bill.Name = "dgv_bill";
            this.dgv_bill.Size = new System.Drawing.Size(510, 109);
            this.dgv_bill.TabIndex = 0;
            this.dgv_bill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bill_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "BILL";
            this.ID.Name = "ID";
            // 
            // ID_USER
            // 
            this.ID_USER.HeaderText = "Employee";
            this.ID_USER.Name = "ID_USER";
            // 
            // STATUS_BILL
            // 
            this.STATUS_BILL.HeaderText = "Status";
            this.STATUS_BILL.Name = "STATUS_BILL";
            // 
            // BILL_PRICE
            // 
            this.BILL_PRICE.HeaderText = "Price";
            this.BILL_PRICE.Name = "BILL_PRICE";
            // 
            // SUB_BILL
            // 
            this.SUB_BILL.HeaderText = "Subprice";
            this.SUB_BILL.Name = "SUB_BILL";
            // 
            // dgv_info
            // 
            this.dgv_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_info.Location = new System.Drawing.Point(13, 40);
            this.dgv_info.Name = "dgv_info";
            this.dgv_info.Size = new System.Drawing.Size(510, 114);
            this.dgv_info.TabIndex = 1;
            // 
            // tbx_idBill
            // 
            this.tbx_idBill.Enabled = false;
            this.tbx_idBill.Location = new System.Drawing.Point(94, 54);
            this.tbx_idBill.Name = "tbx_idBill";
            this.tbx_idBill.Size = new System.Drawing.Size(103, 20);
            this.tbx_idBill.TabIndex = 2;
            // 
            // tbx_idTable
            // 
            this.tbx_idTable.Enabled = false;
            this.tbx_idTable.Location = new System.Drawing.Point(94, 78);
            this.tbx_idTable.Name = "tbx_idTable";
            this.tbx_idTable.Size = new System.Drawing.Size(103, 20);
            this.tbx_idTable.TabIndex = 4;
            // 
            // dtp_bill
            // 
            this.dtp_bill.Enabled = false;
            this.dtp_bill.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_bill.Location = new System.Drawing.Point(94, 100);
            this.dtp_bill.Name = "dtp_bill";
            this.dtp_bill.Size = new System.Drawing.Size(103, 20);
            this.dtp_bill.TabIndex = 5;
            // 
            // dtp_fill
            // 
            this.dtp_fill.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fill.Location = new System.Drawing.Point(77, 36);
            this.dtp_fill.Name = "dtp_fill";
            this.dtp_fill.Size = new System.Drawing.Size(132, 20);
            this.dtp_fill.TabIndex = 6;
            // 
            // btn_fill
            // 
            this.btn_fill.Location = new System.Drawing.Point(134, 129);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(75, 23);
            this.btn_fill.TabIndex = 7;
            this.btn_fill.Text = "Fillter";
            this.btn_fill.UseVisualStyleBackColor = true;
            this.btn_fill.Click += new System.EventHandler(this.btn_fill_Click);
            // 
            // cbx_user
            // 
            this.cbx_user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_user.FormattingEnabled = true;
            this.cbx_user.Location = new System.Drawing.Point(77, 59);
            this.cbx_user.Name = "cbx_user";
            this.cbx_user.Size = new System.Drawing.Size(132, 21);
            this.cbx_user.TabIndex = 8;
            this.cbx_user.SelectedIndexChanged += new System.EventHandler(this.cbx_user_SelectedIndexChanged);
            // 
            // cbx_status
            // 
            this.cbx_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_status.FormattingEnabled = true;
            this.cbx_status.Items.AddRange(new object[] {
            "DONE",
            "NO"});
            this.cbx_status.Location = new System.Drawing.Point(77, 83);
            this.cbx_status.Name = "cbx_status";
            this.cbx_status.Size = new System.Drawing.Size(132, 21);
            this.cbx_status.TabIndex = 9;
            this.cbx_status.SelectedIndexChanged += new System.EventHandler(this.cbx_status_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID bill: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Table: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Date bill: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbx_user);
            this.panel1.Controls.Add(this.dtp_fill);
            this.panel1.Controls.Add(this.btn_fill);
            this.panel1.Controls.Add(this.cbx_status);
            this.panel1.Location = new System.Drawing.Point(556, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 169);
            this.panel1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Status: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Employee: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "DateTime: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "FILLTER  BILL";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dgv_info);
            this.panel2.Location = new System.Drawing.Point(12, 184);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(538, 169);
            this.panel2.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Bill info:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.dgv_bill);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(538, 166);
            this.panel3.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Bills:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.tbx_idTable);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.tbx_idBill);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.dtp_bill);
            this.panel4.Location = new System.Drawing.Point(556, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(223, 166);
            this.panel4.TabIndex = 16;
            // 
            // GUI_BILL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 361);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GUI_BILL";
            this.Text = "GUI_BILL";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_bill;
        private System.Windows.Forms.DataGridView dgv_info;
        private System.Windows.Forms.TextBox tbx_idBill;
        private System.Windows.Forms.TextBox tbx_idTable;
        private System.Windows.Forms.DateTimePicker dtp_bill;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_USER;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS_BILL;
        private System.Windows.Forms.DataGridViewTextBoxColumn BILL_PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUB_BILL;
        private System.Windows.Forms.DateTimePicker dtp_fill;
        private System.Windows.Forms.Button btn_fill;
        private System.Windows.Forms.ComboBox cbx_user;
        private System.Windows.Forms.ComboBox cbx_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
    }
}