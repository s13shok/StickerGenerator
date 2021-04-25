using System;
using System.Drawing;

namespace Sticker_Generator
{
    partial class AlternativeMarkerGenerator : IMarkerGenerator
    {
        public float Coefficient { get; set; }
        public Color MainColor { get; set; }
        public Color BackgroundColor { get; set; }
        public int Tickness { get; set; }
        public Graphics Graphics { get; set; }

        public AlternativeMarkerGenerator(Graphics g, float coef, int tickness, Color main, Color back)
        {
            Graphics = g;
            Coefficient = coef;
            Tickness = tickness;
            MainColor = main;
            BackgroundColor = back;
        }

        public void Draw(bool[] bits, float centerX, float centerY)
        {
            var trigons = CreateTriangleLayout(centerX, centerY, 200 * Coefficient, 0);
            Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            for (int i = 0; i < bits.Length; i++)
            {
                var flippedTriangle = new ShapeOptions(trigons[i + 1].X, trigons[i + 1].Y, MainColor, 29 * Coefficient, 180);
                var triangle = new ShapeOptions(trigons[i + 1].X, trigons[i + 1].Y, MainColor, 29 * Coefficient, 0);
                if (trigons[i + 1].Flipped)
                {
                    DrawTriangle(flippedTriangle, bits[i]);
                }
                else
                {
                    DrawTriangle(triangle, bits[i]);
                }
            }
            DrawTriangle(new ShapeOptions(trigons[0].X, trigons[0].Y, MainColor, 29 * Coefficient, 0), false);
            Graphics.DrawEllipse(new Pen(MainColor, Tickness * Coefficient),
                trigons[0].X - 10 * Coefficient, trigons[0].Y - 10 * Coefficient, 20 * Coefficient, 20 * Coefficient);
        }

        private Triangle[] CreateTriangleLayout(float x_0, float y_0, float r, int turn)
        {
            var triangle = new Triangle[36];
            triangle[0] = new Triangle((float)x_0 + r * (float)Math.Cos((270 + turn) * Math.PI / 180f),
                                  (float)y_0 + (60 * Coefficient) + r * (float)Math.Sin((270 + turn) * Math.PI / 180f), false);
            var h = 3 * r * Math.Cos(60 * Math.PI / 180f);
            var step = (float)(h / 18f);
            for (int i = 0; i < 5; i++)
            {
                var bias = triangle[i].Flipped ? 4 * step : 2 * step;
                triangle[i + 1] = new Triangle(triangle[i].X, triangle[i].Y + bias, !triangle[i].Flipped);
            }
            int lastIndex = 6;
            float offset = (6 - Tickness) * Coefficient;
            for (int i = 0; i < 5; i++)
            {
                triangle[lastIndex++] = new Triangle(triangle[i].X + 2 * step - offset, triangle[i].Y + 3 * step, triangle[i].Flipped);
                triangle[lastIndex++] = new Triangle(triangle[i].X - 2 * step + offset, triangle[i].Y + 3 * step, triangle[i].Flipped);
            }
            for (int i = 6; i < 32; i++)
            {
                if (i % 2 == 0)
                {
                    triangle[lastIndex++] = new Triangle(triangle[i].X + 2 * step - offset, triangle[i].Y + 3 * step, triangle[i].Flipped);
                }
                else
                {
                    triangle[lastIndex++] = new Triangle(triangle[i].X - 2 * step + offset, triangle[i].Y + 3 * step, triangle[i].Flipped);
                }
                if (i == 13 || i == 21 || i == 27)
                {
                    i += 2;
                }
            }
            return triangle;
        }

        private void DrawTriangle(ShapeOptions shape, bool filled)
        {
            var triangle = new PointF[3];
            var angle = new float[] { 30, 150, 270 };
            for (int i = 0; i < 3; i++)
            {
                triangle[i] = new PointF(shape.Centre.X + shape.Radius * (float)Math.Cos((angle[i] + shape.Rotation) * Math.PI / 180f),
                                      shape.Centre.Y + shape.Radius * (float)Math.Sin((angle[i] + shape.Rotation) * Math.PI / 180f));
            }
            var pen = new Pen(shape.Color, Tickness * Coefficient);
            if (filled)
            {
                Graphics.DrawPolygon(pen, triangle);
                Graphics.FillPolygon(new SolidBrush(pen.Color), triangle);
            }
            else
            {
                Graphics.DrawPolygon(pen, triangle);
            }
        }
    }
}