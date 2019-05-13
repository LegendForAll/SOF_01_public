namespace MCoffee_GUI
{
    partial class GUI_AddFoodCategory
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
            this.btAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(350, 107);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 13;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(523, 50);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(155, 20);
            this.txbName.TabIndex = 9;
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(141, 50);
            this.txbID.Name = "txbID";
            this.txbID.ReadOnly = true;
            this.txbID.Size = new System.Drawing.Size(165, 20);
            this.txbID.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // GUI_AddFoodCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 142);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.label1);
            this.Name = "GUI_AddFoodCategory";
            this.Text = "GUI_AddFoodCategory";
            this.Load += new System.EventHandler(this.GUI_AddFoodCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label1;
    }
}