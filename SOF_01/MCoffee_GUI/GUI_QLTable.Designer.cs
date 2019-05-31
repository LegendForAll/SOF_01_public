namespace MCoffee_GUI
{
    partial class GUI_QLTable
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbx_status = new System.Windows.Forms.ComboBox();
            this.ntd_limit = new System.Windows.Forms.NumericUpDown();
            this.ntd_number = new System.Windows.Forms.NumericUpDown();
            this.tbx_id = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntd_limit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntd_number)).BeginInit();
            this.SuspendLayout();
            // 
            // fpn_table
            // 
            this.fpn_table.Location = new System.Drawing.Point(12, 100);
            this.fpn_table.Name = "fpn_table";
            this.fpn_table.Size = new System.Drawing.Size(334, 360);
            this.fpn_table.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.cbx_status);
            this.panel1.Controls.Add(this.tbx_id);
            this.panel1.Controls.Add(this.ntd_limit);
            this.panel1.Controls.Add(this.ntd_number);
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 87);
            this.panel1.TabIndex = 1;
            // 
            // cbx_status
            // 
            this.cbx_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_status.FormattingEnabled = true;
            this.cbx_status.Items.AddRange(new object[] {
            "Free",
            "Busy"});
            this.cbx_status.Location = new System.Drawing.Point(229, 30);
            this.cbx_status.Name = "cbx_status";
            this.cbx_status.Size = new System.Drawing.Size(70, 21);
            this.cbx_status.TabIndex = 14;
            // 
            // ntd_limit
            // 
            this.ntd_limit.Location = new System.Drawing.Point(229, 6);
            this.ntd_limit.Name = "ntd_limit";
            this.ntd_limit.Size = new System.Drawing.Size(46, 20);
            this.ntd_limit.TabIndex = 13;
            // 
            // ntd_number
            // 
            this.ntd_number.Location = new System.Drawing.Point(76, 32);
            this.ntd_number.Name = "ntd_number";
            this.ntd_number.Size = new System.Drawing.Size(46, 20);
            this.ntd_number.TabIndex = 12;
            // 
            // tbx_id
            // 
            this.tbx_id.Enabled = false;
            this.tbx_id.Location = new System.Drawing.Point(76, 6);
            this.tbx_id.Name = "tbx_id";
            this.tbx_id.Size = new System.Drawing.Size(70, 20);
            this.tbx_id.TabIndex = 11;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(166, 57);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 15;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(247, 57);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 16;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Limit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Code table:";
            // 
            // GUI_QLTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 469);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fpn_table);
            this.Name = "GUI_QLTable";
            this.Text = "GUI_QLTable";
            this.Load += new System.EventHandler(this.GUI_QLTable_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntd_limit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntd_number)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpn_table;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbx_status;
        private System.Windows.Forms.TextBox tbx_id;
        private System.Windows.Forms.NumericUpDown ntd_limit;
        private System.Windows.Forms.NumericUpDown ntd_number;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}