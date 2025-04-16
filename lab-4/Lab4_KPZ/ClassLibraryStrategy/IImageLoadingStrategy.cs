using System;
using System.IO;
using System.Net;

namespace ClassLibraryStrategy
{
    public interface IImageLoadingStrategy
    {
        void LoadImage(string href);
    }
}
