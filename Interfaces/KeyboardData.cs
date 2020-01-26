using System.Windows.Forms;

namespace MouseRecorder.Interfaces
{
    public class KeyboardData : HookData
    {
        public Keys keyboard;

        public KeyboardData (int index, Keys value) : base (index)
        {
            this.keyboard = value;
        }
    }
}
