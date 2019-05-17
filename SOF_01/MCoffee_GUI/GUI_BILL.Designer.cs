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
            this.dgv_info = new System.Windows.Forms.DataGridView();
            this.tbx_idBill = new System.Windows.Forms.TextBox();
            this.tbx_idTable = new System.Windows.Forms.TextBox();
            this.dtp_bill = new System.Windows.Forms.DateTimePicker();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_USER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS_BILL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BILL_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUB_BILL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtp_fill = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).BeginInit();
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
            this.dgv_bill.Location = new System.Drawing.Point(12, 38);
            this.dgv_bill.Name = "dgv_bill";
            this.dgv_bill.Size = new System.Drawing.Size(538, 156);
            this.dgv_bill.TabIndex = 0;
            this.dgv_bill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bill_CellClick);
            // 
            // dgv_info
            // 
            this.dgv_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_info.Location = new System.Drawing.Point(12, 227);
            this.dgv_info.Name = "dgv_info";
            this.dgv_info.Size = new System.Drawing.Size(538, 184);
            this.dgv_info.TabIndex = 1;
            // 
            // tbx_idBill
            // 
            this.tbx_idBill.Location = new System.Drawing.Point(12, 12);
            this.tbx_idBill.Name = "tbx_idBill";
            this.tbx_idBill.Size = new System.Drawing.Size(93, 20);
            this.tbx_idBill.TabIndex = 2;
            this.tbx_idBill.Text = "ID_BILL";
            // 
            // tbx_idTable
            // 
            this.tbx_idTable.Location = new System.Drawing.Point(317, 12);
            this.tbx_idTable.Name = "tbx_idTable";
            this.tbx_idTable.Size = new System.Drawing.Size(93, 20);
            this.tbx_idTable.TabIndex = 4;
            this.tbx_idTable.Text = "ID_TABLE";
            // 
            // dtp_bill
            // 
            this.dtp_bill.Location = new System.Drawing.Point(111, 12);
            this.dtp_bill.Name = "dtp_bill";
            this.dtp_bill.Size = new System.Drawing.Size(200, 20);
            this.dtp_bill.TabIndex = 5;
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
            // dtp_fill
            // 
            this.dtp_fill.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fill.Location = new System.Drawing.Point(576, 38);
            this.dtp_fill.Name = "dtp_fill";
            this.dtp_fill.Size = new System.Drawing.Size(200, 20);
            this.dtp_fill.TabIndex = 6;
            this.dtp_fill.ValueChanged += new System.EventHandler(this.dtp_fill_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(576, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GUI_BILL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 427);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtp_fill);
            this.Controls.Add(this.dtp_bill);
            this.Controls.Add(this.tbx_idTable);
            this.Controls.Add(this.tbx_idBill);
            this.Controls.Add(this.dgv_info);
            this.Controls.Add(this.dgv_bill);
            this.Name = "GUI_BILL";
            this.Text = "GUI_BILL";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button button1;
    }
}