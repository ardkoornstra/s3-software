using LatijnLogic.DTOs;
using LatijnLogic.Interfaces;

namespace LatijnLogic.Services
{
    public class ToetsenLogic : IToetsenLogic
    {
        private readonly IToetsenData _data;

        public ToetsenLogic(IToetsenData data)
        {
            _data = data;
        }

        public async Task<int> CreateToets(ToetsDTO toetsDTO)
        {
            return await _data.CreateToets(toetsDTO);
        }
    }
}
