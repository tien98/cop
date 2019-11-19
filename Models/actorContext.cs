using Microsoft.EntityFrameworkCore;

namespace CopAPI.Models
{
    public class actorContext : DbContext
    {
        public actorContext(DbContextOptions<actorContext> options) 
        : base (options) 
        {

        }
        public DbSet<actor> actors { get; set; }
    }
}