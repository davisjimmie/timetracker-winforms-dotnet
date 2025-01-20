using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTracker.Application.Interfaces.UseCases;
using TimeTracker.Application.UseCases;
using TimeTracker.Presentation.Components;

namespace TimeTracker.Presentation.Forms
{
    public partial class NewProjectForm : Form
    {
        private readonly NewProjectComponent _component;
        private readonly IAddProjectUseCase _addProjectUseCase;

        public NewProjectForm()
        {
            InitializeComponent();
            _addProjectUseCase = new AddProjectUseCase(); 
            _component = new NewProjectComponent(ProjectNameTextBox, ProjectDescriptionTextBox, ProjectRateTextBox, _addProjectUseCase);
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
            _component.AddProject();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
