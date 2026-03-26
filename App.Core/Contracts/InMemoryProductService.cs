using App.core.Services;
using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace App.core.Services
{
    public class InMemoryProductService : IProductService
    {

        private List<Product> _products;
        public InMemoryProductService()
        {
            _products = new List<Product>();
            GenerateFakeProducts();
        }
        public Product Add(Product product)
        {
            if (product != null)
            {
                product.ID = GenerateId();
                _products.Add(product);
            }
            return product;
        }
        public bool Update(Product product)
        {
            if (product != null)
            {
                Product? existingProduct = _products.Find(p => p.ID == product.ID);
                if (existingProduct == null) return false;

                existingProduct.Name = product.Name;
                existingProduct.Category = product.Category;
                existingProduct.Price = product.Price;
                existingProduct.Stock = product.Stock;
                existingProduct.Status = product.Status;

                return true;
            }
            return false;
        }
        public bool Delete(string id)
        {
            Product productToDelete = GetById(id);
            _products.Remove(productToDelete);
            return true;
        }

        public Product GetById(string id)

        {
            Product? IDProduct = _products.Find(p => p.ID == id);
            return IDProduct;
        }

        public List<Product> GetAll()
        {
            return _products.OrderBy(p => p.Name).ToList();
        }

        public List<Product> Search(string text, ProductCategoreyEnum? Categorey, ProductStatusEnum? Status)
        {
            List<Product> _filtered = _products.ToList();
            _filtered= _filtered.Where(p => p.Name.Contains(text) ).ToList();
                if (Status != null)
                {
                    _filtered = _filtered.Where(p => p.Status == Status).ToList();
            }

            if (Categorey != null)
            {
                _filtered = _filtered.Where(p => p.Category == Categorey).ToList();
            }
            return _filtered;
        }
        public void GenerateFakeProducts()
        {
            _products.Clear();
            _products.Add(new Product
            {
                ID = GenerateId(),
                Name = "Laptop",
                Category = ProductCategoreyEnum.Electronics,
                Price = 150000.00m,
                Stock = 10,
                Status = ProductStatusEnum.Active
            });

            _products.Add(new Product
            {
                ID = GenerateId(),
                Name = "USB-C Cable",
                Category = ProductCategoreyEnum.Electronics,
                Price = 1200m,
                Stock = 10,

            });
        }

        private string GenerateId()
        {
            // e.g., P-1A2B3C
            return "P-" + Guid.NewGuid().ToString("N").Substring(0, 6);
        }

    }
}