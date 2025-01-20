using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Domain.Common.Enums;

namespace TimeTracker.Domain.Entities
{
    internal class Project
    {
        private readonly List<Task> _tasks;

        public Guid Id { get; private set; }
        public string Name { get; private set; } 
        public string Description { get; private set; }
        public int RatePerHour { get; private set; }
        public TimeSpan TotalTime { get; private set; }
        public double TotalCost => RatePerHour * TotalTime.TotalHours;
        public Status ProjectStatus { get; private set; }

        public Project(string name, string description, int ratePerHour)
        {
            Id = Guid.NewGuid();
            _tasks = new List<Task>();
            Name = name;
            Description = description;
            RatePerHour = ratePerHour;
            TotalTime = TimeSpan.Zero;
            ProjectStatus = Status.Planned;
        }

        public void AddTask(Task task)
        {
            _tasks.Add(task);
            TotalTime += task.LoggedTime;
        }
    }
}
