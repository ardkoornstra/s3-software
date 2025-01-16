using LatijnLogic.Types;
using LatijnLogic.Interfaces;

namespace LatijnLogic.Services
{
    public class WerkwoordenLogic : IWerkwoordenLogic
    {
        private readonly IWerkwoordenData _data;

        public WerkwoordenLogic(IWerkwoordenData data)
        {
            _data = data;
        }

        public async Task<List<Werkwoord>> GetAllWerkwoorden()
        {
            return await _data.GetAllWerkwoorden();
        }
    }
}
