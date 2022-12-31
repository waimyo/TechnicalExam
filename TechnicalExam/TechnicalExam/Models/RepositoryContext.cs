using Microsoft.EntityFrameworkCore;

namespace TechnicalExam.Models
{
    public class RepositoryContext : DbContext
    {
        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext>)
        public RepositoryContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Inventory> Inventories { get; set; }
    }
}
