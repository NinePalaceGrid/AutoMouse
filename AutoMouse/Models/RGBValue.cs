using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AutoMouse.Models
{
    [Serializable]
    public class RGBValue
    {
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
        public ColorHSV HSVValue { get; set; }
        public string HexColor { get; set; }
        public string RGBStr { get; set; }
        public string HSVStr { get; set; }

        public RGBValue(int r, int g, int b)
        {
            R = r;
            G = g;
            B = b;
            SetOtherColorSpace();
        }

        public override string ToString()
        {
            return $"{R},{G},{B}";
        }

        public void setColor(Point p)
        {
            int c = getPixelColor(p);
            R = (c & 0xFF);  // 转换R 
            G = (c & 0xFF00) / 256;  // 转换G 
            B = (c & 0xFF0000) / 65536;  // 转换B 
            SetOtherColorSpace();
        }

        public void SetOtherColorSpace()
        {
            HexColor = parseHexColor(R, G, B);
            RGBStr = ToString();
            HSVValue = RgbToHsv(R, G, B);
            HSVStr = HSVValue.ToString();
        }

        public static RGBValue getColor(Point p)
        {
            return parseColor(getPixelColor(p));
        }

        public static RGBValue parseColor(int c)
        {
            int r = (c & 0xFF);  // 转换R 
            int g = (c & 0xFF00) >> 8;  // 转换G 
            int b = (c & 0xFF0000) >> 16;  // 转换B 
            return new RGBValue(r, g, b);
        }

        // 输出16进制颜色
        public static string parseHexColor(int r, int g, int b)
        {
            return "#" + r.ToString("X").PadLeft(2, '0') + g.ToString("X").PadLeft(2, '0') + b.ToString("X").PadLeft(2, '0');
        }

        public static ColorHSV RgbToHsv(int r, int g, int b)
        {
            float min, max, tmp, H, S, V;
            float R = r * 1.0f / 255, G = g * 1.0f / 255, B = b * 1.0f / 255;
            tmp = Math.Min(R, G);
            min = Math.Min(tmp, B);
            tmp = Math.Max(R, G);
            max = Math.Max(tmp, B);
            // H
            H = 0;
            if (max == min)
            {
                H = 0;
            }
            else if (max == R && G > B)
            {
                H = 60 * (G - B) * 1.0f / (max - min) + 0;
            }
            else if (max == R && G < B)
            {
                H = 60 * (G - B) * 1.0f / (max - min) + 360;
            }
            else if (max == G)
            {
                H = H = 60 * (B - R) * 1.0f / (max - min) + 120;
            }
            else if (max == B)
            {
                H = H = 60 * (R - G) * 1.0f / (max - min) + 240;
            }
            // S
            if (max == 0)
            {
                S = 0;
            }
            else
            {
                S = (max - min) * 1.0f / max;
            }
            // V
            V = max;
            return new ColorHSV((int)H, (int)(S * 255), (int)(V * 255));
        }

        [DllImport("user32.dll")]  // 取设备场景 
        public static extern IntPtr GetDC(IntPtr hwnd);//返回设备场景句柄 
        [System.Runtime.InteropServices.DllImport("User32.dll")]
        static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);
        [DllImport("gdi32.dll")]  // 取指定点颜色 
        public static extern int GetPixel(IntPtr hdc, int x, int y);

        public static int getPixelColor(Point p)
        {
            IntPtr hdc = GetDC(IntPtr.Zero);//取到设备场景(0就是全屏的设备场景) 
            int c = GetPixel(hdc, (int)p.X, (int)p.Y);//取指定点颜色 
            ReleaseDC(IntPtr.Zero, hdc);
            return c;
        }
    }

    /// <summary>
    /// H 色相 \ S 饱和度(纯度) \ V 明度 颜色模型 
    /// </summary>
    [Serializable]
    public class ColorHSV
    {
        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="h"></param>
        /// <param name="s"></param>
        /// <param name="v"></param>
        public ColorHSV(int h, int s, int v)
        {
            this._h = h;
            this._s = s;
            this._v = v;
        }

        private int _h;
        private int _s;
        private int _v;

        /// <summary>
        /// 色相
        /// </summary>
        public int H
        {
            get { return this._h; }
            set
            {
                this._h = value;
                this._h = this._h > 360 ? 360 : this._h;
                this._h = this._h < 0 ? 0 : this._h;
            }
        }

        /// <summary>
        /// 饱和度(纯度)
        /// </summary>
        public int S
        {
            get { return this._s; }
            set
            {
                this._s = value;
                this._s = this._s > 255 ? 255 : this._s;
                this._s = this._s < 0 ? 0 : this._s;
            }
        }

        /// <summary>
        /// 明度
        /// </summary>
        public int V
        {
            get { return this._v; }
            set
            {
                this._v = value;
                this._v = this._v > 255 ? 255 : this._v;
                this._v = this._v < 0 ? 0 : this._v;
            }
        }

        public override string ToString()
        {
            return $"{H},{S},{V}";
        }
    }
}
