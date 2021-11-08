using Problem1_PromotionEngine.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1_PromotionEngine.Model
{
    public class Cart
    {
        public Cart(List<ItemForCart> ItemsList)
        {
            this.ItemsList = ItemsList;
        }

        public List<ItemForCart> ItemsList { get; set; }

        public double GetTotal()
        {
            return PromotionsManager.GetTotal(ItemsList);
        }

        public double GetSubTotal()
        {
            double subtotal = 0;
            foreach (ItemForCart item in ItemsList)
            {
                subtotal = subtotal + (item.Cuantity * item.Price);
            }
            return subtotal;
        }
    }
}
