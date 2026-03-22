namespace App.WinForms.Views
{
    partial class ProductView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductView));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.pnlFilter = new System.Windows.Forms.TableLayoutPanel();
            this.LblSearch = new System.Windows.Forms.TextBox();
            this.CmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbStock = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PnlDrid = new System.Windows.Forms.Panel();
            this.dataGridViewproducts = new System.Windows.Forms.DataGridView();
            this.colid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCateogry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.PnlDrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewproducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlFilter, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PnlDrid, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(16);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(963, 547);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(19, 19);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(925, 50);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(93, 44);
            this.toolStripButton1.Text = "Add";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(90, 44);
            this.toolStripButton2.Text = "Edit";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(101, 44);
            this.toolStripButton3.Text = "View";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(120, 44);
            this.toolStripButton4.Text = "Delete";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(129, 44);
            this.toolStripButton5.Text = "Refresh";
            // 
            // pnlFilter
            // 
            this.pnlFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.ColumnCount = 3;
            this.pnlFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.pnlFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlFilter.Controls.Add(this.LblSearch, 0, 1);
            this.pnlFilter.Controls.Add(this.CmbCategory, 1, 1);
            this.pnlFilter.Controls.Add(this.cmbStock, 2, 1);
            this.pnlFilter.Controls.Add(this.label1, 0, 0);
            this.pnlFilter.Controls.Add(this.label2, 1, 0);
            this.pnlFilter.Controls.Add(this.label3, 2, 0);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilter.Location = new System.Drawing.Point(19, 75);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.pnlFilter.RowCount = 2;
            this.pnlFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.72414F));
            this.pnlFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.27586F));
            this.pnlFilter.Size = new System.Drawing.Size(925, 78);
            this.pnlFilter.TabIndex = 1;
            // 
            // LblSearch
            // 
            this.LblSearch.Location = new System.Drawing.Point(15, 43);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(354, 31);
            this.LblSearch.TabIndex = 0;
            // 
            // CmbCategory
            // 
            this.CmbCategory.FormattingEnabled = true;
            this.CmbCategory.Location = new System.Drawing.Point(375, 43);
            this.CmbCategory.Name = "CmbCategory";
            this.CmbCategory.Size = new System.Drawing.Size(264, 33);
            this.CmbCategory.TabIndex = 1;
            // 
            // cmbStock
            // 
            this.cmbStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbStock.FormattingEnabled = true;
            this.cmbStock.Location = new System.Drawing.Point(645, 43);
            this.cmbStock.Name = "cmbStock";
            this.cmbStock.Size = new System.Drawing.Size(265, 33);
            this.cmbStock.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(375, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(645, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stock Status";
            // 
            // PnlDrid
            // 
            this.PnlDrid.BackColor = System.Drawing.Color.White;
            this.PnlDrid.Controls.Add(this.dataGridViewproducts);
            this.PnlDrid.Location = new System.Drawing.Point(19, 159);
            this.PnlDrid.Name = "PnlDrid";
            this.PnlDrid.Padding = new System.Windows.Forms.Padding(12);
            this.PnlDrid.Size = new System.Drawing.Size(925, 369);
            this.PnlDrid.TabIndex = 2;
            // 
            // dataGridViewproducts
            // 
            this.dataGridViewproducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewproducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colid,
            this.Colname,
            this.ColCateogry,
            this.ColPrice,
            this.ColStock,
            this.ColStatus});
            this.dataGridViewproducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewproducts.GridColor = System.Drawing.Color.White;
            this.dataGridViewproducts.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewproducts.MultiSelect = false;
            this.dataGridViewproducts.Name = "dataGridViewproducts";
            this.dataGridViewproducts.ReadOnly = true;
            this.dataGridViewproducts.RowHeadersVisible = false;
            this.dataGridViewproducts.RowHeadersWidth = 82;
            this.dataGridViewproducts.RowTemplate.Height = 33;
            this.dataGridViewproducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewproducts.Size = new System.Drawing.Size(901, 345);
            this.dataGridViewproducts.TabIndex = 0;
            // 
            // colid
            // 
            this.colid.HeaderText = "ID";
            this.colid.MinimumWidth = 10;
            this.colid.Name = "colid";
            this.colid.ReadOnly = true;
            // 
            // Colname
            // 
            this.Colname.HeaderText = "Name";
            this.Colname.MinimumWidth = 10;
            this.Colname.Name = "Colname";
            this.Colname.ReadOnly = true;
            // 
            // ColCateogry
            // 
            this.ColCateogry.HeaderText = "Category";
            this.ColCateogry.MinimumWidth = 10;
            this.ColCateogry.Name = "ColCateogry";
            this.ColCateogry.ReadOnly = true;
            // 
            // ColPrice
            // 
            this.ColPrice.HeaderText = "Price";
            this.ColPrice.MinimumWidth = 10;
            this.ColPrice.Name = "ColPrice";
            this.ColPrice.ReadOnly = true;
            // 
            // ColStock
            // 
            this.ColStock.HeaderText = "Stock";
            this.ColStock.MinimumWidth = 10;
            this.ColStock.Name = "ColStock";
            this.ColStock.ReadOnly = true;
            // 
            // ColStatus
            // 
            this.ColStatus.HeaderText = "Status";
            this.ColStatus.MinimumWidth = 10;
            this.ColStatus.Name = "ColStatus";
            this.ColStatus.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProductView";
            this.Size = new System.Drawing.Size(969, 539);
            this.Load += new System.EventHandler(this.ProductView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.PnlDrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewproducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.TableLayoutPanel pnlFilter;
        private System.Windows.Forms.TextBox LblSearch;
        private System.Windows.Forms.ComboBox CmbCategory;
        private System.Windows.Forms.ComboBox cmbStock;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PnlDrid;
        private System.Windows.Forms.DataGridView dataGridViewproducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCateogry;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatus;
    }
}
