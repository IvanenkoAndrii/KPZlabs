using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryComposite
{
    public class EventListener
    {
        public string EventType { get; }
        public Action<LightNode> Handler { get; }

        public EventListener(string eventType, Action<LightNode> handler)
        {
            EventType = eventType;
            Handler = handler;
        }
    }
}
