namespace App.WinForms.Views
{
    partial class DashboardView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tbl_Dashborad = new System.Windows.Forms.TableLayoutPanel();
            this.flpKpi = new System.Windows.Forms.FlowLayoutPanel();
            this.Sales_pnl = new System.Windows.Forms.Panel();
            this.lbl_sales = new System.Windows.Forms.Label();
            this.lbl_sales_value = new System.Windows.Forms.Label();
            this.Order_pnl = new System.Windows.Forms.Panel();
            this.Lbl_order_value = new System.Windows.Forms.Label();
            this.Lbl_Order = new System.Windows.Forms.Label();
            this.Rev_pnl = new System.Windows.Forms.Panel();
            this.Lbl_rev_value = new System.Windows.Forms.Label();
            this.Lbl_rev = new System.Windows.Forms.Label();
            this.Pnl_lowStock = new System.Windows.Forms.Panel();
            this.lvLowStock = new System.Windows.Forms.ListView();
            this.colProd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvRecentOrders = new System.Windows.Forms.ListView();
            this.colOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCustom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.Tbl_Dashborad.SuspendLayout();
            this.flpKpi.SuspendLayout();
            this.Sales_pnl.SuspendLayout();
            this.Order_pnl.SuspendLayout();
            this.Rev_pnl.SuspendLayout();
            this.Pnl_lowStock.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tbl_Dashborad
            // 
            this.Tbl_Dashborad.ColumnCount = 1;
            this.Tbl_Dashborad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tbl_Dashborad.Controls.Add(this.flpKpi, 0, 0);
            this.Tbl_Dashborad.Controls.Add(this.Pnl_lowStock, 0, 1);
            this.Tbl_Dashborad.Controls.Add(this.panel1, 0, 2);
            this.Tbl_Dashborad.Location = new System.Drawing.Point(0, 0);
            this.Tbl_Dashborad.Name = "Tbl_Dashborad";
            this.Tbl_Dashborad.RowCount = 3;
            this.Tbl_Dashborad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.Tbl_Dashborad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tbl_Dashborad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tbl_Dashborad.Size = new System.Drawing.Size(1160, 642);
            this.Tbl_Dashborad.TabIndex = 0;
            // 
            // flpKpi
            // 
            this.flpKpi.Controls.Add(this.Sales_pnl);
            this.flpKpi.Controls.Add(this.Order_pnl);
            this.flpKpi.Controls.Add(this.Rev_pnl);
            this.flpKpi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpKpi.Location = new System.Drawing.Point(3, 3);
            this.flpKpi.Name = "flpKpi";
            this.flpKpi.Size = new System.Drawing.Size(1154, 114);
            this.flpKpi.TabIndex = 0;
            // 
            // Sales_pnl
            // 
            this.Sales_pnl.Controls.Add(this.lbl_sales);
            this.Sales_pnl.Controls.Add(this.lbl_sales_value);
            this.Sales_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Sales_pnl.Location = new System.Drawing.Point(3, 3);
            this.Sales_pnl.Name = "Sales_pnl";
            this.Sales_pnl.Size = new System.Drawing.Size(383, 100);
            this.Sales_pnl.TabIndex = 0;
            // 
            // lbl_sales
            // 
            this.lbl_sales.AutoSize = true;
            this.lbl_sales.Location = new System.Drawing.Point(37, 37);
            this.lbl_sales.Name = "lbl_sales";
            this.lbl_sales.Size = new System.Drawing.Size(66, 25);
            this.lbl_sales.TabIndex = 0;
            this.lbl_sales.Text = "Sales";
            // 
            // lbl_sales_value
            // 
            this.lbl_sales_value.AutoSize = true;
            this.lbl_sales_value.Location = new System.Drawing.Point(236, 36);
            this.lbl_sales_value.Name = "lbl_sales_value";
            this.lbl_sales_value.Size = new System.Drawing.Size(48, 25);
            this.lbl_sales_value.TabIndex = 0;
            this.lbl_sales_value.Text = "232";
            this.lbl_sales_value.Click += new System.EventHandler(this.label2_Click);
            // 
            // Order_pnl
            // 
            this.Order_pnl.Controls.Add(this.Lbl_order_value);
            this.Order_pnl.Controls.Add(this.Lbl_Order);
            this.Order_pnl.Location = new System.Drawing.Point(392, 3);
            this.Order_pnl.Name = "Order_pnl";
            this.Order_pnl.Size = new System.Drawing.Size(355, 100);
            this.Order_pnl.TabIndex = 1;
            // 
            // Lbl_order_value
            // 
            this.Lbl_order_value.AutoSize = true;
            this.Lbl_order_value.Location = new System.Drawing.Point(300, 36);
            this.Lbl_order_value.Name = "Lbl_order_value";
            this.Lbl_order_value.Size = new System.Drawing.Size(36, 25);
            this.Lbl_order_value.TabIndex = 2;
            this.Lbl_order_value.Text = "43";
            this.Lbl_order_value.Click += new System.EventHandler(this.Lbl_order_value_Click);
            // 
            // Lbl_Order
            // 
            this.Lbl_Order.AutoSize = true;
            this.Lbl_Order.Location = new System.Drawing.Point(73, 37);
            this.Lbl_Order.Name = "Lbl_Order";
            this.Lbl_Order.Size = new System.Drawing.Size(77, 25);
            this.Lbl_Order.TabIndex = 1;
            this.Lbl_Order.Text = "Orders";
            // 
            // Rev_pnl
            // 
            this.Rev_pnl.Controls.Add(this.Lbl_rev_value);
            this.Rev_pnl.Controls.Add(this.Lbl_rev);
            this.Rev_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Rev_pnl.Location = new System.Drawing.Point(753, 3);
            this.Rev_pnl.Name = "Rev_pnl";
            this.Rev_pnl.Size = new System.Drawing.Size(390, 100);
            this.Rev_pnl.TabIndex = 2;
            // 
            // Lbl_rev_value
            // 
            this.Lbl_rev_value.AutoSize = true;
            this.Lbl_rev_value.Location = new System.Drawing.Point(218, 36);
            this.Lbl_rev_value.Name = "Lbl_rev_value";
            this.Lbl_rev_value.Size = new System.Drawing.Size(96, 25);
            this.Lbl_rev_value.TabIndex = 1;
            this.Lbl_rev_value.Text = "132,42rs";
            // 
            // Lbl_rev
            // 
            this.Lbl_rev.AutoSize = true;
            this.Lbl_rev.Location = new System.Drawing.Point(69, 37);
            this.Lbl_rev.Name = "Lbl_rev";
            this.Lbl_rev.Size = new System.Drawing.Size(98, 25);
            this.Lbl_rev.TabIndex = 0;
            this.Lbl_rev.Text = "Revenue";
            // 
            // Pnl_lowStock
            // 
            this.Pnl_lowStock.Controls.Add(this.lvLowStock);
            this.Pnl_lowStock.Controls.Add(this.label1);
            this.Pnl_lowStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_lowStock.Location = new System.Drawing.Point(3, 123);
            this.Pnl_lowStock.Name = "Pnl_lowStock";
            this.Pnl_lowStock.Size = new System.Drawing.Size(1154, 255);
            this.Pnl_lowStock.TabIndex = 1;
            // 
            // lvLowStock
            // 
            this.lvLowStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProd,
            this.colStock});
            this.lvLowStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLowStock.GridLines = true;
            this.lvLowStock.HideSelection = false;
            this.lvLowStock.Location = new System.Drawing.Point(0, 25);
            this.lvLowStock.Name = "lvLowStock";
            this.lvLowStock.Size = new System.Drawing.Size(1154, 230);
            this.lvLowStock.TabIndex = 3;
            this.lvLowStock.UseCompatibleStateImageBehavior = false;
            this.lvLowStock.View = System.Windows.Forms.View.Details;
            // 
            // colProd
            // 
            this.colProd.Text = "Product";
            this.colProd.Width = 186;
            // 
            // colStock
            // 
            this.colStock.Text = "Stock";
            this.colStock.Width = 192;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Low Stock";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lvRecentOrders);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 384);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 255);
            this.panel1.TabIndex = 2;
            // 
            // lvRecentOrders
            // 
            this.lvRecentOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colOrder,
            this.colCustom,
            this.ColTotal,
            this.ColStatus});
            this.lvRecentOrders.GridLines = true;
            this.lvRecentOrders.HideSelection = false;
            this.lvRecentOrders.Location = new System.Drawing.Point(9, 44);
            this.lvRecentOrders.Name = "lvRecentOrders";
            this.lvRecentOrders.Size = new System.Drawing.Size(1148, 208);
            this.lvRecentOrders.TabIndex = 0;
            this.lvRecentOrders.UseCompatibleStateImageBehavior = false;
            this.lvRecentOrders.View = System.Windows.Forms.View.Details;
            // 
            // colOrder
            // 
            this.colOrder.Text = "Order";
            this.colOrder.Width = 95;
            // 
            // colCustom
            // 
            this.colCustom.Text = "Custom";
            this.colCustom.Width = 108;
            // 
            // ColTotal
            // 
            this.ColTotal.Text = "Total";
            this.ColTotal.Width = 98;
            // 
            // ColStatus
            // 
            this.ColStatus.Text = "Status";
            this.ColStatus.Width = 102;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Recent orders";
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Tbl_Dashborad);
            this.Name = "DashboardView";
            this.Size = new System.Drawing.Size(1285, 655);
            this.Tbl_Dashborad.ResumeLayout(false);
            this.flpKpi.ResumeLayout(false);
            this.Sales_pnl.ResumeLayout(false);
            this.Sales_pnl.PerformLayout();
            this.Order_pnl.ResumeLayout(false);
            this.Order_pnl.PerformLayout();
            this.Rev_pnl.ResumeLayout(false);
            this.Rev_pnl.PerformLayout();
            this.Pnl_lowStock.ResumeLayout(false);
            this.Pnl_lowStock.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Tbl_Dashborad;
        private System.Windows.Forms.FlowLayoutPanel flpKpi;
        private System.Windows.Forms.Panel Sales_pnl;
        private System.Windows.Forms.Label lbl_sales;
        private System.Windows.Forms.Panel Order_pnl;
        private System.Windows.Forms.Panel Rev_pnl;
        private System.Windows.Forms.Label Lbl_Order;
        private System.Windows.Forms.Label lbl_sales_value;
        private System.Windows.Forms.Label Lbl_order_value;
        private System.Windows.Forms.Label Lbl_rev_value;
        private System.Windows.Forms.Label Lbl_rev;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Pnl_lowStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvRecentOrders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvLowStock;
        private System.Windows.Forms.ColumnHeader colProd;
        private System.Windows.Forms.ColumnHeader colStock;
        private System.Windows.Forms.ColumnHeader colOrder;
        private System.Windows.Forms.ColumnHeader colCustom;
        private System.Windows.Forms.ColumnHeader ColTotal;
        private System.Windows.Forms.ColumnHeader ColStatus;
    }
}
