using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Models
{
    public class Product
    {
   public string ID { get; set; }
        public string Name { get; set; }
      
            public ProductCategoreyEnum  Category  { get; set; }
    public int Stock { get; set; }
    public decimal Price { get; set; }
    public ProductStatusEnum Status { get; set; }
}
}
