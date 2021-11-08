using Problem2_BusinessRulesEngine.Services;
using System;

namespace Problem2_BusinessRulesEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            //For this porblem I thought a classic strategy pattern would be a good fit.
            //So I built and interface and the classes implementing them, and then
            //in the OrdersHandler I'm going to be putting the code that implement the class
            //according to the proper business rule.
            //The only clarification I want to make is that these 2 actions
            //•	If the payment is for a membership or upgrade, e - mail the owner and inform them of the activation / upgrade.
            //•	If the payment is for a physical product or a book, generate a commission payment to the agent.
            //Are going to be combined with this 4
            //•	If the payment is for a physical product, generate a packing slip for shipping.
            //•	If the payment is for a book, create a duplicate packing slip for the royalty department.
            //•	If the payment is for a membership, activate that membership.
            //•	If the payment is an upgrade to a membership, apply the upgrade.


            var OrdersHandler = new OrdersHandler("Book");
            OrdersHandler.ApplyBusinessRules();


        }
    }
}
