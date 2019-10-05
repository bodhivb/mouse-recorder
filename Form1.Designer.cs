namespace MouseRecorder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxCooldown = new System.Windows.Forms.CheckBox();
            this.checkBoxKeyboard = new System.Windows.Forms.CheckBox();
            this.checkBoxMouseClick = new System.Windows.Forms.CheckBox();
            this.checkBoxMouseMovement = new System.Windows.Forms.CheckBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonRecord = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.checkBoxCooldown);
            this.panel1.Controls.Add(this.checkBoxKeyboard);
            this.panel1.Controls.Add(this.checkBoxMouseClick);
            this.panel1.Controls.Add(this.checkBoxMouseMovement);
            this.panel1.Controls.Add(this.buttonLoad);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonPlay);
            this.panel1.Controls.Add(this.buttonRecord);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 56);
            this.panel1.TabIndex = 1;
            // 
            // checkBoxCooldown
            // 
            this.checkBoxCooldown.AutoSize = true;
            this.checkBoxCooldown.Location = new System.Drawing.Point(551, 30);
            this.checkBoxCooldown.Name = "checkBoxCooldown";
            this.checkBoxCooldown.Size = new System.Drawing.Size(73, 17);
            this.checkBoxCooldown.TabIndex = 3;
            this.checkBoxCooldown.Text = "Cooldown";
            this.checkBoxCooldown.UseVisualStyleBackColor = true;
            // 
            // checkBoxKeyboard
            // 
            this.checkBoxKeyboard.AutoSize = true;
            this.checkBoxKeyboard.Location = new System.Drawing.Point(551, 11);
            this.checkBoxKeyboard.Name = "checkBoxKeyboard";
            this.checkBoxKeyboard.Size = new System.Drawing.Size(71, 17);
            this.checkBoxKeyboard.TabIndex = 7;
            this.checkBoxKeyboard.Text = "Keyboard";
            this.checkBoxKeyboard.UseVisualStyleBackColor = true;
            // 
            // checkBoxMouseClick
            // 
            this.checkBoxMouseClick.AutoSize = true;
            this.checkBoxMouseClick.Checked = true;
            this.checkBoxMouseClick.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMouseClick.Location = new System.Drawing.Point(412, 30);
            this.checkBoxMouseClick.Name = "checkBoxMouseClick";
            this.checkBoxMouseClick.Size = new System.Drawing.Size(83, 17);
            this.checkBoxMouseClick.TabIndex = 6;
            this.checkBoxMouseClick.Text = "Mouse click";
            this.checkBoxMouseClick.UseVisualStyleBackColor = true;
            // 
            // checkBoxMouseMovement
            // 
            this.checkBoxMouseMovement.AutoSize = true;
            this.checkBoxMouseMovement.Location = new System.Drawing.Point(412, 11);
            this.checkBoxMouseMovement.Name = "checkBoxMouseMovement";
            this.checkBoxMouseMovement.Size = new System.Drawing.Size(110, 17);
            this.checkBoxMouseMovement.TabIndex = 2;
            this.checkBoxMouseMovement.Text = "Mouse movement";
            this.checkBoxMouseMovement.UseVisualStyleBackColor = true;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(284, 11);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 33);
            this.buttonLoad.TabIndex = 5;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(203, 11);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 33);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(12, 11);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 33);
            this.buttonPlay.TabIndex = 3;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonRecord
            // 
            this.buttonRecord.Location = new System.Drawing.Point(93, 11);
            this.buttonRecord.Name = "buttonRecord";
            this.buttonRecord.Size = new System.Drawing.Size(75, 33);
            this.buttonRecord.TabIndex = 2;
            this.buttonRecord.Text = "Record";
            this.buttonRecord.UseVisualStyleBackColor = true;
            this.buttonRecord.Click += new System.EventHandler(this.buttonRecord_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 261);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(690, 300);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Mouse Recorder";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonRecord;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.CheckBox checkBoxCooldown;
        private System.Windows.Forms.CheckBox checkBoxKeyboard;
        private System.Windows.Forms.CheckBox checkBoxMouseClick;
        private System.Windows.Forms.CheckBox checkBoxMouseMovement;
    }
}

