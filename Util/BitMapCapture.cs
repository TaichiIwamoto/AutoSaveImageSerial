using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSaveImageSerial.Util
{
    internal static class BitMapCapture
    {
        public static Bitmap RectangleCapture(int x1, int y1, int x2, int y2)
        {
            Rectangle rect = new Rectangle(x1, y1, x2 - x1, y2 - y1);
            Bitmap bmp = new Bitmap(rect.Width, rect.Height);
            Graphics graphics = Graphics.FromImage(bmp);
            graphics.CopyFromScreen(rect.X, rect.Y, 0, 0, rect.Size);
            graphics.Dispose();
            return bmp;
        }
    }
}
