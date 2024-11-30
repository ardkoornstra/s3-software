using AutoMapper;
using LatijnData.Models;
using LatijnLogic.Interfaces;
using LatijnLogic.Types;
using Microsoft.EntityFrameworkCore;

namespace LatijnData.Repositories
{
    public class UitgangenData : IUitgangenData
    {
        private readonly LatijnDbContext _dbContext;
        private readonly IMapper _mapper;

        public UitgangenData(LatijnDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<Uitgang>> GetAllUitgangen()
        {
            List<UitgangEF> UitgangenEF = await _dbContext.Uitgangen.ToListAsync();
            List<Uitgang> Uitgangen = _mapper.Map<List<Uitgang>>(UitgangenEF);
            return Uitgangen;
        }
    }
}
