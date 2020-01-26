using System.Windows.Forms;

namespace MouseRecorder.Interfaces
{
    public class MouseData : HookData
    {
        public MouseButtons mouse;

        public MouseData(int index, MouseButtons value) : base (index)
        {
            this.mouse = value;
        }
    }
}
