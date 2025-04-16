using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryAgent
{
    public class CommandCentre : IMediator
    {
        private readonly List<Runway> _runways;
        private readonly List<Aircraft> _aircrafts;

        public CommandCentre(Runway[] runways, Aircraft[] aircrafts)
        {
            _runways = new List<Runway>(runways);
            _aircrafts = new List<Aircraft>(aircrafts);

            foreach (var aircraft in aircrafts)
            {
                aircraft.SetMediator(this);
            }
        }

        public void Notify(Aircraft sender, string action)
        {
            switch (action)
            {
                case "Land":
                    var freeRunway = _runways.FirstOrDefault(r => r.IsBusyWithAircraft is null);
                    if (freeRunway != null)
                    {
                        Console.WriteLine($"Aircraft {sender.Name} is landing on runway {freeRunway.Id}");
                        freeRunway.IsBusyWithAircraft = sender;
                        freeRunway.HighLightRed();
                    }
                    else
                    {
                        Console.WriteLine($"Could not land, all runways are busy.");
                    }
                    break;

                case "TakeOff":
                    var occupiedRunway = _runways.FirstOrDefault(r => r.IsBusyWithAircraft == sender);
                    if (occupiedRunway != null)
                    {
                        Console.WriteLine($"Aircraft {sender.Name} is taking off from runway {occupiedRunway.Id}");
                        occupiedRunway.IsBusyWithAircraft = null;
                        occupiedRunway.HighLightGreen();
                    }
                    break;
            }
        }
    }
}
