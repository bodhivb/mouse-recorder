using System;
using System.Windows.Forms;

namespace MouseRecorder
{
    public partial class Form1 : Form
    {
        private bool isRecording = false;


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
                buttonRecord.Text = "Stop record";
            }
            else
            {
                //Stop record mouse/keyboard
                if (kh != null) StopKeyboardRecord();
                buttonRecord.Text = "Record";
            }

            isRecording = !isRecording;
        }



        private void buttonPlay_Click(object sender, EventArgs e)
        {

        }

        private void Kh_KeyboardDownEvent(object sender, Keys key)
        {
            MessageBox.Show(key + "");
        }


        private void StartKeyboardRecord()
        {
            if (kh == null)
            {
                kh = new KeyboardHook();
                kh.SetHook();
                kh.KeyboardDownEvent += Kh_KeyboardDownEvent;
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
    }
}
