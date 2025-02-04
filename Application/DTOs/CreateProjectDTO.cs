using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Domain.Entities;

namespace TimeTracker.Application.DTOs
{
    internal class CreateProjectDTO
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required int RatePerHour { get; set; }
    }
}
