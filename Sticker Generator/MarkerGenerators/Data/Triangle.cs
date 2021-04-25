namespace Sticker_Generator
{
    partial class AlternativeMarkerGenerator
    {
        struct Triangle
        {
            public float X { get; set; }
            public float Y { get; set; }
            public bool Flipped { get; set; }

            public Triangle(float x, float y, bool flipped)
            {
                X = x;
                Y = y;
                Flipped = flipped;
            }
        }
    }
}
