namespace App.WindowsApp.Views
{
    partial class ProductView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductView));
            tableLayoutPanel1 = new TableLayoutPanel();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton5 = new ToolStripButton();
            pnlFilter = new TableLayoutPanel();
            CmbCategory = new ComboBox();
            cmbStock = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LblSearch = new TextBox();
            PnlDrid = new Panel();
            dataGridViewproducts = new DataGridView();
            colid = new DataGridViewTextBoxColumn();
            Colname = new DataGridViewTextBoxColumn();
            ColCateogry = new DataGridViewTextBoxColumn();
            ColPrice = new DataGridViewTextBoxColumn();
            ColStock = new DataGridViewTextBoxColumn();
            ColStatus = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tableLayoutPanel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            pnlFilter.SuspendLayout();
            PnlDrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewproducts).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(toolStrip1, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlFilter, 0, 1);
            tableLayoutPanel1.Controls.Add(PnlDrid, 0, 2);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2, 3, 2, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(13, 16, 13, 16);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(802, 490);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.White;
            toolStrip1.Dock = DockStyle.Fill;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4, toolStripSeparator1, toolStripButton5 });
            toolStrip1.Location = new Point(15, 19);
            toolStrip1.Margin = new Padding(2, 3, 2, 3);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(772, 50);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(82, 45);
            toolStripButton1.Text = "Add";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(78, 45);
            toolStripButton2.Text = "Edit";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(85, 45);
            toolStripButton3.Text = "View";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(98, 45);
            toolStripButton4.Text = "Delete";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 50);
            // 
            // toolStripButton5
            // 
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(106, 45);
            toolStripButton5.Text = "Refresh";
            // 
            // pnlFilter
            // 
            pnlFilter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlFilter.BackColor = Color.White;
            pnlFilter.ColumnCount = 3;
            pnlFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            pnlFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            pnlFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            pnlFilter.Controls.Add(CmbCategory, 1, 1);
            pnlFilter.Controls.Add(cmbStock, 2, 1);
            pnlFilter.Controls.Add(label1, 0, 0);
            pnlFilter.Controls.Add(label2, 1, 0);
            pnlFilter.Controls.Add(label3, 2, 0);
            pnlFilter.Controls.Add(LblSearch, 0, 1);
            pnlFilter.Dock = DockStyle.Fill;
            pnlFilter.Location = new Point(15, 75);
            pnlFilter.Margin = new Padding(2, 3, 2, 3);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Padding = new Padding(10);
            pnlFilter.RowCount = 2;
            pnlFilter.RowStyles.Add(new RowStyle(SizeType.Percent, 51.72414F));
            pnlFilter.RowStyles.Add(new RowStyle(SizeType.Percent, 48.27586F));
            pnlFilter.Size = new Size(772, 78);
            pnlFilter.TabIndex = 1;
            // 
            // CmbCategory
            // 
            CmbCategory.FormattingEnabled = true;
            CmbCategory.Location = new Point(312, 43);
            CmbCategory.Margin = new Padding(2, 3, 2, 3);
            CmbCategory.Name = "CmbCategory";
            CmbCategory.Size = new Size(221, 33);
            CmbCategory.TabIndex = 1;
            CmbCategory.SelectedIndexChanged += new System.EventHandler(this.CmbCategory_SelectedIndexChanged); 
            // 
            // cmbStock
            // 
            cmbStock.Dock = DockStyle.Fill;
            cmbStock.FormattingEnabled = true;
            cmbStock.Location = new Point(537, 43);
            cmbStock.Margin = new Padding(2, 3, 2, 3);
            cmbStock.Name = "cmbStock";
            cmbStock.Size = new Size(223, 33);
            cmbStock.TabIndex = 2;
            cmbStock.SelectedIndexChanged += new System.EventHandler(this.cmbStock_SelectedIndexChanged);  
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(12, 10);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(296, 30);
            label1.TabIndex = 3;
            label1.Text = "Search";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(312, 10);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(221, 30);
            label2.TabIndex = 4;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(537, 10);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(223, 30);
            label3.TabIndex = 5;
            label3.Text = "Stock Status";
            // 
            // LblSearch
            // 
            LblSearch.Location = new Point(12, 43);
            LblSearch.Margin = new Padding(2, 3, 2, 3);
            LblSearch.Name = "LblSearch";
            LblSearch.Size = new Size(296, 31);
            LblSearch.TabIndex = 0;
            LblSearch.TextChanged += LblSearch_TextChanged;
            // 
            // PnlDrid
            // 
            PnlDrid.BackColor = Color.White;
            PnlDrid.Controls.Add(dataGridViewproducts);
            PnlDrid.Location = new Point(15, 159);
            PnlDrid.Margin = new Padding(2, 3, 2, 3);
            PnlDrid.Name = "PnlDrid";
            PnlDrid.Padding = new Padding(10, 12, 10, 12);
            PnlDrid.Size = new Size(771, 312);
            PnlDrid.TabIndex = 2;
            // 
            // dataGridViewproducts
            // 
            dataGridViewproducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewproducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewproducts.Columns.AddRange(new DataGridViewColumn[] { colid, Colname, ColCateogry, ColPrice, ColStock, ColStatus });
            dataGridViewproducts.Dock = DockStyle.Fill;
            dataGridViewproducts.GridColor = Color.White;
            dataGridViewproducts.Location = new Point(10, 12);
            dataGridViewproducts.Margin = new Padding(2, 3, 2, 3);
            dataGridViewproducts.MultiSelect = false;
            dataGridViewproducts.Name = "dataGridViewproducts";
            dataGridViewproducts.ReadOnly = true;
            dataGridViewproducts.RowHeadersVisible = false;
            dataGridViewproducts.RowHeadersWidth = 82;
            dataGridViewproducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewproducts.Size = new Size(751, 288);
            dataGridViewproducts.TabIndex = 0;
            // 
            // colid
            // 
            colid.DataPropertyName = "ID";
            colid.HeaderText = "ID";
            colid.MinimumWidth = 10;
            colid.Name = "colid";
            colid.ReadOnly = true;
            // 
            // Colname
            // 
            Colname.DataPropertyName = "Name";
            Colname.HeaderText = "Name";
            Colname.MinimumWidth = 10;
            Colname.Name = "Colname";
            Colname.ReadOnly = true;
            // 
            // ColCateogry
            // 
            ColCateogry.DataPropertyName = "Category";
            ColCateogry.HeaderText = "Category";
            ColCateogry.MinimumWidth = 10;
            ColCateogry.Name = "ColCateogry";
            ColCateogry.ReadOnly = true;
            // 
            // ColPrice
            // 
            ColPrice.DataPropertyName = "Price";
            ColPrice.HeaderText = "Price";
            ColPrice.MinimumWidth = 10;
            ColPrice.Name = "ColPrice";
            ColPrice.ReadOnly = true;
            // 
            // ColStock
            // 
            ColStock.DataPropertyName = "Stock";
            ColStock.HeaderText = "Stock";
            ColStock.MinimumWidth = 10;
            ColStock.Name = "ColStock";
            ColStock.ReadOnly = true;
            // 
            // ColStatus
            // 
            ColStatus.DataPropertyName = "Status";
            ColStatus.HeaderText = "Status";
            ColStatus.MinimumWidth = 10;
            ColStatus.Name = "ColStatus";
            ColStatus.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "ProductView";
            Size = new Size(808, 473);
            Load += ProductView_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            PnlDrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewproducts).EndInit();
            ResumeLayout(false);
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
        private DataGridViewTextBoxColumn colid;
        private DataGridViewTextBoxColumn Colname;
        private DataGridViewTextBoxColumn ColCateogry;
        private DataGridViewTextBoxColumn ColPrice;
        private DataGridViewTextBoxColumn ColStock;
        private DataGridViewTextBoxColumn ColStatus;
    }
}