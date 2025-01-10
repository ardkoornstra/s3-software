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
            SeedUitgangen();
        }

        public void SeedWerkwoorden()
        {
            if (Werkwoorden.Any()) { return; }

            List<WerkwoordEF> seedList;
            string file = Path.Combine(Directory.GetCurrentDirectory(), "SeedData", "Werkwoorden.csv");
            using (var reader = new StreamReader(file))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<WerkwoordMap>();
                var seedData = csv.GetRecords<WerkwoordEF>();
                seedList = seedData.ToList();
            }
            Werkwoorden.AddRange(seedList);
            SaveChanges();            
        }

        public void SeedUitgangen()
        {
            if (Uitgangen.Any()) { return; }

            List<UitgangEF> seedList;
            for (int i = 0; i<4; i++)
            {
                string file = Path.Combine(Directory.GetCurrentDirectory(), "SeedData", "Uitgangen" + (i + 1) + ".csv");
                using (var reader = new StreamReader(file))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csv.Context.RegisterClassMap<UitgangMap>();
                    var seedData = csv.GetRecords<UitgangEF>();
                    seedList = seedData.ToList();
                }
                Uitgangen.AddRange(seedList);
                SaveChanges();
            }
            
        }

        public DbSet<WerkwoordEF> Werkwoorden { get; set; }
        public DbSet<UitgangEF> Uitgangen { get; set; }
        public DbSet<VervoegingEF> Vervoegingen { get; set; }
    }
}
