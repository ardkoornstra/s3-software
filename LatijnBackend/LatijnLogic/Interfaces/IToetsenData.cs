using LatijnLogic.DTOs;
using LatijnLogic.Types;

namespace LatijnLogic.Interfaces
{
    public interface IToetsenData
    {
        public Task<List<Toets>> GetAllToetsen();
        public Task<ToetsDTO> GetToets(int id);
        public Task<int> CreateToets(ToetsDTO toetsDTO);
    }
}
