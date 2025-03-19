using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZLab2.Factory_method
{
    public abstract class Subscription
    {
        public decimal MonthlyFee { get; set; }
        public int MinimumPeriod { get; set; }
        public List<string> Channels { get; set; }
        public List<string> Features { get; set; }

        public Subscription(decimal monthlyFee, int minimumPeriod, List<string> channels, List<string> features)
        {
            MonthlyFee = monthlyFee;
            MinimumPeriod = minimumPeriod;
            Channels = channels;
            Features = features;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Щомісячна плата: " + MonthlyFee);
            Console.WriteLine("Мінімальний період (місяців): " + MinimumPeriod);
            Console.WriteLine("Канали: " + string.Join(", ", Channels));
            Console.WriteLine("Додаткові можливості: " + string.Join(", ", Features));
        }
    }
}
