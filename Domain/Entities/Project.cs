using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.Domain.Entities
{
    internal class Project
    {
        // Field
        private readonly List<Task> _tasks;

        // Property
        public int Id { get; private set; }
        public string Name { get; private set; }
        public Decimal TotalTime { get; private set; }
    
        // Constructor
        public Project(int id, string name, List<Task> tasks, Decimal totalTime)
        {
            Id = id;
            Name = name;
            _tasks = tasks ?? new List<Task>();
            TotalTime = totalTime;
        }

        // Method
        public void AddTask(Task task)
        {
            _tasks.Add(task);
        }

        // Override ToString to display the project name or other relevant information
        public override string ToString()
        {
            return $"{Name} - Total Time: {TotalTime:C}"; // Example format
        }
    }
}
