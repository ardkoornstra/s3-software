using LatijnData.Models;

namespace LatijnData
{
    public interface IWerkwoordenData
    {
        public Task<List<WerkwoordEF>> GetAllWerkwoorden();
    }
}
