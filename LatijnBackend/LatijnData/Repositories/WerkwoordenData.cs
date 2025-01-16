using AutoMapper;
using LatijnData.Models;
using LatijnLogic.Interfaces;
using LatijnLogic.Types;
using Microsoft.EntityFrameworkCore;

namespace LatijnData.Repositories
{
    public class WerkwoordenData : IWerkwoordenData
    {
        private readonly LatijnDbContext _dbContext;
        private readonly IMapper _mapper;

        public WerkwoordenData(LatijnDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<Werkwoord>> GetAllWerkwoorden()
        {
            List<WerkwoordEF> werkwoordenEF = await _dbContext.Werkwoorden.ToListAsync();
            List<Werkwoord> werkwoorden = _mapper.Map<List<Werkwoord>>(werkwoordenEF);
            return werkwoorden;
        }

        public async Task<List<Werkwoord>> GetWerkwoorden(List<int> werkwoordenIDs)
        {
            List<WerkwoordEF> werkwoordenEF = await _dbContext.Werkwoorden.Where(w => (werkwoordenIDs.Contains(w.WoordID))).ToListAsync();
            List<Werkwoord> werkwoorden = _mapper.Map<List<Werkwoord>>(werkwoordenEF);
            return werkwoorden;
        }
    }
}
