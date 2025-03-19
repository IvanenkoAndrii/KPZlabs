using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZLab2.Factory_method
{
    public class EducationalSubscription : Subscription
    {
        public EducationalSubscription() : base(
            monthlyFee: 5.99m,
            minimumPeriod: 3,
            channels: new List<string> { "Education Channel", "Science Channel" },
            features: new List<string> { "Документальні", "Освітні програми" }
        )
        { }
    }
}
