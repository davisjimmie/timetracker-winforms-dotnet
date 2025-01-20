using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTracker.Presentation.Components;

namespace TimeTracker.Presentation.Forms
{
    public partial class NewProjectForm : Form
    {
        private NewProjectComponent _component;

        public NewProjectForm()
        {
            InitializeComponent();
        }

        private void NewProjectForm_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Works");
        }

        private void AddProjectButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Works");
            _component.AddProject();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
