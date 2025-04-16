using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryChain
{
    class ThirdLevelSupport : SupportHandler
    {
        public override bool HandleRequest(int level)
        {
            if (level == 3)
            {
                Console.WriteLine("Третій рівень підтримки: Проблеми з обладнанням");
                Console.WriteLine("Інженер з обладнання вам допоможе.");
                return true;
            }
            else if (nextHandler != null)
            {
                return nextHandler.HandleRequest(level);
            }
            return false;
        }
    }
}