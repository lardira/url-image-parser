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
            this.minImageYUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxImageYUpDown = new System.Windows.Forms.NumericUpDown();
            this.minImageXUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxImageXUpDown = new System.Windows.Forms.NumericUpDown();
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
            this.savePathFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.settingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minImageYUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxImageYUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minImageXUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxImageXUpDown)).BeginInit();
            this.imageFoundGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageFound)).BeginInit();
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
            resources.ApplyResources(this.settingsGroupBox, "settingsGroupBox");
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.TabStop = false;
            // 
            // minImageYUpDown
            // 
            this.minImageYUpDown.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.minImageYUpDown, "minImageYUpDown");
            this.minImageYUpDown.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.minImageYUpDown.Name = "minImageYUpDown";
            this.minImageYUpDown.ValueChanged += new System.EventHandler(this.minImageYUpDown_ValueChanged);
            // 
            // maxImageYUpDown
            // 
            this.maxImageYUpDown.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.maxImageYUpDown, "maxImageYUpDown");
            this.maxImageYUpDown.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.maxImageYUpDown.Name = "maxImageYUpDown";
            this.maxImageYUpDown.ValueChanged += new System.EventHandler(this.maxImageYUpDown_ValueChanged);
            // 
            // minImageXUpDown
            // 
            this.minImageXUpDown.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.minImageXUpDown, "minImageXUpDown");
            this.minImageXUpDown.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.minImageXUpDown.Name = "minImageXUpDown";
            this.minImageXUpDown.ValueChanged += new System.EventHandler(this.minImageXUpDown_ValueChanged);
            // 
            // maxImageXUpDown
            // 
            this.maxImageXUpDown.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.maxImageXUpDown, "maxImageXUpDown");
            this.maxImageXUpDown.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.maxImageXUpDown.Name = "maxImageXUpDown";
            this.maxImageXUpDown.ValueChanged += new System.EventHandler(this.maxImageXUpDown_ValueChanged);
            // 
            // minImageSizeLabel
            // 
            resources.ApplyResources(this.minImageSizeLabel, "minImageSizeLabel");
            this.minImageSizeLabel.Name = "minImageSizeLabel";
            // 
            // maxImageSizeLabel
            // 
            resources.ApplyResources(this.maxImageSizeLabel, "maxImageSizeLabel");
            this.maxImageSizeLabel.Name = "maxImageSizeLabel";
            // 
            // minImageSizeYLabel
            // 
            resources.ApplyResources(this.minImageSizeYLabel, "minImageSizeYLabel");
            this.minImageSizeYLabel.Name = "minImageSizeYLabel";
            // 
            // maxImageSizeYLabel
            // 
            resources.ApplyResources(this.maxImageSizeYLabel, "maxImageSizeYLabel");
            this.maxImageSizeYLabel.Name = "maxImageSizeYLabel";
            // 
            // minImageSizeXLabel
            // 
            resources.ApplyResources(this.minImageSizeXLabel, "minImageSizeXLabel");
            this.minImageSizeXLabel.Name = "minImageSizeXLabel";
            // 
            // maxImageSizeXLabel
            // 
            resources.ApplyResources(this.maxImageSizeXLabel, "maxImageSizeXLabel");
            this.maxImageSizeXLabel.Name = "maxImageSizeXLabel";
            // 
            // filtersLabel
            // 
            resources.ApplyResources(this.filtersLabel, "filtersLabel");
            this.filtersLabel.Name = "filtersLabel";
            // 
            // URLLabel
            // 
            resources.ApplyResources(this.URLLabel, "URLLabel");
            this.URLLabel.Name = "URLLabel";
            // 
            // URLtextBox
            // 
            this.URLtextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.URLtextBox, "URLtextBox");
            this.URLtextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.URLtextBox.Name = "URLtextBox";
            this.URLtextBox.MouseEnter += new System.EventHandler(this.URLtextBox_MouseEnter);
            this.URLtextBox.MouseLeave += new System.EventHandler(this.URLtextBox_MouseLeave);
            // 
            // savePathButton
            // 
            this.savePathButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.savePathButton, "savePathButton");
            this.savePathButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.savePathButton.Name = "savePathButton";
            this.savePathButton.UseVisualStyleBackColor = false;
            this.savePathButton.Click += new System.EventHandler(this.savePathButton_Click);
            // 
            // savePathLabel
            // 
            resources.ApplyResources(this.savePathLabel, "savePathLabel");
            this.savePathLabel.Name = "savePathLabel";
            // 
            // savePathTextBox
            // 
            this.savePathTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.savePathTextBox, "savePathTextBox");
            this.savePathTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.savePathTextBox.Name = "savePathTextBox";
            this.savePathTextBox.MouseEnter += new System.EventHandler(this.savePathTextBox_MouseEnter);
            this.savePathTextBox.MouseLeave += new System.EventHandler(this.savePathTextBox_MouseLeave);
            // 
            // imageFoundGroupBox
            // 
            resources.ApplyResources(this.imageFoundGroupBox, "imageFoundGroupBox");
            this.imageFoundGroupBox.Controls.Add(this.imageFound);
            this.imageFoundGroupBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.imageFoundGroupBox.Name = "imageFoundGroupBox";
            this.imageFoundGroupBox.TabStop = false;
            // 
            // imageFound
            // 
            resources.ApplyResources(this.imageFound, "imageFound");
            this.imageFound.Name = "imageFound";
            this.imageFound.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.progressBar, "progressBar");
            this.progressBar.Name = "progressBar";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.startButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.startButton, "startButton");
            this.startButton.Name = "startButton";
            this.startButton.TabStop = false;
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // ImageParserForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.imageFoundGroupBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.settingsGroupBox);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ImageParserForm";
            this.settingsGroupBox.ResumeLayout(false);
            this.settingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minImageYUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxImageYUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minImageXUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxImageXUpDown)).EndInit();
            this.imageFoundGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageFound)).EndInit();
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
        private System.Windows.Forms.FolderBrowserDialog savePathFolderBrowserDialog;
    }
}

