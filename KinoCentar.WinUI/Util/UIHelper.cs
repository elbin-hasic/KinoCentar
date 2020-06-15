using KinoCentar.WinUI.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinoCentar.WinUI.Util
{
    public class UIHelper
    {
        #region Korisnici
        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
        #endregion

        #region Slike

        public static SaveImageModel PrepareSaveImage(string imgPath)
        {
            SaveImageModel saveImage = null;

            try
            {
                if (string.IsNullOrEmpty(imgPath))
                {
                    return null;
                }

                if (File.Exists(imgPath))
                {
                    saveImage = new SaveImageModel();

                    saveImage.OriginalImageBytes = File.ReadAllBytes(imgPath);
                    saveImage.OriginalImage = Image.FromFile(imgPath);

                    if (saveImage.OriginalImage.Width > ConfigurationSettings.RESIZED_IMAGE_WIDTH)
                    {
                        MemoryStream ms = new MemoryStream();

                        saveImage.ResizedImage = ResizeImage(saveImage.OriginalImage, new Size(ConfigurationSettings.RESIZED_IMAGE_WIDTH,
                                                                                               ConfigurationSettings.RESIZED_IMAGE_HEIGHT));
                        saveImage.ResizedImage.Save(ms, saveImage.OriginalImage.RawFormat);
                        saveImage.ResizedImageBytes = ms.ToArray();

                        if (saveImage.ResizedImage.Width > ConfigurationSettings.CROPPED_IMAGE_WIDTH &&
                            saveImage.ResizedImage.Height > ConfigurationSettings.CROPPED_IMAGE_HEIGHT)
                        {
                            int croppedXPosition = (saveImage.ResizedImage.Width - ConfigurationSettings.CROPPED_IMAGE_WIDTH) / 2;
                            int croppedYPosition = (saveImage.ResizedImage.Height - ConfigurationSettings.CROPPED_IMAGE_HEIGHT) / 2;

                            saveImage.CroppedImage = CropImage(saveImage.ResizedImage, new Rectangle(croppedXPosition, croppedYPosition,
                                                                                                     ConfigurationSettings.CROPPED_IMAGE_WIDTH,
                                                                                                     ConfigurationSettings.CROPPED_IMAGE_HEIGHT));
                            saveImage.CroppedImage.Save(ms, saveImage.OriginalImage.RawFormat);
                            saveImage.CroppedImageBytes = ms.ToArray();
                        }
                        else
                        {
                            MessageBox.Show(Messages.picture_war + " " + ConfigurationSettings.RESIZED_IMAGE_WIDTH + "x" + ConfigurationSettings.RESIZED_IMAGE_HEIGHT + ".",
                                            Messages.msg_war, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            saveImage = null;
                        }
                    }
                }
                else
                {
                    MessageBox.Show(Messages.picture_not_exist, Messages.msg_war, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    saveImage = null;
                }
            }
            catch
            {
                saveImage = null;
            }

            return saveImage;
        }

        private static Image CropImage(Image img, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);
            Bitmap bmpCrop = bmpImage.Clone(cropArea,
            bmpImage.PixelFormat);
            return (Image)(bmpCrop);
        }

        private static Image ResizeImage(Image imgToResize, Size size)
        {
            int sourceWidth = imgToResize.Width;
            int sourceHeight = imgToResize.Height;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)size.Width / (float)sourceWidth);
            nPercentH = ((float)size.Height / (float)sourceHeight);

            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();

            return (Image)b;
        }

        #endregion
    }
}
