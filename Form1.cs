using System;
using System.Windows.Forms;
using MouseRecorder.Interfaces;
using System.Threading;

namespace MouseRecorder
{
    public partial class Form1 : Form
    {
        private bool isRecording = false;
        private bool isPlaying = false;

        private RecorderData recorderData;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            recorderData = new RecorderData();
            recorderData.data.CollectionChanged += Data_CollectionChanged;
        }

        private void Data_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            // Check if the change is only adding new value
            if (e.NewItems != null && e.NewItems.Count == 1) {
                AddDataToListView((HookData)e.NewItems[0]);

                // Scroll down to the bottom of a ListView
                timelineView.Items[timelineView.Items.Count - 1].EnsureVisible();
            } 
            else {
                // Otherwise, refresh the whole list
                RefreshDataList();
            }
        }

        /// <summary>
        /// Update a ListView
        /// </summary>
        private void RefreshDataList()
        {
            timelineView.Items.Clear();
            foreach (HookData data in recorderData.data)
            {
                AddDataToListView(data);
            }
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

        /// <summary>
        /// Adding data to ListView
        /// </summary>
        /// <param name="data">mouse/keyboard data</param>
        private void AddDataToListView(HookData data)
        {
            if (data is MouseData) {
                AddMouseDataToListView(data as MouseData);
            }
            else if (data is KeyboardData) {
                AddKeyboardDataToListView(data as KeyboardData);
            }
        }

        /// <summary>
        /// Adding mouse data to ListView
        /// </summary>
        /// <param name="data">Mouse data</param>
        private void AddMouseDataToListView(MouseData data)
        {
            timelineView.Items.Add(new ListViewItem(new string[] {
                    "Mouse",
                    (data as MouseData).mouse.ToString(),
                    "X: " + (data as MouseData).point.x + " Y: "+ (data as MouseData).point.y
                }));
        }

        /// <summary>
        /// Adding keyboard data to ListView
        /// </summary>
        /// <param name="data">Keyboard data</param>
        private void AddKeyboardDataToListView(KeyboardData data)
        {
            timelineView.Items.Add(new ListViewItem(new string[] { "Keyboard", "Up", (data as KeyboardData).keyboard.ToString() }));
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            PlayRecorder();
        }

        public void PlayRecorder()
        {
            // TODO: Adding isPlaying statements

            if (isRecording) {
                // Stop first recording
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

                //TODO: create a new work thread, otherwise this will block UI
                Thread.Sleep(1000);
            }

            isPlaying = !isPlaying;
        }
    }
}
