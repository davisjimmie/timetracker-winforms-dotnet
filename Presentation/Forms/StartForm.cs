using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTracker.Presentation.Forms
{
    public partial class StartForm : Form
    {
        private readonly NewProjectForm _newProjectForm;

        public StartForm()
        {
            InitializeComponent();
            _newProjectForm = new NewProjectForm();
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {

        }

        private void NewProjectButton_Click(object sender, EventArgs e)
        {
            _newProjectForm.Show();
        }

        private void LoadProjectButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Show Project List");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
