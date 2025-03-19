using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZLab2.Factory_method
{
    public interface ISubscriptionPurchase
    {
        Subscription CreateSubscription(string subscriptionType);
    }
}
