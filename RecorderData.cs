using System;
using System.Windows.Forms;
using System.Collections.Generic;
using MouseRecorder.Interfaces;

namespace MouseRecorder
{
    class RecorderData
    {
        private MouseHook mh = null;
        private KeyboardHook kh = null;

        public List<HookData> data = new List<HookData>();

        //Event
        public delegate void DataAction(HookData data);
        public event DataAction OnNewData; 

        public RecorderData()
        {
            OnNewData += (d) => data.Add(d);
        }

        public void StartKeyboardRecord() {
            if (kh == null) {
                data = new List<HookData>();
                kh = new KeyboardHook();
                kh.SetHook();
                kh.KeyboardDownEvent += Kh_KeyboardDownEvent;
                kh.KeyboardUpEvent += Kh_KeyboardUpEvent;
            }
        }

        public void StopKeyboardRecord() {
            if (kh != null) {
                kh.UnHook();
                kh = null;
            }
        }

        public void StartMouseRecord() {
            if (mh == null) {
                data = new List<HookData>();
                mh = new MouseHook();
                mh.SetHook();
                mh.MouseDownEvent += Mh_MouseDownEvent;
                mh.MouseUpEvent += Mh_MouseUpEvent;
            }
        }

        public void StopMouseRecord() {
            if (mh != null) {
                mh.UnHook();
                mh = null;
            }
        }


        private void Kh_KeyboardDownEvent(object sender, Keys key) {
            //data.Add(new KeyboardData(data.Count, key));
        }

        private void Kh_KeyboardUpEvent(object sender, Keys key) {
            OnNewData(new KeyboardData(data.Count, key));
        }

        private void Mh_MouseDownEvent(object sender, MouseHook.POINT pt, MouseButtons key) {
            //data.Add(new MouseData(data.Count, key));
        }

        private void Mh_MouseUpEvent(object sender, MouseHook.POINT pt, MouseButtons key) {
            OnNewData(new MouseData(data.Count, pt, key));
        }

    }
}
