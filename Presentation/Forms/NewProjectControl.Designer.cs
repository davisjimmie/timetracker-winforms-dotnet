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
            TableLayoutPanel.BackColor = Color.White;
            TableLayoutPanel.ColumnCount = 3;
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 501F));
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 145F));
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TableLayoutPanel.Controls.Add(InputPanel, 1, 1);
            TableLayoutPanel.Controls.Add(DescriptionPanel, 1, 2);
            TableLayoutPanel.Controls.Add(ButtonPanel, 1, 3);
            TableLayoutPanel.Dock = DockStyle.Fill;
            TableLayoutPanel.Location = new Point(0, 0);
            TableLayoutPanel.Name = "TableLayoutPanel";
            TableLayoutPanel.RowCount = 5;
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 36.7647057F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 63.2352943F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 239F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 87F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 71F));
            TableLayoutPanel.Size = new Size(800, 530);
            TableLayoutPanel.TabIndex = 0;
            // 
            // InputPanel
            // 
            InputPanel.Controls.Add(RateLabel);
            InputPanel.Controls.Add(NameTextBox);
            InputPanel.Controls.Add(RateTextBox);
            InputPanel.Controls.Add(NameLabel);
            InputPanel.Location = new Point(157, 51);
            InputPanel.Name = "InputPanel";
            InputPanel.Size = new Size(495, 78);
            InputPanel.TabIndex = 0;
            // 
            // RateLabel
            // 
            RateLabel.AutoSize = true;
            RateLabel.Font = new Font("Calibri", 17F, FontStyle.Regular, GraphicsUnit.Point);
            RateLabel.Location = new Point(312, 14);
            RateLabel.Name = "RateLabel";
            RateLabel.Size = new Size(54, 28);
            RateLabel.TabIndex = 16;
            RateLabel.Text = "Rate";
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = Color.White;
            NameTextBox.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point);
            NameTextBox.Location = new Point(38, 45);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PlaceholderText = "Project Name";
            NameTextBox.Size = new Size(148, 30);
            NameTextBox.TabIndex = 11;
            // 
            // RateTextBox
            // 
            RateTextBox.BackColor = Color.White;
            RateTextBox.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point);
            RateTextBox.Location = new Point(312, 45);
            RateTextBox.Name = "RateTextBox";
            RateTextBox.PlaceholderText = "Hourly Rate";
            RateTextBox.Size = new Size(148, 30);
            RateTextBox.TabIndex = 15;
            RateTextBox.TextChanged += RateTextBox_TextChanged;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.BackColor = Color.Transparent;
            NameLabel.Font = new Font("Calibri", 17F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabel.Location = new Point(38, 14);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(67, 28);
            NameLabel.TabIndex = 13;
            NameLabel.Text = "Name";
            // 
            // DescriptionPanel
            // 
            DescriptionPanel.Controls.Add(DescriptionTextBox);
            DescriptionPanel.Controls.Add(DescriptionLabel);
            DescriptionPanel.Location = new Point(157, 135);
            DescriptionPanel.Name = "DescriptionPanel";
            DescriptionPanel.Size = new Size(495, 229);
            DescriptionPanel.TabIndex = 1;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.BackColor = Color.White;
            DescriptionTextBox.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionTextBox.Location = new Point(38, 45);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.PlaceholderText = "Project Description";
            DescriptionTextBox.Size = new Size(422, 179);
            DescriptionTextBox.TabIndex = 12;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Calibri", 17F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionLabel.Location = new Point(38, 14);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(118, 28);
            DescriptionLabel.TabIndex = 14;
            DescriptionLabel.Text = "Description";
            DescriptionLabel.Click += DescriptionLabel_Click;
            // 
            // ButtonPanel
            // 
            ButtonPanel.Controls.Add(BackButton);
            ButtonPanel.Controls.Add(AddButton);
            ButtonPanel.Location = new Point(157, 374);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(495, 65);
            ButtonPanel.TabIndex = 2;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.RosyBrown;
            BackButton.FlatStyle = FlatStyle.System;
            BackButton.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BackButton.Location = new Point(38, 21);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(151, 41);
            BackButton.TabIndex = 18;
            BackButton.Text = "🏠 Go Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.RosyBrown;
            AddButton.FlatStyle = FlatStyle.System;
            AddButton.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.Location = new Point(309, 21);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(151, 41);
            AddButton.TabIndex = 17;
            AddButton.Text = "  Add Project ➡️  ";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddProjectButton_Click;
            // 
            // NewProjectControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableLayoutPanel);
            Name = "NewProjectControl";
            Size = new Size(800, 530);
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
