using LatijnLogic.Types;

namespace LatijnLogic.Interfaces
{
    public interface IWerkwoordenData
    {
        public Task<List<Werkwoord>> GetAllWerkwoorden();
    }
}
