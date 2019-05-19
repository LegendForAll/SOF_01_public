namespace MCoffee_GUI
{
    partial class GUI_InputReport
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
            this.btCreate = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.InputReport1 = new MCoffee_GUI.InputReport();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpdateInput = new System.Windows.Forms.DateTimePicker();
            this.InputReport2 = new MCoffee_GUI.InputReport();
            this.btShowAll = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(236, 10);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(75, 23);
            this.btCreate.TabIndex = 0;
            this.btCreate.Text = "Create Report";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.InputReport2;
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 409);
            this.crystalReportViewer1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.crystalReportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 409);
            this.panel1.TabIndex = 2;
            // 
            // dtpdateInput
            // 
            this.dtpdateInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdateInput.Location = new System.Drawing.Point(130, 12);
            this.dtpdateInput.Name = "dtpdateInput";
            this.dtpdateInput.Size = new System.Drawing.Size(100, 20);
            this.dtpdateInput.TabIndex = 3;
            // 
            // btShowAll
            // 
            this.btShowAll.Location = new System.Drawing.Point(317, 9);
            this.btShowAll.Name = "btShowAll";
            this.btShowAll.Size = new System.Drawing.Size(75, 23);
            this.btShowAll.TabIndex = 4;
            this.btShowAll.Text = "Show All";
            this.btShowAll.UseVisualStyleBackColor = true;
            this.btShowAll.Click += new System.EventHandler(this.btShowAll_Click);
            // 
            // GUI_InputReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btShowAll);
            this.Controls.Add(this.dtpdateInput);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btCreate);
            this.Name = "GUI_InputReport";
            this.Text = "GUI_InputReport";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btCreate;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Panel panel1;
        private InputReport InputReport1;
        private System.Windows.Forms.DateTimePicker dtpdateInput;
        private InputReport InputReport2;
        private System.Windows.Forms.Button btShowAll;
    }
}