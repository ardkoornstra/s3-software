using Microsoft.EntityFrameworkCore;
using LatijnData.Models;
using CsvHelper;
using System.Globalization;
using LatijnData.SeedData;

namespace LatijnData
{
    public class LatijnDbContext : DbContext
    {
        public LatijnDbContext(DbContextOptions<LatijnDbContext> options) : base(options) {
            SeedWerkwoorden();
        }

        public void SeedWerkwoorden()
        {
            if (Werkwoorden.Any()) { return; }

            List<WerkwoordEF> seedList;
            using (var reader = new StreamReader("SeedData\\Werkwoorden.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<WerkwoordMap>();
                var seedData = csv.GetRecords<WerkwoordEF>();
                seedList = seedData.ToList();
            }
            Werkwoorden.AddRange(seedList);
            SaveChanges();            
        }

        public void SeedVervoegingen()
        {

        }

        public DbSet<WerkwoordEF> Werkwoorden { get; set; }
        public DbSet<VervoegingEF> Vervoegingen { get; set; }
    }
}
