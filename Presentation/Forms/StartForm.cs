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
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {

        }

        private void NewProjectButton_Click(object sender, EventArgs e)
        {
            NewProjectForm newProjectForm = new NewProjectForm();


            newProjectForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
