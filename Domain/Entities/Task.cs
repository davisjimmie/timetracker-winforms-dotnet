using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Domain.Common.Enums;

namespace TimeTracker.Domain.Entities
{
    internal class Task
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public TimeSpan LoggedTime { get; private set; }
        public TimeSpan EstimatedTime { get; private set; }
        public Status TaskStatus { get; private set; }

        public Task(int id, string name, string description, TimeSpan loggedTime, TimeSpan estimatedTime, Status taskStatus)
        {
            Id = id;
            Name = name;
            Description = description;
            LoggedTime = loggedTime;
            EstimatedTime = estimatedTime;
            TaskStatus = taskStatus;
        }

        public TimeSpan GetLoggedTime(int hours, int minutes, Nullable<int> seconds)
        {
            LoggedTime = new TimeSpan(hours, minutes, (int)seconds);
            return LoggedTime;
        }

        public TimeSpan GetEstimatedTime(int hours, int minutes, Nullable<int> seconds)
        {
            EstimatedTime = new TimeSpan(hours, minutes, (int)seconds);
            return EstimatedTime;
        }
    }
}