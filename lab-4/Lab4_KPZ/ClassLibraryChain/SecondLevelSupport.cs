using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryChain
{
    class SecondLevelSupport : SupportHandler
    {
        public override bool HandleRequest(int level)
        {
            if (level == 2)
            {
                Console.WriteLine("Другий рівень підтримки: Проблеми з інтернетом або мережею");
                Console.WriteLine("Фахівець з технічної підтримки вам допоможе.");
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