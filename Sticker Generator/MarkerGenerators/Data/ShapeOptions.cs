using System.Drawing;

namespace Sticker_Generator
{
    partial class ShapeOptions
    {
        public PointF Centre { get; set; }
        public Color Color { get; set; }
        public float Radius { get; set; }
        public int Rotation { get; set; }

        public ShapeOptions(float x, float y, Color color, float radius, int rotation)
        {
            Centre = new PointF(x, y);
            Color = color;
            Radius = radius;
            Rotation = rotation;
        }
    }
}