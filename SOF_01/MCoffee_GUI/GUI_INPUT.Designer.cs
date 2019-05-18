namespace MCoffee_GUI
{
    partial class GUI_INPUT
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
            this.dataGridViewInputInfo = new System.Windows.Forms.DataGridView();
            this.OBJECT = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.EMPLOYEE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICEINPUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.dtpInput = new System.Windows.Forms.DateTimePicker();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewInput = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATEINPUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInputInfo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInputInfo
            // 
            this.dataGridViewInputInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInputInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewInputInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewInputInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInputInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OBJECT,
            this.EMPLOYEE,
            this.Count,
            this.PRICEINPUT});
            this.dataGridViewInputInfo.Location = new System.Drawing.Point(0, 219);
            this.dataGridViewInputInfo.Name = "dataGridViewInputInfo";
            this.dataGridViewInputInfo.Size = new System.Drawing.Size(583, 259);
            this.dataGridViewInputInfo.TabIndex = 0;
            // 
            // OBJECT
            // 
            this.OBJECT.HeaderText = "Tên nguyên liệu";
            this.OBJECT.Name = "OBJECT";
            this.OBJECT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OBJECT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // EMPLOYEE
            // 
            this.EMPLOYEE.HeaderText = "Nhân viên";
            this.EMPLOYEE.Name = "EMPLOYEE";
            // 
            // Count
            // 
            this.Count.HeaderText = "Số lượng";
            this.Count.Name = "Count";
            // 
            // PRICEINPUT
            // 
            this.PRICEINPUT.HeaderText = "Đơn giá";
            this.PRICEINPUT.Name = "PRICEINPUT";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btReset);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btUpdate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Controls.Add(this.dtpInput);
            this.panel1.Controls.Add(this.tbID);
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 144);
            this.panel1.TabIndex = 1;
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(454, 103);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 23);
            this.btReset.TabIndex = 8;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ngày nhập";
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(188, 103);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 4;
            this.btUpdate.Text = "Sửa";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã phiếu nhập";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(26, 103);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // dtpInput
            // 
            this.dtpInput.Location = new System.Drawing.Point(107, 67);
            this.dtpInput.Name = "dtpInput";
            this.dtpInput.Size = new System.Drawing.Size(200, 20);
            this.dtpInput.TabIndex = 5;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(107, 22);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(200, 20);
            this.tbID.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Danh sách hàng nhập";
            // 
            // dataGridViewInput
            // 
            this.dataGridViewInput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DATEINPUT});
            this.dataGridViewInput.Location = new System.Drawing.Point(589, 28);
            this.dataGridViewInput.Name = "dataGridViewInput";
            this.dataGridViewInput.Size = new System.Drawing.Size(240, 450);
            this.dataGridViewInput.TabIndex = 6;
            this.dataGridViewInput.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInfo_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "STT";
            this.ID.Name = "ID";
            // 
            // DATEINPUT
            // 
            this.DATEINPUT.HeaderText = "Ngày nhập kho";
            this.DATEINPUT.Name = "DATEINPUT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(646, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Danh sách phiếu nhập";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GUI_INPUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 479);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewInputInfo);
            this.Name = "GUI_INPUT";
            this.Text = "Quản lý nhập kho";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInputInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInputInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpInput;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewInput;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATEINPUT;
        private System.Windows.Forms.DataGridViewComboBoxColumn OBJECT;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPLOYEE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICEINPUT;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button button1;
    }
}