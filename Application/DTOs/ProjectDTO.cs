using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Domain.Entities;

namespace TimeTracker.Application.DTOs
{
    internal class ProjectDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int RatePerHour { get; set; }
    }
}
