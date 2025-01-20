using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Application.DTOs;
using TimeTracker.Domain.Entities;

namespace TimeTracker.Application.Interfaces.UseCases
{
    internal interface IAddProjectUseCase
    {
        public void Execute(ProjectDTO projectDTO);
    }
}
