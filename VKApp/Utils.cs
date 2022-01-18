using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace VKApp
{
    internal static class Utils
    {
        public static BitmapImage GetBitmapFromURL(Uri url)
        {
            if (url == null) return null;

            BitmapImage image = new();
            image.BeginInit();
            image.UriSource = url;
            image.EndInit();

            return image;
        }
    }
}
