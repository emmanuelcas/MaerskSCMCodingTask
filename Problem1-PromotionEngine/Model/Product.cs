using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1_PromotionEngine.Model
{
    class Product
    {
        public Product(string sKU, double price)
        {
            SKU = sKU;
            Price = price;
        }

        public string SKU { get; set; }

        public double Price { get; set; }

    }
}
