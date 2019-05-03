using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;

namespace AutoMouse.Models
{
    [Serializable]
    public class MouseKeyHook
    {
        

        [DllImport("user32.dll", EntryPoint = "GetWindowText")]
        public static extern int GetWindowText(int hwnd, StringBuilder lpString, int cch);

        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        public extern static IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern int ShowWindow(IntPtr hwnd, int nCmdShow);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);

        private delegate bool WNDENUMPROC(IntPtr hWnd, int lParam);

        //用来遍历所有窗口 
        [DllImport("user32.dll")]
        private static extern bool EnumWindows(WNDENUMPROC lpEnumFunc, int lParam);

        //获取窗口Text 
        [DllImport("user32.dll")]
        private static extern int GetWindowTextW(IntPtr hWnd, [MarshalAs(UnmanagedType.LPWStr)]StringBuilder lpString, int nMaxCount);

        //获取窗口类名 
        [DllImport("user32.dll")]
        private static extern int GetClassNameW(IntPtr hWnd, [MarshalAs(UnmanagedType.LPWStr)]StringBuilder lpString, int nMaxCount);

        //自定义一个类，用来保存句柄信息，在遍历的时候，随便也用空上句柄来获取些信息，呵呵 
        public struct WindowInfo
        {
            public IntPtr hWnd;
            public string szWindowName;
            public string szClassName;
        }

        public static WindowInfo[] GetAllDesktopWindows()
        {
            //用来保存窗口对象 列表
            List<WindowInfo> wndList = new List<WindowInfo>();

            //enum all desktop windows 
            EnumWindows(delegate (IntPtr hWnd, int lParam)
            {
                WindowInfo wnd = new WindowInfo();
                StringBuilder sb = new StringBuilder(256);

                //get hwnd 
                wnd.hWnd = hWnd;

                //get window name  
                GetWindowTextW(hWnd, sb, sb.Capacity);
                wnd.szWindowName = sb.ToString();

                //get window class 
                GetClassNameW(hWnd, sb, sb.Capacity);
                wnd.szClassName = sb.ToString();

                //add it into list 
                wndList.Add(wnd);
                return true;
            }, 0);

            return wndList.ToArray();
        }

        public static IntPtr GetWindowHandle(string winName)
        {
            IntPtr hwnd = new IntPtr(0);
            if (winName.Length > 0)
            {
                hwnd = MouseKeyHook.FindWindow(null, winName);
                if (hwnd.ToInt32() != 0)
                {
                    return hwnd;
                }
                else
                {
                    foreach (var i in MouseKeyHook.GetAllDesktopWindows())
                    {
                        if (i.szWindowName.IndexOf(winName) >= 0)
                        {
                            return i.hWnd;
                        }
                    }
                }
            }
            return hwnd;
        }

        public static Point TransferCoordinate(IntPtr hwnd, int loc_x, int loc_y)
        {
            RECT rc = new RECT();
            MouseKeyHook.GetWindowRect(hwnd, ref rc);
            int width = rc.Right - rc.Left;                        //窗口的宽度
            int height = rc.Bottom - rc.Top;                   //窗口的高度
            int x = rc.Left;
            int y = rc.Top;
            if (loc_x > width || loc_y > height)
            {
                throw new Exception("警告，窗口大小小于设定值！");
            }
            return new Point(x + loc_x, y + loc_y);
        }

        public static Point TransferCoordinate(IntPtr hwnd, Point p)
        {
            return TransferCoordinate(hwnd, p.X, p.Y);
        }

        public static void mouseMoveTo(InputSimulator sim, double x, double y)
        {
            sim.Mouse
               .MoveMouseTo(x * 65535 / Screen.PrimaryScreen.Bounds.Width,
               y * 65535 / Screen.PrimaryScreen.Bounds.Height);
        }

        public static void mouseMoveTo(InputSimulator sim, Point p)
        {
            sim.Mouse
               .MoveMouseTo(p.X * 65535 / Screen.PrimaryScreen.Bounds.Width,
               p.Y * 65535 / Screen.PrimaryScreen.Bounds.Height);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public int Left;                             //最左坐标
        public int Top;                             //最上坐标
        public int Right;                           //最右坐标
        public int Bottom;                        //最下坐标
    }
}
