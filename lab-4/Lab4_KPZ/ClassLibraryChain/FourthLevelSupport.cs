using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryChain
{
    class FourthLevelSupport : SupportHandler
    {
        public override bool HandleRequest(int level)
        {
            if (level == 4)
            {
                Console.WriteLine("Четвертий рівень підтримки: Скарги та спеціальні запити");
                Console.WriteLine("Менеджер з роботи з клієнтами вам допоможе.");
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