using System;
using System.Drawing;
using System.IO;
using System.Net;

namespace ClassLibraryStrategy
{
    public class UrlImageLoadingStrategy : IImageLoadingStrategy
    {
        public void LoadImage(string href)
        {
            try
            {
                WebClient client = new WebClient();
                byte[] imageData = client.DownloadData(href);
                Console.WriteLine($"Зображення завантажено з інтернету: {href}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка при завантаженні з інтернету: {ex.Message}");
            }
        }
    }
}

