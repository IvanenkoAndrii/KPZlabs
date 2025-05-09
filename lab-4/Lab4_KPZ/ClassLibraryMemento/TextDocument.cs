﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMemento
{
    public class TextDocument
    {
        public string Content { get; set; }

        public TextDocument(string content = "")
        {
            Content = content;
        }

        public override string ToString()
        {
            return Content;
        }
    }

}
