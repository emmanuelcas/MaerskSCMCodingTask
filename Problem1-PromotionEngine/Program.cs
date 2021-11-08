using Problem1_PromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Problem1_PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {

            //This excercise cuould fit into a pattern like the strategy pattern
            //However, since the promotion engine should be modular to allow for 
            //more promotion types to be added at a later date (e.g. a future promotion
            //could be x% of a SKU unit price), I dicided on a less theorical and more
            //real life approach, where I would have a list of the promotions that is going
            //to be updated from an API or a DB each 30 min with the last promotions
            //The promotion manager then in GetTotal method checks if there are any suiitable
            //promotions to apply according to items in the cart, applies them and calculates
            //total. I also added a field for a discount that is going to be taken into account
            //only if the fixed price is empty
            //I chose this approch because a more theorical strategy approach in real life would
            //mean re deploying, this is an approach that enables sales dep to create promos
            //and have it already working in the system in 30 minutes or less
            //I know that some conditions can break the code in the unit test (negative numbers, bigger
            //than int range, etc).This scenearios were considered but the code doesn't contemplate
            //them because of the time




            //Here I leave this to display in the console

            var ItemsList = new List<ItemForCart>();
            ItemsList.Add(new ItemForCart("A", 50, 1));
            ItemsList.Add(new ItemForCart("B", 30, 1));
            ItemsList.Add(new ItemForCart("C", 20, 1));
            var Cart = new Cart(ItemsList);
            Console.WriteLine("");
            Console.WriteLine("SCENARIO A");
            PrintCart(Cart);
            Console.WriteLine("TOTAL " + Cart.GetTotal());

            ItemsList = new List<ItemForCart>();
            ItemsList.Add(new ItemForCart("A", 50, 5));
            ItemsList.Add(new ItemForCart("B", 30, 5));
            ItemsList.Add(new ItemForCart("C", 20, 1));
            Console.WriteLine("");
            Console.WriteLine("SCENARIO B");
            Cart = new Cart(ItemsList);
            PrintCart(Cart);
            Console.WriteLine("TOTAL " + Cart.GetTotal());

            ItemsList = new List<ItemForCart>();
            ItemsList.Add(new ItemForCart("A", 50, 3));
            ItemsList.Add(new ItemForCart("B", 30, 5));
            ItemsList.Add(new ItemForCart("C", 20, 1));
            ItemsList.Add(new ItemForCart("D", 15, 1));
            Cart = new Cart(ItemsList);
            Console.WriteLine("");
            Console.WriteLine("SCENARIO C");
            PrintCart(Cart);
            Console.WriteLine("TOTAL " + Cart.GetTotal());
        }

        static void PrintCart(Cart Cart)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            foreach (ItemForCart item in Cart.ItemsList)
            {
                Console.WriteLine(item.Cuantity + " * " + item.SKU + "   " + item.Price);
            }
            Console.WriteLine("============");
            Console.WriteLine("SUBTOTAL " + Cart.GetSubTotal());
        }
    }
}
