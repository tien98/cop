using Microsoft.EntityFrameworkCore;

namespace CopAPI.Models
{
    public class movieContext : DbContext
    {
        public movieContext(DbContextOptions<movieContext> options) 
        : base (options) 
        {

        }
        public DbSet<movie> movies { get; set; }
    }
}