using System;
using System.Runtime.InteropServices;

namespace OffDisplay
{
    internal class Program
    {
        [DllImport("user32.dll")]
        public static extern int PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);

        const uint WM_SYSCOMMAND = 0x112;
        const int SC_MONITORPOWER = 0xF170;
        const int MONITOR_OFF = 2;
        static void Main(string[] args)
        {
            PostMessage((IntPtr)0xffff, WM_SYSCOMMAND, SC_MONITORPOWER, MONITOR_OFF);
        }
    }
}
