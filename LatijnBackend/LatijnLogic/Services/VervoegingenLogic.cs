using LatijnLogic.Types;
using LatijnLogic.Interfaces;

namespace LatijnLogic.Services
{
    public class VervoegingenLogic : IVervoegingenLogic
    {
        private readonly IVervoegingenData _data;

        public VervoegingenLogic(IVervoegingenData data)
        {
            _data = data;
        }

        public async Task<List<Vervoeging>> GetAllVervoegingen()
        {
            return await _data.GetAllVervoegingen();
        }
    }
}
