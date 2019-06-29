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
    public partial class ImageTestForm : Form
    {
        private Image _image;
        private string _imageFilename;
        private ImageFormat _imageSaveFormat;

        public ImageTestForm()
        {
            InitializeComponent();

            _imageSaveFormat = ImageFormat.Png;
        }

        private void updateTitleBar()
        {
            this.Text = string.Format("[{0}, {1}]", _image.Width, _image.Height);
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            var dlgResult = dlgOpenImageFile.ShowDialog();

            if (dlgResult == DialogResult.OK)
            {
                var filename = dlgOpenImageFile.FileName;
                picImage.Load(filename);
                _image = picImage.Image;
                _imageFilename = filename;
                updateTitleBar();
            }
        }

        private void btnApplyEffect_Click(object sender, EventArgs e)
        {
            pixelateImage();
        }

        private void slider_ValueChanged(object sender, EventArgs e)
        {
            pixelateImage();
        }

        private void pixelateImage()
        {
            if (_image == null) return;

            var bmp = _image as Bitmap;

            var fxBitmap = ImageLib.FX.Pixelate(bmp, slider.Value);

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

    } // END OF CLASS
} // END OF NAMESPACE
