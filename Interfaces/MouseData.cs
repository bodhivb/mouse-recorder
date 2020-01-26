using System.Windows.Forms;

namespace MouseRecorder.Interfaces
{
    public class MouseData : HookData
    {
        public MouseButtons mouse;
        public MouseHook.POINT point;

        public MouseData(int index, MouseHook.POINT point, MouseButtons value) : base (index)
        {
            this.mouse = value;
            this.point = point;
        }
    }
}
