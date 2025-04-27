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

        public List<string> OrderFilesList => _selectedFilesList.OrderBy(fileStr => Path.GetFileName(fileStr)).ToList();

        public Main()
        {
            InitializeComponent();
            pbMainImage.Paint += PbMainImage_Paint;
        }

        private void openImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _selectedFilesList = SelectFiles();
            if (_selectedFilesList.Any())
            {
                lstBox.DataSource = OrderFilesList;
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
                pbMainImage.SizeMode = PictureBoxSizeMode.Zoom;
                _selectedImage = Image.FromFile(lstBox.SelectedItem.ToString());
                pbMainImage.Image = _selectedImage;

                nudWidth.Maximum = _selectedImage.Width;
                nudHeight.Maximum = _selectedImage.Height;
                nudWidth.Value = _selectedImage.Width;
                nudHeight.Value = _selectedImage.Height;

                nudCropXPos.Value = 0;
                nudCropYPos.Value = 0;
                nudCropXPos.Maximum = _selectedImage.Width;
                nudCropYPos.Maximum = _selectedImage.Height;

                nudCropWidth.Maximum = _selectedImage.Width;
                nudCropHeight.Maximum = _selectedImage.Height;
                nudCropWidth.Value = _selectedImage.Width;
                nudCropHeight.Value = _selectedImage.Height;
            }
        }

        private void RefreshCrop()
        {
            if (nudCropXPos.Value > _selectedImage.Width - 1)
                nudCropXPos.Value = _selectedImage.Width - 1;

            if (nudCropYPos.Value > _selectedImage.Height - 1)
                nudCropYPos.Value = _selectedImage.Height - 1;

            if (nudCropWidth.Value + nudCropXPos.Value > _selectedImage.Width)
                nudCropWidth.Value = _selectedImage.Width - nudCropXPos.Value;

            if (nudCropHeight.Value + nudCropYPos.Value > _selectedImage.Height)
                nudCropHeight.Value = _selectedImage.Width - nudCropYPos.Value;

            pbMainImage.Refresh();
        }

        private void PbMainImage_Paint(object sender, PaintEventArgs e)
        {
            Rectangle ee = new Rectangle((int)nudCropXPos.Value, (int)nudCropYPos.Value, (int)nudCropWidth.Value, (int)nudCropHeight.Value);
            using (Pen pen = new Pen(Color.Red, 1))
            {
                e.Graphics.DrawRectangle(pen, ee);
            }
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
        }

        private void nudYPos_ValueChanged(object sender, EventArgs e)
        {
            RefreshCrop();
        }

        private void nudCropWidth_ValueChanged(object sender, EventArgs e)
        {
            RefreshCrop();
        }

        private void nudCropHeight_ValueChanged(object sender, EventArgs e)
        {
            RefreshCrop();
        }

        private void asQuiltToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQuiltExport frmQuiltExport = new FrmQuiltExport(OrderFilesList.ToArray(), 
                (int)nudWidth.Value, 
                (int)nudHeight.Value,
                new Rectangle((int)nudCropXPos.Value, (int)nudCropYPos.Value, (int)nudCropWidth.Value, (int)nudCropHeight.Value));
            frmQuiltExport.ShowDialog();
        }
    }
}
