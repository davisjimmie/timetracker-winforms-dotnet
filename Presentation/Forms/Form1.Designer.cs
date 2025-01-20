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
            button1 = new Button();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.Anchor = AnchorStyles.None;
            StartButton.AutoSize = true;
            StartButton.BackColor = SystemColors.HotTrack;
            StartButton.FlatAppearance.BorderSize = 0;
            StartButton.FlatStyle = FlatStyle.System;
            StartButton.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            StartButton.ForeColor = Color.Transparent;
            StartButton.Location = new Point(275, 204);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(120, 42);
            StartButton.TabIndex = 0;
            StartButton.Text = "▶️ Start";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += startTimeButton_Click;
            // 
            // StopButton
            // 
            StopButton.Anchor = AnchorStyles.None;
            StopButton.AutoSize = true;
            StopButton.BackColor = Color.Firebrick;
            StopButton.FlatAppearance.BorderColor = Color.Red;
            StopButton.FlatAppearance.BorderSize = 0;
            StopButton.FlatStyle = FlatStyle.System;
            StopButton.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            StopButton.ForeColor = SystemColors.ButtonHighlight;
            StopButton.Location = new Point(413, 204);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(120, 42);
            StopButton.TabIndex = 1;
            StopButton.Text = "⏹️ Stop";
            StopButton.UseVisualStyleBackColor = false;
            StopButton.Click += stopTimeButton_Click;
            // 
            // TimeDisplay
            // 
            TimeDisplay.Anchor = AnchorStyles.None;
            TimeDisplay.AutoSize = true;
            TimeDisplay.BackColor = SystemColors.ControlLightLight;
            TimeDisplay.FlatStyle = FlatStyle.Flat;
            TimeDisplay.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            TimeDisplay.Location = new Point(243, 99);
            TimeDisplay.Name = "TimeDisplay";
            TimeDisplay.Padding = new Padding(15);
            TimeDisplay.Size = new Size(328, 102);
            TimeDisplay.TabIndex = 2;
            TimeDisplay.Text = "00:00:00.00";
            TimeDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.AutoSize = true;
            button1.BackColor = Color.RosyBrown;
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(275, 252);
            button1.Name = "button1";
            button1.Size = new Size(258, 42);
            button1.TabIndex = 11;
            button1.Text = "🔃 Save Time";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(804, 461);
            Controls.Add(button1);
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
        private Button button1;
    }
}