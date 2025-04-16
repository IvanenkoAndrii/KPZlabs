using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryComposite
{
    public class LightTextNode : LightNode
    {
        public string Text { get; set; }

        public LightTextNode(string text)
        {
            Text = text;
        }

        public override string OuterHTML(string indent = "")
        {
            return $"{indent}{Text}";
        }

        public override string InnerHTML(string indent = "")
        {
            return $"{indent}{Text}";
        }
    }
}

