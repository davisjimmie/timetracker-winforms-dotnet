namespace TimeTracker
{
    partial class NewProjectControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TableLayoutPanel = new TableLayoutPanel();
            InputPanel = new Panel();
            RateLabel = new Label();
            NameTextBox = new TextBox();
            RateTextBox = new TextBox();
            NameLabel = new Label();
            DescriptionPanel = new Panel();
            DescriptionTextBox = new TextBox();
            DescriptionLabel = new Label();
            ButtonPanel = new Panel();
            BackButton = new Button();
            AddButton = new Button();
            TableLayoutPanel.SuspendLayout();
            InputPanel.SuspendLayout();
            DescriptionPanel.SuspendLayout();
            ButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            TableLayoutPanel.BackColor = Color.WhiteSmoke;
            TableLayoutPanel.ColumnCount = 3;
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TableLayoutPanel.Controls.Add(InputPanel, 1, 1);
            TableLayoutPanel.Controls.Add(DescriptionPanel, 1, 2);
            TableLayoutPanel.Controls.Add(ButtonPanel, 1, 3);
            TableLayoutPanel.Dock = DockStyle.Fill;
            TableLayoutPanel.Location = new Point(0, 0);
            TableLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            TableLayoutPanel.Name = "TableLayoutPanel";
            TableLayoutPanel.RowCount = 5;
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 49.4444427F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50.5555573F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 315F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 116F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 95F));
            TableLayoutPanel.Size = new Size(914, 707);
            TableLayoutPanel.TabIndex = 0;
            // 
            // InputPanel
            // 
            InputPanel.Controls.Add(RateLabel);
            InputPanel.Controls.Add(NameTextBox);
            InputPanel.Controls.Add(RateTextBox);
            InputPanel.Controls.Add(NameLabel);
            InputPanel.Location = new Point(185, 93);
            InputPanel.Margin = new Padding(3, 4, 3, 4);
            InputPanel.Name = "InputPanel";
            InputPanel.Size = new Size(542, 83);
            InputPanel.TabIndex = 0;
            // 
            // RateLabel
            // 
            RateLabel.AutoSize = true;
            RateLabel.Font = new Font("Calibri", 17F, FontStyle.Regular, GraphicsUnit.Point);
            RateLabel.Location = new Point(356, 9);
            RateLabel.Name = "RateLabel";
            RateLabel.Size = new Size(69, 36);
            RateLabel.TabIndex = 16;
            RateLabel.Text = "Rate";
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = Color.White;
            NameTextBox.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            NameTextBox.Location = new Point(43, 49);
            NameTextBox.Margin = new Padding(3, 4, 3, 4);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PlaceholderText = "Project Name";
            NameTextBox.Size = new Size(169, 30);
            NameTextBox.TabIndex = 11;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // RateTextBox
            // 
            RateTextBox.BackColor = Color.White;
            RateTextBox.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            RateTextBox.Location = new Point(356, 49);
            RateTextBox.Margin = new Padding(3, 4, 3, 4);
            RateTextBox.Name = "RateTextBox";
            RateTextBox.PlaceholderText = "Hourly Rate";
            RateTextBox.Size = new Size(169, 30);
            RateTextBox.TabIndex = 15;
            RateTextBox.TextChanged += RateTextBox_TextChanged;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.BackColor = Color.Transparent;
            NameLabel.Font = new Font("Calibri", 17F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabel.Location = new Point(43, 9);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(85, 36);
            NameLabel.TabIndex = 13;
            NameLabel.Text = "Name";
            // 
            // DescriptionPanel
            // 
            DescriptionPanel.Controls.Add(DescriptionTextBox);
            DescriptionPanel.Controls.Add(DescriptionLabel);
            DescriptionPanel.Location = new Point(185, 184);
            DescriptionPanel.Margin = new Padding(3, 4, 3, 4);
            DescriptionPanel.Name = "DescriptionPanel";
            DescriptionPanel.Size = new Size(542, 305);
            DescriptionPanel.TabIndex = 1;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.BackColor = Color.White;
            DescriptionTextBox.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionTextBox.Location = new Point(44, 49);
            DescriptionTextBox.Margin = new Padding(3, 4, 3, 4);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.PlaceholderText = "Project Description";
            DescriptionTextBox.Size = new Size(482, 237);
            DescriptionTextBox.TabIndex = 12;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Calibri", 17F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionLabel.Location = new Point(43, 9);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(148, 36);
            DescriptionLabel.TabIndex = 14;
            DescriptionLabel.Text = "Description";
            DescriptionLabel.Click += DescriptionLabel_Click;
            // 
            // ButtonPanel
            // 
            ButtonPanel.Controls.Add(BackButton);
            ButtonPanel.Controls.Add(AddButton);
            ButtonPanel.Location = new Point(185, 499);
            ButtonPanel.Margin = new Padding(3, 4, 3, 4);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(542, 87);
            ButtonPanel.TabIndex = 2;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.RosyBrown;
            BackButton.FlatStyle = FlatStyle.System;
            BackButton.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BackButton.Location = new Point(43, 4);
            BackButton.Margin = new Padding(3, 4, 3, 4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(175, 50);
            BackButton.TabIndex = 18;
            BackButton.Text = "Go Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.RosyBrown;
            AddButton.FlatStyle = FlatStyle.System;
            AddButton.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.Location = new Point(350, 4);
            AddButton.Margin = new Padding(3, 4, 3, 4);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(175, 50);
            AddButton.TabIndex = 17;
            AddButton.Text = "Add Project  ";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddProjectButton_Click;
            // 
            // NewProjectControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableLayoutPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "NewProjectControl";
            Size = new Size(914, 707);
            TableLayoutPanel.ResumeLayout(false);
            InputPanel.ResumeLayout(false);
            InputPanel.PerformLayout();
            DescriptionPanel.ResumeLayout(false);
            DescriptionPanel.PerformLayout();
            ButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableLayoutPanel;
        private Panel InputPanel;
        private Panel DescriptionPanel;
        private Panel ButtonPanel;
        private Button BackButton;
        private Button AddButton;
        private Label RateLabel;
        private TextBox RateTextBox;
        private Label DescriptionLabel;
        private Label NameLabel;
        private TextBox NameTextBox;
        private TextBox DescriptionTextBox;
    }
}
