using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryChain
{
    abstract class SupportHandler
    {
        public SupportHandler nextHandler;

        public void SetNextHandler(SupportHandler handler)
        {
            this.nextHandler = handler;
        }

        public abstract bool HandleRequest(int level);
    }

}