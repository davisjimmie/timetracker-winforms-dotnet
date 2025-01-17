using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Domain.Entities;
namespace TimeTracker.Presentation.Components
{
    internal class ProjectComponent
    {
        private readonly TextBox _projectName;
        private readonly TextBox _taskName;
        private readonly TextBox _taskDescription;
        private readonly TextBox _taskStatus;
        private readonly ListBox _projectListBox;

        public ProjectComponent(TextBox projectName, TextBox taskName, TextBox taskDescription,  TextBox taskStatus, ListBox projectListBox)
        {
            _projectName = projectName;
            _taskName = taskName;
            _taskDescription = taskDescription;
            _taskStatus = taskStatus;
            _projectListBox = projectListBox;
        }


        public Project CreateProject()
        {
            Project myProject = new Project(1, _projectName.Text, null, 0m);
            _projectListBox.Items.Add(myProject);
            return myProject;
        }




    }
}
