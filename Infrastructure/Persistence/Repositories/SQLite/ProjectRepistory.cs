using Dapper;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Application.Interfaces.Repositories.Entities;
using TimeTracker.Infrastructure.Persistence.Model.Entities;

namespace TimeTracker.Infrastructure.Persistence.Repositories.SQLite
{
    internal class ProjectRepistory : IProjectRepository
    {
        private readonly string _connectionString;

        public ProjectRepistory(string connectionString)
        {
            _connectionString = connectionString;
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            using var connection = new SqliteConnection(_connectionString);
            var command = connection.CreateCommand();
            command.CommandText = @" 
                CREATE TABLE IF NOT EXISTS Projects (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT, 
                    Name TEXT NOT NULL,
                    Description TEXT NOT NULL,
                    Rate INTEGER NOT NULL,
                    Time TEXT NOT NULL,
                    Cost DOUBLE NOT NULL,
                    Status TEXT NOT NULL,
                );";
            command.ExecuteNonQuery();
        }

        public async Task<List<Project>> GetAllAsync()
        {
            using var connection = new SqliteConnection(_connectionString);
            return (await connection.QueryAsync<Project>("SELECT * FROM Projects")).AsList();
        }
    }
}
