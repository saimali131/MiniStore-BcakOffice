using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
namespace App.Core.Contracts
{
    public interface IProductService
    {
        public Product Add(Product product);
        public bool Update(Product product);
        public bool Delete(string ID);
        public Product GetById(string ID);
        public List<Product> GetAll();
        public List<Product> Search(string text, ProductCategoreyEnum? catogrey, ProductStatusEnum? status);
    }
}