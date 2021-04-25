using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Sticker_Generator
{
    public partial class MainForm : MaterialForm
    {
        Graphics g;
        Graphics gMainButton;
        Graphics gBackButton;

        int width;
        int height;

        int tickness;
        float coefficient;


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            coefficient = 1;
            tickness = 3;
            height = (int)(pictureBox.Height * coefficient);
            width = (int)(pictureBox.Width * coefficient);

            pictureBox.Image = new Bitmap(width, height);
            g = Graphics.FromImage(pictureBox.Image);

            mainColorButton.BackgroundImage = new Bitmap(mainColorButton.Width, mainColorButton.Height); ;
            gMainButton = Graphics.FromImage(mainColorButton.BackgroundImage);

            backColorButton.BackgroundImage = new Bitmap(backColorButton.Width, backColorButton.Height); ;
            gBackButton = Graphics.FromImage(backColorButton.BackgroundImage);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            mainColorButton.ForeColor = Color.Black;
            backColorButton.ForeColor = Color.Azure;

            g.FillRectangle(new SolidBrush(backColorButton.ForeColor), 0, 0, width, height);

            mainColorButton_MouseLeave(null, e);
            backColorButton_MouseLeave(null, e);
            pictureBox.Invalidate();
        }

        private void mainColorButton_Click(object sender, EventArgs e)
        {
            ColorPickerForm colorPicker = new ColorPickerForm(mainColorButton.ForeColor);
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                mainColorButton.ForeColor = colorPicker.Color;
            }
            mainColorButton_MouseLeave(null, e);
        }

        private void backColorButton_Click(object sender, EventArgs e)
        {
            ColorPickerForm colorPicker = new ColorPickerForm(backColorButton.ForeColor);
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                g.Clear(Color.Transparent);
                backColorButton.ForeColor = colorPicker.Color;
                backColorButton_MouseLeave(null, e);
                g.FillRectangle(new SolidBrush(backColorButton.ForeColor), 0, 0, width, height);
                pictureBox.Invalidate();
            }
            backColorButton_MouseLeave(null, e);
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            g.Clear(backColorButton.ForeColor);

            bool[] bits;
            if (hashComboBox.SelectedIndex == 0)
            {
                bits = HashFunction.CreateMD5(multiLineTextBox.Text);
            }
            else
            {
                bits = HashFunction.CreateCRC64(multiLineTextBox.Text);
            }

            IMarkerGenerator mg;
            if (typeComboBox.SelectedIndex == 0)
            {
                mg = new MarkerGenerator(g, coefficient * 1.2f, tickness, mainColorButton.ForeColor, backColorButton.ForeColor);
            }
            else
            {
                mg = new AlternativeMarkerGenerator(g, coefficient * 1.2f, tickness, mainColorButton.ForeColor, backColorButton.ForeColor);
            }
            mg.Draw(bits, width / 2.0f, height / 2.0f);

            pictureBox.Invalidate();
        }

        void saveButton_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                var image = pictureBox.Image;
                var imageService = new ImageService();
                imageService.Save(image, multiLineTextBox.Text);
            }
        }

        private void mainColorButton_MouseEnter(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(new Point(0, 0), new Size(mainColorButton.Size.Width - 6, mainColorButton.Size.Height - 6));
            gMainButton.SmoothingMode = SmoothingMode.AntiAlias;
            DrawRoundShadow(gMainButton, rect, 12);
            gMainButton.FillEllipse(new SolidBrush(mainColorButton.ForeColor), 1, 1, mainColorButton.Size.Width - 8, mainColorButton.Size.Height - 8);
            mainColorButton.Invalidate();
        }

        private void mainColorButton_MouseLeave(object sender, EventArgs e)
        {
            gMainButton.Clear(Color.FromArgb(240, 240, 240));
            Rectangle rect = new Rectangle(new Point(0, 0), new Size(mainColorButton.Size.Width - 6, mainColorButton.Size.Height - 6));
            DrawRoundShadow(gMainButton, rect, 6);
            gMainButton.FillEllipse(new SolidBrush(mainColorButton.ForeColor), 1, 1, mainColorButton.Size.Width - 8, mainColorButton.Size.Height - 8);
            mainColorButton.Invalidate();
        }

        private void backColorButton_MouseEnter(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(new Point(0, 0), new Size(backColorButton.Size.Width - 6, backColorButton.Size.Height - 6));
            gBackButton.SmoothingMode = SmoothingMode.AntiAlias;
            DrawRoundShadow(gBackButton, rect, 12);
            gBackButton.FillEllipse(new SolidBrush(backColorButton.ForeColor), 1, 1, backColorButton.Size.Width - 8, backColorButton.Size.Height - 8);
            backColorButton.Invalidate();
        }

        private void backColorButton_MouseLeave(object sender, EventArgs e)
        {
            gBackButton.Clear(Color.FromArgb(240, 240, 240));
            Rectangle rect = new Rectangle(new Point(0, 0), new Size(backColorButton.Size.Width - 6, backColorButton.Size.Height - 6));
            DrawRoundShadow(gBackButton, rect, 6);
            gBackButton.FillEllipse(new SolidBrush(backColorButton.ForeColor), 1, 1, backColorButton.Size.Width - 8, backColorButton.Size.Height - 8);
            backColorButton.Invalidate();
        }

        static void DrawRoundShadow(Graphics g, Rectangle bounds, int shadow)
        {
            using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(shadow, 0, 0, 0)))
            {
                g.FillEllipse(shadowBrush, new Rectangle(bounds.X - 2, bounds.Y - 1, bounds.Width + 4, bounds.Height + 6));
                g.FillEllipse(shadowBrush, new Rectangle(bounds.X - 1, bounds.Y - 1, bounds.Width + 2, bounds.Height + 4));
                g.FillEllipse(shadowBrush, new Rectangle(bounds.X - 0, bounds.Y - 0, bounds.Width + 0, bounds.Height + 2));
                g.FillEllipse(shadowBrush, new Rectangle(bounds.X - 0, bounds.Y + 2, bounds.Width + 0, bounds.Height + 0));
                g.FillEllipse(shadowBrush, new Rectangle(bounds.X - 0, bounds.Y + 1, bounds.Width + 0, bounds.Height + 0));
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            backgroundMainGrid.Size = new Size(this.Size.Width, this.Size.Height - 70);
            pictureBox.Invalidate();
        }

        private void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var newWidth = int.Parse(widthTextBox.Text);
                if (newWidth < 500 || newWidth > 20000)
                {
                    widthErrorPanel.Visible = true;
                }
                else
                {
                    ChangeImage(newWidth, height);
                    widthErrorPanel.Visible = false;
                }
                this.width = newWidth;
            }
            catch (Exception)
            {
                widthErrorPanel.Visible = false;
                ChangeImage(width, height);
                widthTextBox.Text = width.ToString();
            }
        }

        private void heightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var newHeight = int.Parse(heightTextBox.Text);
                if (newHeight < 500 || newHeight > 20000)
                {
                    heightErrorPanel.Visible = true;
                }
                else
                {
                    heightErrorPanel.Visible = false;
                    ChangeImage(width, newHeight);
                }
                this.height = newHeight;
            }
            catch (Exception)
            {
                heightErrorPanel.Visible = false;
                ChangeImage(width, height);
                heightTextBox.Text = height.ToString();
            }
        }

        private void ChangeImage(int width, int height)
        {
            coefficient = height < width ? height / 460f : width / 600f;
            pictureBox.Image = new Bitmap(width, height);
            g = Graphics.FromImage(pictureBox.Image);

            g.FillRectangle(new SolidBrush(backColorButton.ForeColor), 0, 0, width, height);
            pictureBox.Invalidate();
        }

        private void ticknessComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tickness = ticknessComboBox.SelectedIndex + 3;
        }
    }
}
