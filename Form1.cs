using System;
using System.Windows.Forms;
using MouseRecorder.Interfaces;

namespace MouseRecorder
{
    public partial class Form1 : Form
    {
        private bool isRecording = false;
        private RecorderData recorderData;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            recorderData = new RecorderData();
            recorderData.OnNewData += addData;
        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            if (!isRecording)
            {
                //Start record mouse/keyboard
                //TODO CALL DATA EMPTHY
                timelineView.Items.Clear();
                if (checkBoxKeyboard.Checked) recorderData.StartKeyboardRecord();
                if (checkBoxMouseClick.Checked) recorderData.StartMouseRecord();
                buttonRecord.Text = "Stop record";
            }
            else
            {
                //Stop record mouse/keyboard
                recorderData.StopKeyboardRecord();
                recorderData.StopMouseRecord();
                buttonRecord.Text = "Record";
            }

            isRecording = !isRecording;
        }


        private void addData(HookData data)
        {
            if (data is MouseData)
            {
                timelineView.Items.Add(new ListViewItem(new string[] { "Mouse", "Up", (data as MouseData).mouse.ToString() }));

            } else if (data is KeyboardData)
            {
                timelineView.Items.Add(new ListViewItem(new string[] { "Keyboard", "Up", (data as KeyboardData).keyboard.ToString() }));
            }

            timelineView.Items[timelineView.Items.Count - 1].EnsureVisible();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            
        }
    }
}
