using System;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace ClassLibraryStrategy
{
    public class Image
    {
        private IImageLoadingStrategy _loadingStrategy;

        public Image(IImageLoadingStrategy loadingStrategy)
        {
            _loadingStrategy = loadingStrategy;
        }

        public void SetLoadingStrategy(IImageLoadingStrategy loadingStrategy)
        {
            _loadingStrategy = loadingStrategy;
        }

        public void Load(string href)
        {
            _loadingStrategy.LoadImage(href);
        }
    }
}
