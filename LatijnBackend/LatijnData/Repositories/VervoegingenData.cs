using AutoMapper;
using LatijnData.Models;
using LatijnLogic.Interfaces;
using LatijnLogic.Types;
using Microsoft.EntityFrameworkCore;

namespace LatijnData.Repositories
{
    public class VervoegingenData : IVervoegingenData
    {
        private readonly LatijnDbContext _dbContext;
        private readonly IMapper _mapper;

        public VervoegingenData(LatijnDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<Vervoeging>> GetAllVervoegingen()
        {
            List<VervoegingEF> vervoegingenEF = await _dbContext.Vervoegingen.ToListAsync();
            List<Vervoeging> vervoegingen = _mapper.Map<List<Vervoeging>>(vervoegingenEF);
            return vervoegingen;
        }
    }
}
