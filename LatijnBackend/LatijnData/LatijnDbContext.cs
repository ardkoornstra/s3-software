using Microsoft.EntityFrameworkCore;
using LatijnData.Models;


namespace LatijnData
{
    public class LatijnDbContext : DbContext
    {
        public LatijnDbContext(DbContextOptions<LatijnDbContext> options) : base(options) { }

        public DbSet<WerkwoordEF> Werkwoorden { get; set; }
    }
}
