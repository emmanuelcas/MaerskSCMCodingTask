using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1_PromotionEngine.Model
{
    public class Promotion
    {
        public Promotion(List<ProductRule> productsRequeried, double? discount, double? price)
        {
            ProductsRequeried = productsRequeried;
            Discount = discount;
            FixedTotal = price;
        }

        public List<ProductRule> ProductsRequeried { get; set; }

        public double? Discount { get; set; }

        public double? FixedTotal { get; set; }
    }
}


