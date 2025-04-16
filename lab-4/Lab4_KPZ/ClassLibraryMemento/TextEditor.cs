using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMemento
{
    public class TextEditor
    {
        private TextDocument _document;
        private Stack<DocumentMemento> _history = new Stack<DocumentMemento>();

        public TextEditor(string initialContent = "")
        {
            _document = new TextDocument(initialContent);
        }

        public void AddText(string text)
        {
            SaveState();
            _document.Content += text;
        }

        public void DeleteText(int length)
        {
            if (length <= 0) return;

            SaveState();
            if (length >= _document.Content.Length)
            {
                _document.Content = string.Empty;
            }
            else
            {
                _document.Content = _document.Content.Substring(0, _document.Content.Length - length);
            }
        }

        public void SetText(string newText)
        {
            SaveState();
            _document.Content = newText;
        }

        private void SaveState()
        {
            _history.Push(new DocumentMemento(_document.Content));
        }

        public void Undo()
        {
            if (_history.Count > 0)
            {
                var memento = _history.Pop();
                _document.Content = memento.SavedContent;
                Console.WriteLine($"Відновлено стан від {memento.SavedDate}");
            }
            else
            {
                Console.WriteLine("Немає дій для скасування");
            }
        }

        public string GetContent()
        {
            return _document.ToString();
        }
    }
}
