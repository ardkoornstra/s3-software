using LatijnLogic.Types;

namespace LatijnLogic.Interfaces
{
    public interface IWerkwoordenData
    {
        public Task<List<Werkwoord>> GetAllWerkwoorden();

        public Task<List<Werkwoord>> GetWerkwoorden(List<int> werkwoordenIDs);
    }
}
