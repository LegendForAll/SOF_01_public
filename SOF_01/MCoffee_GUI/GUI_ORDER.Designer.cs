namespace MCoffee_GUI
{
    partial class GUI_ORDER
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
            this.cbx_food = new System.Windows.Forms.ComboBox();
            this.cbx_category = new System.Windows.Forms.ComboBox();
            this.btn_order = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.lst_bill = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fpn_table = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lb_ID = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.ntd_food = new System.Windows.Forms.NumericUpDown();
            this.lb_price_food = new System.Windows.Forms.Label();
            this.lb_id_table = new System.Windows.Forms.Label();
            this.dtp_time = new System.Windows.Forms.DateTimePicker();
            this.ntd_price = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_sum = new System.Windows.Forms.Label();
            this.lb_sub = new System.Windows.Forms.Label();
            this.btn_free = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_put = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ntd_food)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntd_price)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_food
            // 
            this.cbx_food.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_food.FormattingEnabled = true;
            this.cbx_food.Location = new System.Drawing.Point(240, 37);
            this.cbx_food.Name = "cbx_food";
            this.cbx_food.Size = new System.Drawing.Size(121, 21);
            this.cbx_food.TabIndex = 36;
            this.cbx_food.SelectedIndexChanged += new System.EventHandler(this.cbx_food_SelectedIndexChanged);
            // 
            // cbx_category
            // 
            this.cbx_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_category.FormattingEnabled = true;
            this.cbx_category.Location = new System.Drawing.Point(240, 12);
            this.cbx_category.Name = "cbx_category";
            this.cbx_category.Size = new System.Drawing.Size(121, 21);
            this.cbx_category.TabIndex = 35;
            this.cbx_category.SelectedIndexChanged += new System.EventHandler(this.cbx_category_SelectedIndexChanged);
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(556, 72);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(67, 50);
            this.btn_order.TabIndex = 34;
            this.btn_order.Text = "Order";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(486, 324);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(137, 50);
            this.btn_submit.TabIndex = 33;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // lst_bill
            // 
            this.lst_bill.BackColor = System.Drawing.SystemColors.Control;
            this.lst_bill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5});
            this.lst_bill.Enabled = false;
            this.lst_bill.GridLines = true;
            this.lst_bill.Location = new System.Drawing.Point(240, 84);
            this.lst_bill.Name = "lst_bill";
            this.lst_bill.Size = new System.Drawing.Size(310, 234);
            this.lst_bill.TabIndex = 29;
            this.lst_bill.UseCompatibleStateImageBehavior = false;
            this.lst_bill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "FOOD";
            this.columnHeader2.Width = 129;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "COUNT";
            this.columnHeader4.Width = 81;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "PRICE";
            this.columnHeader5.Width = 97;
            // 
            // fpn_table
            // 
            this.fpn_table.AutoScroll = true;
            this.fpn_table.BackColor = System.Drawing.Color.Transparent;
            this.fpn_table.Location = new System.Drawing.Point(7, 39);
            this.fpn_table.Name = "fpn_table";
            this.fpn_table.Size = new System.Drawing.Size(222, 329);
            this.fpn_table.TabIndex = 28;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(556, 128);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(67, 50);
            this.btn_reset.TabIndex = 37;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Location = new System.Drawing.Point(8, 12);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(18, 13);
            this.lb_ID.TabIndex = 38;
            this.lb_ID.Text = "ID";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(556, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(67, 54);
            this.btn_add.TabIndex = 39;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // ntd_food
            // 
            this.ntd_food.Location = new System.Drawing.Point(77, 23);
            this.ntd_food.Name = "ntd_food";
            this.ntd_food.Size = new System.Drawing.Size(41, 20);
            this.ntd_food.TabIndex = 40;
            // 
            // lb_price_food
            // 
            this.lb_price_food.AutoSize = true;
            this.lb_price_food.Location = new System.Drawing.Point(77, 8);
            this.lb_price_food.Name = "lb_price_food";
            this.lb_price_food.Size = new System.Drawing.Size(61, 13);
            this.lb_price_food.TabIndex = 41;
            this.lb_price_food.Text = "Price single";
            // 
            // lb_id_table
            // 
            this.lb_id_table.AutoSize = true;
            this.lb_id_table.Location = new System.Drawing.Point(8, 35);
            this.lb_id_table.Name = "lb_id_table";
            this.lb_id_table.Size = new System.Drawing.Size(47, 13);
            this.lb_id_table.TabIndex = 42;
            this.lb_id_table.Text = "ID_table";
            // 
            // dtp_time
            // 
            this.dtp_time.Enabled = false;
            this.dtp_time.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_time.Location = new System.Drawing.Point(128, 13);
            this.dtp_time.Name = "dtp_time";
            this.dtp_time.Size = new System.Drawing.Size(101, 20);
            this.dtp_time.TabIndex = 43;
            // 
            // ntd_price
            // 
            this.ntd_price.Location = new System.Drawing.Point(380, 324);
            this.ntd_price.Name = "ntd_price";
            this.ntd_price.Size = new System.Drawing.Size(100, 20);
            this.ntd_price.TabIndex = 44;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lb_ID);
            this.panel1.Controls.Add(this.lb_id_table);
            this.panel1.Location = new System.Drawing.Point(556, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(67, 59);
            this.panel1.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Price food:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lb_price_food);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ntd_food);
            this.panel2.Location = new System.Drawing.Point(367, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 46);
            this.panel2.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Number:";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(243, 328);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(37, 13);
            this.Label10.TabIndex = 48;
            this.Label10.Text = "SUM: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "SUB: ";
            // 
            // lb_sum
            // 
            this.lb_sum.AutoSize = true;
            this.lb_sum.Location = new System.Drawing.Point(286, 328);
            this.lb_sum.Name = "lb_sum";
            this.lb_sum.Size = new System.Drawing.Size(28, 13);
            this.lb_sum.TabIndex = 50;
            this.lb_sum.Text = ".......";
            // 
            // lb_sub
            // 
            this.lb_sub.AutoSize = true;
            this.lb_sub.Location = new System.Drawing.Point(286, 355);
            this.lb_sub.Name = "lb_sub";
            this.lb_sub.Size = new System.Drawing.Size(28, 13);
            this.lb_sub.TabIndex = 51;
            this.lb_sub.Text = ".......";
            // 
            // btn_free
            // 
            this.btn_free.Location = new System.Drawing.Point(7, 12);
            this.btn_free.Name = "btn_free";
            this.btn_free.Size = new System.Drawing.Size(48, 22);
            this.btn_free.TabIndex = 52;
            this.btn_free.Text = "Free ";
            this.btn_free.UseVisualStyleBackColor = true;
            this.btn_free.Click += new System.EventHandler(this.btn_free_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "BILL";
            // 
            // btn_put
            // 
            this.btn_put.Location = new System.Drawing.Point(61, 12);
            this.btn_put.Name = "btn_put";
            this.btn_put.Size = new System.Drawing.Size(48, 22);
            this.btn_put.TabIndex = 54;
            this.btn_put.Text = "Put";
            this.btn_put.UseVisualStyleBackColor = true;
            this.btn_put.Click += new System.EventHandler(this.btn_put_Click);
            // 
            // GUI_ORDER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 383);
            this.Controls.Add(this.btn_put);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_free);
            this.Controls.Add(this.lb_sub);
            this.Controls.Add(this.lb_sum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtp_time);
            this.Controls.Add(this.ntd_price);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.cbx_food);
            this.Controls.Add(this.cbx_category);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.lst_bill);
            this.Controls.Add(this.fpn_table);
            this.Name = "GUI_ORDER";
            this.Text = "GUI_ORDER";
            this.Load += new System.EventHandler(this.GUI_ORDER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ntd_food)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntd_price)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbx_food;
        private System.Windows.Forms.ComboBox cbx_category;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.ListView lst_bill;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.FlowLayoutPanel fpn_table;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.NumericUpDown ntd_food;
        private System.Windows.Forms.Label lb_price_food;
        private System.Windows.Forms.Label lb_id_table;
        private System.Windows.Forms.DateTimePicker dtp_time;
        private System.Windows.Forms.NumericUpDown ntd_price;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_sum;
        private System.Windows.Forms.Label lb_sub;
        private System.Windows.Forms.Button btn_free;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_put;
    }
}