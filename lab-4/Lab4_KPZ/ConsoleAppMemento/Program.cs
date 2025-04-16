using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryMemento;

namespace ConsoleAppMemento
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var editor = new TextEditor("Початковий текст. ");

            editor.AddText("Доданий текст. ");
            Console.WriteLine(editor.GetContent());

            editor.AddText("Ще трохи тексту. ");
            Console.WriteLine(editor.GetContent());

            editor.DeleteText(10);
            Console.WriteLine(editor.GetContent());

            editor.Undo();
            Console.WriteLine(editor.GetContent());

            editor.Undo();
            Console.WriteLine(editor.GetContent());

            editor.Undo();
            Console.WriteLine(editor.GetContent());
        }
    }
}
