namespace TimeTracker
{
    partial class HomeScreenUserControl
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
            HomeScreenTLP = new TableLayoutPanel();
            panel1 = new Panel();
            LoadProjectButton = new Button();
            NewProjectButton = new Button();
            label2 = new Label();
            label1 = new Label();
            HomeScreenTLP.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // HomeScreenTLP
            // 
            HomeScreenTLP.AutoSize = true;
            HomeScreenTLP.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            HomeScreenTLP.ColumnCount = 3;
            HomeScreenTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9890785F));
            HomeScreenTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.48607F));
            HomeScreenTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.5248489F));
            HomeScreenTLP.Controls.Add(panel1, 1, 3);
            HomeScreenTLP.Controls.Add(label2, 1, 2);
            HomeScreenTLP.Controls.Add(label1, 1, 1);
            HomeScreenTLP.Cursor = Cursors.Hand;
            HomeScreenTLP.Dock = DockStyle.Fill;
            HomeScreenTLP.Location = new Point(0, 0);
            HomeScreenTLP.Name = "HomeScreenTLP";
            HomeScreenTLP.RowCount = 5;
            HomeScreenTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 23.7735844F));
            HomeScreenTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 17.54717F));
            HomeScreenTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 7.35849047F));
            HomeScreenTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 12.45283F));
            HomeScreenTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 38.8679237F));
            HomeScreenTLP.Size = new Size(800, 530);
            HomeScreenTLP.TabIndex = 6;
            HomeScreenTLP.Paint += StartFormTLP_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(LoadProjectButton);
            panel1.Controls.Add(NewProjectButton);
            panel1.Location = new Point(162, 261);
            panel1.Name = "panel1";
            panel1.Size = new Size(475, 54);
            panel1.TabIndex = 10;
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
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(233, 226);
            label2.Name = "label2";
            label2.Size = new Size(335, 24);
            label2.TabIndex = 7;
            label2.Text = "Helping you keep track of your Projects";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 45F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(167, 140);
            label1.Name = "label1";
            label1.Size = new Size(466, 64);
            label1.TabIndex = 9;
            label1.Text = "Time Tracker";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // HomeScreenUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(HomeScreenTLP);
            Name = "HomeScreenUserControl";
            Size = new Size(800, 530);
            HomeScreenTLP.ResumeLayout(false);
            HomeScreenTLP.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel HomeScreenTLP;
        private Panel panel1;
        private Button LoadProjectButton;
        private Button NewProjectButton;
        private Label label2;
        private Label label1;
    }
}
