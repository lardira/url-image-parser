using System;
using System.IO;
using System.Windows.Forms;

namespace ImageParser
{
    public partial class ImageParserForm : Form
    {
        private const string URLTextBoxHint = " type url here... ";
        private const string SavePathTextBoxHint = " choose the destination folder... ";

        private const string DefaultSavePathFolder = "ImageParserOutput";
        private readonly string DefaultSavePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                                                  + @"\" + DefaultSavePathFolder;

        private Size<decimal> filterMaxImageSize = new Size<decimal>();
        private Size<decimal> filterMinImageSize = new Size<decimal>();

        public ImageParserForm()
        {
            InitializeComponent();

            savePathTextBox.Text = DefaultSavePath;
            savePathFolderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (ValidateURLInput() && ValidateSavePath())
            {
                //TODO: start parsing
            }
        }

        private bool ValidateURLInput()
        {
            Uri URIResult;
            bool isValidURL = Uri.TryCreate(URLtextBox.Text, UriKind.Absolute, out URIResult)
                && (URIResult.Scheme == Uri.UriSchemeHttp || URIResult.Scheme == Uri.UriSchemeHttps);

            if (!isValidURL)
            {
                MessageBox.Show("Error!" +
                    "           \nURL Path is invalid!");
                return false;
            }

            return true;
        }

        private bool ValidateSavePath()
        {
            if (!Directory.Exists(savePathTextBox.Text))
            {
                try
                {
                    Directory.CreateDirectory(savePathTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Error!" +
                                    "\nSave path is invalid!" +
                                    "\nCannot access directory in the specified save path.");
                    return false;
                }
            }
            return true;
        }

        private void savePathButton_Click(object sender, EventArgs e)
        {
            if (savePathFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                savePathTextBox.Text = savePathFolderBrowserDialog.SelectedPath;
            }
        }
        private void URLtextBox_MouseEnter(object sender, EventArgs e)
        {
            if (URLtextBox.Text == URLTextBoxHint)
                URLtextBox.Text = default;
        }

        private void URLtextBox_MouseLeave(object sender, EventArgs e)
        {
            if (URLtextBox.Text.Length == 0 && !URLtextBox.Focused)
                URLtextBox.Text = URLTextBoxHint;
        }

        private void savePathTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (savePathTextBox.Text == SavePathTextBoxHint)
                savePathTextBox.Text = default;
        }

        private void savePathTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (savePathTextBox.Text.Length == 0 && !savePathTextBox.Focused)
                savePathTextBox.Text = SavePathTextBoxHint;
        }

        #region Filters

        private void maxImageXUpDown_ValueChanged(object sender, EventArgs e)
        {
            filterMaxImageSize[0] = maxImageXUpDown.Value;
        }

        private void maxImageYUpDown_ValueChanged(object sender, EventArgs e)
        {
            filterMaxImageSize[1] = maxImageYUpDown.Value;
        }

        private void minImageXUpDown_ValueChanged(object sender, EventArgs e)
        {
            filterMinImageSize[0] = minImageXUpDown.Value;
        }

        private void minImageYUpDown_ValueChanged(object sender, EventArgs e)
        {
            filterMinImageSize[1] = minImageYUpDown.Value;
        }

        #endregion Filters
    }
}