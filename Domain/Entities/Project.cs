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
        public int ProjectId { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int RatePerHour { get; private set; }
        public TimeSpan TotalTime => CalculateTotalTime();
        public double TotalCost => CalculateTotalCost();
        public Status ProjectStatus { get; private set; }
        public ICollection<Task> Tasks { get; private set; }

        public Project(int projectId, string name, string description, int ratePerHour, TimeSpan totalTime)
        {
            ProjectId = projectId;
            Name = name;
            Description = description;
            RatePerHour = ratePerHour;
            TotalTime = CalculateTotalTime();
            ProjectStatus = Status.Planned;
        }

        TimeSpan CalculateTotalTime()
        {
            if (Tasks.Count > 0)
            {
                return Tasks.Aggregate(TimeSpan.Zero, (sum, task) => sum.Add(task.TotalTime));
            }
            else
            {
                return TimeSpan.Zero;
            }
        }

        double CalculateTotalCost()
        {
            int rateInSeconds = RatePerHour / 3600;
            double timeInSeconds = TotalTime.TotalSeconds;
            return rateInSeconds * timeInSeconds;
        }
    }

        //temp
        public override string ToString()
        {
            return $"Name: {Name}\nDescription: {Description}\nRate Per Hour: {RatePerHour}";
        }
    }
}
