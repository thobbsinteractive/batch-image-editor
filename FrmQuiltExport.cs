using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace batch_image_editor
{
    public partial class FrmQuiltExport : Form
    {
        private struct QuiltSettings
        {
            public int Id;
            public string Description;
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

        public FrmQuiltExport(string[] imagesPaths, int imageWidth, int imageHeight, Rectangle cropRectangle)
        {
            InitializeComponent();
            _imageWidth = imageWidth;
            _imageHeight = imageHeight;
            _cropRectangle = cropRectangle;
            _imagesPaths = imagesPaths;
            cboPresets.DataSource = PopulateDropDownList();
            cboPresets.SelectedIndex = 0;
        }

        private QuiltSettings[] PopulateDropDownList()
        {
            return new[]
            {
                new QuiltSettings
                {
                    Id = 0,
                    Description = "Looking Glass Go",
                    Cols = 11,
                    Rows = 6,
                    AspectRatio = 0.75,
                    Width = 4092,
                    Height = 4092
                },
                new QuiltSettings
                {
                    Id = 1,
                    Description = "Looking Glass Portrait",
                    Cols = 8,
                    Rows = 6,
                    AspectRatio = 0.75,
                    Width = 3360,
                    Height = 3360
                },
                new QuiltSettings
                {
                    Id = 2,
                    Description = "Looking Glass 16\" Light Field Display (Landscape)",
                    Cols = 7,
                    Rows = 7,
                    AspectRatio = 1.777,
                    Width = 5999,
                    Height = 5999
                },
                new QuiltSettings
                {
                    Id = 3,
                    Description = "Looking Glass 16\" Light Field Display (Portrait)",
                    Cols = 11,
                    Rows = 6,
                    AspectRatio = 1.777,
                    Width = 5995,
                    Height = 6000
                },
                new QuiltSettings
                {
                    Id = 4,
                    Description = "Looking Glass 32\" Light Field Display (Landscape)",
                    Cols = 7,
                    Rows = 7,
                    AspectRatio = 1.777,
                    Width = 8190,
                    Height = 8190
                },
                new QuiltSettings
                {
                    Id = 5,
                    Description = "Looking Glass 32\" Light Field Display (Portrait)",
                    Cols = 11,
                    Rows = 6,
                    AspectRatio = 1.777,
                    Width = 8184,
                    Height = 8184
                }
            };
        }

        private void SetSettings(QuiltSettings settings)
        {
            nudCol.Value = settings.Cols;
            nudRow.Value = settings.Rows;
            lblAspectRatio.Text = settings.AspectRatio.ToString();
            nudWidth.Value = settings.Width;
            nupHeight.Value = settings.Height;
            UpdateFileName();
        }

        private QuiltSettings GetSettings()
        {
            return new QuiltSettings
            {
                Cols = (int)nudCol.Value,
                Rows = (int)nudRow.Value,
                AspectRatio = string.IsNullOrWhiteSpace(lblAspectRatio.Text) ? 0 : double.Parse(lblAspectRatio.Text),
                Width = (int)nudWidth.Value,
                Height = (int)nupHeight.Value
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

        private void Export()
        {
            var settings = GetSettings();
            var imageTotalWidth = _imageWidth * settings.Cols;
            var imageTotalHeight = _imageHeight * settings.Rows;
            Image outputImage = new Bitmap(imageTotalWidth, imageTotalHeight);
            int i = 0;

            for (int y = settings.Rows; y > 0; y--)
            {
                for (int x = 0; x < settings.Cols; x++)
                {
                    var image = Bitmap.FromFile(_imagesPaths[i]);
                    var croppedImage = DrawingUtils.CropImage(image, _cropRectangle);
                    var scaledImage = DrawingUtils.ResizeImage(croppedImage, _imageWidth, _imageHeight);
                    DrawingUtils.DrawImage(outputImage, scaledImage, new Rectangle(x * _imageWidth, y * _imageHeight, _imageWidth, _imageHeight));
                    i++;
                }
            }
            
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
            if (!CheckRatio() &&
                MessageBox.Show("Aspect Ratio mis-match. Do you want to continue?", "Aspect Ratio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (!CheckSize() &&
                MessageBox.Show("Total Size mis-match. Do you want to continue?", "Total Size", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            Export();

            //await Export();
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
