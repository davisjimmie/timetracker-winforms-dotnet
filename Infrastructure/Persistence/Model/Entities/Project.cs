using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Infrastructure.Persistence.Model.Common.Enums;

namespace TimeTracker.Infrastructure.Persistence.Model.Entities
{
    internal class Project
    {
        public int ProjectId { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int RatePerHour { get; private set; }
        public TimeSpan TotalTime => CalculateTotalTime();
        public double TotalCost => CalculateTotalCost();
        public string ProjectStatus { get; private set; }
        public ICollection<Task> Tasks { get; private set; } = new List<Task>();


}
