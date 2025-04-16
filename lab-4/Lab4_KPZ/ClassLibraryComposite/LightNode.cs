using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryComposite
{
    public abstract class LightNode
    {
        public abstract string OuterHTML(string indent = "");
        public abstract string InnerHTML(string indent = "");
    }
}
