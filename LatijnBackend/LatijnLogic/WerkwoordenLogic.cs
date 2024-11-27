using LatijnLogic.Types;
using LatijnLogic.Interfaces;

namespace LatijnLogic
{
    public class WerkwoordenLogic : IWerkwoordenLogic
    {
        private readonly IWerkwoordenData _dataAccess;

        public WerkwoordenLogic(IWerkwoordenData dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<List<Werkwoord>> GetAllWerkwoorden()
        {
            return await _dataAccess.GetAllWerkwoorden();
        }
    }
}
