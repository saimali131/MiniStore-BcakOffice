namespace App.WindowsApp.Forms
{
    partial class Mainform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlheader = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlsidebar = new System.Windows.Forms.Panel();
            this.flpNav = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.Btnorders = new System.Windows.Forms.Button();
            this.BtnReport = new System.Windows.Forms.Button();
            this.BtnSync = new System.Windows.Forms.Button();
            this.BtnLogs = new System.Windows.Forms.Button();
            this.BtnSetting = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlheader.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.pnlsidebar.SuspendLayout();
            this.flpNav.SuspendLayout();
            //this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pnlheader
            // 
            this.pnlheader.Controls.Add(this.flowLayoutPanel1);
            this.pnlheader.Controls.Add(this.flowLayoutPanel2);
            this.pnlheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlheader.Location = new System.Drawing.Point(0, 0);
            this.pnlheader.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlheader.Name = "pnlheader";
            this.pnlheader.Size = new System.Drawing.Size(1534, 51);
            this.pnlheader.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pbLogo);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(212, 51);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = App.WindowsApp.Properties.Resources.icon_home;
            this.pbLogo.Location = new System.Drawing.Point(3, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(37, 38);
            this.pbLogo.TabIndex = 0; 
            this.pbLogo.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel2.Controls.Add(this.lblUser);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1401, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(133, 51);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = App.WindowsApp.Properties.Resources.icon_user;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 38);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(46, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(84, 32);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Admin";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 895);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 15, 0);
            this.statusStrip.Size = new System.Drawing.Size(1534, 42);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "Ready";
            this.statusStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(78, 32);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // pnlsidebar
            // 
            this.pnlsidebar.Controls.Add(this.flpNav);
            this.pnlsidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlsidebar.Location = new System.Drawing.Point(0, 51);
            this.pnlsidebar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlsidebar.Name = "pnlsidebar";
            this.pnlsidebar.Size = new System.Drawing.Size(212, 844);
            this.pnlsidebar.TabIndex = 3;
            // 
            // flpNav
            // 
            this.flpNav.Controls.Add(this.btnDashboard);
            this.flpNav.Controls.Add(this.btnProducts);
            this.flpNav.Controls.Add(this.Btnorders);
            this.flpNav.Controls.Add(this.BtnReport);
            this.flpNav.Controls.Add(this.BtnSync);
            this.flpNav.Controls.Add(this.BtnLogs);
            this.flpNav.Controls.Add(this.BtnSetting);
            this.flpNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpNav.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpNav.Location = new System.Drawing.Point(0, 0);
            this.flpNav.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flpNav.Name = "flpNav";
            this.flpNav.Size = new System.Drawing.Size(212, 844);
            this.flpNav.TabIndex = 0;
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(3, 3);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(200, 40);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = " Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(3, 49);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProducts.Size = new System.Drawing.Size(200, 40);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Products";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // Btnorders
            // 
            this.Btnorders.FlatAppearance.BorderSize = 0;
            this.Btnorders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnorders.Image = App.WindowsApp.Properties.Resources.icon_orders;
            this.Btnorders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnorders.Location = new System.Drawing.Point(3, 95);
            this.Btnorders.Name = "Btnorders";
            this.Btnorders.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Btnorders.Size = new System.Drawing.Size(200, 40);
            this.Btnorders.TabIndex = 2;
            this.Btnorders.Text = "Orders";
            this.Btnorders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnorders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btnorders.UseVisualStyleBackColor = true;
            this.Btnorders.Click += new System.EventHandler(this.Btnorders_Click);
            // 
            // BtnReport
            // 
            this.BtnReport.FlatAppearance.BorderSize = 0;
            this.BtnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReport.Image = App.WindowsApp.Properties.Resources.icon_report;
            this.BtnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReport.Location = new System.Drawing.Point(3, 141);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnReport.Size = new System.Drawing.Size(200, 40);
            this.BtnReport.TabIndex = 3;
            this.BtnReport.Text = "Reports";
            this.BtnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReport.UseVisualStyleBackColor = true;
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // BtnSync
            // 
            this.BtnSync.FlatAppearance.BorderSize = 0;
            this.BtnSync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSync.Image = App.WindowsApp.Properties.Resources.icon_sync;
            this.BtnSync.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSync.Location = new System.Drawing.Point(3, 187);
            this.BtnSync.Name = "BtnSync";
            this.BtnSync.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnSync.Size = new System.Drawing.Size(200, 40);
            this.BtnSync.TabIndex = 4;
            this.BtnSync.Text = "Sync";
            this.BtnSync.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSync.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSync.UseVisualStyleBackColor = true;
            this.BtnSync.Click += new System.EventHandler(this.BtnSync_Click);
            // 
            // BtnLogs
            // 
            this.BtnLogs.FlatAppearance.BorderSize = 0;
            this.BtnLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogs.Image = App.WindowsApp.Properties.Resources.icon_logs;
            this.BtnLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogs.Location = new System.Drawing.Point(3, 233);
            this.BtnLogs.Name = "BtnLogs";
            this.BtnLogs.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnLogs.Size = new System.Drawing.Size(200, 40);
            this.BtnLogs.TabIndex = 5;
            this.BtnLogs.Text = "Logs";
            this.BtnLogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLogs.UseVisualStyleBackColor = true;
            this.BtnLogs.Click += new System.EventHandler(this.BtnLogs_Click);
            // 
            // BtnSetting
            // 
            this.BtnSetting.FlatAppearance.BorderSize = 0;
            this.BtnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSetting.Image = App.WindowsApp.Properties.Resources.icon_settings;
            this.BtnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSetting.Location = new System.Drawing.Point(3, 279);
            this.BtnSetting.Name = "BtnSetting";
            this.BtnSetting.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnSetting.Size = new System.Drawing.Size(200, 48);
            this.BtnSetting.TabIndex = 6;
            this.BtnSetting.Text = "Setting";
            this.BtnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSetting.UseVisualStyleBackColor = true;
            this.BtnSetting.Click += new System.EventHandler(this.button7_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(212, 51);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1322, 844);
            this.pnlContent.TabIndex = 4;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 937);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlsidebar);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pnlheader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mainform";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlheader.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.pnlsidebar.ResumeLayout(false);
            this.flpNav.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel pnlheader;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Panel pnlsidebar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flpNav;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button Btnorders;
        private System.Windows.Forms.Button BtnReport;
        private System.Windows.Forms.Button BtnSync;
        private System.Windows.Forms.Button BtnLogs;
        private System.Windows.Forms.Button BtnSetting;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel pnlContent;
    }
}