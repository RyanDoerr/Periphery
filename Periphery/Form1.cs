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

namespace Periphery
{
    public partial class mnWnd_periphery : Form
    {
        private int quality = 100;
        private grdForm l, r;
        public mnWnd_periphery()
        {
            InitializeComponent();
        }

        private void mnWnd_periphery_Load(object sender, EventArgs e)
        {

        }
        Bitmap bmpOut;
        Bitmap bmpScreenshot;
        Graphics gfxScreenShot;
        MemoryStream msIn, msOut,ms;
        private void CaptureScreen()
        {
            using (var bmpScreenCapture = new Bitmap(Screen.PrimaryScreen.Bounds.Width/quality, Screen.PrimaryScreen.Bounds.Height/quality))
            {
                using (var g = Graphics.FromImage(bmpScreenCapture))
                {
                    g.CopyFromScreen(Screen.PrimaryScreen.Bounds.X/quality, Screen.PrimaryScreen.Bounds.Y/quality, 0, 0, bmpScreenCapture.Size, CopyPixelOperation.SourceCopy);
                    ms = new MemoryStream();
                    if (bmpScreenCapture != null)
                    {
                        bmpScreenCapture.Save(ms, ImageFormat.Bmp);
                        bmpOut = new Bitmap(ms);
                    }
                }  
            }
        }
        private Color GetRGBAverageForPixelRange(int istartRange, int iendRange, Bitmap oBitmap)
        {
            double dRtnVal = 0;
            Color oTempColor;
            int i, j;
            for ( int iCounter = istartRange; iCounter < iendRange; iCounter++)
            {
                i = (iCounter % (oBitmap.Width));
                j = (iCounter / (oBitmap.Width));
                if ( i >= 0 && j >= 0 && i < oBitmap.Width && j < oBitmap.Height)
                {
                    oTempColor = oBitmap.GetPixel(i, j);
                    dRtnVal = dRtnVal + oTempColor.ToArgb();
                }
              
            }
            Console.WriteLine(dRtnVal);
            return Color.FromArgb((int)dRtnVal);
        }
        System.Timers.Timer aTimer;
            
        private Color GetColorFast(Bitmap b)
        {
            BitmapData bData = new BitmapData();
            if (b != null)
            {
                bData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            }
            if (bData != null && b != null)
            {

                int stride = bData.Stride;
                IntPtr Scan0 = bData.Scan0;

                long[] totals = new long[] { 0, 0, 0 };

                int width = b.Width;
                int height = b.Height;

                unsafe
                {
                    byte* p = (byte*)(void*)Scan0;

                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            for (int color = 0; color < 3; color++)
                            {
                                int idx = (y * stride) + x * 4 + color;

                                totals[color] += p[idx];
                            }
                        }
                    }
                }
                int avgB = (int)totals[0] / (width * height);
                int avgG = (int)totals[1] / (width * height);
                int avgR = (int)totals[2] / (width * height);
                bmpOut = null;
                return Color.FromArgb(avgR, avgG, avgB);
            }
            return Color.Black;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            CaptureScreen(); 
        }

        private void btnCalculateAverage_Click(object sender, EventArgs e)
        {
            if (bmpOut != null)
                btnCalculateAverage.BackColor = GetColorFast(bmpOut);
        }
        private void go(Object source, System.Timers.ElapsedEventArgs e)
        {
            CaptureScreen();
            Color c = GetColorFast(bmpOut);
            r.setTransitionColor(c);
            l.setTransitionColor(c);
            r.BackColor = l.BackColor = c;
        }
        private void btn_Start_Simulation_Click(object sender, EventArgs e)
        {
            aTimer = new System.Timers.Timer();
            aTimer.Interval = 50;
            aTimer.Enabled = true;
            aTimer.Elapsed += go;
        }

        private void btn_Create_Periphery_Click(object sender, EventArgs e)
        {
            if (l == null)
            {
                l = new grdForm();
                l.Text = "Left Periphery";
                l.setId("left");
                l.Show();
                
            }
            if (r == null)
            {
                r = new grdForm();
                r.Text = "Right Periphery";
                r.setId("right");
                r.Show();
                
            }
        }
    }
}
