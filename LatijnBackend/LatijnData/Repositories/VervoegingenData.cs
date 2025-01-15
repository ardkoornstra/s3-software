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

        public async Task<List<Vervoeging>> GetVervoegingenByToetsID(int toetsId)
        {
            List<VervoegingEF> vervoegingenEF = await _dbContext.Vervoegingen.Where(v => v.ToetsId == toetsId).ToListAsync();
            List<Vervoeging> vervoegingen = _mapper.Map<List<Vervoeging>>(vervoegingenEF);
            return vervoegingen;
        }

        public async Task<bool> CreateVervoegingen(List<Vervoeging> vervoegingen)
        {
            List<VervoegingEF> vervoegingenEF = _mapper.Map<List<VervoegingEF>>(vervoegingen);
            _dbContext.Vervoegingen.AddRange(vervoegingenEF);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
