namespace App.WindowsApp.Views
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
            Tbl_Dashborad = new TableLayoutPanel();
            flpKpi = new FlowLayoutPanel();
            Sales_pnl = new Panel();
            lbl_sales = new Label();
            lbl_sales_value = new Label();
            Order_pnl = new Panel();
            Lbl_order_value = new Label();
            Lbl_Order = new Label();
            Rev_pnl = new Panel();
            Lbl_rev_value = new Label();
            Lbl_rev = new Label();
            Pnl_lowStock = new Panel();
            lvLowStock = new ListView();
            colProd = new ColumnHeader();
            colStock = new ColumnHeader();
            label1 = new Label();
            panel1 = new Panel();
            lvRecentOrders = new ListView();
            colOrder = new ColumnHeader();
            colCustom = new ColumnHeader();
            ColTotal = new ColumnHeader();
            ColStatus = new ColumnHeader();
            label2 = new Label();
            Tbl_Dashborad.SuspendLayout();
            flpKpi.SuspendLayout();
            Sales_pnl.SuspendLayout();
            Order_pnl.SuspendLayout();
            Rev_pnl.SuspendLayout();
            Pnl_lowStock.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Tbl_Dashborad
            // 
            Tbl_Dashborad.ColumnCount = 1;
            Tbl_Dashborad.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tbl_Dashborad.Controls.Add(flpKpi, 0, 0);
            Tbl_Dashborad.Controls.Add(Pnl_lowStock, 0, 1);
            Tbl_Dashborad.Controls.Add(panel1, 0, 2);
            Tbl_Dashborad.Location = new Point(0, 0);
            Tbl_Dashborad.Margin = new Padding(2, 3, 2, 3);
            Tbl_Dashborad.Name = "Tbl_Dashborad";
            Tbl_Dashborad.RowCount = 3;
            Tbl_Dashborad.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            Tbl_Dashborad.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Tbl_Dashborad.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Tbl_Dashborad.Size = new Size(967, 642);
            Tbl_Dashborad.TabIndex = 0;
            // 
            // flpKpi
            // 
            flpKpi.Controls.Add(Sales_pnl);
            flpKpi.Controls.Add(Order_pnl);
            flpKpi.Controls.Add(Rev_pnl);
            flpKpi.Dock = DockStyle.Fill;
            flpKpi.Location = new Point(2, 3);
            flpKpi.Margin = new Padding(2, 3, 2, 3);
            flpKpi.Name = "flpKpi";
            flpKpi.Size = new Size(963, 114);
            flpKpi.TabIndex = 0;
            // 
            // Sales_pnl
            // 
            Sales_pnl.Controls.Add(lbl_sales);
            Sales_pnl.Controls.Add(lbl_sales_value);
            Sales_pnl.Dock = DockStyle.Top;
            Sales_pnl.Location = new Point(2, 3);
            Sales_pnl.Margin = new Padding(2, 3, 2, 3);
            Sales_pnl.Name = "Sales_pnl";
            Sales_pnl.Size = new Size(319, 100);
            Sales_pnl.TabIndex = 0;
            // 
            // lbl_sales
            // 
            lbl_sales.AutoSize = true;
            lbl_sales.Location = new Point(31, 37);
            lbl_sales.Margin = new Padding(2, 0, 2, 0);
            lbl_sales.Name = "lbl_sales";
            lbl_sales.Size = new Size(52, 25);
            lbl_sales.TabIndex = 0;
            lbl_sales.Text = "Sales";
            // 
            // lbl_sales_value
            // 
            lbl_sales_value.AutoSize = true;
            lbl_sales_value.Location = new Point(197, 36);
            lbl_sales_value.Margin = new Padding(2, 0, 2, 0);
            lbl_sales_value.Name = "lbl_sales_value";
            lbl_sales_value.Size = new Size(42, 25);
            lbl_sales_value.TabIndex = 0;
            lbl_sales_value.Text = "232";
            lbl_sales_value.Click += label2_Click;
            // 
            // Order_pnl
            // 
            Order_pnl.Controls.Add(Lbl_order_value);
            Order_pnl.Controls.Add(Lbl_Order);
            Order_pnl.Location = new Point(325, 3);
            Order_pnl.Margin = new Padding(2, 3, 2, 3);
            Order_pnl.Name = "Order_pnl";
            Order_pnl.Size = new Size(296, 100);
            Order_pnl.TabIndex = 1;
            // 
            // Lbl_order_value
            // 
            Lbl_order_value.AutoSize = true;
            Lbl_order_value.Location = new Point(250, 36);
            Lbl_order_value.Margin = new Padding(2, 0, 2, 0);
            Lbl_order_value.Name = "Lbl_order_value";
            Lbl_order_value.Size = new Size(32, 25);
            Lbl_order_value.TabIndex = 2;
            Lbl_order_value.Text = "43";
            Lbl_order_value.Click += Lbl_order_value_Click;
            // 
            // Lbl_Order
            // 
            Lbl_Order.AutoSize = true;
            Lbl_Order.Location = new Point(61, 37);
            Lbl_Order.Margin = new Padding(2, 0, 2, 0);
            Lbl_Order.Name = "Lbl_Order";
            Lbl_Order.Size = new Size(66, 25);
            Lbl_Order.TabIndex = 1;
            Lbl_Order.Text = "Orders";
            // 
            // Rev_pnl
            // 
            Rev_pnl.Controls.Add(Lbl_rev_value);
            Rev_pnl.Controls.Add(Lbl_rev);
            Rev_pnl.Dock = DockStyle.Top;
            Rev_pnl.Location = new Point(625, 3);
            Rev_pnl.Margin = new Padding(2, 3, 2, 3);
            Rev_pnl.Name = "Rev_pnl";
            Rev_pnl.Size = new Size(325, 100);
            Rev_pnl.TabIndex = 2;
            // 
            // Lbl_rev_value
            // 
            Lbl_rev_value.AutoSize = true;
            Lbl_rev_value.Location = new Point(182, 36);
            Lbl_rev_value.Margin = new Padding(2, 0, 2, 0);
            Lbl_rev_value.Name = "Lbl_rev_value";
            Lbl_rev_value.Size = new Size(80, 25);
            Lbl_rev_value.TabIndex = 1;
            Lbl_rev_value.Text = "132,42rs";
            // 
            // Lbl_rev
            // 
            Lbl_rev.AutoSize = true;
            Lbl_rev.Location = new Point(58, 37);
            Lbl_rev.Margin = new Padding(2, 0, 2, 0);
            Lbl_rev.Name = "Lbl_rev";
            Lbl_rev.Size = new Size(78, 25);
            Lbl_rev.TabIndex = 0;
            Lbl_rev.Text = "Revenue";
            // 
            // Pnl_lowStock
            // 
            Pnl_lowStock.Controls.Add(lvLowStock);
            Pnl_lowStock.Controls.Add(label1);
            Pnl_lowStock.Dock = DockStyle.Fill;
            Pnl_lowStock.Location = new Point(2, 123);
            Pnl_lowStock.Margin = new Padding(2, 3, 2, 3);
            Pnl_lowStock.Name = "Pnl_lowStock";
            Pnl_lowStock.Size = new Size(963, 255);
            Pnl_lowStock.TabIndex = 1;
            // 
            // lvLowStock
            // 
            lvLowStock.Columns.AddRange(new ColumnHeader[] { colProd, colStock });
            lvLowStock.Dock = DockStyle.Fill;
            lvLowStock.GridLines = true;
            lvLowStock.Location = new Point(0, 25);
            lvLowStock.Margin = new Padding(2, 3, 2, 3);
            lvLowStock.Name = "lvLowStock";
            lvLowStock.Size = new Size(963, 230);
            lvLowStock.TabIndex = 3;
            lvLowStock.UseCompatibleStateImageBehavior = false;
            lvLowStock.View = View.Details;
            // 
            // colProd
            // 
            colProd.Text = "Product";
            colProd.Width = 186;
            // 
            // colStock
            // 
            colStock.Text = "Stock";
            colStock.Width = 192;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 0;
            label1.Text = "Low Stock";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lvRecentOrders);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(2, 384);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(962, 255);
            panel1.TabIndex = 2;
            // 
            // lvRecentOrders
            // 
            lvRecentOrders.Columns.AddRange(new ColumnHeader[] { colOrder, colCustom, ColTotal, ColStatus });
            lvRecentOrders.GridLines = true;
            lvRecentOrders.Location = new Point(8, 44);
            lvRecentOrders.Margin = new Padding(2, 3, 2, 3);
            lvRecentOrders.Name = "lvRecentOrders";
            lvRecentOrders.Size = new Size(957, 208);
            lvRecentOrders.TabIndex = 0;
            lvRecentOrders.UseCompatibleStateImageBehavior = false;
            lvRecentOrders.View = View.Details;
            // 
            // colOrder
            // 
            colOrder.Text = "Order";
            colOrder.Width = 95;
            // 
            // colCustom
            // 
            colCustom.Text = "Custom";
            colCustom.Width = 108;
            // 
            // ColTotal
            // 
            ColTotal.Text = "Total";
            ColTotal.Width = 98;
            // 
            // ColStatus
            // 
            ColStatus.Text = "Status";
            ColStatus.Width = 102;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 0);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 0;
            label2.Text = "Recent orders";
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Tbl_Dashborad);
            Margin = new Padding(2, 3, 2, 3);
            Name = "DashboardView";
            Size = new Size(1071, 655);
            Tbl_Dashborad.ResumeLayout(false);
            flpKpi.ResumeLayout(false);
            Sales_pnl.ResumeLayout(false);
            Sales_pnl.PerformLayout();
            Order_pnl.ResumeLayout(false);
            Order_pnl.PerformLayout();
            Rev_pnl.ResumeLayout(false);
            Rev_pnl.PerformLayout();
            Pnl_lowStock.ResumeLayout(false);
            Pnl_lowStock.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

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
