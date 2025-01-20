namespace TimeTracker.Presentation.Forms
{
    partial class StartForm
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
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            NewProjectButton = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.AutoSize = true;
            button2.BackColor = Color.RosyBrown;
            button2.FlatStyle = FlatStyle.System;
            button2.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(387, 259);
            button2.Name = "button2";
            button2.Size = new Size(158, 42);
            button2.TabIndex = 1;
            button2.Text = " Load Project 🔃";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 45F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(221, 120);
            label1.Name = "label1";
            label1.Size = new Size(342, 73);
            label1.TabIndex = 2;
            label1.Text = "Time Tracker";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(223, 193);
            label2.Name = "label2";
            label2.Size = new Size(335, 24);
            label2.TabIndex = 3;
            label2.Text = "Helping you keep track of your Projects";
            // 
            // NewProjectButton
            // 
            NewProjectButton.Anchor = AnchorStyles.None;
            NewProjectButton.AutoSize = true;
            NewProjectButton.BackColor = Color.RosyBrown;
            NewProjectButton.FlatStyle = FlatStyle.System;
            NewProjectButton.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NewProjectButton.Location = new Point(231, 259);
            NewProjectButton.Name = "NewProjectButton";
            NewProjectButton.Size = new Size(150, 42);
            NewProjectButton.TabIndex = 4;
            NewProjectButton.Text = "New Project 🆕";
            NewProjectButton.UseVisualStyleBackColor = false;
            NewProjectButton.Click += NewProjectButton_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(778, 491);
            Controls.Add(NewProjectButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "StartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StartScreen";
            Load += StartScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Label label1;
        private Label label2;
        private Button NewProjectButton;
    }
}