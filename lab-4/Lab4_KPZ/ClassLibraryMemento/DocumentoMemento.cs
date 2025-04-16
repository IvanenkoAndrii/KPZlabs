using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMemento
{
    public class DocumentMemento
    {
        public string SavedContent { get; }
        public DateTime SavedDate { get; }

        public DocumentMemento(string content)
        {
            SavedContent = content;
            SavedDate = DateTime.Now;
        }
    }
}
