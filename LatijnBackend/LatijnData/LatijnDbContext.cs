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
            SeedData();
        }

        public void SeedData()
        {
            if (Werkwoorden.Any()) { return; }

            List<WerkwoordEF> seedList;
            using (var reader = new StreamReader("C:\\Users\\Guildramon\\Documents\\GitHub\\s3-software\\LatijnBackend\\LatijnData\\SeedData\\Werkwoorden.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<WerkwoordMap>();
                var seedData = csv.GetRecords<WerkwoordEF>();
                seedList = seedData.ToList();
            }
            Werkwoorden.AddRange(seedList);
            SaveChanges();            
        }

        public DbSet<WerkwoordEF> Werkwoorden { get; set; }
    }
}
