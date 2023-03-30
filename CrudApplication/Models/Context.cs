using Microsoft.EntityFrameworkCore;

namespace CrudApplication.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options):base(options) 
        { 
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
