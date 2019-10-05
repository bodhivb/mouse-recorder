using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MouseRecorder
{
    class KeyboardHook
    {
        private int hookId;
        public WinUserDll.HookProc hookProc;


        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;

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
            if (wParam == (IntPtr) WM_KEYDOWN)
            {
                MessageBox.Show("key pressed " + (Keys)Marshal.ReadInt32(lParam));
            }
            return WinUserDll.CallNextHookEx(hookId, nCode, wParam, lParam);
        }
    }
}
