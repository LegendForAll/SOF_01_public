namespace MCoffee_GUI
{
    partial class GUI_Main
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
            this.lb_userName = new System.Windows.Forms.Label();
            this.lb_type = new System.Windows.Forms.Label();
            this.tab_main = new System.Windows.Forms.TabControl();
            this.tb_user = new System.Windows.Forms.TabPage();
            this.tb_order = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_repos = new System.Windows.Forms.TabPage();
            this.tb_report = new System.Windows.Forms.TabPage();
            this.tb_option = new System.Windows.Forms.TabPage();
            this.tab_main.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_userName
            // 
            this.lb_userName.AutoSize = true;
            this.lb_userName.Location = new System.Drawing.Point(674, 9);
            this.lb_userName.Name = "lb_userName";
            this.lb_userName.Size = new System.Drawing.Size(55, 13);
            this.lb_userName.TabIndex = 0;
            this.lb_userName.Text = "Username";
            // 
            // lb_type
            // 
            this.lb_type.AutoSize = true;
            this.lb_type.Location = new System.Drawing.Point(611, 9);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(31, 13);
            this.lb_type.TabIndex = 1;
            this.lb_type.Text = "Type";
            // 
            // tab_main
            // 
            this.tab_main.Controls.Add(this.tb_user);
            this.tab_main.Controls.Add(this.tb_order);
            this.tab_main.Controls.Add(this.tb_repos);
            this.tab_main.Controls.Add(this.tb_report);
            this.tab_main.Controls.Add(this.tb_option);
            this.tab_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab_main.Location = new System.Drawing.Point(0, 0);
            this.tab_main.Name = "tab_main";
            this.tab_main.SelectedIndex = 0;
            this.tab_main.Size = new System.Drawing.Size(894, 460);
            this.tab_main.TabIndex = 2;
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(4, 22);
            this.tb_user.Name = "tb_user";
            this.tb_user.Padding = new System.Windows.Forms.Padding(3);
            this.tb_user.Size = new System.Drawing.Size(792, 299);
            this.tb_user.TabIndex = 0;
            this.tb_user.Text = "User";
            this.tb_user.UseVisualStyleBackColor = true;
            // 
            // tb_order
            // 
            this.tb_order.Location = new System.Drawing.Point(4, 22);
            this.tb_order.Name = "tb_order";
            this.tb_order.Padding = new System.Windows.Forms.Padding(3);
            this.tb_order.Size = new System.Drawing.Size(792, 299);
            this.tb_order.TabIndex = 1;
            this.tb_order.Text = "Order Foods";
            this.tb_order.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_type);
            this.panel1.Controls.Add(this.lb_userName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 30);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tab_main);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 460);
            this.panel2.TabIndex = 4;
            // 
            // tb_repos
            // 
            this.tb_repos.Location = new System.Drawing.Point(4, 22);
            this.tb_repos.Name = "tb_repos";
            this.tb_repos.Padding = new System.Windows.Forms.Padding(3);
            this.tb_repos.Size = new System.Drawing.Size(886, 434);
            this.tb_repos.TabIndex = 2;
            this.tb_repos.Text = "Repository";
            this.tb_repos.UseVisualStyleBackColor = true;
            // 
            // tb_report
            // 
            this.tb_report.Location = new System.Drawing.Point(4, 22);
            this.tb_report.Name = "tb_report";
            this.tb_report.Padding = new System.Windows.Forms.Padding(3);
            this.tb_report.Size = new System.Drawing.Size(792, 299);
            this.tb_report.TabIndex = 3;
            this.tb_report.Text = "Report";
            this.tb_report.UseVisualStyleBackColor = true;
            // 
            // tb_option
            // 
            this.tb_option.Location = new System.Drawing.Point(4, 22);
            this.tb_option.Name = "tb_option";
            this.tb_option.Padding = new System.Windows.Forms.Padding(3);
            this.tb_option.Size = new System.Drawing.Size(792, 299);
            this.tb_option.TabIndex = 4;
            this.tb_option.Text = "Options";
            this.tb_option.UseVisualStyleBackColor = true;
            // 
            // GUI_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GUI_Main";
            this.Text = "GUI_Main";
            this.Load += new System.EventHandler(this.GUI_Main_Load);
            this.tab_main.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_userName;
        private System.Windows.Forms.Label lb_type;
        private System.Windows.Forms.TabControl tab_main;
        private System.Windows.Forms.TabPage tb_user;
        private System.Windows.Forms.TabPage tb_order;
        private System.Windows.Forms.TabPage tb_repos;
        private System.Windows.Forms.TabPage tb_report;
        private System.Windows.Forms.TabPage tb_option;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}