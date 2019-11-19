using Microsoft.EntityFrameworkCore;

namespace CopAPI.Models
{
    public class movie_castContext : DbContext
    {
         public movie_castContext(DbContextOptions<movie_castContext> options) 
        : base (options) 
        {

        }
        public DbSet<movie_cast> movie_casts { get; set; }
    }
}