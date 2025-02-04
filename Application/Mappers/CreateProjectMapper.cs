using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Application.DTOs;
using TimeTracker.Domain.Entities;

namespace TimeTracker.Application.Mappers
{
    internal class CreateProjectMapper
    {
        public static Project MapToEntity(CreateProjectDTO createProjectDTO)
        {
            return new Project(
                createProjectDTO.Name,
                createProjectDTO.Description,
                createProjectDTO.RatePerHour
            );
        }
    }
}
