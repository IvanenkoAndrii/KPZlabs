using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZLab2.Factory_method
{
    public class PremiumSubscription : Subscription
    {
        public PremiumSubscription() : base(
            monthlyFee: 19.99m,
            minimumPeriod: 1,
            channels: new List<string> { "Premium Channel 1", "Premium Channel 2", "Exclusive Channel" },
            features: new List<string> { "4K", "Multi-screen", "Без реклами" }
        )
        { }
    }
}
