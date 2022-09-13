using System;
using System.Windows.Forms;
using MouseRecorder.Interfaces;
using System.Threading;

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
            recorderData.OnNewData += AddData;
        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            Recording();
        }

        private void Recording()
        {
            if (!isRecording)
            {
                // Start record mouse/keyboard
                //TODO CALL DATA EMPTHY
                timelineView.Items.Clear();
                if (checkBoxKeyboard.Checked) recorderData.StartKeyboardRecord();
                if (checkBoxMouseClick.Checked) recorderData.StartMouseRecord();
                buttonRecord.Text = "Stop record";
            }
            else
            {
                // Stop record mouse/keyboard
                recorderData.StopKeyboardRecord();
                recorderData.StopMouseRecord();
                buttonRecord.Text = "Record";
            }

            isRecording = !isRecording;
        }


        private void AddData(HookData data)
        {
            if (data is MouseData)
            {
                timelineView.Items.Add(new ListViewItem(new string[] {
                    "Mouse",
                    (data as MouseData).mouse.ToString(),
                    "X: " + (data as MouseData).point.x + " Y: "+ (data as MouseData).point.y
                }));

            } else if (data is KeyboardData)
            {
                timelineView.Items.Add(new ListViewItem(new string[] { "Keyboard", "Up", (data as KeyboardData).keyboard.ToString() }));
            }

            //Set items scroll to bottom
            timelineView.Items[timelineView.Items.Count - 1].EnsureVisible();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            PlayRecorder();
        }

        public void PlayRecorder()
        {
            if (isRecording)
            {
                //Stop first recording
                Recording();
            }

            foreach (HookData data in recorderData.data)
            {
                if (data is MouseData)
                {
                    MouseRecorder.Events.PlayEvent.PlayMouse(data as MouseData);
                }
                else if (data is KeyboardData)
                {
                    MouseRecorder.Events.PlayEvent.PlayKeyboard(data as KeyboardData);
                }

                Thread.Sleep(100);
            }
        }
    }
}
