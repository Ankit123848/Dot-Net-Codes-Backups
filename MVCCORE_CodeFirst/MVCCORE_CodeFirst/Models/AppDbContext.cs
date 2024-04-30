using Microsoft.EntityFrameworkCore;

namespace MVCCORE_CodeFirst.Models
{

        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {

            }



            public DbSet<Employee> Employees { get; set; }
            public DbSet<Department> Departments { get; set; }

        }
}
