
namespace Sticker_Generator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.backgroundMainGrid = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.rightMainGrid = new System.Windows.Forms.TableLayoutPanel();
            this.panelForBackColor = new System.Windows.Forms.Panel();
            this.backColorLabel = new MaterialSkin.Controls.MaterialLabel();
            this.backColorButton = new System.Windows.Forms.Panel();
            this.panelForMainColor = new System.Windows.Forms.Panel();
            this.ticknessComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.mainColorLabel = new MaterialSkin.Controls.MaterialLabel();
            this.mainColorButton = new System.Windows.Forms.Panel();
            this.panelForButtons = new System.Windows.Forms.Panel();
            this.generateButton = new MaterialSkin.Controls.MaterialButton();
            this.saveButton = new MaterialSkin.Controls.MaterialButton();
            this.panelForResolution = new System.Windows.Forms.Panel();
            this.heightErrorPanel = new System.Windows.Forms.Panel();
            this.widthErrorPanel = new System.Windows.Forms.Panel();
            this.widthTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.xLabel = new MaterialSkin.Controls.MaterialLabel();
            this.heightTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.panelForHash = new System.Windows.Forms.Panel();
            this.iconShapes = new System.Windows.Forms.PictureBox();
            this.typeComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.panelForText = new System.Windows.Forms.Panel();
            this.multiLineTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.hashComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.backgroundMainGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.rightMainGrid.SuspendLayout();
            this.panelForBackColor.SuspendLayout();
            this.panelForMainColor.SuspendLayout();
            this.panelForButtons.SuspendLayout();
            this.panelForResolution.SuspendLayout();
            this.panelForHash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconShapes)).BeginInit();
            this.panelForText.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundMainGrid
            // 
            this.backgroundMainGrid.ColumnCount = 2;
            this.backgroundMainGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.backgroundMainGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.backgroundMainGrid.Controls.Add(this.pictureBox, 0, 0);
            this.backgroundMainGrid.Controls.Add(this.rightMainGrid, 1, 0);
            this.backgroundMainGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.backgroundMainGrid.Location = new System.Drawing.Point(3, 69);
            this.backgroundMainGrid.Name = "backgroundMainGrid";
            this.backgroundMainGrid.RowCount = 1;
            this.backgroundMainGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.backgroundMainGrid.Size = new System.Drawing.Size(954, 468);
            this.backgroundMainGrid.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(614, 462);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // rightMainGrid
            // 
            this.rightMainGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rightMainGrid.ColumnCount = 1;
            this.rightMainGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightMainGrid.Controls.Add(this.panelForBackColor, 0, 2);
            this.rightMainGrid.Controls.Add(this.panelForMainColor, 0, 1);
            this.rightMainGrid.Controls.Add(this.panelForButtons, 0, 5);
            this.rightMainGrid.Controls.Add(this.panelForResolution, 0, 3);
            this.rightMainGrid.Controls.Add(this.panelForHash, 0, 4);
            this.rightMainGrid.Controls.Add(this.panelForText, 0, 0);
            this.rightMainGrid.Location = new System.Drawing.Point(624, 3);
            this.rightMainGrid.Name = "rightMainGrid";
            this.rightMainGrid.RowCount = 6;
            this.rightMainGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.rightMainGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.rightMainGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.rightMainGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.rightMainGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightMainGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.rightMainGrid.Size = new System.Drawing.Size(326, 462);
            this.rightMainGrid.TabIndex = 1;
            // 
            // panelForBackColor
            // 
            this.panelForBackColor.Controls.Add(this.backColorLabel);
            this.panelForBackColor.Controls.Add(this.backColorButton);
            this.panelForBackColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForBackColor.Location = new System.Drawing.Point(3, 157);
            this.panelForBackColor.Name = "panelForBackColor";
            this.panelForBackColor.Size = new System.Drawing.Size(320, 71);
            this.panelForBackColor.TabIndex = 10;
            // 
            // backColorLabel
            // 
            this.backColorLabel.AutoSize = true;
            this.backColorLabel.Depth = 0;
            this.backColorLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.backColorLabel.Location = new System.Drawing.Point(70, 28);
            this.backColorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.backColorLabel.Name = "backColorLabel";
            this.backColorLabel.Size = new System.Drawing.Size(125, 19);
            this.backColorLabel.TabIndex = 8;
            this.backColorLabel.Text = "Background color";
            // 
            // backColorButton
            // 
            this.backColorButton.Location = new System.Drawing.Point(8, 12);
            this.backColorButton.Name = "backColorButton";
            this.backColorButton.Size = new System.Drawing.Size(45, 45);
            this.backColorButton.TabIndex = 7;
            this.backColorButton.Click += new System.EventHandler(this.backColorButton_Click);
            this.backColorButton.MouseEnter += new System.EventHandler(this.backColorButton_MouseEnter);
            this.backColorButton.MouseLeave += new System.EventHandler(this.backColorButton_MouseLeave);
            // 
            // panelForMainColor
            // 
            this.panelForMainColor.Controls.Add(this.ticknessComboBox);
            this.panelForMainColor.Controls.Add(this.mainColorLabel);
            this.panelForMainColor.Controls.Add(this.mainColorButton);
            this.panelForMainColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForMainColor.Location = new System.Drawing.Point(3, 80);
            this.panelForMainColor.Name = "panelForMainColor";
            this.panelForMainColor.Size = new System.Drawing.Size(320, 71);
            this.panelForMainColor.TabIndex = 11;
            // 
            // ticknessComboBox
            // 
            this.ticknessComboBox.AutoResize = false;
            this.ticknessComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ticknessComboBox.Depth = 0;
            this.ticknessComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ticknessComboBox.DropDownHeight = 174;
            this.ticknessComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ticknessComboBox.DropDownWidth = 121;
            this.ticknessComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ticknessComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ticknessComboBox.FormattingEnabled = true;
            this.ticknessComboBox.IntegralHeight = false;
            this.ticknessComboBox.ItemHeight = 43;
            this.ticknessComboBox.Items.AddRange(new object[] {
            "30dp",
            "40dp",
            "50dp",
            "60dp",
            "70dp",
            "80dp",
            "90dp"});
            this.ticknessComboBox.Location = new System.Drawing.Point(207, 8);
            this.ticknessComboBox.MaxDropDownItems = 4;
            this.ticknessComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ticknessComboBox.Name = "ticknessComboBox";
            this.ticknessComboBox.Size = new System.Drawing.Size(100, 49);
            this.ticknessComboBox.StartIndex = 0;
            this.ticknessComboBox.TabIndex = 10;
            this.ticknessComboBox.SelectedIndexChanged += new System.EventHandler(this.ticknessComboBox_SelectedIndexChanged);
            // 
            // mainColorLabel
            // 
            this.mainColorLabel.AutoSize = true;
            this.mainColorLabel.Depth = 0;
            this.mainColorLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mainColorLabel.Location = new System.Drawing.Point(70, 28);
            this.mainColorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainColorLabel.Name = "mainColorLabel";
            this.mainColorLabel.Size = new System.Drawing.Size(76, 19);
            this.mainColorLabel.TabIndex = 9;
            this.mainColorLabel.Text = "Main color";
            // 
            // mainColorButton
            // 
            this.mainColorButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mainColorButton.Location = new System.Drawing.Point(8, 12);
            this.mainColorButton.Name = "mainColorButton";
            this.mainColorButton.Size = new System.Drawing.Size(45, 45);
            this.mainColorButton.TabIndex = 6;
            this.mainColorButton.Click += new System.EventHandler(this.mainColorButton_Click);
            this.mainColorButton.MouseEnter += new System.EventHandler(this.mainColorButton_MouseEnter);
            this.mainColorButton.MouseLeave += new System.EventHandler(this.mainColorButton_MouseLeave);
            // 
            // panelForButtons
            // 
            this.panelForButtons.Controls.Add(this.generateButton);
            this.panelForButtons.Controls.Add(this.saveButton);
            this.panelForButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForButtons.Location = new System.Drawing.Point(3, 388);
            this.panelForButtons.Name = "panelForButtons";
            this.panelForButtons.Size = new System.Drawing.Size(320, 71);
            this.panelForButtons.TabIndex = 12;
            // 
            // generateButton
            // 
            this.generateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.generateButton.Depth = 0;
            this.generateButton.DrawShadows = true;
            this.generateButton.HighEmphasis = true;
            this.generateButton.Icon = null;
            this.generateButton.Location = new System.Drawing.Point(8, 19);
            this.generateButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.generateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(95, 36);
            this.generateButton.TabIndex = 4;
            this.generateButton.Text = "Generate";
            this.generateButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.generateButton.UseAccentColor = false;
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveButton.Depth = 0;
            this.saveButton.DrawShadows = true;
            this.saveButton.HighEmphasis = true;
            this.saveButton.Icon = null;
            this.saveButton.Location = new System.Drawing.Point(215, 19);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(92, 36);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save as...";
            this.saveButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveButton.UseAccentColor = false;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // panelForResolution
            // 
            this.panelForResolution.Controls.Add(this.heightErrorPanel);
            this.panelForResolution.Controls.Add(this.widthErrorPanel);
            this.panelForResolution.Controls.Add(this.widthTextBox);
            this.panelForResolution.Controls.Add(this.xLabel);
            this.panelForResolution.Controls.Add(this.heightTextBox);
            this.panelForResolution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForResolution.Location = new System.Drawing.Point(3, 234);
            this.panelForResolution.Name = "panelForResolution";
            this.panelForResolution.Size = new System.Drawing.Size(320, 71);
            this.panelForResolution.TabIndex = 13;
            // 
            // heightErrorPanel
            // 
            this.heightErrorPanel.BackColor = System.Drawing.Color.Red;
            this.heightErrorPanel.Location = new System.Drawing.Point(207, 54);
            this.heightErrorPanel.Name = "heightErrorPanel";
            this.heightErrorPanel.Size = new System.Drawing.Size(100, 3);
            this.heightErrorPanel.TabIndex = 15;
            this.heightErrorPanel.Visible = false;
            // 
            // widthErrorPanel
            // 
            this.widthErrorPanel.BackColor = System.Drawing.Color.Red;
            this.widthErrorPanel.Location = new System.Drawing.Point(8, 54);
            this.widthErrorPanel.Name = "widthErrorPanel";
            this.widthErrorPanel.Size = new System.Drawing.Size(100, 3);
            this.widthErrorPanel.TabIndex = 14;
            this.widthErrorPanel.Visible = false;
            // 
            // widthTextBox
            // 
            this.widthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.widthTextBox.Depth = 0;
            this.widthTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.widthTextBox.Hint = "Width";
            this.widthTextBox.Location = new System.Drawing.Point(8, 10);
            this.widthTextBox.MaxLength = 50;
            this.widthTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.widthTextBox.Multiline = false;
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 50);
            this.widthTextBox.TabIndex = 0;
            this.widthTextBox.Text = "";
            this.widthTextBox.TextChanged += new System.EventHandler(this.widthTextBox_TextChanged);
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Depth = 0;
            this.xLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.xLabel.Location = new System.Drawing.Point(150, 26);
            this.xLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(11, 19);
            this.xLabel.TabIndex = 2;
            this.xLabel.Text = "X";
            // 
            // heightTextBox
            // 
            this.heightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.heightTextBox.Depth = 0;
            this.heightTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.heightTextBox.Hint = "Height";
            this.heightTextBox.Location = new System.Drawing.Point(207, 10);
            this.heightTextBox.MaxLength = 50;
            this.heightTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.heightTextBox.Multiline = false;
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 50);
            this.heightTextBox.TabIndex = 1;
            this.heightTextBox.Text = "";
            this.heightTextBox.TextChanged += new System.EventHandler(this.heightTextBox_TextChanged);
            // 
            // panelForHash
            // 
            this.panelForHash.Controls.Add(this.iconShapes);
            this.panelForHash.Controls.Add(this.typeComboBox);
            this.panelForHash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForHash.Location = new System.Drawing.Point(3, 311);
            this.panelForHash.Name = "panelForHash";
            this.panelForHash.Size = new System.Drawing.Size(320, 71);
            this.panelForHash.TabIndex = 14;
            // 
            // iconShapes
            // 
            this.iconShapes.Image = ((System.Drawing.Image)(resources.GetObject("iconShapes.Image")));
            this.iconShapes.InitialImage = null;
            this.iconShapes.Location = new System.Drawing.Point(8, 4);
            this.iconShapes.Name = "iconShapes";
            this.iconShapes.Size = new System.Drawing.Size(64, 64);
            this.iconShapes.TabIndex = 2;
            this.iconShapes.TabStop = false;
            // 
            // typeComboBox
            // 
            this.typeComboBox.AutoResize = false;
            this.typeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.typeComboBox.Depth = 0;
            this.typeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.typeComboBox.DropDownHeight = 174;
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.DropDownWidth = 121;
            this.typeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.typeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.IntegralHeight = false;
            this.typeComboBox.ItemHeight = 43;
            this.typeComboBox.Items.AddRange(new object[] {
            "Hex",
            "Triangle"});
            this.typeComboBox.Location = new System.Drawing.Point(86, 10);
            this.typeComboBox.MaxDropDownItems = 4;
            this.typeComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(221, 49);
            this.typeComboBox.StartIndex = 0;
            this.typeComboBox.TabIndex = 1;
            // 
            // panelForText
            // 
            this.panelForText.Controls.Add(this.multiLineTextBox);
            this.panelForText.Controls.Add(this.hashComboBox);
            this.panelForText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForText.Location = new System.Drawing.Point(3, 3);
            this.panelForText.Name = "panelForText";
            this.panelForText.Size = new System.Drawing.Size(320, 71);
            this.panelForText.TabIndex = 15;
            // 
            // multiLineTextBox
            // 
            this.multiLineTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.multiLineTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.multiLineTextBox.Depth = 0;
            this.multiLineTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.multiLineTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.multiLineTextBox.Hint = "";
            this.multiLineTextBox.Location = new System.Drawing.Point(8, 10);
            this.multiLineTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.multiLineTextBox.Name = "multiLineTextBox";
            this.multiLineTextBox.Size = new System.Drawing.Size(153, 49);
            this.multiLineTextBox.TabIndex = 1;
            this.multiLineTextBox.Text = "";
            // 
            // hashComboBox
            // 
            this.hashComboBox.AutoResize = false;
            this.hashComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hashComboBox.Depth = 0;
            this.hashComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.hashComboBox.DropDownHeight = 174;
            this.hashComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hashComboBox.DropDownWidth = 121;
            this.hashComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.hashComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hashComboBox.FormattingEnabled = true;
            this.hashComboBox.IntegralHeight = false;
            this.hashComboBox.ItemHeight = 43;
            this.hashComboBox.Items.AddRange(new object[] {
            "MD5",
            "CRC64"});
            this.hashComboBox.Location = new System.Drawing.Point(207, 10);
            this.hashComboBox.MaxDropDownItems = 4;
            this.hashComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.hashComboBox.Name = "hashComboBox";
            this.hashComboBox.Size = new System.Drawing.Size(100, 49);
            this.hashComboBox.StartIndex = 0;
            this.hashComboBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.backgroundMainGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "MainForm";
            this.Text = "Sticker Generator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.backgroundMainGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.rightMainGrid.ResumeLayout(false);
            this.panelForBackColor.ResumeLayout(false);
            this.panelForBackColor.PerformLayout();
            this.panelForMainColor.ResumeLayout(false);
            this.panelForMainColor.PerformLayout();
            this.panelForButtons.ResumeLayout(false);
            this.panelForButtons.PerformLayout();
            this.panelForResolution.ResumeLayout(false);
            this.panelForResolution.PerformLayout();
            this.panelForHash.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconShapes)).EndInit();
            this.panelForText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel backgroundMainGrid;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TableLayoutPanel rightMainGrid;
        private System.Windows.Forms.Panel backColorButton;
        private System.Windows.Forms.Panel mainColorButton;
        private System.Windows.Forms.Panel panelForBackColor;
        private MaterialSkin.Controls.MaterialLabel backColorLabel;
        private System.Windows.Forms.Panel panelForMainColor;
        private MaterialSkin.Controls.MaterialLabel mainColorLabel;
        private System.Windows.Forms.Panel panelForResolution;
        private MaterialSkin.Controls.MaterialLabel xLabel;
        private MaterialSkin.Controls.MaterialTextBox heightTextBox;
        private MaterialSkin.Controls.MaterialTextBox widthTextBox;
        private System.Windows.Forms.Panel widthErrorPanel;
        private System.Windows.Forms.Panel heightErrorPanel;
        private System.Windows.Forms.Panel panelForButtons;
        private MaterialSkin.Controls.MaterialButton generateButton;
        private MaterialSkin.Controls.MaterialButton saveButton;
        private System.Windows.Forms.Panel panelForHash;
        private MaterialSkin.Controls.MaterialComboBox hashComboBox;
        private MaterialSkin.Controls.MaterialComboBox ticknessComboBox;
        private MaterialSkin.Controls.MaterialComboBox typeComboBox;
        private System.Windows.Forms.PictureBox iconShapes;
        private System.Windows.Forms.Panel panelForText;
        private MaterialSkin.Controls.MaterialMultiLineTextBox multiLineTextBox;
    }
}

