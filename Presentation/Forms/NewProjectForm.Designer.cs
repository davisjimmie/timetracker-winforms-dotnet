namespace TimeTracker.Presentation.Forms
{
    partial class NewProjectForm
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
            ProjectDescriptionTextBox = new TextBox();
            ProjectNameTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ProjectRateTextBox = new TextBox();
            AddProjectButton = new Button();
            BackButton = new Button();
            SuspendLayout();
            // 
            // ProjectDescriptionTextBox
            // 
            ProjectDescriptionTextBox.BackColor = Color.White;
            ProjectDescriptionTextBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProjectDescriptionTextBox.Location = new Point(195, 182);
            ProjectDescriptionTextBox.Multiline = true;
            ProjectDescriptionTextBox.Name = "ProjectDescriptionTextBox";
            ProjectDescriptionTextBox.PlaceholderText = "Project Description";
            ProjectDescriptionTextBox.Size = new Size(437, 130);
            ProjectDescriptionTextBox.TabIndex = 3;
            // 
            // ProjectNameTextBox
            // 
            ProjectNameTextBox.BackColor = Color.White;
            ProjectNameTextBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProjectNameTextBox.Location = new Point(195, 101);
            ProjectNameTextBox.Name = "ProjectNameTextBox";
            ProjectNameTextBox.PlaceholderText = "Project Name";
            ProjectNameTextBox.Size = new Size(205, 27);
            ProjectNameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(195, 65);
            label1.Name = "label1";
            label1.Size = new Size(67, 28);
            label1.TabIndex = 4;
            label1.Text = "Name";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(195, 146);
            label2.Name = "label2";
            label2.Size = new Size(118, 28);
            label2.TabIndex = 5;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(427, 65);
            label3.Name = "label3";
            label3.Size = new Size(54, 28);
            label3.TabIndex = 7;
            label3.Text = "Rate";
            label3.Click += label3_Click;
            // 
            // ProjectRateTextBox
            // 
            ProjectRateTextBox.BackColor = Color.White;
            ProjectRateTextBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProjectRateTextBox.Location = new Point(427, 101);
            ProjectRateTextBox.Name = "ProjectRateTextBox";
            ProjectRateTextBox.PlaceholderText = "Hourly Rate";
            ProjectRateTextBox.Size = new Size(205, 27);
            ProjectRateTextBox.TabIndex = 6;
            ProjectRateTextBox.TextChanged += textBox3_TextChanged;
            // 
            // AddProjectButton
            // 
            AddProjectButton.BackColor = Color.RosyBrown;
            AddProjectButton.FlatStyle = FlatStyle.System;
            AddProjectButton.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AddProjectButton.Location = new Point(497, 346);
            AddProjectButton.Name = "AddProjectButton";
            AddProjectButton.Size = new Size(135, 42);
            AddProjectButton.TabIndex = 9;
            AddProjectButton.Text = " Add Project ➡️ ";
            AddProjectButton.UseVisualStyleBackColor = false;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.RosyBrown;
            BackButton.FlatStyle = FlatStyle.System;
            BackButton.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BackButton.Location = new Point(195, 346);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(135, 42);
            BackButton.TabIndex = 10;
            BackButton.Text = "🏠 Go Back";
            BackButton.UseVisualStyleBackColor = false;
            // 
            // NewProjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(804, 461);
            Controls.Add(BackButton);
            Controls.Add(AddProjectButton);
            Controls.Add(label3);
            Controls.Add(ProjectRateTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ProjectDescriptionTextBox);
            Controls.Add(ProjectNameTextBox);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewProjectForm";
            Text = "New Project";
            Load += NewProjectForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ProjectDescriptionTextBox;
        private TextBox ProjectNameTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox ProjectRateTextBox;
        private Button AddProjectButton;
        private Button BackButton;
    }
}