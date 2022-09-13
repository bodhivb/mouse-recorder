namespace MouseRecorder.Events
{
    public class PlayEvent
    {
        private static uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private static uint MOUSEEVENTF_LEFTUP = 0x0004;
        private static uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private static uint MOUSEEVENTF_RIGHTUP = 0x0010;

        private static uint KEYEVENTF_EXTENDEDKEY = 0x0001;
        private static uint KEYEVENTF_KEYUP = 0x0002;


        public static void PlayMouse(Interfaces.MouseData m)
        {
            // Set mouse position
            WinUserDll.SetCursorPos(m.point.x, m.point.y);

            switch (m.mouse)
            {
                case System.Windows.Forms.MouseButtons.Left:
                    WinUserDll.mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, m.point.x, m.point.y, 0, 0);
                    break;

                case System.Windows.Forms.MouseButtons.Right:
                    WinUserDll.mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, m.point.x, m.point.y, 0, 0);
                    break;
            }
        }

        public static void PlayKeyboard (Interfaces.KeyboardData k)
        {
            // Simulate a key press
            WinUserDll.keybd_event((byte)k.keyboard, 0, KEYEVENTF_EXTENDEDKEY, 0);
            // Simulate a key release
            WinUserDll.keybd_event((byte)k.keyboard, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
        }
    }
}
