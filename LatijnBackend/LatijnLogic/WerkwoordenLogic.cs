using LatijnLogic.Types;
using LatijnData;
using AutoMapper;
using LatijnData.Models;

namespace LatijnLogic
{
    public class WerkwoordenLogic : IWerkwoordenLogic
    {
        private readonly IWerkwoordenData _dataAccess;
        private readonly IMapper _mapper;

        public WerkwoordenLogic(IWerkwoordenData dataAccess, IMapper mapper)
        {
            _dataAccess = dataAccess;
            _mapper = mapper;
        }

        public async Task<List<Werkwoord>> GetAllWerkwoorden()
        {
            List<WerkwoordEF> werkwoordenEF = await _dataAccess.GetAllWerkwoorden();
            List<Werkwoord> werkwoorden = _mapper.Map<List<Werkwoord>>(werkwoordenEF);
            return werkwoorden;
        }
    }
}
