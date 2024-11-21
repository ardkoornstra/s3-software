using LatijnData.Models;
using Microsoft.EntityFrameworkCore;

namespace LatijnData
{
    public class WerkwoordenData : IWerkwoordenData
    {
        private readonly LatijnDbContext _dbContext;

        public WerkwoordenData(LatijnDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<WerkwoordEF>> GetAllWerkwoorden()
        {
            return await _dbContext.Werkwoorden.ToListAsync();
        }
    }
}
