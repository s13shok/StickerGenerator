using System;
using System.Drawing;

namespace Sticker_Generator
{
    interface IImageService
    {
        void Save(Image image, string name);
    }
}
