using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryAgent;

namespace ConsoleAppAgent
{
    public class Program
    {
        static void Main(string[] args)
        {
            var runway1 = new Runway();
            var runway2 = new Runway();
            var aircraft1 = new Aircraft("Boeing 737");
            var aircraft2 = new Aircraft("Airbus A320");

            var commandCentre = new CommandCentre(
                new[] { runway1, runway2 },
                new[] { aircraft1, aircraft2 });

            aircraft1.Land();
            aircraft2.Land();
            aircraft1.TakeOff();
            aircraft2.TakeOff();

            Console.ReadKey();
        }
    }
}
