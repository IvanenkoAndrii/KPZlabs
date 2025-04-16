using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryAgent
{
    public class Aircraft
    {
        public string Name { get; }
        private IMediator _mediator;

        public Aircraft(string name)
        {
            Name = name;
        }

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        public void Land()
        {
            if (_mediator != null)
            {
                _mediator.Notify(this, "Land");
            }
        }

        public void TakeOff()
        {
            if (_mediator != null)
            {
                _mediator.Notify(this, "TakeOff");
            }
        }
    }
}
