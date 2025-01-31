using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTracker.Application.Interfaces.UseCases;
using TimeTracker.Application.UseCases;
using TimeTracker.Presentation.Components;

namespace TimeTracker
{
    public partial class NewProjectControl : UserControl
    {
        private readonly NewProjectComponent _component;
        private readonly IAddProjectUseCase _addProjectUseCase;

        public NewProjectControl()
        {
            InitializeComponent();
            _addProjectUseCase = new AddProjectUseCase();
            _component = new NewProjectComponent(NameTextBox, DescriptionTextBox, RateTextBox, _addProjectUseCase);
        }

        private void AddProjectButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Project Button Clicked");
            _component.AddProject();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Back Button Clicked");
            if (this.Parent is Panel MainPanel)
            {
                MainPanel.Controls.Clear();
                MainPanel.Controls.Add(new StartControl());
            }

        }

        private void DescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void RateTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
