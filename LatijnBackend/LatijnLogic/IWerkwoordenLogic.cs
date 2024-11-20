using LatijnLogic.Types;

namespace LatijnLogic
{
    public interface IWerkwoordenLogic
    {
        public Task<List<Werkwoord>> GetAllWerkwoorden();
    }
}
