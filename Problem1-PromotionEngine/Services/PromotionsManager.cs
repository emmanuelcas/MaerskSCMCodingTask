using Problem1_PromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1_PromotionEngine.Services
{
    public static class PromotionsManager
    {
        public static List<Promotion> PromosList { get; set; }
        public static DateTime LastUpdate { get; set; }

        static PromotionsManager()
        {
            PromosList = APICall.GetPromos();
            LastUpdate = DateTime.Now;

        }


        public static double GetTotal(List<ItemForCart> ProductList)
        {
            CheckTimeForPromoUpdates();

            double Total = 0;
            foreach (Promotion Promo in PromosList)
            {
                var PromoSubtotal = ProccessPromo(Promo, ProductList);
                while (PromoSubtotal != 0)
                {
                    Total = Total + PromoSubtotal;
                    PromoSubtotal = ProccessPromo(Promo, ProductList);
                }
            }

            foreach (ItemForCart item in ProductList)
            {
                Total = Total + (item.Cuantity * item.Price);
            }

            return Total;
        }


        public static Double ProccessPromo(Promotion Promo, List<ItemForCart> ProductList)
        {
            double PromoSubtotal = 0;
            foreach (ProductRule Rule in Promo.ProductsRequeried)
            {
                var Item = ProductList.Find(x => x.SKU == Rule.SKU);
                if ((Item == null) || (Item.Cuantity < Rule.Cuantity))
                {
                    return 0;
                }
                else
                {
                    PromoSubtotal = Rule.Cuantity * Item.Price;
                }
            }

            foreach (ProductRule Rule in Promo.ProductsRequeried)
            {
                var Item = ProductList.Find(x => x.SKU == Rule.SKU);
                Item.Cuantity = Item.Cuantity - Rule.Cuantity;
            }

            if (Promo.Discount == null)
                return Promo.FixedTotal.Value;
            else
                //THIS IS IN CASE THERE ARE PROMTIONS WITH % DISCOUNT
                return Promo.Discount.Value * PromoSubtotal;
        }

        public static void CheckTimeForPromoUpdates()
        {
            if (DateTime.Now.Subtract(LastUpdate).Minutes > 30)
            {
                PromosList = APICall.GetPromos();
                LastUpdate = DateTime.Now;
            }

        }

    }
}
