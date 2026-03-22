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
            throw new NotImplementedException();
        }
        public bool Update(Product product)
        {
            return false;
        }
        public bool Delete(string id)
        {
            return false;
        }

        public Product GetById(string id)

        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products.OrderBy(p => p.Name).ToList();
        }

        public List<Product> Search(string text, ProductCategoreyEnum? Categorey, ProductStatusEnum? Status)
        {
            throw new NotImplementedException();
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