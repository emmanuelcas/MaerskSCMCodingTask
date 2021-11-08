using Problem1_PromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1_PromotionEngine.Services
{
    class APICall
    {

        public static List<Promotion> GetPromos()
        {
            //THIS METHOD WOULD CALL IN REAL LIFE AND ENDPOINT TO GET ALL THE PROMOTIONS
            //FROM THE SISTEM IN ORDER TO KEEP THE PROMOTION MANAGER UPDATED

            //SINCE I DON'T HAVE A EXISTING ENDPOINT, HERE I HAVE THE RESULT
            //OF THE METHOD HARDCODED

            var PromosList = new List<Promotion>();

            //adds this promotion: buy 'n' items of a SKU for a fixed price (3 A's for 130)
            var pl = new List<ProductRule>();
            pl.Add(new ProductRule("A", 3));
            PromosList.Add(new Promotion(pl, null, 130));

            //2 of B's for 45
            pl = new List<ProductRule>();
            pl.Add(new ProductRule("B", 2));
            PromosList.Add(new Promotion(pl, null, 45));

            //buy SKU 1 & SKU 2 for a fixed price ( C + D = 30 )
            pl = new List<ProductRule>();
            pl.Add(new ProductRule("C", 1));
            pl.Add(new ProductRule("D", 1));
            PromosList.Add(new Promotion(pl, null, 30));


            return PromosList;
        }
    }
}
