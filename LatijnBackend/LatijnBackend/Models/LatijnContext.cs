using Microsoft.EntityFrameworkCore;

namespace LatijnBackend.Models
{
    public class LatijnContext : DbContext
    {
        public LatijnContext(DbContextOptions<LatijnContext> options) : base(options) { }
        public DbSet<Werkwoord> Werkwoorden { get; set; }
    }
}
