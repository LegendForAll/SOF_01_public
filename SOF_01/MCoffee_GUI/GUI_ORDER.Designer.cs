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
            this.dgv_bill = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tbx_status = new System.Windows.Forms.TextBox();
            this.tbx_price = new System.Windows.Forms.TextBox();
            this.tbx_subPrice = new System.Windows.Forms.TextBox();
            this.lst_bill = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fpn_table = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bill)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_bill
            // 
            this.dgv_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bill.Location = new System.Drawing.Point(556, 184);
            this.dgv_bill.Name = "dgv_bill";
            this.dgv_bill.Size = new System.Drawing.Size(103, 29);
            this.dgv_bill.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(240, 39);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 36;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(240, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 35;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(475, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 50);
            this.button5.TabIndex = 34;
            this.button5.Text = "Order";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(556, 142);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 33;
            this.button4.Text = "submit";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tbx_status
            // 
            this.tbx_status.Location = new System.Drawing.Point(556, 116);
            this.tbx_status.Name = "tbx_status";
            this.tbx_status.Size = new System.Drawing.Size(71, 20);
            this.tbx_status.TabIndex = 32;
            this.tbx_status.Text = "STATUS";
            // 
            // tbx_price
            // 
            this.tbx_price.Location = new System.Drawing.Point(556, 64);
            this.tbx_price.Name = "tbx_price";
            this.tbx_price.Size = new System.Drawing.Size(120, 20);
            this.tbx_price.TabIndex = 31;
            this.tbx_price.Text = "PRICE";
            // 
            // tbx_subPrice
            // 
            this.tbx_subPrice.Location = new System.Drawing.Point(556, 90);
            this.tbx_subPrice.Name = "tbx_subPrice";
            this.tbx_subPrice.Size = new System.Drawing.Size(120, 20);
            this.tbx_subPrice.TabIndex = 30;
            this.tbx_subPrice.Text = "SUB_PRICE";
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
            this.lst_bill.Location = new System.Drawing.Point(240, 68);
            this.lst_bill.Name = "lst_bill";
            this.lst_bill.Size = new System.Drawing.Size(310, 250);
            this.lst_bill.TabIndex = 29;
            this.lst_bill.UseCompatibleStateImageBehavior = false;
            this.lst_bill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "FOOD";
            this.columnHeader2.Width = 71;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "COUNT";
            this.columnHeader4.Width = 79;
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
            this.fpn_table.Location = new System.Drawing.Point(12, 12);
            this.fpn_table.Name = "fpn_table";
            this.fpn_table.Size = new System.Drawing.Size(222, 302);
            this.fpn_table.TabIndex = 28;
            // 
            // GUI_ORDER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 329);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tbx_status);
            this.Controls.Add(this.tbx_price);
            this.Controls.Add(this.tbx_subPrice);
            this.Controls.Add(this.lst_bill);
            this.Controls.Add(this.fpn_table);
            this.Controls.Add(this.dgv_bill);
            this.Name = "GUI_ORDER";
            this.Text = "GUI_ORDER";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_bill;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tbx_status;
        private System.Windows.Forms.TextBox tbx_price;
        private System.Windows.Forms.TextBox tbx_subPrice;
        private System.Windows.Forms.ListView lst_bill;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.FlowLayoutPanel fpn_table;
    }
}