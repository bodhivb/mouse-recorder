using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MouseRecorder
{
    class KeyboardHook
    {
        private int hookId;
        public WinUserDll.HookProc hookProc;


        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN    = 0x0100;
        private const int WM_KEYUP      = 0x0101;


        public void SetHook()
        {
            hookProc = new WinUserDll.HookProc(KeyboardHookProc);
            hookId = WinUserDll.SetWindowsHookEx(WH_KEYBOARD_LL, hookProc, IntPtr.Zero, 0);
        }

        public void UnHook()
        {
            WinUserDll.UnhookWindowsHookEx(hookId);
        }

        private int KeyboardHookProc (int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                if (wParam == (IntPtr)WM_KEYDOWN)
                {
                    if (KeyboardDownEvent != null) KeyboardDownEvent(this, (Keys) Marshal.ReadInt32(lParam));
                }
                else if (wParam == (IntPtr)WM_KEYUP)
                {
                    if (KeyboardUpEvent != null) KeyboardUpEvent(this, (Keys) Marshal.ReadInt32(lParam));
                }
            }
            
            return WinUserDll.CallNextHookEx(hookId, nCode, wParam, lParam);
        }

        public delegate void KeyboardHandler(object sender, Keys key);
        public event KeyboardHandler KeyboardDownEvent;
        public event KeyboardHandler KeyboardUpEvent;
    }
}
