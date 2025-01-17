using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.Domain.ValueObjects
{
    internal class Task
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public List<string> Status { get; private set; }
        public TimeOnly Time {  get; private set; }

        public Task(int id, string name, string description, List<string> status, TimeOnly time)
        {
            Id = id;
            Name = name;
            Description = description;
            Status = status;
            Time = time;
        }
    }
}