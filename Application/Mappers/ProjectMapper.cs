using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Application.DTOs;
using TimeTracker.Domain.Entities;

namespace TimeTracker.Application.Mappers
{
    internal class ProjectMapper
    {
        public static Project MapToEntity(ProjectDTO projectDTO)
        {
            return new Project(
                projectDTO.Name,
                projectDTO.Description,
                projectDTO.RatePerHour
            );
        }
    }
}
