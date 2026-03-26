namespace App.WindowsApp.Views
{
    partial class ProductForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnSave = new Button();
            btnCancel = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            textbox = new TextBox();
            CategorycomboBox = new ComboBox();
            priceUpDown = new NumericUpDown();
            statusbox = new ComboBox();
            IDtextBox = new TextBox();
            btnName = new Button();
            btnCategory = new Button();
            BtnPrice = new Button();
            BtnStock = new Button();
            BtnStatue = new Button();
            BtnId = new Button();
            StockUpDown = new NumericUpDown();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)priceUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StockUpDown).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnSave);
            flowLayoutPanel1.Controls.Add(btnCancel);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 227);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(644, 51);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(529, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.Location = new Point(411, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Controls.Add(textbox, 1, 0);
            tableLayoutPanel1.Controls.Add(CategorycomboBox, 1, 1);
            tableLayoutPanel1.Controls.Add(priceUpDown, 1, 2);
            tableLayoutPanel1.Controls.Add(statusbox, 1, 4);
            tableLayoutPanel1.Controls.Add(IDtextBox, 1, 5);
            tableLayoutPanel1.Controls.Add(btnName, 0, 0);
            tableLayoutPanel1.Controls.Add(btnCategory, 0, 1);
            tableLayoutPanel1.Controls.Add(BtnPrice, 0, 2);
            tableLayoutPanel1.Controls.Add(BtnStock, 0, 3);
            tableLayoutPanel1.Controls.Add(BtnStatue, 0, 4);
            tableLayoutPanel1.Controls.Add(BtnId, 0, 5);
            tableLayoutPanel1.Controls.Add(StockUpDown, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(644, 221);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // textbox
            // 
            textbox.Dock = DockStyle.Fill;
            textbox.Location = new Point(99, 3);
            textbox.Name = "textbox";
            textbox.Size = new Size(542, 31);
            textbox.TabIndex = 0;
            // 
            // CategorycomboBox
            // 
            CategorycomboBox.Dock = DockStyle.Fill;
            CategorycomboBox.FormattingEnabled = true;
            CategorycomboBox.Location = new Point(99, 39);
            CategorycomboBox.Name = "CategorycomboBox";
            CategorycomboBox.Size = new Size(542, 33);
            CategorycomboBox.TabIndex = 1;
            // 
            // priceUpDown
            // 
            priceUpDown.Dock = DockStyle.Fill;
            priceUpDown.Location = new Point(99, 75);
            priceUpDown.Name = "priceUpDown";
            priceUpDown.Size = new Size(542, 31);
            priceUpDown.TabIndex = 2;
            // 
            // statusbox
            // 
            statusbox.Dock = DockStyle.Fill;
            statusbox.FormattingEnabled = true;
            statusbox.Location = new Point(99, 147);
            statusbox.Name = "statusbox";
            statusbox.Size = new Size(542, 33);
            statusbox.TabIndex = 4;
            // 
            // IDtextBox
            // 
            IDtextBox.Dock = DockStyle.Fill;
            IDtextBox.Location = new Point(99, 183);
            IDtextBox.Name = "IDtextBox";
            IDtextBox.Size = new Size(542, 31);
            IDtextBox.TabIndex = 5;
            // 
            // btnName
            // 
            btnName.Dock = DockStyle.Left;
            btnName.Location = new Point(3, 3);
            btnName.Name = "btnName";
            btnName.Size = new Size(90, 30);
            btnName.TabIndex = 6;
            btnName.Text = "Name";
            btnName.UseVisualStyleBackColor = true;
            // 
            // btnCategory
            // 
            btnCategory.Dock = DockStyle.Left;
            btnCategory.Location = new Point(3, 39);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(90, 30);
            btnCategory.TabIndex = 7;
            btnCategory.Text = "Category";
            btnCategory.UseVisualStyleBackColor = true;
            // 
            // BtnPrice
            // 
            BtnPrice.Dock = DockStyle.Left;
            BtnPrice.Location = new Point(3, 75);
            BtnPrice.Name = "BtnPrice";
            BtnPrice.Size = new Size(90, 30);
            BtnPrice.TabIndex = 8;
            BtnPrice.Text = "Price";
            BtnPrice.UseVisualStyleBackColor = true;
            // 
            // BtnStock
            // 
            BtnStock.Dock = DockStyle.Left;
            BtnStock.Location = new Point(3, 111);
            BtnStock.Name = "BtnStock";
            BtnStock.Size = new Size(90, 30);
            BtnStock.TabIndex = 9;
            BtnStock.Text = "Stock";
            BtnStock.UseVisualStyleBackColor = true;
            // 
            // BtnStatue
            // 
            BtnStatue.Dock = DockStyle.Left;
            BtnStatue.Location = new Point(3, 147);
            BtnStatue.Name = "BtnStatue";
            BtnStatue.Size = new Size(90, 30);
            BtnStatue.TabIndex = 10;
            BtnStatue.Text = "Status";
            BtnStatue.UseVisualStyleBackColor = true;
            // 
            // BtnId
            // 
            BtnId.Dock = DockStyle.Left;
            BtnId.Location = new Point(3, 183);
            BtnId.Name = "BtnId";
            BtnId.Size = new Size(90, 35);
            BtnId.TabIndex = 11;
            BtnId.Text = "ID";
            BtnId.UseVisualStyleBackColor = true;
            // 
            // StockUpDown
            // 
            StockUpDown.Dock = DockStyle.Fill;
            StockUpDown.Location = new Point(99, 111);
            StockUpDown.Name = "StockUpDown";
            StockUpDown.Size = new Size(542, 31);
            StockUpDown.TabIndex = 3;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 278);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(flowLayoutPanel1);
            Name = "ProductForm";
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)priceUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)StockUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnCancel;
        private Button btnSave;
        private TextBox textbox;
        private ComboBox CategorycomboBox;
        private NumericUpDown priceUpDown;
        private ComboBox statusbox;
        private TextBox IDtextBox;
        private Button btnName;
        private Button btnCategory;
        private Button BtnPrice;
        private Button BtnStock;
        private Button BtnStatue;
        private Button BtnId;
        private NumericUpDown StockUpDown;
    }
}