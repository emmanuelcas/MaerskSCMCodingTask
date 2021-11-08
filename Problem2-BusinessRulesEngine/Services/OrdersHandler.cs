using Problem2_BusinessRulesEngine.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2_BusinessRulesEngine.Services
{
    public class OrdersHandler
    {
        private IBusinessRules strategy;



        public OrdersHandler(string type)
        {
            switch (type)
            {
                case "PhysicalProduct":
                    this.strategy = new PhysicalProductProcess();
                    break;
                case "Book":
                    this.strategy = new BookProcess();
                    break;
                case "Membership":
                    this.strategy = new ActivateMembershipProcess();
                    break;
                case "MembershipUpgrade":
                    this.strategy = new UpgradeMembershipProcess();
                    break;
                case "LearningToSki":
                    this.strategy = new LearningToSkiProcess();
                    break;
                default:
                    // code block
                    break;
            }

        }

        public void ApplyBusinessRules()
        {
            this.strategy.ApplyBusinessRules();
        }

    }
}
