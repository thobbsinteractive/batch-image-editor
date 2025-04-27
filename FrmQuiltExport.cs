using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace batch_image_editor
{
    public partial class FrmQuiltExport : Form
    {
        private struct QuiltSettings
        {
            public int Id;
            public string Name;
            public int Cols;
            public int Rows;
            public double AspectRatio;
            public int Width;
            public int Height;
        };

        private int _imageWidth;
        private int _imageHeight;
        private Rectangle _cropRectangle;
        private string[] _imagesPaths;
        private string _extension = ".jpg";

        public FrmQuiltExport(string[] imagesPaths, int imageWidth, int imageHeight, Rectangle cropRectangle)
        {
            InitializeComponent();

            if (imagesPaths == null || !imagesPaths.Any())
                throw new ArgumentNullException(nameof(imagesPaths));

            _extension = Path.GetExtension(imagesPaths[0]);
            _imageWidth = imageWidth;
            _imageHeight = imageHeight;
            _cropRectangle = cropRectangle;
            _imagesPaths = imagesPaths;

            cboPresets.DisplayMember = "Name";
            cboPresets.ValueMember = null;
            cboPresets.DataSource = PopulateDropDownList();
            cboPresets.SelectedIndex = 0;
        }

        private QuiltSettings[] PopulateDropDownList()
        {
            List<QuiltSettings> list = new List<QuiltSettings>();

            list.Add(new QuiltSettings
            {
                Id = 0,
                Name = "Looking Glass Go",
                Cols = 11,
                Rows = 6,
                AspectRatio = 0.75,
                Width = 4092,
                Height = 4092
            });
            list.Add(new QuiltSettings {
                Id = 1,
                Name = "Looking Glass Portrait",
                Cols = 8,
                Rows = 6,
                AspectRatio = 0.75,
                Width = 3360,
                Height = 3360
            });

            list.Add(new QuiltSettings
            {
                Id = 2,
                Name = "Looking Glass 16\" Light Field Display (Landscape)",
                Cols = 7,
                Rows = 7,
                AspectRatio = 1.777,
                Width = 5999,
                Height = 5999
            });
            list.Add(new QuiltSettings
            {
                Id = 3,
                Name = "Looking Glass 16\" Light Field Display (Portrait)",
                Cols = 11,
                Rows = 6,
                AspectRatio = 1.777,
                Width = 5995,
                Height = 6000
            });
            list.Add(new QuiltSettings
            {
                Id = 4,
                Name = "Looking Glass 32\" Light Field Display (Landscape)",
                Cols = 7,
                Rows = 7,
                AspectRatio = 1.777,
                Width = 8190,
                Height = 8190
            });
            list.Add(new QuiltSettings
            {
                Id = 5,
                Name = "Looking Glass 32\" Light Field Display (Portrait)",
                Cols = 11,
                Rows = 6,
                AspectRatio = 1.777,
                Width = 8184,
                Height = 8184
            });
            return list.ToArray();
        }

        private void SetSettings(QuiltSettings settings)
        {
            nudCol.Value = settings.Cols;
            nudRow.Value = settings.Rows;
            lblAspectRatio.Text = settings.AspectRatio.ToString();
            txtWidth.Text = settings.Width.ToString();
            txtHeight.Text = settings.Height.ToString();
            UpdateFileName();
        }

        private QuiltSettings GetSettings()
        {
            return new QuiltSettings
            {
                Cols = (int)nudCol.Value,
                Rows = (int)nudRow.Value,
                AspectRatio = string.IsNullOrWhiteSpace(lblAspectRatio.Text) ? 0 : double.Parse(lblAspectRatio.Text),
                Width = string.IsNullOrWhiteSpace(txtWidth.Text) ? 0: int.Parse(txtWidth.Text),
                Height = string.IsNullOrWhiteSpace(txtHeight.Text) ? 0: int.Parse(txtHeight.Text)
            };
        }

        private void UpdateFileName()
        {
            var settings = GetSettings();

            string ending = "_qs" + settings.Cols + "x" + settings.Rows + "a" + settings.AspectRatio;
            var start = txtFileName.Text.Contains("_qs") ? Regex.Split(txtFileName.Text,"_qs")[0] : txtFileName.Text;

            if (string.IsNullOrWhiteSpace(start))
            {
                start = "Quilt";
            }
            txtFileName.Text = start + ending;
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
                    var settings = GetSettings();
                    var imageTotalWidth = _imageWidth * settings.Cols;
                    var imageTotalHeight = _imageHeight * settings.Rows;
                    var totalPics = settings.Rows * settings.Cols;
                    var messageStr = _imageWidth + "x" + _imageHeight + ": Drawing {0} of " + totalPics;
                    UpdateStatus(string.Format(messageStr, 0));

                    using (Image outputImage = new Bitmap(imageTotalWidth, imageTotalHeight))
                    {
                        int i = 0;

                        for (int y = settings.Rows - 1; y > -1; y--)
                        {
                            for (int x = 0; x < settings.Cols; x++)
                            {
                                if (i < _imagesPaths.Count())
                                {
                                    using (Image image = Bitmap.FromFile(_imagesPaths[i]))
                                    {
                                        UpdateStatus(string.Format(messageStr, i));
                                        var croppedImage = DrawingUtils.CropImage(image, _cropRectangle);
                                        var scaledImage = DrawingUtils.ResizeImage(croppedImage, _imageWidth, _imageHeight);
                                        croppedImage.Dispose();
                                        DrawingUtils.DrawImage(scaledImage, outputImage, new Rectangle(x * _imageWidth, y * _imageHeight, _imageWidth, _imageHeight));
                                        scaledImage.Dispose();
                                    }
                                }
                                i++;
                            }
                        }

                        outputImage.Save(filePath);
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

        private bool CheckCount()
        {
            var settings = GetSettings();
            var totalNumPic = settings.Rows * settings.Cols;

            return totalNumPic != _imagesPaths.Length;
        }

        private bool CheckRatio()
        {
            var settings = GetSettings();
            var ratio = (double)_imageWidth / (double)_imageHeight;

            return settings.AspectRatio == Math.Round(ratio, 2);
        }

        private bool CheckSize()
        {
            var settings = GetSettings();
            var totalWidth = _imageWidth * settings.Cols;
            var totalHeight = _imageHeight * settings.Rows;

            return settings.Width == totalWidth && settings.Height == totalHeight;
        }

        private bool CheckFileName()
        {
            return true;
        }

        private void EnableDisableControls(bool enabled)
        {
            txtFileName.Enabled = enabled;
            nudCol.Enabled = enabled;
            nudRow.Enabled = enabled;
            txtFileName.Enabled = enabled;
            btnExport.Enabled = enabled;
            cboPresets.Enabled = enabled;
        }

        private void cboPresets_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cboPresets.SelectedItem != null)
            {
                var settings = (QuiltSettings)cboPresets.SelectedItem;
                SetSettings(settings);
            }
        }

        private async void btnExport_Click(object sender, System.EventArgs e)
        {
            EnableDisableControls(false);

            if (!CheckCount() &&
                MessageBox.Show("The number of the images does not match the rows * cols. Do you want to continue?", "Aspect Ratio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                EnableDisableControls(true);
                return;
            }

            if (!CheckRatio() &&
                MessageBox.Show("Aspect Ratio mis-match. Do you want to continue?", "Aspect Ratio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                EnableDisableControls(true);
                return;
            }

            if (!CheckSize() &&
                MessageBox.Show("Total Size mis-match. Do you want to continue?", "Total Size", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                EnableDisableControls(true);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                saveFileDialog.FileName = txtFileName.Text + _extension;
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    await Export(saveFileDialog.FileName);
                }
            }
            EnableDisableControls(true);
        }

        private void nudCol_ValueChanged(object sender, EventArgs e)
        {
            UpdateFileName();
        }

        private void nudRow_ValueChanged(object sender, EventArgs e)
        {
            UpdateFileName();
        }
    }
}
