using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZLab2.Factory_method
{
    public class WebSite : ISubscriptionPurchase
    {
        public Subscription CreateSubscription(string subscriptionType)
        {
            Console.WriteLine("Придбання підписки через WebSite...");
            return GetSubscription(subscriptionType);
        }

        private Subscription GetSubscription(string subscriptionType)
        {
            switch (subscriptionType)
            {
                case "Domestic":
                    return new DomesticSubscription();
                case "Educational":
                    return new EducationalSubscription();
                case "Premium":
                    return new PremiumSubscription();
                default:
                    throw new Exception("Невідомий тип підписки");
            }
        }
    }
}
