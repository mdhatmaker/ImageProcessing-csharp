using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Images
{
    public partial class ImageAppForm : Form
    {
        private Image _image;
        private string _imageFilename;
        private ImageFormat _imageSaveFormat;

        public ImageAppForm()
        {
            InitializeComponent();

            _imageSaveFormat = ImageFormat.Png;

            var imageFolder = @"D:\Users\mhatm\OneDrive\Pictures\babes\";
            LoadImage(imageFolder + "3F317C3.jpg");
        }

        private void updateTitleBar()
        {
            this.Text = string.Format("[{0}, {1}]  {2}", _image.Width, _image.Height, _imageFilename);
        }

        private void LoadImage(string filename)
        {
            try
            {
                picImage.Load(filename);
                _image = picImage.Image;
                _imageFilename = filename;
                updateTitleBar();
            }
            catch (Exception ex)
            {
                updateStatus(string.Format("ERROR Loading '{0}': {1}", filename, ex.Message));
            }
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            dlgOpenImageFile.Title = "Select an Image File";
            /*dlgOpenImageFile.Filter = "Png Images(*.png)|*.png";
            dlgOpenImageFile.Filter += "|Jpeg Images(*.jpg)|*.jpg";
            dlgOpenImageFile.Filter += "|Bitmap Images(*.bmp)|*.bmp";*/
            var dlgResult = dlgOpenImageFile.ShowDialog();

            if (dlgResult != DialogResult.OK) return;

            LoadImage(dlgOpenImageFile.FileName);
        }

        private void updateStatus(string msg = null)
        {
            if (msg == null)
                updateTitleBar();
            else
                this.Text = msg;
        }

        private void btnApplyEffect_Click(object sender, EventArgs e)
        {
            updateStatus("Applying effect...");
            ApplyEffect();
            updateStatus();
        }

        private void slider_ValueChanged(object sender, EventArgs e)
        {
            //pixelateImage();
        }

        private void ApplyEffect()
        {
            if (_image == null) return;

            var bmp = _image as Bitmap;

            //var fxBitmap = ImageLib.FxPixelate.Pixelate(bmp, slider.Value);
            //var fxBitmap = ImageLib.FxImageCartoonEffect.CartoonEffectFilter(bmp, 0, ImageLib.FxImageCartoonEffect.SmoothingFilterType.Mean5x5);
            //var fxBitmap = ImageLib.FxImageBlurFilter.ImageBlurFilter(bmp, ImageLib.FxImageBlurFilter.BlurType.GaussianBlur5x5);
            float value = 2.0f * slider.Value / slider.Maximum;
            //float blueShade = value, greenShade = value, redShade = value;
            //var fxBitmap = ImageLib.FxBitmapShading.ColorShade(bmp, blueShade, greenShade, redShade);
            //float blueTint = value, greenTint = value, redTint = value;
            //var fxBitmap = ImageLib.FxBitmapTint.ColorTint(bmp, blueTint, greenTint, redTint);
            //var fxBitmap = ImageLib.FxOilPaintingCartoonFilter.OilPaintFilter(bmp, (int)50, Int32.Parse("7"));
            var fxBitmap = ImageLib.FxOilPaintingCartoonFilter.CartoonFilter(bmp, (int)75, Int32.Parse("9"), (byte)60);

            picImage.Image = fxBitmap;
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            string picFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            string ext = _imageSaveFormat.ToString().ToLower();
            string filename = string.Format("IMAGE{0}.{1}", DateTime.Now.ToString("yyyyMMdd.HHmmss"), ext);
            string pathname = Path.Combine(picFolder, filename);
            picImage.Image.Save(pathname, _imageSaveFormat);

            displayInfo("Image saved.");
        }

        private void displayInfo(string msg)
        {
            Console.WriteLine(msg);
        }

        private void btnRevertImage_Click(object sender, EventArgs e)
        {
            picImage.Image = _image;
        }

    } // END OF CLASS
} // END OF NAMESPACE
