using System.Runtime.InteropServices;

namespace MouseRecorder.Events
{
    //Mouse source code: https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-mouse_event
    //Keyboard source code: https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-keybd_event
    public class WinUserDll
    {
        [DllImport("user32")]
        public static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);
    }
}
