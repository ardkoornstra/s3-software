using LatijnLogic.DTOs;
using LatijnLogic.Interfaces;

namespace LatijnLogic.Services
{
    public class ToetsenLogic : IToetsenLogic
    {
        private readonly IToetsenData _data;
        private readonly IVervoegingenLogic _vervoegingen;

        public ToetsenLogic(IToetsenData data, IVervoegingenLogic vervoegingen)
        {
            _data = data;
            _vervoegingen = vervoegingen;
        }

        public async Task<int> CreateToets(ToetsDTO toetsDTO)
        {
            int toetsId = await _data.CreateToets(toetsDTO);
            await _vervoegingen.CreateVervoegingen(toetsDTO.AantalVragen, toetsId);
            return toetsId;
        }
    }
}
