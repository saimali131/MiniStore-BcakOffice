using App.Core.Models;
using App.Core.Utilities;
using App.WindowsApp.Forms;
using System;
using System.Windows.Forms;
namespace App.WindowsApp.Views
{
    public partial class ProductForm : Form
        
    {
        public ProductForm(ProductFormEnumMode mode  , Product? p)
            
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
        }
    }
}