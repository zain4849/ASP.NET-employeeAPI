using EmployeesAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace EmployeesAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            try
            {
                var dbcreator = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;
                if (dbcreator != null)
                {
                    if (!dbcreator.CanConnect())
                    {
                        dbcreator.Create();
                    }
                    if (!dbcreator.HasTables())
                    {
                        dbcreator.CreateTables();
                    }

                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
