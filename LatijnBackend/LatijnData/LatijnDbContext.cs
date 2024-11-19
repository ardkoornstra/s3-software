using Microsoft.EntityFrameworkCore;

namespace LatijnData
{
    public class LatijnDbContext : DbContext
    {
        public LatijnDbContext(DbContextOptions<LatijnDbContext> options) : base(options) { }
        public DbSet<Werkwoord> Werkwoorden { get; set; }
    }
}
