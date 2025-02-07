using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Infrastructure.Persistence.Model.Common.Enums;

namespace TimeTracker.Infrastructure.Persistence.Model.Entities
{
    internal class Task
    {
        private readonly List<Task> _tasks;

        public int TaskId { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public TimeSpan TotalTime { get; private set; }
        public Status TaskStatus { get; private set; }

        // Foreign key to Data Project Entity
        public int ProjectId { get; private set; }

        public Project Project { get; private set; }
    }
}
