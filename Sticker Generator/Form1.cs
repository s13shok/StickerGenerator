using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Sticker_Generator
{
    public partial class Form1 : Form
    {
        Graphics g;
        PointF[] hex;
        int width;
        int height;
        int coef;
        public Form1()
        {
            InitializeComponent();
            coef = 5;
            height = pictureBox1.Height * coef;
            width = pictureBox1.Width * coef;
            var bitmap = new Bitmap(width, height);
            pictureBox1.Image = bitmap;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; 
            g = Graphics.FromImage(bitmap);
            panel1.BackColor = Color.Black;
            panel2.BackColor = Color.Azure;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            panel1.BackColor = colorDialog1.Color;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            panel2.BackColor = colorDialog1.Color;
            g.FillRectangle(new SolidBrush(panel2.BackColor), 0, 0, width, height);
        }

        public static string CreateMD5(string input, out byte[] hashBytes)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.FillRectangle(new SolidBrush(panel2.BackColor), 0, 0, width, height);
            var bytes = new byte[0];
            label1.Text = CreateMD5(textBox1.Text, out bytes);
            BitArray bits = new BitArray(bytes);
            var sb = new StringBuilder(300);
            for (int i = 0; i < bits.Count; i++)
            {
                if (i % 16 == 0)
                {
                    sb.Append("\n");
                }
                if (bits[i])
                {
                    sb.Append(1 + " ");
                }
                else
                {
                    sb.Append(0 + " ");
                }
            }
            label2.Text = sb.ToString();
            var x_0 = (float)(width / 2.0);
            var y_0 = (float)(height / 2.0);

            DrawHexagon(x_0, y_0, Color.White, 120*coef, 0, bits[0]);
            for (int i = 0; i < 6; i++)
            {
                ChooseFig(hex[i].X, hex[i].Y, panel1.BackColor, 15*coef, bits[i + 14], bits[i + 20], bits[i + 26]);
                DrawHexagon(hex[i].X, hex[i].Y, panel1.BackColor, 60*coef, 30, bits[i + 1]);
                DrawInnerLines(hex[i].X, hex[i].Y, panel1.BackColor, 50*coef, 30, bits[i + 7], i % 2 != 0);
            }
            DrawInnerLines(x_0, y_0, panel1.BackColor, 50*coef, 30, bits[12], true);
            DrawHexagon(x_0, y_0, panel1.BackColor, 60*coef, 30, bits[13]);
            ChooseFig(x_0, y_0, panel1.BackColor, 15*coef, bits[32], bits[33], bits[34]);
            pictureBox1.Invalidate();
        }
        public void DrawInnerLines(float x_0, float y_0, Color color, int r, int offset, bool dash, bool off)
        {
            var shape = new PointF[6];
            var angle = new float[] { 30, 90, 150, 210, 270, 330 };
            for (int a = 0; a < 6; a++)
            {
                shape[a] = new PointF((float)x_0 + r * (float)Math.Cos((angle[a] + offset) * Math.PI / 180f),
                                      (float)y_0 + r * (float)Math.Sin((angle[a] + offset) * Math.PI / 180f));
            }
            var pen = new Pen(color, 3*coef);
            if (!dash)
            {
                pen.DashStyle = DashStyle.Dash;
                pen.StartCap = pen.EndCap = LineCap.Flat;
            }
            if (off)
            {
                g.DrawLine(pen, shape[1], shape[2]);
                g.DrawLine(pen, shape[3], shape[4]);
                g.DrawLine(pen, shape[5], shape[0]);
            }
            else
            {
                g.DrawLine(pen, shape[0], shape[1]);
                g.DrawLine(pen, shape[2], shape[3]);
                g.DrawLine(pen, shape[4], shape[5]);
            }
        }
        public void DrawHexagon(float x_0, float y_0, Color color, int r, int offset, bool dash)
        {
            var shape = new PointF[6];
            var angle = new float[] { 30, 90, 150, 210, 270, 330 };
            for (int a = 0; a < 6; a++)
            {
                shape[a] = new PointF((float)x_0 + r * (float)Math.Cos((angle[a] + offset) * Math.PI / 180f),
                                      (float)y_0 + r * (float)Math.Sin((angle[a] + offset) * Math.PI / 180f));
            }
            var pen = new Pen(color, 3*coef);
            if (!dash)
            {
                pen.DashStyle = DashStyle.Dash;
                pen.StartCap = pen.EndCap = LineCap.NoAnchor;
                for (int i = 0; i < 6; i++)
                {
                    if (i != 5)
                    {
                        g.DrawLine(pen, shape[i], shape[i + 1]);
                    }
                    else
                    {
                        g.DrawLine(pen, shape[5], shape[0]);
                    }
                }
            }
            else
            {
                g.DrawPolygon(pen, shape);
            }


            if (hex != null)
                return;
            hex = new PointF[6];
            Array.Copy(shape, hex, shape.Length);

        }
        public void DrawSquare(float x_0, float y_0, Color color, int r, int offset)
        {
            var shape = new PointF[4];
            var angle = new float[] { 90, 180, 270, 360 };
            for (int a = 0; a < 4; a++)
            {
                shape[a] = new PointF((float)x_0 + r * (float)Math.Cos((angle[a] + offset) * Math.PI / 180f),
                                      (float)y_0 + r * (float)Math.Sin((angle[a] + offset) * Math.PI / 180f));
            }
            var pen = new Pen(color, 3*coef);
            g.FillPolygon(new SolidBrush(color), shape);
        }
        public void DrawTriangle(float x_0, float y_0, Color color, int r, int offset)
        {
            var shape = new PointF[3];
            var angle = new float[] { 30, 150, 270 };
            for (int a = 0; a < 3; a++)
            {
                shape[a] = new PointF((float)x_0 + r * (float)Math.Cos((angle[a] + offset) * Math.PI / 180f),
                                      (float)y_0 + r * (float)Math.Sin((angle[a] + offset) * Math.PI / 180f));
            }
            var pen = new Pen(color, 3*coef);
            g.FillPolygon(new SolidBrush(color), shape);
        }
        public void DrawPlus(float x_0, float y_0, Color color, int r, int offset)
        {
            var shape = new PointF[4];
            var angle = new float[] { 90, 180, 270, 360 };
            for (int a = 0; a < 4; a++)
            {
                shape[a] = new PointF((float)x_0 + r * (float)Math.Cos((angle[a] + offset) * Math.PI / 180f),
                                      (float)y_0 + r * (float)Math.Sin((angle[a] + offset) * Math.PI / 180f));
            }
            var pen = new Pen(color, 3*coef);
            g.DrawLine(pen, shape[0], shape[2]);
            g.DrawLine(pen, shape[1], shape[3]);
        }
        public void DrawEqual(float x_0, float y_0, Color color, int r, int offset)
        {
            var shape = new PointF[4];
            var angle = new float[] { 90, 180, 270, 360 };
            for (int a = 0; a < 4; a++)
            {
                shape[a] = new PointF((float)x_0 + r * (float)Math.Cos((angle[a] + offset) * Math.PI / 180f),
                                      (float)y_0 + r * (float)Math.Sin((angle[a] + offset) * Math.PI / 180f));
            }
            var pen = new Pen(color, 3*coef);
            g.DrawLine(pen, shape[0], shape[3]);
            g.DrawLine(pen, shape[1], shape[2]);
        }
        public void DrawMinus(float x_0, float y_0, Color color, int r, int offset)
        {
            var shape = new PointF[2];
            var angle = new float[] { 0, 180 };
            for (int a = 0; a < 2; a++)
            {
                shape[a] = new PointF((float)x_0 + r * (float)Math.Cos((angle[a] + offset) * Math.PI / 180f),
                                      (float)y_0 + r * (float)Math.Sin((angle[a] + offset) * Math.PI / 180f));
            }
            var pen = new Pen(color, 3*coef);
            g.DrawLine(pen, shape[0], shape[1]);
        }
        public void ChooseFig(float x_0, float y_0, Color color, int r, bool first, bool second, bool third)
        {
            if (!first && !second && !third) //000
            {
                DrawPlus(x_0, y_0, panel1.BackColor, 15*coef, 45);
            }
            else if (!first && !second && third) //001
            {
                DrawMinus(x_0, y_0, panel1.BackColor, 15*coef, 0);
            }
            else if (!first && second && !third) //010
            {
                DrawEqual(x_0, y_0, panel1.BackColor, 15*coef, 45);
            }
            else if (!first && second && third) //011
            {
                DrawEqual(x_0, y_0, panel1.BackColor, 15*coef, 135);
                DrawMinus(x_0, y_0, panel1.BackColor, 15*coef, 90);
            }
            else if (first && !second && !third) //100
            {
                DrawPlus(x_0, y_0, panel1.BackColor, 15*coef, 0);
            }
            else if (first && !second && third)  //101
            {
                DrawTriangle(x_0, y_0, panel1.BackColor, 15*coef, 0);
            }
            else if (first && second && !third)  //110
            {
                DrawSquare(x_0, y_0, panel1.BackColor, 15*coef, 45);
            }
            else if (first && second && third)   //111
            {
                DrawHexagon(x_0, y_0, panel1.BackColor, 15*coef, 30, true);
            }

        }

        void SaveImage(object sender, EventArgs e)
        {
            
            if (pictureBox1.Image != null) 
            {
                var image = pictureBox1.Image;
                MessageBox.Show($"{image.Size}");
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как...";
                savedialog.OverwritePrompt = true;
                savedialog.CheckPathExists = true;
                savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                savedialog.ShowHelp = true;
                if (savedialog.ShowDialog() == DialogResult.OK) 
                {
                    try
                    {
                        pictureBox1.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}
