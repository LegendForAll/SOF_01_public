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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bill)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_bill
            // 
            this.dgv_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bill.Location = new System.Drawing.Point(21, 30);
            this.dgv_bill.Name = "dgv_bill";
            this.dgv_bill.Size = new System.Drawing.Size(489, 150);
            this.dgv_bill.TabIndex = 0;
            // 
            // GUI_ORDER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_bill);
            this.Name = "GUI_ORDER";
            this.Text = "GUI_ORDER";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_bill;
    }
}