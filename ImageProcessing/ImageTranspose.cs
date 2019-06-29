using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ImageProcessing
{
    public static class ImageTranspose
    {
        public static Bitmap RotateFlip(Bitmap sourceBmap, RotateFlipType rotateFlipType)
        {
            Bitmap bmap = (Bitmap)sourceBmap.Clone();

            bmap.RotateFlip(rotateFlipType);
            return bmap;
        }

        public static Bitmap DrawOutCropArea(Bitmap sourceBmap, int xPosition, int yPosition, int width, int height)
        {
            Bitmap bmap = (Bitmap)sourceBmap.Clone();

            Graphics gr = Graphics.FromImage(bmap);
            Brush cBrush = new Pen(Color.FromArgb(150, Color.White)).Brush;
            Rectangle rect1 = new Rectangle(0, 0, bmap.Width, yPosition);
            Rectangle rect2 = new Rectangle(0, yPosition, xPosition, height);
            Rectangle rect3 = new Rectangle
            (0, (yPosition + height), bmap.Width, bmap.Height);
            Rectangle rect4 = new Rectangle((xPosition + width), yPosition, (bmap.Width - xPosition - width), height);
            gr.FillRectangle(cBrush, rect1);
            gr.FillRectangle(cBrush, rect2);
            gr.FillRectangle(cBrush, rect3);
            gr.FillRectangle(cBrush, rect4);
            return bmap;
        }

        public static Bitmap Crop(Bitmap sourceBmap, int xPosition, int yPosition, int width, int height)
        {
            Bitmap bmap = (Bitmap)sourceBmap.Clone();

            if (xPosition + width > bmap.Width)
                width = bmap.Width - xPosition;
            if (yPosition + height > bmap.Height)
                height = bmap.Height - yPosition;
            Rectangle rect = new Rectangle(xPosition, yPosition, width, height);
            bmap = (Bitmap)bmap.Clone(rect, bmap.PixelFormat);
            return bmap;
        }

        public static Bitmap Resize(Bitmap sourceBmap, int newWidth, int newHeight)
        {
            if (newWidth == 0 || newHeight == 0)
            {
                return (Bitmap)sourceBmap.Clone();
            }
            else
            {
                Bitmap temp = (Bitmap)sourceBmap.Clone();
                Bitmap bmap = new Bitmap(newWidth, newHeight, temp.PixelFormat);

                double nWidthFactor = (double)temp.Width / (double)newWidth;
                double nHeightFactor = (double)temp.Height / (double)newHeight;

                double fx, fy, nx, ny;
                int cx, cy, fr_x, fr_y;
                Color color1 = new Color();
                Color color2 = new Color();
                Color color3 = new Color();
                Color color4 = new Color();
                byte nRed, nGreen, nBlue;

                byte bp1, bp2;

                for (int x = 0; x < bmap.Width; ++x)
                {
                    for (int y = 0; y < bmap.Height; ++y)
                    {

                        fr_x = (int)Math.Floor(x * nWidthFactor);
                        fr_y = (int)Math.Floor(y * nHeightFactor);
                        cx = fr_x + 1;
                        if (cx >= temp.Width) cx = fr_x;
                        cy = fr_y + 1;
                        if (cy >= temp.Height) cy = fr_y;
                        fx = x * nWidthFactor - fr_x;
                        fy = y * nHeightFactor - fr_y;
                        nx = 1.0 - fx;
                        ny = 1.0 - fy;

                        color1 = temp.GetPixel(fr_x, fr_y);
                        color2 = temp.GetPixel(cx, fr_y);
                        color3 = temp.GetPixel(fr_x, cy);
                        color4 = temp.GetPixel(cx, cy);

                        // Blue
                        bp1 = (byte)(nx * color1.B + fx * color2.B);
                        bp2 = (byte)(nx * color3.B + fx * color4.B);
                        nBlue = (byte)(ny * (double)(bp1) + fy * (double)(bp2));

                        // Green
                        bp1 = (byte)(nx * color1.G + fx * color2.G);
                        bp2 = (byte)(nx * color3.G + fx * color4.G);
                        nGreen = (byte)(ny * (double)(bp1) + fy * (double)(bp2));

                        // Red
                        bp1 = (byte)(nx * color1.R + fx * color2.R);
                        bp2 = (byte)(nx * color3.R + fx * color4.R);
                        nRed = (byte)(ny * (double)(bp1) + fy * (double)(bp2));

                        bmap.SetPixel(x, y, System.Drawing.Color.FromArgb(255, nRed, nGreen, nBlue));
                    }
                }
                return bmap;
            }
        }

    } // END OF CLASS
} // END OF NAMESPACE
