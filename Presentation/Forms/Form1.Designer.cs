namespace TimeTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            StartButton = new Button();
            StopButton = new Button();
            TimeDisplay = new Label();
            ProjectName = new TextBox();
            TaskName = new TextBox();
            TaskDescription = new TextBox();
            SaveButton = new Button();
            TaskStatus = new TextBox();
            ProjectListBox = new ListBox();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.BackColor = SystemColors.HotTrack;
            StartButton.FlatAppearance.BorderSize = 0;
            StartButton.FlatStyle = FlatStyle.Flat;
            StartButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            StartButton.ForeColor = Color.Transparent;
            StartButton.Location = new Point(149, 143);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(50, 30);
            StartButton.TabIndex = 0;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += startTimeButton_Click;
            // 
            // StopButton
            // 
            StopButton.BackColor = Color.Firebrick;
            StopButton.FlatAppearance.BorderColor = Color.Red;
            StopButton.FlatAppearance.BorderSize = 0;
            StopButton.FlatStyle = FlatStyle.Flat;
            StopButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            StopButton.ForeColor = SystemColors.ButtonHighlight;
            StopButton.Location = new Point(205, 143);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(50, 30);
            StopButton.TabIndex = 1;
            StopButton.Text = "Stop";
            StopButton.UseVisualStyleBackColor = false;
            StopButton.Click += saveButton_Click;
            // 
            // TimeDisplay
            // 
            TimeDisplay.AutoSize = true;
            TimeDisplay.BackColor = SystemColors.ControlLightLight;
            TimeDisplay.BorderStyle = BorderStyle.FixedSingle;
            TimeDisplay.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TimeDisplay.Location = new Point(149, 71);
            TimeDisplay.Name = "TimeDisplay";
            TimeDisplay.Padding = new Padding(15);
            TimeDisplay.Size = new Size(187, 69);
            TimeDisplay.TabIndex = 2;
            TimeDisplay.Text = "00:00:00.00";
            TimeDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProjectName
            // 
            ProjectName.Location = new Point(88, 232);
            ProjectName.Name = "ProjectName";
            ProjectName.PlaceholderText = "Project";
            ProjectName.Size = new Size(100, 23);
            ProjectName.TabIndex = 3;
            // 
            // TaskName
            // 
            TaskName.Location = new Point(149, 261);
            TaskName.Name = "TaskName";
            TaskName.PlaceholderText = "Task";
            TaskName.Size = new Size(100, 23);
            TaskName.TabIndex = 4;
            // 
            // TaskDescription
            // 
            TaskDescription.Location = new Point(149, 290);
            TaskDescription.Name = "TaskDescription";
            TaskDescription.PlaceholderText = "Description";
            TaskDescription.Size = new Size(100, 23);
            TaskDescription.TabIndex = 10;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.ForestGreen;
            SaveButton.ForeColor = SystemColors.ButtonFace;
            SaveButton.Location = new Point(88, 348);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 34);
            SaveButton.TabIndex = 8;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += saveButton_Click;
            // 
            // TaskStatus
            // 
            TaskStatus.Location = new Point(149, 319);
            TaskStatus.Name = "TaskStatus";
            TaskStatus.PlaceholderText = "Status";
            TaskStatus.Size = new Size(100, 23);
            TaskStatus.TabIndex = 9;
            // 
            // ProjectListBox
            // 
            ProjectListBox.FormattingEnabled = true;
            ProjectListBox.ItemHeight = 15;
            ProjectListBox.Location = new Point(278, 188);
            ProjectListBox.Name = "ProjectListBox";
            ProjectListBox.Size = new Size(242, 154);
            ProjectListBox.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(520, 471);
            Controls.Add(ProjectListBox);
            Controls.Add(TaskStatus);
            Controls.Add(SaveButton);
            Controls.Add(TaskDescription);
            Controls.Add(TaskName);
            Controls.Add(ProjectName);
            Controls.Add(TimeDisplay);
            Controls.Add(StopButton);
            Controls.Add(StartButton);
            Name = "Form1";
            Text = "          ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartButton;
        private Button StopButton;
        public Label TimeDisplay;
        
        private TextBox ProjectName;
        private TextBox TaskName;
        private TextBox TaskDescription;
        private TextBox TaskStatus;

        private Button SaveButton;
        private ListBox ProjectListBox;
    }
}