using CsvHelper;
using CsvHelper.Configuration;
using LatijnData.Models;
using System.Globalization;

namespace LatijnData.SeedData
{
    public sealed class WerkwoordMap : ClassMap<WerkwoordEF>
    {
        public WerkwoordMap()
        {
            AutoMap(CultureInfo.InvariantCulture);
            Map(m => m.WoordID).Ignore();
        }
    }

    public sealed class UitgangMap : ClassMap<UitgangEF>
    {
        public UitgangMap()
        {
            AutoMap(CultureInfo.InvariantCulture);
            Map(m => m.UitgangID).Ignore();
        }
    }
}
