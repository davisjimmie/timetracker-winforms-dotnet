using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.Infrastructure.Persistence.Database
{
    internal class SQLiteDbContext
    {
        private readonly string _databasePath;
        
        public SQLiteDbContext()
        {
            _databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "timetracker.db");
        }

        public string GetConnectionString()
        {
            return _databasePath;
        }

        public void InitalizeDatabase()
        {
            using var connection = new SqliteConnection(GetConnectionString());
            connection.Open();

            //Set up database tables

            string createProjectsTable = @"
                CREATE TABLE IF NOT EXISTS Projects (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT, 
                    Name TEXT NOT NULL,
                    Description TEXT NOT NULL,
                    Rate INTEGER NOT NULL,
                    Time TEXT NOT NULL,
                    Cost DOUBLE NOT NULL,
                    Status TEXT NOT NULL,
                );";

            string createTasksTable = @"
    

            ";
        }
    }
}
