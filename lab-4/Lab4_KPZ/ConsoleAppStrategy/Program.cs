using System;
using System.Text;
using ClassLibraryStrategy;

namespace ConsoleAppStrategy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string localImagePath = @"D:\TechPrakt2025Task0\lab-4\Lab4_KPZ\ClassLibraryStrategy\images.jpg";
            Image image = new Image(new FileImageLoadingStrategy());
            image.Load(localImagePath);

            string imageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT0yCDb1IS_eXChHzefhpoDg7MTg1cOT7_scA&s";
            image.SetLoadingStrategy(new UrlImageLoadingStrategy());
            image.Load(imageUrl);
        }
    }
}
