using System;
using System.Drawing;
using System.IO;

namespace ClassLibraryStrategy
{
    public class FileImageLoadingStrategy : IImageLoadingStrategy
    {
        public void LoadImage(string href)
        {
            if (File.Exists(href))
            {
                Console.WriteLine($"Зображення завантажено з файлової системи: {href}");
            }
            else
            {
                Console.WriteLine("Файл не знайдений.");
            }
        }
    }
}
