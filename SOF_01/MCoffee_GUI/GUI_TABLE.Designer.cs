namespace MCoffee_GUI
{
    partial class GUI_TABLE
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
            this.fpn_table = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_id = new System.Windows.Forms.TextBox();
            this.ntd_number = new System.Windows.Forms.NumericUpDown();
            this.ntd_limit = new System.Windows.Forms.NumericUpDown();
            this.cbx_status = new System.Windows.Forms.ComboBox();
            this.btn_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ntd_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntd_limit)).BeginInit();
            this.SuspendLayout();
            // 
            // fpn_table
            // 
            this.fpn_table.AutoScroll = true;
            this.fpn_table.BackColor = System.Drawing.Color.White;
            this.fpn_table.Location = new System.Drawing.Point(12, 12);
            this.fpn_table.Name = "fpn_table";
            this.fpn_table.Size = new System.Drawing.Size(359, 401);
            this.fpn_table.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(380, 151);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Code table:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Limit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Status:";
            // 
            // tbx_id
            // 
            this.tbx_id.Enabled = false;
            this.tbx_id.Location = new System.Drawing.Point(445, 23);
            this.tbx_id.Name = "tbx_id";
            this.tbx_id.Size = new System.Drawing.Size(70, 20);
            this.tbx_id.TabIndex = 7;
            // 
            // ntd_number
            // 
            this.ntd_number.Location = new System.Drawing.Point(445, 48);
            this.ntd_number.Name = "ntd_number";
            this.ntd_number.Size = new System.Drawing.Size(46, 20);
            this.ntd_number.TabIndex = 8;
            // 
            // ntd_limit
            // 
            this.ntd_limit.Location = new System.Drawing.Point(445, 75);
            this.ntd_limit.Name = "ntd_limit";
            this.ntd_limit.Size = new System.Drawing.Size(46, 20);
            this.ntd_limit.TabIndex = 9;
            // 
            // cbx_status
            // 
            this.cbx_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_status.FormattingEnabled = true;
            this.cbx_status.Items.AddRange(new object[] {
            "Free",
            "Busy"});
            this.cbx_status.Location = new System.Drawing.Point(445, 100);
            this.cbx_status.Name = "cbx_status";
            this.cbx_status.Size = new System.Drawing.Size(70, 21);
            this.cbx_status.TabIndex = 10;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(380, 180);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // GUI_TABLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 425);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.cbx_status);
            this.Controls.Add(this.ntd_limit);
            this.Controls.Add(this.ntd_number);
            this.Controls.Add(this.tbx_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.fpn_table);
            this.Name = "GUI_TABLE";
            this.Text = "GUI_TABLE";
            this.Load += new System.EventHandler(this.GUI_TABLE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ntd_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntd_limit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpn_table;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_id;
        private System.Windows.Forms.NumericUpDown ntd_number;
        private System.Windows.Forms.NumericUpDown ntd_limit;
        private System.Windows.Forms.ComboBox cbx_status;
        private System.Windows.Forms.Button btn_update;
    }
}