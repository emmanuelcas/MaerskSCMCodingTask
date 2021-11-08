using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1_PromotionEngine.Model
{
    class Cart
    {
        public Cart(List<ItemForCart> ItemsList, double Subtotal, double Total)
        {
            this.ItemsList = ItemsList;
            this.Subtotal = Subtotal;
            this.Total = Total;
        }

        public List<ItemForCart> ItemsList { get; set; }

        public double Subtotal { get; set; }

        public double Total { get; set; }
    }
}
