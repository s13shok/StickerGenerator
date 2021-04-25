namespace Sticker_Generator
{
    partial class ColorPickerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorPickerForm));
            this.redTrackBar = new System.Windows.Forms.TrackBar();
            this.greenTrackBar = new System.Windows.Forms.TrackBar();
            this.blueTrackBar = new System.Windows.Forms.TrackBar();
            this.rLabel = new MaterialSkin.Controls.MaterialLabel();
            this.gLabel = new MaterialSkin.Controls.MaterialLabel();
            this.bLabel = new MaterialSkin.Controls.MaterialLabel();
            this.okButton = new MaterialSkin.Controls.MaterialButton();
            this.cancelButton = new MaterialSkin.Controls.MaterialButton();
            this.redTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.greenTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.blueTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.alphaTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.aLabel = new MaterialSkin.Controls.MaterialLabel();
            this.alphaTrackBar = new System.Windows.Forms.TrackBar();
            this.colorPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // redTrackBar
            // 
            this.redTrackBar.Location = new System.Drawing.Point(47, 334);
            this.redTrackBar.Maximum = 255;
            this.redTrackBar.Name = "redTrackBar";
            this.redTrackBar.Size = new System.Drawing.Size(203, 45);
            this.redTrackBar.TabIndex = 1;
            this.redTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.redTrackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            this.redTrackBar.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // greenTrackBar
            // 
            this.greenTrackBar.Location = new System.Drawing.Point(47, 385);
            this.greenTrackBar.Maximum = 255;
            this.greenTrackBar.Name = "greenTrackBar";
            this.greenTrackBar.Size = new System.Drawing.Size(203, 45);
            this.greenTrackBar.TabIndex = 2;
            this.greenTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.greenTrackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            this.greenTrackBar.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // blueTrackBar
            // 
            this.blueTrackBar.Location = new System.Drawing.Point(47, 441);
            this.blueTrackBar.Maximum = 255;
            this.blueTrackBar.Name = "blueTrackBar";
            this.blueTrackBar.Size = new System.Drawing.Size(203, 45);
            this.blueTrackBar.TabIndex = 3;
            this.blueTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.blueTrackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            this.blueTrackBar.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // rLabel
            // 
            this.rLabel.AutoSize = true;
            this.rLabel.Depth = 0;
            this.rLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.rLabel.Location = new System.Drawing.Point(30, 334);
            this.rLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.rLabel.Name = "rLabel";
            this.rLabel.Size = new System.Drawing.Size(11, 19);
            this.rLabel.TabIndex = 11;
            this.rLabel.Text = "R";
            // 
            // gLabel
            // 
            this.gLabel.AutoSize = true;
            this.gLabel.Depth = 0;
            this.gLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gLabel.Location = new System.Drawing.Point(30, 385);
            this.gLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.gLabel.Name = "gLabel";
            this.gLabel.Size = new System.Drawing.Size(12, 19);
            this.gLabel.TabIndex = 12;
            this.gLabel.Text = "G";
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Depth = 0;
            this.bLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bLabel.Location = new System.Drawing.Point(30, 441);
            this.bLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(11, 19);
            this.bLabel.TabIndex = 13;
            this.bLabel.Text = "B";
            // 
            // okButton
            // 
            this.okButton.AutoSize = false;
            this.okButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.okButton.Depth = 0;
            this.okButton.DrawShadows = true;
            this.okButton.HighEmphasis = true;
            this.okButton.Icon = null;
            this.okButton.Location = new System.Drawing.Point(188, 496);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.okButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(80, 36);
            this.okButton.TabIndex = 17;
            this.okButton.Text = "OK";
            this.okButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.okButton.UseAccentColor = false;
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = false;
            this.cancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelButton.Depth = 0;
            this.cancelButton.DrawShadows = true;
            this.cancelButton.HighEmphasis = true;
            this.cancelButton.Icon = null;
            this.cancelButton.Location = new System.Drawing.Point(88, 496);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 36);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Cacnel";
            this.cancelButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.cancelButton.UseAccentColor = false;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // redTextBox
            // 
            this.redTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.redTextBox.Depth = 0;
            this.redTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.redTextBox.Location = new System.Drawing.Point(256, 332);
            this.redTextBox.MaxLength = 3;
            this.redTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.redTextBox.Multiline = false;
            this.redTextBox.Name = "redTextBox";
            this.redTextBox.Size = new System.Drawing.Size(60, 36);
            this.redTextBox.TabIndex = 19;
            this.redTextBox.Text = "";
            this.redTextBox.UseTallSize = false;
            this.redTextBox.TextChanged += new System.EventHandler(this.redTextBox_TextChanged);
            // 
            // greenTextBox
            // 
            this.greenTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.greenTextBox.Depth = 0;
            this.greenTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.greenTextBox.Location = new System.Drawing.Point(256, 382);
            this.greenTextBox.MaxLength = 3;
            this.greenTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.greenTextBox.Multiline = false;
            this.greenTextBox.Name = "greenTextBox";
            this.greenTextBox.Size = new System.Drawing.Size(60, 36);
            this.greenTextBox.TabIndex = 20;
            this.greenTextBox.Text = "";
            this.greenTextBox.UseTallSize = false;
            this.greenTextBox.TextChanged += new System.EventHandler(this.greenTextBox_TextChanged);
            // 
            // blueTextBox
            // 
            this.blueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.blueTextBox.Depth = 0;
            this.blueTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.blueTextBox.Location = new System.Drawing.Point(256, 438);
            this.blueTextBox.MaxLength = 3;
            this.blueTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.blueTextBox.Multiline = false;
            this.blueTextBox.Name = "blueTextBox";
            this.blueTextBox.Size = new System.Drawing.Size(60, 36);
            this.blueTextBox.TabIndex = 21;
            this.blueTextBox.Text = "";
            this.blueTextBox.UseTallSize = false;
            this.blueTextBox.TextChanged += new System.EventHandler(this.blueTextBox_TextChanged);
            // 
            // alphaTextBox
            // 
            this.alphaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alphaTextBox.Depth = 0;
            this.alphaTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.alphaTextBox.Location = new System.Drawing.Point(256, 282);
            this.alphaTextBox.MaxLength = 3;
            this.alphaTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.alphaTextBox.Multiline = false;
            this.alphaTextBox.Name = "alphaTextBox";
            this.alphaTextBox.Size = new System.Drawing.Size(60, 36);
            this.alphaTextBox.TabIndex = 24;
            this.alphaTextBox.Text = "";
            this.alphaTextBox.UseTallSize = false;
            this.alphaTextBox.TextChanged += new System.EventHandler(this.alphaTextBox_TextChanged);
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Depth = 0;
            this.aLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.aLabel.Location = new System.Drawing.Point(30, 284);
            this.aLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(11, 19);
            this.aLabel.TabIndex = 23;
            this.aLabel.Text = "A";
            // 
            // alphaTrackBar
            // 
            this.alphaTrackBar.Location = new System.Drawing.Point(47, 284);
            this.alphaTrackBar.Maximum = 255;
            this.alphaTrackBar.Name = "alphaTrackBar";
            this.alphaTrackBar.Size = new System.Drawing.Size(203, 45);
            this.alphaTrackBar.TabIndex = 22;
            this.alphaTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.alphaTrackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            this.alphaTrackBar.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // colorPanel
            // 
            this.colorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.colorPanel.Location = new System.Drawing.Point(100, 111);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(150, 150);
            this.colorPanel.TabIndex = 0;
            this.colorPanel.TabStop = true;
            // 
            // ColorPickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 550);
            this.Controls.Add(this.alphaTextBox);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.alphaTrackBar);
            this.Controls.Add(this.blueTextBox);
            this.Controls.Add(this.greenTextBox);
            this.Controls.Add(this.redTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.gLabel);
            this.Controls.Add(this.rLabel);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.blueTrackBar);
            this.Controls.Add(this.greenTrackBar);
            this.Controls.Add(this.redTrackBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ColorPickerForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Color Picker";
            this.Shown += new System.EventHandler(this.ColorPickerForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar redTrackBar;
        private System.Windows.Forms.TrackBar greenTrackBar;
        private System.Windows.Forms.TrackBar blueTrackBar;
        private MaterialSkin.Controls.MaterialLabel rLabel;
        private MaterialSkin.Controls.MaterialLabel gLabel;
        private MaterialSkin.Controls.MaterialLabel bLabel;
        private MaterialSkin.Controls.MaterialButton okButton;
        private MaterialSkin.Controls.MaterialButton cancelButton;
        private MaterialSkin.Controls.MaterialTextBox redTextBox;
        private MaterialSkin.Controls.MaterialTextBox greenTextBox;
        private MaterialSkin.Controls.MaterialTextBox blueTextBox;
        private MaterialSkin.Controls.MaterialTextBox alphaTextBox;
        private MaterialSkin.Controls.MaterialLabel aLabel;
        private System.Windows.Forms.TrackBar alphaTrackBar;
        private System.Windows.Forms.Panel colorPanel;
    }
}