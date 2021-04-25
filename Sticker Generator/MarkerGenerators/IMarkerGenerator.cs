using System.Drawing;

namespace Sticker_Generator
{
    internal interface IMarkerGenerator
    {
        float Coefficient { get; set; }
        Color MainColor { get; set; }
        Color BackgroundColor { get; set; }
        int Tickness { get; set; }
        Graphics Graphics { get; set; }

        void Draw(bool[] bits, float centerX, float centerY);
    }
}