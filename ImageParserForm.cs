using System;
using System.IO;
using System.Windows.Forms;

namespace ImageParser
{
    public partial class ImageParserForm : Form
    {
        private const string DefaultSavePathFolder = "ImageParserOutput";

        private readonly string DefaultSavePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                                                  + @"\" + DefaultSavePathFolder;

        private Size<decimal> filterMaxImageSize = new Size<decimal>();
        private Size<decimal> filterMinImageSize = new Size<decimal>();

        public ImageParserForm()
        {
            InitializeComponent();

            //TODO: make hints on textboxes disappear upon a click

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

        #region Filters

        private void maxImageXUpDown_ValueChanged(object sender, EventArgs e)
        {
            filterMaxImageSize.x = maxImageXUpDown.Value;
        }

        private void maxImageYUpDown_ValueChanged(object sender, EventArgs e)
        {
            filterMaxImageSize.y = maxImageYUpDown.Value;
        }

        private void minImageXUpDown_ValueChanged(object sender, EventArgs e)
        {
            filterMinImageSize.x = minImageXUpDown.Value;
        }

        private void minImageYUpDown_ValueChanged(object sender, EventArgs e)
        {
            filterMinImageSize.y = minImageYUpDown.Value;
        }

        #endregion Filters
    }
}