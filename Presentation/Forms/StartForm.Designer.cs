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
            StartFormTLP = new TableLayoutPanel();
            label2 = new Label();
            panel1 = new Panel();
            LoadProjectButton = new Button();
            NewProjectButton = new Button();
            label1 = new Label();
            StartFormTLP.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // StartFormTLP
            // 
            StartFormTLP.ColumnCount = 3;
            StartFormTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9890785F));
            StartFormTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.48607F));
            StartFormTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.5248489F));
            StartFormTLP.Controls.Add(label2, 1, 2);
            StartFormTLP.Controls.Add(panel1, 1, 3);
            StartFormTLP.Controls.Add(label1, 1, 1);
            StartFormTLP.Cursor = Cursors.Hand;
            StartFormTLP.Location = new Point(12, 12);
            StartFormTLP.Name = "StartFormTLP";
            StartFormTLP.RowCount = 5;
            StartFormTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 28.69379F));
            StartFormTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 16.7023563F));
            StartFormTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 7.280514F));
            StartFormTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 14.7751608F));
            StartFormTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 33.19058F));
            StartFormTLP.Size = new Size(754, 467);
            StartFormTLP.TabIndex = 5;
            StartFormTLP.Paint += tableLayoutPanel1_Paint;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(210, 214);
            label2.Name = "label2";
            label2.Size = new Size(335, 24);
            label2.TabIndex = 7;
            label2.Text = "Helping you keep track of your Projects";
            // 
            // panel1
            // 
            panel1.Controls.Add(LoadProjectButton);
            panel1.Controls.Add(NewProjectButton);
            panel1.Location = new Point(153, 246);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 62);
            panel1.TabIndex = 10;
            // 
            // LoadProjectButton
            // 
            LoadProjectButton.Anchor = AnchorStyles.None;
            LoadProjectButton.AutoSize = true;
            LoadProjectButton.BackColor = Color.RosyBrown;
            LoadProjectButton.FlatStyle = FlatStyle.System;
            LoadProjectButton.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LoadProjectButton.Location = new Point(235, 12);
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
            NewProjectButton.Location = new Point(54, 12);
            NewProjectButton.Name = "NewProjectButton";
            NewProjectButton.Size = new Size(155, 42);
            NewProjectButton.TabIndex = 8;
            NewProjectButton.Text = " New Project 🆕";
            NewProjectButton.UseVisualStyleBackColor = false;
            NewProjectButton.Click += NewProjectButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 45F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(207, 135);
            label1.Name = "label1";
            label1.Size = new Size(342, 73);
            label1.TabIndex = 9;
            label1.Text = "Time Tracker";
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(778, 491);
            Controls.Add(StartFormTLP);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "StartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StartScreen";
            Load += StartScreen_Load;
            StartFormTLP.ResumeLayout(false);
            StartFormTLP.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private void NewProjectButton_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TableLayoutPanel StartFormTLP;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button LoadProjectButton;
        private Button NewProjectButton;
    }
}