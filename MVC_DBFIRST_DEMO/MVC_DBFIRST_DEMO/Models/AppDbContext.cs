using Microsoft.EntityFrameworkCore;
namespace MVC_DBFIRST_DEMO.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)

        {


        }
       public DbSet<Products>Product{ get; set; }



       }
}