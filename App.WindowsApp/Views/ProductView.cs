using System;
using System.Windows.Forms;
using App.Core.Utilities;
using App.Core.Contracts;
using App.WindowsApp.Views;
using App.Core.Models;
using System.Drawing.Text;

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
            var categoires =new List<object> { "---All---"};
            categoires.AddRange(Enum.GetValues(typeof(ProductCategoreyEnum)).Cast<object>());
            CmbCategory.DataSource = categoires;
            CmbCategory.SelectedIndex = 0;


            cmbStock.Items.Clear();
            var stockStatuses = new List<object> { "---All---" };
            stockStatuses.AddRange(Enum.GetValues(typeof(ProductStatusEnum)).Cast<object>());
            cmbStock.DataSource = stockStatuses;
            cmbStock.SelectedIndex = 0;

            if (_service == null)
                return;
            _dgvBindingSource.DataSource = _service.GetAll();

        }

        //private void LblSearch_TextChanged(object sender, EventArgs e)
        //{
        //}

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ProductForm prodForm = new ProductForm(Forms.ProductFormEnumMode.Add, null, _service);
            prodForm.ShowDialog();
            RefreshGrid();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)

        {
            Product? Selectedproducts = _dgvBindingSource.Current as Product;
            if (Selectedproducts != null)
            {
                ProductForm prodForm = new ProductForm(Forms.ProductFormEnumMode.Edit, Selectedproducts, _service);
                prodForm.ShowDialog();
                RefreshGrid();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Product? Selectedproducts = _dgvBindingSource.Current as Product;
            if (Selectedproducts != null)
            {
                ProductForm prodForm = new ProductForm(Forms.ProductFormEnumMode.View, Selectedproducts, _service);
                prodForm.ShowDialog();
                RefreshGrid();
            }

        }
        private void RefreshGrid()
        {

            string SearchText = LblSearch.Text;
            ProductCategoreyEnum? SelectedCategory = null;
            if (CmbCategory.SelectedItem != null)
            {
                if (CmbCategory.SelectedItem.ToString().Equals ("---All---"))
                {
                    SelectedCategory = null;
                }
                else
                {
                    SelectedCategory =  (ProductCategoreyEnum)CmbCategory.SelectedItem;
                }
            }

            ProductStatusEnum? SelectedStatus = null;
            if (cmbStock.SelectedItem != null)
            {
                if (cmbStock.SelectedItem.ToString().Equals("---All---"))
                {
                    SelectedStatus = null;
                }
                else
                {
                    SelectedStatus = (ProductStatusEnum)cmbStock.SelectedItem;
                }
            }


            _dgvBindingSource.DataSource = _service.Search(SearchText, SelectedCategory, SelectedStatus); 

            
        }

        private void LblSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }
        
        private void CmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid(); 
        }

       
        private void cmbStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();  
        }
    }
}