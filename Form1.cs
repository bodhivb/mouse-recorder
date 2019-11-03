using System;
using System.Windows.Forms;

namespace MouseRecorder
{
    public partial class Form1 : Form
    {
        private bool isRecording = false;

        private MouseHook mh = null;
        private KeyboardHook kh = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            if (!isRecording)
            {
                //Start record mouse/keyboard
                if (checkBoxKeyboard.Checked) StartKeyboardRecord();
                if (checkBoxMouseClick.Checked) StartMouseRecord();
                buttonRecord.Text = "Stop record";
            }
            else
            {
                //Stop record mouse/keyboard
                if (kh != null) StopKeyboardRecord();
                if (mh != null) StopMouseRecord();
                buttonRecord.Text = "Record";
            }

            isRecording = !isRecording;
        }



        private void buttonPlay_Click(object sender, EventArgs e)
        {
           
        }

        private void Kh_KeyboardDownEvent(object sender, Keys key)
        {
            MessageBox.Show("Down: " + key);
        }

        private void Kh_KeyboardUpEvent(object sender, Keys key)
        {
            MessageBox.Show("Up: " + key);
        }

        private void Mh_MouseDownEvent(object sender, MouseButtons key)
        {
            MessageBox.Show("Mouse down: " + key);
        }

        private void Mh_MouseUpEvent(object sender, MouseButtons key)
        {
            MessageBox.Show("Mouse up: " + key);
        }


        private void StartKeyboardRecord()
        {
            if (kh == null)
            {
                kh = new KeyboardHook();
                kh.SetHook();
                kh.KeyboardDownEvent += Kh_KeyboardDownEvent;
                kh.KeyboardUpEvent += Kh_KeyboardUpEvent;
            }
        }

        private void StopKeyboardRecord()
        {
            if (kh != null)
            {
                kh.UnHook();
                kh = null;
            }
        }

        private void StartMouseRecord()
        {
            if (mh == null)
            {
                mh = new MouseHook();
                mh.SetHook();
                mh.MouseDownEvent += Mh_MouseDownEvent;
                mh.MouseUpEvent += Mh_MouseUpEvent;
            }
        }

        private void StopMouseRecord()
        {
            if (mh != null)
            {
                mh.UnHook();
                mh = null;
            }
        }
    }
}
