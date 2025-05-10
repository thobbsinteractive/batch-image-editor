using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace batch_image_editor
{
    public partial class Main : Form
    {
        private List<string> _selectedFilesList = new List<string>();
        private Image _selectedImage = null;
        private Image _renderImage = null;

        public List<string> OrderFilesList => _selectedFilesList.OrderBy(fileStr => Path.GetFileName(fileStr)).ToList();

        public Main()
        {
            InitializeComponent();

            cboPresets.DisplayMember = "Name";
            cboPresets.ValueMember = null;
            cboPresets.DataSource = ListUtils.PopulateDropDownList(true);
            cboPresets.SelectedIndex = 0;
        }

        private void openImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _selectedFilesList = SelectFiles();
            if (_selectedFilesList.Any())
            {
                lstBox.DataSource = OrderFilesList;

                lblCount.Text = (OrderFilesList?.Count() ?? 0).ToString();

                nudWidth.Maximum = _selectedImage.Width;
                nudHeight.Maximum = _selectedImage.Height;
                nudWidth.Value = _selectedImage.Width;
                nudHeight.Value = _selectedImage.Height;
                
                nudCropXPos.Maximum = _selectedImage.Width;
                nudCropYPos.Maximum = _selectedImage.Height;
                nudCropXPos.Value = 0;
                nudCropYPos.Value = 0;

                nudCropWidth.Maximum = _selectedImage.Width;
                nudCropHeight.Maximum = _selectedImage.Height;
                nudCropWidth.Value = _selectedImage.Width;
                nudCropHeight.Value = _selectedImage.Height;

                RefreshCrop();
            }
        }

        private List<string> SelectFiles()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                openFileDialog.Filter = GetFileTypes();
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    return openFileDialog.FileNames.ToList();
                }
            }
            return new List<string>();
        }

        private string GetFileTypes()
        {
            var filter = string.Empty;
            var codecs = ImageCodecInfo.GetImageEncoders();
            var sep = string.Empty;
            foreach (ImageCodecInfo c in codecs)
            {
                string codecName = c.CodecName.Substring(8).Replace("Codec", "Files").Trim();
                filter = string.Format("{0}{1}{2} ({3})|{3}", filter, sep, codecName, c.FilenameExtension);
                sep = "|";
            }
            return string.Format("{0}{1}{2} ({3})|{3}", filter, sep, "All Files", "*.*");
        }

        private void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBox.SelectedItem != null)
            {
                RefreshRender();

                pbMainImage.SizeMode = PictureBoxSizeMode.Zoom;
                pbMainImage.Image = _renderImage;

                nudWidth.Maximum = _selectedImage.Width;
                nudHeight.Maximum = _selectedImage.Height;
                if ((nudWidth.Value > _selectedImage.Width || nudHeight.Value > _selectedImage.Height))
                {
                    nudWidth.Value = _selectedImage.Width;
                    nudHeight.Value = _selectedImage.Height;
                }

                nudCropXPos.Maximum = _selectedImage.Width;
                nudCropYPos.Maximum = _selectedImage.Height;
                if ((nudCropXPos.Value > _selectedImage.Width || nudCropXPos.Value > _selectedImage.Height))
                {
                    nudCropXPos.Value = 0;
                    nudCropYPos.Value = 0;
                }

                nudCropWidth.Maximum = _selectedImage.Width;
                nudCropHeight.Maximum = _selectedImage.Height;
                if ((nudCropWidth.Value > _selectedImage.Width || nudCropHeight.Value > _selectedImage.Height))
                {
                    nudCropWidth.Value = _selectedImage.Width;
                    nudCropHeight.Value = _selectedImage.Height;
                }

                RefreshCrop();
            }
        }

        private void RefreshRender()
        {
            if (_selectedImage != null)
                _selectedImage.Dispose();

            _selectedImage = Image.FromFile(lstBox.SelectedItem.ToString());

            if (_renderImage != null)
                _renderImage.Dispose();

            _renderImage = new Bitmap(_selectedImage);

            DrawingUtils.DrawImage(_selectedImage, _renderImage);
            pbMainImage.Image = _renderImage;
        }

        private void RefreshCrop()
        {
            if (_selectedImage is null)
                return;

            RefreshRender();

            if (nudCropXPos.Value > _selectedImage.Width - 1)
                nudCropXPos.Value = _selectedImage.Width - 1;

            if (nudCropYPos.Value > _selectedImage.Height - 1)
                nudCropYPos.Value = _selectedImage.Height - 1;

            if (nudCropWidth.Value + nudCropXPos.Value > _selectedImage.Width)
                nudCropWidth.Value = _selectedImage.Width - nudCropXPos.Value;

            if (nudCropHeight.Value + nudCropYPos.Value > _selectedImage.Height)
                nudCropHeight.Value = _selectedImage.Height - nudCropYPos.Value;

            var blankRect = new Rectangle(0, 0, _selectedImage.Width, _selectedImage.Height);
            DrawingUtils.DrawRectangle(_renderImage, Color.Black, blankRect);

            var rect = new Rectangle((int)nudCropXPos.Value, (int)nudCropYPos.Value, (int)nudCropWidth.Value, (int)nudCropHeight.Value);
            DrawingUtils.DrawImage(_selectedImage, _renderImage, rect, rect);

            decimal ratio = CalculateRatioCrop();
            lblRatioCalc.Text = Math.Round(ratio, 2).ToString();

            decimal ratioScale = CalculateRatioScale();
            lblRatioCalcScale.Text = Math.Round(ratioScale, 2).ToString();

            pbMainImage.Refresh();
        }

        private decimal CalculateRatioCrop()
        {
            return nudCropWidth.Value / nudCropHeight.Value;
        }

        private decimal CalculateRatioScale()
        {
            return nudWidth.Value / nudHeight.Value;
        }

        private void nudWidth_ValueChanged(object sender, EventArgs e)
        {
            if (nudWidth.Value < 1)
                nudWidth.Value = 1;
        }

        private void nudHeight_ValueChanged(object sender, EventArgs e)
        {
            if (nudHeight.Value < 1)
                nudHeight.Value = 1;
        }

        private void nudXPos_ValueChanged(object sender, EventArgs e)
        {
            RefreshCrop();
            nudWidth.Value = nudCropWidth.Value;
            nudHeight.Value = nudCropHeight.Value;
        }

        private void nudYPos_ValueChanged(object sender, EventArgs e)
        {
            RefreshCrop();
            nudWidth.Value = nudCropWidth.Value;
            nudHeight.Value = nudCropHeight.Value;
        }

        private void nudCropWidth_ValueChanged(object sender, EventArgs e)
        {
            RefreshCrop();
            nudWidth.Value = nudCropWidth.Value;
            nudHeight.Value = nudCropHeight.Value;
            cboPresets.SelectedIndex = 0;
        }

        private void nudCropHeight_ValueChanged(object sender, EventArgs e)
        {
            RefreshCrop();
            nudWidth.Value = nudCropWidth.Value;
            nudHeight.Value = nudCropHeight.Value;
            cboPresets.SelectedIndex = 0;
        }

        private void asQuiltToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OrderFilesList.Any())
            {
                FrmQuiltExport frmQuiltExport = new FrmQuiltExport(OrderFilesList.ToArray(),
                    (int)nudWidth.Value,
                    (int)nudHeight.Value,
                    new Rectangle((int)nudCropXPos.Value, (int)nudCropYPos.Value, (int)nudCropWidth.Value, (int)nudCropHeight.Value));
                frmQuiltExport.ShowDialog();
            }
        }

        private void asImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OrderFilesList.Any())
            {
                FrmSequenceExport frmQuiltExport = new FrmSequenceExport(OrderFilesList.ToArray(),
                    (int)nudWidth.Value,
                    (int)nudHeight.Value,
                    new Rectangle((int)nudCropXPos.Value, (int)nudCropYPos.Value, (int)nudCropWidth.Value, (int)nudCropHeight.Value));
                frmQuiltExport.ShowDialog();
            }
        }

        private void cboPresets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPresets.SelectedItem != null)
            {
                var setting = (ListUtils.QuiltSettings)cboPresets.SelectedItem;

                if (setting.Id != 0)
                {
                    if (setting.CellWidth <= nudWidth.Maximum)
                        nudWidth.Value = setting.CellWidth;

                    if (setting.CellHeight <= nudHeight.Maximum)
                        nudHeight.Value = setting.CellHeight;

                    decimal ratioScale = CalculateRatioScale();
                    lblRatioCalcScale.Text = Math.Round(ratioScale, 2).ToString();
                }
            }
        }
    }
}
