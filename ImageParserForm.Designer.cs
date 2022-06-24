namespace ImageParser
{
    partial class ImageParserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageParserForm));
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.minImageSizeLabel = new System.Windows.Forms.Label();
            this.maxImageSizeLabel = new System.Windows.Forms.Label();
            this.minImageSizeYLabel = new System.Windows.Forms.Label();
            this.maxImageSizeYLabel = new System.Windows.Forms.Label();
            this.minImageSizeXLabel = new System.Windows.Forms.Label();
            this.maxImageSizeXLabel = new System.Windows.Forms.Label();
            this.filtersLabel = new System.Windows.Forms.Label();
            this.URLLabel = new System.Windows.Forms.Label();
            this.URLtextBox = new System.Windows.Forms.TextBox();
            this.savePathButton = new System.Windows.Forms.Button();
            this.savePathLabel = new System.Windows.Forms.Label();
            this.savePathTextBox = new System.Windows.Forms.TextBox();
            this.imageFoundGroupBox = new System.Windows.Forms.GroupBox();
            this.imageFound = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.startButton = new System.Windows.Forms.Button();
            this.maxImageXUpDown = new System.Windows.Forms.NumericUpDown();
            this.minImageXUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxImageYUpDown = new System.Windows.Forms.NumericUpDown();
            this.minImageYUpDown = new System.Windows.Forms.NumericUpDown();
            this.settingsGroupBox.SuspendLayout();
            this.imageFoundGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageFound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxImageXUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minImageXUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxImageYUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minImageYUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Controls.Add(this.minImageYUpDown);
            this.settingsGroupBox.Controls.Add(this.maxImageYUpDown);
            this.settingsGroupBox.Controls.Add(this.minImageXUpDown);
            this.settingsGroupBox.Controls.Add(this.maxImageXUpDown);
            this.settingsGroupBox.Controls.Add(this.minImageSizeLabel);
            this.settingsGroupBox.Controls.Add(this.maxImageSizeLabel);
            this.settingsGroupBox.Controls.Add(this.minImageSizeYLabel);
            this.settingsGroupBox.Controls.Add(this.maxImageSizeYLabel);
            this.settingsGroupBox.Controls.Add(this.minImageSizeXLabel);
            this.settingsGroupBox.Controls.Add(this.maxImageSizeXLabel);
            this.settingsGroupBox.Controls.Add(this.filtersLabel);
            this.settingsGroupBox.Controls.Add(this.URLLabel);
            this.settingsGroupBox.Controls.Add(this.URLtextBox);
            this.settingsGroupBox.Controls.Add(this.savePathButton);
            this.settingsGroupBox.Controls.Add(this.savePathLabel);
            this.settingsGroupBox.Controls.Add(this.savePathTextBox);
            this.settingsGroupBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.settingsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(310, 255);
            this.settingsGroupBox.TabIndex = 0;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Settings";
            // 
            // minImageSizeLabel
            // 
            this.minImageSizeLabel.AutoSize = true;
            this.minImageSizeLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.minImageSizeLabel.Location = new System.Drawing.Point(6, 215);
            this.minImageSizeLabel.Name = "minImageSizeLabel";
            this.minImageSizeLabel.Size = new System.Drawing.Size(116, 21);
            this.minImageSizeLabel.TabIndex = 15;
            this.minImageSizeLabel.Text = "Min Image Size";
            this.minImageSizeLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // maxImageSizeLabel
            // 
            this.maxImageSizeLabel.AutoSize = true;
            this.maxImageSizeLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.maxImageSizeLabel.Location = new System.Drawing.Point(6, 188);
            this.maxImageSizeLabel.Name = "maxImageSizeLabel";
            this.maxImageSizeLabel.Size = new System.Drawing.Size(118, 21);
            this.maxImageSizeLabel.TabIndex = 14;
            this.maxImageSizeLabel.Text = "Max Image Size";
            this.maxImageSizeLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // minImageSizeYLabel
            // 
            this.minImageSizeYLabel.AutoSize = true;
            this.minImageSizeYLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.minImageSizeYLabel.Location = new System.Drawing.Point(220, 215);
            this.minImageSizeYLabel.Name = "minImageSizeYLabel";
            this.minImageSizeYLabel.Size = new System.Drawing.Size(22, 21);
            this.minImageSizeYLabel.TabIndex = 13;
            this.minImageSizeYLabel.Text = "y:";
            this.minImageSizeYLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // maxImageSizeYLabel
            // 
            this.maxImageSizeYLabel.AutoSize = true;
            this.maxImageSizeYLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.maxImageSizeYLabel.Location = new System.Drawing.Point(220, 187);
            this.maxImageSizeYLabel.Name = "maxImageSizeYLabel";
            this.maxImageSizeYLabel.Size = new System.Drawing.Size(22, 21);
            this.maxImageSizeYLabel.TabIndex = 12;
            this.maxImageSizeYLabel.Text = "y:";
            this.maxImageSizeYLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // minImageSizeXLabel
            // 
            this.minImageSizeXLabel.AutoSize = true;
            this.minImageSizeXLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.minImageSizeXLabel.Location = new System.Drawing.Point(126, 215);
            this.minImageSizeXLabel.Name = "minImageSizeXLabel";
            this.minImageSizeXLabel.Size = new System.Drawing.Size(22, 21);
            this.minImageSizeXLabel.TabIndex = 11;
            this.minImageSizeXLabel.Text = "x:";
            this.minImageSizeXLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // maxImageSizeXLabel
            // 
            this.maxImageSizeXLabel.AutoSize = true;
            this.maxImageSizeXLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.maxImageSizeXLabel.Location = new System.Drawing.Point(126, 188);
            this.maxImageSizeXLabel.Name = "maxImageSizeXLabel";
            this.maxImageSizeXLabel.Size = new System.Drawing.Size(22, 21);
            this.maxImageSizeXLabel.TabIndex = 10;
            this.maxImageSizeXLabel.Text = "x:";
            this.maxImageSizeXLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // filtersLabel
            // 
            this.filtersLabel.AutoSize = true;
            this.filtersLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.filtersLabel.Location = new System.Drawing.Point(6, 162);
            this.filtersLabel.Name = "filtersLabel";
            this.filtersLabel.Size = new System.Drawing.Size(54, 21);
            this.filtersLabel.TabIndex = 7;
            this.filtersLabel.Text = "Filters";
            this.filtersLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // URLLabel
            // 
            this.URLLabel.AutoSize = true;
            this.URLLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.URLLabel.Location = new System.Drawing.Point(6, 40);
            this.URLLabel.Name = "URLLabel";
            this.URLLabel.Size = new System.Drawing.Size(39, 21);
            this.URLLabel.TabIndex = 4;
            this.URLLabel.Text = "URL";
            this.URLLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // URLtextBox
            // 
            this.URLtextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.URLtextBox.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.URLtextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.URLtextBox.Location = new System.Drawing.Point(6, 64);
            this.URLtextBox.Name = "URLtextBox";
            this.URLtextBox.Size = new System.Drawing.Size(298, 29);
            this.URLtextBox.TabIndex = 3;
            this.URLtextBox.Text = " type url here...";
            // 
            // savePathButton
            // 
            this.savePathButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.savePathButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.savePathButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.savePathButton.Location = new System.Drawing.Point(275, 124);
            this.savePathButton.Name = "savePathButton";
            this.savePathButton.Size = new System.Drawing.Size(29, 29);
            this.savePathButton.TabIndex = 2;
            this.savePathButton.Text = "...";
            this.savePathButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.savePathButton.UseVisualStyleBackColor = false;
            // 
            // savePathLabel
            // 
            this.savePathLabel.AutoSize = true;
            this.savePathLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.savePathLabel.Location = new System.Drawing.Point(6, 100);
            this.savePathLabel.Name = "savePathLabel";
            this.savePathLabel.Size = new System.Drawing.Size(80, 21);
            this.savePathLabel.TabIndex = 1;
            this.savePathLabel.Text = "Save Path";
            this.savePathLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // savePathTextBox
            // 
            this.savePathTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.savePathTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.savePathTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.savePathTextBox.Location = new System.Drawing.Point(6, 124);
            this.savePathTextBox.Name = "savePathTextBox";
            this.savePathTextBox.Size = new System.Drawing.Size(262, 29);
            this.savePathTextBox.TabIndex = 0;
            this.savePathTextBox.Text = " choose the destination folder...";
            // 
            // imageFoundGroupBox
            // 
            this.imageFoundGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imageFoundGroupBox.Controls.Add(this.imageFound);
            this.imageFoundGroupBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.imageFoundGroupBox.Location = new System.Drawing.Point(12, 274);
            this.imageFoundGroupBox.Name = "imageFoundGroupBox";
            this.imageFoundGroupBox.Size = new System.Drawing.Size(310, 202);
            this.imageFoundGroupBox.TabIndex = 5;
            this.imageFoundGroupBox.TabStop = false;
            this.imageFoundGroupBox.Text = "Image Found";
            // 
            // imageFound
            // 
            this.imageFound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imageFound.Image = ((System.Drawing.Image)(resources.GetObject("imageFound.Image")));
            this.imageFound.InitialImage = ((System.Drawing.Image)(resources.GetObject("imageFound.InitialImage")));
            this.imageFound.Location = new System.Drawing.Point(6, 32);
            this.imageFound.Name = "imageFound";
            this.imageFound.Size = new System.Drawing.Size(298, 164);
            this.imageFound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageFound.TabIndex = 0;
            this.imageFound.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.progressBar.Location = new System.Drawing.Point(-6, 533);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(347, 15);
            this.progressBar.TabIndex = 1;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(-6, 481);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(347, 50);
            this.startButton.TabIndex = 2;
            this.startButton.TabStop = false;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // maxImageXUpDown
            // 
            this.maxImageXUpDown.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.maxImageXUpDown.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.maxImageXUpDown.Location = new System.Drawing.Point(154, 188);
            this.maxImageXUpDown.Name = "maxImageXUpDown";
            this.maxImageXUpDown.Size = new System.Drawing.Size(56, 25);
            this.maxImageXUpDown.TabIndex = 16;
            this.maxImageXUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // minImageXUpDown
            // 
            this.minImageXUpDown.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.minImageXUpDown.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.minImageXUpDown.Location = new System.Drawing.Point(154, 215);
            this.minImageXUpDown.Name = "minImageXUpDown";
            this.minImageXUpDown.Size = new System.Drawing.Size(56, 25);
            this.minImageXUpDown.TabIndex = 16;
            this.minImageXUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maxImageYUpDown
            // 
            this.maxImageYUpDown.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.maxImageYUpDown.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.maxImageYUpDown.Location = new System.Drawing.Point(248, 188);
            this.maxImageYUpDown.Name = "maxImageYUpDown";
            this.maxImageYUpDown.Size = new System.Drawing.Size(56, 25);
            this.maxImageYUpDown.TabIndex = 16;
            this.maxImageYUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // minImageYUpDown
            // 
            this.minImageYUpDown.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.minImageYUpDown.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.minImageYUpDown.Location = new System.Drawing.Point(248, 215);
            this.minImageYUpDown.Name = "minImageYUpDown";
            this.minImageYUpDown.Size = new System.Drawing.Size(56, 25);
            this.minImageYUpDown.TabIndex = 16;
            this.minImageYUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ImageParserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(334, 544);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.imageFoundGroupBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.settingsGroupBox);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "ImageParserForm";
            this.Text = "ImageParser";
            this.settingsGroupBox.ResumeLayout(false);
            this.settingsGroupBox.PerformLayout();
            this.imageFoundGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageFound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxImageXUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minImageXUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxImageYUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minImageYUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label URLLabel;
        private System.Windows.Forms.TextBox URLtextBox;
        private System.Windows.Forms.Button savePathButton;
        private System.Windows.Forms.Label savePathLabel;
        private System.Windows.Forms.TextBox savePathTextBox;
        private System.Windows.Forms.GroupBox imageFoundGroupBox;
        private System.Windows.Forms.PictureBox imageFound;
        private System.Windows.Forms.Label filtersLabel;
        private System.Windows.Forms.Label minImageSizeYLabel;
        private System.Windows.Forms.Label maxImageSizeYLabel;
        private System.Windows.Forms.Label minImageSizeXLabel;
        private System.Windows.Forms.Label maxImageSizeXLabel;
        private System.Windows.Forms.Label minImageSizeLabel;
        private System.Windows.Forms.Label maxImageSizeLabel;
        private System.Windows.Forms.NumericUpDown minImageYUpDown;
        private System.Windows.Forms.NumericUpDown maxImageYUpDown;
        private System.Windows.Forms.NumericUpDown minImageXUpDown;
        private System.Windows.Forms.NumericUpDown maxImageXUpDown;
    }
}

