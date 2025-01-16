using AutoMapper;
using LatijnData.Models;
using LatijnLogic.DTOs;
using LatijnLogic.Interfaces;
using LatijnLogic.Types;
using Microsoft.EntityFrameworkCore;

namespace LatijnData.Repositories
{
    public class ToetsenData : IToetsenData
    {
        private readonly LatijnDbContext _dbContext;
        private readonly IMapper _mapper;

        public ToetsenData(LatijnDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<Toets>> GetAllToetsen()
        {
            List<ToetsEF> ToetsenEF = await _dbContext.Toetsen.ToListAsync();
            List<Toets> Toetsen = _mapper.Map<List<Toets>>(ToetsenEF);
            return Toetsen;
        }

        public async Task<ToetsDTO> GetToets(int id)
        {
            ToetsEF toetsEF = await _dbContext.Toetsen.FindAsync(id);
            ToetsDTO toetsDTO = _mapper.Map<ToetsDTO>(toetsEF);
            return toetsDTO;
        }

        public async Task<int> CreateToets(ToetsDTO toetsDTO)
        {
            ToetsEF toets = _mapper.Map<ToetsEF>(toetsDTO);
            _dbContext.Toetsen.Add(toets);
            await _dbContext.SaveChangesAsync();
            return toets.Id;
        }
    }
}
