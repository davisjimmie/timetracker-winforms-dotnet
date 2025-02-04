﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Application.DTOs;
using TimeTracker.Application.Interfaces.UseCases;
using TimeTracker.Application.Mappers;
using TimeTracker.Domain.Entities;

namespace TimeTracker.Application.UseCases
{
    internal class AddProjectUseCase : IAddProjectUseCase
    {
        // Repository Fields

        // Repository Constructor

        // Method
        
        public void Execute(ProjectDTO projectDTO)
        {
            Project project = CreateProjectMapper.MapToEntity(projectDTO);
            // save logic below
        }
    }
}
