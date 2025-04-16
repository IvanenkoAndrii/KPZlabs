using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryAgent
{
    public interface IMediator
    {
        void Notify(Aircraft sender, string action);
    }

}
