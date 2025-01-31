namespace TimeTracker
{
    partial class StartControl
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
            SubTitleLabel = new Label();
            TitleLabel = new Label();
            ButtonPanel = new Panel();
            LoadProjectButton = new Button();
            NewProjectButton = new Button();
            TableLayoutPanel.SuspendLayout();
            ButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            TableLayoutPanel.AutoSize = true;
            TableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TableLayoutPanel.ColumnCount = 3;
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TableLayoutPanel.Controls.Add(SubTitleLabel, 1, 2);
            TableLayoutPanel.Controls.Add(TitleLabel, 1, 1);
            TableLayoutPanel.Controls.Add(ButtonPanel, 1, 3);
            TableLayoutPanel.Cursor = Cursors.Hand;
            TableLayoutPanel.Dock = DockStyle.Fill;
            TableLayoutPanel.Location = new Point(0, 0);
            TableLayoutPanel.Name = "TableLayoutPanel";
            TableLayoutPanel.RowCount = 5;
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 23.7735844F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 17.54717F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 7.35849047F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.45283F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 38.8679237F));
            TableLayoutPanel.Size = new Size(800, 530);
            TableLayoutPanel.TabIndex = 6;
            // 
            // SubTitleLabel
            // 
            SubTitleLabel.Anchor = AnchorStyles.None;
            SubTitleLabel.AutoSize = true;
            SubTitleLabel.BackColor = Color.Transparent;
            SubTitleLabel.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SubTitleLabel.ForeColor = Color.DimGray;
            SubTitleLabel.Location = new Point(232, 226);
            SubTitleLabel.Name = "SubTitleLabel";
            SubTitleLabel.Size = new Size(335, 24);
            SubTitleLabel.TabIndex = 7;
            SubTitleLabel.Text = "Helping you keep track of your Projects";
            // 
            // TitleLabel
            // 
            TitleLabel.Anchor = AnchorStyles.None;
            TitleLabel.BackColor = Color.Transparent;
            TitleLabel.Font = new Font("Calibri", 45F, FontStyle.Regular, GraphicsUnit.Point);
            TitleLabel.ForeColor = Color.Black;
            TitleLabel.Location = new Point(167, 140);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(466, 64);
            TitleLabel.TabIndex = 9;
            TitleLabel.Text = "Time Tracker";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ButtonPanel
            // 
            ButtonPanel.Controls.Add(LoadProjectButton);
            ButtonPanel.Controls.Add(NewProjectButton);
            ButtonPanel.Location = new Point(163, 261);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(474, 54);
            ButtonPanel.TabIndex = 10;
            // 
            // LoadProjectButton
            // 
            LoadProjectButton.Anchor = AnchorStyles.None;
            LoadProjectButton.AutoSize = true;
            LoadProjectButton.BackColor = Color.RosyBrown;
            LoadProjectButton.FlatStyle = FlatStyle.System;
            LoadProjectButton.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LoadProjectButton.Location = new Point(247, 6);
            LoadProjectButton.Name = "LoadProjectButton";
            LoadProjectButton.Size = new Size(158, 42);
            LoadProjectButton.TabIndex = 5;
            LoadProjectButton.Text = " Load Project 🔃";
            LoadProjectButton.UseVisualStyleBackColor = false;
            LoadProjectButton.Click += LoadProjectButton_Click;
            // 
            // NewProjectButton
            // 
            NewProjectButton.Anchor = AnchorStyles.None;
            NewProjectButton.AutoSize = true;
            NewProjectButton.BackColor = Color.RosyBrown;
            NewProjectButton.FlatStyle = FlatStyle.System;
            NewProjectButton.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NewProjectButton.Location = new Point(70, 6);
            NewProjectButton.Name = "NewProjectButton";
            NewProjectButton.Size = new Size(155, 42);
            NewProjectButton.TabIndex = 8;
            NewProjectButton.Text = " New Project 🆕";
            NewProjectButton.UseVisualStyleBackColor = false;
            NewProjectButton.Click += NewProjectButton_Click;
            // 
            // StartControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableLayoutPanel);
            Name = "StartControl";
            Size = new Size(800, 530);
            TableLayoutPanel.ResumeLayout(false);
            TableLayoutPanel.PerformLayout();
            ButtonPanel.ResumeLayout(false);
            ButtonPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel TableLayoutPanel;
        private Panel ButtonPanel;
        private Button LoadProjectButton;
        private Button NewProjectButton;
        private Label SubTitleLabel;
        private Label TitleLabel;
    }
}
