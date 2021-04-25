using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Sticker_Generator
{
    public partial class ColorPickerForm : MaterialForm
    {
        Graphics g;
        public Color Color;
        public ColorPickerForm(Color color)
        {
            InitializeComponent();
            colorPanel.BackgroundImage = new Bitmap(colorPanel.Width, colorPanel.Height);
            g = Graphics.FromImage(colorPanel.BackgroundImage);
            alphaTrackBar.Value = color.A;
            redTrackBar.Value = color.R;
            greenTrackBar.Value = color.G;
            blueTrackBar.Value = color.B;
            Color = color;
        }

        private void ColorPickerForm_Shown(object sender, EventArgs e)
        {
            alphaTextBox.Text = alphaTrackBar.Value.ToString();
            redTextBox.Text = redTrackBar.Value.ToString();
            greenTextBox.Text = greenTrackBar.Value.ToString();
            blueTextBox.Text = blueTrackBar.Value.ToString();
            RefreshColorPanel();
        }

        private void RefreshColorPanel()
        {
            g.Clear(Color.FromArgb(242, 242, 242));
            Rectangle bounds = new Rectangle(new Point(0, 0), new Size(colorPanel.Size.Width - 6, colorPanel.Size.Height - 6));
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(12 * alphaTrackBar.Value/255, 0, 0, 0)))
            {
                g.FillEllipse(shadowBrush, new Rectangle(bounds.X - 2, bounds.Y - 1, bounds.Width + 4, bounds.Height + 6));
                g.FillEllipse(shadowBrush, new Rectangle(bounds.X - 1, bounds.Y - 1, bounds.Width + 2, bounds.Height + 4));
                g.FillEllipse(shadowBrush, new Rectangle(bounds.X - 0, bounds.Y - 0, bounds.Width + 0, bounds.Height + 2));
                g.FillEllipse(shadowBrush, new Rectangle(bounds.X - 0, bounds.Y + 2, bounds.Width + 0, bounds.Height + 0));
                g.FillEllipse(shadowBrush, new Rectangle(bounds.X - 0, bounds.Y + 1, bounds.Width + 0, bounds.Height + 0));
            }
            g.FillEllipse(new SolidBrush(Color), 1, 1, colorPanel.Size.Width - 8, colorPanel.Size.Height - 8);
            colorPanel.Invalidate();
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            alphaTextBox.Text = alphaTrackBar.Value.ToString();
            redTextBox.Text = redTrackBar.Value.ToString();
            greenTextBox.Text = greenTrackBar.Value.ToString();
            blueTextBox.Text = blueTrackBar.Value.ToString();
            Color = Color.FromArgb(alphaTrackBar.Value, redTrackBar.Value, greenTrackBar.Value, blueTrackBar.Value);
            RefreshColorPanel();
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            Color = Color.FromArgb(alphaTrackBar.Value, redTrackBar.Value, greenTrackBar.Value, blueTrackBar.Value);
            RefreshColorPanel();
        }

        private void alphaTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (alphaTextBox.Text == "")
                {
                    alphaTextBox.Text = "0";
                }
                alphaTrackBar.Value = int.Parse(alphaTextBox.Text);
            }
            catch (Exception)
            {
                alphaTextBox.Text = alphaTrackBar.Value.ToString();
            }
        }

        private void redTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (redTextBox.Text == "")
                {
                    redTextBox.Text = "0";
                }
                redTrackBar.Value = int.Parse(redTextBox.Text);
            }
            catch (Exception)
            {
                redTextBox.Text = redTrackBar.Value.ToString();
            }
        }

        private void greenTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (greenTextBox.Text == "")
                {
                    greenTextBox.Text = "0";
                }
                greenTrackBar.Value = int.Parse(greenTextBox.Text);
            }
            catch (Exception)
            {
                greenTextBox.Text = greenTrackBar.Value.ToString();
            }
        }

        private void blueTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (blueTextBox.Text == "")
                {
                    blueTextBox.Text = "0";
                }
                blueTrackBar.Value = int.Parse(blueTextBox.Text);
            }
            catch (Exception)
            {
                blueTextBox.Text = blueTrackBar.Value.ToString();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
