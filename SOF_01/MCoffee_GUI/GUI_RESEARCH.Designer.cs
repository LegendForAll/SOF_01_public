namespace MCoffee_GUI
{
    partial class GUI_RESEARCH
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
            this.cbx_price = new System.Windows.Forms.ComboBox();
            this.fpn_food = new System.Windows.Forms.FlowLayoutPanel();
            this.fpn_category = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_object = new System.Windows.Forms.DataGridView();
            this.G_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_SUPLIER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_UNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbx_suplier = new System.Windows.Forms.ComboBox();
            this.tbx_object = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_object)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(22, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(531, 400);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.cbx_price);
            this.tabPage1.Controls.Add(this.fpn_food);
            this.tabPage1.Controls.Add(this.fpn_category);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(523, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "FOOD";
            // 
            // cbx_price
            // 
            this.cbx_price.FormattingEnabled = true;
            this.cbx_price.Items.AddRange(new object[] {
            "20",
            "50",
            "100"});
            this.cbx_price.Location = new System.Drawing.Point(308, 8);
            this.cbx_price.Name = "cbx_price";
            this.cbx_price.Size = new System.Drawing.Size(121, 21);
            this.cbx_price.TabIndex = 2;
            this.cbx_price.SelectedIndexChanged += new System.EventHandler(this.cbx_price_SelectedIndexChanged);
            // 
            // fpn_food
            // 
            this.fpn_food.AutoScroll = true;
            this.fpn_food.BackColor = System.Drawing.Color.White;
            this.fpn_food.Location = new System.Drawing.Point(153, 35);
            this.fpn_food.Name = "fpn_food";
            this.fpn_food.Size = new System.Drawing.Size(276, 333);
            this.fpn_food.TabIndex = 1;
            // 
            // fpn_category
            // 
            this.fpn_category.AutoScroll = true;
            this.fpn_category.BackColor = System.Drawing.Color.White;
            this.fpn_category.Location = new System.Drawing.Point(6, 6);
            this.fpn_category.Name = "fpn_category";
            this.fpn_category.Size = new System.Drawing.Size(128, 362);
            this.fpn_category.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tbx_object);
            this.tabPage2.Controls.Add(this.cbx_suplier);
            this.tabPage2.Controls.Add(this.dgv_object);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(523, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "OBJECT";
            // 
            // dgv_object
            // 
            this.dgv_object.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_object.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_object.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.G_ID,
            this.G_NAME,
            this.G_SUPLIER,
            this.G_UNIT,
            this.G_NUM});
            this.dgv_object.Location = new System.Drawing.Point(16, 98);
            this.dgv_object.Name = "dgv_object";
            this.dgv_object.Size = new System.Drawing.Size(490, 150);
            this.dgv_object.TabIndex = 0;
            // 
            // G_ID
            // 
            this.G_ID.HeaderText = "ID";
            this.G_ID.Name = "G_ID";
            // 
            // G_NAME
            // 
            this.G_NAME.HeaderText = "NAME";
            this.G_NAME.Name = "G_NAME";
            // 
            // G_SUPLIER
            // 
            this.G_SUPLIER.HeaderText = "SUPLIER";
            this.G_SUPLIER.Name = "G_SUPLIER";
            // 
            // G_UNIT
            // 
            this.G_UNIT.HeaderText = "UNIT";
            this.G_UNIT.Name = "G_UNIT";
            // 
            // G_NUM
            // 
            this.G_NUM.HeaderText = "NUMBERS";
            this.G_NUM.Name = "G_NUM";
            // 
            // cbx_suplier
            // 
            this.cbx_suplier.FormattingEnabled = true;
            this.cbx_suplier.Location = new System.Drawing.Point(84, 56);
            this.cbx_suplier.Name = "cbx_suplier";
            this.cbx_suplier.Size = new System.Drawing.Size(121, 21);
            this.cbx_suplier.TabIndex = 1;
            this.cbx_suplier.SelectedIndexChanged += new System.EventHandler(this.cbx_suplier_SelectedIndexChanged);
            // 
            // tbx_object
            // 
            this.tbx_object.Location = new System.Drawing.Point(84, 30);
            this.tbx_object.Name = "tbx_object";
            this.tbx_object.Size = new System.Drawing.Size(121, 20);
            this.tbx_object.TabIndex = 2;
            this.tbx_object.TextChanged += new System.EventHandler(this.tbx_object_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Object: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Suplier: ";
            // 
            // GUI_RESEARCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "GUI_RESEARCH";
            this.Text = "GUI_RESEARCH";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_object)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel fpn_category;
        private System.Windows.Forms.FlowLayoutPanel fpn_food;
        private System.Windows.Forms.ComboBox cbx_price;
        private System.Windows.Forms.DataGridView dgv_object;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_SUPLIER;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_UNIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_NUM;
        private System.Windows.Forms.ComboBox cbx_suplier;
        private System.Windows.Forms.TextBox tbx_object;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}