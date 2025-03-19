using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZLab2.Factory_method
{
    public class DomesticSubscription : Subscription
    {
        public DomesticSubscription() : base(
            monthlyFee: 9.99m,
            minimumPeriod: 1,
            channels: new List<string> { "Channel A", "Channel B", "Channel C" },
            features: new List<string> { "HD", "Catch-up TV" }
        )
        { }
    }
}
