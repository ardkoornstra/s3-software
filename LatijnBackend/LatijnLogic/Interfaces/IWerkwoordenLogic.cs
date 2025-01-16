using LatijnLogic.Types;

namespace LatijnLogic.Interfaces
{
    public interface IWerkwoordenLogic
    {
        public Task<List<Werkwoord>> GetAllWerkwoorden();
    }
}
