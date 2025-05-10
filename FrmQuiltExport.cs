using System;
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
        private int _cellWidth;
        private int _cellHeight;
        private Rectangle _cropRectangle;
        private string[] _imagesPaths;
        private string _extension = ".jpg";

        public FrmQuiltExport(string[] imagesPaths, int cellWidth, int cellHeight, Rectangle cropRectangle)
        {
            InitializeComponent();

            if (imagesPaths == null || !imagesPaths.Any())
                throw new ArgumentNullException(nameof(imagesPaths));

            _extension = Path.GetExtension(imagesPaths[0]);
            _cellWidth = cellWidth;
            _cellHeight = cellHeight;

            lblImageCellWidth.Text = _cellWidth.ToString();
            lblImageCellHeight.Text = _cellHeight.ToString();

            _cropRectangle = cropRectangle;
            _imagesPaths = imagesPaths;

            cboPresets.DisplayMember = "Name";
            cboPresets.ValueMember = null;
            cboPresets.DataSource = ListUtils.PopulateDropDownList();
            cboPresets.SelectedIndex = 1;
        }

        private void SetSettings(ListUtils.QuiltSettings settings)
        {
            nudCol.Value = settings.Cols;
            nudRow.Value = settings.Rows;
            lblAspectRatio.Text = settings.AspectRatio.ToString();
            lblPresetWidth.Text = settings.Width.ToString();
            lblPresetHeight.Text = settings.Height.ToString();
            lblPresetCellWidth.Text = settings.CellWidth.ToString();
            lblPresetCellHeight.Text = settings.CellHeight.ToString();
            UpdateFileName();
            RefreshImageTotals();
        }

        private ListUtils.QuiltSettings GetSettings()
        {
            return new ListUtils.QuiltSettings
            {
                Cols = (int)nudCol.Value,
                Rows = (int)nudRow.Value,
                AspectRatio = string.IsNullOrWhiteSpace(lblAspectRatio.Text) ? 0 : double.Parse(lblAspectRatio.Text),
                Width = string.IsNullOrWhiteSpace(lblWidth.Text) ? 0: int.Parse(lblWidth.Text),
                Height = string.IsNullOrWhiteSpace(lblHeight.Text) ? 0: int.Parse(lblHeight.Text)
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

        private void RefreshImageTotals()
        {
            var settings = GetSettings();
            lblWidth.Text = (_cellWidth * settings.Cols).ToString();
            lblHeight.Text = (_cellHeight * settings.Rows).ToString();
        }

        private Task<bool> Export(string filePath)
        {
            return Task.Factory.StartNew(() =>
            {
                try
                {
                    var settings = GetSettings();
                    var imageTotalWidth = _cellWidth * settings.Cols;
                    var imageTotalHeight = _cellHeight * settings.Rows;
                    var totalPics = settings.Rows * settings.Cols;
                    var messageStr = _cellWidth + "x" + _cellHeight + ": Drawing {0} of " + totalPics;
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
                                        UpdateStatus(string.Format(messageStr, i + 1));
                                        var croppedImage = DrawingUtils.CropImage(image, _cropRectangle);
                                        var scaledImage = DrawingUtils.ResizeImage(croppedImage, _cellWidth, _cellHeight);
                                        croppedImage.Dispose();
                                        DrawingUtils.DrawImage(scaledImage, outputImage, 
                                            new Rectangle(0, 0, scaledImage.Width, scaledImage.Height),
                                            new Rectangle(x * _cellWidth, y * _cellHeight, _cellWidth, _cellHeight));
                                        scaledImage.Dispose();
                                    }
                                }
                                i++;
                            }
                        }

                        outputImage.Save(filePath);
                        UpdateStatus("Export Complete!");
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

            if(totalNumPic != _imagesPaths.Length)
            {
                return MessageBox.Show($"The number of the images for the device: {totalNumPic} does not match the number of images selected: {_imagesPaths.Length}. This can lead to gaps in the Quilt. Do you want to continue?", "Aspect Ratio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
            }
            return true;
        }

        private bool CheckRatio()
        {
            var settings = GetSettings();
            var ratio = Math.Round((double)_cellWidth / (double)_cellHeight, 2);

            if (settings.AspectRatio !=ratio)
            {
                return MessageBox.Show($"The Aspect Ratio for the selected device: {settings.AspectRatio} does not match ratio of the images selected: {ratio}. Do you want to continue?", "Aspect Ratio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
            }
            return true;
        }

        private bool CheckSize()
        {
            var settings = GetSettings();
            var totalWidth = _cellWidth * settings.Cols;
            var totalHeight = _cellHeight * settings.Rows;

            if (settings.Width != totalWidth || settings.Height != totalHeight)
            {
                return MessageBox.Show($"The Quilt size for the selected device: {settings.Width}x{settings.Height} does not match the calculated Quilt size {totalWidth}x{totalHeight}. Do you want to continue?", "Total Size", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
             }
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
                var settings = (ListUtils.QuiltSettings)cboPresets.SelectedItem;
                SetSettings(settings);
            }
        }

        private async void btnExport_Click(object sender, System.EventArgs e)
        {
            EnableDisableControls(false);

            if (!CheckCount())
            {
                EnableDisableControls(true);
                return;
            }

            if (!CheckRatio())
            {
                EnableDisableControls(true);
                return;
            }

            if (!CheckSize())
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
            RefreshImageTotals();
        }

        private void nudRow_ValueChanged(object sender, EventArgs e)
        {
            UpdateFileName();
            RefreshImageTotals();
        }
    }
}
