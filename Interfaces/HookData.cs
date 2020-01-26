namespace MouseRecorder.Interfaces
{
    public abstract class HookData
    {
        public int id;
        public int time;

        protected HookData (int index)
        {
            this.id = index;
            //this.time = DateTime.Now;
        }
    }
}
