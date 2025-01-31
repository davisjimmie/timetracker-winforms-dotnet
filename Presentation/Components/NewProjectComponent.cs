using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Application.DTOs;
using TimeTracker.Application.UseCases;
using TimeTracker.Application.Interfaces.UseCases;
using TimeTracker.Application.Mappers;
using TimeTracker.Domain.Entities;
using System.Windows.Forms;

namespace TimeTracker.Presentation.Components
{
    internal class NewProjectComponent
    {
        private readonly TextBox _projectName;
        private readonly TextBox _projectDescription;
        private readonly TextBox _projectRate;
        private readonly IAddProjectUseCase _addProjectUseCase;

        public NewProjectComponent(TextBox projectName, TextBox projectDescription, TextBox projectRate, IAddProjectUseCase addProjectUseCase)
        {
            _projectName = projectName;
            _projectDescription = projectDescription;
            _projectRate = projectRate;
            _addProjectUseCase = addProjectUseCase;
        }

        public void AddProject()
        {
            MessageBox.Show("ok");

            ProjectDTO projectDTO = new ProjectDTO
            {
                Name = _projectName.Text,
                Description = _projectDescription.Text,
                RatePerHour = int.Parse(_projectRate.Text)
            };


            Project project = new Project(
                projectDTO.Name,
                projectDTO.Description,
                projectDTO.RatePerHour
                );
            //temp code
            _projectDescription.Text = string.Empty;
            _projectDescription.Text = project.ToString();

            _addProjectUseCase.Execute(projectDTO);
        }
    }
}
