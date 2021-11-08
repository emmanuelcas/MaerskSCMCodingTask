using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1_PromotionEngine.Model
{
    public class ProductRule
    {
        public ProductRule(string sKU, int cuantity)
        {
            SKU = sKU;
            Cuantity = cuantity;
        }

        public string SKU { get; set; }

        public int Cuantity { get; set; }

    }
}
