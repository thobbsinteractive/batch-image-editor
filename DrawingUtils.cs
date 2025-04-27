using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace batch_image_editor
{
    internal static class DrawingUtils
    {
        /// <summary>
        /// Draws the rectangle destination image
        /// </summary>
        /// <param name="image">The image to use</param>
        /// <param name="rectangle">Destination rectangle</param>
        public static void DrawCrop(Image destImage, Rectangle destRect)
        {
            using (var graphics = Graphics.FromImage(destImage))
            {
                using (Pen pen = new Pen(Color.Red, 2))
                {
                    graphics.DrawRectangle(pen, destRect);
                }
            }
        }

        /// <summary>
        /// Draws the source image to the specified destination image using the rectangle
        /// </summary>
        /// <param name="srcImage">The source Image to use</param>
        /// <param name="destImage">The destination Image to use</param>
        /// <param name="rectangle">Destination rectangle</param>
        public static void DrawImage(Image srcImage, Image destImage, Rectangle destRect)
        {
            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(srcImage, destRect, 0, 0, destRect.Width, destRect.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
        }

        /// <summary>
        /// Draws the source image to the specified destination image using the rectangle
        /// </summary>
        /// <param name="srcImage">The source Image to use</param>
        /// <param name="destImage">The destination Image to use</param>
        /// <param name="rectangle">Destination rectangle</param>
        public static void DrawImage(Image srcImage, Image destImage)
        {
            var destRect = new Rectangle(0, 0, srcImage.Width, srcImage.Height);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(srcImage, destRect, 0, 0, destRect.Width, destRect.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
        }

        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="rectangle">The rectangle to Crop</param>
        /// <returns>The resized image.</returns>
        public static Bitmap CropImage(Image image, Rectangle rectangle)
        {
            var destRect = new Rectangle(0, 0, rectangle.Width, rectangle.Height);
            var destImage = new Bitmap(rectangle.Width, rectangle.Height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}
