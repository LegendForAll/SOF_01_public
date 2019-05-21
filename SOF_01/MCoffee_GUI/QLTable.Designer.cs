namespace MCoffee_GUI
{
    partial class QLTable
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
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.btThemMon = new System.Windows.Forms.Button();
            this.nupCount = new System.Windows.Forms.NumericUpDown();
            this.lvBill = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btThanhToan = new System.Windows.Forms.Button();
            this.txtSubPrice = new System.Windows.Forms.TextBox();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.pbFood = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFood)).BeginInit();
            this.SuspendLayout();
            // 
            // flpTable
            // 
            this.flpTable.Location = new System.Drawing.Point(13, 13);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(395, 425);
            this.flpTable.TabIndex = 0;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(414, 14);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(123, 21);
            this.cbCategory.TabIndex = 1;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(414, 41);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(123, 21);
            this.cbFood.TabIndex = 2;
            this.cbFood.SelectedIndexChanged += new System.EventHandler(this.cbFood_SelectedIndexChanged);
            // 
            // btThemMon
            // 
            this.btThemMon.Location = new System.Drawing.Point(622, 13);
            this.btThemMon.Name = "btThemMon";
            this.btThemMon.Size = new System.Drawing.Size(86, 48);
            this.btThemMon.TabIndex = 3;
            this.btThemMon.Text = "Thêm Món";
            this.btThemMon.UseVisualStyleBackColor = true;
            this.btThemMon.Click += new System.EventHandler(this.btThemMon_Click);
            // 
            // nupCount
            // 
            this.nupCount.Location = new System.Drawing.Point(725, 27);
            this.nupCount.Name = "nupCount";
            this.nupCount.Size = new System.Drawing.Size(39, 20);
            this.nupCount.TabIndex = 4;
            // 
            // lvBill
            // 
            this.lvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.columnHeader1,
            this.columnHeader2});
            this.lvBill.GridLines = true;
            this.lvBill.Location = new System.Drawing.Point(414, 68);
            this.lvBill.Name = "lvBill";
            this.lvBill.Size = new System.Drawing.Size(258, 323);
            this.lvBill.TabIndex = 5;
            this.lvBill.UseCompatibleStateImageBehavior = false;
            this.lvBill.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Count";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            // 
            // btThanhToan
            // 
            this.btThanhToan.Location = new System.Drawing.Point(690, 210);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(98, 48);
            this.btThanhToan.TabIndex = 6;
            this.btThanhToan.Text = "Thanh Toán";
            this.btThanhToan.UseVisualStyleBackColor = true;
            this.btThanhToan.Click += new System.EventHandler(this.btThanhToan_Click);
            // 
            // txtSubPrice
            // 
            this.txtSubPrice.Location = new System.Drawing.Point(690, 184);
            this.txtSubPrice.Name = "txtSubPrice";
            this.txtSubPrice.Size = new System.Drawing.Size(100, 20);
            this.txtSubPrice.TabIndex = 7;
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Location = new System.Drawing.Point(430, 404);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(59, 13);
            this.lbTongTien.TabIndex = 8;
            this.lbTongTien.Text = "Tổng Tiền:";
            // 
            // pbFood
            // 
            this.pbFood.Location = new System.Drawing.Point(544, 13);
            this.pbFood.Name = "pbFood";
            this.pbFood.Size = new System.Drawing.Size(72, 50);
            this.pbFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFood.TabIndex = 9;
            this.pbFood.TabStop = false;
            this.pbFood.Click += new System.EventHandler(this.pbFood_Click);
            // 
            // QLTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbFood);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.txtSubPrice);
            this.Controls.Add(this.btThanhToan);
            this.Controls.Add(this.lvBill);
            this.Controls.Add(this.nupCount);
            this.Controls.Add(this.btThemMon);
            this.Controls.Add(this.cbFood);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.flpTable);
            this.Text = "QLTable";
            this.Load += new System.EventHandler(this.QLTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.Button btThemMon;
        private System.Windows.Forms.NumericUpDown nupCount;
        private System.Windows.Forms.ListView lvBill;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btThanhToan;
        private System.Windows.Forms.TextBox txtSubPrice;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.PictureBox pbFood;
    }
}