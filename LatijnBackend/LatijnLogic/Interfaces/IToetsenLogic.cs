using LatijnLogic.DTOs;

namespace LatijnLogic.Interfaces
{
    public interface IToetsenLogic
    {
        public Task<int> CreateToets(ToetsDTO toetsDTO);
    }
}
