using LatijnLogic.DTOs;

namespace LatijnLogic.Interfaces
{
    public interface IToetsenLogic
    {
        public Task<ToetsDTO> GetToets(int id);
        public Task<int> CreateToets(ToetsDTO toetsDTO);        
    }
}
