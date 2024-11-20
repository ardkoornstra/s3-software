using LatijnLogic.Types;
using LatijnData;

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
            List<Werkwoord> werkwoorden = await (Werkwoord)_dataAccess.GetAllWerkwoorden();
            return werkwoorden;
        }
    }
}
