using Microsoft.EntityFrameworkCore;

namespace ReflectedXss.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> context) : base(context) { }

        public DbSet<Employee> Employees { get; set; }
    }
}