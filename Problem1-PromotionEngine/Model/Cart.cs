using Problem1_PromotionEngine.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1_PromotionEngine.Model
{
    class Cart
    {
        public Cart(List<ItemForCart> ItemsList, double Subtotal)
        {
            this.ItemsList = ItemsList;
            this.Subtotal = Subtotal;
        }

        public List<ItemForCart> ItemsList { get; set; }

        public double Subtotal { get; set; }

        //public double Total { get; set; }

        public double GetTotal()
        {
            return PromotionsManager.GetTotal(ItemsList);
        }
    }
}
