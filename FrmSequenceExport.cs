using batch_image_editor.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace batch_image_editor
{
    public partial class FrmSequenceExport : Form
    {
        private int _imageWidth;
        private int _imageHeight;
        private Rectangle _cropRectangle;
        private string[] _imagesPaths;
        private string _extension = ".jpg";

        public FrmSequenceExport(string[] imagesPaths, int imageWidth, int imageHeight, Rectangle cropRectangle, int transformX, int transformY)
        {
            InitializeComponent();

            if (imagesPaths == null || !imagesPaths.Any())
                throw new ArgumentNullException(nameof(imagesPaths));

            _extension = Path.GetExtension(imagesPaths[0]);
            _imageWidth = imageWidth;
            _imageHeight = imageHeight;
            _cropRectangle = cropRectangle;
            _imagesPaths = imagesPaths;

            UpdateFileName();
        }

        private void UpdateFileName()
        {
            string fileName = Path.GetFileNameWithoutExtension(_imagesPaths[0]);
            txtFileName.Text = fileName + "_{0}";
        }

        private void UpdateStatus(string status)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    lblStatus.Text = status;
                }));
            }
            else
            {
                lblStatus.Text = status;
            }
        }

        private Task<bool> Export(string filePath)
        {
            return Task.Factory.StartNew(() =>
            {
                try
                {
                    var messageStr = "Drawing {0} of " + _imagesPaths.Length;
                    UpdateStatus(string.Format(messageStr, 0));

                    using (Image outputImage = new Bitmap(_imageWidth, _imageWidth))
                    {
                        for (int i = 0; i < _imagesPaths.Length; i++)
                        {
                            using (Image image = Bitmap.FromFile(_imagesPaths[i]))
                            {
                                UpdateStatus(string.Format(messageStr, i + 1));
                                var croppedImage = DrawingUtils.CropImage(image, _cropRectangle);
                                var scaledImage = DrawingUtils.ResizeImage(croppedImage, _imageWidth, _imageHeight);
                                croppedImage.Dispose();
                                var path = string.Format(filePath, (i + 1).ToString().PadLeft(5, '0')) + _extension;
                                scaledImage.Save(path);
                                scaledImage.Dispose();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error during export {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true;
            });
        }

        private bool CheckFileName()
        {
            return txtFileName.Text.Contains("{0}");
        }

        private void EnableDisableControls(bool enabled)
        {
            this.Cursor = enabled ? Cursors.Default : Cursors.WaitCursor;
            txtFileName.Enabled = enabled;
            txtFileName.Enabled = enabled;
            btnExport.Enabled = enabled;
        }

        private async void btnExport_Click(object sender, System.EventArgs e)
        {
            EnableDisableControls(false);

            if (!CheckFileName())
            {
                MessageBox.Show("File name needs '{0}' in pattern for sequence number.", "File Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableDisableControls(true);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                saveFileDialog.FileName = txtFileName.Text;
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (!CheckFileName())
                    {
                        MessageBox.Show("File name needs '{0}' in pattern for sequence number.", "File Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        EnableDisableControls(true);
                        return;
                    }

                    //Get the path of specified file
                    await Export(saveFileDialog.FileName);
                }
            }
            EnableDisableControls(true);
        }
    }
}
