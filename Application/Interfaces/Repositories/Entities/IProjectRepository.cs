using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Infrastructure.Persistence.Model.Entities;

namespace TimeTracker.Application.Interfaces.Repositories.Entities
{
    internal interface IProjectRepository
    {
        Task<List<Project>> GetAllAsync();
        Task<Project> GetByIdAsync(int id);
        Task<int> AddAsync(Project project);
        Task<int> UpdateAsync(Project project);
        Task<int> DeleteAsync(int id);
    }
}
