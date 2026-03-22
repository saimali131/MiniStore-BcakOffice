using System;
using System.Windows.Forms;
using App.Core.Utilities;
using App.Core.Contracts;
using App.WindowsApp.Views;
using App.Core.Models;

namespace App.WindowsApp.Views
{
    public partial class ProductView : UserControl
    {
        IProductService _service;
        BindingSource _dgvBindingSource = new BindingSource();

        public ProductView(IProductService _serv)
        {
            _service = _serv;
            InitializeComponent();
            dataGridViewproducts.DataSource = _dgvBindingSource;
            _dgvBindingSource.DataSource = _service.GetAll();
        }

        private void ProductView_Load(object sender, EventArgs e)
        {
            CmbCategory.Items.Clear();
            CmbCategory.Items.Add("---All---");
            CmbCategory.Items.AddRange(Enum.GetNames(typeof(ProductCategoreyEnum)));
            CmbCategory.SelectedIndex = 0;
            cmbStock.Items.Clear();
            cmbStock.Items.Add("---All----");
            cmbStock.Items.AddRange(Enum.GetNames(typeof(ProductStatusEnum)));
            cmbStock.SelectedIndex = 0;
        }

        //private void LblSearch_TextChanged(object sender, EventArgs e)
        //{
        //}

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ProductForm prodForm = new ProductForm(Forms.ProductFormEnumMode.Add, null);
            prodForm.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)

        {
            Product? Selectedproducts = _dgvBindingSource.Current as Product;
            if (Selectedproducts != null)
            {
                ProductForm prodForm = new ProductForm(Forms.ProductFormEnumMode.Edit, Selectedproducts);
                prodForm.ShowDialog();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Product? Selectedproducts = _dgvBindingSource.Current as Product;
            if (Selectedproducts != null)
            {
                ProductForm prodForm = new ProductForm(Forms.ProductFormEnumMode.View, Selectedproducts);
                prodForm.ShowDialog();
            }
        }
    }
}