using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;
using App.WindowsApp.Forms;
using System;
using System.Windows.Forms;
namespace App.WindowsApp.Views
{
    public partial class ProductForm : Form
    {
        ProductFormEnumMode _mode;
        Product _product;
        IProductService _service;

        public ProductForm(ProductFormEnumMode mode, Product? p, IProductService service)

        {
            InitializeComponent();

            priceUpDown.Maximum = Decimal.MaxValue;
            StockUpDown.Maximum = Int32.MaxValue;

            CategorycomboBox.Items.Clear();
            CategorycomboBox.DataSource = (Enum.GetValues(typeof(ProductCategoreyEnum)));
            CategorycomboBox.SelectedIndex = 0;

            statusbox.Items.Clear();
            statusbox.DataSource = (Enum.GetValues(typeof(ProductStatusEnum)));
            statusbox.SelectedIndex = 0;

            if (mode == ProductFormEnumMode.Edit)
            {
                btnSave.Text = "Update";
            }
            else if (mode == ProductFormEnumMode.View)

            {
                btnSave.Visible = false;
            }
            _mode = mode;
            _product = p;
            _service = service;
            if (mode == ProductFormEnumMode.Edit || mode == ProductFormEnumMode.View)
            {

                IDtextBox.Text = p.ID;
                textbox.Text = p.Name;
                CategorycomboBox.SelectedItem = p.Category;
                statusbox.SelectedItem = p.Status;
                priceUpDown.Value = p.Price;
                StockUpDown.Value = p.Stock;
            }

        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_mode == ProductFormEnumMode.Add)
            {
                Product newProduct = new Product();

                newProduct.Name = textbox.Text;
                newProduct.Category = (ProductCategoreyEnum)CategorycomboBox.SelectedItem;
                newProduct.Status = (ProductStatusEnum)statusbox.SelectedItem;
                newProduct.Price = priceUpDown.Value;
                newProduct.Stock = (int)StockUpDown.Value;

                Product temp = _service.Add(newProduct);
                IDtextBox.Text = temp?.ID ?? "";

            }
            else if (_mode == ProductFormEnumMode.Edit)
            {
                _product.Name = textbox.Text;
                _product.Category = (ProductCategoreyEnum)CategorycomboBox.SelectedItem;
                _product.Status = (ProductStatusEnum)statusbox.SelectedItem;
                _product.Price = priceUpDown.Value;
                _product.Stock = (int)StockUpDown.Value;

                bool isUpdated = _service.Update(_product);
            }
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}