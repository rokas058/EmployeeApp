using EmployeeApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApp.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = Environment.GetEnvironmentVariable("connectionString");

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new Exception("Environment variable 'connectionString' not found!");
            }

            optionsBuilder.UseNpgsql(connectionString);
        }
    }
}
