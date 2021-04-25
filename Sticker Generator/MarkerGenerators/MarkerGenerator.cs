using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Sticker_Generator
{
    partial class MarkerGenerator : IMarkerGenerator
    {
        public float Coefficient { get; set; }
        public Color MainColor { get; set; }
        public Color BackgroundColor { get; set; }
        public int Tickness { get; set; }
        public Graphics Graphics { get; set; }

        public MarkerGenerator(Graphics g, float coef, int tickness, Color main, Color back)
        {
            Graphics = g;
            Coefficient = coef;
            Tickness = tickness;
            MainColor = main;
            BackgroundColor = back;
        }

        public void Draw(bool[] bits, float centreX, float centreY)
        {
            Graphics.SmoothingMode = SmoothingMode.HighQuality;
            var hexLayout = CreateHexLayout(centreX, centreY, 120 * Coefficient, 0);
            for (int i = 0; i < 7; i++)
            {
                var hex = new ShapeOptions(hexLayout[i].X, hexLayout[i].Y, MainColor, 60 * Coefficient, 30);
                var value = new OctalNumber(bits[i + 14], bits[i + 21], bits[i + 28]).Value;
                var innerLines = new ShapeOptions(hexLayout[i].X, hexLayout[i].Y, MainColor, 50 * Coefficient, 30);
                ChooseFigure(hexLayout[i].X, hexLayout[i].Y, value);
                DrawHexagon(hex, bits[i]);
                DrawInnerLines(innerLines, bits[i + 7], i % 2 != 0);
            }
        }

        private PointF[] CreateHexLayout(float x_0, float y_0, float r, int turn)
        {
            var hex = new PointF[7];
            var angle = new float[] { 30, 90, 150, 210, 270, 330 };
            for (int i = 0; i < 6; i++)
            {
                hex[i] = new PointF((float)x_0 + r * (float)Math.Cos((angle[i] + turn) * Math.PI / 180f),
                                        (float)y_0 + r * (float)Math.Sin((angle[i] + turn) * Math.PI / 180f));
            }
            hex[6] = new PointF(x_0, y_0);
            return hex;
        }

        private void DrawInnerLines(ShapeOptions shape, bool dash, bool rotate)
        {
            var figure = new PointF[6];
            var angle = new float[] { 30, 90, 150, 210, 270, 330 };
            for (int i = 0; i < 6; i++)
            {
                figure[i] = new PointF(shape.Centre.X + shape.Radius * (float)Math.Cos((angle[i] + shape.Rotation) * Math.PI / 180f),
                                      shape.Centre.Y + shape.Radius * (float)Math.Sin((angle[i] + shape.Rotation) * Math.PI / 180f));
            }
            var pen = new Pen(shape.Color, Tickness * Coefficient);
            if (!dash)
            {
                pen.DashStyle = DashStyle.Dash;
                pen.StartCap = pen.EndCap = LineCap.Flat;
            }
            if (rotate)
            {
                Graphics.DrawLine(pen, figure[1], figure[2]);
                Graphics.DrawLine(pen, figure[3], figure[4]);
                Graphics.DrawLine(pen, figure[5], figure[0]);
            }
            else
            {
                Graphics.DrawLine(pen, figure[0], figure[1]);
                Graphics.DrawLine(pen, figure[2], figure[3]);
                Graphics.DrawLine(pen, figure[4], figure[5]);
            }
        }

        private void DrawHexagon(ShapeOptions shape, bool dash)
        {
            var figure = new PointF[6];
            var angle = new float[] { 30, 90, 150, 210, 270, 330 };
            for (int i = 0; i < 6; i++)
            {
                figure[i] = new PointF(shape.Centre.X + shape.Radius * (float)Math.Cos((angle[i] + shape.Rotation) * Math.PI / 180f),
                                      shape.Centre.Y + shape.Radius * (float)Math.Sin((angle[i] + shape.Rotation) * Math.PI / 180f));
            }
            var pen = new Pen(shape.Color, Tickness * Coefficient);
            if (!dash)
            {
                pen.DashStyle = DashStyle.Dash;
                pen.StartCap = pen.EndCap = LineCap.NoAnchor;
                for (int i = 0; i < 6; i++)
                {
                    if (i != 5)
                    {
                        Graphics.DrawLine(pen, figure[i], figure[i + 1]);
                    }
                    else
                    {
                        Graphics.DrawLine(pen, figure[5], figure[0]);
                    }
                }
            }
            else
            {
                Graphics.DrawPolygon(pen, figure);
            }
        }

        private void DrawSquare(ShapeOptions shape)
        {
            var figure = new PointF[4];
            var angle = new float[] { 90, 180, 270, 360 };
            for (int i = 0; i < 4; i++)
            {
                figure[i] = new PointF(shape.Centre.X + shape.Radius * (float)Math.Cos((angle[i] + shape.Rotation) * Math.PI / 180f),
                                      shape.Centre.Y + shape.Radius * (float)Math.Sin((angle[i] + shape.Rotation) * Math.PI / 180f));
            }
            var pen = new Pen(shape.Color, Tickness * Coefficient);
            Graphics.DrawPolygon(pen, figure);
        }

        private void DrawTriangle(ShapeOptions shape)
        {
            var figure = new PointF[3];
            var angle = new float[] { 30, 150, 270 };
            for (int i = 0; i < 3; i++)
            {
                figure[i] = new PointF(shape.Centre.X + shape.Radius * (float)Math.Cos((angle[i] + shape.Rotation) * Math.PI / 180f),
                                      shape.Centre.Y + shape.Radius * (float)Math.Sin((angle[i] + shape.Rotation) * Math.PI / 180f));
            }
            var pen = new Pen(shape.Color, Tickness * Coefficient);
            Graphics.DrawPolygon(pen, figure);
        }

        private void DrawPlus(ShapeOptions shape)
        {
            var figure = new PointF[4];
            var angle = new float[] { 90, 180, 270, 360 };
            for (int i = 0; i < 4; i++)
            {
                figure[i] = new PointF(shape.Centre.X + shape.Radius * (float)Math.Cos((angle[i] + shape.Rotation) * Math.PI / 180f),
                                      shape.Centre.Y + shape.Radius * (float)Math.Sin((angle[i] + shape.Rotation) * Math.PI / 180f));
            }
            var pen = new Pen(shape.Color, Tickness * Coefficient);
            Graphics.DrawLine(pen, figure[0], figure[2]);
            Graphics.DrawLine(pen, figure[1], figure[3]);
        }

        private void DrawEqual(ShapeOptions shape)
        {
            var figure = new PointF[4];
            var angle = new float[] { 90, 180, 270, 360 };
            for (int i = 0; i < 4; i++)
            {
                figure[i] = new PointF(shape.Centre.X + shape.Radius * (float)Math.Cos((angle[i] + shape.Rotation) * Math.PI / 180f),
                                      shape.Centre.Y + shape.Radius * (float)Math.Sin((angle[i] + shape.Rotation) * Math.PI / 180f));
            }
            var pen = new Pen(shape.Color, Tickness * Coefficient);
            Graphics.DrawLine(pen, figure[0], figure[3]);
            Graphics.DrawLine(pen, figure[1], figure[2]);
        }

        private void DrawMinus(ShapeOptions shape)
        {
            var figure = new PointF[2];
            var angle = new float[] { 0, 180 };
            for (int i = 0; i < 2; i++)
            {
                figure[i] = new PointF(shape.Centre.X + shape.Radius * (float)Math.Cos((angle[i] + shape.Rotation) * Math.PI / 180f),
                                      shape.Centre.Y + shape.Radius * (float)Math.Sin((angle[i] + shape.Rotation) * Math.PI / 180f));
            }
            var pen = new Pen(shape.Color, Tickness * Coefficient);
            Graphics.DrawLine(pen, figure[0], figure[1]);
        }

        private void ChooseFigure(float x_0, float y_0, int value)
        {
            var crossOrEqual = new ShapeOptions(x_0, y_0, MainColor, 15 * Coefficient, 45);
            var plusMinusOrTriangle = new ShapeOptions(x_0, y_0, MainColor, 15 * Coefficient, 0);
            var square = new ShapeOptions(x_0, y_0, MainColor, 15 * Coefficient, 45);
            var hex = new ShapeOptions(x_0, y_0, MainColor, 15 * Coefficient, 30);
            var threeLines = new ShapeOptions(x_0, y_0, MainColor, 15 * Coefficient, 135);
            switch (value)
            {
                case 0:
                    DrawPlus(crossOrEqual);
                    break;
                case 1:
                    DrawMinus(plusMinusOrTriangle);
                    break;
                case 2:
                    DrawEqual(crossOrEqual);
                    break;
                case 3:
                    DrawEqual(threeLines);
                    threeLines.Rotation = 90;
                    DrawMinus(threeLines);
                    break;
                case 4:
                    DrawPlus(plusMinusOrTriangle);
                    break;
                case 5:
                    DrawTriangle(plusMinusOrTriangle);
                    break;
                case 6:
                    DrawSquare(square);
                    break;
                case 7:
                    DrawHexagon(hex, true);
                    break;
            }
        }
    }
}