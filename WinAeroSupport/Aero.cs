using System;
using System.Runtime.InteropServices;

namespace AeroSupport {
    public static class Aero {
        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarinset);
        [StructLayout(LayoutKind.Sequential)]
        public struct MARGINS {
            public int Right;
            public int left;
            public int Top;
            public int Bottom;
        }
        public static void AreoIt(IntPtr hwnd) {// using: AeroIt(Handle)
            //easy:)
            MARGINS margins = new MARGINS();
            margins.left = 1;
            margins.Right = -1;
            margins.Top = -1;
            margins.Bottom = -1;
            int result = DwmExtendFrameIntoClientArea(hwnd, ref margins);
        }
    }
}
