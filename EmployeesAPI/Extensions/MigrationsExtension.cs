using Microsoft.EntityFrameworkCore;
using EmployeesAPI.Data;

namespace EmployeesAPI.Extensions
{
    public static class MigrationsExtension
    {
        public static void AddMigrations(this IApplicationBuilder app)
        {
            using IServiceScope scope = app.ApplicationServices.CreateScope();
            using DataContext dbcontext = scope.ServiceProvider.GetRequiredService<DataContext>();

            dbcontext.Database.Migrate(); 
        }
    }
}
