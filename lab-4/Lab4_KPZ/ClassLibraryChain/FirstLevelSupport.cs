using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryChain
{
    class FirstLevelSupport : SupportHandler
    {
        public override bool HandleRequest(int level)
        {
            if (level == 1)
            {
                Console.WriteLine("Перший рівень підтримки: Проблеми з рахунком або платежами");
                Console.WriteLine("Оператор підтримки першого рівня вам допоможе.");
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